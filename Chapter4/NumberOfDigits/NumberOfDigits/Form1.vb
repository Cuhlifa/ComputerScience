Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = "Digits: " + String.Concat(TextBox1.TextLength)
    End Sub
End Class
