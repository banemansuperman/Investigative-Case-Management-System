Public Class Chooseprinter

    Private Sub Chooseprinter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.printer
    End Sub


    Private Sub DreamButton1_Click_1(sender As Object, e As EventArgs) Handles DreamButton1.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If

        TextBox1.Text = PrintDialog1.PrinterSettings.PrinterName
    End Sub

    Private Sub ParrotGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles ParrotGradientPanel1.Paint

    End Sub

    Private Sub Chooseprinter_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.printer = TextBox1.Text
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()

    End Sub
End Class