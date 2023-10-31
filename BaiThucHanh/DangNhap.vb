Imports System.Configuration
Imports System.Data.SqlClient
Public Class DangNhap
    Private _ConectionString As String = ConfigurationSettings.AppSettings("MyConnectionString")
    Private conn As SqlConnection
    Private da As SqlDataAdapter

    Private Function getDataTable(sqlQuery As String) As DataTable
        Dim dTable As New DataTable
        conn = New SqlConnection(_ConectionString)
        da = New SqlDataAdapter(sqlQuery, conn)
        Try
            conn.Open()
            da.Fill(dTable)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        Finally
            conn.Close()
        End Try




        Return dTable
    End Function
    Private Function CheckLogin(user As String, pass As String)
        Dim sqlQuery As String = String.Format("select * from [dbo].[Table_1] where [username] = '{0}' and [password] = '{1}'", user, pass)
        Dim dTable As DataTable = getDataTable(sqlQuery)
        Return dTable.Rows.Count > 0
    End Function

    Private Function IsEmpty() As Boolean

        Return String.IsNullOrEmpty(Me.txtUserName.Text) OrElse String.IsNullOrEmpty(Me.txtPassword.Text)
    End Function





    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsEmpty() Then
            MessageBox.Show("Tên, mật khẩu không thể để trống")
        Else
            If CheckLogin(Me.txtUserName.Text.ToLower, Me.txtPassword.Text.ToLower) Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                MessageBox.Show("Đăng Nhập thành công")
                Me.Close()
                SachThieuNhi.Show()
            Else
                MessageBox.Show("Tên, Mật khẩu Không Đúng")
            End If
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub DangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class