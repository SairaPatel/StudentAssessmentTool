Imports System.Random

Public Class AppController

    ' teacher properties --------
    Property currentUserID As String
    Property currentAssessmentID As String
    Property currentQuestionNum As Integer
    Property currentPartNum As Integer
    Property sharedAssessments As Boolean
    Property reportID As Integer
    Property studentID As Integer

    ' student properties 
    Property studentLogin As Boolean
    Property studentName As String

    Property DBController As New DBController

    ' colour palette
    Property blues As Color() = {Color.FromArgb(50, 100, 220), Color.FromArgb(0, 170, 240), Color.FromArgb(100, 200, 235), Color.FromArgb(190, 230, 255)}
    Property purples As Color() = {Color.FromArgb(150, 100, 255), Color.FromArgb(180, 150, 255), Color.FromArgb(210, 180, 255), Color.FromArgb(240, 225, 255)}
    Property greens As Color() = {Color.FromArgb(45, 165, 190), Color.FromArgb(65, 220, 205), Color.FromArgb(130, 235, 200), Color.FromArgb(200, 240, 220)}
    Property pinks As Color() = {Color.FromArgb(205, 45, 195), Color.FromArgb(210, 70, 195), Color.FromArgb(255, 135, 230), Color.FromArgb(250, 200, 220)}
    Property oranges As Color() = {Color.FromArgb(255, 205, 45), Color.FromArgb(250, 195, 75), Color.FromArgb(255, 205, 130), Color.FromArgb(255, 230, 180)}

    Property palettes As Array = {blues, greens, oranges, pinks, purples}
    Property palette As Color()
    Property currentCol As Integer = -1

    Property questionTypeDescription As Dictionary(Of String, String)



    Public Sub New()

        switchPalette()
        setQuestionTypeDescription()
    End Sub

#Region "Forms Management"
    Public Sub switchPalette()
        ' switch to next colour (functions like a circular queue)
        currentCol = (currentCol + 1) Mod palettes.Length
        palette = palettes(currentCol)
    End Sub

    Public Sub SwitchForms(current As Form, nextForm As Form)
        ' set properties of next form
        nextForm.Location = current.Location
        nextForm.StartPosition = FormStartPosition.Manual
        nextForm.Size = current.Size

        nextForm.Show()
        If current.WindowState = FormWindowState.Maximized Then
            nextForm.Size = nextForm.MinimumSize
        End If

        nextForm.WindowState = current.WindowState
        nextForm.BackColor = Color.White

        nextForm.FormBorderStyle = FormBorderStyle.Sizable

        ' close current form
        current.Close()
    End Sub

    Public Sub SwitchToHome(current As Form, controller As AppController, nextForm As Home)
        ' switch (back) to Home form and pass current controller as param
        nextForm.controller = controller

        nextForm.Location = current.Location
        nextForm.StartPosition = FormStartPosition.Manual
        nextForm.Size = current.Size

        nextForm.Show()
        If current.WindowState = FormWindowState.Maximized Then
            nextForm.Size = nextForm.MinimumSize
        End If

        nextForm.WindowState = current.WindowState
        nextForm.BackColor = Color.White

        nextForm.FormBorderStyle = FormBorderStyle.FixedToolWindow
        nextForm.FormBorderStyle = FormBorderStyle.Sizable


        current.Close()
    End Sub



    ''' <summary>
    ''' Set all starting values for a control
    ''' </summary>
    ''' <param name="table">Table to contain Control</param>
    ''' <param name="con">Control</param>
    ''' <param name="anchor">Array of Integers for associated anchors: 0-> top, 1->right, 2->bottom, 3->left</param>
    ''' <param name="cell">Array of 2 Integers for cell postion in Table: {column, row}</param>
    ''' <param name="dock">Dock Style</param>
    ''' <param name="colSpan">Column span for control in Table</param>
    ''' <param name="rowSpan">Row span for control in Table</param>
    Sub setControl(ByRef table As TableLayoutPanel, ByRef con As Control, cell() As Integer, anchor() As Integer, Optional dock As DockStyle = DockStyle.None, Optional colSpan As Integer = 1, Optional rowSpan As Integer = 1, Optional fontsize As Integer = 10)

        Dim font As New Font(New FontFamily("Segoe UI"), fontsize)
        con.Font = font
        table.Controls.Add(con, cell(0), cell(1))
        table.SetColumnSpan(con, colSpan)
        table.SetRowSpan(con, rowSpan)


        Dim anchorTypes() As AnchorStyles = {AnchorStyles.Top, AnchorStyles.Right, AnchorStyles.Bottom, AnchorStyles.Left}
        For Each i In anchor
            con.Anchor = con.Anchor Or anchorTypes(i)
        Next
        con.Dock = dock
    End Sub


    ''' <summary>
    ''' Creates table, add columns and rows
    ''' </summary>
    ''' <param name="columns">array of integers, 1 for each column, with its size as a percentage or -1 if size is autosize</param>
    ''' <param name="rows">array of integers, 1 for each row, with its size as a percentage or -1 if size is autosize</param>
    ''' <returns></returns>
    Public Function createTable(columns() As Integer, rows() As Integer) As TableLayoutPanel
        Dim table As New TableLayoutPanel
        table.BackColor = Color.Transparent
        table.Dock = DockStyle.Fill

        table.ColumnCount = columns.Length
        table.RowCount = rows.Length

        For Each c In columns
            If c = -1 Then
                table.ColumnStyles.Add(New ColumnStyle(SizeType.AutoSize))
            Else
                table.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, c))
            End If
        Next

        For Each r In rows
            If r = -1 Then
                table.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            Else

                table.RowStyles.Add(New RowStyle(SizeType.Percent, r))
            End If
        Next



        Return table
    End Function

