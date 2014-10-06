Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim model As Integer = Integer.Parse(TextBox1.Text)

        Label2.Text = "Good"

        If model = 119 Or model = 179 Or (model > 188 And model < 196) And model = 221 And model = 780 Then
            Label2.Text = "Bad"
        End If

    End Sub
End Class
