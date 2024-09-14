
Public Class Assessment
    'properties of live assessments, including list of questions(passed from server to clients)

    Property id As String
    Property Name As String

    Property questions As New List(Of Question)  ' association (by composition)

    Property gameMode As Boolean

    Property timeLimit As Integer
    Property randomOrder As Boolean
    Property showResults As Boolean

    Property music As Boolean
    Property chooseName As Boolean
    Property showPosition As Boolean

    Property status As String

    Property timeLeft As TimeSpan

    Sub New()
        status = "000"
        timeLimit = -1


        gameMode = False

        randomOrder = False
        showResults = False

        music = False
        chooseName = False
        showPosition = False

    End Sub

    ' gets total mark for assessment (up to question specified in param upToQuestion or if not specified: for whole assessment)
    Public Function getTotalMark(Optional upToQuestion As Integer = -1) As Integer

        ' get max quetsion number
        If upToQuestion = -1 Then
            upToQuestion = questions.Count - 1
        End If

        Dim q As Integer = 0
        Dim total As Integer = 0

        While q <= upToQuestion

            total += getQuestionMark(questions(q))
            q += 1
        End While

        Return total
    End Function

    ' gets the total mark for a question
    Public Function getQuestionMark(question As Question) As Integer
        Dim total As Integer = 0
        For Each p As Part In question.parts
            total += p.availableMark
        Next
        Return total
    End Function

End Class
