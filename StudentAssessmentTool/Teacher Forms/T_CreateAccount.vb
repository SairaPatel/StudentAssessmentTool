Public Class T_CreateAccount
    Property controller As AppController

    Sub New(controller_ As AppController)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        controller = controller_

    End Sub


#Region "Form"
    Private Sub TeacherCreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If controller.studentLogin Then
            ' title
            TitleLbl.Text = "Student Account"

        Else
                ' title
                TitleLbl.Text = "Teacher Account"
        End If

        ' add show btns to password inputs
        PasswordInput.Controls.Add(ShowBtn)
        CPasswordInput.Controls.Add(CShowBtn)
        CPasswordInput2.Controls.Add(CShowBtn2)
        ' change login/create account button row span
        CreateAccountTbl.SetRowSpan(CreateAccountBtn, 2)
        LoginTbl.SetRowSpan(LoginBtn, 2)

        ' set colours
        Me.BackColor = Color.GhostWhite

        'TitleLbl.ForeColor = controller.blues(0)

        CreateAccountTbl.BackColor = Color.White
        LoginTbl.BackColor = Color.White

        For Each c As Control In CreateAccountTbl.Controls
            'c.ForeColor = Color.White
        Next
        For Each c As Control In LoginTbl.Controls
            'c.ForeColor = Color.White
        Next

        CShowBtn.ForeColor = Color.Transparent
        CShowBtn2.ForeColor = Color.Transparent
        ShowBtn.ForeColor = Color.Transparent

        CreateAccountBtn.BackColor = controller.palette(2)
        CreateAccountBtn.ForeColor = Color.White
        LoginBtn.BackColor = controller.palette(2)
        LoginBtn.ForeColor = Color.White

        BackBtn.BackColor = controller.palette(3)
        BackBtn.ForeColor = controller.palette(3)

    End Sub


#End Region

#Region "Navigation"

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim nextForm As New Home()
        controller.SwitchToHome(Me, controller, nextForm)
    End Sub

#End Region

#Region "Create Account"
    Private Sub CreateAccountBtn_Click(sender As Object, e As EventArgs) Handles CreateAccountBtn.Click

        Cursor = Cursors.WaitCursor

        ' set db table depending on teacher or student login
        Dim table As String = "Teachers"
        If controller.studentLogin Then
            table = "StudentUsers"
        End If

        ' check for existing username
        Dim users As List(Of Object()) = controller.DBController.SelectValues(table, "Username", $"Username='{CUsernameInput.Text}'")

        ' validate username 
        If users.Count > 0 Then
            CValidLbl.Text = "This username already exists."
        ElseIf CUsernameInput.Text.Contains(" ") Then
            CValidLbl.Text = "Username must not contain any spaces."

            ' validate password
        ElseIf CPasswordInput.Text.Length < 6 Then
            CValidLbl.Text = "Password must contain at least 6 characters."
        ElseIf CPasswordInput.Text.Contains(" ") Then
            CValidLbl.Text = "Password must not contain any spaces."
        ElseIf CPasswordInput.Text.ToUpper = CPasswordInput.Text Or CPasswordInput.Text.ToLower = CPasswordInput.Text Then
            CValidLbl.Text = "Password must contain at least 1 uppercase character and at least 1 lowercase character."
        ElseIf Not CPasswordInput.Text.Any(Function(c) "1234567890".Contains(c)) Then 'Any: https://stackoverflow.com/questions/58435061/what-is-the-linq-any-query-in-vb-net
            CValidLbl.Text = "Password must contain at least 1 numerical digit."

            ' validate repeat password
        ElseIf CPasswordInput.Text <> CPasswordInput2.Text Then
            CValidLbl.Text = "Passwords do not match."
        Else

            ' add user to database
            controller.DBController.AddValues(table, {CUsernameInput.Text, CPasswordInput.Text})
            ' get userID
            controller.currentUserID = controller.DBController.SelectValues(table, "UserID", $"Username='{CUsernameInput.Text}'")(0)(0)


            If controller.studentLogin Then
                'Student Objective 4a

                If controller.studentName <> vbNullString Then
                    ' add student report
                    controller.DBController.AddValues("StudentReports", {controller.reportID, controller.studentName, controller.currentUserID})

                    ' student view report 
                    Dim nextForm As New T_ViewReport(controller, True, True)
                    controller.SwitchForms(Me, nextForm)
                Else
                    ' all students reports
                    Dim nextForm As New T_Reports(controller)
                    controller.SwitchForms(Me, nextForm)

                End If

            Else
                'Teacher Objective 1a
                ' teacher assessments form
                controller.sharedAssessments = False
                Dim nextForm As New T_AllAssessments(controller)
                controller.SwitchForms(Me, nextForm)
            End If
        End If

        Cursor = Cursors.Default

    End Sub

    Private Sub CShowBtn_Click(sender As Object, e As EventArgs) Handles CShowBtn.Click
        ' show/hide password chars
        If CPasswordInput.PasswordChar = "•" Then
            CPasswordInput.PasswordChar = ""
            CShowBtn.ImageIndex = 1
        Else
            CPasswordInput.PasswordChar = "•"
            CShowBtn.ImageIndex = 0
        End If

        CPasswordInput.Focus()
    End Sub

    Private Sub CUsernameInput_TextChanged(sender As Object, e As EventArgs) Handles CUsernameInput.TextChanged
        CValidLbl.Text = ""
    End Sub

    Private Sub CPasswordInput_TextChanged(sender As Object, e As EventArgs) Handles CPasswordInput.TextChanged
        CValidLbl.Text = ""
    End Sub

    Private Sub CPasswordInput2_TextChanged(sender As Object, e As EventArgs) Handles CPasswordInput2.TextChanged
        CValidLbl.Text = ""
    End Sub

    Private Sub CShowBtn2_Click(sender As Object, e As EventArgs) Handles CShowBtn2.Click
        ' show/hide password chars
        If CPasswordInput2.PasswordChar = "•" Then
            CPasswordInput2.PasswordChar = ""
            CShowBtn2.ImageIndex = 1
        Else
            CPasswordInput2.PasswordChar = "•"
            CShowBtn2.ImageIndex = 0
        End If
        CPasswordInput2.Focus()
    End Sub
