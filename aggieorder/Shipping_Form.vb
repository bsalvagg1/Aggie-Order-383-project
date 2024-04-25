Public Class Shipping_Form
    Private Sub BillingAddress_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles BillingAddress_CheckBox.CheckedChanged
        If BillingAddress_CheckBox.CheckState = CheckState.Checked Then
            Address_TextBox.Text = BillAddress_AddressLine
            City_TextBox.Text = BillAddress_City
            State_ComboBox.Text = BillAddress_State
            ZIPCode_TextBox.Text = BillAddress_ZipCode
        Else
            Address_TextBox.Text = ""
            City_TextBox.Text = ""
            State_ComboBox.Text = ""
            ZIPCode_TextBox.Text = ""

        End If
    End Sub

    Private Sub BackToPayment_Button_Click(sender As Object, e As EventArgs) Handles BackToPayment_Button.Click
        Me.Hide()
        Payment_Form.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'confirm
        Me.Hide()
        Receipt.Show()
    End Sub
End Class