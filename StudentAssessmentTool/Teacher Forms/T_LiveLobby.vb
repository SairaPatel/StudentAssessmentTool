Public Class T_LiveLobby
    Property controller As AppController
    Property server As Server
    Property quit As Boolean = False
    Sub New(controller_ As AppController, assessment_ As Assessment)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        controller = controller_

        server = New Server(assessment_)
    End Sub

#Region "Form"
    Private Sub T_LiveLobby_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' colours
        BackBtn.ForeColor = controller.palette(3)
        BackBtn.BackColor = controller.palette(3)

        ParticipantsListbox.BackColor = Color.GhostWhite

        StartBtn.BackColor = controller.palette(2)
        StartBtn.ForeColor = Color.White


        EditNameBtn.BackColor = controller.palette(2)
        EditNameBtn.ForeColor = Color.White


        DeleteBtn.BackColor = controller.palette(2)
        DeleteBtn.ForeColor = Color.White

        musicBtn.ForeColor = Color.White
        musicBtn.BackColor = controller.palette(2)

        ' hide start btn for test mode
        If Not server.assessment.gameMode Then
            StartBtn.Text = "End and Save"
        End If

        ' assign server controls
        LiveNameLbl.Text = server.assessment.Name
        server.lobbyListbox = ParticipantsListbox

        ' start server
        If Not server.startServer() Then

            Dim nextForm As New T_ViewAssessment(controller)
            controller.SwitchForms(Me, nextForm)
        End If

        ' Teacher Objective 3e
        ' assign random live id
        Randomize()
        Dim r As New Random()

        ' get live id
        IDLbl.Text = ""
        For Each d In server.ip.ToString
            If d = "." Then
                Dim c As Char = "abcdefghijklmnopqrstuvwxyz"(r.Next(0, 26))
                server.assessment.id &= c
                IDLbl.Text &= c & " "
            Else
                IDLbl.Text &= d

            End If
        Next


        'Teacher Objective 3b
        'music
        If server.assessment.music Then
            PlayLoopingLobbyMusic()
        Else
            musicBtn.Visible = False
        End If

        ' start timer
        Timer.Start()


    End Sub
#End Region

#Region "Music"
    ' Teacher Objective 3b


    Sub PlayLoopingLobbyMusic()
        My.Computer.Audio.Play(Application.StartupPath & "\Music\backgroundMusic.wav", AudioPlayMode.BackgroundLoop)
    End Sub


    Private Sub musicBtn_Click(sender As Object, e As EventArgs) Handles musicBtn.Click
        ' mute or unmute music (stop/start)
        If musicBtn.ImageIndex = 0 Then
            My.Computer.Audio.Stop()
        Else
            PlayLoopingLobbyMusic()
        End If

        ' change image index
        musicBtn.ImageIndex = (musicBtn.ImageIndex + 1) Mod 2

    End Sub
#End Region

#Region "Navigation"

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim ans As MsgBoxResult = MsgBox("Are you sure you want to go back. This will end the current live session?", MessageBoxButtons.YesNo)
        If ans = MsgBoxResult.Yes Then

            ' end connection
            server.assessment.status = "END"
            server.sendAssessmentToAll()

            quit = True

        End If
    End Sub

#End Region

