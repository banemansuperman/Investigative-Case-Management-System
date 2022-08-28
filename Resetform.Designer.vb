<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resetform
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
        Me.AirForm1 = New ReaLTaiizor.Forms.AirForm()
        Me.Panel1 = New ReaLTaiizor.Controls.Panel()
        Me.DungeonLabel1 = New ReaLTaiizor.Controls.DungeonLabel()
        Me.DungeonLabel2 = New ReaLTaiizor.Controls.DungeonLabel()
        Me.DungeonLabel3 = New ReaLTaiizor.Controls.DungeonLabel()
        Me.TextBox1 = New ReaLTaiizor.Controls.SmallTextBox()
        Me.Textpass = New ReaLTaiizor.Controls.SmallTextBox()
        Me.TextConfirm = New ReaLTaiizor.Controls.SmallTextBox()
        Me.Button1 = New ReaLTaiizor.Controls.HopeRoundButton()
        Me.AirForm1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AirForm1
        '
        Me.AirForm1.BackColor = System.Drawing.Color.Black
        Me.AirForm1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.AirForm1.Controls.Add(Me.Panel1)
        Me.AirForm1.Customization = "AAAA/1paWv9ycnL/"
        Me.AirForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AirForm1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AirForm1.Image = Nothing
        Me.AirForm1.Location = New System.Drawing.Point(0, 0)
        Me.AirForm1.MinimumSize = New System.Drawing.Size(112, 35)
        Me.AirForm1.Movable = True
        Me.AirForm1.Name = "AirForm1"
        Me.AirForm1.NoRounding = False
        Me.AirForm1.Sizable = True
        Me.AirForm1.Size = New System.Drawing.Size(800, 450)
        Me.AirForm1.SmartBounds = True
        Me.AirForm1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.AirForm1.TabIndex = 0
        Me.AirForm1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.AirForm1.Transparent = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Aqua
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TextConfirm)
        Me.Panel1.Controls.Add(Me.Textpass)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.DungeonLabel3)
        Me.Panel1.Controls.Add(Me.DungeonLabel2)
        Me.Panel1.Controls.Add(Me.DungeonLabel1)
        Me.Panel1.EdgeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(164, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(426, 336)
        Me.Panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.Panel1.TabIndex = 0
        Me.Panel1.Text = "Panel1"
        '
        'DungeonLabel1
        '
        Me.DungeonLabel1.AutoSize = True
        Me.DungeonLabel1.BackColor = System.Drawing.Color.Transparent
        Me.DungeonLabel1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DungeonLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.DungeonLabel1.Location = New System.Drawing.Point(21, 54)
        Me.DungeonLabel1.Name = "DungeonLabel1"
        Me.DungeonLabel1.Size = New System.Drawing.Size(97, 25)
        Me.DungeonLabel1.TabIndex = 0
        Me.DungeonLabel1.Text = "Username"
        '
        'DungeonLabel2
        '
        Me.DungeonLabel2.AutoSize = True
        Me.DungeonLabel2.BackColor = System.Drawing.Color.Transparent
        Me.DungeonLabel2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.DungeonLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.DungeonLabel2.Location = New System.Drawing.Point(21, 118)
        Me.DungeonLabel2.Name = "DungeonLabel2"
        Me.DungeonLabel2.Size = New System.Drawing.Size(92, 25)
        Me.DungeonLabel2.TabIndex = 1
        Me.DungeonLabel2.Text = "Password"
        '
        'DungeonLabel3
        '
        Me.DungeonLabel3.AutoSize = True
        Me.DungeonLabel3.BackColor = System.Drawing.Color.Transparent
        Me.DungeonLabel3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.DungeonLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.DungeonLabel3.Location = New System.Drawing.Point(21, 176)
        Me.DungeonLabel3.Name = "DungeonLabel3"
        Me.DungeonLabel3.Size = New System.Drawing.Size(165, 25)
        Me.DungeonLabel3.TabIndex = 2
        Me.DungeonLabel3.Text = "Confirm Password"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Transparent
        Me.TextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.TextBox1.CustomBGColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.DimGray
        Me.TextBox1.Location = New System.Drawing.Point(127, 54)
        Me.TextBox1.MaxLength = 32767
        Me.TextBox1.Multiline = False
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = False
        Me.TextBox1.Size = New System.Drawing.Size(174, 33)
        Me.TextBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBox1.UseSystemPasswordChar = False
        '
        'Textpass
        '
        Me.Textpass.BackColor = System.Drawing.Color.Transparent
        Me.Textpass.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Textpass.CustomBGColor = System.Drawing.Color.White
        Me.Textpass.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Textpass.ForeColor = System.Drawing.Color.DimGray
        Me.Textpass.Location = New System.Drawing.Point(127, 118)
        Me.Textpass.MaxLength = 32767
        Me.Textpass.Multiline = False
        Me.Textpass.Name = "Textpass"
        Me.Textpass.ReadOnly = False
        Me.Textpass.Size = New System.Drawing.Size(174, 33)
        Me.Textpass.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.Textpass.TabIndex = 5
        Me.Textpass.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.Textpass.UseSystemPasswordChar = False
        '
        'TextConfirm
        '
        Me.TextConfirm.BackColor = System.Drawing.Color.Transparent
        Me.TextConfirm.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.TextConfirm.CustomBGColor = System.Drawing.Color.White
        Me.TextConfirm.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.TextConfirm.ForeColor = System.Drawing.Color.DimGray
        Me.TextConfirm.Location = New System.Drawing.Point(191, 176)
        Me.TextConfirm.MaxLength = 32767
        Me.TextConfirm.Multiline = False
        Me.TextConfirm.Name = "TextConfirm"
        Me.TextConfirm.ReadOnly = False
        Me.TextConfirm.Size = New System.Drawing.Size(208, 33)
        Me.TextConfirm.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.TextConfirm.TabIndex = 6
        Me.TextConfirm.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextConfirm.UseSystemPasswordChar = False
        '
        'Button1
        '
        Me.Button1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Button1.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.DangerColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Button1.DefaultColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.HoverTextColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Button1.InfoColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(111, 238)
        Me.Button1.Name = "Button1"
        Me.Button1.PrimaryColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Size = New System.Drawing.Size(190, 40)
        Me.Button1.SuccessColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Submit"
        Me.Button1.TextColor = System.Drawing.Color.White
        Me.Button1.WarningColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(60, Byte), Integer))
        '
        'Resetform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AirForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(261, 65)
        Me.Name = "Resetform"
        Me.ShowIcon = False
        Me.Text = "DungeonForm1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.AirForm1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AirForm1 As ReaLTaiizor.Forms.AirForm
    Friend WithEvents Panel1 As ReaLTaiizor.Controls.Panel
    Friend WithEvents TextConfirm As ReaLTaiizor.Controls.SmallTextBox
    Friend WithEvents Textpass As ReaLTaiizor.Controls.SmallTextBox
    Friend WithEvents TextBox1 As ReaLTaiizor.Controls.SmallTextBox
    Friend WithEvents DungeonLabel3 As ReaLTaiizor.Controls.DungeonLabel
    Friend WithEvents DungeonLabel2 As ReaLTaiizor.Controls.DungeonLabel
    Friend WithEvents DungeonLabel1 As ReaLTaiizor.Controls.DungeonLabel
    Friend WithEvents Button1 As ReaLTaiizor.Controls.HopeRoundButton
End Class
