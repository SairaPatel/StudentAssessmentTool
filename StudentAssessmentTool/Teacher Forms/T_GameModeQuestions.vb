Public Class T_GameModeQuestions
    Property controller As AppController
    Property server As Server
    Property currentQuestion As Integer
    Property partControls As New List(Of List(Of Control))

    Sub New(con As AppController, server_ As Server)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        controller = con
        server = server_

        currentQuestion = -1
    End Sub

    Private Sub T_GameModeQuestions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' colours
        nextBtn.ForeColor = Color.White
        nextBtn.BackColor = controller.palette(2)

        BackBtn.ForeColor = Color.White
        BackBtn.BackColor = controller.palette(2)

        musicBtn.ForeColor = Color.White
        musicBtn.BackColor = controller.palette(2)

        ' Teacher Objective 3b
        ' time limit
        If server.assessment.timeLimit = -1 Then
            timerLbl.Visible = False
        End If

        ' Teacher Objective 4a
        currentQuestion = -1
        ' first question
        setUpQuestion()

        'timer 
        Timer.Start()

        'Teacher Objective 3b
        'music
        If server.assessment.music Then
            PlayLoopingGameMusic()
        Else
            musicBtn.Visible = False
        End If

    End Sub

#Region "Navigation"

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        ' end game
        Dim ans As MsgBoxResult = MsgBox("Are you sure you want to leave? Your game report will not be saved.", MessageBoxButtons.YesNo)
        If ans = MsgBoxResult.Yes Then

            server.assessment.status = "END"
            server.sendAssessmentToAll()

            server.listening = False

            Dim nextForm As New T_ViewAssessment(controller)
            controller.SwitchForms(Me, nextForm)

        End If
    End Sub

    Private Sub nextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        nextQuestion()
    End Sub

    Private Sub nextQuestion()

        If nextBtn.ImageIndex = 0 Then ' forward btn clicked 

            'Teacher Objective 4a

            If currentQuestion < server.assessment.questions.Count - 1 Then
                ' next question

                nextBtn.ImageIndex = 1
                setUpQuestion()

                ' update status
                server.assessment.status = "que" & currentQuestion
                server.sendAssessmentToAll()

                If server.assessment.timeLimit > -1 Then

                    timerLbl.Visible = True
                End If

            Else ' end assessment

                'Teacher Objective 4c

                server.assessment.status = "end" & currentQuestion
                Dim nextform As New T_Results(controller, server)
                controller.SwitchForms(Me, nextform)

            End If


        Else ' submit btn clicked --> display answers

            'Teacher Objective 4b

            timerLbl.Visible = False
            submittedAnswersLbl.Text = ""
            showAnswers()
            nextBtn.ImageIndex = 0


            ' update status
            server.assessment.status = "ans" & currentQuestion
            server.sendAssessmentToAll()
        End If
    End Sub
#End Region

#Region "Leaderboard and answers"
    Public Sub displayLeaderboard()
        'Teacher Objective 3b, 4b

        ' get leaderboard
        Dim names As New List(Of String)
        Dim sortedScores As List(Of Integer()) = server.getStudentScoresAndNames(names)
        controller.sortIndiciesByScores(sortedScores)

        ' display leaderboard
        If server.assessment.showPosition Then

            ' create leaderboard tab
            Dim tabpage As New TabPage("Leaderboard")
            Dim leaderboard As New ListBox
            leaderboard.Font = New Font(New FontFamily("Segoe UI"), 12)

            Dim position As Integer = 0
            Dim previousScore As Integer = -1
            For i = 0 To names.Count - 1

                ' if not tie - increment position number
                If sortedScores(i)(1) <> previousScore Then
                    position += 1
                    previousScore = sortedScores(i)(1)
                End If

                ' display position, name and score
                leaderboard.Items.Add($"{position}. {names(sortedScores(i)(0))} - {sortedScores(i)(1)}/{server.assessment.getTotalMark(currentQuestion)} ({Math.Round(sortedScores(i)(1) / server.assessment.getTotalMark(currentQuestion) * 100)}%)")

                ' send Student Position
                sendStudentPosition(names(sortedScores(i)(0)), position)
                server.assessment.status = "ans" & currentQuestion
            Next

            leaderboard.Dock = DockStyle.Fill
            tabpage.Controls.Add(leaderboard)
            partsTab.TabPages.Add(tabpage)

        End If

    End Sub

    Public Sub sendStudentPosition(name As String, position As Integer)
        'Teacher Objective 4b, Student Objective 2c

        ' get student 
        Dim id As Integer = server.getStudentIDFromName(name)
        Dim student As Student = server.students(id)

        While server.students(id).position = -1
            ' wait 
            UseWaitCursor = True

            server.assessment.status = "pos" & position
            server.sendAssessment(student.client)
        End While
        UseWaitCursor = False

    End Sub


    Public Sub showAnswers()
        'Teacher Objective 3b, 4b

        Dim question As Question = server.assessment.questions(currentQuestion)

        For p = 0 To question.parts.Count - 1
            Dim part As Part = question.parts(p)

            ' get table and question
            Dim table As TableLayoutPanel = partControls(p)(0)
            Dim questionLbl As Label = partControls(p)(1)
            Select Case part.type
                Case "Short Text", "Numerical"
                    ' move question lbl
                    table.SetRowSpan(questionLbl, 1)


                    ' answer label
                    Dim answerLbl As New Label()

                    controller.setControl(table, answerLbl, {0, 1}, {1, 3}, DockStyle.None, fontsize:=14, rowSpan:=2)

                    answerLbl.TextAlign = ContentAlignment.MiddleCenter
                    answerLbl.Text = part.answers(Val(part.correctAnswer))

                    answerLbl.BackColor = controller.palette(2)
                    answerLbl.ForeColor = Color.White

                Case "Multiple Choice"
                    partControls(p)(2 + Val(part.correctAnswer)).BackColor = controller.palette(2)
                    partControls(p)(2 + Val(part.correctAnswer)).ForeColor = Color.White
                    partControls(p)(2 + Val(part.correctAnswer)).Font = New Font(New FontFamily("Segoe UI"), 14, FontStyle.Bold)

                Case "Multiple Answer"
                    For Each ans As Char In part.correctAnswer
                        partControls(p)(2 + Val(ans)).BackColor = controller.palette(2)
                        partControls(p)(2 + Val(ans)).ForeColor = Color.White
                        partControls(p)(2 + Val(ans)).Font = New Font(New FontFamily("Segoe UI"), 14, FontStyle.Bold)
                    Next

                Case "Rank Order"
                    For i = 0 To part.answers.Count - 1
                        partControls(p)(2 + i).Text = server.assessment.questions(currentQuestion).parts(p).answers(i)

                        partControls(p)(2 + i).BackColor = controller.palette(2)
                        partControls(p)(2 + i).ForeColor = Color.White
                        partControls(p)(2 + i).Font = New Font(New FontFamily("Segoe UI"), 14, FontStyle.Bold)
                    Next

            End Select
        Next

    End Sub
