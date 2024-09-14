Public Class S_Results
    Property controller As AppController
    Property client As Client
    Sub New(controller_ As AppController, client_ As Client)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        controller = controller_
        Client = client_
    End Sub

#Region "Form"
    Private Sub S_Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' colours 
        BackBtn.BackColor = controller.palette(3)
        BackBtn.ForeColor = Color.White
        studentLoginBtn.BackColor = controller.palette(2)
        studentLoginBtn.ForeColor = Color.White
        studentLoginBtn.Visible = False


        'Student objective 2e
        ' game mode
        If client.assessment.gameMode Then

            ' score
            If client.assessment.getTotalMark > 0 Then
                markLbl.Text = $"You scored {client.student.getTotalMark}/{client.assessment.getTotalMark} ({Math.Round(client.student.getTotalMark / client.assessment.getTotalMark * 100)}%) "

            End If

            ' position
            If client.assessment.showPosition Then
                markLbl.Text &= $"and your position is {controller.getPositionText(client.student.position)}."
            End If

            ' title lbl
            Me.Text = $"{client.assessment.Name} - {client.student.Name}"
            titleLbl.Text = client.assessment.Name & " - Results"
        Else
            'Student objective 3c
            ' test mode
            If client.assessment.showResults Then
                ' score
                If client.assessment.getTotalMark > 0 Then
                    markLbl.Text = $"You scored {client.student.getTotalMark}/{client.assessment.getTotalMark} ({Math.Round(client.student.getTotalMark / client.assessment.getTotalMark * 100)}%) "

                    ' title lbl
                    Me.Text = $"{client.assessment.Name} - {client.student.Name}"
                    titleLbl.Text = client.assessment.Name & " - Results"
                End If


            Else

                ' title lbl
                Me.Text = $"{client.student.Name}: {client.assessment.Name} - Submitted"
                titleLbl.Text = $"{client.student.Name}: {client.assessment.Name} - Submitted"

                markLbl.Text = $"Your answers have been submitted. Thank you!"

                statusLbl.Visible = False
            End If

        End If

        If client.assessment.gameMode Or client.assessment.showResults Then

            Timer.Start()
        End If

    End Sub


    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim ans As MsgBoxResult = MsgBox("Are you sure you want to leave? Your will not be able to return to this page.", MessageBoxButtons.YesNo)
        If ans = MsgBoxResult.Yes Then
            Dim nextForm As New S_LiveIDEnter(controller)
            controller.SwitchForms(Me, nextForm)
        End If
    End Sub

#End Region


#Region "Log In"

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        'Student objective 4a
        ' enable student login with new report id
        If client.assessment.status.Substring(0, 3) = "rID" Then
            controller.reportID = client.assessment.status.Substring(3, client.assessment.status.Length - 3)
            statusLbl.Text = "The teacher has saved the live report. To view your own report, login to the student portal:"
            studentLoginBtn.Visible = True

            Timer.Stop()
        End If
    End Sub

    Private Sub studentLoginBtn_Click(sender As Object, e As EventArgs) Handles studentLoginBtn.Click
        'Student objective 4a
        ' get id
        controller.studentID = controller.DBController.SelectValues("Students", "StudentID", $"ReportID='{controller.reportID}' AND Name = '{client.student.Name}'")(0)(0)

        controller.studentName = client.student.Name
        controller.studentLogin = True

        ' log in/account page
        Dim nextForm As New T_CreateAccount(controller)
        controller.SwitchForms(Me, nextForm)


    End Sub
#End Region
End Class