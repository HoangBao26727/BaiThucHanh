Public Class DangNhap
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtmatkhau_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ten As String = TextBox1.Text
        Dim mk As String = TextBox2.Text
        If (ten = "thanhtruong" AndAlso mk = "123") Then
            Dim ngdat As New SachThieuNhi()
            ngdat.Show()
            Me.Hide()
        End If
        If (ten = "hoangbao" AndAlso mk = "123") Then
            Dim ngdat1 As New SachNgoaiNgu()
            ngdat1.Show()
            Me.Hide()
        End If
        If (ten = "tanthanh" AndAlso mk = "123") Then
            Dim ngdat2 As New SachkyNangSong()
            ngdat2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub linkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked

    End Sub
End Class