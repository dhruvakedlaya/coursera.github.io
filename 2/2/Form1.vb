Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim m, n, d, dsum, rev As Integer
        n = Val(TextBox1.Text)
        rev = 0
        dsum = 0
        If TextBox1.Text = "" Then
            MsgBox("text box cannot be empty ! enter the last number")
            TextBox1.Focus()
            Exit Sub

        End If
        If Not (IsNumeric(TextBox1.Text)) Then
            MsgBox("enter the number")
            TextBox1.Text = ""
            TextBox1.Focus()
            Exit Sub

        End If
        If n < 0 Then
            MsgBox("enter the positive result")
            TextBox1.Text = ""
            TextBox1.Focus()
            Exit Sub

        End If
        m = n
        Do While (n <> 0)
            d = n Mod 10
            rev = (rev * 10) + d
            dsum = dsum + d
            n = n \ 10

        Loop
        Label4.Text = Str(rev)
        Label5.Text = Str(dsum)
        If (m = rev) Then
            Label6.Text = "it is a palindrom"
        Else
            Label6.Text = "it is not a palindrom"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        Label4.Text = ""
        Label5.Text = ""
        Label6.Text = ""

    End Sub
End Class
