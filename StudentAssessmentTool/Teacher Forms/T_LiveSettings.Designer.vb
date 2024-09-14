<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class T_LiveSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(T_LiveSettings))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.NameLbl = New System.Windows.Forms.Label()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.ModeCombo = New System.Windows.Forms.ComboBox()
        Me.NameInput = New System.Windows.Forms.TextBox()
        Me.RandomCheckbox = New System.Windows.Forms.CheckBox()
        Me.TimerCheckbox = New System.Windows.Forms.CheckBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.minutesLbl = New System.Windows.Forms.Label()
        Me.TimerPicker = New System.Windows.Forms.NumericUpDown()
        Me.NextBtn = New System.Windows.Forms.Button()
        Me.DisplayCheckbox = New System.Windows.Forms.CheckBox()
        Me.MusicCheckbox = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.TimerPicker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.NameLbl, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BackBtn, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TitleLbl, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ModeCombo, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.NameInput, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.RandomCheckbox, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TimerCheckbox, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.SplitContainer1, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.NextBtn, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.DisplayCheckbox, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.MusicCheckbox, 3, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(858, 424)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'NameLbl
        '
        Me.NameLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.NameLbl, 4)
        Me.NameLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NameLbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLbl.Location = New System.Drawing.Point(63, 60)
        Me.NameLbl.Name = "NameLbl"
        Me.NameLbl.Size = New System.Drawing.Size(730, 40)
        Me.NameLbl.TabIndex = 6
        Me.NameLbl.Text = "Session/Class Name:"
        Me.NameLbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.Color.Transparent
        Me.BackBtn.BackgroundImage = CType(resources.GetObject("BackBtn.BackgroundImage"), System.Drawing.Image)
        Me.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.BackBtn.Location = New System.Drawing.Point(0, 0)
        Me.BackBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(50, 50)
        Me.BackBtn.TabIndex = 4
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.TitleLbl, 4)
        Me.TitleLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleLbl.Font = New System.Drawing.Font("Segoe UI Light", 26.0!)
        Me.TitleLbl.Location = New System.Drawing.Point(63, 0)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(730, 60)
        Me.TitleLbl.TabIndex = 0
        Me.TitleLbl.Text = "LIVE ASSESSMENT SETUP"
        Me.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ModeCombo
        '
        Me.ModeCombo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel1.SetColumnSpan(Me.ModeCombo, 2)
        Me.ModeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ModeCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModeCombo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ModeCombo.FormattingEnabled = True
        Me.ModeCombo.Items.AddRange(New Object() {"Game Mode", "Test Mode"})
        Me.ModeCombo.Location = New System.Drawing.Point(258, 200)
        Me.ModeCombo.Name = "ModeCombo"
        Me.ModeCombo.Size = New System.Drawing.Size(340, 40)
        Me.ModeCombo.TabIndex = 8
        '
        'NameInput
        '
        Me.NameInput.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TableLayoutPanel1.SetColumnSpan(Me.NameInput, 4)
        Me.NameInput.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.NameInput.Location = New System.Drawing.Point(166, 103)
        Me.NameInput.Name = "NameInput"
        Me.NameInput.Size = New System.Drawing.Size(524, 45)
        Me.NameInput.TabIndex = 10
        Me.NameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RandomCheckbox
        '
        Me.RandomCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RandomCheckbox.AutoSize = True
        Me.RandomCheckbox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RandomCheckbox.Location = New System.Drawing.Point(247, 284)
        Me.RandomCheckbox.Name = "RandomCheckbox"
        Me.RandomCheckbox.Size = New System.Drawing.Size(178, 32)
        Me.RandomCheckbox.TabIndex = 12
        Me.RandomCheckbox.Text = "Order questions randomly"
        Me.RandomCheckbox.UseVisualStyleBackColor = True
        '
        'TimerCheckbox
        '
        Me.TimerCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TimerCheckbox.AutoSize = True
        Me.TimerCheckbox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TimerCheckbox.Location = New System.Drawing.Point(71, 284)
        Me.TimerCheckbox.Name = "TimerCheckbox"
        Me.TimerCheckbox.Size = New System.Drawing.Size(161, 32)
        Me.TimerCheckbox.TabIndex = 11
        Me.TimerCheckbox.Text = "Set Time Limit"
        Me.TimerCheckbox.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SplitContainer1.Location = New System.Drawing.Point(63, 347)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.minutesLbl)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TimerPicker)
        Me.SplitContainer1.Size = New System.Drawing.Size(178, 70)
        Me.SplitContainer1.SplitterDistance = 87
        Me.SplitContainer1.TabIndex = 16
        '
        'minutesLbl
        '
        Me.minutesLbl.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.minutesLbl.AutoSize = True
        Me.minutesLbl.Location = New System.Drawing.Point(-27, 0)
        Me.minutesLbl.Name = "minutesLbl"
        Me.minutesLbl.Size = New System.Drawing.Size(160, 21)
        Me.minutesLbl.TabIndex = 15
        Me.minutesLbl.Text = "Time Limit (minutes): "
        Me.minutesLbl.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.minutesLbl.Visible = False
        '
        'TimerPicker
        '
        Me.TimerPicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TimerPicker.Location = New System.Drawing.Point(0, 2)
        Me.TimerPicker.Margin = New System.Windows.Forms.Padding(0)
        Me.TimerPicker.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.TimerPicker.Minimum = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.TimerPicker.Name = "TimerPicker"
        Me.TimerPicker.Size = New System.Drawing.Size(80, 29)
        Me.TimerPicker.TabIndex = 14
        Me.TimerPicker.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TimerPicker.Visible = False
        '
        'NextBtn
        '
        Me.NextBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel1.SetColumnSpan(Me.NextBtn, 2)
        Me.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.NextBtn.Location = New System.Drawing.Point(367, 359)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(122, 46)
        Me.NextBtn.TabIndex = 9
        Me.NextBtn.Text = "Next"
        Me.NextBtn.UseVisualStyleBackColor = True
        '
        'DisplayCheckbox
        '
        Me.DisplayCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DisplayCheckbox.AutoSize = True
        Me.DisplayCheckbox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DisplayCheckbox.Location = New System.Drawing.Point(930, 426)
        Me.DisplayCheckbox.Name = "DisplayCheckbox"
        Me.DisplayCheckbox.Size = New System.Drawing.Size(251, 48)
        Me.DisplayCheckbox.TabIndex = 13
        Me.DisplayCheckbox.Text = "Display Results"
        Me.DisplayCheckbox.UseVisualStyleBackColor = True
        '
        'MusicCheckbox
        '
        Me.MusicCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MusicCheckbox.AutoSize = True
        Me.MusicCheckbox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MusicCheckbox.Location = New System.Drawing.Point(431, 284)
        Me.MusicCheckbox.Name = "MusicCheckbox"
        Me.MusicCheckbox.Size = New System.Drawing.Size(178, 32)
        Me.MusicCheckbox.TabIndex = 17
        Me.MusicCheckbox.Text = "Background Music"
        Me.MusicCheckbox.UseVisualStyleBackColor = True
        '
        'T_LiveSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 444)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(900, 500)
        Me.Name = "T_LiveSettings"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Live Assessment Setup"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.TimerPicker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TitleLbl As Label
    Friend WithEvents BackBtn As Button
    Friend WithEvents NameLbl As Label
    Friend WithEvents ModeCombo As ComboBox
    Friend WithEvents NextBtn As Button
    Friend WithEvents NameInput As TextBox
    Friend WithEvents TimerCheckbox As CheckBox
    Friend WithEvents RandomCheckbox As CheckBox
    Friend WithEvents DisplayCheckbox As CheckBox
    Friend WithEvents TimerPicker As NumericUpDown
    Friend WithEvents minutesLbl As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents MusicCheckbox As CheckBox
End Class
