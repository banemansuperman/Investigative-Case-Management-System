Public Class whatprint
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub ThunderButton1_Click(sender As Object, e As EventArgs) Handles ThunderButton1.Click
        Me.Hide()
        Print.Show()
    End Sub

    Private Sub ThunderButton2_Click(sender As Object, e As EventArgs) Handles ThunderButton2.Click
        Me.Hide()
        Printvictim.Show()
    End Sub

    Private Sub ThunderButton3_Click(sender As Object, e As EventArgs) Handles ThunderButton3.Click
        Me.Hide()
        Printsuspect.Show()
    End Sub

    Private Sub ThunderButton5_Click(sender As Object, e As EventArgs) Handles ThunderButton5.Click
        Me.Hide()
        Printforensic.Show()
    End Sub

    Private Sub ThunderButton6_Click(sender As Object, e As EventArgs) Handles ThunderButton6.Click
        Me.Hide()
        Printinvestigation.Show()
    End Sub

    Private Sub ThunderButton4_Click(sender As Object, e As EventArgs) Handles ThunderButton4.Click
        Me.Hide()
        Printwitness.Show()
    End Sub
End Class