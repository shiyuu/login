Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmLoaiSP
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


    Private Sub btnTh_Click(sender As Object, e As EventArgs) Handles btnTh.Click
        Application.Exit()
    End Sub

    Private Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        'Kết nối với DB Online 
        Dim ketnoi As New SqlConnection(chuoiketnoi)
        'kết nối mở
        ketnoi.Open()

        Dim SP As String = "insert into Loai_SP Values (@MA_LSP, @TEN_LOAI, @XUAT_XU, @TINH_TRANG, @HUONG_DAN)"
        Dim T As New SqlCommand(SP, ketnoi)
        Try
            T.Parameters.AddWithValue("@MA_LSP", TextBox1.Text)
            T.Parameters.AddWithValue("@TEN_LOAI", TextBox2.Text)
            T.Parameters.AddWithValue("@XUAT_XU", TextBox3.Text)
            T.Parameters.AddWithValue("@TINH_TRANG", TextBox4.Text)
            T.Parameters.AddWithValue("@HUONG_DAN", TextBox5.Text)
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


    Private Sub LoaiSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ketnoi As New SqlConnection(chuoiketnoi)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from LOAI_SP", ketnoi)

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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Lấy giá trị của dòng Cell bất kỳ đưa lên Textbox tương ứng
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        TextBox1.Text = DataGridView1.Item(0, index).Value
        TextBox2.Text = DataGridView1.Item(1, index).Value
        TextBox3.Text = DataGridView1.Item(2, index).Value
    End Sub



    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        'Kết nối với DB Online 
        Dim ketnoi As New SqlConnection(chuoiketnoi)
        'kết nối mở
        ketnoi.Open()

        Dim SP As String = "update LOAI_SP Set MA_LSP = @MA_LSP, TEN_LOAI = @TEN_LOAI, XUAT_XU = @XUAT_XU, TINH_TRANG = @TINH_TRANG, HUONG_DAN = @HUONG_DAN"
        Dim T As New SqlCommand(SP, ketnoi)
        Try
            T.Parameters.AddWithValue("@MA_LSP", TextBox1.Text)
            T.Parameters.AddWithValue("@TEN_LOAI", TextBox2.Text)
            T.Parameters.AddWithValue("@XUAT_XU", TextBox3.Text)
            T.Parameters.AddWithValue("@TINH_TRANG", TextBox4.Text)
            T.Parameters.AddWithValue("@HUONG_DAN", TextBox5.Text)
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

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        Dim ketnoi As New SqlConnection(chuoiketnoi)
        ketnoi.Open()
        Dim SP As String = "delete from LOAI_SP where MA_LSP = @MA_LSP"
        Dim T As New SqlCommand(SP, ketnoi)
        Try
            T.Parameters.AddWithValue("@MA_LSP", TextBox1.Text)
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
End Class