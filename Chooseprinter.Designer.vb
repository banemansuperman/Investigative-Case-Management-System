<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chooseprinter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Chooseprinter))
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.ParrotGradientPanel1 = New ReaLTaiizor.Controls.ParrotGradientPanel()
        Me.DreamButton1 = New ReaLTaiizor.Controls.DreamButton()
        Me.TextBox1 = New ReaLTaiizor.Controls.FoxTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ParrotGradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'ParrotGradientPanel1
        '
        Me.ParrotGradientPanel1.BottomLeft = System.Drawing.Color.OrangeRed
        Me.ParrotGradientPanel1.BottomRight = System.Drawing.Color.DarkMagenta
        Me.ParrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality
        Me.ParrotGradientPanel1.Controls.Add(Me.DreamButton1)
        Me.ParrotGradientPanel1.Controls.Add(Me.TextBox1)
        Me.ParrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear
        Me.ParrotGradientPanel1.Location = New System.Drawing.Point(2, 58)
        Me.ParrotGradientPanel1.Name = "ParrotGradientPanel1"
        Me.ParrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        Me.ParrotGradientPanel1.PrimerColor = System.Drawing.Color.Lime
        Me.ParrotGradientPanel1.Size = New System.Drawing.Size(797, 334)
        Me.ParrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.ParrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Horizontal
        Me.ParrotGradientPanel1.TabIndex = 1
        Me.ParrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.ParrotGradientPanel1.TopLeft = System.Drawing.Color.Crimson
        Me.ParrotGradientPanel1.TopRight = System.Drawing.Color.Aquamarine
        '
        'DreamButton1
        '
        Me.DreamButton1.ColorA = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.DreamButton1.ColorB = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.DreamButton1.ColorC = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.DreamButton1.ColorD = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DreamButton1.ColorE = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DreamButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DreamButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DreamButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DreamButton1.Location = New System.Drawing.Point(323, 177)
        Me.DreamButton1.Name = "DreamButton1"
        Me.DreamButton1.Size = New System.Drawing.Size(120, 40)
        Me.DreamButton1.TabIndex = 1
        Me.DreamButton1.Text = "Select"
        Me.DreamButton1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox1.EnabledCalc = True
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(213, 121)
        Me.TextBox1.MaxLength = 32767
        Me.TextBox1.MultiLine = False
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = False
        Me.TextBox1.Size = New System.Drawing.Size(344, 29)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBox1.UseSystemPasswordChar = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(748, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Chooseprinter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ParrotGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(112, 35)
        Me.Name = "Chooseprinter"
        Me.Text = "Chooseprinter"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ParrotGradientPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents ParrotGradientPanel1 As ReaLTaiizor.Controls.ParrotGradientPanel
    Friend WithEvents DreamButton1 As ReaLTaiizor.Controls.DreamButton
    Friend WithEvents TextBox1 As ReaLTaiizor.Controls.FoxTextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
