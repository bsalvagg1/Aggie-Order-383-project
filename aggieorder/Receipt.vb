Imports Microsoft.VisualBasic.Logging

Public Class Receipt
    Private shiptime As Decimal
    Private Sub Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Text = Format(tprice, "$ 0.00")
        Label7.Text = CStr(numprod)
        Label8.Text = BillAddress_City & ", " & BillAddress_State

        If numprod = 1 Then
            shiptime = numprod * 2
        ElseIf numprod > 1 And numprod <= 3 Then
            shiptime = (numprod * 2) - 0.5
        ElseIf numprod > 3 Then
            shiptime = Math.Log(numprod) + 2
        End If

        Label9.Text = Format(shiptime, "0.00") & " weeks"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class