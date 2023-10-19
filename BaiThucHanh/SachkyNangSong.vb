Public Class SachkyNangSong


    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim ngdat As New SachNgoaiNgu()
        SachNgoaiNgu.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ngdat As New tuoitre()
        ngdat.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ngdat As New dactamnhan()
        ngdat.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ngdat As New hanhtrinh()
        ngdat.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ngdat As New dungluachonkhicontre()
        ngdat.Show()
    End Sub
End Class