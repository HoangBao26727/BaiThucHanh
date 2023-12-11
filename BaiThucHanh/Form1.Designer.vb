<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TrangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SáchThiếuNhiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SáchNgoạiNgữToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SáchKỹNăngSốngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SáchTriếtLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GiớiThiệuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrangToolStripMenuItem, Me.SảnPhẩmToolStripMenuItem, Me.GiớiThiệuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1175, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TrangToolStripMenuItem
        '
        Me.TrangToolStripMenuItem.Name = "TrangToolStripMenuItem"
        Me.TrangToolStripMenuItem.Size = New System.Drawing.Size(94, 24)
        Me.TrangToolStripMenuItem.Text = "Trang Chủ"
        '
        'SảnPhẩmToolStripMenuItem
        '
        Me.SảnPhẩmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SáchThiếuNhiToolStripMenuItem, Me.SáchNgoạiNgữToolStripMenuItem, Me.SáchKỹNăngSốngToolStripMenuItem, Me.SáchTriếtLýToolStripMenuItem})
        Me.SảnPhẩmToolStripMenuItem.Name = "SảnPhẩmToolStripMenuItem"
        Me.SảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(118, 24)
        Me.SảnPhẩmToolStripMenuItem.Text = "Thể Loại Sách"
        '
        'SáchThiếuNhiToolStripMenuItem
        '
        Me.SáchThiếuNhiToolStripMenuItem.Name = "SáchThiếuNhiToolStripMenuItem"
        Me.SáchThiếuNhiToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.SáchThiếuNhiToolStripMenuItem.Text = "Sách Thiếu Nhi"
        '
        'SáchNgoạiNgữToolStripMenuItem
        '
        Me.SáchNgoạiNgữToolStripMenuItem.Name = "SáchNgoạiNgữToolStripMenuItem"
        Me.SáchNgoạiNgữToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.SáchNgoạiNgữToolStripMenuItem.Text = "Sách Ngoại Ngữ"
        '
        'SáchKỹNăngSốngToolStripMenuItem
        '
        Me.SáchKỹNăngSốngToolStripMenuItem.Name = "SáchKỹNăngSốngToolStripMenuItem"
        Me.SáchKỹNăngSốngToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.SáchKỹNăngSốngToolStripMenuItem.Text = "Sách Kỹ Năng Sống"
        '
        'SáchTriếtLýToolStripMenuItem
        '
        Me.SáchTriếtLýToolStripMenuItem.Name = "SáchTriếtLýToolStripMenuItem"
        Me.SáchTriếtLýToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.SáchTriếtLýToolStripMenuItem.Text = "Sách Tiểu Thuyết"
        '
        'GiớiThiệuToolStripMenuItem
        '
        Me.GiớiThiệuToolStripMenuItem.Name = "GiớiThiệuToolStripMenuItem"
        Me.GiớiThiệuToolStripMenuItem.Size = New System.Drawing.Size(94, 24)
        Me.GiớiThiệuToolStripMenuItem.Text = "Giới Thiệu"
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
        Me.Label1.Location = New System.Drawing.Point(773, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BaiThucHanh.My.Resources.Resources.cuốn_sách1
        Me.PictureBox1.Location = New System.Drawing.Point(-11, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1188, 581)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1175, 610)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Quanlybansach.vb"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SảnPhẩmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SáchThiếuNhiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SáchNgoạiNgữToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SáchKỹNăngSốngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents GiớiThiệuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SáchTriếtLýToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
