<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLSP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblQLSP = New System.Windows.Forms.Label()
        Me.lblMSP = New System.Windows.Forms.Label()
        Me.lblMLSP = New System.Windows.Forms.Label()
        Me.lblTSP = New System.Windows.Forms.Label()
        Me.lblGT = New System.Windows.Forms.Label()
        Me.lblCTSP = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblQLSP
        '
        Me.lblQLSP.AutoSize = True
        Me.lblQLSP.Location = New System.Drawing.Point(219, 20)
        Me.lblQLSP.Name = "lblQLSP"
        Me.lblQLSP.Size = New System.Drawing.Size(164, 19)
        Me.lblQLSP.TabIndex = 0
        Me.lblQLSP.Text = "QUẢN LÝ SẢN PHẨM"
        '
        'lblMSP
        '
        Me.lblMSP.AutoSize = True
        Me.lblMSP.Location = New System.Drawing.Point(27, 64)
        Me.lblMSP.Name = "lblMSP"
        Me.lblMSP.Size = New System.Drawing.Size(95, 19)
        Me.lblMSP.TabIndex = 1
        Me.lblMSP.Text = "Mã Sản Phẩm"
        '
        'lblMLSP
        '
        Me.lblMLSP.AutoSize = True
        Me.lblMLSP.Location = New System.Drawing.Point(27, 107)
        Me.lblMLSP.Name = "lblMLSP"
        Me.lblMLSP.Size = New System.Drawing.Size(130, 19)
        Me.lblMLSP.TabIndex = 2
        Me.lblMLSP.Text = "Mã Loại Sản Phẩm "
        '
        'lblTSP
        '
        Me.lblTSP.AutoSize = True
        Me.lblTSP.Location = New System.Drawing.Point(27, 153)
        Me.lblTSP.Name = "lblTSP"
        Me.lblTSP.Size = New System.Drawing.Size(97, 19)
        Me.lblTSP.TabIndex = 3
        Me.lblTSP.Text = "Tên Sản Phẩm"
        '
        'lblGT
        '
        Me.lblGT.AutoSize = True
        Me.lblGT.Location = New System.Drawing.Point(27, 197)
        Me.lblGT.Name = "lblGT"
        Me.lblGT.Size = New System.Drawing.Size(59, 19)
        Me.lblGT.TabIndex = 4
        Me.lblGT.Text = "Giá Tiền"
        '
        'lblCTSP
        '
        Me.lblCTSP.AutoSize = True
        Me.lblCTSP.Location = New System.Drawing.Point(27, 245)
        Me.lblCTSP.Name = "lblCTSP"
        Me.lblCTSP.Size = New System.Drawing.Size(121, 19)
        Me.lblCTSP.TabIndex = 5
        Me.lblCTSP.Text = "Chi Tiết Sản Phẩm"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(213, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 26)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(213, 105)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(207, 26)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(213, 146)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(207, 26)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(213, 190)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(207, 26)
        Me.TextBox4.TabIndex = 10
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(213, 238)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(299, 26)
        Me.TextBox5.TabIndex = 11
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(82, 312)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 13
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(213, 312)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 14
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(329, 312)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 15
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(437, 312)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat.TabIndex = 16
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 350)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(500, 150)
        Me.DataGridView1.TabIndex = 17
        '
        'frmQLSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 512)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblCTSP)
        Me.Controls.Add(Me.lblGT)
        Me.Controls.Add(Me.lblTSP)
        Me.Controls.Add(Me.lblMLSP)
        Me.Controls.Add(Me.lblMSP)
        Me.Controls.Add(Me.lblQLSP)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmQLSP"
        Me.Text = "Quản lý sản phẩm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQLSP As System.Windows.Forms.Label
    Friend WithEvents lblMSP As System.Windows.Forms.Label
    Friend WithEvents lblMLSP As System.Windows.Forms.Label
    Friend WithEvents lblTSP As System.Windows.Forms.Label
    Friend WithEvents lblGT As System.Windows.Forms.Label
    Friend WithEvents lblCTSP As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
