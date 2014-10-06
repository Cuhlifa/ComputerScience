Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim heavy As Boolean = False
        Dim big As Boolean = False

        If Integer.Parse(TextBox1.Text) > 27 Then
            heavy = True
        ElseIf Integer.Parse(TextBox2.Text) * Integer.Parse(TextBox3.Text) * Integer.Parse(TextBox4.Text) > 100000 Then
            big = True
        End If

        If heavy And big Then
            Label5.Text = "Status: " + "Both"
        ElseIf heavy Then
            Label5.Text = "Status: " + "heavy"
        ElseIf big Then
            Label5.Text = "Status: " + "big"
        Else
            Label5.Text = "Status: " + "Good"
        End If

    End Sub
End Class
