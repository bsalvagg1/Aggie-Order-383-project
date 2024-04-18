Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'create account button
        Me.Hide()
        CreateAccount.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(1, "383project_account_info.csv", OpenMode.Input)

        Dim i As Integer = 0
        Do Until EOF(1)

            ReDim Preserve User(0 To i)
            ReDim Preserve pass(0 To i)

            Input(1, User(i))
            Input(1, pass(i))
            i += 1
        Loop
        total = i
        FileClose(1)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'continue as guest button
        accountname = "Guest"
        Me.Hide()
        Homepage.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'sign in button
        Dim j As Integer = 0
        Do Until j > total - 1
            If TextBox1.Text = User(j) Then
                If TextBox2.Text = pass(j) Then
                    accountname = user(j)
                    Me.Hide()
                    Homepage.Show()
                    Exit Do
                Else
                    j += 1
                    Continue Do
                End If
            Else
                j += 1
                Continue Do
            End If
        Loop
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        admin.Show()
    End Sub
End Class
