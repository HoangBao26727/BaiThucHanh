<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThongKe
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnThongKe = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtLoaiSach = New System.Windows.Forms.TextBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtLoaiSach)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.btnThongKe)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(962, 358)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(8, 385)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(677, 360)
        Me.DataGridView1.TabIndex = 1
        '
        'btnThongKe
        '
        Me.btnThongKe.Font = New System.Drawing.Font("Niagara Engraved", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThongKe.ForeColor = System.Drawing.Color.Red
        Me.btnThongKe.Location = New System.Drawing.Point(351, 295)
        Me.btnThongKe.Name = "btnThongKe"
        Me.btnThongKe.Size = New System.Drawing.Size(205, 60)
        Me.btnThongKe.TabIndex = 0
        Me.btnThongKe.Text = "Thống Kê"
        Me.btnThongKe.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(0, 56)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(89, 20)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Loại Sách"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(3, 232)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(104, 20)
        Me.CheckBox2.TabIndex = 2
        Me.CheckBox2.Text = "Ngày Tháng"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(123, 228)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(123, 22)
        Me.DateTimePicker1.TabIndex = 3
        '
        'txtLoaiSach
        '
        Me.txtLoaiSach.Location = New System.Drawing.Point(103, 54)
        Me.txtLoaiSach.Name = "txtLoaiSach"
        Me.txtLoaiSach.Size = New System.Drawing.Size(136, 22)
        Me.txtLoaiSach.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "Loại Sách"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Tên Sách"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Số Lượng "
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Tiền Lãi"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Ngày Tháng"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'ThongKe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 753)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ThongKe"
        Me.Text = "ThongKe"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnThongKe As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtLoaiSach As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
