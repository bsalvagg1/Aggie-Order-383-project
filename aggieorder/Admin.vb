Public Class Admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "storeadmin" And TextBox2.Text = "adminpass" Then
            Me.Hide()
            accountDB.Show()
        Else
            MsgBox("Username or password incorrect. Enter the correct credentials to view Account Database.", MsgBoxStyle.Information, "Admin Status.")
        End If
    End Sub
End Class