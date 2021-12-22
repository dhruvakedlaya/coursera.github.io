Public Class Form1
    Dim opr1, opr2 As Double
    Dim op1 As String
    Dim cd As Boolean
    Public Sub clearvalue()
        If cd Then
            TextBox1.Text = ""
            cd = False

        End If

    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click, Button7.Click, Button6.Click, Button16.Click, Button15.Click, Button14.Click, Button12.Click, Button11.Click, Button10.Click, Button1.Click
        clearvalue()
        Dim bc As Button
        bc = CType(sender, Button)
        TextBox1.Text = TextBox1.Text & bc.Text

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        opr1 = Val(TextBox1.Text)
        op1 = "+"
        TextBox1.Text = ""

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If (TextBox1.Text = "") Then
            TextBox1.Text += "-"
            cd = False
        Else
            opr1 = Val(TextBox1.Text)
            op1 = "-"
            TextBox1.Text = ""

        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        opr1 = Val(TextBox1.Text)
        op1 = "*"
        TextBox1.Text = ""

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        opr1 = Val(TextBox1.Text)
        op1 = "/"
        TextBox1.Text = ""

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If InStr(TextBox1.Text, ".") Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text + "."
        End If

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        End

    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        opr1 = 0
        opr2 = 0
        TextBox1.Text = ""

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim result As Double
        result = 0
        opr2 = Val(TextBox1.Text)
        If op1 = "+" Then result = opr1 + opr2
        If op1 = "-" Then result = opr1 - opr2
        If op1 = "*" Then result = opr1 * opr2
        If op1 = "/" Then
            If opr1 <> 0 And opr2 = 0 Then
                TextBox1.Text = "devisible by zero"
                cd = True
                Exit Sub
            Else
                result = opr1 / opr2
            End If
        End If
        TextBox1.Text = result
        cd = True
        opr1 = 0
        opr2 = 0

    End Sub
End Class