#End Region


#Region "Helper Subroutines"

    Public Function generateRandomID(currentIds As String()) As String

        ' get range for random nums
        Dim count As Integer = Math.Max(currentIds.Count, 99999)

        ' generate random
        Randomize()
        Dim rand As New Random()
        Dim id As Integer = rand.Next(count)

        While currentIds.Contains(id.ToString)
            id = rand.Next
        End While

        ' get len of ID and pad
        Dim len As Integer = Math.Ceiling(Math.Log10(count))
        Return id.ToString.PadLeft(len, "0")
    End Function


    Public Sub setQuestionTypeDescription()
        ' return dictionary with pairs of Question Part Type names and their descriptions
        questionTypeDescription = New Dictionary(Of String, String)

        questionTypeDescription.Add("Short Text", "The answer is an exact word/phrase")
        questionTypeDescription.Add("Long Text", "The answer will be marked manually")
        questionTypeDescription.Add("Numerical", "The answer is a numerical value)")
        questionTypeDescription.Add("Multiple Choice", "Select only 1 answer")
        questionTypeDescription.Add("Multiple Answer", "Select all number of answers")
        questionTypeDescription.Add("Rank Order", "Arrange the items in order")

    End Sub

    Public Function getPartIDFromIndex(part As Integer, question As Integer, assessment As String)
        ' gets the PartID attribute in database of a part from its index
        Dim questionNum As Integer = getQuestionNumberFromIndex(question, assessment)

        ' select parts 
        Dim parts As List(Of Object()) = DBController.SelectValues("Parts", "PartID", $"AssessmentID = '{assessment}' AND QuestionNumber = {questionNum}  ")

        Return parts(part)(0)
    End Function

    Public Function getQuestionNumberFromIndex(question As Integer, assessment As String) As Integer
        ' gets the Question Number attribute in database of a question from its index 
        ' select questions 
        Dim questions As List(Of Object()) = DBController.SelectValues("Questions", "QuestionNumber", $"AssessmentID = '{assessment}'")

        Return questions(question)(0)

    End Function


    Public Sub sortIndiciesByScores(ByRef indiciesAndScores As List(Of Integer()))

        ' bubble sort list by score
        Dim sorted As Boolean = False
        Dim i As Integer = 0
        While Not sorted And i < indiciesAndScores.Count
            For j = 0 To indiciesAndScores.Count - 2

                sorted = True
                If indiciesAndScores(j)(1) < indiciesAndScores(j + 1)(1) Then
                    Dim smaller As Integer() = indiciesAndScores(j)
                    indiciesAndScores(j) = indiciesAndScores(j + 1)
                    indiciesAndScores(j + 1) = smaller
                    sorted = False
                End If
            Next
            i += 1
        End While

    End Sub

    Public Function getPositionText(position As Integer) As String
        ' returns the string representation of a Position from the position value
        Dim positionText As String = position.ToString
        Select Case position
            Case 0, 4, 5, 6, 7, 8, 9
                positionText &= "th"
            Case 1
                positionText &= "st"
            Case 2
                positionText &= "nd"
            Case 3
                positionText &= "rd"

        End Select
        Return positionText
    End Function

#End Region

#Region "DB Subroutines"
    Public Function createReport(server As Server) As Integer
        ' adds a report record to the Reports database table and returns the ID (or -1 if excpeiton occurred)
        Try

            ' insert report record
            DBController.AddValues("Reports", {reportID, currentAssessmentID, server.assessment.Name})

            ' insert students
            Dim studentCount As Integer = server.students.Values.Count


            For i = 0 To studentCount - 1
                Dim student As Student = server.students.Values(i)
                DBController.AddValues("Students", {reportID, student.Name})
                studentID = DBController.SelectValues("Students", "StudentID", $"Name = '{student.Name}' AND ReportID = {reportID}")(0)(0)

                ' questions
                For q = 0 To student.answers.Count - 1

                    ' answers
                    For p = 0 To student.answers(q).Count - 1
                        Dim partID As Integer = getPartIDFromIndex(p, q, currentAssessmentID)
                        DBController.AddValues("StudentAnswers", {studentID, q, partID, student.answers(q)(p), student.marks(q)(p)})
                    Next
                Next
            Next

            Return reportID
        Catch ex As Exception

            ' delete report
            DBController.DeleteValues("Reports", $"ReportID={reportID}")
            MessageBox.Show("An error occurred saving this report. Please try again.")

            Return -1
        End Try

    End Function
#End Region


End Class
