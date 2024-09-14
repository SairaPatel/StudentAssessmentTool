'I used the following site to help with SQL syntax (JOIN) that I did not know: https://www.w3schools.com/sql/sql_join_inner.asp

Public Class T_AllAssessments
    Property controller As AppController
    Property search As String
    Sub New(controller_ As AppController)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        controller = controller_

        search = ""

    End Sub


#Region "Form"
    Private Sub TeacherAllAssessments_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' set colours
        Me.BackColor = Color.White

        AssessmentsListBox.BackColor = Color.GhostWhite

        DeleteBtn.BackColor = controller.palette(1)
        DeleteBtn.ForeColor = Color.White
        AddBtn.BackColor = controller.palette(1)
        AddBtn.ForeColor = Color.White

        BackBtn.ForeColor = controller.palette(3)
        BackBtn.BackColor = controller.palette(3)

        copyBtn.BackColor = controller.palette(1)
        copyBtn.ForeColor = Color.White


        SharedBtn.ForeColor = controller.palette(0)
        SharedBtn.BackColor = Color.White
        searchBtn.ForeColor = controller.palette(1)
        searchBtn.BackColor = controller.palette(1)



        'Teacher Objective 2a
        ' display current assessments
        displayAssessments()


        ' shared mode - hide edit btns
        If controller.sharedAssessments Then
            DeleteBtn.Visible = False
            copyBtn.Visible = False
            AddBtn.Visible = False
            SharedBtn.Visible = False

            TitleLbl.Text = "Assessments Shared With You"
        End If



    End Sub

#End Region

#Region "Navigation"


    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click

        ' sharing - go back to all assessments
        If controller.sharedAssessments Then

            controller.sharedAssessments = False
            Dim nextForm As New T_AllAssessments(controller)
            controller.SwitchForms(Me, nextForm)

        Else ' not sharing - go to sign in page
            Dim ans As MsgBoxResult = MsgBox("Are you sure you want to go back? Doing so will involve signing out of your account.", MessageBoxButtons.YesNo)
            If ans = MsgBoxResult.Yes Then
                Dim nextForm As New T_CreateAccount(controller)
                controller.SwitchForms(Me, nextForm)
            End If
        End If



    End Sub
#End Region

