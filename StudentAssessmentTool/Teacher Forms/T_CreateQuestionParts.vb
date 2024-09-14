Public Class T_CreateQuestionParts
    Property controller As AppController
    Property parts As List(Of Part)
    Property controlsCreated As Boolean
    Property canEdit As Boolean

    ''' <summary>
    ''' list of lists: 1 list per part
    ''' each part contains: (0): marks input, (1): text input, 
    '''                           - (2): num of answers, (3,5,7,9...): answer checkboxes,  (4, 6, 8, 10...): answer inputs 
    '''                           - (2): answer
    ''' </summary>
    ''' <returns></returns>
    Property partControls As List(Of List(Of Control))

    Sub New(controller_ As AppController, edit As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        controller = controller_

        controlsCreated = False
        canEdit = edit
    End Sub


#Region "Form"
    Private Sub T_CreateQuestionParts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' colours

        Me.BackColor = Color.White
        BackBtn.BackColor = controller.palette(3)
        BackBtn.ForeColor = controller.palette(3)

        DeleteBtn.BackColor = controller.palette(3)
        DeleteBtn.ForeColor = Color.White

        SaveBtn.BackColor = controller.palette(1)
        SaveBtn.ForeColor = Color.White


        ' update question properties

        ' Teacher Objective 2b
        ' update title lbl - get category
        Dim question As Object() = controller.DBController.SelectValues("Questions", "Category, Timer", $"AssessmentID='{controller.currentAssessmentID}' AND QuestionNumber={controller.currentQuestionNum}")(0)
        titleLbl.Text = $"Question  {controller.currentQuestionNum + 1}"

        Cursor = Cursors.WaitCursor
        ' update category
        Dim categories As List(Of Object()) = controller.DBController.SelectValues("Questions", "Category, QuestionNumber", $"AssessmentID='{controller.currentAssessmentID}'")
        For Each c In categories ' get current categories
            If c(0) <> "" Then
                'add category
                If Not categoryCombo.Items.Contains(c(0)) Then
                    categoryCombo.Items.Add(c(0))
                End If
            End If
        Next
        categoryCombo.SelectedItem = question(0)

        Cursor = Cursors.Default

        ' Teacher Objective 2f
        ' timer
        If Val(question(1)) > -1 Then
            TimeCheckbox.Checked = True
            TimeChooser.Enabled = True
            TimeChooser.Value = Val(question(1))
        Else
            TimeCheckbox.Checked = False
            TimeChooser.Enabled = False
        End If


        'Teacher Objective 2c, 2d
        ' parts
        GetParts()
        displayParts()
        partsTab.SelectedIndex = 0

        ' disable add btn
        If parts.Count = 4 Then
            NewPartMenuStrip.Enabled = False
        End If



        ' disable btns based on CanEdit
        If Not canEdit Or controller.sharedAssessments Then
            NewPartMenuStrip.Enabled = False
            categoryCombo.Enabled = False
            TimeChooser.Enabled = False
            TimeCheckbox.Enabled = False
            SaveBtn.Enabled = False
            DeleteBtn.Enabled = False
            SaveBtn.BackColor = Color.LightGray
            DeleteBtn.BackColor = Color.LightGray


            For Each list As List(Of Control) In partControls
                For Each con As Control In list
                    con.Enabled = False
                Next
            Next
        End If





    End Sub

#End Region

#Region "Question Setup"

    Private Sub GetParts()
        Cursor = Cursors.WaitCursor
        parts = New List(Of Part)
        ' get parts
        Dim CurrentParts As List(Of Object()) = controller.DBController.SelectValues("Parts", "*", $"QuestionNumber={controller.currentQuestionNum} AND AssessmentID='{controller.currentAssessmentID}'")
        For Each p In CurrentParts
            Dim part As New Part()
            part.setProperties(p(0), p(3), p(4), {p(5), p(6), p(7), p(8), p(9), p(10)}, p(11), p(12))
            parts.Add(part)
        Next

        Cursor = Cursors.Default
    End Sub

    Private Sub displayParts()
        ' create part tabs
        partsTab.TabPages.Clear()
        partControls = New List(Of List(Of Control))
        For i = 0 To parts.Count - 1
            createTab(i)
        Next
        controlsCreated = True
    End Sub


    Public Sub createTab(i As Integer)


        ' add part tab
        Dim partChars As String = "ABCD"

        Dim tab As New TabPage($"{partChars(i)} ({parts(i).type})")
        tab.BackColor = Color.White
        partsTab.TabPages.Add(tab)

        partControls.Add(New List(Of Control))


        ' create table panel
        Dim table As New TableLayoutPanel()
        table.Dock = DockStyle.Fill
        table.ColumnCount = 2
        table.RowCount = 11

        tab.Controls.Add(table)


        ' rows and columns

        ' 2 columns
        table.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50))
        table.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50))

        ' marks rows
        table.RowStyles.Add(New RowStyle(SizeType.Percent, 7))
        table.RowStyles.Add(New RowStyle(SizeType.Percent, 9))

        ' question rows
        table.RowStyles.Add(New RowStyle(SizeType.Percent, 8))
        table.RowStyles.Add(New RowStyle(SizeType.Percent, 12))
        table.RowStyles.Add(New RowStyle(SizeType.Percent, 10))

        ' answers rows
        For c = 0 To 2
            table.RowStyles.Add(New RowStyle(SizeType.Percent, 7))
            table.RowStyles.Add(New RowStyle(SizeType.Percent, 11))
        Next

        ' Teacher Objective 2f
        ' Marks
        Dim marksLbl As New Label()
        marksLbl.Text = "Marks:"
        marksLbl.TextAlign = ContentAlignment.BottomLeft



        Dim marksInput As New ComboBox()
        marksInput.Width = 350
        Select Case parts(i).type
            Case "Short Text", "Multiple Choice"
                marksInput.Items.Add("0")
                marksInput.Items.Add("1")
            Case "Numerical"
                marksInput.Items.Add("0")
                marksInput.Items.Add("1")
                marksInput.Items.Add("2 (2 for accurate answer, 1 for answer within error range)")
            Case "Multiple Answer", "Rank Order"
                marksInput.Items.Add("0")
                marksInput.Items.Add("1 (1 mark for all answers correct)")

                If parts(i).answers.Count < 2 Then
                    marksInput.Items.Add(2 & " (1 mark per correct answer)")
                Else
                    marksInput.Items.Add(parts(i).answers.Count.ToString & " (1 mark per correct answer)")
                End If

            Case "Long Text"
                For item = 0 To 11
                    marksInput.Items.Add(item.ToString)
                Next
        End Select

        marksInput.DropDownStyle = ComboBoxStyle.DropDownList
        marksInput.SelectedIndex = 0
        For Each m In marksInput.Items
            If Val(m(0)) = parts(i).availableMark Then
                marksInput.SelectedItem = m
            End If
        Next

        'Teacher Objective 2c
        ' Question Text
        Dim textLbl As New Label()
        textLbl.Text = "Question Text:"
        textLbl.TextAlign = ContentAlignment.BottomLeft

        Dim textInput As New RichTextBox() : textInput.Name = i & "questionInput"
        textInput.ZoomFactor = 1.2
        textInput.Text = parts(i).text ' update with current part text
        textInput.MaxLength = 250

        ' Marks/Question Positions
        Dim marksRow As Integer ' marks row
        Dim questionRow(1) As Integer ' {question Lbl row, questionInput row span}

        ' parts control list 
        partControls(i).AddRange({marksInput, textInput})

        'Teacher Objective 2d
        'add controlls
        Select Case parts(i).type
            Case "Short Text"
                ShortTextQuestion(i, table, questionRow, marksRow, partControls(i))
            Case "Long Text"
                LongTextQuestion(i, table, questionRow, marksRow)
            Case "Numerical"
                NumericalQuestion(i, table, questionRow, marksRow, partControls(i))
            Case "Multiple Choice", "Multiple Answer", "Rank Order"
                PluralAnswerQuestion(i, table, questionRow, marksRow, partControls(i))
        End Select

        ' reposition of question and marks 
        controller.setControl(table, marksLbl, {0, marksRow}, {2, 3})
        controller.setControl(table, marksInput, {0, marksRow + 1}, {3})
        controller.setControl(table, textLbl, {0, questionRow(0)}, {2, 3}, DockStyle.Fill)
        controller.setControl(table, textInput, {0, questionRow(0) + 1}, {}, DockStyle.Fill, 2, questionRow(1))
        table.SetRowSpan(textInput, questionRow(1))

    End Sub

#End Region

#Region "Navigation"
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        ' go back message
        If canEdit Then
            Dim ans As MsgBoxResult = MsgBox("Are you sure you want to go back? Any changes you have made will not be saved", MessageBoxButtons.YesNo)
            If ans = MsgBoxResult.Yes Then

                ' check if question is empty --> delete
                Dim qParts As List(Of Object()) = controller.DBController.SelectValues("Parts", "*", $"QuestionNumber={controller.currentQuestionNum} AND AssessmentID='{controller.currentAssessmentID}'")

                If qParts.Count = 0 Then
                    controller.DBController.DeleteValues("Questions", $"QuestionNumber={controller.currentQuestionNum} AND AssessmentID='{controller.currentAssessmentID}'")
                End If

                'switch form
                Dim nextForm As New T_ViewAssessment(controller)
                controller.SwitchForms(Me, nextForm)


            End If
        Else

            'switch form
            Dim nextForm As New T_ViewAssessment(controller)
            controller.SwitchForms(Me, nextForm)
        End If

    End Sub


#End Region

#Region "Control Event Handlers"
    Private Sub NumericalQuestionDecimalInputChange(sender As NumericUpDown, e As EventArgs)
        ' change the number of decimal places for the Answer and Range numeric inputs when the user changes the Decimal input value

        ' get part id
        Dim part As Integer = 0

        For p = 0 To partControls.Count - 1
            If partControls(p).Contains(sender) Then
                part = p
            End If

        Next

        ' get answer and range input controls
        Dim answerInput As NumericUpDown = CType(partControls(part)(2), NumericUpDown)
        Dim rangeInput As NumericUpDown = CType(partControls(part)(4), NumericUpDown)

        ' update decimal places
        answerInput.DecimalPlaces = sender.Value
        rangeInput.DecimalPlaces = sender.Value + 1

    End Sub

    Private Sub hideShowAnswers(numOfAnswers As Integer, controls As List(Of Control))
        ' hide/ show the appropriate number of answer inputs
        For i = 0 To 5

            Dim answerCheckBox As Control = controls(3 + i * 2)
            Dim answerInput As TextBox = controls(4 + i * 2)



            If i < numOfAnswers Then
                answerCheckBox.Visible = True
                answerInput.Visible = True
            Else
                answerCheckBox.Visible = False
                answerInput.Visible = False
            End If
        Next
    End Sub

    Private Sub MultiQuestionNumberChange(sender As NumericUpDown, e As EventArgs)
        ' change the number of answer input boxes displayed when user changes the Number of Answers input value

        ' get part id
        Dim part As Integer = 0

        For p = 0 To partControls.Count - 1
            If partControls(p).Contains(sender) Then
                part = p
            End If
        Next

        ' enable/disable inputs
        hideShowAnswers(sender.Value, partControls(part))

        ' update mark dropdown input for rank /multiple answer questions
        If parts(part).type = "Rank Order" Or parts(part).type = "Multiple Answer" Then
            CType(partControls(part)(0), ComboBox).Items(2) = sender.Value.ToString & " (1 mark per correct answer)"
        End If



    End Sub

    Private Sub TimeCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles TimeCheckbox.CheckedChanged
        'enable/disable timer checkbox

        If TimeCheckbox.Checked Then
            TimeChooser.Enabled = True
        Else
            TimeChooser.Enabled = False
        End If
    End Sub
#End Region

#Region "Setup Parts"

    ''' <summary>
    ''' Short Question: answer input
    ''' </summary>
    ''' <param name="table"></param>
    ''' <param name="questionRow"></param>
    ''' <param name="marksRow"></param>
    Public Sub ShortTextQuestion(part As Integer, table As TableLayoutPanel, ByRef questionRow() As Integer, ByRef marksRow As Integer, ByRef currentControls As List(Of Control))
        ' Teacher Objective 2c, 2d


        ' Question 
        marksRow = 0
        questionRow = {2, 3}

        ' Answer
        Dim answerLbl As New Label()
        answerLbl.Text = "Answer:"
        answerLbl.TextAlign = ContentAlignment.BottomLeft
        controller.setControl(table, answerLbl, {0, 6}, {2, 3})

        Dim answerInput As New TextBox() : answerInput.Name = part & "answerInput"
        answerInput.MaxLength = 250
        controller.setControl(table, answerInput, {0, 7}, {}, DockStyle.Fill, 2)


        ' update input with current answer
        If parts(part).answers.Count > 0 Then
            answerInput.Text = parts(part).answers(0)
        End If

        currentControls.Add(answerInput)

    End Sub

    ''' <summary>
    ''' Long Question: answer input
    ''' </summary>
    ''' <param name="table"></param>
    ''' <param name="questionRow"></param>
    ''' <param name="marksRow"></param>
    Public Sub LongTextQuestion(part As Integer, table As TableLayoutPanel, ByRef questionRow() As Integer, ByRef marksRow As Integer)
        ' Teacher Objective 2c, 2d

        ' Question 
        marksRow = 0
        questionRow = {2, 3}

        ' Answer
        Dim answerLbl As New Label()
        answerLbl.Text = "Answer must be marked manually after students complete assessment."
        answerLbl.TextAlign = ContentAlignment.MiddleCenter
        answerLbl.Anchor = AnchorStyles.Left Or AnchorStyles.Bottom

        controller.setControl(table, answerLbl, {0, 7}, {}, DockStyle.Fill, 2)


    End Sub

    ''' <summary>
    ''' Numerical Question: decimal places input, range input, answer input
    ''' </summary>
    ''' <param name="table"></param>
    ''' <param name="questionRow"></param>
    ''' <param name="marksRow"></param>
    Public Sub NumericalQuestion(part As Integer, table As TableLayoutPanel, ByRef questionRow() As Integer, ByRef marksRow As Integer, ByRef currentControls As List(Of Control))
        ' Teacher Objective 2c, 2d

        ' Question 
        marksRow = 0
        questionRow = {2, 2}

        ' Decimal Places
        Dim decimalLbl As New Label()
        decimalLbl.Text = "Decimal Places:"
        decimalLbl.TextAlign = ContentAlignment.BottomLeft
        controller.setControl(table, decimalLbl, {0, 5}, {}, DockStyle.Fill)

        Dim decimalInput As New NumericUpDown() : decimalInput.Name = part & "decimalInput"
        decimalInput.Minimum = 0
        controller.setControl(table, decimalInput, {0, 6}, {}, DockStyle.Fill)
        AddHandler decimalInput.ValueChanged, New EventHandler(AddressOf NumericalQuestionDecimalInputChange)

        ' Range
        Dim rangeLbl As New Label()
        rangeLbl.Text = "Allowed Error (will accept answers +- this value):"
        rangeLbl.TextAlign = ContentAlignment.BottomLeft
        controller.setControl(table, rangeLbl, {0, 7}, {2, 3})

        Dim rangeInput As New NumericUpDown() : rangeInput.Name = part & "rangeInput"
        rangeInput.Minimum = 0
        controller.setControl(table, rangeInput, {0, 8}, {}, DockStyle.Fill)

        ' Answer
        Dim answerLbl As New Label()
        answerLbl.Text = "Answer:"
        answerLbl.TextAlign = ContentAlignment.BottomLeft
        controller.setControl(table, answerLbl, {0, 9}, {2, 3})


        Dim answerInput As New NumericUpDown() : answerInput.Name = part & "answerInput"
        controller.setControl(table, answerInput, {0, 10}, {}, DockStyle.Fill)

        currentControls.AddRange({answerInput, decimalInput, rangeInput})


        ' update Inputs with current answers
        answerInput.DecimalPlaces = decimalInput.Value

        If parts(part).answers.Count > 0 Then
            answerInput.Value = Val(parts(part).answers(0))
            decimalInput.Value = Val(parts(part).answers(1))
            rangeInput.Value = Val(parts(part).answers(2))
        End If



    End Sub

    ''' <summary>
    ''' Questions with multiple answers/items: Multiple choice, multiple answer, rank order
    ''' </summary>
    ''' <param name="table"></param>
    ''' <param name="questionRow"></param>
    ''' <param name="marksRow"></param>
    Public Sub PluralAnswerQuestion(part As Integer, table As TableLayoutPanel, ByRef questionRow() As Integer, ByRef marksRow As Integer, ByRef currentControls As List(Of Control))
        ' Teacher Objective 2c, 2d

        ' Question 
        marksRow = 0
        questionRow = {2, 2}


        ' Num of Answers
        Dim numOfAnswersLbl As New Label() : numOfAnswersLbl.Name = part & "numOfAnswersLbl"
        numOfAnswersLbl.Text = "Number of Answers:"
        numOfAnswersLbl.TextAlign = ContentAlignment.BottomLeft
        controller.setControl(table, numOfAnswersLbl, {1, 0}, {}, DockStyle.Fill)

        Dim numOfAnswersInput As New NumericUpDown() : numOfAnswersInput.Name = part & "numOfAnswersInput"
        numOfAnswersInput.Minimum = 2
        numOfAnswersInput.Maximum = 6
        controller.setControl(table, numOfAnswersInput, {1, 1}, {})

        ' add to control list
        currentControls.Add(numOfAnswersInput)

        ' add handler
        AddHandler numOfAnswersInput.ValueChanged, New EventHandler(AddressOf MultiQuestionNumberChange)


        Select Case parts(part).type
            Case "Multiple Choice"
                MultipleChoiceQuestion(part, table, questionRow, marksRow, currentControls)
            Case "Multiple Answer"
                MultipleAnswerQuestion(part, table, questionRow, marksRow, currentControls)
            Case "Rank Order"
                ' Question 
                questionRow = {2, 1}
                RankAnswerQuestion(part, table, questionRow, marksRow, currentControls)
        End Select




        ' update numOfAnswers with current answers
        Dim answersCount As Integer = 0
        For Each a In parts(part).answers ' (get num of answers excluding empty "" answers)
            If a <> "" Then
                answersCount += 1
            End If
        Next

        If answersCount > 2 Then ' set minimum of 2 answers
            numOfAnswersInput.Value = answersCount
        Else
            numOfAnswersInput.Value = 2
        End If


        hideShowAnswers(numOfAnswersInput.Value, currentControls)


    End Sub


    ''' <summary>
    ''' Multiple Choice Question: number of answers input, answer radiobuttons, answers inputs
    ''' </summary>
    ''' <param name="table"></param>
    ''' <param name="questionRow"></param>
    ''' <param name="marksRow"></param>
    Public Sub MultipleChoiceQuestion(part As Integer, table As TableLayoutPanel, ByRef questionRow() As Integer, ByRef marksRow As Integer, ByRef currentControls As List(Of Control))
        ' Teacher Objective 2c, 2d

        ' Answers 
        For i = 0 To 5
            ' position
            Dim col As Integer = i Mod 2
            Dim row As Integer = 5 + 2 * (i \ 2)

            'CheckBox/ Label
            Dim answerCheckbox As New RadioButton() : answerCheckbox.Name = part & "answerCheckbox" & i
            answerCheckbox.Text = $"Answer {i + 1}:"
            answerCheckbox.Checked = False
            controller.setControl(table, answerCheckbox, {col, row}, {2, 3})

            'Input
            Dim answerInput As New TextBox() : answerInput.Name = part & "answerInput" & i
            answerInput.MaxLength = 250
            controller.setControl(table, answerInput, {col, row + 1}, {}, DockStyle.Fill)

            answerCheckbox.Margin = New Padding(3, 0, 3, 0)
            answerInput.Margin = New Padding(3, 0, 3, 0)

            'update answer input with current answer
            If i < parts(part).answers.Count Then
                answerInput.Text = parts(part).answers(i)
            End If

            ' update checkbox with current correct answer
            If parts(part).correctAnswer.Contains(i.ToString) Then
                answerCheckbox.Checked = True
            End If

            currentControls.Add(answerCheckbox)
            currentControls.Add(answerInput)
        Next

    End Sub

    ''' <summary>
    ''' Multiple Answer Question: number of answers input, answer checkboxes, answers inputs
    ''' </summary>
    ''' <param name="table"></param>
    ''' <param name="questionRow"></param>
    ''' <param name="marksRow"></param>
    Public Sub MultipleAnswerQuestion(part As Integer, table As TableLayoutPanel, ByRef questionRow() As Integer, ByRef marksRow As Integer, ByRef currentControls As List(Of Control))
        ' Teacher Objective 2c, 2d

        ' Answers 
        For i = 0 To 5
            ' position
            Dim col As Integer = i Mod 2
            Dim row As Integer = 5 + 2 * (i \ 2)

            'CheckBox/ Label
            Dim answerCheckbox As New CheckBox() : answerCheckbox.Name = part & "answerCheckbox" & i
            answerCheckbox.Text = $"Answer {i + 1}:"
            answerCheckbox.Checked = False
            controller.setControl(table, answerCheckbox, {col, row}, {2, 3})

            ' Input
            Dim answerInput As New TextBox() : answerInput.Name = part & "answerInput" & i
            answerInput.MaxLength = 250
            controller.setControl(table, answerInput, {col, row + 1}, {}, DockStyle.Fill)

            answerCheckbox.Margin = New Padding(3, 0, 3, 0)
            answerInput.Margin = New Padding(3, 0, 3, 0)


            'update answer input with current answer
            If i < parts(part).answers.Count Then
                answerInput.Text = parts(part).answers(i)
            End If

            ' update checkbox with current correct answer
            If parts(part).correctAnswer.Contains(i.ToString) Then
                answerCheckbox.Checked = True
            End If

            currentControls.Add(answerCheckbox)
            currentControls.Add(answerInput)
        Next



    End Sub

    ''' <summary>
    ''' Rank Order Question: answer checkboxes, answers inputs
    ''' </summary>
    ''' <param name="part"></param>
    ''' <param name="table"></param>
    ''' <param name="questionRow"></param>
    ''' <param name="marksRow"></param>
    Public Sub RankAnswerQuestion(part As Integer, table As TableLayoutPanel, ByRef questionRow() As Integer, ByRef marksRow As Integer, ByRef currentControls As List(Of Control))
        ' Teacher Objective 2c, 2d

        ' Order Correctly Label
        Dim orderCorrectlyLbl As New Label()
        orderCorrectlyLbl.Text = "Please enter items in the correct order."
        orderCorrectlyLbl.TextAlign = ContentAlignment.MiddleCenter
        controller.setControl(table, orderCorrectlyLbl, {0, 3}, {}, DockStyle.Fill, 2)

        ' Answers 
        For i = 0 To 5
            ' position
            Dim col As Integer = i Mod 2
            Dim row As Integer = 5 + 2 * (i \ 2)

            'CheckBox/ Label
            Dim answerLbl As New Label() : answerLbl.Name = part & "answerCheckbox" & i
            answerLbl.Text = $"Item {i + 1}:"
            controller.setControl(table, answerLbl, {col, row}, {2, 3})

            ' Input
            Dim answerInput As New TextBox() : answerInput.Name = part & "answerInput" & i
            answerInput.MaxLength = 250
            controller.setControl(table, answerInput, {col, row + 1}, {}, DockStyle.Fill)

            answerLbl.Margin = New Padding(3, 0, 3, 0)
            answerInput.Margin = New Padding(3, 0, 3, 0)

            'update answer input with current answer
            If i < parts(part).answers.Count Then
                answerInput.Text = parts(part).answers(i)
            End If

            currentControls.Add(answerLbl)
            currentControls.Add(answerInput)
        Next

    End Sub

