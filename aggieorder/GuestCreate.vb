Public Class GuestCreate
    Private Sub GuestCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(1, "383project_account_info.csv", OpenMode.Append)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'create and checkout button
        Write(1, TextBox1.Text)
        Write(1, TextBox2.Text)
        WriteLine(1)
        FileClose(1)
        accountname = TextBox1.Text
        Me.Hide()
        Payment_Form.Show()
    End Sub
End Class