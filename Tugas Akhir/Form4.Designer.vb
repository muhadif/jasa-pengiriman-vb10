<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Panel_penerima = New System.Windows.Forms.Panel()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSender = New System.Windows.Forms.Label()
        Me.lblSenderAddress = New System.Windows.Forms.Label()
        Me.lblReciverAddress = New System.Windows.Forms.Label()
        Me.lblReceiver = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.tbLocation = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblLastLocation = New System.Windows.Forms.Label()
        Me.Panel_penerima.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_penerima
        '
        Me.Panel_penerima.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.panel_search_user2
        Me.Panel_penerima.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_penerima.Controls.Add(Me.lblLastLocation)
        Me.Panel_penerima.Controls.Add(Me.Label7)
        Me.Panel_penerima.Controls.Add(Me.btnUpdate)
        Me.Panel_penerima.Controls.Add(Me.tbLocation)
        Me.Panel_penerima.Controls.Add(Me.lblWeight)
        Me.Panel_penerima.Controls.Add(Me.lblReciverAddress)
        Me.Panel_penerima.Controls.Add(Me.lblReceiver)
        Me.Panel_penerima.Controls.Add(Me.lblSenderAddress)
        Me.Panel_penerima.Controls.Add(Me.lblSender)
        Me.Panel_penerima.Controls.Add(Me.Label6)
        Me.Panel_penerima.Controls.Add(Me.Label5)
        Me.Panel_penerima.Controls.Add(Me.Label4)
        Me.Panel_penerima.Controls.Add(Me.Label3)
        Me.Panel_penerima.Controls.Add(Me.Label2)
        Me.Panel_penerima.Controls.Add(Me.Label1)
        Me.Panel_penerima.Controls.Add(Me.tbSearch)
        Me.Panel_penerima.Controls.Add(Me.btn_search)
        Me.Panel_penerima.Location = New System.Drawing.Point(193, 66)
        Me.Panel_penerima.Name = "Panel_penerima"
        Me.Panel_penerima.Size = New System.Drawing.Size(652, 434)
        Me.Panel_penerima.TabIndex = 13
        '
        'tbSearch
        '
        Me.tbSearch.Location = New System.Drawing.Point(38, 52)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(527, 20)
        Me.tbSearch.TabIndex = 2
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.Transparent
        Me.btn_search.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.btn_search
        Me.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_search.FlatAppearance.BorderSize = 0
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Location = New System.Drawing.Point(571, 46)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(30, 30)
        Me.btn_search.TabIndex = 0
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.White
        Me.UsernameLabel.Location = New System.Drawing.Point(56, 157)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(90, 31)
        Me.UsernameLabel.TabIndex = 21
        Me.UsernameLabel.Text = "Admin"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Transparent
        Me.btn_back.BackgroundImage = CType(resources.GetObject("btn_back.BackgroundImage"), System.Drawing.Image)
        Me.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_back.FlatAppearance.BorderSize = 0
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Location = New System.Drawing.Point(20, 16)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(20, 30)
        Me.btn_back.TabIndex = 6
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.Transparent
        Me.btn_exit.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.btn_exit1
        Me.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Location = New System.Drawing.Point(806, 20)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(22, 22)
        Me.btn_exit.TabIndex = 5
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Pengirim"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(369, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Penerima"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(369, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Berat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(369, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Perbarui Lokasi"
        '
        'lblSender
        '
        Me.lblSender.AutoSize = True
        Me.lblSender.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSender.Location = New System.Drawing.Point(42, 126)
        Me.lblSender.Name = "lblSender"
        Me.lblSender.Size = New System.Drawing.Size(77, 25)
        Me.lblSender.TabIndex = 9
        Me.lblSender.Text = "Label7"
        '
        'lblSenderAddress
        '
        Me.lblSenderAddress.AutoSize = True
        Me.lblSenderAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenderAddress.Location = New System.Drawing.Point(46, 186)
        Me.lblSenderAddress.Name = "lblSenderAddress"
        Me.lblSenderAddress.Size = New System.Drawing.Size(57, 20)
        Me.lblSenderAddress.TabIndex = 10
        Me.lblSenderAddress.Text = "Label8"
        '
        'lblReciverAddress
        '
        Me.lblReciverAddress.AutoSize = True
        Me.lblReciverAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReciverAddress.Location = New System.Drawing.Point(371, 190)
        Me.lblReciverAddress.Name = "lblReciverAddress"
        Me.lblReciverAddress.Size = New System.Drawing.Size(57, 20)
        Me.lblReciverAddress.TabIndex = 12
        Me.lblReciverAddress.Text = "Label9"
        '
        'lblReceiver
        '
        Me.lblReceiver.AutoSize = True
        Me.lblReceiver.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiver.Location = New System.Drawing.Point(367, 123)
        Me.lblReceiver.Name = "lblReceiver"
        Me.lblReceiver.Size = New System.Drawing.Size(89, 25)
        Me.lblReceiver.TabIndex = 11
        Me.lblReceiver.Text = "Label10"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(46, 241)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(66, 20)
        Me.lblWeight.TabIndex = 13
        Me.lblWeight.Text = "Label11"
        '
        'tbLocation
        '
        Me.tbLocation.Location = New System.Drawing.Point(372, 249)
        Me.tbLocation.Name = "tbLocation"
        Me.tbLocation.Size = New System.Drawing.Size(100, 20)
        Me.tbLocation.TabIndex = 14
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(372, 304)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Perbarui"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Lokasi Terakhir"
        '
        'lblLastLocation
        '
        Me.lblLastLocation.AutoSize = True
        Me.lblLastLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastLocation.Location = New System.Drawing.Point(47, 303)
        Me.lblLastLocation.Name = "lblLastLocation"
        Me.lblLastLocation.Size = New System.Drawing.Size(66, 20)
        Me.lblLastLocation.TabIndex = 17
        Me.lblLastLocation.Text = "Label11"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.form_21
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(845, 500)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.Panel_penerima)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.Panel_penerima.ResumeLayout(False)
        Me.Panel_penerima.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_penerima As System.Windows.Forms.Panel
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents tbSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents tbLocation As System.Windows.Forms.TextBox
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents lblReciverAddress As System.Windows.Forms.Label
    Friend WithEvents lblReceiver As System.Windows.Forms.Label
    Friend WithEvents lblSenderAddress As System.Windows.Forms.Label
    Friend WithEvents lblSender As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblLastLocation As System.Windows.Forms.Label
End Class
