Imports System.Data.SqlClient
Public Class Suspect
    Private Sub Suspect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conaccess As New SqlConnection
        DataGridView1.EditMode = False
        conaccess.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Antony Biju\source\repos\ICMS\Database1.mdf;Integrated Security=True"
        conaccess.Open()
        loadGrid()
        DateTimePicker1.MaxDate = DateTime.Now

        Me.BindGrid()
        DataGridView1.DataSource = SuspectreportBindingSource
        'TODO: This line of code loads data into the 'Database1DataSet.Suspectreport' table. You can move, or remove it, as needed.
        Me.SuspectreportTableAdapter.Fill(Me.Database1DataSet.Suspectreport)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim statement As String
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Antony Biju\source\repos\ICMS\Database1.mdf;Integrated Security=True"
        con.Open()
        Try
            If (TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "") Then
                MessageBox.Show("please enter the details")
            Else
                statement = "insert into Suspectreport VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "')"
                cmd = New SqlCommand(statement, con)
                cmd.ExecuteNonQuery()
                MsgBox("Details Inserted Successfully", MsgBoxStyle.Information, "succes")
            End If

            con.Close()
        Catch ex As SqlException
            MessageBox.Show("ENTER THE RIGHT DETAILS")
        Finally
            con.Dispose()

        End Try
    End Sub
    Private Sub loadGrid()
        Dim conaccess As New SqlConnection
        conaccess.ConnectionString = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Antony Biju\source\repos\ICMS\Database1.mdf;Integrated Security=True")
        Dim access As String
        access = "select * from Suspectreport"
        Dim DataTab As New DataTable
        Dim DataAdap As New SqlDataAdapter(access, conaccess)
        DataAdap.Fill(DataTab)
        DataGridView1.DataSource = DataTab
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Antony Biju\source\repos\ICMS\Database1.mdf;Integrated Security=True"
        Dim con As New SqlConnection(str)

        Dim com As String = "Select Id,Cno,Vname,Date,Witnessdesc,Suspectdetail,Lastlocation from Suspectreport"

        Dim Adpt As New SqlDataAdapter(com, con)

        Dim ds As New DataSet()

        Adpt.Fill(ds, "Suspectreport")

        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("Id").Value.ToString
            TextBox2.Text = row.Cells("Cno").Value.ToString
            TextBox3.Text = row.Cells("Vname").Value.ToString
            TextBox4.Text = row.Cells("DateData").Value.ToString
            TextBox5.Text = row.Cells("Witnessdesc").Value.ToString
            TextBox6.Text = row.Cells("Suspectdetail").Value.ToString
            TextBox7.Text = row.Cells("Lastlocation").Value.ToString
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim access As String
        Dim conn As New SqlConnection
        Dim cmd As New SqlCommand


        conn.ConnectionString = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Antony Biju\source\repos\ICMS\Database1.mdf;Integrated Security=True")
        Try
            conn.Open()
            access = "UPDATE Suspectreport SET Id = '" & TextBox1.Text & "',Cno = '" & TextBox2.Text & "', Vname = '" & TextBox3.Text & "', Date ='" & TextBox4.Text & "' , Witnessdesc ='" & TextBox5.Text & "' , Suspectdetail = '" & TextBox6.Text & "',Lastlocation ='" & TextBox7.Text & "' where Id='" & TextBox1.Text & "'"
            Dim reader As SqlDataReader
            cmd = New SqlCommand(access, conn)
            reader = cmd.ExecuteReader
            MessageBox.Show("DATA UPDATED")
            conn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()

        End Try


    End Sub
    Private Sub BindGrid()
        DataGridView1.DataSource = Nothing
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Antony Biju\source\repos\ICMS\Database1.mdf;Integrated Security=True")

            Using cmd As SqlCommand = New SqlCommand("SELECT Id,Cno,Vname,Date,Witnessdesc,Suspectdetail,Lastlocation FROM Suspectreport", con)
                cmd.CommandType = CommandType.Text
                Using sda As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Using dt As DataTable = New DataTable()
                        sda.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using

        'Add the Button Column.
        Dim buttonColumn As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        buttonColumn.HeaderText = ""
        buttonColumn.Width = 60
        buttonColumn.Name = "buttonColumn"
        buttonColumn.Text = "Delete"
        buttonColumn.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Insert(7, buttonColumn)
    End Sub
    Private Sub dataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 7 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            If MessageBox.Show(String.Format("Do you want to delete Id: {0}", row.Cells("Id").Value), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Antony Biju\source\repos\ICMS\Database1.mdf;Integrated Security=True")
                    Using cmd As New SqlCommand("DELETE FROM Suspectreport WHERE Id = @Id", con)
                        cmd.CommandType = CommandType.Text
                        cmd.Parameters.AddWithValue("@Id", row.Cells("Id").Value)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using

                Me.BindGrid()
            End If
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Antony Biju\source\repos\ICMS\Database1.mdf;Integrated Security=True")

        Dim command As New SqlCommand("select * from Policereport where Cno = @Cno", connection)

        command.Parameters.Add("@Cno", SqlDbType.Int).Value = TextBox2.Text

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()
        Try
            adapter.Fill(table)

            TextBox3.Text = ""
            TextBox4.Text = ""


            If table.Rows.Count() > 0 Then

                ' return only 1 row
                TextBox3.Text = table.Rows(0)(2).ToString()
                TextBox4.Text = table.Rows(0)(6).ToString()

            Else

                MessageBox.Show("NO Data Found")

            End If
        Catch ex As Exception
            MessageBox.Show("PLEASE ENTER THE RIGHT VALUE")
        Finally
            connection.Dispose()

        End Try
    End Sub

    Private Sub DungeonLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DungeonLinkLabel1.LinkClicked
        Me.Hide()
        Witness.Show()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTime.Now.ToString("yyyy-MM-dd")
        TextBox4.Text = DateTimePicker1.Value.ToShortDateString()
    End Sub
End Class