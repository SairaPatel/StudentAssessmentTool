
' NOTE: there is a bug with the Listbox control which means that it does not update an item's value if the change is only a change to case. E.g. Sam --> sam
' SOLUTION (workaround):  I have added validation to the Students Name so that by default any name entered by the user (student/client or teacher/server) will be converted to Proper Case.

Imports System.Net
Imports System.Net.Sockets

Imports System.Text.Json ' installed Nuget package System.Text.Json

Public Class Server


    Property port As Integer
    Property ip As IPAddress
    Property serverListener As TcpListener

    Property listening As Boolean

    Property currentStudentID As Integer
    Property students As New Dictionary(Of Integer, Student)
    Property assessment As Assessment

    Property lobbyListbox As ListBox

    Public Sub New(assessment_ As Assessment)
        port = 5432
        ip = IPAddress.Parse(getIP)

        assessment = assessment_
        currentStudentID = 1


    End Sub

#Region "Server Setup"
    Public Function getIP() As String

        ' I found this method of obtaining the host’s IP address from the following link:
        ' https://stackoverflow.com/questions/2234757/how-do-i-get-a-computers-name-and-ip-address-using-vb-net
        Dim ip As String = ""
        ' get host entry
        Dim strHostName As String = Dns.GetHostName()
        Dim iphe As IPHostEntry = Dns.GetHostEntry(strHostName)

        ' find ipv4 address from address list
        For Each ipheal As IPAddress In iphe.AddressList
            If ipheal.AddressFamily = AddressFamily.InterNetwork Then
                ip = ipheal.ToString()
            End If
        Next
        Return ip
    End Function

    Public Function startServer() As Boolean
        'Teacher Objective 3a
        Try
            ' start listening
            listening = True
            serverListener = New TcpListener(ip, port)
            serverListener.Start()

            ' open thread for first client
            Threading.ThreadPool.QueueUserWorkItem(AddressOf newClient)

            Return True
        Catch ex As TypeAccessException
            MessageBox.Show("Couldn't start live session.")
            Return False
        End Try
    End Function
#End Region

#Region "Clients"
    Public Sub newClient(state As Object)
        'Student Objective 1a

        ' accept client
        Dim client As TcpClient = serverListener.AcceptTcpClient


        ' add student
        Dim s As New Student()

        s.client = client
        s.id = currentStudentID
        currentStudentID += 1

        s.Name = "Student " & s.id
        students.Add(s.id, s)


        Try
            sendAssessment(client)

            'Teacher Objective 3e
            'update participants listbox
            lobbyListbox.Invoke(Sub()
                                    lobbyListbox.Items.Add(s.Name)
                                End Sub)


            'open thread for next client
            Threading.ThreadPool.QueueUserWorkItem(AddressOf newClient)

            Dim threadOpen As Boolean = True


            While threadOpen

                ' receive from client
                Dim ns As NetworkStream = client.GetStream
                Dim toReceive(10000000) As Byte
                ns.Read(toReceive, 0, toReceive.Length)
                Dim student As Student = strToStudent(Text.Encoding.ASCII.GetString(toReceive))

                ' if student has been updated: updated assessment/perform appropriate operations
                If Not student.Equals(students(s.id)) Then
                    students(s.id) = student
                    student.client = client


                    ' check student status and alter assessment status accordingly:


                    'name requests - Student Objective 1b, Teacher 3e
                    If student.status.Substring(0, 3) = "nm?" Then

                        ' check uniqueness of name
                        Dim unique As Boolean = True
                        Dim index As Integer = 0
                        While unique And index < students.Count
                            If students.Values(index).Name = student.status.Substring(3, student.status.Length - 3) Then
                                unique = False
                            End If
                            index += 1
                        End While


                        If unique Then
                            assessment.status = "APR"
                            updateStudentListboxName(s.id, student.status.Substring(3, student.status.Length - 3))

                        Else
                            assessment.status = "DEN"
                        End If

                    ElseIf Not {"que", "ans", "end", "pos", "rID"}.Contains(assessment.status.Substring(0, 3)) Then


                        Select Case student.status ' send asssessment ID - Student Objective 1a, Teacher 3e
                            Case "waiting for verification"
                                assessment.status = "VER" & assessment.id

                            Case "waiting for index" ' send student's ID - Student Objective 1a, Teacher 3e
                                assessment.status = "IND" & s.id.ToString

                            Case "leaving" ' remove student
                                assessment.status = "DEL"
                                sendAssessment(client)
                                removeStudent(s.id)

                            Case "ready"
                                assessment.status = "000"

                            Case Else
                                assessment.status = "000"

                        End Select

                    End If


                    ' send updated assessment
                    If Not {"DEL", "pos", "leaving"}.Contains(assessment.status.Substring(0, 3)) Then
                        sendAssessment(client)
                    End If


                End If


                ' check thread open/closed
                threadOpen = False
                If listening And students.ContainsKey(s.id) Then
                    If students(s.id).client.Connected Then
                        threadOpen = True
                    Else

                        removeStudent(s.id)
                    End If
                End If


            End While
        Catch ex As Exception


            ' display error message
            If Not students(s.id).status = "leaving" Then
                MessageBox.Show($"An error occurred. A {students(s.id).Name}'s connection has failed.")
            End If

            removeStudent(s.id)

        End Try
    End Sub

#End Region

