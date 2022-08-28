Imports System.Data.SqlClient
Public Class Resetform
    Dim conn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Antony Biju\source\repos\ICMS\Database1.mdf;Integrated Security=True")
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim email As String
    Dim sql As String
    Public id As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Textpass.Text <> TextConfirm.Text) Then
            MessageBox.Show("Password are not Equals Please check again And Try", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Textpass.Text = ""
            TextConfirm.Text = ""
            Textpass.Focus()

        Else
            sql = "Update Login Set Password='" & TextConfirm.Text & "' where UserId='" & id & "'"
            cmd = New SqlCommand(sql, conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            If (cmd.ExecuteNonQuery) Then
                MessageBox.Show("Password Succesfully Changed Please Login Again", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Application.Restart()
                Form1.Show()

            End If


        End If
    End Sub
End Class