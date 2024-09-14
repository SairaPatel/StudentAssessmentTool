<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class T_AssessmentProperties
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(T_AssessmentProperties))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.NameLbl = New System.Windows.Forms.Label()
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.NameInput = New System.Windows.Forms.TextBox()
        Me.IDLbl = New System.Windows.Forms.Label()
        Me.AccessCombo = New System.Windows.Forms.ComboBox()
        Me.AccessListBtn = New System.Windows.Forms.Button()
        Me.CreateBtn = New System.Windows.Forms.Button()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.AccessLbl = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.NameLbl, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TitleLbl, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NameInput, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.IDLbl, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.AccessCombo, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.AccessListBtn, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.CreateBtn, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.BackBtn, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AccessLbl, 1, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64706!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.5294!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(864, 441)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'NameLbl
        '
        Me.NameLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.NameLbl, 2)
        Me.NameLbl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NameLbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLbl.Location = New System.Drawing.Point(63, 136)
        Me.NameLbl.Margin = New System.Windows.Forms.Padding(3)
        Me.NameLbl.Name = "NameLbl"
        Me.NameLbl.Size = New System.Drawing.Size(738, 32)
        Me.NameLbl.TabIndex = 9
        Me.NameLbl.Text = "Assessment Name:"
        Me.NameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.TitleLbl, 2)
        Me.TitleLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleLbl.Font = New System.Drawing.Font("Segoe UI Light", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLbl.Location = New System.Drawing.Point(63, 3)
        Me.TitleLbl.Margin = New System.Windows.Forms.Padding(3)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(738, 54)
        Me.TitleLbl.TabIndex = 0
        Me.TitleLbl.Text = "ASSESSMENT PROPERTIES"
        Me.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NameInput
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.NameInput, 2)
        Me.NameInput.Dock = System.Windows.Forms.DockStyle.Top
        Me.NameInput.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.NameInput.Location = New System.Drawing.Point(70, 181)
        Me.NameInput.Margin = New System.Windows.Forms.Padding(10)
        Me.NameInput.MaxLength = 100
        Me.NameInput.Name = "NameInput"
        Me.NameInput.Size = New System.Drawing.Size(724, 45)
        Me.NameInput.TabIndex = 1
        Me.NameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IDLbl
        '
        Me.IDLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.IDLbl, 2)
        Me.IDLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IDLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.IDLbl.Location = New System.Drawing.Point(63, 63)
        Me.IDLbl.Margin = New System.Windows.Forms.Padding(3)
        Me.IDLbl.Name = "IDLbl"
        Me.IDLbl.Size = New System.Drawing.Size(738, 61)
        Me.IDLbl.TabIndex = 2
        Me.IDLbl.Text = "Assessment ID: 0001"
        Me.IDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AccessCombo
        '
        Me.AccessCombo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel1.SetColumnSpan(Me.AccessCombo, 2)
        Me.AccessCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AccessCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AccessCombo.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.AccessCombo.FormattingEnabled = True
        Me.AccessCombo.Items.AddRange(New Object() {"Me", "Everyone", "Custom"})
        Me.AccessCombo.Location = New System.Drawing.Point(282, 269)
        Me.AccessCombo.Margin = New System.Windows.Forms.Padding(10)
        Me.AccessCombo.Name = "AccessCombo"
        Me.AccessCombo.Size = New System.Drawing.Size(300, 44)
        Me.AccessCombo.TabIndex = 3
        '
        'AccessListBtn
        '
        Me.AccessListBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TableLayoutPanel1.SetColumnSpan(Me.AccessListBtn, 2)
        Me.AccessListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AccessListBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AccessListBtn.Location = New System.Drawing.Point(339, 306)
        Me.AccessListBtn.Name = "AccessListBtn"
        Me.AccessListBtn.Size = New System.Drawing.Size(185, 36)
        Me.AccessListBtn.TabIndex = 4
        Me.AccessListBtn.Text = "Update Access List"
        Me.AccessListBtn.UseVisualStyleBackColor = True
        Me.AccessListBtn.Visible = False
        '
        'CreateBtn
        '
        Me.CreateBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel1.SetColumnSpan(Me.CreateBtn, 2)
        Me.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateBtn.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.CreateBtn.Location = New System.Drawing.Point(356, 365)
        Me.CreateBtn.Name = "CreateBtn"
        Me.CreateBtn.Size = New System.Drawing.Size(151, 57)
        Me.CreateBtn.TabIndex = 5
        Me.CreateBtn.Text = "Save"
        Me.CreateBtn.UseVisualStyleBackColor = True
        '
        'BackBtn
        '
        Me.BackBtn.BackgroundImage = CType(resources.GetObject("BackBtn.BackgroundImage"), System.Drawing.Image)
        Me.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BackBtn.Location = New System.Drawing.Point(0, 0)
        Me.BackBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(50, 50)
        Me.BackBtn.TabIndex = 7
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'AccessLbl
        '
        Me.AccessLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.AccessLbl, 2)
        Me.AccessLbl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AccessLbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccessLbl.Location = New System.Drawing.Point(63, 224)
        Me.AccessLbl.Margin = New System.Windows.Forms.Padding(3)
        Me.AccessLbl.Name = "AccessLbl"
        Me.AccessLbl.Size = New System.Drawing.Size(738, 32)
        Me.AccessLbl.TabIndex = 8
        Me.AccessLbl.Text = "Who Can Access?"
        Me.AccessLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'T_AssessmentProperties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 461)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Rockwell", 9.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(900, 500)
        Me.Name = "T_AssessmentProperties"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Assessment Properties"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TitleLbl As Label
    Friend WithEvents NameInput As TextBox
    Friend WithEvents IDLbl As Label
    Friend WithEvents AccessCombo As ComboBox
    Friend WithEvents AccessListBtn As Button
    Friend WithEvents CreateBtn As Button
    Friend WithEvents AccessLbl As Label
    Friend WithEvents NameLbl As Label
    Friend WithEvents BackBtn As Button
End Class
