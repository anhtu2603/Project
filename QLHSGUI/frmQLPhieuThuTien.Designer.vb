﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLPhieuThuTien
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btXoaPhieuThuTien = New System.Windows.Forms.Button()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.btCapNhatPhieuThuTien = New System.Windows.Forms.Button()
        Me.txtTienNo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtSoTienThu = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtHoTenKH = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpNgayThu = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaPhieuThuTienTimKiem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvListPhieuThuTien = New System.Windows.Forms.DataGridView()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvListPhieuThuTien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(369, 81)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(447, 331)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btXoaPhieuThuTien)
        Me.TabPage1.Controls.Add(Me.txtMaKH)
        Me.TabPage1.Controls.Add(Me.btCapNhatPhieuThuTien)
        Me.TabPage1.Controls.Add(Me.txtTienNo)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtSDT)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(Me.txtSoTienThu)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtDiaChi)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtHoTenKH)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.dtpNgayThu)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(439, 305)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Thông Tin Phiếu Thu Tiền"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btXoaPhieuThuTien
        '
        Me.btXoaPhieuThuTien.Location = New System.Drawing.Point(230, 276)
        Me.btXoaPhieuThuTien.Name = "btXoaPhieuThuTien"
        Me.btXoaPhieuThuTien.Size = New System.Drawing.Size(75, 23)
        Me.btXoaPhieuThuTien.TabIndex = 43
        Me.btXoaPhieuThuTien.Text = "Xóa"
        Me.btXoaPhieuThuTien.UseVisualStyleBackColor = True
        '
        'txtMaKH
        '
        Me.txtMaKH.Enabled = False
        Me.txtMaKH.Location = New System.Drawing.Point(172, 6)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.ReadOnly = True
        Me.txtMaKH.Size = New System.Drawing.Size(261, 20)
        Me.txtMaKH.TabIndex = 42
        '
        'btCapNhatPhieuThuTien
        '
        Me.btCapNhatPhieuThuTien.Location = New System.Drawing.Point(149, 276)
        Me.btCapNhatPhieuThuTien.Name = "btCapNhatPhieuThuTien"
        Me.btCapNhatPhieuThuTien.Size = New System.Drawing.Size(75, 23)
        Me.btCapNhatPhieuThuTien.TabIndex = 1
        Me.btCapNhatPhieuThuTien.Text = "Cập nhật"
        Me.btCapNhatPhieuThuTien.UseVisualStyleBackColor = True
        '
        'txtTienNo
        '
        Me.txtTienNo.Enabled = False
        Me.txtTienNo.Location = New System.Drawing.Point(172, 184)
        Me.txtTienNo.Name = "txtTienNo"
        Me.txtTienNo.ReadOnly = True
        Me.txtTienNo.Size = New System.Drawing.Size(261, 20)
        Me.txtTienNo.TabIndex = 41
        Me.txtTienNo.WordWrap = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 187)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Số Tiền Nợ"
        '
        'txtSDT
        '
        Me.txtSDT.Enabled = False
        Me.txtSDT.Location = New System.Drawing.Point(172, 158)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.ReadOnly = True
        Me.txtSDT.Size = New System.Drawing.Size(261, 20)
        Me.txtSDT.TabIndex = 39
        Me.txtSDT.WordWrap = False
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(172, 132)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(261, 20)
        Me.txtEmail.TabIndex = 38
        Me.txtEmail.WordWrap = False
        '
        'txtSoTienThu
        '
        Me.txtSoTienThu.BackColor = System.Drawing.SystemColors.Window
        Me.txtSoTienThu.Location = New System.Drawing.Point(172, 210)
        Me.txtSoTienThu.Name = "txtSoTienThu"
        Me.txtSoTienThu.Size = New System.Drawing.Size(261, 20)
        Me.txtSoTienThu.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Số Điện Thoại"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Email"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.BackColor = System.Drawing.SystemColors.Control
        Me.txtDiaChi.Enabled = False
        Me.txtDiaChi.Location = New System.Drawing.Point(172, 59)
        Me.txtDiaChi.Multiline = True
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.ReadOnly = True
        Me.txtDiaChi.Size = New System.Drawing.Size(261, 67)
        Me.txtDiaChi.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Địa Chỉ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Họ Tên Khách Hàng"
        '
        'txtHoTenKH
        '
        Me.txtHoTenKH.Enabled = False
        Me.txtHoTenKH.Location = New System.Drawing.Point(172, 33)
        Me.txtHoTenKH.Name = "txtHoTenKH"
        Me.txtHoTenKH.ReadOnly = True
        Me.txtHoTenKH.Size = New System.Drawing.Size(261, 20)
        Me.txtHoTenKH.TabIndex = 22
        Me.txtHoTenKH.WordWrap = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Số Tiền Thu"
        '
        'dtpNgayThu
        '
        Me.dtpNgayThu.CustomFormat = "MM/dd/yyyy"
        Me.dtpNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayThu.Location = New System.Drawing.Point(172, 236)
        Me.dtpNgayThu.Name = "dtpNgayThu"
        Me.dtpNgayThu.Size = New System.Drawing.Size(261, 20)
        Me.dtpNgayThu.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Ngày Thu Tiền"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Mã Khách Hàng"
        '
        'txtMaPhieuThuTienTimKiem
        '
        Me.txtMaPhieuThuTienTimKiem.Location = New System.Drawing.Point(172, 9)
        Me.txtMaPhieuThuTienTimKiem.Name = "txtMaPhieuThuTienTimKiem"
        Me.txtMaPhieuThuTienTimKiem.Size = New System.Drawing.Size(261, 20)
        Me.txtMaPhieuThuTienTimKiem.TabIndex = 17
        Me.txtMaPhieuThuTienTimKiem.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Phiếu Thu Tiền"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(12, 12)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(351, 400)
        Me.TabControl2.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvListPhieuThuTien)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(343, 374)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Danh Sách Phiếu Thu Tiền"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvListPhieuThuTien
        '
        Me.dgvListPhieuThuTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListPhieuThuTien.Location = New System.Drawing.Point(6, 6)
        Me.dgvListPhieuThuTien.Name = "dgvListPhieuThuTien"
        Me.dgvListPhieuThuTien.Size = New System.Drawing.Size(331, 362)
        Me.dgvListPhieuThuTien.TabIndex = 0
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage3)
        Me.TabControl3.Location = New System.Drawing.Point(369, 12)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(447, 63)
        Me.TabControl3.TabIndex = 3
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.txtMaPhieuThuTienTimKiem)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(439, 37)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Tìm Kiếm"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'frmQLPhieuThuTien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 418)
        Me.Controls.Add(Me.TabControl3)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmQLPhieuThuTien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Phiếu Thu Tiền"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvListPhieuThuTien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btCapNhatPhieuThuTien As Button
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents txtTienNo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtHoTenKH As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpNgayThu As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaPhieuThuTienTimKiem As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSoTienThu As TextBox
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvListPhieuThuTien As DataGridView
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btXoaPhieuThuTien As Button
End Class
