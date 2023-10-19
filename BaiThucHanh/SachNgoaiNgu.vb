Public Class SachNgoaiNgu


    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim ngdat As New SachTieuThuyet
        SachTieuThuyet.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ngdat As New grammarxanh()
        ngdat.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ngdat As New grammarhong()
        ngdat.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ngdat As New grammarcam()
        ngdat.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ngdat As New perfect()
        ngdat.Show()
    End Sub
End Class