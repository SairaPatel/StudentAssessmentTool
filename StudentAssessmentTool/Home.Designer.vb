<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ContinueLbl = New System.Windows.Forms.Label()
        Me.StudentBtn = New System.Windows.Forms.Button()
        Me.TeacherBtn = New System.Windows.Forms.Button()
        Me.colourBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ContinueLbl, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.StudentBtn, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TeacherBtn, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.colourBtn, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(5, 5)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.25!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(868, 434)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ContinueLbl
        '
        Me.ContinueLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.ContinueLbl, 2)
        Me.ContinueLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContinueLbl.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContinueLbl.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ContinueLbl.Location = New System.Drawing.Point(3, 93)
        Me.ContinueLbl.Margin = New System.Windows.Forms.Padding(3)
        Me.ContinueLbl.Name = "ContinueLbl"
        Me.ContinueLbl.Size = New System.Drawing.Size(862, 47)
        Me.ContinueLbl.TabIndex = 1
        Me.ContinueLbl.Text = "Continue as..."
        Me.ContinueLbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'StudentBtn
        '
        Me.StudentBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StudentBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Bold)
        Me.StudentBtn.Location = New System.Drawing.Point(30, 173)
        Me.StudentBtn.Margin = New System.Windows.Forms.Padding(30)
        Me.StudentBtn.Name = "StudentBtn"
        Me.StudentBtn.Size = New System.Drawing.Size(374, 170)
        Me.StudentBtn.TabIndex = 2
        Me.StudentBtn.Text = "STUDENT"
        Me.StudentBtn.UseVisualStyleBackColor = True
        '
        'TeacherBtn
        '
        Me.TeacherBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TeacherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TeacherBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Bold)
        Me.TeacherBtn.Location = New System.Drawing.Point(464, 173)
        Me.TeacherBtn.Margin = New System.Windows.Forms.Padding(30)
        Me.TeacherBtn.Name = "TeacherBtn"
        Me.TeacherBtn.Size = New System.Drawing.Size(374, 170)
        Me.TeacherBtn.TabIndex = 3
        Me.TeacherBtn.Text = "TEACHER"
        Me.TeacherBtn.UseVisualStyleBackColor = True
        '
        'colourBtn
        '
        Me.colourBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.colourBtn.BackgroundImage = CType(resources.GetObject("colourBtn.BackgroundImage"), System.Drawing.Image)
        Me.colourBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.colourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colourBtn.Location = New System.Drawing.Point(808, 378)
        Me.colourBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.colourBtn.Name = "colourBtn"
        Me.colourBtn.Size = New System.Drawing.Size(60, 51)
        Me.colourBtn.TabIndex = 4
        Me.colourBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label1, 2)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(862, 90)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "STUDENT ASSESSMENT TOOL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 444)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(900, 500)
        Me.Name = "Home"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Text = "Home"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ContinueLbl As Label
    Friend WithEvents StudentBtn As Button
    Friend WithEvents TeacherBtn As Button
    Friend WithEvents colourBtn As Button
    Friend WithEvents Label1 As Label
End Class
