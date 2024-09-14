Public Class T_AssessmentProperties
    Property controller As AppController
    Property allowedUsers As List(Of Object())

    Sub New(controller_ As AppController)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        controller = controller_

        ' get allowed users
        allowedUsers = controller.DBController.SelectValues(
            "Teachers", "Teachers.UserID, Teachers.Username", $"INNER JOIN TeacherAccess ON Teachers.UserID = TeacherAccess.UserID WHERE TeacherAccess.AssessmentID='{controller.currentAssessmentID}'", True)

    End Sub

#Region "Form"
    Private Sub AssessmentProperties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AccessCombo.SelectedIndex = 0

        ' set colours
        Me.BackColor = Color.White

        AccessCombo.BackColor = Color.GhostWhite

        AccessListBtn.BackColor = controller.palette(3)
        AccessListBtn.ForeColor = controller.palette(0)

        CreateBtn.BackColor = controller.palette(2)
        CreateBtn.ForeColor = Color.White

        BackBtn.ForeColor = controller.palette(3)
        BackBtn.BackColor = controller.palette(3)


        'Teacher Objectives 2a
        ' update properties
        Dim assessment As Object() = controller.DBController.SelectValues("Assessments", "*", $"AssessmentID='{controller.currentAssessmentID}'")(0)
        IDLbl.Text = "Assessment ID: " & controller.currentAssessmentID
        NameInput.Text = assessment(2)
        AccessCombo.SelectedItem = assessment(3)


    End Sub
#End Region

#Region "Navigation"
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click

        Dim ans As MsgBoxResult = MsgBox("Are you sure you want to go back? Any changes you have made will not be saved.", MessageBoxButtons.YesNo)
        If ans = MsgBoxResult.Yes Then
            Dim nextForm As New T_AllAssessments(controller)
            controller.SwitchForms(Me, nextForm)
        End If
    End Sub
#End Region

#Region "Properties"
    'Teacher Objectives 2a

    Private Sub AccessCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AccessCombo.SelectedIndexChanged
        ' show access list btn
        If AccessCombo.SelectedIndex = 2 Then
            AccessListBtn.Visible = True
        Else
            AccessListBtn.Visible = False
        End If
    End Sub

    Private Sub AccessListBtn_Click(sender As Object, e As EventArgs) Handles AccessListBtn.Click
        'open access list form
        Dim accessForm As New T_AccessList(controller, allowedUsers)
        accessForm.Show()
    End Sub

    Private Sub CreateBtn_Click(sender As Object, e As EventArgs) Handles CreateBtn.Click
        ' validate  name
        Dim assessments As List(Of Object()) = controller.DBController.SelectValues("Assessments", "Name, AssessmentID", $"UserID='{controller.currentUserID}'")
        Dim unique As Boolean = True ' unique
        For Each a In assessments
            If a(0) = NameInput.Text And a(1) <> controller.currentAssessmentID Then
                unique = False
            End If
        Next


        If Not unique Then
            MessageBox.Show("An assessment already exists with this name.")

        ElseIf NameInput.Text.Trim() = "" Then ' not null
            MessageBox.Show("Assessment Name Field cannot be left empty")
        Else

            ' update object in database
            Dim newProperties(,) As String = {{"Name", NameInput.Text}, {"AllowedType", AccessCombo.Text}}
            controller.DBController.UpdateValues("Assessments", newProperties, $"AssessmentID='{controller.currentAssessmentID}'")

            ' update database access list
            controller.DBController.DeleteValues("TeacherAccess", $"AssessmentID='{controller.currentAssessmentID}'")  ' clear current access list
            If AccessCombo.SelectedIndex = 2 Then
                For Each user In allowedUsers ' add each user
                    controller.DBController.AddValues("TeacherAccess", {controller.currentAssessmentID, user(0)})
                Next
            End If

            ' next page
            Dim nextForm As New T_ViewAssessment(controller)
            controller.SwitchForms(Me, nextForm)
        End If

    End Sub

#End Region

End Class