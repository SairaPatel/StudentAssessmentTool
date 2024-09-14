Public Class T_ViewReport

    Property controller As AppController
    Property search As String
    Property marksInputs As New List(Of Dictionary(Of NumericUpDown, Integer))
    Property displayName As Boolean

    Property showByStudent As Boolean

    Property numberOfStudents As Integer

    Sub New(controller_ As AppController, display As Boolean, bystudent As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        controller = controller_
        displayName = display
        showByStudent = bystudent
    End Sub

#Region "Form"

    Private Sub T_Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' set colours
        Me.BackColor = Color.White

        saveBtn.BackColor = controller.palette(3)
        saveBtn.ForeColor = Color.White

        hideNameBtn.BackColor = controller.palette(2)
        hideNameBtn.ForeColor = Color.White

        scrollPanel.BackColor = Color.White
        scrollPanel.BackColor = Color.White

        BackBtn.ForeColor = controller.palette(3)
        BackBtn.BackColor = controller.palette(3)



        ' Student Objective 4
        ' student users
        If controller.studentLogin Then
            ' disable editing for
            hideNameBtn.Hide()
            saveBtn.Hide()

            ' get assessment
            controller.currentAssessmentID = controller.DBController.SelectValues("Reports", "AssessmentID", $"ReportID = {controller.reportID}")(0)(0)

        End If

        ' Teacher Objective 6a
        ' total marks available
        Dim totalAvailable As Integer = controller.DBController.SelectValues("Parts", "SUM(AvailableMarks)", $"AssessmentID = '{controller.currentAssessmentID}'")(0)(0)

        ' display students or questions
        If showByStudent Then

            ' Teacher Objective 6e
            ' display student name
            If displayName Then
                TitleLbl.Text = getStudentName()

            Else
                hideNameBtn.Text = "Show Name"
                TitleLbl.Text = ""
            End If

            If totalAvailable > 0 Then
                ' Teacher Objective 6a
                ' display average 
                Dim totalAwarded As Integer = controller.DBController.SelectValues("StudentAnswers", "SUM(MarkAwarded)", $"StudentID = {controller.studentID}")(0)(0)
                markLbl.Text = $"Total Mark: {totalAwarded}/{totalAvailable} - {Math.Round(totalAwarded / totalAvailable * 100)}%"

            End If
        Else
            ' Teacher Objective 6b
            TitleLbl.Text = $"Class Analysis"
            hideNameBtn.Visible = False
            saveBtn.Visible = False

            If totalAvailable > 0 Then
                ' diaplay average 
                Dim totalMark As Integer = controller.DBController.SelectValues("StudentAnswers, Students", "SUM(MarkAwarded)", $"Students.StudentID = StudentAnswers.StudentID AND Students.ReportID = {controller.reportID}")(0)(0)
                numberOfStudents = controller.DBController.SelectValues("Students", "Count(StudentID)", $"ReportID = {controller.reportID}")(0)(0)
                markLbl.Text = $"Average Mark: {totalMark / numberOfStudents}/{totalAvailable} - {Math.Round(totalMark / numberOfStudents / totalAvailable * 100)}%"
            End If
        End If



        ' display questions (and get total scores for each question)
        Dim questionAccuracyMarks As List(Of Integer) = New List(Of Integer)
        displayQuestions(questionAccuracyMarks)

        'Teacher Objective 6d

        ' sort questions by accuracy
        Dim questionScores As List(Of Integer()) = getIndiciesAndScoresFromScores(questionAccuracyMarks)
        controller.sortIndiciesByScores(questionScores)
        'display questions by accuracy 
        For Each q As Integer() In questionScores
            questionListbox.Items.Add($"Question {q(0) + 1} - {q(1)}%")
        Next


        ' get categories by accuracy
        Dim categoryScoresDict As Dictionary(Of String, Integer) = getScoresByCategory(questionScores)
        Dim categoryNames As New List(Of String)
        Dim categoryScores As List(Of Integer()) = getIndiciesAndScoresListFromDict(categoryScoresDict, categoryNames)

        controller.sortIndiciesByScores(categoryScores)
        displaySortedScores(categoryListbox, categoryScores, categoryNames)




    End Sub
#End Region

#Region "Navigation"

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        If controller.studentLogin Then
            ' student user

            controller.reportID = vbNullString
            controller.studentID = vbNullString

            ' back to Student Reports page
            Dim nextForm As New T_Reports(controller)
            controller.SwitchForms(Me, nextForm)

        Else
            ' teacher user
            ' back to Report Students page
            If showByStudent Then
                Dim ans As MsgBoxResult = MsgBox("Are you sure you want to go back? Any changes you have made will not be saved", MessageBoxButtons.YesNo)
                If ans = MsgBoxResult.Yes Then

                    'next form
                    Dim nextForm As New T_ReportStudents(controller, displayName)
                    controller.SwitchForms(Me, nextForm)
                End If
            Else
                'next form
                Dim nextForm As New T_ReportStudents(controller, displayName)
                controller.SwitchForms(Me, nextForm)
            End If
        End If

    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        ' Teacher Objective 6c
        ' update marks

        For q = 0 To marksInputs.Count - 1
            For p = 0 To marksInputs(q).Count - 1

                ' if marksinput value has changed
                If marksInputs(q).Keys(p).Value <> marksInputs(q).Values(p) Then
                    ' update database
                    Dim condition As String = $"StudentID = {controller.studentID} AND QuestionNumber = {controller.getQuestionNumberFromIndex(q, controller.currentAssessmentID)} AND PartID = {controller.getPartIDFromIndex(p, q, controller.currentAssessmentID)}"
                    controller.DBController.UpdateValues("StudentAnswers", {{"MarkAwarded", marksInputs(q).Keys(p).Value.ToString}}, condition)
                    Debug.WriteLine($"{condition}, q{q} p{p} val{ marksInputs(q).Keys(p).Value} ")
                End If

            Next
        Next

        'next form
        Dim nextForm As New T_ReportStudents(controller, displayName)
        controller.SwitchForms(Me, nextForm)
    End Sub

    Private Sub hideNameBtn_Click(sender As Object, e As EventArgs) Handles hideNameBtn.Click
        ' Teacher Objective 6e

        If hideNameBtn.Text = "Hide Name" Then
            hideNameBtn.Text = "Show Name"
            displayName = False
            TitleLbl.Text = ""
        Else
            hideNameBtn.Text = "Hide Name"
            displayName = True

            TitleLbl.Text = getStudentName()
        End If

    End Sub
#End Region

#Region "Get Data"

    Private Function getStudentName() As String
        ' Teacher Objective 6a
        Return controller.DBController.SelectValues("Students", "Name", $"StudentID = {controller.studentID}")(0)(0)
        'Return controller.studentName
    End Function

    ''' <summary>
    ''' </summary>
    ''' <returns>list of answer arrays: answer, markAwarded</returns>
    Private Function getAnswers() As List(Of Object())
        ' Teacher Objective 6a, 6b, Student Objective 4b
        ' get questions
        Dim condition As String = $"StudentID = {controller.studentID} ORDER BY QuestionNumber, PartID"
        Dim parts As List(Of Object()) = controller.DBController.SelectValues("StudentAnswers", "StudentAnswer, MarkAwarded", condition)
        Return parts
    End Function


    ''' <summary>
    ''' </summary>
    ''' <returns>list of parts arrays: 0 Answer1, 1 Answer2, 2 Answer3,3 Answer4, 4 Answer5, 5 Answer6, 6 CorrectAnswer, 7 AvailableMarks, 8 QuestionText, 9 QuestionNumber, 10 QuestionType</returns>
    Private Function getParts() As List(Of Object())
        ' Teacher Objective 6a, 6b, Student Objective 4b
        ' get questions
        Dim condition As String = $"AssessmentID = '{controller.currentAssessmentID}' ORDER BY QuestionNumber, PartID "
        Dim parts As List(Of Object()) = controller.DBController.SelectValues("Parts", "Answer1, Answer2,Answer3,Answer4,Answer5,Answer6,CorrectAnswer, AvailableMarks, QuestionText, QuestionNumber, QuestionType ", condition)
        Return parts
    End Function


#End Region

#Region "Analyse Data"

    Private Function getIndiciesAndScoresFromScores(questionScores As List(Of Integer)) As List(Of Integer())
        ' Teacher Objective 6a, Student 4b

        ' populate dicitonary with indicies and scores of each question
        Dim indiciesAndScores As New List(Of Integer())

        For q = 0 To questionScores.Count - 1
            indiciesAndScores.Add({q, questionScores(q)})
        Next
        Return indiciesAndScores

    End Function

    Private Function getScoresByCategory(questionScores As List(Of Integer())) As Dictionary(Of String, Integer)
        ' Teacher Objective 6a, Student 4b
        Dim indiciesAndScores As New Dictionary(Of String, Integer)

        ' add marks for each category to list
        For Each q In questionScores
            ' get category
            Dim category As String = controller.DBController.SelectValues("Questions", "Category", $"AssessmentID='{controller.currentAssessmentID}' AND QuestionNumber = {q(0)} ")(0)(0)

            ' add question mark to category's value
            If indiciesAndScores.ContainsKey(category) Then
                indiciesAndScores(category) += q(1)
            Else ' add category to dictionary
                indiciesAndScores.Add(category, q(1))
            End If
        Next
        Return indiciesAndScores
    End Function

    Private Function getIndiciesAndScoresListFromDict(indiciesScoresDict As Dictionary(Of String, Integer), ByRef categories As List(Of String)) As List(Of Integer())
        ' Teacher Objective 6a, Student 4b
        Dim indiciesAndScoresList As New List(Of Integer())
        For i = 0 To indiciesScoresDict.Count - 1
            indiciesAndScoresList.Add({i, indiciesScoresDict.Values(i)})
            categories.Add(indiciesScoresDict.Keys(i))
        Next

        Return indiciesAndScoresList
    End Function

    Private Sub displaySortedScores(listbox As ListBox, scores As List(Of Integer()), names As List(Of String))
        ' Teacher Objective 6a, Student 4b
        ' display categories by accuracy
        For Each c As Integer() In scores
            listbox.Items.Add($"{names(c(0))} - {c(1)}%")
        Next
    End Sub

#End Region

#Region "Display Questions"

    Private Function addNewTab(ByRef questionLbl As Label, questionNum As Integer) As TabControl
        ' new question/tab
        If scrollPanel.RowCount > 1 Then
            scrollPanel.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        End If
        scrollPanel.RowStyles.Add(New RowStyle(SizeType.AutoSize))

        scrollPanel.RowCount = (questionNum + 1) * 2

        controller.setControl(scrollPanel, questionLbl, {0, scrollPanel.RowCount - 2}, {}, DockStyle.Fill)

        'get question category
        Dim topic As Object = controller.DBController.SelectValues("Questions", "Category", $"AssessmentID = '{controller.currentAssessmentID}' AND QuestionNumber = {questionNum}")(0)(0)
        questionLbl.Text = $"Question {questionNum + 1} - Topic: {topic}"

        Dim tab As New TabControl()
        tab.Dock = DockStyle.Fill
        tab.Height = 200
        scrollPanel.Controls.Add(tab)
        scrollPanel.SetRow(tab, scrollPanel.RowCount - 1)

        Return tab
    End Function

    Private Function addNewTabPage(partID As Integer, marks As Integer) As TabPage
        ' create tabpage
        Dim tabpage As New TabPage($"Part {"ABCD"(partID)} - {marks} marks")
        tabpage.BackColor = Color.GhostWhite
        tabpage.AutoScroll = True

        Return tabpage


    End Function

    Public Function addNewTable(questionText As String) As TableLayoutPanel
        Dim table As TableLayoutPanel = controller.createTable({50, 50}, {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 100})

        'Question Text
        Dim questionLbl As New RichTextBox()
        controller.setControl(table, questionLbl, {0, 0}, {}, DockStyle.Fill, rowSpan:=16)
        questionLbl.Text = questionText
        questionLbl.BackColor = Color.FromArgb(240, 240, 240)
        questionLbl.ReadOnly = True


        Return table

    End Function

    Public Sub addNewAnswers(answerStrings As List(Of String), ByRef table As TableLayoutPanel, ByRef tab As TabControl, ByRef nextRow As Integer)
        ' display answer/answers
        Dim originalNextRow As Integer = nextRow
        For Each ans In answerStrings
            If ans <> "" Then
                Dim answerLbl As New Label()
                controller.setControl(table, answerLbl, {1, nextRow}, {}, DockStyle.Fill)
                answerLbl.TextAlign = ContentAlignment.MiddleLeft
                answerLbl.Text = ans
                answerLbl.Font = New Font(answerLbl.Font.FontFamily, answerLbl.Font.Size, FontStyle.Italic)

                ' increment table row num 
                nextRow += 1
            End If
        Next
    End Sub

    Private Sub displayQuestions(ByRef questionScores As List(Of Integer))
        Dim questionNum As Integer
        Dim recordIndex As Integer = 0

        Dim answers As List(Of Object()) = getAnswers()
        Dim parts As List(Of Object()) = getParts()


        Dim innerLoop As Boolean
        While recordIndex < parts.Count
            ' NEW QUESTION
            marksInputs.Add(New Dictionary(Of NumericUpDown, Integer))
            questionNum = parts(recordIndex)(9)

            ' question label
            Dim questionLbl As New Label()
            Dim tab As TabControl = addNewTab(questionLbl, questionNum)

            ' add parts to question
            Dim partID As Integer = 0
            Dim totalQuestionMark As Integer = 0


            ' QUESTION PARTS
            innerLoop = True
            While innerLoop
                'Teacher Objective 6a, Student 4a

                Dim part As Object() = parts(recordIndex)
                ' add part mark to question total
                totalQuestionMark += part(7)

                ' add tabpage & table
                Dim tabPage As TabPage = addNewTabPage(partID, part(7))
                tab.TabPages.Add(tabPage)


                Dim table As TableLayoutPanel = addNewTable(part(8))
                tabPage.Controls.Add(table)


                If showByStudent Then
                    'Teacher Objective 6a, Student 4b
                    'marks label
                    Dim marksLbl As New Label()
                    controller.setControl(table, marksLbl, {1, 0}, {}, DockStyle.Fill)
                    marksLbl.TextAlign = ContentAlignment.BottomLeft
                    marksLbl.Text = $"Marks Awarded: "
                    markLbl.Font = New Font(markLbl.Font, FontStyle.Bold)



                    If controller.studentLogin Then
                        ' display student mark in label
                        marksLbl.Text &= answers(recordIndex)(1)
                    Else

                        ' display student mark in inputbox
                        Dim marksInput As New NumericUpDown()
                        controller.setControl(table, marksInput, {1, 1}, {0, 3}, DockStyle.None)
                        marksInput.Value = answers(recordIndex)(1)
                        marksInput.Maximum = part(7)

                        ' add marks input control and its current value to list
                        marksInputs(questionNum).Add(marksInput, marksInput.Value)

                    End If

                End If

                ' correct answer label
                Dim correctAnswerLbl As New Label()
                controller.setControl(table, correctAnswerLbl, {1, 2}, {}, DockStyle.Fill)
                correctAnswerLbl.TextAlign = ContentAlignment.MiddleLeft
                correctAnswerLbl.Text = "Correct Answer:"
                correctAnswerLbl.Font = New Font(correctAnswerLbl.Font, FontStyle.Bold)

                Dim nextRow As Integer = 3

                ' get correct answer/answers depending on question type
                Dim answerStrings As New List(Of String)
                Select Case part(10)
                    Case "Short Text", "Numerical"
                        answerStrings.Add(part(Val(part(6))))

                    Case "Multiple Answer", "Multiple Choice"
                        For Each c As Char In part(6)
                            answerStrings.Add(part(Val(c)))
                        Next

                    Case "Rank Order"
                        For i = 0 To 5
                            answerStrings.Add(part(Val(i)))
                        Next
                    Case "Long Text"
                        answerStrings.Add("N/A")

                End Select

                ' display correct answer/answers
                addNewAnswers(answerStrings, table, tab, nextRow)

                ' otherLbl 
                Dim otherLbl As New Label()
                controller.setControl(table, otherLbl, {1, nextRow}, {}, DockStyle.Fill)
                otherLbl.TextAlign = ContentAlignment.MiddleLeft
                otherLbl.Font = New Font(otherLbl.Font, FontStyle.Bold)
                nextRow += 1
                If showByStudent Then

                    otherLbl.Text = "Student Answer: "

                    ' get student answer/answers depending on question type
                    answerStrings.Clear()

                    Select Case part(10)
                        Case "Short Text", "Long Text", "Numerical"
                            answerStrings.Add(answers(recordIndex)(0))

                        Case "Multiple Answer", "Rank Order", "Multiple Choice"
                            For Each c As Char In answers(recordIndex)(0)
                                answerStrings.Add(part(Val(c)))
                            Next

                    End Select

                    ' display answer/answers
                    addNewAnswers(answerStrings, table, tab, nextRow)

                Else ' show by question

                    If part(7) > 0 Then

                        'Teacher Objective 6b
                        ' get average mark for part
                        Dim condition As String = $"QuestionNumber = {questionNum} AND PartID = {partID} AND Students.StudentID = StudentAnswers.StudentID AND Students.ReportID = {controller.reportID}"
                        Dim average As Integer = controller.DBController.SelectValues("StudentAnswers, Students", "AVG(MarkAwarded)", condition)(0)(0)

                        ' accuracy - other label
                        otherLbl.Text = $"Average Mark: {average}"
                        otherLbl.Text &= $" (Accuracy: {Math.Round(average / part(7) * 100)}%)"
                    End If
                End If

                recordIndex += 1
                partID += 1

                ' check recordIndex is in range 
                If recordIndex >= parts.Count Then
                    innerLoop = False

                    ' check if moved to next question
                ElseIf parts(recordIndex)(9) <> questionNum Then
                    innerLoop = False
                End If


                ' adjust height
                If tab.Height < (nextRow + 1) * otherLbl.Height + 20 Then
                    tab.Height = (nextRow + 1) * otherLbl.Height + 20
                End If

            End While


            If showByStudent Then

                'Teacher Objective 6a, Student 4a
                ' average mark for question for student
                Dim condition As String = $"QuestionNumber = {questionNum} AND StudentAnswers.StudentID = {controller.studentID}"
                Dim totalMarks As Integer = controller.DBController.SelectValues("StudentAnswers", "SUM(MarkAwarded)", condition)(0)(0)

                Dim percent As Integer = 0

                If totalQuestionMark > 0 Then
                    percent = Math.Round(totalMarks / totalQuestionMark * 100)
                End If

                ' question mark label
                questionLbl.Text &= $" (Total Mark: {totalMarks}/{totalQuestionMark} - {percent}%)"
                questionScores.Add(percent)

            Else

                'Teacher Objective 6b
                ' average mark for question
                ' get total marks for this question for all students
                Dim condition As String = $"QuestionNumber = {questionNum} AND Students.StudentID = StudentAnswers.StudentID AND Students.ReportID = {controller.reportID}"
                Dim totalMarks As Integer = controller.DBController.SelectValues("StudentAnswers, Students", "SUM(MarkAwarded)", condition)(0)(0)

                Dim percent As Integer = 0

                If totalQuestionMark > 0 Then
                    percent = Math.Round(totalMarks / totalQuestionMark / numberOfStudents * 100)
                End If

                ' question mark label
                questionLbl.Text &= $" (Average: {totalMarks / numberOfStudents}/{totalQuestionMark} - {percent}%)"

                questionScores.Add(percent)

            End If

        End While

    End Sub

#End Region

End Class