Public Class S_LiveQuestions
    Property controller As AppController
    Property client As Client

    Property currentQuestionIndex As Integer
    Property questionPage As Boolean

    Property questionNumbers As List(Of Integer)
    Property currentQuestion As Integer

    Property itemSelected As Boolean

    Property timeLeft As TimeSpan

    Property partControls As New List(Of List(Of Control))
    Sub New(controller_ As AppController, client_ As Client)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        controller = controller_
        client = client_

        currentQuestionIndex = 0

        itemSelected = False
        questionPage = True
    End Sub



#Region "Form"
    Private Sub S_LiveQuestions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Student Objectives 2a, 2b, 3a, 3b

        ' set colours
        Me.BackColor = Color.White


        BackBtn.ForeColor = Color.White
        BackBtn.BackColor = controller.palette(3)

        nextBtn.ForeColor = Color.White
        nextBtn.BackColor = controller.palette(2)

        previousBtn.ForeColor = Color.White
        previousBtn.BackColor = controller.palette(2)



        ' setup page
        Me.Text = $"{client.assessment.Name} - {client.student.Name}"

        previousBtn.Enabled = False
        previousBtn.BackColor = Color.LightGray




        If client.assessment.gameMode Then
            ' game mode
            previousBtn.Visible = False
            Timer.Start()


            If client.assessment.timeLimit = -1 Then
                timerLbl.Visible = False
            End If

        Else ' test mode

            ' questions order
            setQuestionOrder()
            currentQuestion = questionNumbers(currentQuestionIndex)

            ' disable next btn
            If currentQuestionIndex = client.assessment.questions.Count - 1 Then
                nextBtn.ImageIndex = 2

                nextBtn.BackgroundImageLayout = ImageLayout.Zoom
            End If

            ' timer
            If client.assessment.timeLimit > -1 Then
                ' Student objective 3a
                Timer.Start()
                timeLeft = New TimeSpan(client.assessment.timeLimit * 60 * 10 ^ 7)
                timerLbl.Text = timeLeft.ToString()
            Else
                timerLbl.Visible = False
            End If

        End If


        displayQuestion()
        ' setup student answers
        client.student.answers = New List(Of List(Of String))
        For i = 0 To client.assessment.questions.Count - 1
            client.student.answers.Add(New List(Of String))
            For Each p In client.assessment.questions(i).parts
                client.student.answers(i).Add(String.Empty)
            Next
        Next

    End Sub



#End Region

#Region "Navigation"
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        client.student.status = "leaving"
        client.sendStudent()
    End Sub


    Private Sub previousBtn_Click(sender As Object, e As EventArgs) Handles previousBtn.Click

        getStudentAnswers()

        currentQuestionIndex -= 1
        currentQuestion = questionNumbers(currentQuestionIndex)

        ' disable prev btn
        If currentQuestionIndex = 0 Then
            previousBtn.Enabled = False
            previousBtn.BackColor = Color.LightGray
        End If

        ' enable next btn
        If currentQuestionIndex < client.assessment.questions.Count - 1 Then
            nextBtn.ImageIndex = 1
        End If

        displayQuestion()



        If Not (client.assessment.gameMode) Then

            displayStudentAnswers()
            ' show correct anwers
        End If

    End Sub

    Private Sub nextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click

        getStudentAnswers()
        If client.assessment.gameMode Then
            ' game mode
            client.student.status = "que" & (currentQuestion + 1).ToString
            '
            client.sendStudent()

            gameModeEndQuestion(True)

            currentQuestionIndex = currentQuestion

        Else ' test mode
            If nextBtn.ImageIndex = 1 Then


                currentQuestionIndex += 1
                currentQuestion = questionNumbers(currentQuestionIndex)


                ' enable prev btn
                If currentQuestionIndex = 1 Then
                    previousBtn.Enabled = True
                    previousBtn.BackColor = controller.palette(2)
                End If

                ' last question -change next btn
                If currentQuestionIndex = client.assessment.questions.Count - 1 Then
                    nextBtn.ImageIndex = 2

                    nextBtn.BackgroundImageLayout = ImageLayout.Zoom
                End If


                displayQuestion()


                If Not (client.assessment.gameMode) Then

                    displayStudentAnswers()
                    ' show correct anwers
                End If

            Else
                ' Student objective 3c
                markTest()
                ' submit
                client.sendStudent()
                client.student.status = "assessment submitted"
                Timer.Stop()


                Dim nextForm As New S_Results(controller, client)
                controller.SwitchForms(Me, nextForm)




            End If
        End If


    End Sub



