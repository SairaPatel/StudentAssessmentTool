
Public Class Home
    Property controller As New AppController
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub StudentBtn_Click(sender As Object, e As EventArgs) Handles StudentBtn.Click
        ' switch to student form
        controller.studentLogin = True
        Dim nextForm As New S_LiveIDEnter(controller)
        controller.SwitchForms(Me, nextForm)
    End Sub

    Private Sub TeacherBtn_Click(sender As Object, e As EventArgs) Handles TeacherBtn.Click
        ' switch to teacher form
        controller.studentLogin = False
        Dim nextForm As New T_CreateAccount(controller)
        controller.SwitchForms(Me, nextForm)


    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' set colours

        Me.BackColor = Color.White

        StudentBtn.ForeColor = Color.White
        StudentBtn.BackColor = controller.palette(2)
        TeacherBtn.ForeColor = Color.White
        TeacherBtn.BackColor = controller.palette(2)
        colourBtn.BackColor = controller.palette(2)
        colourBtn.ForeColor = Color.White


    End Sub


    Private Sub colourBtn_Click(sender As Object, e As EventArgs) Handles colourBtn.Click
        ' change colour palette
        controller.switchPalette()

        StudentBtn.BackColor = controller.palette(2)
        TeacherBtn.BackColor = controller.palette(2)
        colourBtn.BackColor = controller.palette(2)
    End Sub



End Class