#Region "Students"
    Public Sub removeStudent(id As Integer)

        If students.ContainsKey(id) Then

            ' update listbox
            lobbyListbox.Invoke(Sub()
                                    lobbyListbox.Items.Remove(students(id).Name)
                                End Sub)

            students(id).client.Close()

            students.Remove(id)

        End If



    End Sub

    Public Sub changeStudentsName(oldName As String, newName As String)
        'Student Objective 1b, Teacher 3e

        Dim id As Integer = getStudentIDFromName(oldName)
        If id > -1 Then
            ' update listbox
            updateStudentListboxName(id, newName)

            ' send change msg to student client
            assessment.status = "NAM" & newName
            sendAssessment(students(id).client)
            assessment.status = "000"
        End If

    End Sub


    Public Sub updateStudentListboxName(id As Integer, newName As String)
        ' Student Objective 1b, Teacher 3e
        ' find item in listbox
        Dim currentName As String = students(id).Name
        For i = 0 To lobbyListbox.Items.Count - 1

            If lobbyListbox.Items(i) = currentName Then
                Dim index As Integer = i
                ' update listbox
                lobbyListbox.Invoke(Sub()
                                        lobbyListbox.Items(index) = newName
                                    End Sub)
            End If
        Next

        ' update students
        students(id).Name = newName
    End Sub


    Public Function getStudentIDFromName(name As String) As Integer
        Dim id As Integer = -1

        ' repeat 3 times if exception thrown (collection was modified during process)
        Dim retries As Integer = 0
        While retries < 3
            Try
                For Each key As Integer In students.Keys
                    If students(key).Name = name Then
                        id = key
                    End If
                Next
                retries = 3
            Catch ex As Exception
                retries += 1

                ' retry/end
                retries += 1
            End Try
        End While

        Return id
    End Function


    Public Function getStudentScoresAndNames(names As List(Of String)) As List(Of Integer())
        ' Teacher 3b, 4b, 4c
        ' get all students scores
        Dim studentScores As New List(Of Integer())
        For i = 0 To students.Count - 1
            studentScores.Add({i, students.Values(i).getTotalMark})
            names.Add(students.Values(i).Name)
        Next

        Return studentScores
    End Function



#End Region

#Region "Sending Assessment"

    Public Function sendAssessmentToAll2() As Boolean
        ' for each student client
        Dim s As Integer = 0
        Dim count As Integer = students.Count
        While s < count

            Try
                ' send assessment to client
                Dim ns As NetworkStream = students.Values(s).client.GetStream
                Dim sendText As String = assessmentToStr(assessment)
                ns.Write(Text.Encoding.ASCII.GetBytes(sendText), 0, sendText.Length)

                s += 1

            Catch ex As Exception
                Return False
            End Try
        End While


        Return True

    End Function

    Public Sub sendAssessmentToAll()
        ' for each student client
        Dim s As Integer = 0
        Dim count As Integer = students.Count

        Dim retries As Integer
        While s < count


            ' repeat 3 times if exception thrown (collection was modified during process)
            retries = 0
            While retries < 3
                Try

                    ' send assessment to client
                    Dim ns As NetworkStream = students.Values(s).client.GetStream
                    Dim sendText As String = assessmentToStr(assessment)
                    ns.Write(Text.Encoding.ASCII.GetBytes(sendText), 0, sendText.Length)

                    s += 1

                    retries = 3
                Catch ex As Exception


                    ' retry/end
                    retries += 1
                End Try
            End While

        End While


    End Sub

    Public Function sendAssessment(client As TcpClient) As Boolean

        Try
            ' send assessment to client
            Dim ns As NetworkStream = client.GetStream
            Dim sendText As String = assessmentToStr(assessment)
            ns.Write(Text.Encoding.ASCII.GetBytes(sendText), 0, sendText.Length)

            Return True
        Catch ex As OverflowException
            Return False
        End Try


    End Function

#End Region

#Region "Conversions (string <-> object)"

    ' serialize and deserialize json from mic docs website
    'https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-how-to?pivots=dotnet-6-0

    Public Function assessmentToStr(assessment As Assessment) As String
        ' converts an assessment object to a JSON object string
        Return JsonSerializer.Serialize(assessment)
    End Function

    Public Function strToStudent(str As String) As Student
        ' converts a str with a JSON object to an Assessment object



        ' deserializing json produced a string with a long series of trailing 'vbNull' characters with the following exception:
        ' System.Text.Json.JsonException: ''0x00' is invalid after a single JSON value. Expected end of data.
        ' the following code removes these characters to make the string valid for transmission
        Dim strEnd As Boolean = False
        Dim i As Integer = -1
        While Not strEnd
            i += 1
            If str(i) = vbNullChar Then
                strEnd = True
            End If
        End While
        str = str.Substring(0, i)





        ' got this EXCEPTION  on a few dif occasions:System.Text.Json.JsonException: ''{' is invalid after a single JSON value. Expected end of data. Path: $ | LineNumber: 0 | BytePositionInLine: 5133.'
        ' occurs when 2 JSON objects are sent in one string (the same one repeated) so the recieved JSON message.
        ' so it is expected that the JSON message ends when the first object is defined and closed with '}' but instead it contains another '}'
        ' SOLUTION: 
        ' the following code truncates the string so that there is only one json student object valid for deserialisation
        Dim openBrackets As Integer = 0
        Dim starting As Boolean = True
        Dim c As Integer = 0

        While openBrackets > 0 Or starting
            If str(c) = "{" Then
                openBrackets += 1
                starting = False

            ElseIf str(c) = "}" Then
                openBrackets -= 1
            End If

            c += 1
        End While

        Return JsonSerializer.Deserialize(Of Student)(str.Substring(0, c),)



    End Function

#End Region
End Class
