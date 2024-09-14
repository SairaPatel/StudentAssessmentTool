Public Class T_Reports

    Property controller As AppController
    Property search As String

#Region "Form"
    Sub New(controller_ As AppController)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        controller = controller_


    End Sub

    Private Sub T_Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' set colours
        Me.BackColor = Color.White

        ReportsListbox.BackColor = Color.GhostWhite

        DeleteBtn.BackColor = controller.palette(1)
        DeleteBtn.ForeColor = Color.White

        BackBtn.ForeColor = controller.palette(3)
        BackBtn.BackColor = controller.palette(3)

        ' display reports
        displayReports()

    End Sub

    Private Function getReports() As List(Of Object())

        ' select reports
        Dim reports As List(Of Object())
        If controller.studentLogin Then
            ' student all reports
            'Student objective 4a
            Dim condition As String = $"StudentReports.UserID = {controller.currentUserID} AND StudentReports.Name = Students.Name AND StudentReports.ReportID = Students.ReportID AND StudentReports.ReportID = Reports.ReportID"
            reports = controller.DBController.SelectValues("Reports, Students, StudentReports", "Students.StudentID, Reports.Name, Students.ReportID", condition)
        Else
            ' teacher assessmentreports
            ' Teacher Objective 6
            reports = controller.DBController.SelectValues("Reports", "ReportID, Name", $"AssessmentID ='{controller.currentAssessmentID}'")
        End If
        Return reports
    End Function

    Private Sub displayReports()
        ReportsListbox.Items.Clear()
        For Each report As Object() In getReports()
            ReportsListbox.Items.Add($"{report(1)}")
        Next
    End Sub
#End Region

#Region "Navigation"


    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        If controller.studentLogin Then
            ' student create page form
            Dim ans As MsgBoxResult = MsgBox("Are you sure you want to sign out of your account?", MessageBoxButtons.YesNo)
            If ans = MsgBoxResult.Yes Then

                controller.currentUserID = vbNullString
                Dim nextForm As New T_CreateAccount(controller)
                controller.SwitchForms(Me, nextForm)
            End If
        Else
            'teacher assessments form
            controller.sharedAssessments = False
            Dim nextForm As New T_ViewAssessment(controller)
            controller.SwitchForms(Me, nextForm)
        End If


    End Sub


    Private Sub ReportsListbox_DoubleClick(sender As Object, e As EventArgs) Handles ReportsListbox.DoubleClick
        If ReportsListbox.SelectedIndex > -1 Then
            If controller.studentLogin Then
                ' Student Objective 4a
                ' set student and reportID
                'Dim id As List(Of Object()) = controller.DBController.SelectValues("StudentReports", "ReportID, StudentID", "")
                controller.studentID = getReports(ReportsListbox.SelectedIndex)(0)
                controller.reportID = getReports(ReportsListbox.SelectedIndex)(2)


                ' student view report
                Dim nextForm As New T_ViewReport(controller, True, True)
                controller.SwitchForms(Me, nextForm)
            Else
                ' teacher report page
                ' (Teacher Objective 6)
                ' get id
                Dim id As String = getReports(ReportsListbox.SelectedIndex)(0)
                controller.reportID = Val(id)
                ' next form 
                Dim nextForm As New T_ReportStudents(controller, True)
                controller.SwitchForms(Me, nextForm)
            End If


        End If
    End Sub

#End Region

#Region "Delete"


    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If ReportsListbox.SelectedIndex > -1 Then
            ' get id
            Dim id As String = getReports(ReportsListbox.SelectedIndex)(0)
            controller.reportID = Val(id)

            ' delete
            controller.DBController.DeleteValues("Reports", $"ReportID = {id}")

            'update listbox
            displayReports()

        End If
    End Sub

    Private Sub ReportsListbox_KeyDown(sender As Object, e As KeyEventArgs) Handles ReportsListbox.KeyDown

        ' same as delete btn click event
        If ReportsListbox.SelectedIndex > -1 Then
            If e.KeyCode = Keys.Delete Then
                DeleteBtn_Click(New Object, New EventArgs)
            End If

        End If
    End Sub


#End Region
End Class