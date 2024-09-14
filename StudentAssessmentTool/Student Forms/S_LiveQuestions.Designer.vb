<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class S_LiveQuestions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(S_LiveQuestions))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.statusLbl = New System.Windows.Forms.Label()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.partsTab = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.titleLbl = New System.Windows.Forms.Label()
        Me.previousBtn = New System.Windows.Forms.Button()
        Me.NavQsImgList = New System.Windows.Forms.ImageList(Me.components)
        Me.timerLbl = New System.Windows.Forms.Label()
        Me.nextBtn = New System.Windows.Forms.Button()
        Me.UpDownImgList = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.partsTab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.statusLbl, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BackBtn, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.partsTab, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.titleLbl, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.previousBtn, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.timerLbl, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.nextBtn, 4, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(858, 424)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'statusLbl
        '
        Me.statusLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.statusLbl, 2)
        Me.statusLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.statusLbl.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusLbl.Location = New System.Drawing.Point(123, 361)
        Me.statusLbl.Name = "statusLbl"
        Me.statusLbl.Size = New System.Drawing.Size(612, 63)
        Me.statusLbl.TabIndex = 1
        Me.statusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackBtn
        '
        Me.BackBtn.BackgroundImage = Global.StudentAssessmentTool.My.Resources.Resources.LeaveIcon
        Me.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BackBtn.Location = New System.Drawing.Point(0, 0)
        Me.BackBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(50, 50)
        Me.BackBtn.TabIndex = 17
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'partsTab
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.partsTab, 5)
        Me.partsTab.Controls.Add(Me.TabPage1)
        Me.partsTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.partsTab.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.partsTab.Location = New System.Drawing.Point(0, 73)
        Me.partsTab.Margin = New System.Windows.Forms.Padding(0)
        Me.partsTab.Name = "partsTab"
        Me.partsTab.SelectedIndex = 0
        Me.partsTab.Size = New System.Drawing.Size(858, 288)
        Me.partsTab.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 41)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(850, 243)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.42616!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.57384!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(844, 237)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'titleLbl
        '
        Me.titleLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.titleLbl, 2)
        Me.titleLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.titleLbl.Font = New System.Drawing.Font("Segoe UI", 26.0!)
        Me.titleLbl.Location = New System.Drawing.Point(123, 3)
        Me.titleLbl.Margin = New System.Windows.Forms.Padding(3)
        Me.titleLbl.Name = "titleLbl"
        Me.titleLbl.Size = New System.Drawing.Size(612, 67)
        Me.titleLbl.TabIndex = 1
        Me.titleLbl.Text = "Question 1"
        Me.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'previousBtn
        '
        Me.previousBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.previousBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.previousBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.previousBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.previousBtn.ImageIndex = 0
        Me.previousBtn.ImageList = Me.NavQsImgList
        Me.previousBtn.Location = New System.Drawing.Point(741, 364)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(54, 57)
        Me.previousBtn.TabIndex = 19
        Me.previousBtn.UseVisualStyleBackColor = True
        '
        'NavQsImgList
        '
        Me.NavQsImgList.ImageStream = CType(resources.GetObject("NavQsImgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.NavQsImgList.TransparentColor = System.Drawing.Color.Transparent
        Me.NavQsImgList.Images.SetKeyName(0, "BackIcon.png")
        Me.NavQsImgList.Images.SetKeyName(1, "ForwardIcon.png")
        Me.NavQsImgList.Images.SetKeyName(2, "SubmitIcon.png")
        '
        'timerLbl
        '
        Me.timerLbl.AutoSize = True
        Me.timerLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.timerLbl.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.timerLbl.Location = New System.Drawing.Point(3, 361)
        Me.timerLbl.Name = "timerLbl"
        Me.timerLbl.Size = New System.Drawing.Size(114, 63)
        Me.timerLbl.TabIndex = 20
        Me.timerLbl.Text = "00:00:00"
        Me.timerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nextBtn
        '
        Me.nextBtn.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nextBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.nextBtn.ImageIndex = 1
        Me.nextBtn.ImageList = Me.NavQsImgList
        Me.nextBtn.Location = New System.Drawing.Point(801, 364)
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.Size = New System.Drawing.Size(54, 57)
        Me.nextBtn.TabIndex = 18
        Me.nextBtn.UseVisualStyleBackColor = True
        '
        'UpDownImgList
        '
        Me.UpDownImgList.ImageStream = CType(resources.GetObject("UpDownImgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.UpDownImgList.TransparentColor = System.Drawing.Color.Transparent
        Me.UpDownImgList.Images.SetKeyName(0, "DownIcon.png")
        Me.UpDownImgList.Images.SetKeyName(1, "UpIcon.png")
        '
        'Timer
        '
        '
        'S_LiveQuestions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 444)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.MinimumSize = New System.Drawing.Size(900, 500)
        Me.Name = "S_LiveQuestions"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Student Live"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.partsTab.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents partsTab As TabControl
    Friend WithEvents titleLbl As Label
    Friend WithEvents nextBtn As Button
    Friend WithEvents previousBtn As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents UpDownImgList As ImageList
    Friend WithEvents timerLbl As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents NavQsImgList As ImageList
    Friend WithEvents statusLbl As Label
    Friend WithEvents BackBtn As Button
End Class
