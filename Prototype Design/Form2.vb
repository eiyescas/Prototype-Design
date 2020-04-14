Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogOff.Click
        Dim SecondForm As New Form1
        SecondForm.Show()
        Me.Hide()
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskCurrBal.MaskInputRejected

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class