<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class S_Lobby
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(S_Lobby))
        Me.Table = New System.Windows.Forms.TableLayoutPanel()
        Me.LeaveBtn = New System.Windows.Forms.Button()
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.HomeBtn = New System.Windows.Forms.Button()
        Me.displayNameLbl = New System.Windows.Forms.Label()
        Me.changeNameBtn = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Table.SuspendLayout()
        Me.SuspendLayout()
        '
        'Table
        '
        Me.Table.ColumnCount = 3
        Me.Table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.Table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.Table.Controls.Add(Me.LeaveBtn, 0, 0)
        Me.Table.Controls.Add(Me.TitleLbl, 1, 0)
        Me.Table.Controls.Add(Me.HomeBtn, 2, 0)
        Me.Table.Controls.Add(Me.displayNameLbl, 1, 1)
        Me.Table.Controls.Add(Me.changeNameBtn, 1, 2)
        Me.Table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Table.Location = New System.Drawing.Point(10, 11)
        Me.Table.Name = "Table"
        Me.Table.RowCount = 4
        Me.Table.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.Table.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Table.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Table.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.Table.Size = New System.Drawing.Size(858, 422)
        Me.Table.TabIndex = 0
        '
        'LeaveBtn
        '
        Me.LeaveBtn.BackgroundImage = CType(resources.GetObject("LeaveBtn.BackgroundImage"), System.Drawing.Image)
        Me.LeaveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LeaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LeaveBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LeaveBtn.Location = New System.Drawing.Point(0, 0)
        Me.LeaveBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.LeaveBtn.Name = "LeaveBtn"
        Me.LeaveBtn.Size = New System.Drawing.Size(50, 50)
        Me.LeaveBtn.TabIndex = 5
        Me.LeaveBtn.UseVisualStyleBackColor = True
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TitleLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleLbl.Font = New System.Drawing.Font("Segoe UI Light", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLbl.Location = New System.Drawing.Point(63, 0)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(732, 63)
        Me.TitleLbl.TabIndex = 1
        Me.TitleLbl.Text = "LOBBY"
        Me.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HomeBtn
        '
        Me.HomeBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HomeBtn.BackgroundImage = CType(resources.GetObject("HomeBtn.BackgroundImage"), System.Drawing.Image)
        Me.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.HomeBtn.Location = New System.Drawing.Point(808, 0)
        Me.HomeBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(50, 50)
        Me.HomeBtn.TabIndex = 4
        Me.HomeBtn.UseVisualStyleBackColor = True
        '
        'displayNameLbl
        '
        Me.displayNameLbl.AutoSize = True
        Me.displayNameLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.displayNameLbl.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.displayNameLbl.Location = New System.Drawing.Point(70, 74)
        Me.displayNameLbl.Margin = New System.Windows.Forms.Padding(10, 11, 10, 11)
        Me.displayNameLbl.Name = "displayNameLbl"
        Me.displayNameLbl.Size = New System.Drawing.Size(718, 62)
        Me.displayNameLbl.TabIndex = 2
        Me.displayNameLbl.Text = "Your Display Name:"
        Me.displayNameLbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'changeNameBtn
        '
        Me.changeNameBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.changeNameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.changeNameBtn.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.changeNameBtn.Location = New System.Drawing.Point(287, 158)
        Me.changeNameBtn.Margin = New System.Windows.Forms.Padding(10, 11, 10, 11)
        Me.changeNameBtn.Name = "changeNameBtn"
        Me.changeNameBtn.Size = New System.Drawing.Size(283, 62)
        Me.changeNameBtn.TabIndex = 3
        Me.changeNameBtn.Text = "Change Display Name"
        Me.changeNameBtn.UseVisualStyleBackColor = True
        '
        'Timer
        '
        '
        'S_Lobby
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 444)
        Me.Controls.Add(Me.Table)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.MinimumSize = New System.Drawing.Size(900, 500)
        Me.Name = "S_Lobby"
        Me.Padding = New System.Windows.Forms.Padding(10, 11, 10, 11)
        Me.ShowInTaskbar = False
        Me.Text = "Student Lobby"
        Me.Table.ResumeLayout(False)
        Me.Table.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Table As TableLayoutPanel
    Friend WithEvents TitleLbl As Label
    Friend WithEvents displayNameLbl As Label
    Friend WithEvents changeNameBtn As Button
    Friend WithEvents HomeBtn As Button
    Friend WithEvents LeaveBtn As Button
    Friend WithEvents Timer As Timer
End Class