#End Region


#Region "Questions Setup"

    Private Sub setQuestionOrder()
        ' Student objective 3b
        questionNumbers = New List(Of Integer)

        ' arrange questions in random order
        If client.assessment.randomOrder Then
            Dim rand As New Random()
            Dim num As Integer
            While questionNumbers.Count < client.assessment.questions.Count
                num = rand.Next(0, client.assessment.questions.Count)
                If Not questionNumbers.Contains(num) Then
                    questionNumbers.Add(num)
                End If
            End While
        Else
            For i = 0 To client.assessment.questions.Count - 1
                questionNumbers.Add(i)
            Next
        End If
    End Sub


    Sub getStudentAnswers()
        ' Student objective 2b, 3c

        ' get student's answers from their control inputs

        For p = 0 To client.student.answers(currentQuestion).Count - 1
            Dim answer As String = ""
            Select Case client.assessment.questions(currentQuestion).parts(p).type
                Case "Short Text"
                    answer = partControls(p)(0).Text

                Case "Long Text"
                    answer = partControls(p)(0).Text

                Case "Multiple Choice"
                    For a = 0 To partControls(p).Count - 1
                        If partControls(p)(a).ForeColor = Color.White Then
                            answer = a.ToString
                        End If
                    Next

                Case "Multiple Answer"
                    For a = 0 To partControls(p).Count - 1
                        If partControls(p)(a).ForeColor = Color.White Then
                            answer &= a.ToString
                        End If
                    Next

                Case "Numerical"
                    answer = CType(partControls(p)(0), NumericUpDown).Value

                Case "Rank Order"
                    For Each item As String In CType(partControls(p)(2), ListBox).Items
                        answer &= client.assessment.questions(currentQuestion).parts(p).answers.IndexOf(item).ToString
                    Next
            End Select

            client.student.answers(currentQuestion)(p) = answer
        Next

    End Sub

    Sub displayStudentAnswers()
        ' Student objective 2a, 3b

        ' display the student's answers in the part controls(from when they have previously answered this question) 

        ' for each part

        For p = 0 To client.student.answers(currentQuestion).Count - 1
            Dim answer As String = client.student.answers(currentQuestion)(p)
            ' get student's entered answer
            Select Case client.assessment.questions(currentQuestion).parts(p).type
                Case "Short Text"
                    partControls(p)(0).Text = answer
                Case "Long Text"
                    partControls(p)(0).Text = answer
                Case "Multiple Choice"
                    If answer.Length > 0 Then
                        partControls(p)(Val(answer)).BackColor = controller.palette(1)
                        partControls(p)(Val(answer)).ForeColor = Color.White
                    End If

                Case "Multiple Answer"
                    For Each a As Char In answer
                        partControls(p)(Val(a)).BackColor = controller.palette(1)
                        partControls(p)(Val(a)).ForeColor = Color.White
                    Next
                Case "Rank Order"
                    If answer.Length > 1 Then
                        CType(partControls(p)(2), ListBox).Items.Clear()
                        For Each a As Char In answer
                            CType(partControls(p)(2), ListBox).Items.Add(client.assessment.questions(currentQuestion).parts(p).answers(Val(a)))
                        Next
                    End If

                Case "Numerical"
                    CType(partControls(p)(0), NumericUpDown).Value = Val(answer)
            End Select
        Next

    End Sub



    Private Function getPartFromControl(control As Control) As Integer
        ' get part number that a control belongs to
        For p = 0 To partControls.Count - 1
            For Each c As Control In partControls(p)
                If control.Equals(c) Then
                    Return p
                End If
            Next
        Next
        Return -1
    End Function


    Public Sub displayQuestion()
        ' Student objective 2a, 2b, 3b

        Dim question As Question = client.assessment.questions(currentQuestion)

        ' controls list
        partControls = New List(Of List(Of Control))

        ' title
        titleLbl.Text = $"Question {currentQuestionIndex + 1}/{client.assessment.questions.Count} (Topic: {question.category})"

        ' clear tabpage 
        partsTab.TabPages.Clear()


        ' create tabs
        For i = 0 To question.parts.Count - 1
            Dim part As Part = question.parts(i)

            ' create tab
            Dim tab As New TabPage($"Part {"ABCD"(i)}")
            partsTab.TabPages.Add(tab)

            ' control list
            Dim currentPartControls As New List(Of Control)

            ' marks
            If part.availableMark > 0 Then
                tab.Text &= $": {part.availableMark} marks "
            End If

            ' setup table
            Dim table As TableLayoutPanel = controller.createTable({100}, {30, 70, 10})
            tab.Controls.Add(table)

            ' question label
            Dim questionLbl As New Label()
            controller.setControl(table, questionLbl, {0, 0}, {}, DockStyle.Fill)


            questionLbl.Font = New Font(New FontFamily("Segoe UI"), 14)
            questionLbl.TextAlign = ContentAlignment.MiddleCenter
            questionLbl.Text = part.text

            itemSelected = False

            'question type 
            Select Case part.type
                Case "Short Text"
                    ShortTextQuestion(table, part, currentPartControls)
                Case "Long Text"
                    LongTextQuestion(table, part, currentPartControls)
                Case "Multiple Choice"
                    MultipleChoiceQuestion(table, part, currentPartControls)
                Case "Multiple Answer"
                    MultipleAnswerQuestion(table, part, currentPartControls)
                Case "Rank Order"
                    RankQuestion(table, part, currentPartControls)
                Case "Numerical"
                    NumericalQuestion(table, part, currentPartControls)
            End Select

            partControls.Add(currentPartControls)



            ' type lbl
            Dim typeLbl As New Label()
            controller.setControl(table, typeLbl, {0, 2}, {}, DockStyle.Fill)
            typeLbl.Font = New Font(New FontFamily("Segoe UI"), 12)
            typeLbl.TextAlign = ContentAlignment.MiddleCenter

            typeLbl.Text = $"({part.type}: {controller.questionTypeDescription(part.type)})"


        Next


    End Sub

