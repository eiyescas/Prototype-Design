Public Class Form1
    Private Sub btnFaceID_Click(sender As Object, e As EventArgs) Handles btnFaceID.Click
        If btnFaceID.Text = "FaceID" Then 'off
            btnFaceID.Text = "FaceID "  'on
            btnFaceID.BackColor = Color.LimeGreen
        ElseIf btnFaceID.Text = "FaceID " Then 'on
            btnFaceID.Text = "FaceID" 'off
            btnFaceID.BackColor = Color.Red
        End If
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnRemember_Click(sender As Object, e As EventArgs) Handles btnRemember.Click
        If btnRemember.Text = "Remember me" Then 'off
            btnRemember.Text = "Remember me " 'on
            btnRemember.BackColor = Color.LimeGreen
        ElseIf btnRemember.Text = "Remember me " Then 'on
            btnRemember.Text = "Remember me" 'off
            btnRemember.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnSignOn_Click(sender As Object, e As EventArgs) Handles btnSignOn.Click
        txtUserID.Text = ""
        txtPassword.Text = ""
        btnRemember.BackColor = Color.Red
        btnFaceID.BackColor = Color.Red

        Dim SecondForm As New Form2
        SecondForm.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUserID.TextChanged
        Dim allowed As String = ("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ")
        For Each c As Char In txtUserID.Text
            If allowed.Contains(c) = False Then
                txtUserID.Text = txtUserID.Text.Remove(txtUserID.SelectionStart - 1, 1)
                txtUserID.Select(txtUserID.Text.Count, 0)
            End If
        Next
    End Sub

    Private Sub ShowPassBtn_Click(sender As Object, e As EventArgs) Handles btnShowPass.Click
        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Dim SecondForm As New Form4
        SecondForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnForgot_Click(sender As Object, e As EventArgs) Handles btnForgot.Click
        Dim SecondForm As New Form3
        SecondForm.Show()
        Me.Hide()
    End Sub
End Class
