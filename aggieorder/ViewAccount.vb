Imports System.Runtime.InteropServices.ComTypes

Public Class ViewAccount
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer = 0
        For x = 0 To total - 1
            If TextBox1.Text = user(x) Then
                pass(x) = TextBox3.Text
            End If
        Next
    End Sub
End Class