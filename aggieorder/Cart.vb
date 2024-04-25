Public Class Cart
    Private Sub Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim n As Integer
        Dim message As String
        For n = 0 To L - 1
            message &= selectedprod(n) & vbCrLf & vbCrLf
            numprod += 1
        Next

        TextBox1.Text = message
        prodmessage = message

        p = prices.Sum()
        tax = p * 0.05
        tprice = p + tax
        TextBox2.Text = Format(tprice, "$ 0.00")

        Button3.Focus()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'back to products
        Me.Hide()
        ProductView.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'back to home
        Me.Hide()
        Homepage.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'checkout
        If accountname = "Guest" Then
            Me.Hide()
            GuestCreate.Show()
        Else
            Me.Hide()
            Payment_Form.Show()
        End If

    End Sub
End Class