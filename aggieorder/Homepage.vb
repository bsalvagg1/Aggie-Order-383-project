Public Class Homepage
    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.ReadOnly = True
        TextBox1.Text = accountname
    End Sub
End Class