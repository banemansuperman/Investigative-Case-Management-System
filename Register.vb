Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Public Class Register
    Private Sub DreamButton2_Click(sender As Object, e As EventArgs) Handles DreamButton2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub DreamButton1_Click(sender As Object, e As EventArgs) Handles DreamButton1.Click
        Auto()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim statement As String
        con.ConnectionString = " Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Antony Biju\source\repos\ICMS\Database1.mdf;Integrated Security=True"
        con.Open()
        If (TextBox4.Text = "" Or TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "") Then
            MessageBox.Show("PLEASE ENTER THE DETAILS")
        Else
            statement = "insert into Login VALUES('" & TextBox4.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
            cmd = New SqlCommand(statement, con)
            cmd.ExecuteNonQuery()
            MsgBox("USER DETAILS INSERTED SUCCESFULLY", MsgBoxStyle.Information, "succes")
        End If

        con.Close()

    End Sub
    Public Sub auto()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim num As Integer
        con.ConnectionString = " Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Antony Biju\source\repos\ICMS\Database1.mdf;Integrated Security=True"
        con.Open()
        cmd = New SqlCommand("select max(UserId)from Login", con)
        cmd.ExecuteNonQuery()
        If IsDBNull(cmd.ExecuteScalar) Then
            num = 1
            TextBox4.Text = num
        End If
        con.Close()

    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Hide()
        TextBox4.Hide()
    End Sub
End Class