Imports System.Text.Json

Public Class S_LiveIDEnter
    Property controller As AppController
    Sub New(controller_ As AppController)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        controller = controller_
    End Sub

#Region "Form"
    Private Sub GamePinPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' set colours
        Me.BackColor = Color.White

        GoBtn.ForeColor = Color.White
        GoBtn.BackColor = controller.palette(2)

        HomeBtn.ForeColor = Color.White
        HomeBtn.BackColor = controller.palette(3)

        loginBtn.BackColor = Color.White
        loginBtn.ForeColor = controller.palette(0)


    End Sub
#End Region

#Region "Navigation"
    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        ' switch to home page
        Dim nextForm As New Home()
        controller.SwitchToHome(Me, controller, nextForm)

    End Sub
#End Region

#Region "Buttons"

    Private Sub GoBtn_Click(sender As Object, e As EventArgs) Handles GoBtn.Click
        ' Student objectives 1a

        ' get ip from assessment ID
        Dim ip As String = ""
        Dim id As String = ""
        For Each c In IDInput.Text

            If "1234567890".Contains(c) Then ' part of IP
                ip &= c
            ElseIf c <> " " Then ' part of assessment id/password
                id &= c
                ip &= "."
            End If
        Next


        ' create client
        Dim student As New Student()

        Dim client As New Client(ip, student, id, controller)
        client.student = student
        client.student.status = "waiting for verification"

        ' connect to server
        If client.connect() Then
            While client.student.status = "waiting for verification"
                UseWaitCursor = True
            End While

            UseWaitCursor = False

            If client.student.status = "verified" Then

                client.student.status = "waiting - lobby loading"
                Dim nextform As New S_Lobby(controller, client)
                controller.SwitchForms(Me, nextform)
            Else
                client.student.status = "leaving"
                client.sendStudent()
                MessageBox.Show("Invalid ID.")

            End If

        Else
            ' connection failed
            MessageBox.Show("Could not connect.")
        End If



    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        ' switch to Account page 

        controller.studentLogin = True
        controller.studentName = vbNullString

        Dim nextForm As New T_CreateAccount(controller)
        controller.SwitchForms(Me, nextForm)
    End Sub


#End Region
End Class