Public Class Part
    Property ID As Integer
    Property text As String
    'Types (strings): Long Text, Multiple Choice, Multiple Select, Numerical, Rank Order, Short Text
    Property type As String

    Property answers As New List(Of String)

    Property correctAnswer As String ' string containing index of correct answers e.g. "1" or "045"...
    Property availableMark As Integer

    Sub New()

    End Sub

    Public Sub setProperties(id_ As Integer, type_ As String, text_ As String, ans() As String, correctAns As String, mark As Integer)
        ' set all properties of a parts
        ID = id_
        type = type_

        text = text_

        correctAnswer = correctAns

        availableMark = mark

        ' add answers
        For Each a In ans
            If a <> "" Then
                answers.Add(a)
            End If
        Next

    End Sub
End Class