#End Region

#Region "Part Setup"


    Public Sub ShortTextQuestion(ByRef mainTable As TableLayoutPanel, part As Part, ByRef partControls As List(Of Control))
        Dim fontfam As New FontFamily("Segoe UI")

        ' setup table
        Dim table As TableLayoutPanel = controller.createTable({100}, {100})
        mainTable.Controls.Add(table, 0, 1)


        ' answer label
        Dim answerLbl As New Label()
        controller.setControl(table, answerLbl, {0, 0}, {}, DockStyle.Fill)
        answerLbl.TextAlign = ContentAlignment.MiddleCenter
        answerLbl.Font = New Font(fontfam, 15)
        answerLbl.Text = "Your Answer:"

        ' answer input
        Dim answerInput As New TextBox()
        controller.setControl(table, answerInput, {0, 1}, {}, DockStyle.Fill)
        answerInput.Margin = New Padding(10)
        answerInput.Size = New Size(500, 50)
        answerInput.Font = New Font(fontfam, 20)
        answerInput.MaxLength = 250

        partControls.Add(answerInput)


        ' part controls: 0 answerInput

    End Sub

    Public Sub LongTextQuestion(ByRef mainTable As TableLayoutPanel, part As Part, ByRef partControl As List(Of Control))
        Dim fontfam As New FontFamily("Segoe UI")

        ' setup table
        Dim table As TableLayoutPanel = controller.createTable({100}, {100})
        mainTable.Controls.Add(table, 0, 1)


        'answer Label
        Dim answerLbl As New Label()
        controller.setControl(table, answerLbl, {0, 0}, {}, DockStyle.Fill)

        answerLbl.TextAlign = ContentAlignment.BottomLeft
        answerLbl.Font = New Font(fontfam, 15)
        answerLbl.Text = "Your Answer:"

        ' answer input
        Dim answerInput As New RichTextBox()
        controller.setControl(table, answerInput, {0, 1}, {}, DockStyle.Fill)

        answerInput.Font = New Font(fontfam, 12)
        answerInput.MaxLength = 250

        partControl.Add(answerInput)


        ' part controls: 0 answerInput


    End Sub

    Public Sub NumericalQuestion(ByRef mainTable As TableLayoutPanel, part As Part, ByRef partControl As List(Of Control))
        Dim fontfam As New FontFamily("Segoe UI")

        ' setup table
        Dim table As TableLayoutPanel = controller.createTable({100}, {30, 70})
        mainTable.Controls.Add(table, 0, 1)


        ' answer label
        Dim answerLbl As New Label()
        controller.setControl(table, answerLbl, {0, 0}, {}, DockStyle.Fill)
        answerLbl.TextAlign = ContentAlignment.MiddleCenter
        answerLbl.Font = New Font(fontfam, 20)
        answerLbl.Text = "Your Answer:"

        ' answer input
        Dim answerInput As New NumericUpDown()
        answerInput.DecimalPlaces = part.answers(1)
        controller.setControl(table, answerInput, {0, 1}, {}, DockStyle.Fill)

        answerInput.Margin = New Padding(10)
        answerInput.Size = New Size(500, 50)
        answerInput.Font = New Font(fontfam, 20)

        partControl.Add(answerInput)

        ' part controls: 0 answerINput
    End Sub


