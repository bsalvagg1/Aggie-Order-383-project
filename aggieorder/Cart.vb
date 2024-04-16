Public Class Cart
    Private Sub Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim n As Integer
        Dim message As String
        For n = 0 To L - 1
            message &= selectedprod(n) & vbTab
        Next
        TextBox1.Text = message
    End Sub
End Class