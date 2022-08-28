Imports System.Data.SqlClient

Public Class Reset
    Dim counter As Integer
    Dim conn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Antony Biju\source\repos\ICMS\Database1.mdf;Integrated Security=True")
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim email As String
    Dim sql As String
    Dim uname As String
    Dim UId As String

    Private Sub ChatButtonLeft1_Click(sender As Object, e As EventArgs) Handles ChatButtonLeft1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub DreamButton1_Click(sender As Object, e As EventArgs) Handles DreamButton1.Click
        email = SmallTextBox1.Text
        Try
            sql = "select* from Login where Email='" & email & "'"
            cmd = New SqlCommand(sql, conn)
            conn.Open()
            dr = cmd.ExecuteReader()
            If (dr.Read) Then
                uname = dr("UserName")
                UId = dr("UserId")
                Resetform.TextBox1.Text = uname
                Resetform.id = UId
                Me.Hide()
                Resetform.Show()


            Else
                MessageBox.Show("Inavild Email Please Enter Again")


            End If
            conn.Close()




        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class