<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forensic
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Forensic))
        Me.Panel1 = New ReaLTaiizor.Controls.Panel()
        Me.DataGridView1 = New ReaLTaiizor.Controls.PoisonDataGridView()
        Me.Fno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ename = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Evidence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Evidencetype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ereport = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ForensicreportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New ICMS.Database1DataSet()
        Me.ForensicreportTableAdapter = New ICMS.Database1DataSetTableAdapters.ForensicreportTableAdapter()
        Me.DungeonLabel2 = New ReaLTaiizor.Controls.DungeonLabel()
        Me.DungeonLabel3 = New ReaLTaiizor.Controls.DungeonLabel()
        Me.DungeonLabel1 = New ReaLTaiizor.Controls.DungeonLabel()
        Me.DungeonLabel4 = New ReaLTaiizor.Controls.DungeonLabel()
        Me.DungeonLabel5 = New ReaLTaiizor.Controls.DungeonLabel()
        Me.DungeonLabel6 = New ReaLTaiizor.Controls.DungeonLabel()
        Me.DungeonLabel7 = New ReaLTaiizor.Controls.DungeonLabel()
        Me.DungeonLabel8 = New ReaLTaiizor.Controls.DungeonLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New ReaLTaiizor.Controls.Button()
        Me.Button4 = New ReaLTaiizor.Controls.Button()
        Me.Button3 = New ReaLTaiizor.Controls.Button()
        Me.Button2 = New ReaLTaiizor.Controls.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ForensicreportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.EdgeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(168, 375)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(1071, 329)
        Me.Panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.Panel1.TabIndex = 0
        Me.Panel1.Text = "Panel1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fno, Me.Lno, Me.Cno, Me.Vname, Me.Ename, Me.Evidence, Me.Evidencetype, Me.Ereport})
        Me.DataGridView1.DataSource = Me.ForensicreportBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(8, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1052, 303)
        Me.DataGridView1.TabIndex = 0
        '
        'Fno
        '
        Me.Fno.DataPropertyName = "Fno"
        Me.Fno.HeaderText = "Fno"
        Me.Fno.MinimumWidth = 6
        Me.Fno.Name = "Fno"
        Me.Fno.Width = 125
        '
        'Lno
        '
        Me.Lno.DataPropertyName = "Lno "
        Me.Lno.HeaderText = "Lno "
        Me.Lno.MinimumWidth = 6
        Me.Lno.Name = "Lno"
        Me.Lno.Width = 125
        '
        'Cno
        '
        Me.Cno.DataPropertyName = "Cno"
        Me.Cno.HeaderText = "Cno"
        Me.Cno.MinimumWidth = 6
        Me.Cno.Name = "Cno"
        Me.Cno.Width = 125
        '
        'Vname
        '
        Me.Vname.DataPropertyName = "Vname"
        Me.Vname.HeaderText = "Vname"
        Me.Vname.MinimumWidth = 6
        Me.Vname.Name = "Vname"
        Me.Vname.Width = 125
        '
        'Ename
        '
        Me.Ename.DataPropertyName = "Ename"
        Me.Ename.HeaderText = "Ename"
        Me.Ename.MinimumWidth = 6
        Me.Ename.Name = "Ename"
        Me.Ename.Width = 125
        '
        'Evidence
        '
        Me.Evidence.DataPropertyName = "Evidence"
        Me.Evidence.HeaderText = "Evidence"
        Me.Evidence.MinimumWidth = 6
        Me.Evidence.Name = "Evidence"
        Me.Evidence.Width = 125
        '
        'Evidencetype
        '
        Me.Evidencetype.DataPropertyName = "Evidencetype"
        Me.Evidencetype.HeaderText = "Evidencetype"
        Me.Evidencetype.MinimumWidth = 6
        Me.Evidencetype.Name = "Evidencetype"
        Me.Evidencetype.Width = 125
        '
        'Ereport
        '
        Me.Ereport.DataPropertyName = "Ereport"
        Me.Ereport.HeaderText = "Ereport"
        Me.Ereport.MinimumWidth = 6
        Me.Ereport.Name = "Ereport"
        Me.Ereport.Width = 125
        '
        'ForensicreportBindingSource
        '
        Me.ForensicreportBindingSource.DataMember = "Forensicreport"
        Me.ForensicreportBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ForensicreportTableAdapter
        '
        Me.ForensicreportTableAdapter.ClearBeforeFill = True
        '
        'DungeonLabel2
        '
        Me.DungeonLabel2.AutoSize = True
        Me.DungeonLabel2.BackColor = System.Drawing.Color.Transparent
        Me.DungeonLabel2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DungeonLabel2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.DungeonLabel2.Location = New System.Drawing.Point(31, 42)
        Me.DungeonLabel2.Name = "DungeonLabel2"
        Me.DungeonLabel2.Size = New System.Drawing.Size(112, 25)
        Me.DungeonLabel2.TabIndex = 8
        Me.DungeonLabel2.Text = "Forensic No"
        '
        'DungeonLabel3
        '
        Me.DungeonLabel3.AutoSize = True
        Me.DungeonLabel3.BackColor = System.Drawing.Color.Transparent
        Me.DungeonLabel3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DungeonLabel3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.DungeonLabel3.Location = New System.Drawing.Point(31, 159)
        Me.DungeonLabel3.Name = "DungeonLabel3"
        Me.DungeonLabel3.Size = New System.Drawing.Size(72, 25)
        Me.DungeonLabel3.TabIndex = 9
        Me.DungeonLabel3.Text = "Lab No"
        '
        'DungeonLabel1
        '
        Me.DungeonLabel1.AutoSize = True
        Me.DungeonLabel1.BackColor = System.Drawing.Color.Transparent
        Me.DungeonLabel1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DungeonLabel1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.DungeonLabel1.Location = New System.Drawing.Point(31, 258)
        Me.DungeonLabel1.Name = "DungeonLabel1"
        Me.DungeonLabel1.Size = New System.Drawing.Size(81, 25)
        Me.DungeonLabel1.TabIndex = 10
        Me.DungeonLabel1.Text = "Case No"
        '
        'DungeonLabel4
        '
        Me.DungeonLabel4.AutoSize = True
        Me.DungeonLabel4.BackColor = System.Drawing.Color.Transparent
        Me.DungeonLabel4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DungeonLabel4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.DungeonLabel4.Location = New System.Drawing.Point(314, 42)
        Me.DungeonLabel4.Name = "DungeonLabel4"
        Me.DungeonLabel4.Size = New System.Drawing.Size(121, 25)
        Me.DungeonLabel4.TabIndex = 11
        Me.DungeonLabel4.Text = "Victim Name"
        '
        'DungeonLabel5
        '
        Me.DungeonLabel5.AutoSize = True
        Me.DungeonLabel5.BackColor = System.Drawing.Color.Transparent
        Me.DungeonLabel5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DungeonLabel5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.DungeonLabel5.Location = New System.Drawing.Point(314, 156)
        Me.DungeonLabel5.Name = "DungeonLabel5"
        Me.DungeonLabel5.Size = New System.Drawing.Size(146, 25)
        Me.DungeonLabel5.TabIndex = 12
        Me.DungeonLabel5.Text = "Examiner Name"
        '
        'DungeonLabel6
        '
        Me.DungeonLabel6.AutoSize = True
        Me.DungeonLabel6.BackColor = System.Drawing.Color.Transparent
        Me.DungeonLabel6.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DungeonLabel6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.DungeonLabel6.Location = New System.Drawing.Point(342, 255)
        Me.DungeonLabel6.Name = "DungeonLabel6"
        Me.DungeonLabel6.Size = New System.Drawing.Size(93, 25)
        Me.DungeonLabel6.TabIndex = 13
        Me.DungeonLabel6.Text = "Evidence "
        '
        'DungeonLabel7
        '
        Me.DungeonLabel7.AutoSize = True
        Me.DungeonLabel7.BackColor = System.Drawing.Color.Transparent
        Me.DungeonLabel7.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DungeonLabel7.ForeColor = System.Drawing.Color.DodgerBlue
        Me.DungeonLabel7.Location = New System.Drawing.Point(682, 45)
        Me.DungeonLabel7.Name = "DungeonLabel7"
        Me.DungeonLabel7.Size = New System.Drawing.Size(134, 25)
        Me.DungeonLabel7.TabIndex = 14
        Me.DungeonLabel7.Text = "Evidence Type"
        '
        'DungeonLabel8
        '
        Me.DungeonLabel8.AutoSize = True
        Me.DungeonLabel8.BackColor = System.Drawing.Color.Transparent
        Me.DungeonLabel8.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DungeonLabel8.ForeColor = System.Drawing.Color.DodgerBlue
        Me.DungeonLabel8.Location = New System.Drawing.Point(699, 157)
        Me.DungeonLabel8.Name = "DungeonLabel8"
        Me.DungeonLabel8.Size = New System.Drawing.Size(152, 25)
        Me.DungeonLabel8.TabIndex = 15
        Me.DungeonLabel8.Text = "Evidence Report"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(168, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(95, 26)
        Me.TextBox1.TabIndex = 16
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(133, 158)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(103, 26)
        Me.TextBox2.TabIndex = 17
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(122, 260)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 26)
        Me.TextBox3.TabIndex = 18
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(441, 41)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(192, 26)
        Me.TextBox4.TabIndex = 19
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(466, 159)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(218, 26)
        Me.TextBox5.TabIndex = 20
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(441, 260)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(243, 26)
        Me.TextBox6.TabIndex = 21
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(822, 45)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(246, 26)
        Me.TextBox7.TabIndex = 22
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(857, 161)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox8.Size = New System.Drawing.Size(224, 158)
        Me.TextBox8.TabIndex = 22
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(247, 248)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 61)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1318, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.EnteredColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button5.Image = Nothing
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.InactiveColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(1115, 58)
        Me.Button5.Name = "Button5"
        Me.Button5.PressedColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button5.Size = New System.Drawing.Size(107, 46)
        Me.Button5.TabIndex = 43
        Me.Button5.Text = "Edit"
        Me.Button5.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.EnteredColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button4.Image = Nothing
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.InactiveColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(1115, 279)
        Me.Button4.Name = "Button4"
        Me.Button4.PressedColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button4.Size = New System.Drawing.Size(120, 40)
        Me.Button4.TabIndex = 42
        Me.Button4.Text = "Update"
        Me.Button4.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.EnteredColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button3.Image = Nothing
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.InactiveColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(1245, 170)
        Me.Button3.Name = "Button3"
        Me.Button3.PressedColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button3.Size = New System.Drawing.Size(120, 40)
        Me.Button3.TabIndex = 41
        Me.Button3.Text = "Clear"
        Me.Button3.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.EnteredColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button2.Image = Nothing
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.InactiveColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(1115, 170)
        Me.Button2.Name = "Button2"
        Me.Button2.PressedColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button2.Size = New System.Drawing.Size(120, 40)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Insert"
        Me.Button2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Forensic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1377, 745)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DungeonLabel8)
        Me.Controls.Add(Me.DungeonLabel7)
        Me.Controls.Add(Me.DungeonLabel6)
        Me.Controls.Add(Me.DungeonLabel5)
        Me.Controls.Add(Me.DungeonLabel4)
        Me.Controls.Add(Me.DungeonLabel1)
        Me.Controls.Add(Me.DungeonLabel3)
        Me.Controls.Add(Me.DungeonLabel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Forensic"
        Me.Text = "Forensic"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ForensicreportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As ReaLTaiizor.Controls.Panel
    Friend WithEvents DataGridView1 As ReaLTaiizor.Controls.PoisonDataGridView
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents ForensicreportBindingSource As BindingSource
    Friend WithEvents ForensicreportTableAdapter As Database1DataSetTableAdapters.ForensicreportTableAdapter
    Friend WithEvents DungeonLabel2 As ReaLTaiizor.Controls.DungeonLabel
    Friend WithEvents DungeonLabel3 As ReaLTaiizor.Controls.DungeonLabel
    Friend WithEvents DungeonLabel1 As ReaLTaiizor.Controls.DungeonLabel
    Friend WithEvents DungeonLabel4 As ReaLTaiizor.Controls.DungeonLabel
    Friend WithEvents DungeonLabel5 As ReaLTaiizor.Controls.DungeonLabel
    Friend WithEvents DungeonLabel6 As ReaLTaiizor.Controls.DungeonLabel
    Friend WithEvents DungeonLabel7 As ReaLTaiizor.Controls.DungeonLabel
    Friend WithEvents DungeonLabel8 As ReaLTaiizor.Controls.DungeonLabel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button5 As ReaLTaiizor.Controls.Button
    Friend WithEvents Button4 As ReaLTaiizor.Controls.Button
    Friend WithEvents Button3 As ReaLTaiizor.Controls.Button
    Friend WithEvents Button2 As ReaLTaiizor.Controls.Button
    Friend WithEvents Fno As DataGridViewTextBoxColumn
    Friend WithEvents Lno As DataGridViewTextBoxColumn
    Friend WithEvents Cno As DataGridViewTextBoxColumn
    Friend WithEvents Vname As DataGridViewTextBoxColumn
    Friend WithEvents Ename As DataGridViewTextBoxColumn
    Friend WithEvents Evidence As DataGridViewTextBoxColumn
    Friend WithEvents Evidencetype As DataGridViewTextBoxColumn
    Friend WithEvents Ereport As DataGridViewTextBoxColumn
End Class
