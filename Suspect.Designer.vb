<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Suspect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Suspect))
        Me.Panel1 = New ReaLTaiizor.Controls.Panel()
        Me.DataGridView1 = New ReaLTaiizor.Controls.PoisonDataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Witnessdesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Suspectdetail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuspectreportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New ICMS.Database1DataSet()
        Me.SuspectreportTableAdapter = New ICMS.Database1DataSetTableAdapters.SuspectreportTableAdapter()
        Me.DungeonLabel1 = New ReaLTaiizor.Controls.DungeonLabel()
        Me.DungeonLabel2 = New ReaLTaiizor.Controls.DungeonLabel()
        Me.DungeonLabel3 = New ReaLTaiizor.Controls.DungeonLabel()
        Me.DungeonLabel4 = New ReaLTaiizor.Controls.DungeonLabel()
        Me.DungeonLabel5 = New ReaLTaiizor.Controls.DungeonLabel()
        Me.DungeonLabel7 = New ReaLTaiizor.Controls.DungeonLabel()
        Me.DungeonLabel8 = New ReaLTaiizor.Controls.DungeonLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New ReaLTaiizor.Controls.Button()
        Me.Button4 = New ReaLTaiizor.Controls.Button()
        Me.Button3 = New ReaLTaiizor.Controls.Button()
        Me.Button2 = New ReaLTaiizor.Controls.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.DungeonLinkLabel1 = New ReaLTaiizor.Controls.DungeonLinkLabel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuspectreportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cyan
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.EdgeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(171, 355)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(948, 377)
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Cno, Me.Vname, Me.DateData, Me.Witnessdesc, Me.Suspectdetail, Me.LastLocation})
        Me.DataGridView1.DataSource = Me.SuspectreportBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(5, 5)
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
        Me.DataGridView1.Size = New System.Drawing.Size(938, 367)
        Me.DataGridView1.TabIndex = 0
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Id"
        Me.Id.MinimumWidth = 6
        Me.Id.Name = "Id"
        Me.Id.Width = 125
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
        'DateData
        '
        Me.DateData.DataPropertyName = "Date"
        Me.DateData.HeaderText = "Date"
        Me.DateData.MinimumWidth = 6
        Me.DateData.Name = "DateData"
        Me.DateData.Width = 125
        '
        'Witnessdesc
        '
        Me.Witnessdesc.DataPropertyName = "Witnessdesc"
        Me.Witnessdesc.HeaderText = "Witnessdesc"
        Me.Witnessdesc.MinimumWidth = 6
        Me.Witnessdesc.Name = "Witnessdesc"
        Me.Witnessdesc.Width = 125
        '
        'Suspectdetail
        '
        Me.Suspectdetail.DataPropertyName = "Suspectdetail"
        Me.Suspectdetail.HeaderText = "Suspectdetail"
        Me.Suspectdetail.MinimumWidth = 6
        Me.Suspectdetail.Name = "Suspectdetail"
        Me.Suspectdetail.Width = 125
        '
        'LastLocation
        '
        Me.LastLocation.DataPropertyName = "LastLocation"
        Me.LastLocation.HeaderText = "LastLocation"
        Me.LastLocation.MinimumWidth = 6
        Me.LastLocation.Name = "LastLocation"
        Me.LastLocation.Width = 125
        '
        'SuspectreportBindingSource
        '
        Me.SuspectreportBindingSource.DataMember = "Suspectreport"
        Me.SuspectreportBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SuspectreportTableAdapter
        '
        Me.SuspectreportTableAdapter.ClearBeforeFill = True
        '
        'DungeonLabel1
        '
        Me.DungeonLabel1.AutoSize = True
        Me.DungeonLabel1.BackColor = System.Drawing.Color.Transparent
        Me.DungeonLabel1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DungeonLabel1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.DungeonLabel1.Location = New System.Drawing.Point(43, 33)
        Me.DungeonLabel1.Name = "DungeonLabel1"
        Me.DungeonLabel1.Size = New System.Drawing.Size(29, 25)
        Me.DungeonLabel1.TabIndex = 8
        Me.DungeonLabel1.Text = "Id"
        '
        'DungeonLabel2
        '
        Me.DungeonLabel2.AutoSize = True
        Me.DungeonLabel2.BackColor = System.Drawing.Color.Transparent
        Me.DungeonLabel2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DungeonLabel2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.DungeonLabel2.Location = New System.Drawing.Point(43, 115)
        Me.DungeonLabel2.Name = "DungeonLabel2"
        Me.DungeonLabel2.Size = New System.Drawing.Size(81, 25)
        Me.DungeonLabel2.TabIndex = 9
        Me.DungeonLabel2.Text = "Case No"
        '
        'DungeonLabel3
        '
        Me.DungeonLabel3.AutoSize = True
        Me.DungeonLabel3.BackColor = System.Drawing.Color.Transparent
        Me.DungeonLabel3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DungeonLabel3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.DungeonLabel3.Location = New System.Drawing.Point(43, 238)
        Me.DungeonLabel3.Name = "DungeonLabel3"
        Me.DungeonLabel3.Size = New System.Drawing.Size(121, 25)
        Me.DungeonLabel3.TabIndex = 10
        Me.DungeonLabel3.Text = "Victim Name"
        '
        'DungeonLabel4
        '
        Me.DungeonLabel4.AutoSize = True
        Me.DungeonLabel4.BackColor = System.Drawing.Color.Transparent
        Me.DungeonLabel4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DungeonLabel4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.DungeonLabel4.Location = New System.Drawing.Point(348, 104)
        Me.DungeonLabel4.Name = "DungeonLabel4"
        Me.DungeonLabel4.Size = New System.Drawing.Size(119, 25)
        Me.DungeonLabel4.TabIndex = 11
        Me.DungeonLabel4.Text = "WitnessDesc"
        '
        'DungeonLabel5
        '
        Me.DungeonLabel5.AutoSize = True
        Me.DungeonLabel5.BackColor = System.Drawing.Color.Transparent
        Me.DungeonLabel5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DungeonLabel5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.DungeonLabel5.Location = New System.Drawing.Point(665, 33)
        Me.DungeonLabel5.Name = "DungeonLabel5"
        Me.DungeonLabel5.Size = New System.Drawing.Size(119, 25)
        Me.DungeonLabel5.TabIndex = 12
        Me.DungeonLabel5.Text = "LastLocation"
        '
        'DungeonLabel7
        '
        Me.DungeonLabel7.AutoSize = True
        Me.DungeonLabel7.BackColor = System.Drawing.Color.Transparent
        Me.DungeonLabel7.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DungeonLabel7.ForeColor = System.Drawing.Color.DodgerBlue
        Me.DungeonLabel7.Location = New System.Drawing.Point(348, 238)
        Me.DungeonLabel7.Name = "DungeonLabel7"
        Me.DungeonLabel7.Size = New System.Drawing.Size(133, 25)
        Me.DungeonLabel7.TabIndex = 14
        Me.DungeonLabel7.Text = "Suspect Detail"
        '
        'DungeonLabel8
        '
        Me.DungeonLabel8.AutoSize = True
        Me.DungeonLabel8.BackColor = System.Drawing.Color.Transparent
        Me.DungeonLabel8.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DungeonLabel8.ForeColor = System.Drawing.Color.DodgerBlue
        Me.DungeonLabel8.Location = New System.Drawing.Point(348, 33)
        Me.DungeonLabel8.Name = "DungeonLabel8"
        Me.DungeonLabel8.Size = New System.Drawing.Size(52, 25)
        Me.DungeonLabel8.TabIndex = 15
        Me.DungeonLabel8.Text = "Date"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(244, 104)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 61)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1291, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
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
        Me.Button5.Location = New System.Drawing.Point(1075, 89)
        Me.Button5.Name = "Button5"
        Me.Button5.PressedColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button5.Size = New System.Drawing.Size(107, 46)
        Me.Button5.TabIndex = 38
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
        Me.Button4.Location = New System.Drawing.Point(1075, 278)
        Me.Button4.Name = "Button4"
        Me.Button4.PressedColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button4.Size = New System.Drawing.Size(120, 40)
        Me.Button4.TabIndex = 37
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
        Me.Button3.Location = New System.Drawing.Point(1227, 187)
        Me.Button3.Name = "Button3"
        Me.Button3.PressedColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button3.Size = New System.Drawing.Size(120, 40)
        Me.Button3.TabIndex = 36
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
        Me.Button2.Location = New System.Drawing.Point(1075, 187)
        Me.Button2.Name = "Button2"
        Me.Button2.PressedColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button2.Size = New System.Drawing.Size(120, 40)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Insert"
        Me.Button2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.Location = New System.Drawing.Point(108, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 40
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox2.Location = New System.Drawing.Point(130, 117)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 26)
        Me.TextBox2.TabIndex = 41
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox4.Location = New System.Drawing.Point(454, 49)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(111, 26)
        Me.TextBox4.TabIndex = 42
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox3.Location = New System.Drawing.Point(176, 240)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 26)
        Me.TextBox3.TabIndex = 43
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox5.Location = New System.Drawing.Point(482, 106)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox5.Size = New System.Drawing.Size(261, 102)
        Me.TextBox5.TabIndex = 44
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox6.Location = New System.Drawing.Point(496, 240)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox6.Size = New System.Drawing.Size(288, 87)
        Me.TextBox6.TabIndex = 45
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox7.Location = New System.Drawing.Point(790, 32)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox7.Size = New System.Drawing.Size(219, 97)
        Me.TextBox7.TabIndex = 46
        '
        'DungeonLinkLabel1
        '
        Me.DungeonLinkLabel1.ActiveLinkColor = System.Drawing.Color.Lime
        Me.DungeonLinkLabel1.AutoSize = True
        Me.DungeonLinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.DungeonLinkLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.DungeonLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.DungeonLinkLabel1.LinkColor = System.Drawing.Color.DodgerBlue
        Me.DungeonLinkLabel1.Location = New System.Drawing.Point(1070, 30)
        Me.DungeonLinkLabel1.Name = "DungeonLinkLabel1"
        Me.DungeonLinkLabel1.Size = New System.Drawing.Size(198, 25)
        Me.DungeonLinkLabel1.TabIndex = 47
        Me.DungeonLinkLabel1.TabStop = True
        Me.DungeonLinkLabel1.Text = "Enter Witness Details?"
        Me.DungeonLinkLabel1.VisitedLinkColor = System.Drawing.Color.LimeGreen
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(406, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 48
        '
        'Suspect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1356, 744)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DungeonLinkLabel1)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.DungeonLabel8)
        Me.Controls.Add(Me.DungeonLabel7)
        Me.Controls.Add(Me.DungeonLabel5)
        Me.Controls.Add(Me.DungeonLabel4)
        Me.Controls.Add(Me.DungeonLabel3)
        Me.Controls.Add(Me.DungeonLabel2)
        Me.Controls.Add(Me.DungeonLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Suspect"
        Me.Text = "Suspect"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuspectreportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As ReaLTaiizor.Controls.Panel
    Friend WithEvents DataGridView1 As ReaLTaiizor.Controls.PoisonDataGridView
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents SuspectreportBindingSource As BindingSource
    Friend WithEvents SuspectreportTableAdapter As Database1DataSetTableAdapters.SuspectreportTableAdapter
    Friend WithEvents DungeonLabel1 As ReaLTaiizor.Controls.DungeonLabel
    Friend WithEvents DungeonLabel2 As ReaLTaiizor.Controls.DungeonLabel
    Friend WithEvents DungeonLabel3 As ReaLTaiizor.Controls.DungeonLabel
    Friend WithEvents DungeonLabel4 As ReaLTaiizor.Controls.DungeonLabel
    Friend WithEvents DungeonLabel5 As ReaLTaiizor.Controls.DungeonLabel
    Friend WithEvents DungeonLabel7 As ReaLTaiizor.Controls.DungeonLabel
    Friend WithEvents DungeonLabel8 As ReaLTaiizor.Controls.DungeonLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button5 As ReaLTaiizor.Controls.Button
    Friend WithEvents Button4 As ReaLTaiizor.Controls.Button
    Friend WithEvents Button3 As ReaLTaiizor.Controls.Button
    Friend WithEvents Button2 As ReaLTaiizor.Controls.Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Cno As DataGridViewTextBoxColumn
    Friend WithEvents Vname As DataGridViewTextBoxColumn
    Friend WithEvents DateData As DataGridViewTextBoxColumn
    Friend WithEvents Witnessdesc As DataGridViewTextBoxColumn
    Friend WithEvents Suspectdetail As DataGridViewTextBoxColumn
    Friend WithEvents LastLocation As DataGridViewTextBoxColumn
    Friend WithEvents DungeonLinkLabel1 As ReaLTaiizor.Controls.DungeonLinkLabel
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
