<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuenMatKhau
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
        Me.button1 = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txt_TenTaiKhoan = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.AutoSize = True
        Me.button1.BackColor = System.Drawing.Color.Blue
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.button1.Location = New System.Drawing.Point(314, 372)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(159, 45)
        Me.button1.TabIndex = 19
        Me.button1.Text = "Lấy Lại Mật Khẩu"
        Me.button1.UseVisualStyleBackColor = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Blue
        Me.label2.Location = New System.Drawing.Point(163, 309)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(89, 24)
        Me.label2.TabIndex = 18
        Me.label2.Text = "Kết Quả:"
        '
        'txt_TenTaiKhoan
        '
        Me.txt_TenTaiKhoan.Location = New System.Drawing.Point(314, 221)
        Me.txt_TenTaiKhoan.Name = "txt_TenTaiKhoan"
        Me.txt_TenTaiKhoan.Size = New System.Drawing.Size(323, 22)
        Me.txt_TenTaiKhoan.TabIndex = 17
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Blue
        Me.label1.Location = New System.Drawing.Point(163, 221)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(145, 24)
        Me.label1.TabIndex = 16
        Me.label1.Text = "Email đăng ký:"
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.BaiThucHanh.My.Resources.Resources.gif2
        Me.pictureBox1.Location = New System.Drawing.Point(245, 34)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(228, 142)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 15
        Me.pictureBox1.TabStop = False
        '
        'QuenMatKhau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 450)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txt_TenTaiKhoan)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Name = "QuenMatKhau"
        Me.Text = "QuenMatKhau"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button1 As Button
    Private WithEvents label2 As Label
    Private WithEvents txt_TenTaiKhoan As TextBox
    Private WithEvents label1 As Label
    Private WithEvents pictureBox1 As PictureBox
End Class
