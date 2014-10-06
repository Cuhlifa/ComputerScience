Public Class Form1

    Dim fail As Integer
    Dim pass As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.ToLower.Equals("a") Or TextBox1.Text.ToLower.Equals("b") Or TextBox1.Text.ToLower.Equals("c") Or TextBox1.Text.ToLower.Equals("d") Then
            pass += 1
        Else
            fail += 1
        End If
        Label2.Text = String.Concat(pass)
        Label3.Text = String.Concat(fail)
    End Sub
End Class
