<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class T_ViewReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(T_ViewReport))
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.hideNameBtn = New System.Windows.Forms.Button()
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.mainTab = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.scrollPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.summaryTable = New System.Windows.Forms.TableLayoutPanel()
        Me.CategoriesLbl = New System.Windows.Forms.Label()
        Me.categoryListbox = New System.Windows.Forms.ListBox()
        Me.questionDifficultyLbl = New System.Windows.Forms.Label()
        Me.markLbl = New System.Windows.Forms.Label()
        Me.questionListbox = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel.SuspendLayout()
        Me.mainTab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.summaryTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 3
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel.Controls.Add(Me.hideNameBtn, 0, 2)
        Me.TableLayoutPanel.Controls.Add(Me.TitleLbl, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.BackBtn, 2, 0)
        Me.TableLayoutPanel.Controls.Add(Me.saveBtn, 1, 2)
        Me.TableLayoutPanel.Controls.Add(Me.mainTab, 0, 1)
        Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel.MinimumSize = New System.Drawing.Size(858, 424)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 3
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel.Size = New System.Drawing.Size(858, 424)
        Me.TableLayoutPanel.TabIndex = 2
        '
        'hideNameBtn
        '
        Me.hideNameBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.hideNameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hideNameBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.hideNameBtn.Location = New System.Drawing.Point(3, 349)
        Me.hideNameBtn.Name = "hideNameBtn"
        Me.hideNameBtn.Padding = New System.Windows.Forms.Padding(3)
        Me.hideNameBtn.Size = New System.Drawing.Size(79, 72)
        Me.hideNameBtn.TabIndex = 18
        Me.hideNameBtn.Text = "Hide Name"
        Me.hideNameBtn.UseVisualStyleBackColor = True
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TitleLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleLbl.Font = New System.Drawing.Font("Segoe UI Light", 21.0!)
        Me.TitleLbl.Location = New System.Drawing.Point(88, 3)
        Me.TitleLbl.Margin = New System.Windows.Forms.Padding(3)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(682, 54)
        Me.TitleLbl.TabIndex = 2
        Me.TitleLbl.Text = "Student Name"
        Me.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'saveBtn
        '
        Me.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.Location = New System.Drawing.Point(337, 353)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(184, 63)
        Me.saveBtn.TabIndex = 16
        Me.saveBtn.Text = "Save Changes"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'mainTab
        '
        Me.TableLayoutPanel.SetColumnSpan(Me.mainTab, 3)
        Me.mainTab.Controls.Add(Me.TabPage1)
        Me.mainTab.Controls.Add(Me.TabPage2)
        Me.mainTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainTab.Location = New System.Drawing.Point(3, 63)
        Me.mainTab.Name = "mainTab"
        Me.mainTab.SelectedIndex = 0
        Me.mainTab.Size = New System.Drawing.Size(852, 280)
        Me.mainTab.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.scrollPanel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(844, 247)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Questions"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'scrollPanel
        '
        Me.scrollPanel.AutoScroll = True
        Me.scrollPanel.ColumnCount = 1
        Me.scrollPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.scrollPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.scrollPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.scrollPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scrollPanel.Location = New System.Drawing.Point(3, 3)
        Me.scrollPanel.Name = "scrollPanel"
        Me.scrollPanel.RowCount = 1
        Me.scrollPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.scrollPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 241.0!))
        Me.scrollPanel.Size = New System.Drawing.Size(838, 241)
        Me.scrollPanel.TabIndex = 16
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.summaryTable)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(844, 247)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Summary"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'summaryTable
        '
        Me.summaryTable.ColumnCount = 2
        Me.summaryTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.summaryTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.summaryTable.Controls.Add(Me.CategoriesLbl, 1, 1)
        Me.summaryTable.Controls.Add(Me.categoryListbox, 1, 3)
        Me.summaryTable.Controls.Add(Me.questionDifficultyLbl, 0, 1)
        Me.summaryTable.Controls.Add(Me.markLbl, 0, 0)
        Me.summaryTable.Controls.Add(Me.questionListbox, 0, 3)
        Me.summaryTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.summaryTable.Location = New System.Drawing.Point(3, 3)
        Me.summaryTable.Name = "summaryTable"
        Me.summaryTable.RowCount = 4
        Me.summaryTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.summaryTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.summaryTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.summaryTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.summaryTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.summaryTable.Size = New System.Drawing.Size(838, 241)
        Me.summaryTable.TabIndex = 0
        '
        'CategoriesLbl
        '
        Me.CategoriesLbl.AutoSize = True
        Me.CategoriesLbl.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoriesLbl.Location = New System.Drawing.Point(422, 38)
        Me.CategoriesLbl.Name = "CategoriesLbl"
        Me.CategoriesLbl.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.CategoriesLbl.Size = New System.Drawing.Size(288, 33)
        Me.CategoriesLbl.TabIndex = 4
        Me.CategoriesLbl.Text = "Category Scores (Asc Accuracy):"
        '
        'categoryListbox
        '
        Me.categoryListbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.categoryListbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoryListbox.FormattingEnabled = True
        Me.categoryListbox.ItemHeight = 28
        Me.categoryListbox.Location = New System.Drawing.Point(422, 74)
        Me.categoryListbox.Name = "categoryListbox"
        Me.categoryListbox.Size = New System.Drawing.Size(413, 164)
        Me.categoryListbox.TabIndex = 3
        '
        'questionDifficultyLbl
        '
        Me.questionDifficultyLbl.AutoSize = True
        Me.questionDifficultyLbl.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.questionDifficultyLbl.Location = New System.Drawing.Point(3, 38)
        Me.questionDifficultyLbl.Name = "questionDifficultyLbl"
        Me.questionDifficultyLbl.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.questionDifficultyLbl.Size = New System.Drawing.Size(287, 33)
        Me.questionDifficultyLbl.TabIndex = 1
        Me.questionDifficultyLbl.Text = "Question Scores (Asc Accuracy):"
        '
        'markLbl
        '
        Me.markLbl.AutoSize = True
        Me.summaryTable.SetColumnSpan(Me.markLbl, 2)
        Me.markLbl.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.markLbl.Location = New System.Drawing.Point(3, 0)
        Me.markLbl.Name = "markLbl"
        Me.markLbl.Padding = New System.Windows.Forms.Padding(5)
        Me.markLbl.Size = New System.Drawing.Size(123, 38)
        Me.markLbl.TabIndex = 0
        Me.markLbl.Text = "Total Mark: "
        '
        'questionListbox
        '
        Me.questionListbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.questionListbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.questionListbox.FormattingEnabled = True
        Me.questionListbox.ItemHeight = 28
        Me.questionListbox.Location = New System.Drawing.Point(3, 74)
        Me.questionListbox.Name = "questionListbox"
        Me.questionListbox.Size = New System.Drawing.Size(413, 164)
        Me.questionListbox.TabIndex = 2
        '
        'T_ViewReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 444)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.MinimumSize = New System.Drawing.Size(900, 500)
        Me.Name = "T_ViewReport"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Report"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        Me.mainTab.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.summaryTable.ResumeLayout(False)
        Me.summaryTable.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel As TableLayoutPanel
    Friend WithEvents TitleLbl As Label
    Friend WithEvents BackBtn As Button
    Friend WithEvents saveBtn As Button
    Friend WithEvents hideNameBtn As Button
    Friend WithEvents mainTab As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents scrollPanel As TableLayoutPanel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents summaryTable As TableLayoutPanel
    Friend WithEvents questionDifficultyLbl As Label
    Friend WithEvents markLbl As Label
    Friend WithEvents categoryListbox As ListBox
    Friend WithEvents questionListbox As ListBox
    Friend WithEvents CategoriesLbl As Label
End Class
