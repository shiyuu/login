﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoaDon
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
        Me.lblHD = New System.Windows.Forms.Label()
        Me.lblMHD = New System.Windows.Forms.Label()
        Me.lblMKH = New System.Windows.Forms.Label()
        Me.lblSL = New System.Windows.Forms.Label()
        Me.lblDG = New System.Windows.Forms.Label()
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHD
        '
        Me.lblHD.AutoSize = True
        Me.lblHD.Location = New System.Drawing.Point(266, 21)
        Me.lblHD.Name = "lblHD"
        Me.lblHD.Size = New System.Drawing.Size(81, 19)
        Me.lblHD.TabIndex = 0
        Me.lblHD.Text = "HÓA ĐƠN"
        '
        'lblMHD
        '
        Me.lblMHD.AutoSize = True
        Me.lblMHD.Location = New System.Drawing.Point(32, 76)
        Me.lblMHD.Name = "lblMHD"
        Me.lblMHD.Size = New System.Drawing.Size(90, 19)
        Me.lblMHD.TabIndex = 1
        Me.lblMHD.Text = "Mã Hóa Đơn"
        '
        'lblMKH
        '
        Me.lblMKH.AutoSize = True
        Me.lblMKH.Location = New System.Drawing.Point(32, 122)
        Me.lblMKH.Name = "lblMKH"
        Me.lblMKH.Size = New System.Drawing.Size(110, 19)
        Me.lblMKH.TabIndex = 2
        Me.lblMKH.Text = "Mã Khách Hàng"
        '
        'lblSL
        '
        Me.lblSL.AutoSize = True
        Me.lblSL.Location = New System.Drawing.Point(31, 206)
        Me.lblSL.Name = "lblSL"
        Me.lblSL.Size = New System.Drawing.Size(70, 19)
        Me.lblSL.TabIndex = 3
        Me.lblSL.Text = "Số Lượng"
        '
        'lblDG
        '
        Me.lblDG.AutoSize = True
        Me.lblDG.Location = New System.Drawing.Point(32, 164)
        Me.lblDG.Name = "lblDG"
        Me.lblDG.Size = New System.Drawing.Size(60, 19)
        Me.lblDG.TabIndex = 4
        Me.lblDG.Text = "Đơn Giá"
        '
        'lblTT
        '
        Me.lblTT.AutoSize = True
        Me.lblTT.Location = New System.Drawing.Point(32, 253)
        Me.lblTT.Name = "lblTT"
        Me.lblTT.Size = New System.Drawing.Size(69, 19)
        Me.lblTT.TabIndex = 5
        Me.lblTT.Text = "Tổng Tiền"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(184, 76)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(271, 26)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(184, 122)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(271, 26)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(184, 161)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(271, 26)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(184, 203)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(271, 26)
        Me.TextBox4.TabIndex = 9
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(184, 246)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(271, 26)
        Me.TextBox5.TabIndex = 10
        '
        'btnT
        '
        Me.btnT.Location = New System.Drawing.Point(133, 301)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(75, 23)
        Me.btnT.TabIndex = 11
        Me.btnT.Text = "Thêm"
        Me.btnT.UseVisualStyleBackColor = True
        '
        'btnS
        '
        Me.btnS.Location = New System.Drawing.Point(260, 301)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(75, 23)
        Me.btnS.TabIndex = 12
        Me.btnS.Text = "Sửa"
        Me.btnS.UseVisualStyleBackColor = True
        '
        'btnX
        '
        Me.btnX.Location = New System.Drawing.Point(380, 301)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(75, 23)
        Me.btnX.TabIndex = 13
        Me.btnX.Text = "Xóa"
        Me.btnX.UseVisualStyleBackColor = True
        '
        'btnTh
        '
        Me.btnTh.Location = New System.Drawing.Point(494, 301)
        Me.btnTh.Name = "btnTh"
        Me.btnTh.Size = New System.Drawing.Size(75, 23)
        Me.btnTh.TabIndex = 14
        Me.btnTh.Text = "Thoát"
        Me.btnTh.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 353)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(575, 150)
        Me.DataGridView1.TabIndex = 15
        '
        'frmHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 515)
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
        Me.Controls.Add(Me.lblDG)
        Me.Controls.Add(Me.lblSL)
        Me.Controls.Add(Me.lblMKH)
        Me.Controls.Add(Me.lblMHD)
        Me.Controls.Add(Me.lblHD)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmHoaDon"
        Me.Text = "HoaDon"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHD As System.Windows.Forms.Label
    Friend WithEvents lblMHD As System.Windows.Forms.Label
    Friend WithEvents lblMKH As System.Windows.Forms.Label
    Friend WithEvents lblSL As System.Windows.Forms.Label
    Friend WithEvents lblDG As System.Windows.Forms.Label
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
End Class
