Public Class DangNhap
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(TextBox1, "Đăng Nhập Thành Công $$$", "Thông Tin")
        Me.Close()
    End Sub
End Class