#Region "Multiple Choice Question"
    Public Sub MultipleChoiceQuestion(ByRef mainTable As TableLayoutPanel, part As Part, ByRef partControl As List(Of Control))
        Dim fontfam As New FontFamily("Segoe UI")

        ' Table 
        'determine num of rows
        Dim ansCount As Integer = 0
        For Each a In part.answers
            If a <> "" Then
                ansCount += 1
            End If
        Next

        Dim columns(ansCount - 1) As Integer
        For c = 0 To ansCount - 1
            columns(c) = 100 / ansCount
        Next

        ' create table
        Dim table As TableLayoutPanel = controller.createTable({100}, columns)
        mainTable.Controls.Add(table, 0, 1)

        For i = 0 To ansCount - 1
            Dim answerBtn As New Button()
            answerBtn.BackColor = controller.palette(0)
            controller.setControl(table, answerBtn, {0, i}, {}, DockStyle.Fill)
            answerBtn.Margin = New Padding(2)
            answerBtn.TextAlign = ContentAlignment.MiddleCenter
            answerBtn.Text = part.answers(i)

            AddHandler answerBtn.Click, New EventHandler(AddressOf singleAnswerClick)

            answerBtn.BackColor = controller.palette(3)
            answerBtn.ForeColor = Color.Black

            partControl.Add(answerBtn)

        Next


        ' part controls: 0 answer0, 1 answer1, 2 answer3... 5 answer5
    End Sub


    Private Sub singleAnswerClick(sender As Object, e As EventArgs)
        Dim btnClicked As Button = CType(sender, Button)
        Dim part As Integer = getPartFromControl(btnClicked)

        ' set all btn colours to unselected
        For Each b As Control In partControls(part)
            b.BackColor = controller.palette(3)
            b.ForeColor = Color.Black
        Next

        ' set clicked button colours to selected
        CType(sender, Button).BackColor = controller.palette(1)
        CType(sender, Button).ForeColor = Color.White

        client.student.answers(currentQuestion)(part) = CType(sender, Button).Text

    End Sub


#End Region