#Region "Participants"

    Private Sub ParticipantsListbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ParticipantsListbox.SelectedIndexChanged, ParticipantsListbox.Click
        ' Teacher Objective 5a
        ' select student - display student status


        If ParticipantsListbox.SelectedIndex > -1 Then
            EditNameBtn.Visible = True
            DeleteBtn.Visible = True

            ' update status label
            updateStudentStatus()

        Else
            studentStatusLbl.Text = ""
        End If

    End Sub

    Private Sub EditNameBtn_Click(sender As Object, e As EventArgs) Handles EditNameBtn.Click
        ' Teacher Objective 3e
        ' update student's name


        If ParticipantsListbox.SelectedIndex > -1 Then
            Dim name As String = ParticipantsListbox.SelectedItem
            name = InputBox("Enter a New name for this student: ", "Edit Student Name", name)
            name = StrConv(name, vbProperCase)

            ' check unique
            Dim unique As Boolean = True
            For Each s In ParticipantsListbox.Items
                If s = name And s <> ParticipantsListbox.SelectedItem Then
                    unique = False
                End If
            Next

            ' update
            If unique Then
                server.changeStudentsName(ParticipantsListbox.SelectedItem, name)
            Else
                MessageBox.Show("Another student already has this display name.", "Invalid Name")
            End If

        End If

    End Sub


    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        ' remove student from live


        If ParticipantsListbox.SelectedIndex > -1 Then
            Dim res As MsgBoxResult = MsgBox("Are you sure you want to remove this student from the session?", MsgBoxStyle.YesNo, "Remove Student")

            Dim id As Integer = server.getStudentIDFromName(ParticipantsListbox.SelectedItem)

            If res = MsgBoxResult.Yes Then
                If id > -1 Then
                    ' remove student
                    server.assessment.status = "REM"
                    server.sendAssessment(server.students(id).client)
                    server.assessment.status = "000"

                    ' update btns
                    EditNameBtn.Visible = False
                    DeleteBtn.Visible = False

                End If
            End If



        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        ' Teacher objective 5a
        ' update selected student status
        If ParticipantsListbox.SelectedIndex > -1 Then

            updateStudentStatus()
        End If

        'Teacher Objective 3e
        ' update student count label
        If server.students.Count = 1 Then
            ParticipantsLbl.Text = $"{server.students.Count} Student"
        Else
            ParticipantsLbl.Text = $"{server.students.Count} Students"
        End If

        'Teacher Objective 5a
        ' check if all students have submitted
        If Not server.assessment.gameMode Then
            Dim studentCount As Integer = server.students.Count
            Dim i As Integer = 0
            Dim studentInProgress As Boolean = False
            While i < studentCount And Not studentInProgress
                If server.students.Values(i).status <> "assessment submitted" Then
                    studentInProgress = True
                End If
                i += 1
            End While


            StartBtn.Visible = Not studentInProgress
        End If


        ' quit
        If quit And server.students.Count = 0 Then

            server.listening = False
            server.serverListener.Stop()

            Dim nextForm As New T_ViewAssessment(controller)

            controller.SwitchForms(Me, nextForm)
        End If

    End Sub


    Private Sub updateStudentStatus()
        ' Teacher objective 5a

        ' get student id
        Dim id As Integer = server.getStudentIDFromName(ParticipantsListbox.SelectedItem)
        If id > -1 Then
            ' update status label
            Dim status As String = server.students(id).status
            Dim updatedText As String = $"{ParticipantsListbox.SelectedItem}: "
            studentStatusLbl.Text = $"{ParticipantsListbox.SelectedItem}: "

            ' show student's time left
            If status.Substring(0, 3) = "tim" Then
                updatedText &= $"In progress - {status.Substring(3, status.Length - 3)}"
            Else
                Select Case status
                    Case "que0"
                        updatedText &= "In progress"
                    Case "assessment submitted"
                        updatedText &= $"Completed: {server.students(id).getTotalMark()}/{server.assessment.getTotalMark()} "
                        If server.assessment.getTotalMark > 0 Then
                            updatedText &= $"- {Math.Round(server.students(id).getTotalMark() / server.assessment.getTotalMark() * 100)}%"
                        End If
                    Case Else
                        updatedText &= $"In Lobby"
                End Select
            End If

            ' only update if changed
            If updatedText <> studentStatusLbl.Text Then
                studentStatusLbl.Text = updatedText
            End If


        End If
    End Sub

    Private Sub StartBtn_Click(sender As Object, e As EventArgs) Handles StartBtn.Click
        If server.assessment.gameMode Then
            ' Teacher objective 4 (Game mode)
            ' game mode start
            server.assessment.status = "que0"
            server.sendAssessmentToAll()


            Dim nextForm As New T_GameModeQuestions(controller, server)
            controller.SwitchForms(Me, nextForm)
        Else
            ' Teacher objective 6 (Test Report)
            ' test mode end

            ' create report
            Dim id As Integer = controller.createReport(server)

            If id > -1 Then
                controller.reportID = id


                'Student Objective 4a
                ' send reportID to students
                server.assessment.status = "rID" & id
                server.sendAssessmentToAll()

                Dim nextForm As New T_ReportStudents(controller, True)
                controller.SwitchForms(Me, nextForm)
            End If
        End If

    End Sub
#End Region
End Class