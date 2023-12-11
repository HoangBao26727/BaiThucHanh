Public Class Form1
    Private Sub BánSáchToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DangToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SảnPhẩmToolStripMenuItem.Click
        Dim frm As New DangNhap()
        frm.Show()
    End Sub

    Private Sub SáchThiếuNhiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SáchThiếuNhiToolStripMenuItem.Click
        Dim frm As New SachThieuNhi()
        frm.Show()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SáchNgoạiNgữToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SáchNgoạiNgữToolStripMenuItem.Click
        Dim frm As New SachNgoaiNgu()
        frm.Show()
    End Sub

    Private Sub SáchKỹNăngSốngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SáchKỹNăngSốngToolStripMenuItem.Click
        Dim frm As New SachkyNangSong()
        frm.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LiênHệToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GiớiThiệuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GiớiThiệuToolStripMenuItem.Click
        Dim frm As New Gioithieu()
        frm.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)


    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TrangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrangToolStripMenuItem.Click
        Dim frm As New TrangChu()
        frm.Show()
    End Sub
End Class
