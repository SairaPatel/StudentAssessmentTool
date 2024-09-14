<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class T_CreateQuestionParts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(T_CreateQuestionParts))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.partsTab = New System.Windows.Forms.TabControl()
        Me.titleLbl = New System.Windows.Forms.Label()
        Me.TimeCheckbox = New System.Windows.Forms.CheckBox()
        Me.TimeChooser = New System.Windows.Forms.NumericUpDown()
        Me.CategoryLbl = New System.Windows.Forms.Label()
        Me.categoryCombo = New System.Windows.Forms.ComboBox()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.NewPartMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.PartTypeCombo = New System.Windows.Forms.ToolStripComboBox()
        Me.AddPartBtn = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TimeChooser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NewPartMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BackBtn, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.partsTab, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.titleLbl, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TimeCheckbox, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TimeChooser, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.CategoryLbl, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.categoryCombo, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.SaveBtn, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.NewPartMenuStrip, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DeleteBtn, 4, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(858, 424)
        Me.TableLayoutPanel1.TabIndex = 0
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
        'partsTab
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.partsTab, 13)
        Me.partsTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.partsTab.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.partsTab.Location = New System.Drawing.Point(0, 70)
        Me.partsTab.Margin = New System.Windows.Forms.Padding(0)
        Me.partsTab.Name = "partsTab"
        Me.partsTab.SelectedIndex = 0
        Me.partsTab.Size = New System.Drawing.Size(858, 284)
        Me.partsTab.TabIndex = 0
        '
        'titleLbl
        '
        Me.titleLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.titleLbl, 3)
        Me.titleLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.titleLbl.Font = New System.Drawing.Font("Segoe UI", 26.0!)
        Me.titleLbl.Location = New System.Drawing.Point(223, 3)
        Me.titleLbl.Margin = New System.Windows.Forms.Padding(3)
        Me.titleLbl.Name = "titleLbl"
        Me.titleLbl.Size = New System.Drawing.Size(412, 64)
        Me.titleLbl.TabIndex = 1
        Me.titleLbl.Text = "Question 1"
        Me.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimeCheckbox
        '
        Me.TimeCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TimeCheckbox.AutoSize = True
        Me.TimeCheckbox.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.TimeCheckbox.Location = New System.Drawing.Point(13, 357)
        Me.TimeCheckbox.Name = "TimeCheckbox"
        Me.TimeCheckbox.Size = New System.Drawing.Size(193, 27)
        Me.TimeCheckbox.TabIndex = 21
        Me.TimeCheckbox.Text = "Time Limit (Seconds)"
        Me.TimeCheckbox.UseVisualStyleBackColor = True
        '
        'TimeChooser
        '
        Me.TimeChooser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TimeChooser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TimeChooser.Location = New System.Drawing.Point(50, 390)
        Me.TimeChooser.Maximum = New Decimal(New Integer() {720, 0, 0, 0})
        Me.TimeChooser.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.TimeChooser.Name = "TimeChooser"
        Me.TimeChooser.Size = New System.Drawing.Size(120, 31)
        Me.TimeChooser.TabIndex = 20
        Me.TimeChooser.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'CategoryLbl
        '
        Me.CategoryLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CategoryLbl.AutoSize = True
        Me.CategoryLbl.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CategoryLbl.Location = New System.Drawing.Point(264, 356)
        Me.CategoryLbl.Name = "CategoryLbl"
        Me.CategoryLbl.Size = New System.Drawing.Size(62, 28)
        Me.CategoryLbl.TabIndex = 22
        Me.CategoryLbl.Text = "Topic:"
        '
        'categoryCombo
        '
        Me.categoryCombo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.categoryCombo.FormattingEnabled = True
        Me.categoryCombo.Location = New System.Drawing.Point(223, 391)
        Me.categoryCombo.Name = "categoryCombo"
        Me.categoryCombo.Size = New System.Drawing.Size(144, 29)
        Me.categoryCombo.TabIndex = 25
        '
        'SaveBtn
        '
        Me.SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Location = New System.Drawing.Point(393, 361)
        Me.SaveBtn.Name = "SaveBtn"
        Me.TableLayoutPanel1.SetRowSpan(Me.SaveBtn, 2)
        Me.SaveBtn.Size = New System.Drawing.Size(121, 55)
        Me.SaveBtn.TabIndex = 18
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'NewPartMenuStrip
        '
        Me.NewPartMenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.NewPartMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.NewPartMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PartTypeCombo, Me.AddPartBtn})
        Me.NewPartMenuStrip.Location = New System.Drawing.Point(638, 0)
        Me.NewPartMenuStrip.Name = "NewPartMenuStrip"
        Me.NewPartMenuStrip.Size = New System.Drawing.Size(220, 37)
        Me.NewPartMenuStrip.TabIndex = 27
        Me.NewPartMenuStrip.Text = "Create Part"
        '
        'PartTypeCombo
        '
        Me.PartTypeCombo.Items.AddRange(New Object() {"Short Text", "Long Text", "Numerical", "Multiple Choice", "Multiple Answer", "Rank Order"})
        Me.PartTypeCombo.Name = "PartTypeCombo"
        Me.PartTypeCombo.Size = New System.Drawing.Size(121, 33)
        '
        'AddPartBtn
        '
        Me.AddPartBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AddPartBtn.Name = "AddPartBtn"
        Me.AddPartBtn.Size = New System.Drawing.Size(62, 33)
        Me.AddPartBtn.Text = "Add"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.DeleteBtn.BackgroundImage = CType(resources.GetObject("DeleteBtn.BackgroundImage"), System.Drawing.Image)
        Me.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBtn.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.Location = New System.Drawing.Point(803, 363)
        Me.DeleteBtn.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.TableLayoutPanel1.SetRowSpan(Me.DeleteBtn, 2)
        Me.DeleteBtn.Size = New System.Drawing.Size(52, 52)
        Me.DeleteBtn.TabIndex = 28
        Me.DeleteBtn.UseVisualStyleBackColor = True
        Me.DeleteBtn.Visible = False
        '
        'T_CreateQuestionParts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 444)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.NewPartMenuStrip
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(900, 500)
        Me.Name = "T_CreateQuestionParts"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Question Properties"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.TimeChooser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NewPartMenuStrip.ResumeLayout(False)
        Me.NewPartMenuStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents titleLbl As Label
    Friend WithEvents BackBtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents partsTab As TabControl
    Friend WithEvents TimeChooser As NumericUpDown
    Friend WithEvents TimeCheckbox As CheckBox
    Friend WithEvents CategoryLbl As Label
    Friend WithEvents categoryCombo As ComboBox
    Friend WithEvents NewPartMenuStrip As MenuStrip
    Friend WithEvents PartTypeCombo As ToolStripComboBox
    Friend WithEvents AddPartBtn As ToolStripMenuItem
    Friend WithEvents DeleteBtn As Button
End Class
