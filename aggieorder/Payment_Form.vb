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

    Private Sub Payment_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PaymentAmount_Label.Text = Format(tprice, "$0.00")
    End Sub




End Class