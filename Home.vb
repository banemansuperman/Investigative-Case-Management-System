Imports System.IO
Public Class Home
    Dim m As MsgBoxResult
    Dim t As String

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel3.Visible = False
        Panel4.Visible = False
        Dim m1 As MsgBoxResult
        t = MonthCalendar2.SelectionRange.Start.Month.ToString & MonthCalendar2.SelectionRange.Start.Day.ToString
        If Date.Today = MonthCalendar2.TodayDate And File.Exists(t & ".txt") = True Then
            m1 = MsgBox("YOU HAVE APPOINTMENTS SET FOR THE DAY WOULD U LIKE TO VIEW THEM?", MsgBoxStyle.YesNo)
            If m1 = MsgBoxResult.Yes Then
                Panel3.Show()
                Panel4.Hide()
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                Label1.Visible = False
                Label2.Visible = False
                Label3.Visible = False
                Label4.Visible = False



                TextBox1.Text = File.ReadAllText(t & ".txt")
            End If

        End If

    End Sub
    'here new
    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox9_Click_1(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Me.Hide()
        whatprint.Show()
    End Sub

    Private Sub PictureBox8_Click_1(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Panel4.Enabled = False
        Panel4.Hide()
        Panel3.Visible = True
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
    End Sub

    Private Sub PictureBox10_Click_1(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Panel3.Enabled = False
        Panel3.Hide()
        Panel4.Enabled = True
        Panel4.Show()
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
    End Sub

    Private Sub PictureBox7_Click_1(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Panel4.Visible = False
        Panel3.Visible = False
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Cases.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Suspect.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Forensic.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Investigation.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Try

            If TextBox1.Text = "" Then
                If File.Exists(t & ".txt") = True Then
                    File.Delete(t & ".txt")
                End If
            End If
            If TextBox1.Text.Length > 0 Then
                File.WriteAllText(t & ".txt", TextBox1.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub MonthCalendar2_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar2.DateChanged

    End Sub

    Private Sub MonthCalendar2_DateSelected_1(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar2.DateSelected
        t = MonthCalendar2.SelectionRange.Start.Month.ToString & MonthCalendar2.SelectionRange.Start.Day.ToString
        Try
            If File.Exists(t & ".txt") = True Then
                MonthCalendar2.Enabled = True
                MonthCalendar2.Show()
                TextBox1.Enabled = True
                TextBox1.Show()
                Button5.Enabled = True
                Button5.Show()
                TextBox1.Text = File.ReadAllText(t & ".txt")
            Else
                m = MsgBox("WOULD U LIKE TO ENTER APPOINTMENT FOR THIS DATE?", MsgBoxStyle.YesNo)
                If m = MsgBoxResult.Yes Then
                    MonthCalendar2.Enabled = True
                    MonthCalendar2.Show()
                    TextBox1.Enabled = True
                    TextBox1.Show()
                    TextBox1.Text = ""
                    Button5.Enabled = True
                    Button5.Show()

                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class