Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim copies As Integer = Integer.Parse(TextBox1.Text)
        Dim price As Double

        If copies < 450 Then
            price = 0.3
        ElseIf copies < 750 Then
            price = 0.28
        ElseIf copies < 1000 Then
            price = 0.27
        Else
            price = 0.25
        End If

        Label2.Text = "Price:" + String.Concat(price * copies)

    End Sub
End Class
