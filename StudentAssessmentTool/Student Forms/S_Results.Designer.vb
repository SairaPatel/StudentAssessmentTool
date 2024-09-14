<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class S_Results
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(S_Results))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.statusLbl = New System.Windows.Forms.Label()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.titleLbl = New System.Windows.Forms.Label()
        Me.markLbl = New System.Windows.Forms.Label()
        Me.studentLoginBtn = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.statusLbl, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BackBtn, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.titleLbl, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.markLbl, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.studentLoginBtn, 1, 7)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(865, 442)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'statusLbl
        '
        Me.statusLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.statusLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.statusLbl, 2)
        Me.statusLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusLbl.Location = New System.Drawing.Point(245, 346)
        Me.statusLbl.Margin = New System.Windows.Forms.Padding(4)
        Me.statusLbl.Name = "statusLbl"
        Me.statusLbl.Size = New System.Drawing.Size(379, 25)
        Me.statusLbl.TabIndex = 27
        Me.statusLbl.Text = "Waiting for teacher to save the live report..."
        Me.statusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'titleLbl
        '
        Me.titleLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.titleLbl, 2)
        Me.titleLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.titleLbl.Font = New System.Drawing.Font("Segoe UI", 26.0!)
        Me.titleLbl.Location = New System.Drawing.Point(73, 3)
        Me.titleLbl.Margin = New System.Windows.Forms.Padding(3)
        Me.titleLbl.Name = "titleLbl"
        Me.titleLbl.Size = New System.Drawing.Size(724, 71)
        Me.titleLbl.TabIndex = 1
        Me.titleLbl.Text = "Results"
        Me.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'markLbl
        '
        Me.markLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.markLbl, 2)
        Me.markLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.markLbl.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.markLbl.Location = New System.Drawing.Point(73, 77)
        Me.markLbl.Name = "markLbl"
        Me.markLbl.Size = New System.Drawing.Size(724, 265)
        Me.markLbl.TabIndex = 18
        Me.markLbl.Text = "Mark:"
        Me.markLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'studentLoginBtn
        '
        Me.studentLoginBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel1.SetColumnSpan(Me.studentLoginBtn, 2)
        Me.studentLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.studentLoginBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentLoginBtn.Location = New System.Drawing.Point(341, 378)
        Me.studentLoginBtn.Name = "studentLoginBtn"
        Me.studentLoginBtn.Size = New System.Drawing.Size(187, 61)
        Me.studentLoginBtn.TabIndex = 28
        Me.studentLoginBtn.Text = "Student Portal"
        Me.studentLoginBtn.UseVisualStyleBackColor = True
        '
        'Timer
        '
        '
        'S_Results
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 462)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(900, 500)
        Me.Name = "S_Results"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Results"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BackBtn As Button
    Friend WithEvents titleLbl As Label
    Friend WithEvents markLbl As Label
    Friend WithEvents statusLbl As Label
    Friend WithEvents studentLoginBtn As Button
    Friend WithEvents Timer As Timer
End Class
