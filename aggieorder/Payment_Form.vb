Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Payment_Form
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles CardNumber_TextBox.TextChanged
        ' Remove any existing spaces
        Dim inputText As String = CardNumber_TextBox.Text.Replace(" ", "")

        ' Check if inputText is not empty and is numeric
        If inputText <> "" AndAlso IsNumeric(inputText) Then
            ' Remove any non-numeric characters
            Dim numericInput As String = Regex.Replace(inputText, "[^\d]", "")

            ' Add space every four digits
            Dim formattedText As String = Regex.Replace(numericInput, ".{4}", "$0 ")

            ' Trim any leading or trailing spaces
            formattedText = formattedText.Trim()

            ' Update the text in the TextBox
            CardNumber_TextBox.Text = formattedText

            ' Set the caret position to the end to maintain cursor position
            CardNumber_TextBox.SelectionStart = CardNumber_TextBox.Text.Length
        End If
    End Sub

    Private Sub ExpiryDate_TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ExpiryDate_TextBox.KeyPress
        ' Check if the entered character is a digit or a slash and if the length is less than 5
        If (Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "/"c) OrElse ExpiryDate_TextBox.TextLength >= 5 Then
            e.Handled = True ' Ignore the input
        ElseIf ExpiryDate_TextBox.TextLength = 2 AndAlso e.KeyChar <> "/"c Then
            ExpiryDate_TextBox.Text &= "/" ' Add a slash after the second character
            ExpiryDate_TextBox.SelectionStart = ExpiryDate_TextBox.TextLength ' Move the cursor to the end
            e.Handled = True ' Ignore the input
        End If
    End Sub

    Private Sub Payment_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PaymentAmount_Label.Text = Format(tprice, "$0.00")
    End Sub

    Private Sub GoToShipping_Button_Click(sender As Object, e As EventArgs) Handles GoToShipping_Button.Click
        'Store the Billing Address values
        BillAddress_AddressLine = CStr(AddressLine_TextBox.Text)
        BillAddress_City = CStr(City_TextBox.Text)
        BillAddress_State = CStr(State_ComboBox.Text)
        BillAddress_ZipCode = CStr(ZIPCode_TextBox.Text)

        'Show the Shipping Form
        Me.Hide()
        Shipping_Form.Show()
    End Sub

    Private Sub BackToCart_Button_Click(sender As Object, e As EventArgs) Handles BackToCart_Button.Click
        Me.Hide()
        Cart.Show()
    End Sub
End Class