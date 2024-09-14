Public Class T_ViewAssessment
    Property controller As AppController
    Property canEdit As Boolean
    Sub New(controller_ As AppController)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        controller = controller_
    End Sub

#Region "Form"
    Private Sub ViewAssessment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' set colours
        Me.BackColor = Color.White

        titleLbl.ForeColor = Color.Black

        QuestionsListbox.BackColor = Color.GhostWhite

        DeleteBtn.BackColor = controller.palette(1)
        DeleteBtn.ForeColor = Color.White
        AddBtn.BackColor = controller.palette(1)
        AddBtn.ForeColor = Color.White

        ReportsBtn.BackColor = Color.White
        ReportsBtn.ForeColor = controller.palette(0)
        propertiesBtn.BackColor = Color.White
        propertiesBtn.ForeColor = controller.palette(0)

        LiveBtn.BackColor = controller.palette(2)
        LiveBtn.ForeColor = Color.White

        HomeBtn.ForeColor = controller.palette(3)
        HomeBtn.BackColor = controller.palette(3)


        'Teacher Objective 2a

        ' get assessment name
        Dim assessment As Object() = controller.DBController.SelectValues("Assessments", "Name", $"AssessmentID='{controller.currentAssessmentID}'")(0)
        titleLbl.Text = assessment(0)

        ' display current questions
        displayQuestions()


        ' disable assesment editing - if locked by reports or shared assessments
        If controller.sharedAssessments Then
            canEditLbl.Text = "This assessment cannot be edited because it has been shared by another user."
        End If

        Dim numOfReports As Integer = controller.DBController.SelectValues("Reports", "COUNT(ReportID)", $"AssessmentID = {controller.currentAssessmentID}")(0)(0)
        If numOfReports > 0 Or controller.sharedAssessments Then
            canEdit = False
            canEditLbl.Visible = True

            AddBtn.Enabled = False
            DeleteBtn.Enabled = False

            AddBtn.BackColor = Color.LightGray
            DeleteBtn.BackColor = Color.LightGray

            propertiesBtn.Enabled = False

        Else
            canEdit = True
            canEditLbl.Visible = False
        End If
    End Sub
#End Region

#Region "Navigation"
    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        ' back to All Assessments page
        Dim nextForm As New T_AllAssessments(controller)
        controller.SwitchForms(Me, nextForm)
    End Sub
#End Region

#Region "Question Buttons"

    Private Sub propertiesBtn_Click(sender As Object, e As EventArgs) Handles propertiesBtn.Click
        'Teacher Objective 2a
        'next form
        Dim nextForm As New T_AssessmentProperties(controller)
        controller.SwitchForms(Me, nextForm)
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        'Teacher Objective 2a, 2b
        ' Add new question
        ' enable listbox
        EnableDisableListbox()

        ' update database
        controller.currentQuestionNum = getQuestions.Count
        controller.DBController.AddValues("Questions", {controller.currentAssessmentID, controller.currentQuestionNum, "", "30"})
        controller.DBController.AddValues("Parts", {0, controller.currentQuestionNum, controller.currentAssessmentID, "Short Text", "Enter Question Text", "Enter Answer", "", "", "", "", "", "0", "0"})

        'update listbox
        QuestionsListbox.Items.Add("Question " & getQuestions.Count)

        QuestionsListbox.SelectedIndex = QuestionsListbox.Items.Count - 1
        QuestionsListbox_DoubleClick(New Object, New EventArgs)
    End Sub


    Private Sub QuestionsListbox_DoubleClick(sender As Object, e As EventArgs) Handles QuestionsListbox.DoubleClick
        'Teacher Objective 2a, 2b, 2c

        If QuestionsListbox.SelectedIndex > -1 Then
            controller.currentQuestionNum = QuestionsListbox.SelectedIndex

            'next form
            Dim nextForm As New T_CreateQuestionParts(controller, canEdit)
            controller.SwitchForms(Me, nextForm)
        End If
    End Sub


    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click

        Dim deleteIndex As Integer = QuestionsListbox.SelectedIndex
        Dim deleteID As Integer = getQuestions(deleteIndex)(1)

        ' delete selected question from database
        controller.DBController.DeleteValues("Questions", $"AssessmentID='{controller.currentAssessmentID}' AND QuestionNumber={deleteID}")


        ' update listbox
        displayQuestions()

        ' reselect listbox
        If QuestionsListbox.Enabled Then
            QuestionsListbox.SelectedIndex = deleteIndex - 1
        End If

        'hide more/delete btns
        DeleteBtn.Visible = False
    End Sub

    Private Sub QuestionsListbox_KeyDown(sender As Object, e As KeyEventArgs) Handles QuestionsListbox.KeyDown

        ' delete key pressed
        If e.KeyCode = Keys.Delete And canEdit Then
            DeleteBtn_Click(New Object, New EventArgs)
        End If
    End Sub

#End Region

#Region "Live"
    Private Sub LiveBtn_Click(sender As Object, e As EventArgs) Handles LiveBtn.Click
        'Teacher Objective 3 (Live)
        Dim nextform As New T_LiveSettings(controller)
        controller.SwitchForms(Me, nextform)

    End Sub

    Private Sub ReportsBtn_Click(sender As Object, e As EventArgs) Handles ReportsBtn.Click
        'Teacher Objective 6 (Reports)
        ' next form
        Dim nextForm As New T_Reports(controller)
        controller.SwitchForms(Me, nextForm)
    End Sub

#End Region

#Region "Questions Listbox"
    Private Sub QuestionsListbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles QuestionsListbox.SelectedIndexChanged
        ' hide delete btn when nothing selected
        If QuestionsListbox.SelectedIndex > -1 Then

            If controller.sharedAssessments = False Then
                DeleteBtn.Visible = True
            End If

        End If

    End Sub

    Public Sub EnableDisableListbox()
        ' disable listbox when no questions created/ enable when question created

        If QuestionsListbox.Items.Count = 0 Then
            ' disable empty listbox

            If controller.sharedAssessments = False Then
                QuestionsListbox.Items.Add("You have no Questions. Click the + to create one.")
            Else
                QuestionsListbox.Items.Add("This Assessment has no Questions.")
            End If

            QuestionsListbox.Enabled = False

        Else
            ' enable empty listbox
            If Not QuestionsListbox.Enabled Then
                QuestionsListbox.Items.RemoveAt(0)
                QuestionsListbox.Enabled = True

            End If
        End If

    End Sub

    Public Sub displayQuestions()
        'Teacher Objective 2a

        QuestionsListbox.Items.Clear()

        ' update listbox
        For i = 0 To getQuestions.Count - 1

            'create assessment objects
            QuestionsListbox.Items.Add($"Question  {i + 1} - {getQuestions(i)(2)}")

        Next
        ' enable/disable listbox 
        EnableDisableListbox()
    End Sub

    Public Function getQuestions() As List(Of Object())
        'Teacher Objective 2a

        Cursor = Cursors.WaitCursor
        ' get all parts from database where questionID and AssessmentID = questionID and currentAssessment.ID
        Dim questions As List(Of Object()) = controller.DBController.SelectValues("Questions", "*", $"AssessmentID='{controller.currentAssessmentID}' ORDER BY QuestionNumber ASC")

        Cursor = Cursors.Default
        Return questions

    End Function

#End Region

End Class