#End Region

#Region "Questions"
    Public Sub setUpQuestion()
        ' display question and timer
        'Teacher Objective 4a

        currentQuestion += 1

        displayQuestion()

        ' set timer 
        If server.assessment.timeLimit > -1 Then ' assessment Time limit on
            If server.assessment.questions(currentQuestion).timeLimit > -1 Then ' question time limit set

                server.assessment.timeLeft = New TimeSpan(server.assessment.questions(currentQuestion).timeLimit * 10 ^ 7)
                timerLbl.Visible = True
                timerLbl.Text = server.assessment.timeLeft.ToString
            Else
                timerLbl.Visible = False

            End If

        End If

    End Sub

    Public Sub displayQuestion()
        'Teacher Objective 4a

        Dim question As Question = server.assessment.questions(currentQuestion)

        ' title
        titleLbl.Text = $"Question {currentQuestion + 1}/{server.assessment.questions.Count}"

        ' clear tabpage 
        partsTab.TabPages.Clear()
        partControls.Clear()


        ' create tabs
        For i = 0 To question.parts.Count - 1
            ' new part
            Dim part As Part = question.parts(i)
            partControls.Add(New List(Of Control))

            ' create tab
            Dim tab As New TabPage($"Part {"ABCD"(i)}")
            partsTab.TabPages.Add(tab)


            ' marks
            If question.parts(i).availableMark > 0 Then
                tab.Text &= $": {part.availableMark} marks "
            End If

            ' setup table
            Dim table As TableLayoutPanel = createTable({100}, {35, 55, 10})
            tab.Controls.Add(table)
            table.BackColor = Color.GhostWhite

            ' question label
            Dim questionLbl As New Label() : questionLbl.Name = part.ID & "questionLbl"
            controller.setControl(table, questionLbl, {0, 0}, {}, DockStyle.Fill, fontsize:=14)

            questionLbl.TextAlign = ContentAlignment.MiddleCenter
            questionLbl.Text = part.text


            ' add table and question label to part controls list
            partControls(i).AddRange({table, questionLbl})

            If {"Multiple Choice", "Multiple Answer", "Rank Order"}.Contains(part.type) Then


                ' randomly order answers for rank order 
                Dim answerList As New List(Of String)

                If part.type = "Rank Order" Then
                    Dim rand As New Random()

                    While answerList.Count < part.answers.Count
                        Dim index As Integer = rand.Next(part.answers.Count)
                        If Not answerList.Contains(part.answers(index)) Then
                            answerList.Add(part.answers(index))
                        End If
                    End While

                Else
                    answerList = part.answers
                End If


                ' answers table
                Dim answerTable As New TableLayoutPanel()
                answerTable.ColumnCount = 1
                answerTable.RowCount = part.answers.Count

                answerTable.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100))

                controller.setControl(table, answerTable, {0, 1}, {}, DockStyle.Fill)

                ' answers
                For a = 0 To part.answers.Count - 1

                    ' new row
                    answerTable.RowStyles.Add(New RowStyle(SizeType.AutoSize))

                    ' answer label
                    Dim answerLbl As New Label()

                    controller.setControl(answerTable, answerLbl, {0, a}, {0, 1, 3}, DockStyle.None)

                    answerLbl.TextAlign = ContentAlignment.TopCenter

                    answerLbl.Text = answerList(a)
                    answerLbl.Height = 25


                    answerLbl.Font = New Font(New FontFamily("Segoe UI"), 14)
                    answerLbl.Margin = New Padding(3)

                    ' add answer lbl to part controls list
                    partControls(i).Add(answerLbl)

                Next

            Else
                table.SetRowSpan(questionLbl, 2)
            End If

            ' type lbl
            Dim typeLbl As New Label() : typeLbl.Name = part.ID & "typeLbl"
            controller.setControl(table, typeLbl, {0, 2}, {}, DockStyle.Fill)
            typeLbl.Font = New Font(New FontFamily("Segoe UI"), 12)
            typeLbl.TextAlign = ContentAlignment.MiddleCenter

            typeLbl.Text = $"({part.type}: {controller.questionTypeDescription(part.type)})"


        Next


    End Sub
