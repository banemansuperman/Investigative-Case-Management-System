Imports System.Data.SqlClient
Public Class Printwitness
    Private Sub NightButton1_Click(sender As Object, e As EventArgs) Handles NightButton1.Click
        PrintDocument1.PrinterSettings.PrinterName = My.Settings.printer
        PrintDocument1.Print()
    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim dm As New Bitmap(Me.Policereport.Width, Me.Policereport.Height)
        Policereport.DrawToBitmap(dm, New Rectangle(0, 0, Me.Policereport.Width, Me.Policereport.Height))
        e.Graphics.DrawImage(dm, 0, 0)
        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub NightLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles NightLinkLabel1.LinkClicked
        Me.NightButton1.Enabled = True
        Chooseprinter.ShowDialog()
    End Sub

    Private Sub Printwitness_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.NightButton1.Enabled = False
        TextBox1.Hide()
        TextBox3.Hide()
        TextBox2.Hide()

        TextBox7.Hide()
        TextBox8.Hide()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Antony Biju\source\repos\ICMS\Database1.mdf;Integrated Security=True")

        Dim command As New SqlCommand("select * from Witnessreport where Wno = @Wno", connection)



        command.Parameters.Add("@Wno", SqlDbType.Int).Value = SmallTextBox1.Text

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()
        Try
            adapter.Fill(table)
            TextBox1.Text = "" 'id
            TextBox3.Text = "" 'address
            TextBox2.Text = "" 'wname

            TextBox7.Text = "" 'Witness desc
            TextBox8.Text = "" 'Phoneno



            If table.Rows.Count() > 0 Then

                ' return only 1 row
                TextBox1.Text = table.Rows(0)(1).ToString()
                TextBox3.Text = table.Rows(0)(4).ToString()
                TextBox2.Text = table.Rows(0)(2).ToString()

                TextBox7.Text = table.Rows(0)(5).ToString()
                TextBox8.Text = table.Rows(0)(3).ToString()


            Else

                MessageBox.Show("NO Data Found")

            End If
        Catch ex As Exception
            MessageBox.Show("PLEASE ENTER THE RIGHT VALUE")
        Finally
            connection.Dispose()

        End Try
        TextBox1.Show()
        TextBox3.Show()
        TextBox2.Show()

        TextBox7.Show()
        TextBox8.Show()
    End Sub

    Private Sub ToggleButton1_ToggledChanged() Handles ToggleButton1.ToggledChanged
        TextBox1.Hide()
        TextBox3.Hide()
        TextBox2.Hide()

        TextBox7.Hide()
        TextBox8.Hide()

    End Sub
End Class