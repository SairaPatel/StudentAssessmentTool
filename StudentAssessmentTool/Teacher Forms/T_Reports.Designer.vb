<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class T_Reports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(T_Reports))
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.ReportsListbox = New System.Windows.Forms.ListBox()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.resultsLbl = New System.Windows.Forms.Label()
        Me.TableLayoutPanel.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 4
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel.Controls.Add(Me.TitleLbl, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.ReportsListbox, 0, 2)
        Me.TableLayoutPanel.Controls.Add(Me.BackBtn, 3, 0)
        Me.TableLayoutPanel.Controls.Add(Me.FlowLayoutPanel2, 0, 3)
        Me.TableLayoutPanel.Controls.Add(Me.resultsLbl, 0, 1)
        Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel.MinimumSize = New System.Drawing.Size(858, 424)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 4
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(858, 424)
        Me.TableLayoutPanel.TabIndex = 1
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TableLayoutPanel.SetColumnSpan(Me.TitleLbl, 2)
        Me.TitleLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleLbl.Font = New System.Drawing.Font("Segoe UI Light", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLbl.Location = New System.Drawing.Point(63, 3)
        Me.TitleLbl.Margin = New System.Windows.Forms.Padding(3)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(732, 54)
        Me.TitleLbl.TabIndex = 2
        Me.TitleLbl.Text = "YOUR REPORTS"
        Me.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReportsListbox
        '
        Me.TableLayoutPanel.SetColumnSpan(Me.ReportsListbox, 4)
        Me.ReportsListbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportsListbox.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.ReportsListbox.FormattingEnabled = True
        Me.ReportsListbox.ItemHeight = 45
        Me.ReportsListbox.Items.AddRange(New Object() {"Report 1"})
        Me.ReportsListbox.Location = New System.Drawing.Point(0, 90)
        Me.ReportsListbox.Margin = New System.Windows.Forms.Padding(0)
        Me.ReportsListbox.Name = "ReportsListbox"
        Me.ReportsListbox.Size = New System.Drawing.Size(858, 274)
        Me.ReportsListbox.TabIndex = 8
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
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel.SetColumnSpan(Me.FlowLayoutPanel2, 2)
        Me.FlowLayoutPanel2.Controls.Add(Me.DeleteBtn)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 367)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(143, 54)
        Me.FlowLayoutPanel2.TabIndex = 10
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackgroundImage = CType(resources.GetObject("DeleteBtn.BackgroundImage"), System.Drawing.Image)
        Me.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBtn.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.Location = New System.Drawing.Point(3, 0)
        Me.DeleteBtn.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(55, 55)
        Me.DeleteBtn.TabIndex = 2
        Me.DeleteBtn.UseVisualStyleBackColor = True
        Me.DeleteBtn.Visible = False
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
        'T_Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 444)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.MinimumSize = New System.Drawing.Size(900, 500)
        Me.Name = "T_Reports"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Reports"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel As TableLayoutPanel
    Friend WithEvents TitleLbl As Label
    Friend WithEvents ReportsListbox As ListBox
    Friend WithEvents BackBtn As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents resultsLbl As Label
    Friend WithEvents DeleteBtn As Button
End Class
