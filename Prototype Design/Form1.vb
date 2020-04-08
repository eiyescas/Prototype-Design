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

    End Sub
End Class
