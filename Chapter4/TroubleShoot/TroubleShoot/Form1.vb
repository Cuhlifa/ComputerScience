Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.ToLower.Equals("n") And TextBox1.Text.ToLower.Equals("n") Then
            Label3.Text = "get repaired"
        ElseIf TextBox1.Text.ToLower.Equals("y") And TextBox1.Text.ToLower.Equals("n") Then
            Label3.Text = "Check Drive"
        ElseIf TextBox1.Text.ToLower.Equals("n") And TextBox1.Text.ToLower.Equals("y") Then
            Label3.Text = "Check speaker"
        ElseIf TextBox1.Text.ToLower.Equals("y") And TextBox1.Text.ToLower.Equals("y") Then
            Label3.Text = "tech support"
        End If
    End Sub

End Class
