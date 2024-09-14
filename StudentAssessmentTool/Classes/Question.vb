Public Class Question
    ' properties of a question, including list of parts
    Property category As String
    Property parts As List(Of Part) ' association (by composition)
    Property id As Integer
    Property timeLimit As Integer
    Sub New()
        parts = New List(Of Part)
    End Sub
End Class
