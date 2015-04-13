<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoaiSP
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
        Me.lblLSP = New System.Windows.Forms.Label()
        Me.lblMLSP = New System.Windows.Forms.Label()
        Me.lblTL = New System.Windows.Forms.Label()
        Me.lblXX = New System.Windows.Forms.Label()
        Me.lblTT = New System.Windows.Forms.Label()
        Me.lblHD = New System.Windows.Forms.Label()
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
        'lblLSP
        '
        Me.lblLSP.AutoSize = True
        Me.lblLSP.Location = New System.Drawing.Point(240, 22)
        Me.lblLSP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLSP.Name = "lblLSP"
        Me.lblLSP.Size = New System.Drawing.Size(131, 19)
        Me.lblLSP.TabIndex = 0
        Me.lblLSP.Text = "LOẠI SẢN PHẨM"
        '
        'lblMLSP
        '
        Me.lblMLSP.AutoSize = True
        Me.lblMLSP.Location = New System.Drawing.Point(24, 65)
        Me.lblMLSP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMLSP.Name = "lblMLSP"
        Me.lblMLSP.Size = New System.Drawing.Size(126, 19)
        Me.lblMLSP.TabIndex = 1
        Me.lblMLSP.Text = "Mã Loại Sản Phẩm"
        '
        'lblTL
        '
        Me.lblTL.AutoSize = True
        Me.lblTL.Location = New System.Drawing.Point(24, 106)
        Me.lblTL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTL.Name = "lblTL"
        Me.lblTL.Size = New System.Drawing.Size(63, 19)
        Me.lblTL.TabIndex = 2
        Me.lblTL.Text = "Tên Loại"
        '
        'lblXX
        '
        Me.lblXX.AutoSize = True
        Me.lblXX.Location = New System.Drawing.Point(24, 150)
        Me.lblXX.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblXX.Name = "lblXX"
        Me.lblXX.Size = New System.Drawing.Size(58, 19)
        Me.lblXX.TabIndex = 3
        Me.lblXX.Text = "Xuất xứ"
        '
        'lblTT
        '
        Me.lblTT.AutoSize = True
        Me.lblTT.Location = New System.Drawing.Point(24, 195)
        Me.lblTT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTT.Name = "lblTT"
        Me.lblTT.Size = New System.Drawing.Size(73, 19)
        Me.lblTT.TabIndex = 4
        Me.lblTT.Text = "Tình Trạng"
        '
        'lblHD
        '
        Me.lblHD.AutoSize = True
        Me.lblHD.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblHD.Location = New System.Drawing.Point(24, 238)
        Me.lblHD.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHD.Name = "lblHD"
        Me.lblHD.Size = New System.Drawing.Size(80, 19)
        Me.lblHD.TabIndex = 5
        Me.lblHD.Text = "Hướng Dẫn"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(180, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(267, 26)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(180, 103)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(267, 26)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(180, 147)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(267, 26)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(180, 192)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(178, 26)
        Me.TextBox4.TabIndex = 9
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(180, 235)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(343, 26)
        Me.TextBox5.TabIndex = 10
        '
        'btnT
        '
        Me.btnT.Location = New System.Drawing.Point(105, 297)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(75, 23)
        Me.btnT.TabIndex = 11
        Me.btnT.Text = "Thêm"
        Me.btnT.UseVisualStyleBackColor = True
        '
        'btnS
        '
        Me.btnS.Location = New System.Drawing.Point(223, 297)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(75, 23)
        Me.btnS.TabIndex = 12
        Me.btnS.Text = "Sửa"
        Me.btnS.UseVisualStyleBackColor = True
        '
        'btnX
        '
        Me.btnX.Location = New System.Drawing.Point(338, 297)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(75, 23)
        Me.btnX.TabIndex = 13
        Me.btnX.Text = "Xóa"
        Me.btnX.UseVisualStyleBackColor = True
        '
        'btnTh
        '
        Me.btnTh.Location = New System.Drawing.Point(448, 297)
        Me.btnTh.Name = "btnTh"
        Me.btnTh.Size = New System.Drawing.Size(75, 23)
        Me.btnTh.TabIndex = 14
        Me.btnTh.Text = "Thoát"
        Me.btnTh.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 351)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(495, 150)
        Me.DataGridView1.TabIndex = 15
        '
        'frmLoaiSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 513)
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
        Me.Controls.Add(Me.lblHD)
        Me.Controls.Add(Me.lblTT)
        Me.Controls.Add(Me.lblXX)
        Me.Controls.Add(Me.lblTL)
        Me.Controls.Add(Me.lblMLSP)
        Me.Controls.Add(Me.lblLSP)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLoaiSP"
        Me.Text = "LoaiSP"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLSP As System.Windows.Forms.Label
    Friend WithEvents lblMLSP As System.Windows.Forms.Label
    Friend WithEvents lblTL As System.Windows.Forms.Label
    Friend WithEvents lblXX As System.Windows.Forms.Label
    Friend WithEvents lblTT As System.Windows.Forms.Label
    Friend WithEvents lblHD As System.Windows.Forms.Label
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