#Region "Multiple Answer Question"
    Public Sub MultipleAnswerQuestion(ByRef mainTable As TableLayoutPanel, part As Part, ByRef partControl As List(Of Control))
        Dim fontfam As New FontFamily("Segoe UI")

        ' Table 
        'determine num of rows
        Dim ansCount As Integer = 0
        For Each a In part.answers
            If a <> "" Then
                ansCount += 1
            End If
        Next

        Dim columns(ansCount - 1) As Integer
        For c = 0 To ansCount - 1
            columns(c) = 100 / ansCount
        Next

        ' create table
        Dim table As TableLayoutPanel = controller.createTable({100}, columns)
        mainTable.Controls.Add(table, 0, 1)

        For i = 0 To ansCount - 1
            Dim answerBtn As New Button()
            controller.setControl(table, answerBtn, {0, i}, {}, DockStyle.Fill)
            answerBtn.Margin = New Padding(2)
            answerBtn.Text = part.answers(i)

            AddHandler answerBtn.Click, New EventHandler(AddressOf MultipleAnswerClick)

            answerBtn.BackColor = controller.palette(3)
            answerBtn.ForeColor = Color.Black


            partControl.Add(answerBtn)

        Next

        ' part controls: 0 answer0, 1 answer1, 2 answer3... 5 answer5
    End Sub

    Private Sub MultipleAnswerClick(sender As Object, e As EventArgs)
        Dim btnClicked As Button = CType(sender, Button)
        Dim part As Integer = getPartFromControl(btnClicked)
        Dim answerText As String = btnClicked.Text

        ' select
        If CType(sender, Button).BackColor = controller.palette(3) Then
            CType(sender, Button).BackColor = controller.palette(1)
            CType(sender, Button).ForeColor = Color.White

        ElseIf CType(sender, Button).BackColor = controller.palette(1) Then ' deselect
            CType(sender, Button).BackColor = controller.palette(3)
            CType(sender, Button).ForeColor = Color.Black

        End If

        For i = 0 To client.assessment.questions(currentQuestion).parts(part).answers.Count - 1

        Next



    End Sub

#End Region

#Region "Rank Question"
    Public Sub RankQuestion(ByRef mainTable As TableLayoutPanel, part As Part, ByRef partControl As List(Of Control))
        Dim fontfam As New FontFamily("Segoe UI")

        ' Table 
        Dim table As New TableLayoutPanel
        table.Dock = DockStyle.Fill

        table.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 50))
        table.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100))

        table.RowStyles.Add(New RowStyle(SizeType.Percent, 50))
        table.RowStyles.Add(New RowStyle(SizeType.Percent, 50))

        mainTable.Controls.Add(table, 0, 1)

        ' Listbox
        Dim rankListbox As New ListBox()
        rankListbox.Dock = DockStyle.Fill

        table.Controls.Add(rankListbox, 1, 0)
        table.SetRowSpan(rankListbox, 2)


        ' populate listbox
        Dim rnd As New Random()
        Dim used As New List(Of Integer)
        Do Until rankListbox.Items.Count = part.answers.Count
            Dim i As Integer = rnd.Next(part.answers.Count)
            If Not used.Contains(i) Then
                used.Add(i)
                rankListbox.Items.Add(part.answers(i))
            End If
        Loop


        ' Up Down Btns

        For b = 0 To 1
            Dim btn As New Button()
            btn.BackgroundImage = UpDownImgList.Images(b)
            btn.BackgroundImageLayout = ImageLayout.Zoom
            btn.BackColor = controller.palette(2)
            btn.ForeColor = Color.White
            btn.FlatStyle = FlatStyle.Flat
            btn.Width = 50
            btn.Height = 50
            table.Controls.Add(btn, 0, 1 - b)

            If b = 0 Then
                btn.Anchor = AnchorStyles.Top
                AddHandler btn.Click, New EventHandler(AddressOf downBtnClick)

            Else
                btn.Anchor = AnchorStyles.Bottom
                AddHandler btn.Click, New EventHandler(AddressOf upBtnClick)
            End If


            partControl.Add(btn)
        Next


        partControl.Add(rankListbox)

        ' part controls: 0  downbtn, 1 upbtn, 2 listbox
    End Sub

    Private Sub upBtnClick(sender As Object, e As EventArgs)
        Dim upBtn As Button = CType(sender, Button)
        Dim part As Integer = getPartFromControl(upBtn)


        Dim listbox As ListBox = partControls(part)(2)

        If listbox.SelectedIndex > 0 Then
            Dim selected As String = listbox.SelectedItem
            Dim above As String = listbox.Items(listbox.SelectedIndex - 1)

            listbox.Items(listbox.SelectedIndex) = above
            listbox.Items(listbox.SelectedIndex - 1) = selected
            listbox.SelectedIndex -= 1
        End If
    End Sub

    Private Sub downBtnClick(sender As Object, e As EventArgs)
        Dim downBtn As Button = CType(sender, Button)
        Dim part As Integer = getPartFromControl(downBtn)

        Dim listbox As ListBox = partControls(part)(2)

        If listbox.SelectedIndex > -1 And listbox.SelectedIndex < listbox.Items.Count - 1 Then
            Dim selected As String = listbox.SelectedItem
            Dim below As String = listbox.Items(listbox.SelectedIndex + 1)

            listbox.Items(listbox.SelectedIndex) = below
            listbox.Items(listbox.SelectedIndex + 1) = selected
            listbox.SelectedIndex += 1
        End If
    End Sub
