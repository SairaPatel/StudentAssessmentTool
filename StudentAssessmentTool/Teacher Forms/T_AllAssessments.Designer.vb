<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class T_AllAssessments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(T_AllAssessments))
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.AssessmentsListBox = New System.Windows.Forms.ListBox()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.copyBtn = New System.Windows.Forms.Button()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.searchImages = New System.Windows.Forms.ImageList(Me.components)
        Me.SharedBtn = New System.Windows.Forms.Button()
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
        Me.TableLayoutPanel.Controls.Add(Me.AssessmentsListBox, 0, 2)
        Me.TableLayoutPanel.Controls.Add(Me.BackBtn, 3, 0)
        Me.TableLayoutPanel.Controls.Add(Me.FlowLayoutPanel2, 0, 3)
        Me.TableLayoutPanel.Controls.Add(Me.searchBtn, 3, 3)
        Me.TableLayoutPanel.Controls.Add(Me.SharedBtn, 2, 3)
        Me.TableLayoutPanel.Controls.Add(Me.resultsLbl, 0, 1)
        Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 4
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(859, 424)
        Me.TableLayoutPanel.TabIndex = 0
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TableLayoutPanel.SetColumnSpan(Me.TitleLbl, 2)
        Me.TitleLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleLbl.Font = New System.Drawing.Font("Segoe UI Light", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLbl.Location = New System.Drawing.Point(63, 3)
        Me.TitleLbl.Margin = New System.Windows.Forms.Padding(3)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(733, 54)
        Me.TitleLbl.TabIndex = 2
        Me.TitleLbl.Text = "YOUR ASSESSMENTS"
        Me.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AssessmentsListBox
        '
        Me.TableLayoutPanel.SetColumnSpan(Me.AssessmentsListBox, 4)
        Me.AssessmentsListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AssessmentsListBox.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.AssessmentsListBox.FormattingEnabled = True
        Me.AssessmentsListBox.ItemHeight = 45
        Me.AssessmentsListBox.Location = New System.Drawing.Point(0, 90)
        Me.AssessmentsListBox.Margin = New System.Windows.Forms.Padding(0)
        Me.AssessmentsListBox.Name = "AssessmentsListBox"
        Me.AssessmentsListBox.Size = New System.Drawing.Size(859, 274)
        Me.AssessmentsListBox.TabIndex = 8
        '
        'BackBtn
        '
        Me.BackBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BackBtn.BackColor = System.Drawing.Color.Transparent
        Me.BackBtn.BackgroundImage = CType(resources.GetObject("BackBtn.BackgroundImage"), System.Drawing.Image)
        Me.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.BackBtn.Location = New System.Drawing.Point(809, 0)
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
        Me.FlowLayoutPanel2.Controls.Add(Me.AddBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.DeleteBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.copyBtn)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 367)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(211, 54)
        Me.FlowLayoutPanel2.TabIndex = 10
        '
        'AddBtn
        '
        Me.AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddBtn.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.Location = New System.Drawing.Point(0, 0)
        Me.AddBtn.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(55, 55)
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
        Me.DeleteBtn.Size = New System.Drawing.Size(55, 55)
        Me.DeleteBtn.TabIndex = 2
        Me.DeleteBtn.UseVisualStyleBackColor = True
        Me.DeleteBtn.Visible = False
        '
        'copyBtn
        '
        Me.copyBtn.BackgroundImage = Global.StudentAssessmentTool.My.Resources.Resources.CopyIcon
        Me.copyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.copyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.copyBtn.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copyBtn.Location = New System.Drawing.Point(119, 0)
        Me.copyBtn.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.copyBtn.Name = "copyBtn"
        Me.copyBtn.Size = New System.Drawing.Size(55, 55)
        Me.copyBtn.TabIndex = 3
        Me.copyBtn.UseVisualStyleBackColor = True
        Me.copyBtn.Visible = False
        '
        'searchBtn
        '
        Me.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchBtn.ImageIndex = 0
        Me.searchBtn.ImageList = Me.searchImages
        Me.searchBtn.Location = New System.Drawing.Point(800, 369)
        Me.searchBtn.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(55, 55)
        Me.searchBtn.TabIndex = 13
        Me.searchBtn.UseVisualStyleBackColor = True
        '
        'searchImages
        '
        Me.searchImages.ImageStream = CType(resources.GetObject("searchImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.searchImages.TransparentColor = System.Drawing.Color.Transparent
        Me.searchImages.Images.SetKeyName(0, "search")
        Me.searchImages.Images.SetKeyName(1, "cancelSearch")
        '
        'SharedBtn
        '
        Me.SharedBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SharedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SharedBtn.Location = New System.Drawing.Point(682, 369)
        Me.SharedBtn.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.SharedBtn.Name = "SharedBtn"
        Me.SharedBtn.Size = New System.Drawing.Size(114, 55)
        Me.SharedBtn.TabIndex = 11
        Me.SharedBtn.Text = "Shared Assessments"
        Me.SharedBtn.UseVisualStyleBackColor = True
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
        Me.resultsLbl.Size = New System.Drawing.Size(855, 26)
        Me.resultsLbl.TabIndex = 14
        Me.resultsLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'T_AllAssessments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 444)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(900, 500)
        Me.Name = "T_AllAssessments"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Assessments"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel As TableLayoutPanel
    Friend WithEvents BackBtn As Button
    Friend WithEvents AssessmentsListBox As ListBox
    Friend WithEvents TitleLbl As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents AddBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents SharedBtn As Button
    Friend WithEvents searchImages As ImageList
    Friend WithEvents searchBtn As Button
    Friend WithEvents resultsLbl As Label
    Friend WithEvents copyBtn As Button
End Class
