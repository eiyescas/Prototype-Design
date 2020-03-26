Public Class Form1
    Private Sub btnFaceID_Click(sender As Object, e As EventArgs) Handles btnFaceID.Click
        If btnFaceID.Text = "OFF" Then
            btnFaceID.Text = "ON"
            btnFaceID.BackColor = Color.LimeGreen
        ElseIf btnFaceID.Text = "ON" Then
            btnFaceID.Text = "OFF"
            btnFaceID.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnRemember_Click(sender As Object, e As EventArgs) Handles btnRemember.Click
        If btnRemember.Text = "OFF" Then
            btnRemember.Text = "ON"
            btnRemember.BackColor = Color.LimeGreen
        ElseIf btnRemember.Text = "ON" Then
            btnRemember.Text = "OFF"
            btnRemember.BackColor = Color.Red
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
