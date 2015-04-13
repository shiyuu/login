Imports System.Data.SqlClient

Public Class frmDN
    Private Sub btnNL_Click(sender As Object, e As EventArgs) Handles btnNL.Click
        txtMK.Clear()
        txtDN.Clear()
    End Sub
    Private Sub txtDN_TextChanged(sender As Object, e As EventArgs) Handles txtDN.TextChanged

    End Sub

    Private Sub btnDN_Click(sender As Object, e As EventArgs) Handles btnDN.Click
        Dim chuoiketnoi As String = "workstation id=maihps02050.mssql.somee.com;packet size=4096;user id=shiyuu_SQLLogin_1;pwd=i6wme2kwyi;data source=maihps02050.mssql.somee.com;persist security info=False;initial catalog=maihps02050"
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlDA As New SqlDataAdapter("select * from NHAN_VIEN where TAI_KHOAN='" & txtDN.Text & "' and MAT_KHAU='" & txtMK.Text & "' ", ketnoi)
        Dim DT As New DataTable

        Try
            ketnoi.Open()
            sqlDA.Fill(DT)
            If DT.Rows.Count > 0 Then
                MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG")
                Main.Show()
                Me.Hide()
            Else
                MessageBox.Show("SAI TÀI KHOẢN HOẶC MẬT KHẨU KHÔNG ĐÚNG")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmDN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
