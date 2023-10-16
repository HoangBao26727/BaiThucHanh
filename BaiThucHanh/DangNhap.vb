Public Class DangNhap
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "NguyenThanhDat" Then
            If TextBox2.Text = "dat123" Then
                Dim ngdat As DialogResult
                ngdat = MessageBox.Show("Đăng Nhập Thành Công", "Đăng Nhập ", MessageBoxButtons.OK)
            End If
        End If
        If TextBox1.Text = "HoangBao" Then
            If TextBox2.Text = "bao123" Then
                Dim ngdat As DialogResult
                ngdat = MessageBox.Show("Đăng Nhập Thành Công", "Đăng Nhập ", MessageBoxButtons.OK)
            End If
        End If
        If TextBox1.Text = "hongNgoc" Then
            If TextBox2.Text = "ngoc123" Then
                Dim ngdat As DialogResult
                ngdat = MessageBox.Show("Đăng Nhập Thành Công", "Đăng Nhập ", MessageBoxButtons.OK)
            End If
        Else
            Dim ngdat1 As DialogResult
            ngdat1 = MessageBox.Show("Đăng nhập Hay Tài khoảng", "Đăng Nhập", MessageBoxButtons.AbortRetryIgnore)

        End If

    End Sub
End Class