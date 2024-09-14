<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class T_AccessList
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DescriptionLbl = New System.Windows.Forms.Label()
        Me.UsernameInput = New System.Windows.Forms.TextBox()
        Me.AccessListbox = New System.Windows.Forms.ListBox()
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.UsernameLbl = New System.Windows.Forms.Label()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DescriptionLbl, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.UsernameInput, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.AccessListbox, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TitleLbl, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.UsernameLbl, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.AddBtn, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.SaveBtn, 2, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(458, 551)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'DescriptionLbl
        '
        Me.DescriptionLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.DescriptionLbl, 3)
        Me.DescriptionLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescriptionLbl.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.DescriptionLbl.Location = New System.Drawing.Point(3, 55)
        Me.DescriptionLbl.Name = "DescriptionLbl"
        Me.DescriptionLbl.Size = New System.Drawing.Size(452, 82)
        Me.DescriptionLbl.TabIndex = 6
        Me.DescriptionLbl.Text = "The following users will be able to access your assessment as well as you."
        Me.DescriptionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UsernameInput
        '
        Me.UsernameInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UsernameInput.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.UsernameInput.Location = New System.Drawing.Point(5, 500)
        Me.UsernameInput.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.UsernameInput.Name = "UsernameInput"
        Me.UsernameInput.Size = New System.Drawing.Size(288, 39)
        Me.UsernameInput.TabIndex = 2
        '
        'AccessListbox
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.AccessListbox, 3)
        Me.AccessListbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccessListbox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AccessListbox.FormattingEnabled = True
        Me.AccessListbox.ItemHeight = 32
        Me.AccessListbox.Location = New System.Drawing.Point(10, 148)
        Me.AccessListbox.Margin = New System.Windows.Forms.Padding(10, 11, 10, 11)
        Me.AccessListbox.Name = "AccessListbox"
        Me.AccessListbox.Size = New System.Drawing.Size(438, 308)
        Me.AccessListbox.TabIndex = 1
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.TitleLbl, 3)
        Me.TitleLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleLbl.Font = New System.Drawing.Font("Segoe UI Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLbl.Location = New System.Drawing.Point(3, 0)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(452, 55)
        Me.TitleLbl.TabIndex = 5
        Me.TitleLbl.Text = "CUSTOM ACCESS LIST "
        Me.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UsernameLbl
        '
        Me.UsernameLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UsernameLbl.AutoSize = True
        Me.UsernameLbl.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.UsernameLbl.Location = New System.Drawing.Point(3, 467)
        Me.UsernameLbl.Name = "UsernameLbl"
        Me.UsernameLbl.Size = New System.Drawing.Size(127, 27)
        Me.UsernameLbl.TabIndex = 7
        Me.UsernameLbl.Text = "Username:"
        '
        'AddBtn
        '
        Me.AddBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AddBtn.Location = New System.Drawing.Point(303, 499)
        Me.AddBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(70, 35)
        Me.AddBtn.TabIndex = 4
        Me.AddBtn.Text = "Add User"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'SaveBtn
        '
        Me.SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SaveBtn.Location = New System.Drawing.Point(385, 499)
        Me.SaveBtn.Margin = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(70, 35)
        Me.SaveBtn.TabIndex = 8
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'T_AccessList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 571)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.MinimumSize = New System.Drawing.Size(500, 627)
        Me.Name = "T_AccessList"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Access List"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents AccessListbox As ListBox
    Friend WithEvents UsernameInput As TextBox
    Friend WithEvents AddBtn As Button
    Friend WithEvents DescriptionLbl As Label
    Friend WithEvents TitleLbl As Label
    Friend WithEvents UsernameLbl As Label
    Friend WithEvents SaveBtn As Button
End Class
