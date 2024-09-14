Public Class S_Lobby
    Property controller As AppController
    Property client As Client

    Property currentName As String
    Sub New(controller_ As AppController, client_ As Client)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        controller = controller_

        client = client_
        client.lobbyForm = Me



    End Sub

#Region "Form"
    Private Sub StudentLobby_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' set colours
        Me.BackColor = Color.White

        changeNameBtn.BackColor = controller.palette(2)
        changeNameBtn.ForeColor = Color.White

        HomeBtn.ForeColor = Color.White
        HomeBtn.BackColor = controller.palette(3)
        LeaveBtn.ForeColor = Color.White
        LeaveBtn.BackColor = controller.palette(3)



        ' assign Client object's controls 
        client.nameLbl = displayNameLbl

        client.student.status = "waiting for index"


        ' create start label/button dependant on live mode

        If client.assessment.gameMode Then
            ' label
            Dim con As New Label()
            con.Text = "Waiting for Teacher to Start..."
            ' appearance
            con.Dock = DockStyle.Fill
            con.TextAlign = ContentAlignment.MiddleCenter
            con.Font = New Font(New FontFamily("Segoe UI"), 14, FontStyle.Regular)

            Table.Controls.Add(con, 1, 3)


            ' start timer
            Timer.Start()


            ' Student Objective 1b
            ' random names
            If client.assessment.chooseName = False Then
                changeNameBtn.Text = "Change name to: " & client.student.generateRandomName(client.student.Name)
            End If
        Else
            'button
            Dim con As New Button()
            con.Text = "Start Assessment"

            ' appearance
            con.Anchor = AnchorStyles.Bottom And AnchorStyles.Top And AnchorStyles.Left And AnchorStyles.Right
            con.AutoSize = True
            con.TextAlign = ContentAlignment.MiddleCenter
            con.Font = New Font(New FontFamily("Segoe UI"), 16, FontStyle.Regular)
            con.FlatStyle = FlatStyle.Flat
            con.Margin = New Padding(50)
            ' colours
            con.BackColor = Color.White
            con.ForeColor = controller.palette(0)



            AddHandler con.Click, New EventHandler(AddressOf startBtnClick)


            Table.Controls.Add(con, 1, 3)
        End If



    End Sub
#End Region

#Region "Navigation"


    Private Sub LeaveBtn_Click(sender As Object, e As EventArgs) Handles LeaveBtn.Click
        ' close connection
        client.student.status = "leaving"

    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Dim nextForm As New Home()
        controller.SwitchToHome(Me, controller, nextForm)
    End Sub

#End Region

#Region "Buttons"

    Private Sub changeNameBtn_Click(sender As Object, e As EventArgs) Handles changeNameBtn.Click
        'Student Objective 1b

        ' get student name input
        Dim name As String
        If client.assessment.chooseName Then
            name = InputBox("Enter new display name: ", "Change Name", client.student.Name)

            name = StrConv(name, vbProperCase)

            ' validate name and update status
            If name.Trim <> "" And name <> client.student.Name Then
                client.student.status = "nm?" & name
            End If

            ' send updated student
            client.sendStudent()
        Else


            ' only allow name change if current name is updated/confirmed by server
            If client.student.status.Substring(0, 3) <> "nm?" Then

                name = changeNameBtn.Text.Substring("Change name to: ".Length, changeNameBtn.Text.Length - "Change name to: ".Length)
                client.student.status = "nm?" & name
                client.sendStudent()
                changeNameBtn.Text = "Change name to: " & client.student.generateRandomName(name)
            Else
                MessageBox.Show("Could not update name. To many requests in a short time period.")
            End If



        End If



    End Sub

    Private Sub startBtnClick(sender As Object, e As EventArgs)
        ' Student Objective 
        ' start live test 
        client.student.status = "que0"
        client.sendStudent()
        Dim nextForm As New S_LiveQuestions(controller, client)
        controller.SwitchForms(Me, nextForm)

    End Sub

    Private Sub S_Lobby_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' if user closed form - close connection
        If {"que0", "left"}.Contains(client.student.status) Then
            client.student.status = "leaving"
        End If

    End Sub



#End Region

#Region "Timer"

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        ' stop timer if student starts assessment
        If client.assessment.status = "que0" Then
            client.student.status = "que0"

            Timer.Stop()
            Dim nextForm As New S_LiveQuestions(controller, client)
            controller.SwitchForms(Me, nextForm)

        End If
    End Sub
#End Region


End Class