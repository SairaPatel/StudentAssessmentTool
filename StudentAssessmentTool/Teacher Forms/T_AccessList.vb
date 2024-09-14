Public Class T_AccessList
    Property controller As AppController
    Property AllowedUsers As List(Of Object())
    Sub New(controller_ As AppController, ByRef users As List(Of Object()))

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        controller = controller_
        AllowedUsers = users

    End Sub

#Region "Form "
    Private Sub AccessList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' control colours
        Me.BackColor = Color.White

        AddBtn.ForeColor = controller.palette(0)
        AddBtn.BackColor = controller.palette(3)
        SaveBtn.BackColor = controller.palette(1)
        SaveBtn.ForeColor = Color.White

        ' populate listbox with CurrentUsers names
        For Each item In AllowedUsers
            AccessListbox.Items.Add(item(1))
        Next

        EnableDisableListbox()


    End Sub

    Public Sub EnableDisableListbox()
        If AccessListbox.Items.Count = 0 Then
            ' disable empty listbox

            AccessListbox.Items.Add("Enter a name below to start your Access List.")
            AccessListbox.Enabled = False

        Else
            ' enable empty listbox
            If Not AccessListbox.Enabled Then
                AccessListbox.Items.RemoveAt(0)
                AccessListbox.Enabled = True

            End If
        End If

    End Sub
#End Region

#Region "Add"

    Public Sub addUser()
        ' get user
        Dim users As List(Of Object()) = controller.DBController.SelectValues("Teachers", "*", $"Username='{UsernameInput.Text}'")



        If users.Count = 0 Then ' if user exists 
            MessageBox.Show("This username does not exist.")

        ElseIf users(0)(0) = controller.currentUserID Then ' if not current user
            MessageBox.Show("You cannot add yourself to the access list. You already have access to this assessment.")
        Else

            EnableDisableListbox()
            AccessListbox.Items.Add(UsernameInput.Text)
            UsernameInput.Text = ""

            ' add to allowedUsers
            AllowedUsers.Add({users(0)(0), users(0)(1)})
        End If



    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        addUser()
    End Sub

    Private Sub UsernameInput_KeyDown(sender As Object, e As KeyEventArgs) Handles UsernameInput.KeyDown
        ' enter key pressed
        If e.KeyCode = Keys.Enter Then
            addUser()
        End If
    End Sub

#End Region

#Region "Delete"

    Private Sub AccessListbox_KeyDown(sender As Object, e As KeyEventArgs) Handles AccessListbox.KeyDown
        Dim index As Integer = AccessListbox.SelectedIndex
        'delete key pressed
        If e.KeyCode = Keys.Delete Then

            ' removes item from allowed list
            AccessListbox.Items.RemoveAt(index)
            AllowedUsers.RemoveAt(index)

            EnableDisableListbox()

            'reselect an item
            If AccessListbox.Enabled Then
                If index = 0 Then
                    AccessListbox.SelectedIndex = index
                Else
                    AccessListbox.SelectedIndex = index - 1
                End If
            End If


        End If

    End Sub
#End Region


End Class