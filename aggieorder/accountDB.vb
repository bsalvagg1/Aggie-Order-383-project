Public Class accountDB
    Private total, target, i As Integer
    Private Xname(), Xpass(), Xtarget As String


    Private tempname, temppass As String

    Private Sub Xsave(ByVal B As Long)
        'Save all the records Excep B into the data file
        Dim M As Long
        M = 0
        FileOpen(2, "383project_account_info.csv", OpenMode.Output)
        WriteLine(2, tempname, temppass)

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

    Private Sub Xdisplay(ByVal X As Integer)
        'each button can call this function
        TextBox1.Text = Xname(X)
        TextBox2.Text = Xpass(X)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'first record
        Xdisplay(0)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'last record
        Xdisplay(total - 1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'next record
        For i = 0 To total - 1
            If TextBox2.Text = Xpass(i) Then
                If i = total - 1 Then
                    Call Button1_Click(sender, e)
                Else
                    Call Xdisplay(i + 1)
                End If
                Exit For
            End If
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'previous record
        For i = 0 To total - 1
            If TextBox2.Text = Xpass(i) Then
                If i = 0 Then
                    Call Button3_Click(sender, e)
                Else
                    Call Xdisplay(i - 1)
                End If
                Exit For
            End If
        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'search
        'compare user input with record contents
        Dim Xfind As String
        Dim target As Long
        target = -1

        Xfind = InputBox("Enter a name.")
        For i = 0 To total - 1
            If Xfind = Xname(i) Then
                target = i
                Xdisplay(i)
            End If
        Next

        If target = -1 Then
            MsgBox("No such record.")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load and read data into arrays upon form load
        FileOpen(1, "383project_account_info.csv", OpenMode.Input)
        i = 0
        Do Until EOF(1)
            ReDim Preserve Xname(0 To i)
            ReDim Preserve Xpass(0 To i)

            Input(1, Xname(i))
            Input(1, Xpass(i))
            i += 1
        Loop
        total = i
        FileClose(1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'modify
        Dim Xtarget As String


        If Button8.Text = "Modify" Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button9.Enabled = False
            Button8.Text = "Save"

            Xtarget = TextBox1.Text
            Call Xfind(Xtarget)

        Else
            Button8.Text = "Modify"
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True
            Button6.Enabled = True
            Button7.Enabled = True
            Button9.Enabled = True

            Xname(target) = TextBox1.Text
            Xpass(target) = TextBox2.Text

            Call Xsave(-1)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'add
        If Button6.Text = "Add" Then
            Button6.Text = "Save"
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            TextBox1.Clear()
            TextBox2.Clear()

        Else
            Button6.Text = "Add"
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True
            Button7.Enabled = True
            Button8.Enabled = True
            Button9.Enabled = True

            ReDim Preserve Xname(0 To total)
            ReDim Preserve Xpass(0 To total)

            Xname(total) = TextBox1.Text
            Xpass(total) = TextBox2.Text
            total += 1

            Call Xsave(-1)
        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'delete
        Dim Xtarget As String
        Xtarget = TextBox1.Text
        Call Xfind(Xtarget)

        Xsave(target)

        Form1_Load(sender, e)

    End Sub
End Class