#End Region

#End Region

#Region "Submitted"

    Private Sub markQuestion(q As Integer)
        ' Student objective 2b, 2e, 3c


        client.student.marks.Add(New List(Of Integer))
        For p = 0 To client.assessment.questions(q).parts.Count - 1
            client.student.marks(q).Add(0)
            ' part
            Dim part As Part = client.assessment.questions(q).parts(p)

            Select Case part.type
                Case "Short Text"
                    If client.student.answers(q)(p).ToLower = part.answers(Val(part.correctAnswer)).ToLower Then
                        client.student.marks(q)(p) = part.availableMark
                    End If

                Case "Numerical"
                    ' 2 marks available 
                    If part.availableMark = 2 Then
                        If client.student.answers(q)(p) = part.answers(0) Then
                            ' 2 marks if answer is correct
                            client.student.marks(q)(p) = 2
                        ElseIf Val(client.student.answers(q)(p)) > Val(part.answers(0)) - Val(part.answers(2)) And Val(client.student.answers(q)(p)) < Val(part.answers(0)) + Val(part.answers(2)) Then
                            ' 1 marks if answer is incorrect but within error range
                            client.student.marks(q)(p) = 1
                        Else
                            client.student.marks(q)(p) = 0
                        End If
                        ' 1 or 0 marks avaialable
                    Else
                        If client.student.answers(q)(p) = part.answers(0) Then
                            ' 1 mark if correct
                            client.student.marks(q)(p) = Val(part.availableMark)
                        End If
                    End If

                Case "Multiple Choice"
                    ' 1 mark for correct answer
                    If client.student.answers(q)(p) = part.correctAnswer Then
                        client.student.marks(q)(p) = part.availableMark
                    End If

                Case "Multiple Answer"
                    ' 1 mark per answer
                    If part.availableMark > 1 Then ' 1 mark per answer

                        For i = 0 To client.assessment.questions(q).parts(p).answers.Count - 1
                            ' add marks
                            If part.correctAnswer.Contains(i) = client.student.answers(q)(p).Contains(i) Then
                                client.student.marks(q)(p) += 1
                            End If

                        Next

                    Else ' 1 or 0 marks for all correct answers
                        If client.student.answers(q)(p) = part.correctAnswer Then
                            client.student.marks(q)(p) = part.availableMark
                        End If
                    End If

                Case "Rank Order"
                    If part.availableMark > 1 Then ' 1 mark per answer

                        For i = 0 To client.assessment.questions(q).parts(p).answers.Count - 1
                            'add marks
                            If Val(client.student.answers(q)(p)(i)) = i Then ' compare each index in student answer with index i
                                client.student.marks(q)(p) += 1
                            End If
                        Next

                    Else ' 1 or 0 marks 
                        Dim correct As Boolean = True
                        For index = 0 To client.student.answers(q)(p).Length - 1 ' compare each index in student answer with index i
                            If Val(client.student.answers(q)(p)(index)) <> index Then
                                correct = False
                            End If
                        Next

                        If correct Then
                            client.student.marks(q)(p) = part.availableMark
                        End If
                    End If

                Case "Long Text"
                    client.student.marks(q)(p) = 0
            End Select

        Next
    End Sub
    Private Sub markTest()
        ' Student objective 2b, 2e, 3c

        For q = 0 To client.assessment.questions.Count - 1
            ' question
            markQuestion(q)
        Next
    End Sub


    Private Sub gameModeEndQuestion(studentSubmitted As Boolean)
        ' Student objective 2d
        ' disable controls
        For Each page As TabPage In partsTab.TabPages
            page.Enabled = False
        Next

        If studentSubmitted Then
            statusLbl.Text = "Answer Submitted. Waiting for teacher..."

        Else
            ' display marks
            Dim parts As List(Of Part) = client.assessment.questions(currentQuestion).parts
            For p = 0 To parts.Count - 1
                partsTab.TabPages(p).Text = $"Part {"ABCD"(p)} : {client.student.marks(currentQuestion)(p)}/{parts(p).availableMark} marks"
            Next

            statusLbl.Text = $"Marks for this question: {client.student.getQuestionMark(client.student.marks(currentQuestion))}/{client.assessment.getQuestionMark(client.assessment.questions(currentQuestion))}"

        End If



    End Sub
