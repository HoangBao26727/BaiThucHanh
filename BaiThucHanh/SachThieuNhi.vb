Public Class SachThieuNhi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim frm As New DangNhap
        frm.ShowDialog()
        _LoginResult = frm.DialogResult
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private _LoginResult As DialogResult
    Private Sub SachThieuNhi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _LoginResult <> Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim ngdat As New SachkyNangSong
        SachkyNangSong.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim ngdat As New dungsaigon()
        ngdat.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ngdat As New vitchivitem()
        ngdat.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ngdat As New lequang()
        ngdat.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ngdat As New nguoicon()
        ngdat.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim ngdat As New tuoitho()
        ngdat.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim ngdat As New ruavatho()
        ngdat.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim ngdat As New khurung()
        ngdat.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim ngdat As New alice()
        ngdat.Show()
    End Sub
End Class