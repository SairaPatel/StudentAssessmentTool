<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class T_CreateAccount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(T_CreateAccount))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.LoginTitle = New System.Windows.Forms.TabPage()
        Me.LoginTbl = New System.Windows.Forms.TableLayoutPanel()
        Me.PasswordInput = New System.Windows.Forms.TextBox()
        Me.PasswordLbl = New System.Windows.Forms.Label()
        Me.UsernameLbl = New System.Windows.Forms.Label()
        Me.UsernameInput = New System.Windows.Forms.TextBox()
        Me.ShowBtn = New System.Windows.Forms.Button()
        Me.VisibilityIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.LValidLbl = New System.Windows.Forms.Label()
        Me.CreateAccountTitle = New System.Windows.Forms.TabPage()
        Me.CreateAccountTbl = New System.Windows.Forms.TableLayoutPanel()
        Me.CShowBtn = New System.Windows.Forms.Button()
        Me.RepeatPasswordLbl = New System.Windows.Forms.Label()
        Me.CPasswordLbl = New System.Windows.Forms.Label()
        Me.CPasswordInput2 = New System.Windows.Forms.TextBox()
        Me.CPasswordInput = New System.Windows.Forms.TextBox()
        Me.CUsernameInput = New System.Windows.Forms.TextBox()
        Me.CUsernameLbl = New System.Windows.Forms.Label()
        Me.CValidLbl = New System.Windows.Forms.Label()
        Me.CShowBtn2 = New System.Windows.Forms.Button()
        Me.CreateAccountBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tabControl.SuspendLayout()
        Me.LoginTitle.SuspendLayout()
        Me.LoginTbl.SuspendLayout()
        Me.CreateAccountTitle.SuspendLayout()
        Me.CreateAccountTbl.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BackBtn, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TitleLbl, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tabControl, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(858, 446)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'BackBtn
        '
        Me.BackBtn.BackgroundImage = Global.StudentAssessmentTool.My.Resources.Resources.HomeIcon
        Me.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.Location = New System.Drawing.Point(798, 0)
        Me.BackBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(50, 50)
        Me.BackBtn.TabIndex = 3
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TitleLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleLbl.Font = New System.Drawing.Font("Segoe UI Light", 26.0!)
        Me.TitleLbl.Location = New System.Drawing.Point(60, 0)
        Me.TitleLbl.Margin = New System.Windows.Forms.Padding(0)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(738, 60)
        Me.TitleLbl.TabIndex = 1
        Me.TitleLbl.Text = "TEACHER ACCOUNT"
        Me.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabControl
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.tabControl, 3)
        Me.tabControl.Controls.Add(Me.LoginTitle)
        Me.tabControl.Controls.Add(Me.CreateAccountTitle)
        Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.tabControl.Location = New System.Drawing.Point(30, 90)
        Me.tabControl.Margin = New System.Windows.Forms.Padding(30)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(798, 326)
        Me.tabControl.TabIndex = 2
        '
        'LoginTitle
        '
        Me.LoginTitle.Controls.Add(Me.LoginTbl)
        Me.LoginTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LoginTitle.Location = New System.Drawing.Point(4, 47)
        Me.LoginTitle.Name = "LoginTitle"
        Me.LoginTitle.Padding = New System.Windows.Forms.Padding(3)
        Me.LoginTitle.Size = New System.Drawing.Size(790, 275)
        Me.LoginTitle.TabIndex = 0
        Me.LoginTitle.Text = "Login"
        Me.LoginTitle.UseVisualStyleBackColor = True
        '
        'LoginTbl
        '
        Me.LoginTbl.ColumnCount = 1
        Me.LoginTbl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.LoginTbl.Controls.Add(Me.PasswordInput, 0, 3)
        Me.LoginTbl.Controls.Add(Me.PasswordLbl, 0, 2)
        Me.LoginTbl.Controls.Add(Me.UsernameLbl, 0, 0)
        Me.LoginTbl.Controls.Add(Me.UsernameInput, 0, 1)
        Me.LoginTbl.Controls.Add(Me.ShowBtn, 0, 5)
        Me.LoginTbl.Controls.Add(Me.LoginBtn, 0, 4)
        Me.LoginTbl.Controls.Add(Me.LValidLbl, 0, 6)
        Me.LoginTbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoginTbl.Location = New System.Drawing.Point(3, 3)
        Me.LoginTbl.Name = "LoginTbl"
        Me.LoginTbl.Padding = New System.Windows.Forms.Padding(10)
        Me.LoginTbl.RowCount = 7
        Me.LoginTbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.38961!))
        Me.LoginTbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.88312!))
        Me.LoginTbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.38961!))
        Me.LoginTbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.88312!))
        Me.LoginTbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454!))
        Me.LoginTbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.LoginTbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.LoginTbl.Size = New System.Drawing.Size(784, 269)
        Me.LoginTbl.TabIndex = 0
        '
        'PasswordInput
        '
        Me.PasswordInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PasswordInput.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.PasswordInput.Location = New System.Drawing.Point(13, 87)
        Me.PasswordInput.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.PasswordInput.MaxLength = 40
        Me.PasswordInput.Name = "PasswordInput"
        Me.PasswordInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.PasswordInput.Size = New System.Drawing.Size(758, 45)
        Me.PasswordInput.TabIndex = 4
        '
        'PasswordLbl
        '
        Me.PasswordLbl.AutoSize = True
        Me.PasswordLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PasswordLbl.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.PasswordLbl.Location = New System.Drawing.Point(10, 66)
        Me.PasswordLbl.Margin = New System.Windows.Forms.Padding(0)
        Me.PasswordLbl.Name = "PasswordLbl"
        Me.PasswordLbl.Size = New System.Drawing.Size(764, 21)
        Me.PasswordLbl.TabIndex = 3
        Me.PasswordLbl.Text = "Password:"
        Me.PasswordLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'UsernameLbl
        '
        Me.UsernameLbl.AutoSize = True
        Me.UsernameLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UsernameLbl.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.UsernameLbl.Location = New System.Drawing.Point(10, 10)
        Me.UsernameLbl.Margin = New System.Windows.Forms.Padding(0)
        Me.UsernameLbl.Name = "UsernameLbl"
        Me.UsernameLbl.Size = New System.Drawing.Size(764, 21)
        Me.UsernameLbl.TabIndex = 1
        Me.UsernameLbl.Text = "Username:"
        Me.UsernameLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'UsernameInput
        '
        Me.UsernameInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UsernameInput.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.UsernameInput.Location = New System.Drawing.Point(13, 31)
        Me.UsernameInput.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.UsernameInput.MaxLength = 40
        Me.UsernameInput.Name = "UsernameInput"
        Me.UsernameInput.Size = New System.Drawing.Size(758, 45)
        Me.UsernameInput.TabIndex = 2
        '
        'ShowBtn
        '
        Me.ShowBtn.BackColor = System.Drawing.Color.Transparent
        Me.ShowBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ShowBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.ShowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowBtn.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.ShowBtn.ImageIndex = 0
        Me.ShowBtn.ImageList = Me.VisibilityIcons
        Me.ShowBtn.Location = New System.Drawing.Point(738, 222)
        Me.ShowBtn.Margin = New System.Windows.Forms.Padding(6)
        Me.ShowBtn.Name = "ShowBtn"
        Me.ShowBtn.Size = New System.Drawing.Size(30, 8)
        Me.ShowBtn.TabIndex = 14
        Me.ShowBtn.UseVisualStyleBackColor = False
        '
        'VisibilityIcons
        '
        Me.VisibilityIcons.ImageStream = CType(resources.GetObject("VisibilityIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.VisibilityIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.VisibilityIcons.Images.SetKeyName(0, "ShowIcon.png")
        Me.VisibilityIcons.Images.SetKeyName(1, "HideIcon.png")
        '
        'LoginBtn
        '
        Me.LoginBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LoginBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginBtn.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.LoginBtn.Location = New System.Drawing.Point(310, 140)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(164, 58)
        Me.LoginBtn.TabIndex = 0
        Me.LoginBtn.Text = "LOGIN"
        Me.LoginBtn.UseVisualStyleBackColor = True
        '
        'LValidLbl
        '
        Me.LValidLbl.AutoSize = True
        Me.LValidLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LValidLbl.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LValidLbl.ForeColor = System.Drawing.Color.Firebrick
        Me.LValidLbl.Location = New System.Drawing.Point(13, 236)
        Me.LValidLbl.Name = "LValidLbl"
        Me.LValidLbl.Size = New System.Drawing.Size(758, 23)
        Me.LValidLbl.TabIndex = 15
        Me.LValidLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CreateAccountTitle
        '
        Me.CreateAccountTitle.Controls.Add(Me.CreateAccountTbl)
        Me.CreateAccountTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CreateAccountTitle.Location = New System.Drawing.Point(4, 47)
        Me.CreateAccountTitle.Name = "CreateAccountTitle"
        Me.CreateAccountTitle.Padding = New System.Windows.Forms.Padding(3)
        Me.CreateAccountTitle.Size = New System.Drawing.Size(790, 275)
        Me.CreateAccountTitle.TabIndex = 1
        Me.CreateAccountTitle.Text = "Create Account"
        Me.CreateAccountTitle.UseVisualStyleBackColor = True
        '
        'CreateAccountTbl
        '
        Me.CreateAccountTbl.ColumnCount = 2
        Me.CreateAccountTbl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.CreateAccountTbl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.CreateAccountTbl.Controls.Add(Me.CShowBtn, 0, 7)
        Me.CreateAccountTbl.Controls.Add(Me.RepeatPasswordLbl, 0, 4)
        Me.CreateAccountTbl.Controls.Add(Me.CPasswordLbl, 0, 2)
        Me.CreateAccountTbl.Controls.Add(Me.CPasswordInput2, 0, 5)
        Me.CreateAccountTbl.Controls.Add(Me.CPasswordInput, 0, 3)
        Me.CreateAccountTbl.Controls.Add(Me.CUsernameInput, 0, 1)
        Me.CreateAccountTbl.Controls.Add(Me.CUsernameLbl, 0, 0)
        Me.CreateAccountTbl.Controls.Add(Me.CValidLbl, 0, 8)
        Me.CreateAccountTbl.Controls.Add(Me.CShowBtn2, 0, 6)
        Me.CreateAccountTbl.Controls.Add(Me.CreateAccountBtn, 1, 5)
        Me.CreateAccountTbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CreateAccountTbl.Location = New System.Drawing.Point(3, 3)
        Me.CreateAccountTbl.Name = "CreateAccountTbl"
        Me.CreateAccountTbl.Padding = New System.Windows.Forms.Padding(3)
        Me.CreateAccountTbl.RowCount = 9
        Me.CreateAccountTbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.CreateAccountTbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.CreateAccountTbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.CreateAccountTbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.CreateAccountTbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.CreateAccountTbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.CreateAccountTbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CreateAccountTbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.CreateAccountTbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CreateAccountTbl.Size = New System.Drawing.Size(784, 269)
        Me.CreateAccountTbl.TabIndex = 1
        '
        'CShowBtn
        '
        Me.CShowBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CShowBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.CShowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CShowBtn.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.CShowBtn.ImageIndex = 0
        Me.CShowBtn.ImageList = Me.VisibilityIcons
        Me.CShowBtn.Location = New System.Drawing.Point(745, 229)
        Me.CShowBtn.Margin = New System.Windows.Forms.Padding(6)
        Me.CShowBtn.Name = "CShowBtn"
        Me.CShowBtn.Size = New System.Drawing.Size(30, 9)
        Me.CShowBtn.TabIndex = 13
        Me.CShowBtn.UseVisualStyleBackColor = True
        '
        'RepeatPasswordLbl
        '
        Me.RepeatPasswordLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RepeatPasswordLbl.AutoSize = True
        Me.RepeatPasswordLbl.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RepeatPasswordLbl.Location = New System.Drawing.Point(3, 113)
        Me.RepeatPasswordLbl.Margin = New System.Windows.Forms.Padding(0)
        Me.RepeatPasswordLbl.Name = "RepeatPasswordLbl"
        Me.RepeatPasswordLbl.Size = New System.Drawing.Size(162, 22)
        Me.RepeatPasswordLbl.TabIndex = 11
        Me.RepeatPasswordLbl.Text = "Repeat Password:"
        Me.RepeatPasswordLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'CPasswordLbl
        '
        Me.CPasswordLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CPasswordLbl.AutoSize = True
        Me.CPasswordLbl.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CPasswordLbl.Location = New System.Drawing.Point(3, 58)
        Me.CPasswordLbl.Margin = New System.Windows.Forms.Padding(0)
        Me.CPasswordLbl.Name = "CPasswordLbl"
        Me.CPasswordLbl.Size = New System.Drawing.Size(97, 22)
        Me.CPasswordLbl.TabIndex = 10
        Me.CPasswordLbl.Text = "Password:"
        Me.CPasswordLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'CPasswordInput2
        '
        Me.CreateAccountTbl.SetColumnSpan(Me.CPasswordInput2, 2)
        Me.CPasswordInput2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CPasswordInput2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.CPasswordInput2.Location = New System.Drawing.Point(6, 135)
        Me.CPasswordInput2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.CPasswordInput2.MaxLength = 40
        Me.CPasswordInput2.Name = "CPasswordInput2"
        Me.CPasswordInput2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.CPasswordInput2.Size = New System.Drawing.Size(772, 45)
        Me.CPasswordInput2.TabIndex = 6
        '
        'CPasswordInput
        '
        Me.CreateAccountTbl.SetColumnSpan(Me.CPasswordInput, 2)
        Me.CPasswordInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CPasswordInput.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.CPasswordInput.Location = New System.Drawing.Point(6, 80)
        Me.CPasswordInput.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.CPasswordInput.MaxLength = 40
        Me.CPasswordInput.Name = "CPasswordInput"
        Me.CPasswordInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.CPasswordInput.Size = New System.Drawing.Size(772, 45)
        Me.CPasswordInput.TabIndex = 5
        '
        'CUsernameInput
        '
        Me.CreateAccountTbl.SetColumnSpan(Me.CUsernameInput, 2)
        Me.CUsernameInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CUsernameInput.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.CUsernameInput.Location = New System.Drawing.Point(6, 25)
        Me.CUsernameInput.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.CUsernameInput.MaxLength = 40
        Me.CUsernameInput.Name = "CUsernameInput"
        Me.CUsernameInput.Size = New System.Drawing.Size(772, 45)
        Me.CUsernameInput.TabIndex = 3
        '
        'CUsernameLbl
        '
        Me.CUsernameLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CUsernameLbl.AutoSize = True
        Me.CreateAccountTbl.SetColumnSpan(Me.CUsernameLbl, 2)
        Me.CUsernameLbl.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CUsernameLbl.Location = New System.Drawing.Point(3, 3)
        Me.CUsernameLbl.Margin = New System.Windows.Forms.Padding(0)
        Me.CUsernameLbl.Name = "CUsernameLbl"
        Me.CUsernameLbl.Size = New System.Drawing.Size(103, 22)
        Me.CUsernameLbl.TabIndex = 2
        Me.CUsernameLbl.Text = "Username:"
        Me.CUsernameLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'CValidLbl
        '
        Me.CValidLbl.AutoSize = True
        Me.CreateAccountTbl.SetColumnSpan(Me.CValidLbl, 2)
        Me.CValidLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CValidLbl.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CValidLbl.ForeColor = System.Drawing.Color.Firebrick
        Me.CValidLbl.Location = New System.Drawing.Point(6, 244)
        Me.CValidLbl.Name = "CValidLbl"
        Me.CValidLbl.Size = New System.Drawing.Size(772, 22)
        Me.CValidLbl.TabIndex = 14
        Me.CValidLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CShowBtn2
        '
        Me.CShowBtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CShowBtn2.Dock = System.Windows.Forms.DockStyle.Right
        Me.CShowBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CShowBtn2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.CShowBtn2.ImageIndex = 0
        Me.CShowBtn2.ImageList = Me.VisibilityIcons
        Me.CShowBtn2.Location = New System.Drawing.Point(356, 229)
        Me.CShowBtn2.Margin = New System.Windows.Forms.Padding(6)
        Me.CShowBtn2.Name = "CShowBtn2"
        Me.CShowBtn2.Size = New System.Drawing.Size(30, 9)
        Me.CShowBtn2.TabIndex = 2
        Me.CShowBtn2.UseVisualStyleBackColor = True
        '
        'CreateAccountBtn
        '
        Me.CreateAccountBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CreateAccountTbl.SetColumnSpan(Me.CreateAccountBtn, 2)
        Me.CreateAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateAccountBtn.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.CreateAccountBtn.Location = New System.Drawing.Point(208, 171)
        Me.CreateAccountBtn.Name = "CreateAccountBtn"
        Me.CreateAccountBtn.Size = New System.Drawing.Size(367, 49)
        Me.CreateAccountBtn.TabIndex = 12
        Me.CreateAccountBtn.Text = "CREATE ACCOUNT"
        Me.CreateAccountBtn.UseVisualStyleBackColor = True
        '
        'T_CreateAccount
        '
        Me.AcceptButton = Me.LoginBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 466)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.MinimumSize = New System.Drawing.Size(900, 500)
        Me.Name = "T_CreateAccount"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Your Account"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.tabControl.ResumeLayout(False)
        Me.LoginTitle.ResumeLayout(False)
        Me.LoginTbl.ResumeLayout(False)
        Me.LoginTbl.PerformLayout()
        Me.CreateAccountTitle.ResumeLayout(False)
        Me.CreateAccountTbl.ResumeLayout(False)
        Me.CreateAccountTbl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TitleLbl As Label
    Friend WithEvents tabControl As TabControl
    Friend WithEvents LoginTitle As TabPage
    Friend WithEvents LoginTbl As TableLayoutPanel
    Friend WithEvents PasswordInput As TextBox
    Friend WithEvents PasswordLbl As Label
    Friend WithEvents LoginBtn As Button
    Friend WithEvents UsernameLbl As Label
    Friend WithEvents UsernameInput As TextBox
    Friend WithEvents CreateAccountTitle As TabPage
    Friend WithEvents CreateAccountTbl As TableLayoutPanel
    Friend WithEvents CPasswordInput2 As TextBox
    Friend WithEvents CPasswordInput As TextBox
    Friend WithEvents CUsernameInput As TextBox
    Friend WithEvents CUsernameLbl As Label
    Friend WithEvents RepeatPasswordLbl As Label
    Friend WithEvents CPasswordLbl As Label
    Friend WithEvents CreateAccountBtn As Button
    Friend WithEvents ShowBtn As Button
    Friend WithEvents CShowBtn2 As Button
    Friend WithEvents CShowBtn As Button
    Friend WithEvents VisibilityIcons As ImageList
    Friend WithEvents CValidLbl As Label
    Friend WithEvents BackBtn As Button
    Friend WithEvents LValidLbl As Label
End Class
