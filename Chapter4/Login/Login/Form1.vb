Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Equals("bob1") Or TextBox1.Text.Equals("bob2") Or TextBox1.Text.Equals("bob3") Then

            If TextBox2.Text = "pass" Then
                MessageBox.Show("Welcome")
            Else

                MessageBox.Show("Wrong Pass")

            End If

        Else

            MessageBox.Show("Wrong ID")

        End If
    End Sub
End Class
