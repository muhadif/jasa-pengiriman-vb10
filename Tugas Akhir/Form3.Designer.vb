<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.panel_pengirim = New System.Windows.Forms.Panel()
        Me.Panel_penerima = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_check_harga = New System.Windows.Forms.Button()
        Me.tb_kota_r = New System.Windows.Forms.TextBox()
        Me.tb_kota_s = New System.Windows.Forms.TextBox()
        Me.btn_prev = New System.Windows.Forms.Button()
        Me.cb_kota_r = New System.Windows.Forms.ComboBox()
        Me.tb_biaya = New System.Windows.Forms.TextBox()
        Me.tb_kontak_r = New System.Windows.Forms.TextBox()
        Me.tb_alamat_r = New System.Windows.Forms.TextBox()
        Me.tb_nama_r = New System.Windows.Forms.TextBox()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.cb_kota_s = New System.Windows.Forms.ComboBox()
        Me.btn_generate = New System.Windows.Forms.Button()
        Me.cb_jenispaket = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_berat = New System.Windows.Forms.TextBox()
        Me.tb_barang = New System.Windows.Forms.TextBox()
        Me.tb_kontak_s = New System.Windows.Forms.TextBox()
        Me.tb_alamat_s = New System.Windows.Forms.TextBox()
        Me.tb_kode = New System.Windows.Forms.TextBox()
        Me.tb_nama_s = New System.Windows.Forms.TextBox()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.panel_pengirim.SuspendLayout()
        Me.Panel_penerima.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_pengirim
        '
        Me.panel_pengirim.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.panel_pengirim2
        Me.panel_pengirim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_pengirim.Controls.Add(Me.Panel_penerima)
        Me.panel_pengirim.Controls.Add(Me.cb_kota_s)
        Me.panel_pengirim.Controls.Add(Me.btn_generate)
        Me.panel_pengirim.Controls.Add(Me.cb_jenispaket)
        Me.panel_pengirim.Controls.Add(Me.Label1)
        Me.panel_pengirim.Controls.Add(Me.tb_berat)
        Me.panel_pengirim.Controls.Add(Me.tb_barang)
        Me.panel_pengirim.Controls.Add(Me.tb_kontak_s)
        Me.panel_pengirim.Controls.Add(Me.tb_alamat_s)
        Me.panel_pengirim.Controls.Add(Me.tb_kode)
        Me.panel_pengirim.Controls.Add(Me.tb_nama_s)
        Me.panel_pengirim.Controls.Add(Me.btn_next)
        Me.panel_pengirim.Location = New System.Drawing.Point(193, 66)
        Me.panel_pengirim.Name = "panel_pengirim"
        Me.panel_pengirim.Size = New System.Drawing.Size(652, 434)
        Me.panel_pengirim.TabIndex = 0
        '
        'Panel_penerima
        '
        Me.Panel_penerima.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.panel_penerima4
        Me.Panel_penerima.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_penerima.Controls.Add(Me.Button1)
        Me.Panel_penerima.Controls.Add(Me.btn_check_harga)
        Me.Panel_penerima.Controls.Add(Me.tb_kota_r)
        Me.Panel_penerima.Controls.Add(Me.tb_kota_s)
        Me.Panel_penerima.Controls.Add(Me.btn_prev)
        Me.Panel_penerima.Controls.Add(Me.cb_kota_r)
        Me.Panel_penerima.Controls.Add(Me.tb_biaya)
        Me.Panel_penerima.Controls.Add(Me.tb_kontak_r)
        Me.Panel_penerima.Controls.Add(Me.tb_alamat_r)
        Me.Panel_penerima.Controls.Add(Me.tb_nama_r)
        Me.Panel_penerima.Controls.Add(Me.btn_submit)
        Me.Panel_penerima.Location = New System.Drawing.Point(0, -1)
        Me.Panel_penerima.Name = "Panel_penerima"
        Me.Panel_penerima.Size = New System.Drawing.Size(652, 434)
        Me.Panel_penerima.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(447, 387)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_check_harga
        '
        Me.btn_check_harga.BackColor = System.Drawing.Color.Gold
        Me.btn_check_harga.FlatAppearance.BorderSize = 0
        Me.btn_check_harga.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_check_harga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_check_harga.Location = New System.Drawing.Point(452, 321)
        Me.btn_check_harga.Name = "btn_check_harga"
        Me.btn_check_harga.Size = New System.Drawing.Size(70, 31)
        Me.btn_check_harga.TabIndex = 19
        Me.btn_check_harga.Text = "Check"
        Me.btn_check_harga.UseVisualStyleBackColor = False
        '
        'tb_kota_r
        '
        Me.tb_kota_r.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_kota_r.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_kota_r.Location = New System.Drawing.Point(294, 288)
        Me.tb_kota_r.Name = "tb_kota_r"
        Me.tb_kota_r.Size = New System.Drawing.Size(135, 19)
        Me.tb_kota_r.TabIndex = 18
        '
        'tb_kota_s
        '
        Me.tb_kota_s.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_kota_s.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_kota_s.Location = New System.Drawing.Point(104, 288)
        Me.tb_kota_s.Name = "tb_kota_s"
        Me.tb_kota_s.Size = New System.Drawing.Size(135, 19)
        Me.tb_kota_s.TabIndex = 17
        '
        'btn_prev
        '
        Me.btn_prev.BackColor = System.Drawing.Color.Gold
        Me.btn_prev.FlatAppearance.BorderSize = 0
        Me.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_prev.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_prev.Location = New System.Drawing.Point(69, 382)
        Me.btn_prev.Name = "btn_prev"
        Me.btn_prev.Size = New System.Drawing.Size(93, 31)
        Me.btn_prev.TabIndex = 16
        Me.btn_prev.Text = "Back"
        Me.btn_prev.UseVisualStyleBackColor = False
        '
        'cb_kota_r
        '
        Me.cb_kota_r.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_kota_r.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_kota_r.FormattingEnabled = True
        Me.cb_kota_r.Location = New System.Drawing.Point(104, 202)
        Me.cb_kota_r.Name = "cb_kota_r"
        Me.cb_kota_r.Size = New System.Drawing.Size(249, 23)
        Me.cb_kota_r.TabIndex = 15
        '
        'tb_biaya
        '
        Me.tb_biaya.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_biaya.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_biaya.Location = New System.Drawing.Point(104, 332)
        Me.tb_biaya.Name = "tb_biaya"
        Me.tb_biaya.Size = New System.Drawing.Size(330, 19)
        Me.tb_biaya.TabIndex = 7
        '
        'tb_kontak_r
        '
        Me.tb_kontak_r.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_kontak_r.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_kontak_r.Location = New System.Drawing.Point(374, 207)
        Me.tb_kontak_r.Name = "tb_kontak_r"
        Me.tb_kontak_r.Size = New System.Drawing.Size(181, 19)
        Me.tb_kontak_r.TabIndex = 5
        '
        'tb_alamat_r
        '
        Me.tb_alamat_r.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_alamat_r.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_alamat_r.Location = New System.Drawing.Point(104, 161)
        Me.tb_alamat_r.Name = "tb_alamat_r"
        Me.tb_alamat_r.Size = New System.Drawing.Size(441, 19)
        Me.tb_alamat_r.TabIndex = 3
        '
        'tb_nama_r
        '
        Me.tb_nama_r.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_nama_r.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nama_r.Location = New System.Drawing.Point(104, 118)
        Me.tb_nama_r.Name = "tb_nama_r"
        Me.tb_nama_r.Size = New System.Drawing.Size(441, 19)
        Me.tb_nama_r.TabIndex = 1
        '
        'btn_submit
        '
        Me.btn_submit.BackColor = System.Drawing.Color.Gold
        Me.btn_submit.FlatAppearance.BorderSize = 0
        Me.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_submit.Location = New System.Drawing.Point(534, 382)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(93, 31)
        Me.btn_submit.TabIndex = 0
        Me.btn_submit.Text = "SUBMIT"
        Me.btn_submit.UseVisualStyleBackColor = False
        '
        'cb_kota_s
        '
        Me.cb_kota_s.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_kota_s.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_kota_s.FormattingEnabled = True
        Me.cb_kota_s.Location = New System.Drawing.Point(104, 202)
        Me.cb_kota_s.Name = "cb_kota_s"
        Me.cb_kota_s.Size = New System.Drawing.Size(249, 23)
        Me.cb_kota_s.TabIndex = 14
        '
        'btn_generate
        '
        Me.btn_generate.BackColor = System.Drawing.Color.Gold
        Me.btn_generate.FlatAppearance.BorderSize = 0
        Me.btn_generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_generate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_generate.Location = New System.Drawing.Point(570, 107)
        Me.btn_generate.Name = "btn_generate"
        Me.btn_generate.Size = New System.Drawing.Size(70, 31)
        Me.btn_generate.TabIndex = 13
        Me.btn_generate.Text = "Generate"
        Me.btn_generate.UseVisualStyleBackColor = False
        '
        'cb_jenispaket
        '
        Me.cb_jenispaket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_jenispaket.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_jenispaket.FormattingEnabled = True
        Me.cb_jenispaket.Location = New System.Drawing.Point(104, 372)
        Me.cb_jenispaket.Name = "cb_jenispaket"
        Me.cb_jenispaket.Size = New System.Drawing.Size(299, 23)
        Me.cb_jenispaket.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(359, 323)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Kg"
        '
        'tb_berat
        '
        Me.tb_berat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_berat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_berat.Location = New System.Drawing.Point(104, 332)
        Me.tb_berat.Name = "tb_berat"
        Me.tb_berat.Size = New System.Drawing.Size(230, 19)
        Me.tb_berat.TabIndex = 8
        '
        'tb_barang
        '
        Me.tb_barang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_barang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_barang.Location = New System.Drawing.Point(104, 288)
        Me.tb_barang.Name = "tb_barang"
        Me.tb_barang.Size = New System.Drawing.Size(299, 19)
        Me.tb_barang.TabIndex = 7
        '
        'tb_kontak_s
        '
        Me.tb_kontak_s.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_kontak_s.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_kontak_s.Location = New System.Drawing.Point(374, 207)
        Me.tb_kontak_s.Name = "tb_kontak_s"
        Me.tb_kontak_s.Size = New System.Drawing.Size(181, 19)
        Me.tb_kontak_s.TabIndex = 5
        '
        'tb_alamat_s
        '
        Me.tb_alamat_s.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_alamat_s.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_alamat_s.Location = New System.Drawing.Point(104, 161)
        Me.tb_alamat_s.Name = "tb_alamat_s"
        Me.tb_alamat_s.Size = New System.Drawing.Size(451, 19)
        Me.tb_alamat_s.TabIndex = 3
        '
        'tb_kode
        '
        Me.tb_kode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_kode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_kode.Location = New System.Drawing.Point(418, 118)
        Me.tb_kode.Name = "tb_kode"
        Me.tb_kode.Size = New System.Drawing.Size(137, 19)
        Me.tb_kode.TabIndex = 2
        '
        'tb_nama_s
        '
        Me.tb_nama_s.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_nama_s.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nama_s.Location = New System.Drawing.Point(104, 118)
        Me.tb_nama_s.Name = "tb_nama_s"
        Me.tb_nama_s.Size = New System.Drawing.Size(299, 19)
        Me.tb_nama_s.TabIndex = 1
        '
        'btn_next
        '
        Me.btn_next.BackColor = System.Drawing.Color.Gold
        Me.btn_next.FlatAppearance.BorderSize = 0
        Me.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_next.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.Location = New System.Drawing.Point(534, 363)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(93, 31)
        Me.btn_next.TabIndex = 0
        Me.btn_next.Text = "NEXT"
        Me.btn_next.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.Transparent
        Me.btn_exit.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.btn_exit1
        Me.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Location = New System.Drawing.Point(798, 23)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(22, 22)
        Me.btn_exit.TabIndex = 3
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Transparent
        Me.btn_back.BackgroundImage = CType(resources.GetObject("btn_back.BackgroundImage"), System.Drawing.Image)
        Me.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_back.FlatAppearance.BorderSize = 0
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Location = New System.Drawing.Point(12, 19)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(20, 30)
        Me.btn_back.TabIndex = 4
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.White
        Me.UsernameLabel.Location = New System.Drawing.Point(55, 157)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(97, 31)
        Me.UsernameLabel.TabIndex = 20
        Me.UsernameLabel.Text = "Admin"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.form_21
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(845, 500)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.panel_pengirim)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.panel_pengirim.ResumeLayout(False)
        Me.panel_pengirim.PerformLayout()
        Me.Panel_penerima.ResumeLayout(False)
        Me.Panel_penerima.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel_pengirim As System.Windows.Forms.Panel
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents tb_nama_s As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_berat As System.Windows.Forms.TextBox
    Friend WithEvents tb_barang As System.Windows.Forms.TextBox
    Friend WithEvents tb_kontak_s As System.Windows.Forms.TextBox
    Friend WithEvents tb_alamat_s As System.Windows.Forms.TextBox
    Friend WithEvents tb_kode As System.Windows.Forms.TextBox
    Friend WithEvents cb_jenispaket As System.Windows.Forms.ComboBox
    Friend WithEvents Panel_penerima As System.Windows.Forms.Panel
    Friend WithEvents tb_biaya As System.Windows.Forms.TextBox
    Friend WithEvents tb_kontak_r As System.Windows.Forms.TextBox
    Friend WithEvents tb_alamat_r As System.Windows.Forms.TextBox
    Friend WithEvents tb_nama_r As System.Windows.Forms.TextBox
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents btn_generate As System.Windows.Forms.Button
    Friend WithEvents cb_kota_s As System.Windows.Forms.ComboBox
    Friend WithEvents cb_kota_r As System.Windows.Forms.ComboBox
    Friend WithEvents btn_prev As System.Windows.Forms.Button
    Friend WithEvents tb_kota_r As System.Windows.Forms.TextBox
    Friend WithEvents tb_kota_s As System.Windows.Forms.TextBox
    Friend WithEvents btn_check_harga As System.Windows.Forms.Button
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
