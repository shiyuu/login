<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChiTietHD
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
        Me.lblCTHD = New System.Windows.Forms.Label()
        Me.lblMHD = New System.Windows.Forms.Label()
        Me.lblMSP = New System.Windows.Forms.Label()
        Me.lblNI = New System.Windows.Forms.Label()
        Me.lblNG = New System.Windows.Forms.Label()
        Me.lblTT = New System.Windows.Forms.Label()
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
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCTHD
        '
        Me.lblCTHD.AutoSize = True
        Me.lblCTHD.Location = New System.Drawing.Point(238, 22)
        Me.lblCTHD.Name = "lblCTHD"
        Me.lblCTHD.Size = New System.Drawing.Size(148, 19)
        Me.lblCTHD.TabIndex = 0
        Me.lblCTHD.Text = "CHI TIẾT HÓA ĐƠN"
        '
        'lblMHD
        '
        Me.lblMHD.AutoSize = True
        Me.lblMHD.Location = New System.Drawing.Point(32, 75)
        Me.lblMHD.Name = "lblMHD"
        Me.lblMHD.Size = New System.Drawing.Size(90, 19)
        Me.lblMHD.TabIndex = 1
        Me.lblMHD.Text = "Mã Hóa Đơn"
        '
        'lblMSP
        '
        Me.lblMSP.AutoSize = True
        Me.lblMSP.Location = New System.Drawing.Point(32, 112)
        Me.lblMSP.Name = "lblMSP"
        Me.lblMSP.Size = New System.Drawing.Size(95, 19)
        Me.lblMSP.TabIndex = 2
        Me.lblMSP.Text = "Mã Sản Phẩm"
        '
        'lblNI
        '
        Me.lblNI.AutoSize = True
        Me.lblNI.Location = New System.Drawing.Point(32, 148)
        Me.lblNI.Name = "lblNI"
        Me.lblNI.Size = New System.Drawing.Size(58, 19)
        Me.lblNI.TabIndex = 3
        Me.lblNI.Text = "Ngày In"
        '
        'lblNG
        '
        Me.lblNG.AutoSize = True
        Me.lblNG.Location = New System.Drawing.Point(32, 184)
        Me.lblNG.Name = "lblNG"
        Me.lblNG.Size = New System.Drawing.Size(75, 19)
        Me.lblNG.TabIndex = 4
        Me.lblNG.Text = "Ngày Giao"
        '
        'lblTT
        '
        Me.lblTT.AutoSize = True
        Me.lblTT.Location = New System.Drawing.Point(32, 221)
        Me.lblTT.Name = "lblTT"
        Me.lblTT.Size = New System.Drawing.Size(69, 19)
        Me.lblTT.TabIndex = 5
        Me.lblTT.Text = "Tổng Tiền"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(203, 73)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(305, 26)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(203, 109)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(305, 26)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(203, 145)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(305, 26)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(203, 181)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(305, 26)
        Me.TextBox4.TabIndex = 9
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(203, 218)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(305, 26)
        Me.TextBox5.TabIndex = 10
        '
        'btnT
        '
        Me.btnT.Location = New System.Drawing.Point(120, 319)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(75, 23)
        Me.btnT.TabIndex = 11
        Me.btnT.Text = "Thêm"
        Me.btnT.UseVisualStyleBackColor = True
        '
        'btnS
        '
        Me.btnS.Location = New System.Drawing.Point(256, 319)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(75, 23)
        Me.btnS.TabIndex = 12
        Me.btnS.Text = "Sửa"
        Me.btnS.UseVisualStyleBackColor = True
        '
        'btnX
        '
        Me.btnX.Location = New System.Drawing.Point(381, 319)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(75, 23)
        Me.btnX.TabIndex = 13
        Me.btnX.Text = "Xóa"
        Me.btnX.UseVisualStyleBackColor = True
        '
        'btnTh
        '
        Me.btnTh.Location = New System.Drawing.Point(502, 319)
        Me.btnTh.Name = "btnTh"
        Me.btnTh.Size = New System.Drawing.Size(75, 23)
        Me.btnTh.TabIndex = 14
        Me.btnTh.Text = "Thoát"
        Me.btnTh.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 363)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(585, 175)
        Me.DataGridView1.TabIndex = 15
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(203, 260)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(305, 26)
        Me.TextBox6.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 263)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Mã Hóa Đơn"
        '
        'frmChiTietHD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 538)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox6)
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
        Me.Controls.Add(Me.lblTT)
        Me.Controls.Add(Me.lblNG)
        Me.Controls.Add(Me.lblNI)
        Me.Controls.Add(Me.lblMSP)
        Me.Controls.Add(Me.lblMHD)
        Me.Controls.Add(Me.lblCTHD)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmChiTietHD"
        Me.Text = "ChiTietHD"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCTHD As System.Windows.Forms.Label
    Friend WithEvents lblMHD As System.Windows.Forms.Label
    Friend WithEvents lblMSP As System.Windows.Forms.Label
    Friend WithEvents lblNI As System.Windows.Forms.Label
    Friend WithEvents lblNG As System.Windows.Forms.Label
    Friend WithEvents lblTT As System.Windows.Forms.Label
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
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
