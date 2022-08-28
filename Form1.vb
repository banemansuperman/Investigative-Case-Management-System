Imports System.Data.SqlClient
'
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'forgot password?
    Private Sub DungeonLinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DungeonLinkLabel2.LinkClicked
        Me.Hide()
        Reset.Show()
    End Sub
    'create new accountt
    Private Sub DungeonLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DungeonLinkLabel1.LinkClicked
        Me.Hide()
        Register.Show()
    End Sub
    'login
    Private Sub ButtonLeft2_Click(sender As Object, e As EventArgs) Handles ButtonLeft2.Click
        Dim connection As New SqlConnection
        Dim command As New SqlCommand
        If TextBox1.Text.Length <= 0 Then
            MessageBox.Show("Please enter Username!")
        ElseIf TextBox2.Text.Length <= 0 Then
            MessageBox.Show("Please enter Password!")
        End If
        Dim str As String = " Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Antony Biju\source\repos\ICMS\Database1.mdf;Integrated Security=True"
        Dim sql As String = "select count(*) from Login where UserName=@UserName and Password=@Password"
        Using Conn As New SqlConnection(str)
            Using cmd As New SqlCommand(sql, Conn)
                Conn.Open()
                cmd.Parameters.AddWithValue("@UserName", TextBox1.Text)
                cmd.Parameters.AddWithValue("@Password", TextBox2.Text)
                Dim value = cmd.ExecuteScalar()
                If value > 0 Then

                    Me.Hide()
                    Home.Show()
                Else
                    MessageBox.Show("ACCESS DENIED")
                End If
            End Using

        End Using
    End Sub

    Private Sub NightButton1_Click(sender As Object, e As EventArgs) Handles NightButton1.Click
        Application.Exit()

    End Sub
End Class
