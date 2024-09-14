<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class S_LiveIDEnter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(S_LiveIDEnter))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.HomeBtn = New System.Windows.Forms.Button()
        Me.GoBtn = New System.Windows.Forms.Button()
        Me.IDInput = New System.Windows.Forms.TextBox()
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.HomeBtn, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GoBtn, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.IDInput, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TitleLbl, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.loginBtn, 1, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99999!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(864, 441)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'HomeBtn
        '
        Me.HomeBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HomeBtn.BackgroundImage = CType(resources.GetObject("HomeBtn.BackgroundImage"), System.Drawing.Image)
        Me.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.HomeBtn.Location = New System.Drawing.Point(814, 0)
        Me.HomeBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(50, 50)
        Me.HomeBtn.TabIndex = 0
        Me.HomeBtn.UseVisualStyleBackColor = True
        '
        'GoBtn
        '
        Me.GoBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TableLayoutPanel1.SetColumnSpan(Me.GoBtn, 2)
        Me.GoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GoBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoBtn.Location = New System.Drawing.Point(345, 305)
        Me.GoBtn.Name = "GoBtn"
        Me.GoBtn.Size = New System.Drawing.Size(173, 63)
        Me.GoBtn.TabIndex = 1
        Me.GoBtn.Text = "GO"
        Me.GoBtn.UseVisualStyleBackColor = True
        '
        'IDInput
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.IDInput, 2)
        Me.IDInput.Dock = System.Windows.Forms.DockStyle.Top
        Me.IDInput.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDInput.Location = New System.Drawing.Point(30, 225)
        Me.IDInput.Margin = New System.Windows.Forms.Padding(30, 3, 30, 3)
        Me.IDInput.Name = "IDInput"
        Me.IDInput.Size = New System.Drawing.Size(804, 43)
        Me.IDInput.TabIndex = 2
        Me.IDInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.TitleLbl, 2)
        Me.TitleLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleLbl.Font = New System.Drawing.Font("Segoe UI Light", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLbl.Location = New System.Drawing.Point(3, 74)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(858, 148)
        Me.TitleLbl.TabIndex = 3
        Me.TitleLbl.Text = "ASSESSMENTS ID:"
        Me.TitleLbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'loginBtn
        '
        Me.loginBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.loginBtn, 2)
        Me.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.Location = New System.Drawing.Point(726, 380)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(135, 58)
        Me.loginBtn.TabIndex = 4
        Me.loginBtn.Text = "Student Portal"
        Me.loginBtn.UseVisualStyleBackColor = True
        '
        'S_LiveIDEnter
        '
        Me.AcceptButton = Me.GoBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 461)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(900, 500)
        Me.Name = "S_LiveIDEnter"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Enter Live ID"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents HomeBtn As Button
    Friend WithEvents GoBtn As Button
    Friend WithEvents IDInput As TextBox
    Friend WithEvents TitleLbl As Label
    Friend WithEvents loginBtn As Button
End Class
