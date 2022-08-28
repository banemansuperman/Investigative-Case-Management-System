<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Printforensic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Printforensic))
        Me.SkyLabel2 = New ReaLTaiizor.Controls.SkyLabel()
        Me.ToggleButton1 = New ReaLTaiizor.Controls.ToggleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SmallTextBox1 = New ReaLTaiizor.Controls.SmallTextBox()
        Me.SkyLabel1 = New ReaLTaiizor.Controls.SkyLabel()
        Me.NightLinkLabel1 = New ReaLTaiizor.Controls.NightLinkLabel()
        Me.NightButton1 = New ReaLTaiizor.Controls.NightButton()
        Me.Policereport = New System.Windows.Forms.Panel()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Policereport.SuspendLayout()
        Me.SuspendLayout()
        '
        'SkyLabel2
        '
        Me.SkyLabel2.AutoSize = True
        Me.SkyLabel2.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold)
        Me.SkyLabel2.ForeColor = System.Drawing.Color.Cyan
        Me.SkyLabel2.Location = New System.Drawing.Point(212, 99)
        Me.SkyLabel2.Name = "SkyLabel2"
        Me.SkyLabel2.Size = New System.Drawing.Size(42, 14)
        Me.SkyLabel2.TabIndex = 57
        Me.SkyLabel2.Text = "Clear"
        '
        'ToggleButton1
        '
        Me.ToggleButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ToggleButton1.ForeColor = System.Drawing.Color.HotPink
        Me.ToggleButton1.Location = New System.Drawing.Point(197, 116)
        Me.ToggleButton1.Name = "ToggleButton1"
        Me.ToggleButton1.Size = New System.Drawing.Size(76, 33)
        Me.ToggleButton1.TabIndex = 56
        Me.ToggleButton1.Text = "Clear"
        Me.ToggleButton1.Toggled = False
        Me.ToggleButton1.Type = ReaLTaiizor.Controls.ToggleButton._Type.CheckMark
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(212, 182)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 61)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 54
        Me.PictureBox2.TabStop = False
        '
        'SmallTextBox1
        '
        Me.SmallTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.SmallTextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.SmallTextBox1.CustomBGColor = System.Drawing.Color.White
        Me.SmallTextBox1.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.SmallTextBox1.ForeColor = System.Drawing.Color.DimGray
        Me.SmallTextBox1.Location = New System.Drawing.Point(72, 191)
        Me.SmallTextBox1.MaxLength = 32767
        Me.SmallTextBox1.Multiline = False
        Me.SmallTextBox1.Name = "SmallTextBox1"
        Me.SmallTextBox1.ReadOnly = False
        Me.SmallTextBox1.Size = New System.Drawing.Size(118, 33)
        Me.SmallTextBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.SmallTextBox1.TabIndex = 53
        Me.SmallTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.SmallTextBox1.UseSystemPasswordChar = False
        '
        'SkyLabel1
        '
        Me.SkyLabel1.AutoSize = True
        Me.SkyLabel1.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SkyLabel1.ForeColor = System.Drawing.Color.Cyan
        Me.SkyLabel1.Location = New System.Drawing.Point(8, 196)
        Me.SkyLabel1.Name = "SkyLabel1"
        Me.SkyLabel1.Size = New System.Drawing.Size(52, 20)
        Me.SkyLabel1.TabIndex = 52
        Me.SkyLabel1.Text = "F No"
        '
        'NightLinkLabel1
        '
        Me.NightLinkLabel1.ActiveLinkColor = System.Drawing.Color.Cyan
        Me.NightLinkLabel1.AutoSize = True
        Me.NightLinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.NightLinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NightLinkLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NightLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.NightLinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.NightLinkLabel1.Location = New System.Drawing.Point(161, 68)
        Me.NightLinkLabel1.Name = "NightLinkLabel1"
        Me.NightLinkLabel1.Size = New System.Drawing.Size(112, 20)
        Me.NightLinkLabel1.TabIndex = 49
        Me.NightLinkLabel1.TabStop = True
        Me.NightLinkLabel1.Text = "Choose Printer?"
        Me.NightLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'NightButton1
        '
        Me.NightButton1.BackColor = System.Drawing.Color.Transparent
        Me.NightButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NightButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.NightButton1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NightButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.NightButton1.HoverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.NightButton1.HoverForeColor = System.Drawing.Color.White
        Me.NightButton1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
        Me.NightButton1.Location = New System.Drawing.Point(140, 9)
        Me.NightButton1.MinimumSize = New System.Drawing.Size(144, 47)
        Me.NightButton1.Name = "NightButton1"
        Me.NightButton1.NormalBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.NightButton1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        Me.NightButton1.PressedBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.NightButton1.PressedForeColor = System.Drawing.Color.White
        Me.NightButton1.Radius = 20
        Me.NightButton1.Size = New System.Drawing.Size(144, 47)
        Me.NightButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.NightButton1.TabIndex = 51
        Me.NightButton1.Text = "Print"
        '
        'Policereport
        '
        Me.Policereport.BackgroundImage = CType(resources.GetObject("Policereport.BackgroundImage"), System.Drawing.Image)
        Me.Policereport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Policereport.Controls.Add(Me.TextBox8)
        Me.Policereport.Controls.Add(Me.TextBox7)
        Me.Policereport.Controls.Add(Me.TextBox6)
        Me.Policereport.Controls.Add(Me.TextBox5)
        Me.Policereport.Controls.Add(Me.TextBox4)
        Me.Policereport.Controls.Add(Me.TextBox3)
        Me.Policereport.Controls.Add(Me.TextBox2)
        Me.Policereport.Controls.Add(Me.TextBox1)
        Me.Policereport.Location = New System.Drawing.Point(294, 2)
        Me.Policereport.Name = "Policereport"
        Me.Policereport.Size = New System.Drawing.Size(769, 1057)
        Me.Policereport.TabIndex = 50
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.Cyan
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.TextBox8.ForeColor = System.Drawing.Color.Black
        Me.TextBox8.Location = New System.Drawing.Point(587, 287)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(154, 537)
        Me.TextBox8.TabIndex = 65
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.TextBox7.Location = New System.Drawing.Point(177, 800)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(357, 23)
        Me.TextBox7.TabIndex = 64
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.TextBox6.Location = New System.Drawing.Point(139, 656)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(383, 23)
        Me.TextBox6.TabIndex = 63
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.TextBox5.Location = New System.Drawing.Point(164, 523)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(228, 23)
        Me.TextBox5.TabIndex = 62
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.TextBox4.Location = New System.Drawing.Point(117, 396)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(90, 23)
        Me.TextBox4.TabIndex = 61
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.TextBox3.Location = New System.Drawing.Point(128, 270)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(90, 23)
        Me.TextBox3.TabIndex = 60
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.TextBox2.Location = New System.Drawing.Point(411, 139)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(90, 23)
        Me.TextBox2.TabIndex = 59
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.TextBox1.Location = New System.Drawing.Point(155, 139)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(90, 23)
        Me.TextBox1.TabIndex = 58
        '
        'PrintDocument1
        '
        '
        'Printforensic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1066, 1055)
        Me.Controls.Add(Me.SkyLabel2)
        Me.Controls.Add(Me.ToggleButton1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.SmallTextBox1)
        Me.Controls.Add(Me.SkyLabel1)
        Me.Controls.Add(Me.NightLinkLabel1)
        Me.Controls.Add(Me.NightButton1)
        Me.Controls.Add(Me.Policereport)
        Me.Name = "Printforensic"
        Me.Text = "Printforensic"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Policereport.ResumeLayout(False)
        Me.Policereport.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SkyLabel2 As ReaLTaiizor.Controls.SkyLabel
    Friend WithEvents ToggleButton1 As ReaLTaiizor.Controls.ToggleButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SmallTextBox1 As ReaLTaiizor.Controls.SmallTextBox
    Friend WithEvents SkyLabel1 As ReaLTaiizor.Controls.SkyLabel
    Friend WithEvents NightLinkLabel1 As ReaLTaiizor.Controls.NightLinkLabel
    Friend WithEvents NightButton1 As ReaLTaiizor.Controls.NightButton
    Friend WithEvents Policereport As Panel
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