#End Region

#Region "Control Helpers"

    ''' <summary>
    ''' Creates table, add columns and rows
    ''' </summary>
    ''' <param name="columns">array of integers, 1 for each column, with its size as a percentage</param>
    ''' <param name="rows">array of integers, 1 for each row, with its size as a percentage</param>
    ''' <returns></returns>
    Public Function createTable(columns() As Integer, rows() As Integer) As TableLayoutPanel
        Dim table As New TableLayoutPanel
        table.BackColor = Color.Transparent
        table.Dock = DockStyle.Fill

        table.ColumnCount = columns.Length
        table.RowCount = rows.Length

        For Each c In columns
            table.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, c))
        Next

        For Each r In rows
            table.RowStyles.Add(New RowStyle(SizeType.Percent, r))
        Next
        Return table
    End Function



#End Region

#Region "Timer"

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        'Teacher Objective 3b, 4a
        ' timer - only if timer on and if on Question Page (not Answer page) 
        If server.assessment.timeLimit > -1 And nextBtn.ImageIndex = 1 Then

            If server.assessment.timeLeft.TotalSeconds = 0 Then
                nextQuestion()
            Else
                server.assessment.timeLeft -= New TimeSpan(0, 0, 0, 0, 100)

                timerLbl.Text = server.assessment.timeLeft.ToString("hh':'mm':'ss")
            End If
        End If

        server.sendAssessmentToAll()



        ' check recieved marks if not done 
        Try

            If server.assessment.status.Substring(0, 3) = "que" Then

                'Teacher Objective 4a
                countStudentResponses()
            ElseIf server.assessment.status.Substring(0, 3) = "ans" Then

                'Teacher Objective 4b
                If submittedAnswersLbl.Text = "" Then
                    countStudentMarksRecieved()
                End If

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub countStudentMarksRecieved()

        ' count recieved marks
        Dim studentCount As Integer = server.students.Count
        Dim s As Integer = 0

        Dim recievedMarks As Integer = 0
        Dim totalMark As Integer = 0

        ' for each student 
        While s < studentCount
                If server.students.Values(s).status = "question marked" Then

                ' add parts mark to total
                For Each mark In server.students.Values(s).marks(currentQuestion)
                    totalMark += mark
                Next

                recievedMarks += 1
                End If
                s += 1
            End While

        If studentCount = recievedMarks Then
            submittedAnswersLbl.Text = $"Average mark: {Math.Round(totalMark / studentCount, 2)}/{server.assessment.getQuestionMark(server.assessment.questions(currentQuestion))}"

            'show leaderboard
            If server.assessment.showPosition Then
                displayLeaderboard()
            End If
        End If


    End Sub
    Private Sub countStudentResponses()

        ' get num of answers
        Dim studentCount As Integer = server.students.Count
        Dim s As Integer = 0
        ' count submitted answers
        Dim submittedAnswers As Integer = 0


        While s < studentCount
            If server.students.Values(s).status = "que" & (currentQuestion + 1).ToString Then
                submittedAnswers += 1
            End If
            s += 1
        End While

        submittedAnswersLbl.Text = $"{submittedAnswers}/{server.students.Count} answers submitted"

    End Sub
#End Region

#Region "Music"
    Private Sub musicBtn_Click(sender As Object, e As EventArgs) Handles musicBtn.Click
        'Teacher Objective 3b


        ' mute or unmute music (stop/start)
        If musicBtn.ImageIndex = 0 Then
            My.Computer.Audio.Stop()
        Else
            PlayLoopingGameMusic()
        End If

        ' change image index
        musicBtn.ImageIndex = (musicBtn.ImageIndex + 1) Mod 2

    End Sub

    Sub PlayLoopingGameMusic()
        'Teacher Objective 3b
        My.Computer.Audio.Play(Application.StartupPath & "\Music\gameMusic.wav", AudioPlayMode.BackgroundLoop)
    End Sub



#End Region

End Class