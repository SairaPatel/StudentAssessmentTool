<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class T_Results
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(T_Results))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.saveReportBtn = New System.Windows.Forms.Button()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.titleLbl = New System.Windows.Forms.Label()
        Me.leaderboardListbox = New System.Windows.Forms.ListBox()
        Me.averageLbl = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.saveReportBtn, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.BackBtn, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.titleLbl, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.leaderboardListbox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.averageLbl, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(569, 280)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'saveReportBtn
        '
        Me.saveReportBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.saveReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveReportBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.saveReportBtn.Location = New System.Drawing.Point(196, 241)
        Me.saveReportBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.saveReportBtn.Name = "saveReportBtn"
        Me.saveReportBtn.Size = New System.Drawing.Size(177, 37)
        Me.saveReportBtn.TabIndex = 19
        Me.saveReportBtn.Text = "Save Game Report"
        Me.saveReportBtn.UseVisualStyleBackColor = True
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
        Me.BackBtn.Size = New System.Drawing.Size(40, 39)
        Me.BackBtn.TabIndex = 17
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'titleLbl
        '
        Me.titleLbl.AutoSize = True
        Me.titleLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.titleLbl.Font = New System.Drawing.Font("Segoe UI", 26.0!)
        Me.titleLbl.Location = New System.Drawing.Point(42, 2)
        Me.titleLbl.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.titleLbl.Name = "titleLbl"
        Me.titleLbl.Size = New System.Drawing.Size(485, 43)
        Me.titleLbl.TabIndex = 1
        Me.titleLbl.Text = "Results"
        Me.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'leaderboardListbox
        '
        Me.leaderboardListbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.leaderboardListbox.FormattingEnabled = True
        Me.leaderboardListbox.Location = New System.Drawing.Point(42, 66)
        Me.leaderboardListbox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.leaderboardListbox.Name = "leaderboardListbox"
        Me.leaderboardListbox.Size = New System.Drawing.Size(485, 171)
        Me.leaderboardListbox.TabIndex = 18
        '
        'averageLbl
        '
        Me.averageLbl.AutoSize = True
        Me.averageLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.averageLbl.Location = New System.Drawing.Point(42, 49)
        Me.averageLbl.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.averageLbl.Name = "averageLbl"
        Me.averageLbl.Size = New System.Drawing.Size(485, 13)
        Me.averageLbl.TabIndex = 20
        Me.averageLbl.Text = "Average Mark: "
        Me.averageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'T_Results
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 300)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(605, 339)
        Me.Name = "T_Results"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Results"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BackBtn As Button
    Friend WithEvents titleLbl As Label
    Friend WithEvents leaderboardListbox As ListBox
    Friend WithEvents saveReportBtn As Button
    Friend WithEvents averageLbl As Label
End Class
