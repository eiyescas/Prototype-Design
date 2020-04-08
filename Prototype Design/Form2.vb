Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogOff.Click
        Dim SecondForm As New Form1
        SecondForm.Show()
        Me.Hide()
    End Sub
End Class