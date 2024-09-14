Public Class T_LiveSettings
    Property controller As AppController
    Sub New(controller_ As AppController)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        controller = controller_
    End Sub

#Region "Form"

    Private Sub TeacherLiveSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModeCombo.SelectedIndex = 0

        ' colours
        BackBtn.ForeColor = controller.palette(3)
        BackBtn.BackColor = controller.palette(3)

        ModeCombo.BackColor = Color.GhostWhite

        NextBtn.BackColor = controller.palette(2)
        NextBtn.ForeColor = Color.White

    End Sub

#End Region

#Region "Navigation"
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        ' back to assessment page
        Dim nextForm As New T_ViewAssessment(controller)
        controller.SwitchForms(Me, nextForm)
    End Sub

#End Region

#Region "Save"
    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click


        'Teacher Objective 3a
        ' validate name
        Dim valid As Boolean = True
        Dim names As List(Of Object()) = controller.DBController.SelectValues("Reports", "Name", $"AssessmentID = '{controller.currentAssessmentID}'")
        For Each name As Object() In names
            If name(0).ToString.Trim() = NameInput.Text.Trim Then

                valid = False
            End If
        Next

        If Not valid Then
            MessageBox.Show("A live report already exists with this name. Please enter another.")
        ElseIf NameInput.Text.Trim = "" Then
            MessageBox.Show("This is not a valid report name. Please enter another.")
        Else
            ' create assessment object
            Dim assessment As New Assessment()

            ' generate report id
            ' get current report IDs
            Dim reportIDs As List(Of Object()) = controller.DBController.SelectValues("Reports", "ReportID")
            Dim reportIdStrings(reportIDs.Count) As String
            For i = 0 To reportIDs.Count - 1
                reportIdStrings(i) = reportIDs(i)(0)
            Next
            controller.reportID = controller.generateRandomID(reportIdStrings)



            ' add mode settings
            If ModeCombo.SelectedIndex = 1 Then
                ' Teacher Objective 3c
                ' test mode: random order, show answers, time limit
                assessment.gameMode = False

                assessment.randomOrder = RandomCheckbox.Checked
                assessment.showResults = DisplayCheckbox.Checked
                assessment.timeLimit = -1

                assessment.chooseName = True
                assessment.music = False
                assessment.showPosition = True

                ' Teacher Objective 3d
                If TimerCheckbox.Checked Then
                    assessment.timeLimit = TimerPicker.Value
                End If
            Else
                ' Teacher Objective 3b
                ' game mode: random name, show position, music, timelimit
                assessment.gameMode = True

                assessment.chooseName = Not RandomCheckbox.Checked
                assessment.showPosition = DisplayCheckbox.Checked
                assessment.music = MusicCheckbox.Checked


                assessment.randomOrder = False

                If TimerCheckbox.Checked Then
                    assessment.timeLimit = 1
                Else
                    assessment.timeLimit = -1
                End If

            End If


            'Teacher Objective 3a
            ' add name
            assessment.Name = NameInput.Text

            ' add questions
            Dim questions As List(Of Object()) = controller.DBController.SelectValues("Questions", "Category, Timer", $"AssessmentID='{controller.currentAssessmentID}'")
            For i = 0 To questions.Count - 1
                Dim question As New Question
                question.id = i
                question.category = questions(i)(0)
                question.timeLimit = questions(i)(1)


                ' add parts
                Dim parts As List(Of Object()) = controller.DBController.SelectValues("Parts", "*", $"AssessmentID='{controller.currentAssessmentID}' AND QuestionNumber={i} ORDER BY PartID ASC")
                For Each p In parts
                    Dim part As New Part
                    part.setProperties(p(0), p(3), p(4), {p(5), p(6), p(7), p(8), p(9), p(10)}, p(11), p(12))
                    question.parts.Add(part)
                Next

                assessment.questions.Add(question)

            Next

            Dim nextForm As New T_LiveLobby(controller, assessment)
            controller.SwitchForms(Me, nextForm)
        End If



    End Sub
#End Region

#Region " Live Properties"
    Private Sub ModeCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ModeCombo.SelectedIndexChanged


        ' show/hide relevant mode setting checkboxes
        If ModeCombo.SelectedIndex = 0 Then

            'Teacher Objective 3b
            ' game mode (random names, question time limits, leaderboard, music)
            RandomCheckbox.Text = "Assign Student Names Randomly"
            TimerCheckbox.Text = "Question Time Limits"
            DisplayCheckbox.Text = "Display Leaderboard"
            TableLayoutPanel1.SetColumnSpan(RandomCheckbox, 1)
            MusicCheckbox.Visible = True
            TimerPicker.Visible = False
            minutesLbl.Visible = False
        Else ' test mode (random question order, time limit and time setter, display correct answers)

            'Teacher Objective 3c
            RandomCheckbox.Text = "Order Questions Randomly"
            TimerCheckbox.Text = "Set Time Limit "
            DisplayCheckbox.Text = "Display Correct Answers"
            TableLayoutPanel1.SetColumnSpan(RandomCheckbox, 2)
            MusicCheckbox.Visible = False

            ' display time input if checked. 
            If TimerCheckbox.Checked Then
                TimerPicker.Visible = True
                minutesLbl.Visible = True
            Else
                TimerPicker.Visible = False
                minutesLbl.Visible = False
            End If
        End If
    End Sub

    Private Sub TimerCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles TimerCheckbox.CheckedChanged

        'Teacher Objective 3d
        ' hide time limit label/input
        If ModeCombo.SelectedIndex = 1 And TimerCheckbox.Checked Then
            TimerPicker.Visible = True
            minutesLbl.Visible = True
        Else
            TimerPicker.Visible = False
            minutesLbl.Visible = False
        End If
    End Sub
#End Region
End Class