#End Region

#Region "Log In"

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click

        Cursor = Cursors.WaitCursor

        ' set db table depending on teacher or student login
        Dim table As String = "Teachers"
        If controller.studentLogin Then
            table = "StudentUsers"
        End If

        ' get user from database
        Dim users As List(Of Object()) = controller.DBController.SelectValues(table, "Username, Password", $"Username='{UsernameInput.Text}'")


        If users.Count = 0 Then
            ' invalid username
            LValidLbl.Text = "There is no existing account with this username. (Click the 'Create Account' tab if you would like to create one.)"

        ElseIf users(0)(1) <> PasswordInput.Text Then
            ' invalid password
            LValidLbl.Text = "The password you have entered is incorrect."
        Else
            ' get userID
            controller.currentUserID = controller.DBController.SelectValues(table, "UserID", $"Username='{UsernameInput.Text}'")(0)(0)

            If controller.studentLogin Then
                'Student Objective 4a

                If controller.studentName <> vbNullString Then
                    ' add student report
                    controller.DBController.AddValues("StudentReports", {controller.reportID, controller.studentName, controller.currentUserID})

                    ' student view report 
                    Dim nextForm As New T_ViewReport(controller, True, True)
                    controller.SwitchForms(Me, nextForm)
                Else
                    ' all students reports
                    Dim nextForm As New T_Reports(controller)
                    controller.SwitchForms(Me, nextForm)

                End If

            Else
                'Teacher Objective 1a
                ' teacher assessments form
                controller.sharedAssessments = False
                Dim nextForm As New T_AllAssessments(controller)
                controller.SwitchForms(Me, nextForm)
            End If

        End If

        Cursor = Cursors.Default

    End Sub



    Private Sub ShowBtn_Click(sender As Object, e As EventArgs) Handles tabControl.Click, ShowBtn.Click
        ' show/hide password chars
        If PasswordInput.PasswordChar = "•" Then
            PasswordInput.PasswordChar = ""
            ShowBtn.ImageIndex = 1
        Else
            PasswordInput.PasswordChar = "•"
            ShowBtn.ImageIndex = 0
        End If

        PasswordInput.Focus()
    End Sub

    Private Sub UsernameInput_TextChanged(sender As Object, e As EventArgs) Handles UsernameInput.TextChanged
        LValidLbl.Text = ""
    End Sub

    Private Sub PasswordInput_TextChanged(sender As Object, e As EventArgs) Handles PasswordInput.TextChanged
        LValidLbl.Text = ""
    End Sub

    Private Sub tabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabControl.SelectedIndexChanged
        If tabControl.SelectedIndex = 0 Then
            AcceptButton = LoginBtn
        Else
            AcceptButton = CreateAccountBtn
        End If
    End Sub



#End Region

End Class