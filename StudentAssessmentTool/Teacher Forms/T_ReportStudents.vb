Public Class T_ReportStudents

    Property controller As AppController
    Property search As String
    Property displayNames As Boolean

    Sub New(controller_ As AppController, display As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        controller = controller_
        displayNames = display


    End Sub
#Region "Form"

    Private Sub T_ReportStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' set colours
        Me.BackColor = Color.White

        StudentsListbox.BackColor = Color.GhostWhite

        hideNamesBtn.BackColor = controller.palette(2)
        hideNamesBtn.ForeColor = Color.White

        showByBtn.BackColor = controller.palette(2)
        showByBtn.ForeColor = Color.White

        BackBtn.ForeColor = controller.palette(3)
        BackBtn.BackColor = controller.palette(3)

        ' Teacher Objective 6e
        ' display names
        If Not displayNames Then
            hideNamesBtn.Text = "Show Names"
        End If



        displayStudents()
    End Sub


#End Region


#Region "Navigation"

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        'next form
        Dim nextForm As New T_Reports(controller)
        controller.SwitchForms(Me, nextForm)

    End Sub

#End Region

#Region "Listbox"
    Private Sub StudentsListbox_Click(sender As Object, e As EventArgs) Handles StudentsListbox.Click
        If StudentsListbox.SelectedIndex > -1 Then
            'Teacher Objective 6a
            controller.studentID = getStudents(StudentsListbox.SelectedIndex)(1)

            ' next form 
            Dim nextForm As New T_ViewReport(controller, displayNames, True)
            controller.SwitchForms(Me, nextForm)
        End If
    End Sub
#End Region
#Region "Students"
    Private Sub hideNamesBtn_Click(sender As Object, e As EventArgs) Handles hideNamesBtn.Click

        'Teacher Objective 6e
        If hideNamesBtn.Text = "Hide Names" Then
            hideNamesBtn.Text = "Show Names"
            displayNames = False
        Else
            hideNamesBtn.Text = "Hide Names"
            displayNames = True
        End If

        displayStudents()
    End Sub


    Private Function getStudents() As List(Of Object())
        'Teacher Objective 6a
        Dim condition As String = $"Reports.ReportID = Students.ReportID And Reports.AssessmentID = '{controller.currentAssessmentID}' AND Reports.ReportID = '{controller.reportID}'"
        Dim students As List(Of Object()) = controller.DBController.SelectValues("Students, Reports", "Students.Name, StudentID", condition)

        Return students
    End Function

    Public Sub displayStudents()
        'Teacher Objective 6a
        ' add student names to listbox
        StudentsListbox.Items.Clear()

        Dim students As List(Of Object()) = getStudents()

        For s = 1 To students.Count
            If displayNames Then
                StudentsListbox.Items.Add(students(s - 1)(0))
            Else
                StudentsListbox.Items.Add("Student " & s)
            End If
        Next
    End Sub

    Private Sub QuestionsBtn_Click(sender As Object, e As EventArgs) Handles showByBtn.Click
        'Teacher Objective 6b
        ' next form 
        Dim nextForm As New T_ViewReport(controller, displayNames, False)
        controller.SwitchForms(Me, nextForm)
    End Sub

#End Region

End Class