Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SecondForm As New Form1
        SecondForm.Show()
        Me.Hide()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtMomMaiden.TextChanged
        Dim allowed As String = ("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ")
        For Each c As Char In txtMomMaiden.Text
            If allowed.Contains(c) = False Then
                txtMomMaiden.Text = txtMomMaiden.Text.Remove(txtMomMaiden.SelectionStart - 1, 1)
                txtMomMaiden.Select(txtMomMaiden.Text.Count, 0)
            End If
        Next
    End Sub

    Private Sub btnCont_Click(sender As Object, e As EventArgs) Handles btnCont.Click
        Dim SecondForm As New Form1
        SecondForm.Show()
        Me.Hide()
    End Sub
End Class