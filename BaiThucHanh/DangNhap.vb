Public Class DangNhap
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ten As String = TextBox1.Text
        Dim mk As String = TextBox2.Text
        If (ten = "nguyendat" AndAlso mk = "123") Then
            Dim ngdat As New SachThieuNhi()
            ngdat.Show()
            Me.Hide()
        End If
        If (ten = "hoangbao" AndAlso mk = "123") Then
            Dim ngdat1 As New SachNgoaiNgu()
            ngdat1.Show()
            Me.Hide()
        End If
        If (ten = "hongngoc" AndAlso mk = "123") Then
            Dim ngdat2 As New SachNgoaiNgu()
            ngdat2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub


End Class