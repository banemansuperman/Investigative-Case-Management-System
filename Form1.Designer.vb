<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CrownDockPanel1 = New ReaLTaiizor.Docking.Crown.CrownDockPanel()
        Me.HopePictureBox1 = New ReaLTaiizor.Controls.HopePictureBox()
        Me.FoxLabel1 = New ReaLTaiizor.Controls.FoxLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FoxLabel2 = New ReaLTaiizor.Controls.FoxLabel()
        Me.TextBox1 = New ReaLTaiizor.Controls.DungeonTextBox()
        Me.TextBox2 = New ReaLTaiizor.Controls.DungeonTextBox()
        Me.ButtonLeft2 = New ReaLTaiizor.Controls.DungeonButtonLeft()
        Me.DungeonLinkLabel1 = New ReaLTaiizor.Controls.DungeonLinkLabel()
        Me.DungeonLinkLabel2 = New ReaLTaiizor.Controls.DungeonLinkLabel()
        Me.NightButton1 = New ReaLTaiizor.Controls.NightButton()
        CType(Me.HopePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrownDockPanel1
        '
        Me.CrownDockPanel1.BackColor = System.Drawing.Color.Cyan
        Me.CrownDockPanel1.Location = New System.Drawing.Point(2, 1)
        Me.CrownDockPanel1.Name = "CrownDockPanel1"
        Me.CrownDockPanel1.Size = New System.Drawing.Size(0, 0)
        Me.CrownDockPanel1.TabIndex = 0
        '
        'HopePictureBox1
        '
        Me.HopePictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HopePictureBox1.Image = CType(resources.GetObject("HopePictureBox1.Image"), System.Drawing.Image)
        Me.HopePictureBox1.Location = New System.Drawing.Point(566, 50)
        Me.HopePictureBox1.Name = "HopePictureBox1"
        Me.HopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        Me.HopePictureBox1.Size = New System.Drawing.Size(218, 342)
        Me.HopePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.HopePictureBox1.TabIndex = 2
        Me.HopePictureBox1.TabStop = False
        Me.HopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        '
        'FoxLabel1
        '
        Me.FoxLabel1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FoxLabel1.ForeColor = System.Drawing.Color.Cyan
        Me.FoxLabel1.Location = New System.Drawing.Point(514, 454)
        Me.FoxLabel1.Name = "FoxLabel1"
        Me.FoxLabel1.Size = New System.Drawing.Size(91, 27)
        Me.FoxLabel1.TabIndex = 3
        Me.FoxLabel1.Text = "Username"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cyan
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.ForeColor = System.Drawing.Color.Cyan
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(150, 773)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Cyan
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.ForeColor = System.Drawing.Color.Cyan
        Me.Panel2.Location = New System.Drawing.Point(1233, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(150, 773)
        Me.Panel2.TabIndex = 5
        '
        'FoxLabel2
        '
        Me.FoxLabel2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FoxLabel2.ForeColor = System.Drawing.Color.Cyan
        Me.FoxLabel2.Location = New System.Drawing.Point(514, 512)
        Me.FoxLabel2.Name = "FoxLabel2"
        Me.FoxLabel2.Size = New System.Drawing.Size(91, 27)
        Me.FoxLabel2.TabIndex = 6
        Me.FoxLabel2.Text = "Password"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Transparent
        Me.TextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.TextBox1.EdgeColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Cyan
        Me.TextBox1.Location = New System.Drawing.Point(611, 454)
        Me.TextBox1.MaxLength = 32767
        Me.TextBox1.Multiline = False
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = False
        Me.TextBox1.Size = New System.Drawing.Size(157, 33)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBox1.UseSystemPasswordChar = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Transparent
        Me.TextBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.TextBox2.EdgeColor = System.Drawing.Color.White
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.ForestGreen
        Me.TextBox2.Location = New System.Drawing.Point(611, 508)
        Me.TextBox2.MaxLength = 32767
        Me.TextBox2.Multiline = False
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = False
        Me.TextBox2.Size = New System.Drawing.Size(157, 31)
        Me.TextBox2.TabIndex = 8
        Me.TextBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'ButtonLeft2
        '
        Me.ButtonLeft2.BackColor = System.Drawing.Color.Transparent
        Me.ButtonLeft2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonLeft2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLeft2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonLeft2.Image = Nothing
        Me.ButtonLeft2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonLeft2.InactiveColorA = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ButtonLeft2.InactiveColorB = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ButtonLeft2.Location = New System.Drawing.Point(803, 478)
        Me.ButtonLeft2.Name = "ButtonLeft2"
        Me.ButtonLeft2.PressedColorA = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ButtonLeft2.PressedColorB = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ButtonLeft2.PressedContourColorA = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.ButtonLeft2.PressedContourColorB = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.ButtonLeft2.Size = New System.Drawing.Size(110, 30)
        Me.ButtonLeft2.TabIndex = 12
        Me.ButtonLeft2.Text = "LOGIN"
        Me.ButtonLeft2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'DungeonLinkLabel1
        '
        Me.DungeonLinkLabel1.ActiveLinkColor = System.Drawing.Color.Lime
        Me.DungeonLinkLabel1.AutoSize = True
        Me.DungeonLinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.DungeonLinkLabel1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DungeonLinkLabel1.ForeColor = System.Drawing.Color.Cyan
        Me.DungeonLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.DungeonLinkLabel1.LinkColor = System.Drawing.Color.Blue
        Me.DungeonLinkLabel1.Location = New System.Drawing.Point(479, 633)
        Me.DungeonLinkLabel1.Name = "DungeonLinkLabel1"
        Me.DungeonLinkLabel1.Size = New System.Drawing.Size(193, 25)
        Me.DungeonLinkLabel1.TabIndex = 13
        Me.DungeonLinkLabel1.TabStop = True
        Me.DungeonLinkLabel1.Text = "Create New Account?"
        Me.DungeonLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(70, Byte), Integer))
        '
        'DungeonLinkLabel2
        '
        Me.DungeonLinkLabel2.ActiveLinkColor = System.Drawing.Color.Cyan
        Me.DungeonLinkLabel2.AutoSize = True
        Me.DungeonLinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.DungeonLinkLabel2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.DungeonLinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.DungeonLinkLabel2.LinkColor = System.Drawing.Color.Blue
        Me.DungeonLinkLabel2.Location = New System.Drawing.Point(708, 633)
        Me.DungeonLinkLabel2.Name = "DungeonLinkLabel2"
        Me.DungeonLinkLabel2.Size = New System.Drawing.Size(161, 25)
        Me.DungeonLinkLabel2.TabIndex = 14
        Me.DungeonLinkLabel2.TabStop = True
        Me.DungeonLinkLabel2.Text = "Forgot Password?"
        Me.DungeonLinkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(70, Byte), Integer))
        '
        'NightButton1
        '
        Me.NightButton1.BackColor = System.Drawing.Color.Transparent
        Me.NightButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NightButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.NightButton1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NightButton1.ForeColor = System.Drawing.Color.White
        Me.NightButton1.HoverBackColor = System.Drawing.Color.Cyan
        Me.NightButton1.HoverForeColor = System.Drawing.Color.Black
        Me.NightButton1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
        Me.NightButton1.Location = New System.Drawing.Point(1083, 1)
        Me.NightButton1.MinimumSize = New System.Drawing.Size(144, 47)
        Me.NightButton1.Name = "NightButton1"
        Me.NightButton1.NormalBackColor = System.Drawing.Color.Black
        Me.NightButton1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        Me.NightButton1.PressedBackColor = System.Drawing.Color.Cyan
        Me.NightButton1.PressedForeColor = System.Drawing.Color.Black
        Me.NightButton1.Radius = 20
        Me.NightButton1.Size = New System.Drawing.Size(144, 47)
        Me.NightButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.NightButton1.TabIndex = 15
        Me.NightButton1.Text = "EXIT?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1384, 774)
        Me.Controls.Add(Me.NightButton1)
        Me.Controls.Add(Me.DungeonLinkLabel2)
        Me.Controls.Add(Me.DungeonLinkLabel1)
        Me.Controls.Add(Me.ButtonLeft2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.FoxLabel2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FoxLabel1)
        Me.Controls.Add(Me.HopePictureBox1)
        Me.Controls.Add(Me.CrownDockPanel1)
        Me.Name = "Form1"
        Me.Text = "Login"
        CType(Me.HopePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrownDockPanel1 As ReaLTaiizor.Docking.Crown.CrownDockPanel
    Friend WithEvents HopePictureBox1 As ReaLTaiizor.Controls.HopePictureBox
    Friend WithEvents FoxLabel1 As ReaLTaiizor.Controls.FoxLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FoxLabel2 As ReaLTaiizor.Controls.FoxLabel
    Friend WithEvents TextBox1 As ReaLTaiizor.Controls.DungeonTextBox
    Friend WithEvents TextBox2 As ReaLTaiizor.Controls.DungeonTextBox
    Friend WithEvents ButtonLeft2 As ReaLTaiizor.Controls.DungeonButtonLeft
    Friend WithEvents DungeonLinkLabel1 As ReaLTaiizor.Controls.DungeonLinkLabel
    Friend WithEvents DungeonLinkLabel2 As ReaLTaiizor.Controls.DungeonLinkLabel
    Friend WithEvents NightButton1 As ReaLTaiizor.Controls.NightButton
End Class