#End Region

#Region "Save Parts"

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim valid As Boolean = True
        Dim i As Integer = -1


        ' Update Question Properties:
        ' Teacher Objective 2b, 2f

        ' get time value
        Dim timeVal As Integer = TimeChooser.Value
        If Not TimeCheckbox.Checked Then
            timeVal = -1
        End If

        ' update question category and timer in database
        controller.DBController.UpdateValues("Questions", {{"Category", categoryCombo.Text}, {"Timer", timeVal}}, $"AssessmentID='{controller.currentAssessmentID}' AND QuestionNumber={controller.currentQuestionNum}")

        ' Update Part Properties:
        ' Teacher Objective 2c, 2d

        ' iterate through part
        While valid And i < parts.Count - 1
            ' increment to next part
            i += 1
            Dim part As Part = parts(i)

            ' Question/Mark
            part.availableMark = Val(CType(partControls(i)(0), ComboBox).SelectedItem(0))
            part.text = partControls(i)(1).Text

            ' clear current answers
            part.answers = New List(Of String)
            part.correctAnswer = ""

            ' validate Question
            If part.text.Trim = "" Then
                MessageBox.Show($"Please fill the 'Question Text' field in part {"ABCD"(i)}")
                valid = False
            Else
                ' Answers
                Select Case part.type
                    Case "Short Text"
                        ' update part obj
                        shortTextQuestionSave(valid, i)

                    Case "Numerical"
                        numericalQuestionSave(i)

                    Case "Multiple Choice", "Multiple Answer", "Rank Order"
                        multipleQuestionSave(valid, i)

                End Select

            End If

        End While

        ' next form
        If valid Then

            ' delete existing parts for current question
            controller.DBController.DeleteValues("Parts", $"AssessmentID='{controller.currentAssessmentID}' AND QuestionNumber={controller.currentQuestionNum}")

            ' update database question parts: where questionID = currentQuestionID
            For p = 0 To parts.Count - 1

                Dim part As Part = parts(p)

                While part.answers.Count < 6
                    part.answers.Add("")
                End While

                Dim values() As String = {p,
                    controller.currentQuestionNum,
                    controller.currentAssessmentID,
                    Part.type,
                    Part.text,
                    Part.answers(0),
                    Part.answers(1),
                    Part.answers(2),
                    Part.answers(3),
                    Part.answers(4),
                    Part.answers(5),
                    Part.correctAnswer,
                    Part.availableMark}

                controller.DBController.AddValues("Parts", values)
            Next

            Dim nextForm As New T_ViewAssessment(controller)
            controller.SwitchForms(Me, nextForm)
        End If
    End Sub


    Public Sub shortTextQuestionSave(ByRef valid As Boolean, i As Integer)
        ' Teacher Objective 2c, 2d

        ' get/add answer
        'Dim answer As String = CType(Controls.Find(i & "answerInput", True)(0), TextBox).Text
        Dim answer As String = partControls(i)(2).Text

        parts(i).answers.Add(answer)

        'validate answer input
        If answer.Trim = "" Then
            valid = False
            MessageBox.Show($"Please fill the 'Answer' field in part {"ABCD"(i)}")
        End If

        ' correct answer
        parts(i).correctAnswer = "0"
    End Sub

    Public Sub numericalQuestionSave(i As Integer)
        ' Teacher Objective 2c, 2d

        Dim answer As String = CType(partControls(i)(2), NumericUpDown).Value.ToString
        Dim decimalVal As String = CType(partControls(i)(3), NumericUpDown).Value.ToString
        Dim range As String = CType(partControls(i)(4), NumericUpDown).Value.ToString



        ' add answers
        parts(i).answers.Add(answer)
        parts(i).answers.Add(decimalVal)
        parts(i).answers.Add(range)

        'correct answer
        parts(i).correctAnswer = "0"
    End Sub

    Public Sub multipleQuestionSave(ByRef valid As Boolean, i As Integer)
        ' Teacher Objective 2c, 2d


        ' num of answers
        Dim numOfAnswers As Integer = CType(partControls(i)(2), NumericUpDown).Value

        Dim a As Integer = 0

        While valid And a < numOfAnswers
            ' answers
            Dim answer As String = CType(partControls(i)(4 + a * 2), TextBox).Text

            parts(i).answers.Add(answer)

            ' correct answer
            Select Case parts(i).type
                Case "Multiple Choice"

                    If CType(partControls(i)(3 + a * 2), RadioButton).Checked Then
                        parts(i).correctAnswer = a.ToString
                    End If

                Case "Multiple Answer"


                    If CType(partControls(i)(3 + a * 2), CheckBox).Checked Then
                        parts(i).correctAnswer &= a.ToString
                    End If
            End Select

            ' validate answer inputs
            If answer.Trim = "" Then
                valid = False
                MessageBox.Show($"Please fill all 'Answer' fields in part {"ABCD"(i)}")
            End If

            a += 1
        End While

        ' validate answer checkboxes
        If parts(i).type <> "Rank Order" Then
            If parts(i).correctAnswer.Trim = "" Then
                valid = False
                MessageBox.Show($"Please fill all 'Item' fields in part {"ABCD"(i)}")
            End If
        End If

    End Sub