#End Region

#Region "Timer"

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        ' test mode 
        If Not client.assessment.gameMode Then

            ' Student objective 3a
            'timer
            If client.assessment.timeLimit > -1 Then
                timerLbl.Text = timeLeft.ToString("hh':'mm':'ss")

                ' reduce time 
                timeLeft -= New TimeSpan(0, 0, 0, 0, 100)
                client.student.status = "tim " & timeLeft.ToString("hh':'mm':'ss")
            End If


            ' Student objective 3c
            ' time ended
            If timeLeft.TotalSeconds = 0 Then
                Timer.Stop()

                markTest()
                ' submit
                client.student.status = "assessment submitted"
                client.sendStudent()

                Dim nextForm As New S_Results(controller, client)
                controller.SwitchForms(Me, nextForm)

            End If

        End If


        ' game mode settings
        If client.assessment.gameMode Then

            ' timer 
            If client.assessment.timeLimit > -1 Then
                ' timer label
                timerLbl.Text = client.assessment.timeLeft.ToString("hh':'mm':'ss")
            End If




            If client.assessment.status.Substring(0, 3) = "ans" And questionPage Then
                ' Student objective 2b
                'switch to answers page
                statusLbl.Text = ""
                timerLbl.Visible = False

                ' mark
                getStudentAnswers()
                markQuestion(currentQuestion)
                gameModeEndQuestion(False)

                client.student.status = "question marked"
                client.sendStudent()

                questionPage = False
                nextBtn.Enabled = False



            ElseIf client.assessment.status = "que" & (currentQuestion + 1) And Not questionPage Then
                ' Student objective 2d
                ' next question
                client.student.position = -1
                statusLbl.Text = ""
                timerLbl.Visible = True

                currentQuestion = client.assessment.status.Substring(3, client.assessment.status.Length - 3)
                displayQuestion()

                questionPage = True
                nextBtn.Enabled = True


                client.student.status = "que" & (currentQuestion).ToString



                ' results page
            ElseIf client.assessment.status.Substring(0, 3) = "end" Then
                ' Student objective 2e

                Dim nextform As New S_Results(controller, client)
                controller.SwitchForms(Me, nextform)


            End If


            ' Student objective 2c
            ' position
            If client.student.position > -1 And statusLbl.Text = "" Then

                statusLbl.Text = $"Your overall score is {client.student.getTotalMark}/{client.assessment.getTotalMark(currentQuestion)} and your position is {controller.getPositionText(client.student.position)}"

            End If


        End If


    End Sub



#End Region


End Class