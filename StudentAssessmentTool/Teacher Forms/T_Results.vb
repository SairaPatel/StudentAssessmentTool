Public Class T_Results

    Property controller As AppController
    Property server As Server

    Sub New(controller_ As AppController, server_ As Server)

        ' This call is required by the designer.
        InitializeComponent()
        controller = controller_
        server = server_
        ' Add any initialization after the InitializeComponent() call.

    End Sub
#Region "Form"
    Private Sub T_Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'colours
        BackBtn.BackColor = controller.palette(3)
        BackBtn.ForeColor = Color.White

        leaderboardListbox.BackColor = Color.GhostWhite

        saveReportBtn.BackColor = controller.palette(1)
        saveReportBtn.ForeColor = Color.White


        ' Teacher Objective 4c
        ' display leaderboard
        If server.assessment.showPosition Then
            displayLeaderboard()
        Else
            leaderboardListbox.Hide()
            TableLayoutPanel1.SetRow(averageLbl, 2)

        End If

        ' display average mark
        If server.assessment.getTotalMark > 0 Then
            averageLbl.Text = $"Average Mark: {getAverage()}/{server.assessment.getTotalMark} ({Math.Round(getAverage() / server.assessment.getTotalMark * 100)}%)"
        End If


        Me.Text = $"{server.assessment.Name} Results"
        titleLbl.Text = server.assessment.Name & " - Results"


        ' sound effect
        If server.assessment.music Then
            PlayEndSound()
        End If

    End Sub

    Sub PlayEndSound()
        My.Computer.Audio.Play(Application.StartupPath & "\Music\successSound.wav", AudioPlayMode.WaitToComplete)
    End Sub
#End Region

#Region "Marks and Leaderboard"

    Public Function getAverage() As Integer

        ' get marks
        Dim total As Integer = 0
        For Each student As Student In server.students.Values
            total += student.getTotalMark()
        Next

        If server.students.Count > 0 Then

            Return Math.Round(total / server.students.Count, 2)
        Else
            Return 0
        End If

    End Function

    Public Sub displayLeaderboard()
        ' Teacher Objective 4c
        ' get leaderboard
        Dim names As New List(Of String)
        Dim sortedScores As List(Of Integer()) = server.getStudentScoresAndNames(names)
        controller.sortIndiciesByScores(sortedScores)


        Dim position As Integer = 0
        Dim previousScore As Integer = -1
        For i = 0 To names.Count - 1

            ' if not tie - increment position number
            If sortedScores(i)(1) <> previousScore Then
                position += 1
                previousScore = sortedScores(i)(1)
            End If

            If server.assessment.getTotalMark > 0 Then
                ' display position, name and score
                leaderboardListbox.Items.Add($"{position}. {names(sortedScores(i)(0))} - {sortedScores(i)(1)}/{server.assessment.getTotalMark()} ({Math.Round(sortedScores(i)(1) / server.assessment.getTotalMark() * 100)}%)")
            End If

        Next

    End Sub
#End Region

#Region "Report"
    Private Sub saveReportBtn_Click(sender As Object, e As EventArgs) Handles saveReportBtn.Click
        ' Teacher Objective 6a
        ' game end - save report
        Dim id As Integer = controller.createReport(server)

        ' 
        If id > -1 Then
            controller.reportID = id

            'Student Objective 4a
            ' send reportID to students
            server.assessment.status = "rID" & id
            server.sendAssessmentToAll()


            Dim nextForm As New T_ReportStudents(controller, server.assessment.showPosition)
            controller.SwitchForms(Me, nextForm)

        End If
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim ans As MsgBoxResult = MsgBox("Are you sure you want to leave? Your game report will not be saved.", MessageBoxButtons.YesNo)
        If ans = MsgBoxResult.Yes Then
            Dim nextForm As New T_ViewAssessment(controller)
            controller.SwitchForms(Me, nextForm)
        End If
    End Sub
#End Region
End Class