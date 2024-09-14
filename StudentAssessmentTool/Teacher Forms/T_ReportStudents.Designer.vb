<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class T_ReportStudents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(T_ReportStudents))
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.hideNamesBtn = New System.Windows.Forms.Button()
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.StudentsListbox = New System.Windows.Forms.ListBox()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.resultsLbl = New System.Windows.Forms.Label()
        Me.showByBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 4
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel.Controls.Add(Me.hideNamesBtn, 0, 3)
        Me.TableLayoutPanel.Controls.Add(Me.TitleLbl, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.StudentsListbox, 0, 2)
        Me.TableLayoutPanel.Controls.Add(Me.BackBtn, 3, 0)
        Me.TableLayoutPanel.Controls.Add(Me.resultsLbl, 0, 1)
        Me.TableLayoutPanel.Controls.Add(Me.showByBtn, 2, 3)
        Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel.MinimumSize = New System.Drawing.Size(858, 424)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 4
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel.Size = New System.Drawing.Size(858, 424)
        Me.TableLayoutPanel.TabIndex = 2
        '
        'hideNamesBtn
        '
        Me.hideNamesBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel.SetColumnSpan(Me.hideNamesBtn, 2)
        Me.hideNamesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hideNamesBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.hideNamesBtn.Location = New System.Drawing.Point(3, 366)
        Me.hideNamesBtn.Name = "hideNamesBtn"
        Me.hideNamesBtn.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.hideNamesBtn.Size = New System.Drawing.Size(135, 55)
        Me.hideNamesBtn.TabIndex = 17
        Me.hideNamesBtn.Text = "Hide Names"
        Me.hideNamesBtn.UseVisualStyleBackColor = True
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TableLayoutPanel.SetColumnSpan(Me.TitleLbl, 2)
        Me.TitleLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleLbl.Font = New System.Drawing.Font("Segoe UI Light", 22.0!)
        Me.TitleLbl.Location = New System.Drawing.Point(62, 3)
        Me.TitleLbl.Margin = New System.Windows.Forms.Padding(3)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(733, 54)
        Me.TitleLbl.TabIndex = 2
        Me.TitleLbl.Text = "Report Name"
        Me.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StudentsListbox
        '
        Me.TableLayoutPanel.SetColumnSpan(Me.StudentsListbox, 4)
        Me.StudentsListbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StudentsListbox.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.StudentsListbox.FormattingEnabled = True
        Me.StudentsListbox.ItemHeight = 45
        Me.StudentsListbox.Items.AddRange(New Object() {"Student1"})
        Me.StudentsListbox.Location = New System.Drawing.Point(0, 90)
        Me.StudentsListbox.Margin = New System.Windows.Forms.Padding(0)
        Me.StudentsListbox.Name = "StudentsListbox"
        Me.StudentsListbox.Size = New System.Drawing.Size(858, 273)
        Me.StudentsListbox.TabIndex = 8
        '
        'BackBtn
        '
        Me.BackBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BackBtn.BackColor = System.Drawing.Color.Transparent
        Me.BackBtn.BackgroundImage = CType(resources.GetObject("BackBtn.BackgroundImage"), System.Drawing.Image)
        Me.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.BackBtn.Location = New System.Drawing.Point(808, 0)
        Me.BackBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(50, 50)
        Me.BackBtn.TabIndex = 3
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'resultsLbl
        '
        Me.resultsLbl.AutoSize = True
        Me.TableLayoutPanel.SetColumnSpan(Me.resultsLbl, 4)
        Me.resultsLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.resultsLbl.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.resultsLbl.Location = New System.Drawing.Point(2, 62)
        Me.resultsLbl.Margin = New System.Windows.Forms.Padding(2)
        Me.resultsLbl.Name = "resultsLbl"
        Me.resultsLbl.Size = New System.Drawing.Size(854, 26)
        Me.resultsLbl.TabIndex = 14
        Me.resultsLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'showByBtn
        '
        Me.showByBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel.SetColumnSpan(Me.showByBtn, 2)
        Me.showByBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.showByBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.showByBtn.Location = New System.Drawing.Point(667, 366)
        Me.showByBtn.Name = "showByBtn"
        Me.showByBtn.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.showByBtn.Size = New System.Drawing.Size(188, 55)
        Me.showByBtn.TabIndex = 19
        Me.showByBtn.Text = "Show by Question"
        Me.showByBtn.UseVisualStyleBackColor = True
        '
        'T_ReportStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 444)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.MinimumSize = New System.Drawing.Size(900, 500)
        Me.Name = "T_ReportStudents"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Students"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel As TableLayoutPanel
    Friend WithEvents TitleLbl As Label
    Friend WithEvents StudentsListbox As ListBox
    Friend WithEvents BackBtn As Button
    Friend WithEvents resultsLbl As Label
    Friend WithEvents hideNamesBtn As Button
    Friend WithEvents showByBtn As Button
End Class
