Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SecondForm As New Form1
        SecondForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnForgot2.Click
        Dim SecondForm As New Form3
        SecondForm.Show()
        Me.Hide()
    End Sub
End Class