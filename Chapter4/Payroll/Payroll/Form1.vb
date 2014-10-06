Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Label3.Text = "Wage: " + String.Concat(Integer.Parse(TextBox1.Text) * Integer.Parse(TextBox2.Text) + ((Integer.Parse(TextBox1.Text) * Integer.Parse(TextBox2.Text)) * 0.18))
        Else
            Label3.Text = "Wage: " + String.Concat(Integer.Parse(TextBox1.Text) * Integer.Parse(TextBox2.Text))
        End If
    End Sub
End Class
