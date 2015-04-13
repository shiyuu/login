<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDN
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
        Me.lblDN = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblMK = New System.Windows.Forms.Label()
        Me.btnDN = New System.Windows.Forms.Button()
        Me.btnNL = New System.Windows.Forms.Button()
        Me.txtDN = New System.Windows.Forms.TextBox()
        Me.txtMK = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblDN
        '
        Me.lblDN.AutoSize = True
        Me.lblDN.Location = New System.Drawing.Point(155, 21)
        Me.lblDN.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDN.Name = "lblDN"
        Me.lblDN.Size = New System.Drawing.Size(101, 19)
        Me.lblDN.TabIndex = 0
        Me.lblDN.Text = "ĐĂNG NHẬP"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblUser.Location = New System.Drawing.Point(13, 70)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(96, 17)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "Tên đăng nhập"
        '
        'lblMK
        '
        Me.lblMK.AutoSize = True
        Me.lblMK.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMK.Location = New System.Drawing.Point(13, 136)
        Me.lblMK.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMK.Name = "lblMK"
        Me.lblMK.Size = New System.Drawing.Size(64, 17)
        Me.lblMK.TabIndex = 2
        Me.lblMK.Text = "Mật khẩu"
        '
        'btnDN
        '
        Me.btnDN.Location = New System.Drawing.Point(131, 196)
        Me.btnDN.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDN.Name = "btnDN"
        Me.btnDN.Size = New System.Drawing.Size(92, 34)
        Me.btnDN.TabIndex = 3
        Me.btnDN.Text = "Đăng nhập"
        Me.btnDN.UseVisualStyleBackColor = True
        '
        'btnNL
        '
        Me.btnNL.Location = New System.Drawing.Point(268, 196)
        Me.btnNL.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNL.Name = "btnNL"
        Me.btnNL.Size = New System.Drawing.Size(92, 34)
        Me.btnNL.TabIndex = 4
        Me.btnNL.Text = "Nhập lại"
        Me.btnNL.UseVisualStyleBackColor = True
        '
        'txtDN
        '
        Me.txtDN.Location = New System.Drawing.Point(131, 65)
        Me.txtDN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDN.Name = "txtDN"
        Me.txtDN.Size = New System.Drawing.Size(229, 26)
        Me.txtDN.TabIndex = 5
        '
        'txtMK
        '
        Me.txtMK.Location = New System.Drawing.Point(131, 131)
        Me.txtMK.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMK.Name = "txtMK"
        Me.txtMK.Size = New System.Drawing.Size(229, 26)
        Me.txtMK.TabIndex = 6
        '
        'frmDN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 259)
        Me.Controls.Add(Me.txtMK)
        Me.Controls.Add(Me.txtDN)
        Me.Controls.Add(Me.btnNL)
        Me.Controls.Add(Me.btnDN)
        Me.Controls.Add(Me.lblMK)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblDN)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDN"
        Me.Text = "Đăng nhập"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDN As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblMK As System.Windows.Forms.Label
    Friend WithEvents btnDN As System.Windows.Forms.Button
    Friend WithEvents btnNL As System.Windows.Forms.Button
    Friend WithEvents txtDN As System.Windows.Forms.TextBox
    Friend WithEvents txtMK As System.Windows.Forms.TextBox

End Class
