<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrangChu
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
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.AutoSize = True
        Me.button1.BackColor = System.Drawing.Color.Blue
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.button1.Location = New System.Drawing.Point(854, 484)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(115, 45)
        Me.button1.TabIndex = 8
        Me.button1.Text = "Đăng Xuất"
        Me.button1.UseVisualStyleBackColor = False
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = Global.BaiThucHanh.My.Resources.Resources.anh_gif_1_min
        Me.pictureBox2.Location = New System.Drawing.Point(716, -1)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(253, 144)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.BaiThucHanh.My.Resources.Resources.ảnh_gif_buồn_trong_đêm
        Me.pictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(708, 530)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 6
        Me.pictureBox1.TabStop = False
        '
        'TrangChu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(979, 523)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.pictureBox1)
        Me.Name = "TrangChu"
        Me.Text = "TrangChu"
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button1 As Button
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents pictureBox1 As PictureBox
End Class
