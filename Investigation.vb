Imports System.Data.SqlClient
Public Class Investigation
    Private Sub Investigation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Investigationreport' table. You can move, or remove it, as needed.
        Me.InvestigationreportTableAdapter.Fill(Me.Database1DataSet.Investigationreport)

        Dim conaccess As New SqlConnection
        DataGridView1.EditMode = False
        conaccess.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Antony Biju\source\repos\ICMS\Database1.mdf;Integrated Security=True"
        conaccess.Open()
        loadGrid()
        Me.BindGrid()
        DataGridView1.DataSource = InvestigationreportBindingSource

    End Sub
    Private Sub loadGrid()
        Dim conaccess As New SqlConnection
        conaccess.ConnectionString = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Antony Biju\source\repos\ICMS\Database1.mdf;Integrated Security=True")
        Dim access As String
        access = "select * from Investigationreport"
        Dim DataTab As New DataTable
        Dim DataAdap As New SqlDataAdapter(access, conaccess)
        DataAdap.Fill(DataTab)
        DataGridView1.DataSource = DataTab
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
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
            If (TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "") Then
                MessageBox.Show("Please Enter The Details")
            Else
                statement = "insert into Investigationreport VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "')"
                cmd = New SqlCommand(statement, con)
                cmd.ExecuteNonQuery()
                MsgBox("Inserted Successfully", MsgBoxStyle.Information, "succes")
            End If
            con.Close()
        Catch ex As SqlException
            MessageBox.Show("ENTER THE RIGHT DETAILS")
        Finally
            con.Dispose()

        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Antony Biju\source\repos\ICMS\Database1.mdf;Integrated Security=True"

        Dim con As New SqlConnection(str)

        Dim com As String = "Select Ino,Cno,Fno,Id,Incident,Crimedetails,Ereport,Suspectdetail,Summary from Investigationreport"

        Dim Adpt As New SqlDataAdapter(com, con)

        Dim ds As New DataSet()

        Adpt.Fill(ds, "Investigationreport")

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
        TextBox8.Clear()
        TextBox9.Clear()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            Try
                row = Me.DataGridView1.Rows(e.RowIndex)
                TextBox1.Text = row.Cells("Ino").Value.ToString
                TextBox2.Text = row.Cells("Cno").Value.ToString
                TextBox3.Text = row.Cells("Incident").Value.ToString
                TextBox4.Text = row.Cells("Crimedetails").Value.ToString
                TextBox5.Text = row.Cells("Ereport").Value.ToString
                TextBox6.Text = row.Cells("Suspectdetail").Value.ToString
                TextBox7.Text = row.Cells("Summary").Value.ToString
                TextBox8.Text = row.Cells("Fno").Value.ToString
                TextBox9.Text = row.Cells("Id").Value.ToString
            Catch ex As SqlException
                MessageBox.Show("RESTART THE PROGRAM PLEASE")
            Finally

            End Try
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim access As String
        Dim conn As New SqlConnection
        Dim cmd As New SqlCommand


        conn.ConnectionString = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Antony Biju\source\repos\ICMS\Database1.mdf;Integrated Security=True")
        Try
            conn.Open()
            access = "UPDATE Investigationreport SET Ino= '" & TextBox2.Text & "',Cno= '" & TextBox2.Text & "',Fno= '" & TextBox8.Text & "',Id= '" & TextBox9.Text & "' ,Incident = '" & TextBox3.Text & "', Crimedetails ='" & TextBox4.Text & "' , Ereport ='" & TextBox5.Text & "' , Suspectdetail = '" & TextBox6.Text & "',Summary ='" & TextBox7.Text & "' where Ino='" & TextBox1.Text & "'"
            Dim reader As SqlDataReader
            cmd = New SqlCommand(access, conn)
            reader = cmd.ExecuteReader
            MessageBox.Show("DATA UPDATED")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try


    End Sub
    Private Sub BindGrid()
        DataGridView1.DataSource = Nothing
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Antony Biju\source\repos\ICMS\Database1.mdf;Integrated Security=True")

            Using cmd As SqlCommand = New SqlCommand("SELECT Ino,Cno,Fno,Id,Incident,Crimedetails,Ereport,Suspectdetail,Summary FROM Investigationreport", con)
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
        DataGridView1.Columns.Insert(9, buttonColumn)
    End Sub
    Private Sub dataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 9 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            If MessageBox.Show(String.Format("Do you want to delete Ino: {0}", row.Cells("Id").Value), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Antony Biju\source\repos\ICMS\Database1.mdf;Integrated Security=True")
                    Using cmd As New SqlCommand("DELETE FROM Investigationreport WHERE Ino = @Ino", con)
                        cmd.CommandType = CommandType.Text
                        cmd.Parameters.AddWithValue("@Ino", row.Cells("Ino").Value)
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
        Dim sql As String = Nothing
        Dim b As New BindingSource
        b.DataSource = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Antony Biju\source\repos\ICMS\Database1.mdf;Integrated Security=True"
        sql = "select Cno from Policereport"
        InvestigationreportBindingSource.DataSource = b

        b.ResetBindings(False)
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Antony Biju\source\repos\ICMS\Database1.mdf;Integrated Security=True")

        Dim command As New SqlCommand("select * from Policereport where Cno = @Cno", connection)

        command.Parameters.Add("@Cno", SqlDbType.Int).Value = TextBox2.Text

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        TextBox3.Text = ""
        TextBox4.Text = ""


        If table.Rows.Count() > 0 Then

            ' return only 1 row
            TextBox3.Text = table.Rows(0)(3).ToString()
            TextBox4.Text = table.Rows(0)(5).ToString()


        Else

            MessageBox.Show("NO Data Found")

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Antony Biju\source\repos\ICMS\Database1.mdf;Integrated Security=True")

        Dim command As New SqlCommand("select * from Forensicreport where Fno = @Fno", connection)

        command.Parameters.Add("@Fno", SqlDbType.Int).Value = TextBox8.Text

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        TextBox5.Text = ""



        If table.Rows.Count() > 0 Then

            TextBox5.Text = table.Rows(0)(7).ToString()



        Else

            MessageBox.Show("NO Data Found")

        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Antony Biju\source\repos\ICMS\Database1.mdf;Integrated Security=True")

        Dim command As New SqlCommand("select * from Suspectreport where Id = @Id", connection)

        command.Parameters.Add("@Id", SqlDbType.Int).Value = TextBox9.Text

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        TextBox6.Text = ""



        If table.Rows.Count() > 0 Then

            TextBox6.Text = table.Rows(0)(5).ToString()



        Else

            MessageBox.Show("NO Data Found")

        End If
    End Sub
End Class
