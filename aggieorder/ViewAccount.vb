Imports System.Runtime.InteropServices.ComTypes

Public Class ViewAccount
    Private total, target, i As Integer
    Private Xname(), Xpass(), Xtarget As String
    Private tempname, temppass As String

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'back
        Me.Hide()
        Homepage.Show()

    End Sub

    Private Sub Xsave(ByVal B As Long)
        'Save all the records Excep B into the data file
        Dim M As Long
        M = 0
        FileOpen(2, "383project_account_info.csv", OpenMode.Output)
        'WriteLine(2, tempname, temppass)

        For M = 0 To total - 1
            If M <> B Then
                WriteLine(2, Xname(M), Xpass(M))
            End If
        Next
        FileClose(2)

    End Sub

    Private Sub Xfind(ByVal Xtarget As String)
        Dim K As Integer
        target = -1
        For K = 0 To total - 1
            If Xname(K) = Xtarget Then
                target = K
                Exit Sub
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'confirm change
        Dim Xtarget As String


        If Button1.Text = "Change Password" Then
            Button2.Enabled = False
            Button3.Enabled = False
            Button1.Text = "Save"

            Xtarget = TextBox1.Text
            Call Xfind(Xtarget)

        Else
            Button1.Text = "Change Password"
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True

            Xname(target) = TextBox1.Text
            Xpass(target) = TextBox2.Text

            Call Xsave(-1)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'cancel
        Me.Hide()
        Homepage.Show()
    End Sub

    Private Sub ViewAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load and read data into arrays upon form load
        FileOpen(1, "383project_account_info.csv", OpenMode.Input)
        i = 0
        Do Until EOF(1)
            ReDim Preserve XName(0 To i)
            ReDim Preserve Xpass(0 To i)

            Input(1, XName(i))
            Input(1, Xpass(i))
            i += 1
        Loop
        total = i
        FileClose(1)
    End Sub
End Class