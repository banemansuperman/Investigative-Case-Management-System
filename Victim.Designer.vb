<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Victim
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Victim))
        Me.Panel1 = New ReaLTaiizor.Controls.Panel()
        Me.DataGridView1 = New ReaLTaiizor.Controls.PoisonDataGridView()
        Me.Vno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Occupation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VictimreportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New ICMS.Database1DataSet()
        Me.DungeonLabel1 = New ReaLTaiizor.Controls.DungeonLabel()
        Me.DungeonLabel2 = New ReaLTaiizor.Controls.DungeonLabel()
        Me.DungeonLabel3 = New ReaLTaiizor.Controls.DungeonLabel()
        Me.DungeonLabel4 = New ReaLTaiizor.Controls.DungeonLabel()
        Me.DungeonLabel5 = New ReaLTaiizor.Controls.DungeonLabel()
        Me.DungeonLabel6 = New ReaLTaiizor.Controls.DungeonLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New ReaLTaiizor.Controls.Button()
        Me.Button4 = New ReaLTaiizor.Controls.Button()
        Me.Button3 = New ReaLTaiizor.Controls.Button()
        Me.Button2 = New ReaLTaiizor.Controls.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.VictimreportTableAdapter = New ICMS.Database1DataSetTableAdapters.VictimreportTableAdapter()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VictimreportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cyan
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.EdgeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(312, 403)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(694, 290)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Vno, Me.Cno, Me.Vname, Me.Address, Me.DOB, Me.Occupation})
        Me.DataGridView1.DataSource = Me.VictimreportBindingSource
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
        Me.DataGridView1.Size = New System.Drawing.Size(684, 280)
        Me.DataGridView1.TabIndex = 0
        '
        'Vno
        '
        Me.Vno.DataPropertyName = "Vno"
        Me.Vno.HeaderText = "Vno"
        Me.Vno.MinimumWidth = 6
        Me.Vno.Name = "Vno"
        Me.Vno.Width = 125
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
        'Address
        '
        Me.Address.DataPropertyName = "Address"
        Me.Address.HeaderText = "Address"
        Me.Address.MinimumWidth = 6
        Me.Address.Name = "Address"
        Me.Address.Width = 125
        '
        'DOB
        '
        Me.DOB.DataPropertyName = "DOB"
        Me.DOB.HeaderText = "DOB"
        Me.DOB.MinimumWidth = 6
        Me.DOB.Name = "DOB"
        Me.DOB.Width = 125
        '
        'Occupation
        '
        Me.Occupation.DataPropertyName = "Occupation"
        Me.Occupation.HeaderText = "Occupation"
        Me.Occupation.MinimumWidth = 6
        Me.Occupation.Name = "Occupation"
        Me.Occupation.Width = 125
        '
        'VictimreportBindingSource
        '
        Me.VictimreportBindingSource.DataMember = "Victimreport"
        Me.VictimreportBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DungeonLabel1
        '
        Me.DungeonLabel1.AutoSize = True
        Me.DungeonLabel1.BackColor = System.Drawing.Color.Transparent
        Me.DungeonLabel1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.DungeonLabel1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.DungeonLabel1.Location = New System.Drawing.Point(76, 50)
        Me.DungeonLabel1.Name = "DungeonLabel1"
        Me.DungeonLabel1.Size = New System.Drawing.Size(45, 25)
        Me.DungeonLabel1.TabIndex = 1
        Me.DungeonLabel1.Text = "Vno"
        '
        'DungeonLabel2
        '
        Me.DungeonLabel2.AutoSize = True
        Me.DungeonLabel2.BackColor = System.Drawing.Color.Transparent
        Me.DungeonLabel2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.DungeonLabel2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.DungeonLabel2.Location = New System.Drawing.Point(76, 165)
        Me.DungeonLabel2.Name = "DungeonLabel2"
        Me.DungeonLabel2.Size = New System.Drawing.Size(45, 25)
        Me.DungeonLabel2.TabIndex = 2
        Me.DungeonLabel2.Text = "Cno"
        '
        'DungeonLabel3
        '
        Me.DungeonLabel3.AutoSize = True
        Me.DungeonLabel3.BackColor = System.Drawing.Color.Transparent
        Me.DungeonLabel3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.DungeonLabel3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.DungeonLabel3.Location = New System.Drawing.Point(490, 50)
        Me.DungeonLabel3.Name = "DungeonLabel3"
        Me.DungeonLabel3.Size = New System.Drawing.Size(80, 25)
        Me.DungeonLabel3.TabIndex = 3
        Me.DungeonLabel3.Text = "Address"
        '
        'DungeonLabel4
        '
        Me.DungeonLabel4.AutoSize = True
        Me.DungeonLabel4.BackColor = System.Drawing.Color.Transparent
        Me.DungeonLabel4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.DungeonLabel4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.DungeonLabel4.Location = New System.Drawing.Point(490, 165)
        Me.DungeonLabel4.Name = "DungeonLabel4"
        Me.DungeonLabel4.Size = New System.Drawing.Size(51, 25)
        Me.DungeonLabel4.TabIndex = 4
        Me.DungeonLabel4.Text = "DOB"
        '
        'DungeonLabel5
        '
        Me.DungeonLabel5.AutoSize = True
        Me.DungeonLabel5.BackColor = System.Drawing.Color.Transparent
        Me.DungeonLabel5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.DungeonLabel5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.DungeonLabel5.Location = New System.Drawing.Point(487, 307)
        Me.DungeonLabel5.Name = "DungeonLabel5"
        Me.DungeonLabel5.Size = New System.Drawing.Size(110, 25)
        Me.DungeonLabel5.TabIndex = 5
        Me.DungeonLabel5.Text = "Occupation"
        '
        'DungeonLabel6
        '
        Me.DungeonLabel6.AutoSize = True
        Me.DungeonLabel6.BackColor = System.Drawing.Color.Transparent
        Me.DungeonLabel6.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.DungeonLabel6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.DungeonLabel6.Location = New System.Drawing.Point(59, 289)
        Me.DungeonLabel6.Name = "DungeonLabel6"
        Me.DungeonLabel6.Size = New System.Drawing.Size(62, 25)
        Me.DungeonLabel6.TabIndex = 6
        Me.DungeonLabel6.Text = "Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1261, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
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
        Me.Button5.Location = New System.Drawing.Point(1005, 67)
        Me.Button5.Name = "Button5"
        Me.Button5.PressedColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button5.Size = New System.Drawing.Size(107, 46)
        Me.Button5.TabIndex = 31
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
        Me.Button4.Location = New System.Drawing.Point(1005, 307)
        Me.Button4.Name = "Button4"
        Me.Button4.PressedColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button4.Size = New System.Drawing.Size(120, 40)
        Me.Button4.TabIndex = 30
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
        Me.Button3.Location = New System.Drawing.Point(1193, 190)
        Me.Button3.Name = "Button3"
        Me.Button3.PressedColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button3.Size = New System.Drawing.Size(120, 40)
        Me.Button3.TabIndex = 29
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
        Me.Button2.Location = New System.Drawing.Point(1005, 190)
        Me.Button2.Name = "Button2"
        Me.Button2.PressedColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button2.Size = New System.Drawing.Size(120, 40)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Insert"
        Me.Button2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(281, 146)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 61)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.Location = New System.Drawing.Point(149, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 34
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox2.Location = New System.Drawing.Point(149, 162)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 26)
        Me.TextBox2.TabIndex = 35
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox3.Location = New System.Drawing.Point(149, 288)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(178, 26)
        Me.TextBox3.TabIndex = 36
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox4.Location = New System.Drawing.Point(625, 49)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox4.Size = New System.Drawing.Size(207, 87)
        Me.TextBox4.TabIndex = 37
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox6.Location = New System.Drawing.Point(621, 309)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(188, 26)
        Me.TextBox6.TabIndex = 39
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox5.Location = New System.Drawing.Point(621, 167)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(104, 26)
        Me.TextBox5.TabIndex = 40
        '
        'VictimreportTableAdapter
        '
        Me.VictimreportTableAdapter.ClearBeforeFill = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(559, 235)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 41
        '
        'Victim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1325, 715)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DungeonLabel6)
        Me.Controls.Add(Me.DungeonLabel5)
        Me.Controls.Add(Me.DungeonLabel4)
        Me.Controls.Add(Me.DungeonLabel3)
        Me.Controls.Add(Me.DungeonLabel2)
        Me.Controls.Add(Me.DungeonLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Victim"
        Me.Text = "Victim"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VictimreportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As ReaLTaiizor.Controls.Panel
    Friend WithEvents DungeonLabel1 As ReaLTaiizor.Controls.DungeonLabel
    Friend WithEvents DungeonLabel2 As ReaLTaiizor.Controls.DungeonLabel
    Friend WithEvents DungeonLabel3 As ReaLTaiizor.Controls.DungeonLabel
    Friend WithEvents DungeonLabel4 As ReaLTaiizor.Controls.DungeonLabel
    Friend WithEvents DungeonLabel5 As ReaLTaiizor.Controls.DungeonLabel
    Friend WithEvents DungeonLabel6 As ReaLTaiizor.Controls.DungeonLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button5 As ReaLTaiizor.Controls.Button
    Friend WithEvents Button4 As ReaLTaiizor.Controls.Button
    Friend WithEvents Button3 As ReaLTaiizor.Controls.Button
    Friend WithEvents Button2 As ReaLTaiizor.Controls.Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents DataGridView1 As ReaLTaiizor.Controls.PoisonDataGridView
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents VictimreportBindingSource As BindingSource
    Friend WithEvents VictimreportTableAdapter As Database1DataSetTableAdapters.VictimreportTableAdapter
    Friend WithEvents Vno As DataGridViewTextBoxColumn
    Friend WithEvents Cno As DataGridViewTextBoxColumn
    Friend WithEvents Vname As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents DOB As DataGridViewTextBoxColumn
    Friend WithEvents Occupation As DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
