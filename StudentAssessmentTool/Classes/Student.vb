Imports System.Net.Sockets

Public Class Student
    ' properties of students (passed from clients to server) 
    Property client As TcpClient
    Property id As Integer
    Property Name As String
    Property answers As New List(Of List(Of String))
    Property marks As New List(Of List(Of Integer))
    Property status As String
    Property position As Integer

    Sub New()
        status = ""
        position = -1

    End Sub

    ' gets total mark of student
    Public Function getTotalMark() As Integer
        Dim total As Integer = 0
        For Each questionMarks As List(Of Integer) In marks
            total += getQuestionMark(questionMarks)
        Next
        Return total
    End Function


    ' gets mark for a question from marks for each parts (specified as list of marks as param partsMarks)
    Public Function getQuestionMark(partsMarks As List(Of Integer)) As Integer
        Dim total As Integer = 0
        For Each mark As Integer In partsMarks
            total += mark
        Next
        Return total
    End Function


    ' returns random name for student made up of 2 words
    Public Function generateRandomName(currentName As String) As String
        Dim name As String = currentName
        Dim word1 As String() = {"Magenta", "Coral", "Lilac", "Golden", "Silver", "Emerald", "Violet", "Crimson"}
        Dim word2 As String() = {"Serpent", "Leopard", "Bulldog", "Tiger", "Wolf", "Lion", "Spider", "Octopus", "Snail", "Rhino", "Scorpian", "Giraffe"}

        Dim rand As New Random()
        While name = currentName

            name = word1(rand.Next(word1.Count)) & word2(rand.Next(word2.Count))
        End While

        Return name
    End Function
End Class
