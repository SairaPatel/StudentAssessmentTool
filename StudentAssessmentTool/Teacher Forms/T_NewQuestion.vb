Public Class T_NewQuestion
    Property controller As AppController
    Sub New(controller_ As AppController)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        controller = controller_
    End Sub

#Region "Form"
    Private Sub NewQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' colours
        TypeACombo.BackColor = Color.GhostWhite
        TypeBCombo.BackColor = Color.GhostWhite
        TypeCCombo.BackColor = Color.GhostWhite
        TypeDCombo.BackColor = Color.GhostWhite

        CreateQuestionBtn.BackColor = controller.palette(1)
        CreateQuestionBtn.ForeColor = Color.White

        BackBtn.BackColor = controller.palette(3)
        BackBtn.ForeColor = controller.palette(3)

        ' update title label
        QuestionLbl.Text = "Question " & (controller.currentQuestionNum + 1)


        Cursor = Cursors.WaitCursor
        ' update category
        Dim categories As List(Of Object()) = controller.DBController.SelectValues("Questions", "Category, QuestionNumber", $"AssessmentID='{controller.currentAssessmentID}'")
        For Each c In categories ' get current categories
            If c(0) <> "" Then
                'add category
                If Not categoryCombo.Items.Contains(c(0)) Then
                    categoryCombo.Items.Add(c(0))
                End If

                ' select current category 
                If c(1) = controller.currentQuestionNum Then
                    categoryCombo.SelectedItem = c(0)
                End If
            End If
        Next

        Cursor = Cursors.Default


    End Sub
#End Region

#Region "Navigation"

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        ' go back message
        Dim ans As MsgBoxResult = MsgBox("Are you sure you want to go back? Any changes you have made will not be saved", MessageBoxButtons.YesNo)
        If ans = MsgBoxResult.Yes Then

            ' delete question
            controller.DBController.DeleteValues("Questions", $"QuestionNumber={controller.currentQuestionNum} AND AssessmentID='{controller.currentAssessmentID}'")

            'switch form
            Dim nextForm As New T_ViewAssessment(controller)
            controller.SwitchForms(Me, nextForm)
        End If
    End Sub
#End Region




#Region "Parts"
    Private Sub NumPartsChooser_ValueChanged(sender As Object, e As EventArgs) Handles NumPartsChooser.ValueChanged
        For Each c As Control In TableLayoutPanel1.Controls
            c.Visible = True
        Next

        TableLayoutPanel1.SetRow(CreateQuestionBtn, 11)
        If NumPartsChooser.Value < 4 Then
            TypeDCombo.Visible = False
            PartDLbl.Visible = False
            TableLayoutPanel1.SetRow(CreateQuestionBtn, 10)
        End If
        If NumPartsChooser.Value < 3 Then
            TypeCCombo.Visible = False
            PartCLbl.Visible = False
            TableLayoutPanel1.SetRow(CreateQuestionBtn, 8)
        End If
        If NumPartsChooser.Value < 2 Then
            TypeBCombo.Visible = False
            PartBLbl.Visible = False
            TableLayoutPanel1.SetRow(CreateQuestionBtn, 8)
        End If
    End Sub

#End Region

    Private Sub TimeCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TimeCheckBox.CheckedChanged
        If TimeCheckBox.Checked Then
            TimeChooser.Enabled = True
            TimeLbl.Enabled = True
        Else
            TimeChooser.Enabled = False
            TimeLbl.Enabled = False
        End If
    End Sub

#Region "Create"
    Private Sub CreateQuestionBtn_Click(sender As Object, e As EventArgs) Handles CreateQuestionBtn.Click

        Dim parts As New List(Of Part)
        Dim validSelection As Boolean = True



        ' validate category
        If categoryCombo.Text.Trim = "" Then
            MessageBox.Show("Please enter a Topic for this Question")
        Else

            ' get time value
            Dim timeVal As Integer = TimeChooser.Value
            If Not TimeCheckBox.Checked Then
                timeVal = -1
            End If

            ' update question category and timer in database
            controller.DBController.UpdateValues("Questions", {{"Category", categoryCombo.Text}, {"Timer", timeVal}}, $"AssessmentID='{controller.currentAssessmentID}' AND QuestionNumber={controller.currentQuestionNum}")

            ' validate type selection
            Dim types() As ComboBox = {TypeACombo, TypeBCombo, TypeCCombo, TypeDCombo}
            For i = 0 To NumPartsChooser.Value - 1
                If types(i).SelectedIndex = -1 Then
                    validSelection = False
                Else
                    Dim part As New Part
                    part.ID = i
                    part.type = types(i).Text
                    part.correctAnswer = ""
                    parts.Add(part)

                End If
            Next

            ' next form
            If validSelection Then
                Dim nextForm As New T_CreateQuestionParts(controller, False)
                controller.SwitchForms(Me, nextForm)
            Else
                MessageBox.Show("Please enter the Question Type for each part.")
            End If

        End If

    End Sub


#End Region

End Class