#Region "Listbox"
    Public Function getAssessments()
        'Teacher Objective 2a

        Dim assessments As List(Of Object())


        Cursor = Cursors.WaitCursor
        If controller.sharedAssessments Then
            ' get all custom shared assessments
            Dim join1 As String = $"INNER JOIN TeacherAccess ON Assessments.AssessmentID=TeacherAccess.AssessmentID"
            Dim join2 As String = $"INNER JOIN Teachers ON Assessments.UserID=Teachers.UserID"
            Dim condition As String = $"{join1} {join2} WHERE TeacherAccess.UserID='{controller.currentUserID}' AND (Teachers.Username LIKE '%{search}%' OR Assessments.Name LIKE '%{search}%')  ORDER BY Name ASC"

            assessments = controller.DBController.SelectValues("Assessments", "Assessments.Name, Assessments.AssessmentID, Assessments.AllowedType, Teachers.Username", condition, True)

            ' get all public assessments (allowed type: everyone)
            join1 = $"INNER JOIN Teachers ON Assessments.UserID=Teachers.UserID"
            condition = $"{join1} WHERE AllowedType='Everyone' AND (NOT Assessments.UserID={controller.currentUserID}) AND (Teachers.Username LIKE '%{search}%' OR Assessments.Name LIKE '%{search}%') ORDER BY Name ASC"

            Dim publicAssessments As List(Of Object()) = controller.DBController.SelectValues("Assessments", "Assessments.Name, Assessments.AssessmentID, Assessments.AllowedType, Teachers.Username", condition, True)

            assessments.AddRange(publicAssessments)


        Else 'get all user's assessments
            assessments = controller.DBController.SelectValues("Assessments", "Name, AssessmentID, AllowedType, AllowedType", $"UserID='{controller.currentUserID}' AND Assessments.Name LIKE '%{search}%' ORDER BY Name ASC")

        End If

        Cursor = Cursors.Default
        Return assessments
    End Function

    Public Sub displayAssessments()
        'Teacher Objective 2a
        AssessmentsListBox.Items.Clear()

        ' get all assessments for current user
        Dim assessments As List(Of Object()) = getAssessments()
        If controller.sharedAssessments Then ' shared assessments

            For a = 0 To assessments.Count - 1
                ' update listbox
                If assessments(a)(2) = "Custom" Then
                    AssessmentsListBox.Items.Add(assessments(a)(0) & " Shared By " & assessments(a)(3))
                Else
                    AssessmentsListBox.Items.Add(assessments(a)(0) & " Made Public By " & assessments(a)(3))
                End If
            Next

        Else ' users assessments

            For a = 0 To getAssessments.Count - 1
                ' update listbox
                AssessmentsListBox.Items.Add(getAssessments(a)(0))
            Next
        End If

        ' enable/disable listbox 
        EnableDisableListbox()

        ' display title and search term
        If controller.sharedAssessments Then
            TitleLbl.Text = "ASSESSMENTS SHARED WITH YOU"
        Else
            TitleLbl.Text = "YOUR ASSESSMENTS"
        End If

        If search <> "" Then
            resultsLbl.Text &= $"(Showing results for: '{search}')"
        Else
            resultsLbl.Text = ""
        End If


    End Sub

    Private Sub AssessmentsListbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AssessmentsListBox.SelectedIndexChanged
        If AssessmentsListBox.SelectedIndex > -1 Then
            If controller.sharedAssessments = False Then
                DeleteBtn.Visible = True
                copyBtn.Visible = True
            End If

        End If

    End Sub

    Public Sub EnableDisableListbox()
        If AssessmentsListBox.Items.Count = 0 Then
            ' disable empty listbox

            Dim msg As String
            'display 'no assessments' message depending on search or shared 
            If controller.sharedAssessments Then
                If searchBtn.ImageIndex = 1 Then
                    msg = "There are no shared or public assessments that match this search criteria."
                Else
                    msg = "No assessments have been shared with you or made publicly available."
                End If
            Else
                If searchBtn.ImageIndex = 1 Then
                    msg = "You have no assessments that match this search criteria."
                Else
                    msg = "You have no assessments. Click the '+' to create one."
                End If
            End If


            AssessmentsListBox.Items.Add(msg)
            AssessmentsListBox.Enabled = False


        Else
            ' enable empty listbox
            If Not AssessmentsListBox.Enabled Then
                AssessmentsListBox.Items.RemoveAt(0)
                AssessmentsListBox.Enabled = True

            End If
        End If

    End Sub
#End Region

