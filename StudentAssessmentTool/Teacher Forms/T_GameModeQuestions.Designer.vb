<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class T_GameModeQuestions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(T_GameModeQuestions))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.musicBtn = New System.Windows.Forms.Button()
        Me.soundBtnImages = New System.Windows.Forms.ImageList(Me.components)
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.timerLbl = New System.Windows.Forms.Label()
        Me.nextBtn = New System.Windows.Forms.Button()
        Me.nextBtnImages = New System.Windows.Forms.ImageList(Me.components)
        Me.titleLbl = New System.Windows.Forms.Label()
        Me.submittedAnswersLbl = New System.Windows.Forms.Label()
        Me.partsTab = New System.Windows.Forms.TabControl()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.musicBtn, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BackBtn, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.timerLbl, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.nextBtn, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.titleLbl, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.submittedAnswersLbl, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.partsTab, 0, 1)
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
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'musicBtn
        '
        Me.musicBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.musicBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.musicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.musicBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.musicBtn.ImageIndex = 0
        Me.musicBtn.ImageList = Me.soundBtnImages
        Me.musicBtn.Location = New System.Drawing.Point(808, 0)
        Me.musicBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.musicBtn.Name = "musicBtn"
        Me.musicBtn.Size = New System.Drawing.Size(50, 50)
        Me.musicBtn.TabIndex = 25
        Me.musicBtn.UseVisualStyleBackColor = True
        '
        'soundBtnImages
        '
        Me.soundBtnImages.ImageStream = CType(resources.GetObject("soundBtnImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.soundBtnImages.TransparentColor = System.Drawing.Color.Transparent
        Me.soundBtnImages.Images.SetKeyName(0, "muteBtn.png")
        Me.soundBtnImages.Images.SetKeyName(1, "volumeBtn.png")
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
        Me.BackBtn.TabIndex = 17
        Me.BackBtn.UseVisualStyleBackColor = True
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
        Me.timerLbl.Text = "00:00"
        Me.timerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nextBtn
        '
        Me.nextBtn.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nextBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.nextBtn.ImageIndex = 1
        Me.nextBtn.ImageList = Me.nextBtnImages
        Me.nextBtn.Location = New System.Drawing.Point(801, 364)
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.Size = New System.Drawing.Size(54, 57)
        Me.nextBtn.TabIndex = 18
        Me.nextBtn.UseVisualStyleBackColor = True
        '
        'nextBtnImages
        '
        Me.nextBtnImages.ImageStream = CType(resources.GetObject("nextBtnImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.nextBtnImages.TransparentColor = System.Drawing.Color.Transparent
        Me.nextBtnImages.Images.SetKeyName(0, "ForwardIcon.png")
        Me.nextBtnImages.Images.SetKeyName(1, "SubmitIcon.png")
        '
        'titleLbl
        '
        Me.titleLbl.AutoSize = True
        Me.titleLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.titleLbl.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLbl.Location = New System.Drawing.Point(123, 0)
        Me.titleLbl.Name = "titleLbl"
        Me.titleLbl.Size = New System.Drawing.Size(672, 73)
        Me.titleLbl.TabIndex = 22
        Me.titleLbl.Text = "Question 1/10 (topic)"
        Me.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'submittedAnswersLbl
        '
        Me.submittedAnswersLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.submittedAnswersLbl.AutoSize = True
        Me.submittedAnswersLbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submittedAnswersLbl.Location = New System.Drawing.Point(321, 376)
        Me.submittedAnswersLbl.Name = "submittedAnswersLbl"
        Me.submittedAnswersLbl.Size = New System.Drawing.Size(275, 32)
        Me.submittedAnswersLbl.TabIndex = 23
        Me.submittedAnswersLbl.Text = "0/15 Answers Submitted"
        '
        'partsTab
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.partsTab, 3)
        Me.partsTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.partsTab.Location = New System.Drawing.Point(3, 76)
        Me.partsTab.Name = "partsTab"
        Me.partsTab.SelectedIndex = 0
        Me.partsTab.Size = New System.Drawing.Size(852, 282)
        Me.partsTab.TabIndex = 24
        '
        'Timer
        '
        '
        'T_GameModeQuestions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 444)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(900, 500)
        Me.Name = "T_GameModeQuestions"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Game Mode"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BackBtn As Button
    Friend WithEvents timerLbl As Label
    Friend WithEvents nextBtn As Button
    Friend WithEvents titleLbl As Label
    Friend WithEvents partsTab As TabControl
    Friend WithEvents Timer As Timer
    Friend WithEvents nextBtnImages As ImageList
    Friend WithEvents submittedAnswersLbl As Label
    Friend WithEvents musicBtn As Button
    Friend WithEvents soundBtnImages As ImageList
End Class
