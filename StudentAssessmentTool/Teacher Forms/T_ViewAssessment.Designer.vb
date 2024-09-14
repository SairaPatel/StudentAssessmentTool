<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class T_ViewAssessment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(T_ViewAssessment))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.HomeBtn = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.LiveBtn = New System.Windows.Forms.Button()
        Me.titleLbl = New System.Windows.Forms.Label()
        Me.QuestionsListbox = New System.Windows.Forms.ListBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ReportsBtn = New System.Windows.Forms.Button()
        Me.propertiesBtn = New System.Windows.Forms.Button()
        Me.canEditLbl = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.HomeBtn, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LiveBtn, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.titleLbl, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.QuestionsListbox, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.canEditLbl, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(858, 424)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'HomeBtn
        '
        Me.HomeBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HomeBtn.BackgroundImage = CType(resources.GetObject("HomeBtn.BackgroundImage"), System.Drawing.Image)
        Me.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeBtn.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.HomeBtn.Location = New System.Drawing.Point(808, 0)
        Me.HomeBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(50, 50)
        Me.HomeBtn.TabIndex = 13
        Me.HomeBtn.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel1.SetColumnSpan(Me.FlowLayoutPanel2, 3)
        Me.FlowLayoutPanel2.Controls.Add(Me.AddBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.DeleteBtn)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 366)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(185, 55)
        Me.FlowLayoutPanel2.TabIndex = 11
        '
        'AddBtn
        '
        Me.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddBtn.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.Location = New System.Drawing.Point(0, 0)
        Me.AddBtn.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(55, 50)
        Me.AddBtn.TabIndex = 0
        Me.AddBtn.Text = "+"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackgroundImage = CType(resources.GetObject("DeleteBtn.BackgroundImage"), System.Drawing.Image)
        Me.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBtn.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.Location = New System.Drawing.Point(61, 0)
        Me.DeleteBtn.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(55, 50)
        Me.DeleteBtn.TabIndex = 2
        Me.DeleteBtn.UseVisualStyleBackColor = True
        Me.DeleteBtn.Visible = False
        '
        'LiveBtn
        '
        Me.LiveBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LiveBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LiveBtn.Location = New System.Drawing.Point(326, 371)
        Me.LiveBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.LiveBtn.Name = "LiveBtn"
        Me.LiveBtn.Size = New System.Drawing.Size(196, 46)
        Me.LiveBtn.TabIndex = 9
        Me.LiveBtn.Text = "Start Live Assessment"
        Me.LiveBtn.UseVisualStyleBackColor = True
        '
        'titleLbl
        '
        Me.titleLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.titleLbl, 4)
        Me.titleLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.titleLbl.Font = New System.Drawing.Font("Segoe UI Light", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLbl.Location = New System.Drawing.Point(63, 0)
        Me.titleLbl.Name = "titleLbl"
        Me.titleLbl.Size = New System.Drawing.Size(723, 60)
        Me.titleLbl.TabIndex = 0
        Me.titleLbl.Text = "Assessment Name"
        Me.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QuestionsListbox
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.QuestionsListbox, 6)
        Me.QuestionsListbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QuestionsListbox.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.QuestionsListbox.FormattingEnabled = True
        Me.QuestionsListbox.ItemHeight = 36
        Me.QuestionsListbox.Location = New System.Drawing.Point(0, 143)
        Me.QuestionsListbox.Margin = New System.Windows.Forms.Padding(0)
        Me.QuestionsListbox.Name = "QuestionsListbox"
        Me.QuestionsListbox.Size = New System.Drawing.Size(1287, 404)
        Me.QuestionsListbox.TabIndex = 3
        '
        'FlowLayoutPanel1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.FlowLayoutPanel1, 2)
        Me.FlowLayoutPanel1.Controls.Add(Me.ReportsBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.propertiesBtn)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(618, 369)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(5)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(235, 50)
        Me.FlowLayoutPanel1.TabIndex = 12
        '
        'ReportsBtn
        '
        Me.ReportsBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ReportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReportsBtn.Location = New System.Drawing.Point(3, 3)
        Me.ReportsBtn.Name = "ReportsBtn"
        Me.ReportsBtn.Size = New System.Drawing.Size(107, 45)
        Me.ReportsBtn.TabIndex = 9
        Me.ReportsBtn.Text = "Live Reports"
        Me.ReportsBtn.UseVisualStyleBackColor = True
        '
        'propertiesBtn
        '
        Me.propertiesBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.propertiesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.propertiesBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.propertiesBtn.Location = New System.Drawing.Point(116, 3)
        Me.propertiesBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.propertiesBtn.Name = "propertiesBtn"
        Me.propertiesBtn.Size = New System.Drawing.Size(115, 45)
        Me.propertiesBtn.TabIndex = 10
        Me.propertiesBtn.Text = "Properties"
        Me.propertiesBtn.UseVisualStyleBackColor = True
        '
        'canEditLbl
        '
        Me.canEditLbl.AutoSize = True
        Me.canEditLbl.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.SetColumnSpan(Me.canEditLbl, 6)
        Me.canEditLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.canEditLbl.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.canEditLbl.ForeColor = System.Drawing.Color.Gray
        Me.canEditLbl.Location = New System.Drawing.Point(8, 98)
        Me.canEditLbl.Margin = New System.Windows.Forms.Padding(5)
        Me.canEditLbl.Name = "canEditLbl"
        Me.canEditLbl.Size = New System.Drawing.Size(1272, 38)
        Me.canEditLbl.TabIndex = 14
        Me.canEditLbl.Text = "This Assessment is Locked and cannot be edited because it has been used for at le" &
    "ast 1 live session."
        Me.canEditLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'T_ViewAssessment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 444)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(900, 500)
        Me.Name = "T_ViewAssessment"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Your Assessment"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents titleLbl As Label
    Friend WithEvents QuestionsListbox As ListBox
    Friend WithEvents LiveBtn As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents AddBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ReportsBtn As Button
    Friend WithEvents propertiesBtn As Button
    Friend WithEvents HomeBtn As Button
    Friend WithEvents canEditLbl As Label
End Class
