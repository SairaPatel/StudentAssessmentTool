Imports System.Net
Imports System.Net.Sockets
Imports System.Text.Json ' installed Nuget package System.Text.Json


Public Class Client
    Property connectedClient As TcpClient
    Property connected As Boolean

    Property port As Integer
    Property ip As String

    Property student As Student
    Property assessment As Assessment


    Property controller As AppController

    Property lobbyForm As S_Lobby
    Property nameLbl As Label

    Property id As String


    Public Sub New(ip_ As String, student_ As Student, id_ As String, controller_ As AppController)
        port = 5432
        ip = ip_

        assessment = New Assessment
        student = student_
        id = id_

        controller = controller_


    End Sub
#Region "Setup connection"

    Public Function connect() As Boolean
        Try
            ' Student Objective 1a
            ' create client
            connectedClient = New TcpClient(ip, port)
            connected = True

            ' create thread for sending/receiving
            Threading.ThreadPool.QueueUserWorkItem(AddressOf updateAssessment)

            Return True

        Catch exception As Exception
            'MessageBox.Show(exception.Message)
            Return False

        End Try



    End Function
#End Region

#Region "Client Connection"
    Public Sub updateAssessment()

        While connected
            Try
                ' receive from client
                Dim ns As NetworkStream = connectedClient.GetStream()
                Dim toReceive(10000000) As Byte
                ns.Read(toReceive, 0, toReceive.Count)

                Dim recievedString As String = Text.Encoding.ASCII.GetString(toReceive).Trim
                assessment = strToAssessment(recievedString)


                ' view and update statuses
                Dim code As String = assessment.status.Substring(0, 3)
                Dim message As String = assessment.status.Substring(3, assessment.status.Length - 3)


                Select Case code
                    Case "VER" ' id verified - Student Objective 1a
                        assessment.id = message
                        If id = assessment.id Then
                            student.status = "verified"
                        Else
                            student.status = "id invalid"
                        End If
                    Case "IND" ' student index xx... - Student Objective 1b
                        student.id = Val(message)
                        student.Name = $"Student {student.id}"
                        updateName()
                        student.status = "ready"

                    Case "APR" ' name approved - Student Objective 1b
                        If student.status.Substring(0, 3) = "nm?" Then
                            student.Name = student.status.Substring(3, student.status.Length - 3)
                            updateName()
                            student.status = "ready"
                        End If

                    Case "DEN" ' name denied (not unique) - Student Objective 1b
                        student.status = "ready"
                        MessageBox.Show("Someone already has this display name.")

                    Case "NAM" ' name changed xx...

                        student.Name = message
                        updateName()
                        student.status = "ready"


                    Case "REM" ' teacher removed student 
                        MessageBox.Show("You have been removed from this session.")
                        student.status = "leaving"

                    Case "pos"
                        student.position = Val(message)
                        sendStudent()


                    Case "DEL" 'student/client removed from server lists
                        student.status = "left"
                        connected = False
                        ns.Close()
                        connectedClient.Close()
                        lobbyForm.Invoke(Sub()
                                             Dim nextForm As New S_LiveIDEnter(controller)
                                             controller.SwitchForms(lobbyForm, nextForm)
                                         End Sub)
                    Case "END"
                        MessageBox.Show("This session has ended.")
                        student.status = "leaving"
                        sendStudent()


                End Select


                'send student object
                If student.status <> "left" And student.status <> "leaving" Then
                    sendStudent()
                End If

            Catch ex As Exception

                MessageBox.Show($"An error occurred. You have been disconnected.")

                connected = False

                connectedClient.Close()
                lobbyForm.Invoke(Sub()
                                     Dim nextForm As New S_LiveIDEnter(controller)
                                     controller.SwitchForms(lobbyForm, nextForm)
                                 End Sub)

            End Try


        End While

    End Sub

    Public Sub updateName()
        nameLbl.Invoke(Sub()
                           nameLbl.Text = "Your display name: " & student.Name
                       End Sub)

    End Sub



    Public Function sendStudent() As Boolean
        ' send student object to server
        Try
            Dim ns As NetworkStream = connectedClient.GetStream
            Dim sendText As String = studentToStr(student)
            ns.Write(Text.Encoding.ASCII.GetBytes(sendText), 0, sendText.Length)

            Return True
        Catch ex As OverflowException
            MessageBox.Show("Error (client.sendStudent): " & ex.Message)
            Return False
        End Try
    End Function
#End Region

#Region "Conversions (string <-> object)"

    ' serialize and deserialize json from mic docs website
    'https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-how-to?pivots=dotnet-6-0


    Public Function strToAssessment(str As String) As Assessment
        ' converts a str with a JSON object to an Assessment object


        ' deserializing json produced a string with a long series of trailing 'vbNull' characters with the following exception:
        ' System.Text.Json.JsonException: ''0x00' is invalid after a single JSON value. Expected end of data.
        ' the following code removes these characters to make the string valid for transmission:
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
        ' the following code truncates the string so that there is only one json student object valid for deserialisation:
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

        Return JsonSerializer.Deserialize(Of Assessment)(str.Substring(0, c),)


    End Function


    Public Function studentToStr(student As Student) As String
        ' converts a student object to a JSON object string
        Return JsonSerializer.Serialize(student)
    End Function
#End Region
End Class