#End Region

#Region "Add/Remove Parts"
    Private Sub AddPartBtn_Click(sender As Object, e As EventArgs) Handles AddPartBtn.Click
        ' Teacher Objective 2b, 2d

        If PartTypeCombo.SelectedIndex > -1 Then
            ' create new part 
            Dim p As New Part

            p.ID = parts.Count
            p.type = PartTypeCombo.SelectedItem.ToString
            p.correctAnswer = ""
            parts.Add(p)

            ' disable add button
            If parts.Count = 4 Then
                NewPartMenuStrip.Enabled = False
            End If

            ' add parts tab
            createTab(parts.Count - 1)

            DeleteBtn.Visible = True
        End If

    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If parts.Count > 1 Then

            ' update parts list
            parts.RemoveAt(partsTab.SelectedIndex)

            ' update parts controls
            partControls.RemoveAt(partsTab.SelectedIndex)

            ' update parts tab
            partsTab.TabPages.Remove(partsTab.SelectedTab)

            Dim partChars As String = "ABCD"
            For i = 0 To partsTab.TabPages.Count - 1
                partsTab.TabPages(i).Text = $"{partChars(i)} ({parts(i).type})"
            Next

            ' delete in database
            Dim id As Integer = controller.getPartIDFromIndex(partsTab.SelectedIndex, controller.currentQuestionNum, controller.currentAssessmentID)
            controller.DBController.DeleteValues("Parts", $"AssessmentID = '{controller.currentAssessmentID}' AND QuestionNumber = {controller.currentQuestionNum} AND PartID = {id}")


            If partsTab.SelectedIndex < 0 Then
                DeleteBtn.Visible = False
            End If
            ' reanble menu strip
            NewPartMenuStrip.Enabled = True
        Else
            MessageBox.Show("Each Question must have a minimum of 1 Part.")
        End If

    End Sub

    Private Sub partsTab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles partsTab.SelectedIndexChanged
        If partsTab.SelectedIndex < 0 Then
            DeleteBtn.Visible = False
        Else
            DeleteBtn.Visible = True
        End If

    End Sub
#End Region

End Class