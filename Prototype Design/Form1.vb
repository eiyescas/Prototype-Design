Public Class Form1
    Private Sub btnFaceID_Click(sender As Object, e As EventArgs) Handles btnFaceID.Click
        If btnFaceID.Text = "Off" Then
            btnFaceID.Text = "On"
        ElseIf btnFaceID.Text = "On" Then
            btnFaceID.Text = "Off"
        End If
    End Sub

    Private Sub btnRemember_Click(sender As Object, e As EventArgs) Handles btnRemember.Click
        If btnRemember.Text = "Off" Then
            btnRemember.Text = "On"
        ElseIf btnRemember.Text = "On" Then
            btnRemember.Text = "Off"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