#Region "Assessment Edit Btns"
    Private Function getID() As String

        'Teacher Objective 2a
        ' generate id
        Dim currentIDs As List(Of Object()) = controller.DBController.SelectValues("Assessments", "AssessmentID") ' get current IDs
        Dim ids(currentIDs.Count - 1) As String ' (converts list of obj arrays to 1d str array)
        For i = 0 To currentIDs.Count - 1
            ids(i) = currentIDs(i)(0)
        Next

        Return controller.generateRandomID(ids) ' generate random ID
    End Function

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        'Teacher Objective 2a
        ' create new assessment


        ' generate name
        Dim name As String
        Dim num As Integer = 1
        While AssessmentsListBox.Items.Contains("Assessment " & num)
            num += 1
        End While
        name = "Assessment " & num.ToString()


        ' generate id
        Dim ID As String = getID()

        ' create Assessment record in DB
        controller.DBController.AddValues("Assessments", {ID, controller.currentUserID, name, "Me"})
        controller.currentAssessmentID = ID

        ' next form
        Dim nextForm As New T_AssessmentProperties(controller)
        controller.SwitchForms(Me, nextForm)

    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        'Teacher Objective 2a
        ' delete assessment

        Dim deleteIndex As Integer = AssessmentsListBox.SelectedIndex
        ' remove item from database
        controller.DBController.DeleteValues("Assessments", $"Name='{AssessmentsListBox.Items(deleteIndex)}'")

        ' update listbox
        displayAssessments()

        ' reselect listbox
        If AssessmentsListBox.Enabled Then
            AssessmentsListBox.SelectedIndex = deleteIndex - 1
        End If


        'hide copy/delete btns
        DeleteBtn.Visible = False
        copyBtn.Visible = False
    End Sub

    Private Sub AssessmentsListBox_KeyDown(sender As Object, e As KeyEventArgs) Handles AssessmentsListBox.KeyDown
        ' del key pressed
        If AssessmentsListBox.SelectedIndex > -1 Then
            If e.KeyCode = Keys.Delete Then
                DeleteBtn_Click(New Object, New EventArgs)
            End If
        End If


    End Sub

    Private Sub copyBtn_Click(sender As Object, e As EventArgs) Handles copyBtn.Click
        'New Objective: Duplicate Assessments

        ' create copy
        If AssessmentsListBox.SelectedIndex > -1 Then

            ' get new copy name
            Dim defaultName As String = $"{AssessmentsListBox.SelectedItem} - Copy "
            Dim version As Integer = 1
            While AssessmentsListBox.Items.Contains(defaultName & version)
                version += 1
            End While

            Dim name As String = InputBox("Enter a name for the duplicate assessment: ", "Create Duplicate Assessment", $"{defaultName}{version}")

            ' validate new name - check if unique
            Dim assessmentNames As List(Of Object()) = controller.DBController.SelectValues("Assessments", "Name", $"UserID= {controller.currentUserID}")
            Dim unique As Boolean = True

            Dim i As Integer = 0
            While i < assessmentNames.Count And unique
                If assessmentNames(i)(0) = name Then
                    unique = False
                End If
                i += 1
            End While


            If name.Trim <> "" And unique Then
                ' get origianl Assessment ID
                Dim originalID As String = getAssessments(AssessmentsListBox.SelectedIndex)(1)

                ' get current assessment allowedType

                Dim allowedTypes As List(Of Object()) = controller.DBController.SelectValues("Assessments", "AllowedType", $"AssessmentID = '{originalID}'")
                Dim allowedType As String = controller.DBController.SelectValues("Assessments", "AllowedType", $"AssessmentID = '{originalID}'")(0)(0)

                ' generate new ID
                Dim id As String = getID()
                ' insert duplicate assessment record
                controller.DBController.AddValues("Assessments", {id, controller.currentUserID, name, allowedType})


                ' copy questions 
                controller.DBController.NonQueryCommand($"INSERT INTO Questions SELECT {id}, QuestionNumber, Category, Timer FROM Questions WHERE AssessmentID = '{originalID}'")

                ' copy question parts
                controller.DBController.NonQueryCommand($"INSERT INTO PARTS SELECT PartID, QuestionNumber,{id}, QuestionType, QuestionText, Answer1, Answer2, Answer3, Answer4, Answer5, Answer6, correctAnswer, AvailableMarks FROM Parts WHERE AssessmentID = '{originalID}'")

                displayAssessments()
            ElseIf Not unique Then
                MessageBox.Show("There is already an assessment with this name. Please try another.")
            Else

                MessageBox.Show("This is not a valid assessment name.")
            End If


        End If
    End Sub



    Private Sub AssessmentsListBox_DoubleClick(sender As Object, e As EventArgs) Handles AssessmentsListBox.DoubleClick
        'Teacher Objective 2a
        ' view assessment

        If AssessmentsListBox.SelectedIndex > -1 Then

            'get  assessment ID
            controller.currentAssessmentID = getAssessments(AssessmentsListBox.SelectedIndex)(1)

            'next form
            Dim nextForm As New T_ViewAssessment(controller)
            controller.SwitchForms(Me, nextForm)
        End If
    End Sub


#End Region

#Region "Other Buttons"

    Private Sub SharedBtn_Click(sender As Object, e As EventArgs) Handles SharedBtn.Click
        controller.sharedAssessments = True
        'next form
        Dim nextForm As New T_AllAssessments(controller)
        controller.SwitchForms(Me, nextForm)
    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        'Teacher Objective 2a

        If searchBtn.ImageIndex = 0 Then
            ' search
            search = InputBox("Enter a search term to filter the assessments: ", "Search")
            searchBtn.ImageIndex = 1
        Else
            ' cancel search
            search = ""
            searchBtn.ImageIndex = 0
        End If

        displayAssessments()

        'hide copy/delete btns
        DeleteBtn.Visible = False
        copyBtn.Visible = False

    End Sub

#End Region
End Class