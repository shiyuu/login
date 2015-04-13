<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhachHang
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
        Me.lblKH = New System.Windows.Forms.Label()
        Me.lblMKH = New System.Windows.Forms.Label()
        Me.lblTKH = New System.Windows.Forms.Label()
        Me.lblSDT = New System.Windows.Forms.Label()
        Me.lblDC = New System.Windows.Forms.Label()
        Me.lblE = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.btnT = New System.Windows.Forms.Button()
        Me.btnS = New System.Windows.Forms.Button()
        Me.btnX = New System.Windows.Forms.Button()
        Me.btnTh = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblKH
        '
        Me.lblKH.AutoSize = True
        Me.lblKH.Location = New System.Drawing.Point(257, 22)
        Me.lblKH.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKH.Name = "lblKH"
        Me.lblKH.Size = New System.Drawing.Size(114, 19)
        Me.lblKH.TabIndex = 0
        Me.lblKH.Text = "KHÁCH HÀNG"
        '
        'lblMKH
        '
        Me.lblMKH.AutoSize = True
        Me.lblMKH.Location = New System.Drawing.Point(24, 73)
        Me.lblMKH.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMKH.Name = "lblMKH"
        Me.lblMKH.Size = New System.Drawing.Size(110, 19)
        Me.lblMKH.TabIndex = 1
        Me.lblMKH.Text = "Mã Khách Hàng"
        '
        'lblTKH
        '
        Me.lblTKH.AutoSize = True
        Me.lblTKH.Location = New System.Drawing.Point(24, 121)
        Me.lblTKH.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTKH.Name = "lblTKH"
        Me.lblTKH.Size = New System.Drawing.Size(112, 19)
        Me.lblTKH.TabIndex = 2
        Me.lblTKH.Text = "Tên Khách Hàng"
        '
        'lblSDT
        '
        Me.lblSDT.AutoSize = True
        Me.lblSDT.Location = New System.Drawing.Point(24, 163)
        Me.lblSDT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSDT.Name = "lblSDT"
        Me.lblSDT.Size = New System.Drawing.Size(96, 19)
        Me.lblSDT.TabIndex = 3
        Me.lblSDT.Text = "Số Điện Thoại"
        '
        'lblDC
        '
        Me.lblDC.AutoSize = True
        Me.lblDC.Location = New System.Drawing.Point(24, 206)
        Me.lblDC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDC.Name = "lblDC"
        Me.lblDC.Size = New System.Drawing.Size(55, 19)
        Me.lblDC.TabIndex = 4
        Me.lblDC.Text = "Địa Chỉ"
        '
        'lblE
        '
        Me.lblE.AutoSize = True
        Me.lblE.Location = New System.Drawing.Point(24, 245)
        Me.lblE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblE.Name = "lblE"
        Me.lblE.Size = New System.Drawing.Size(42, 19)
        Me.lblE.TabIndex = 5
        Me.lblE.Text = "Email"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(205, 70)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(263, 26)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(205, 118)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(342, 26)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(205, 160)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(263, 26)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(205, 203)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(342, 26)
        Me.TextBox4.TabIndex = 9
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(205, 242)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(342, 26)
        Me.TextBox5.TabIndex = 10
        '
        'btnT
        '
        Me.btnT.Location = New System.Drawing.Point(154, 294)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(75, 23)
        Me.btnT.TabIndex = 12
        Me.btnT.Text = "Thêm"
        Me.btnT.UseVisualStyleBackColor = True
        '
        'btnS
        '
        Me.btnS.Location = New System.Drawing.Point(261, 294)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(75, 23)
        Me.btnS.TabIndex = 13
        Me.btnS.Text = "Sửa"
        Me.btnS.UseVisualStyleBackColor = True
        '
        'btnX
        '
        Me.btnX.Location = New System.Drawing.Point(372, 294)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(75, 23)
        Me.btnX.TabIndex = 14
        Me.btnX.Text = "Xóa"
        Me.btnX.UseVisualStyleBackColor = True
        '
        'btnTh
        '
        Me.btnTh.Location = New System.Drawing.Point(472, 294)
        Me.btnTh.Name = "btnTh"
        Me.btnTh.Size = New System.Drawing.Size(75, 23)
        Me.btnTh.TabIndex = 15
        Me.btnTh.Text = "Thoát"
        Me.btnTh.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 351)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(519, 150)
        Me.DataGridView1.TabIndex = 16
        '
        'frmKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 513)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnTh)
        Me.Controls.Add(Me.btnX)
        Me.Controls.Add(Me.btnS)
        Me.Controls.Add(Me.btnT)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblE)
        Me.Controls.Add(Me.lblDC)
        Me.Controls.Add(Me.lblSDT)
        Me.Controls.Add(Me.lblTKH)
        Me.Controls.Add(Me.lblMKH)
        Me.Controls.Add(Me.lblKH)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmKhachHang"
        Me.Text = "KhachHang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblKH As System.Windows.Forms.Label
    Friend WithEvents lblMKH As System.Windows.Forms.Label
    Friend WithEvents lblTKH As System.Windows.Forms.Label
    Friend WithEvents lblSDT As System.Windows.Forms.Label
    Friend WithEvents lblDC As System.Windows.Forms.Label
    Friend WithEvents lblE As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents btnT As System.Windows.Forms.Button
    Friend WithEvents btnS As System.Windows.Forms.Button
    Friend WithEvents btnX As System.Windows.Forms.Button
    Friend WithEvents btnTh As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
