Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim price As Integer = 25

        If CheckBox1.Checked = True Then
            price += 3.5
        End If
        If CheckBox2.Checked = True Then
            price += 3.5
        End If
        If CheckBox3.Checked = True Then
            price += 3.5
        End If

        Label1.Text = String.Concat(price)

    End Sub
End Class
