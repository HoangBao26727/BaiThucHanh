Public Class englishvocabulary
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (MessageBox.Show("Đã Thêm Vào Giỏ Hàng ^^", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) - -DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub
End Class