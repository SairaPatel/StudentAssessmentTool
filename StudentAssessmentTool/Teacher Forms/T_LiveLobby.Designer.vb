<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class T_LiveLobby
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(T_LiveLobby))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.musicBtn = New System.Windows.Forms.Button()
        Me.soundBtnImages = New System.Windows.Forms.ImageList(Me.components)
        Me.EditNameBtn = New System.Windows.Forms.Button()
        Me.ParticipantsListbox = New System.Windows.Forms.ListBox()
        Me.StartBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.LiveNameLbl = New System.Windows.Forms.Label()
        Me.ParticipantsLbl = New System.Windows.Forms.Label()
        Me.IDLbl = New System.Windows.Forms.TextBox()
        Me.studentStatusLbl = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.musicBtn, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.EditNameBtn, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ParticipantsListbox, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.StartBtn, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.DeleteBtn, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.BackBtn, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LiveNameLbl, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ParticipantsLbl, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.IDLbl, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.studentStatusLbl, 2, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(864, 446)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'musicBtn
        '
        Me.musicBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.musicBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.musicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.musicBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.musicBtn.ImageIndex = 0
        Me.musicBtn.ImageList = Me.soundBtnImages
        Me.musicBtn.Location = New System.Drawing.Point(814, 0)
        Me.musicBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.musicBtn.Name = "musicBtn"
        Me.musicBtn.Size = New System.Drawing.Size(50, 50)
        Me.musicBtn.TabIndex = 26
        Me.musicBtn.UseVisualStyleBackColor = True
        '
        'soundBtnImages
        '
        Me.soundBtnImages.ImageStream = CType(resources.GetObject("soundBtnImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.soundBtnImages.TransparentColor = System.Drawing.Color.Transparent
        Me.soundBtnImages.Images.SetKeyName(0, "muteBtn.png")
        Me.soundBtnImages.Images.SetKeyName(1, "volumeBtn.png")
        '
        'EditNameBtn
        '
        Me.EditNameBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditNameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditNameBtn.Location = New System.Drawing.Point(655, 388)
        Me.EditNameBtn.Margin = New System.Windows.Forms.Padding(3, 3, 6, 3)
        Me.EditNameBtn.Name = "EditNameBtn"
        Me.TableLayoutPanel1.SetRowSpan(Me.EditNameBtn, 2)
        Me.EditNameBtn.Size = New System.Drawing.Size(139, 55)
        Me.EditNameBtn.TabIndex = 0
        Me.EditNameBtn.Text = "Edit Participant Button"
        Me.EditNameBtn.UseVisualStyleBackColor = True
        Me.EditNameBtn.Visible = False
        '
        'ParticipantsListbox
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.ParticipantsListbox, 5)
        Me.ParticipantsListbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ParticipantsListbox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ParticipantsListbox.FormattingEnabled = True
        Me.ParticipantsListbox.ItemHeight = 32
        Me.ParticipantsListbox.Location = New System.Drawing.Point(3, 113)
        Me.ParticipantsListbox.Name = "ParticipantsListbox"
        Me.ParticipantsListbox.Size = New System.Drawing.Size(858, 244)
        Me.ParticipantsListbox.TabIndex = 4
        '
        'StartBtn
        '
        Me.StartBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.StartBtn.Location = New System.Drawing.Point(310, 363)
        Me.StartBtn.Name = "StartBtn"
        Me.StartBtn.Size = New System.Drawing.Size(240, 50)
        Me.StartBtn.TabIndex = 6
        Me.StartBtn.Text = "Start Live Assessment"
        Me.StartBtn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteBtn.BackgroundImage = CType(resources.GetObject("DeleteBtn.BackgroundImage"), System.Drawing.Image)
        Me.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBtn.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.Location = New System.Drawing.Point(806, 388)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.TableLayoutPanel1.SetRowSpan(Me.DeleteBtn, 2)
        Me.DeleteBtn.Size = New System.Drawing.Size(55, 55)
        Me.DeleteBtn.TabIndex = 7
        Me.DeleteBtn.UseVisualStyleBackColor = True
        Me.DeleteBtn.Visible = False
        '
        'BackBtn
        '
        Me.BackBtn.BackgroundImage = CType(resources.GetObject("BackBtn.BackgroundImage"), System.Drawing.Image)
        Me.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.Location = New System.Drawing.Point(0, 0)
        Me.BackBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(50, 50)
        Me.BackBtn.TabIndex = 3
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'LiveNameLbl
        '
        Me.LiveNameLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.LiveNameLbl, 3)
        Me.LiveNameLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LiveNameLbl.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LiveNameLbl.Location = New System.Drawing.Point(63, 0)
        Me.LiveNameLbl.Name = "LiveNameLbl"
        Me.LiveNameLbl.Size = New System.Drawing.Size(734, 60)
        Me.LiveNameLbl.TabIndex = 8
        Me.LiveNameLbl.Text = "Live Assessment Name"
        Me.LiveNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ParticipantsLbl
        '
        Me.ParticipantsLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ParticipantsLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.ParticipantsLbl, 2)
        Me.ParticipantsLbl.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParticipantsLbl.Location = New System.Drawing.Point(3, 82)
        Me.ParticipantsLbl.Name = "ParticipantsLbl"
        Me.ParticipantsLbl.Size = New System.Drawing.Size(109, 28)
        Me.ParticipantsLbl.TabIndex = 11
        Me.ParticipantsLbl.Text = "0 Students"
        Me.ParticipantsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IDLbl
        '
        Me.IDLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IDLbl.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.IDLbl.Location = New System.Drawing.Point(280, 63)
        Me.IDLbl.Name = "IDLbl"
        Me.IDLbl.ReadOnly = True
        Me.IDLbl.Size = New System.Drawing.Size(300, 50)
        Me.IDLbl.TabIndex = 12
        Me.IDLbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'studentStatusLbl
        '
        Me.studentStatusLbl.AutoSize = True
        Me.studentStatusLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.studentStatusLbl.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.studentStatusLbl.Location = New System.Drawing.Point(211, 416)
        Me.studentStatusLbl.Name = "studentStatusLbl"
        Me.studentStatusLbl.Size = New System.Drawing.Size(438, 30)
        Me.studentStatusLbl.TabIndex = 13
        Me.studentStatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer
        '
        '
        'T_LiveLobby
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 466)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(900, 500)
        Me.Name = "T_LiveLobby"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Live Lobby"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BackBtn As Button
    Friend WithEvents EditNameBtn As Button
    Friend WithEvents ParticipantsListbox As ListBox
    Friend WithEvents StartBtn As Button
    Friend WithEvents LiveNameLbl As Label
    Friend WithEvents ParticipantsLbl As Label
    Friend WithEvents IDLbl As TextBox
    Friend WithEvents studentStatusLbl As Label
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents musicBtn As Button
    Friend WithEvents soundBtnImages As ImageList
End Class
