Imports System.Data.SqlClient
Imports System.Data.DataTable


Public Class frmQLSP
    Dim DT As New DataTable
    Dim chuoiketnoi As String = "workstation id=maihps02050.mssql.somee.com;packet size=4096;user id=shiyuu_SQLLogin_1;pwd=i6wme2kwyi;data source=maihps02050.mssql.somee.com;persist security info=False;initial catalog=maihps02050"
    Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)

    Public Sub LoadData()
        Dim ketnoi As New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from SAN_PHAM ", ketnoi)

        Try
            sqlAdapter.Fill(DT)

        Catch ex As Exception

        End Try
        DataGridView1.DataSource = DT
        ketnoi.Close()
    End Sub

        
   

    Private Sub frmQLSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ketnoi As New SqlConnection(chuoiketnoi)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from NHAN_VIEN", ketnoi)

        Try
            ketnoi.Open()
            'Đổ dữ liệu trên vào Datatable
            sqlAdapter.Fill(DT)

        Catch ex As Exception

        End Try
        'Hiển thị dữ liệu ra giao diện qua Datagridview
        DataGridView1.DataSource = DT
        ketnoi.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        'Lấy giá trị của dòng Cell bất kỳ đưa lên Textbox tương ứng
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        TextBox1.Text = DataGridView1.Item(0, index).Value
        TextBox2.Text = DataGridView1.Item(1, index).Value
        TextBox3.Text = DataGridView1.Item(2, index).Value

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        'Kết nối với DB Online 
        Dim ketnoi As New SqlConnection(chuoiketnoi)
        'kết nối mở
        ketnoi.Open()

        Dim SP As String = "insert into SAN_PHAM Values (@MA_SP, @MA_LSP, @TEN_SP, @GIA_TIEN, @CHI_TIET_SP)"
        Dim T As New SqlCommand(SP, ketnoi)
        Try
            T.Parameters.AddWithValue("@MA_SP", TextBox1.Text)
            T.Parameters.AddWithValue("@MA_LSP", TextBox2.Text)
            T.Parameters.AddWithValue("@TEN_SP", TextBox3.Text)
            T.Parameters.AddWithValue("@GIA_TIEN", TextBox4.Text)
            T.Parameters.AddWithValue("@CHI_TIET_SP", TextBox5.Text)
            'Insert dữ liệu vào DB Online
            T.ExecuteNonQuery()
            'Đóng 
            ketnoi.Close()

        Catch ex As Exception
            MessageBox.Show("KẾT NỐI THÀNH CÔNG")


        End Try
        DT.Clear()
        DataGridView1.DataSource = DT
        DataGridView1.DataSource = Nothing
        LoadData()

    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        'Kết nối với DB Online 
        Dim ketnoi As New SqlConnection(chuoiketnoi)
        'kết nối mở
        ketnoi.Open()

        Dim SP As String = "update SAN_PHAM Set MA_SP = @MA_SP, MA_LSP = @MA_LSP, TEN_SP = @TEN_SP, GIA_TIEN = @GIA_TIEN, CHI_TIET_SP = @CHI_TIET_SP"
        Dim T As New SqlCommand(SP, ketnoi)
        Try
            T.Parameters.AddWithValue("@MA_SP", TextBox1.Text)
            T.Parameters.AddWithValue("@MA_LSP", TextBox2.Text)
            T.Parameters.AddWithValue("@TEN_SP", TextBox3.Text)
            T.Parameters.AddWithValue("@GIA_TIEN", TextBox4.Text)
            T.Parameters.AddWithValue("@CHI_TIET_SP", TextBox5.Text)
            'Insert dữ liệu vào DB Online
            T.ExecuteNonQuery()
            'Đóng 
            ketnoi.Close()

        Catch ex As Exception
            MessageBox.Show("KẾT NỐI THÀNH CÔNG")


        End Try
        'LOAD LẠI SP
        DT.Clear()
        DataGridView1.DataSource = DT
        DataGridView1.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim ketnoi As New SqlConnection(chuoiketnoi)
        ketnoi.Open()
        Dim SP As String = "delete from SAN_PHAM where MA_SP = @MA_SP"
        Dim T As New SqlCommand(SP, ketnoi)
        Try
            T.Parameters.AddWithValue("@MA_SP", TextBox1.Text)
            T.ExecuteNonQuery()
            ketnoi.Close()

        Catch ex As Exception
            MessageBox.Show("KẾT NỐI THÀNH CÔNG")

        End Try
        DT.Clear()
        DataGridView1.DataSource = DT
        DataGridView1.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Application.Exit()

    End Sub
End Class