<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SáchThiếuNhiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SáchNgoạiNgữToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SáchKỹNăngSốngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GiớiThiệuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SáchTriếtLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DangToolStripMenuItem, Me.SảnPhẩmToolStripMenuItem, Me.GiớiThiệuToolStripMenuItem, Me.ThoátToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(892, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DangToolStripMenuItem
        '
        Me.DangToolStripMenuItem.Name = "DangToolStripMenuItem"
        Me.DangToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.DangToolStripMenuItem.Text = "Đăng Nhập"
        '
        'SảnPhẩmToolStripMenuItem
        '
        Me.SảnPhẩmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SáchThiếuNhiToolStripMenuItem, Me.SáchNgoạiNgữToolStripMenuItem, Me.SáchKỹNăngSốngToolStripMenuItem, Me.SáchTriếtLýToolStripMenuItem})
        Me.SảnPhẩmToolStripMenuItem.Name = "SảnPhẩmToolStripMenuItem"
        Me.SảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.SảnPhẩmToolStripMenuItem.Text = "Thể Loại Sách"
        '
        'SáchThiếuNhiToolStripMenuItem
        '
        Me.SáchThiếuNhiToolStripMenuItem.Name = "SáchThiếuNhiToolStripMenuItem"
        Me.SáchThiếuNhiToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SáchThiếuNhiToolStripMenuItem.Text = "Sách Thiếu Nhi"
        '
        'SáchNgoạiNgữToolStripMenuItem
        '
        Me.SáchNgoạiNgữToolStripMenuItem.Name = "SáchNgoạiNgữToolStripMenuItem"
        Me.SáchNgoạiNgữToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SáchNgoạiNgữToolStripMenuItem.Text = "Sách Ngoại Ngữ"
        '
        'SáchKỹNăngSốngToolStripMenuItem
        '
        Me.SáchKỹNăngSốngToolStripMenuItem.Name = "SáchKỹNăngSốngToolStripMenuItem"
        Me.SáchKỹNăngSốngToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SáchKỹNăngSốngToolStripMenuItem.Text = "Sách Kỹ Năng Sống"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.ThoátToolStripMenuItem.Text = "Thoát"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(580, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 3
        '
        'GiớiThiệuToolStripMenuItem
        '
        Me.GiớiThiệuToolStripMenuItem.Name = "GiớiThiệuToolStripMenuItem"
        Me.GiớiThiệuToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.GiớiThiệuToolStripMenuItem.Text = "Giới Thiệu"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BaiThucHanh.My.Resources.Resources.one
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(892, 544)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'SáchTriếtLýToolStripMenuItem
        '
        Me.SáchTriếtLýToolStripMenuItem.Name = "SáchTriếtLýToolStripMenuItem"
        Me.SáchTriếtLýToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SáchTriếtLýToolStripMenuItem.Text = "Sách Tiểu Thuyết"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(892, 566)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Quanlybansach.vb"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SảnPhẩmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SáchThiếuNhiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SáchNgoạiNgữToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SáchKỹNăngSốngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GiớiThiệuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SáchTriếtLýToolStripMenuItem As ToolStripMenuItem
End Class
