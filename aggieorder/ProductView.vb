Imports System.Reflection

Public Class ProductView
    Private Sub ProductView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EquipmentDataSet.Equipment' table. You can move, or remove it, as needed.
        Me.EquipmentTableAdapter.Fill(Me.EquipmentDataSet.Equipment)
        Dim k As Integer
        FileOpen(2, "img.txt", OpenMode.Input)
        Do Until EOF(2)
            ReDim Preserve Image(0 To k)
            Input(2, Image(k))
            k += 1
        Loop
        FileClose(2)
        imgcount = 0
        PictureBox1.Load(Image(imgcount))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Next
        index = Me.EquipmentBindingSource.Position

        If imgcount < 9 Then
            imgcount += 1
        Else
            imgcount = 0
        End If

        If index = total - 1 Then
            Me.EquipmentBindingSource.Position = 0
        Else
            EquipmentBindingSource.MoveNext()
        End If

        PictureBox1.Load(Image(imgcount))

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'back
        index = Me.EquipmentBindingSource.Position

        If imgcount > 0 Then
            imgcount -= 1
        Else
            imgcount = 9
        End If

        If index = 0 Then
            Me.EquipmentBindingSource.Position = total - 1
        Else
            EquipmentBindingSource.MovePrevious()
        End If

        PictureBox1.Load(Image(imgcount))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'add to cart


        price = CInt(TextBox1.Text)
        prices.Append(price)
        selectprod = Label1.Text
        selectedprod.Append(selectprod)
        L += 1



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'view cart
        Me.Hide()
        Cart.Show()
    End Sub
End Class