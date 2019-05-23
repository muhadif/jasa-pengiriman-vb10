<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintData
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbNameReceiver = New System.Windows.Forms.TextBox()
        Me.Panel_penerima = New System.Windows.Forms.Panel()
        Me.tbAddressReceiver = New System.Windows.Forms.TextBox()
        Me.tbReceiverKota = New System.Windows.Forms.TextBox()
        Me.tbReceiverContact = New System.Windows.Forms.TextBox()
        Me.tbSenderCity = New System.Windows.Forms.TextBox()
        Me.tbReceiverCity = New System.Windows.Forms.TextBox()
        Me.tbCost = New System.Windows.Forms.TextBox()
        Me.Panel_penerima.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(298, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Deliver"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(309, 479)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tbNameReceiver
        '
        Me.tbNameReceiver.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbNameReceiver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNameReceiver.Location = New System.Drawing.Point(81, 87)
        Me.tbNameReceiver.Name = "tbNameReceiver"
        Me.tbNameReceiver.Size = New System.Drawing.Size(335, 15)
        Me.tbNameReceiver.TabIndex = 1
        '
        'Panel_penerima
        '
        Me.Panel_penerima.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.panel_penerima4
        Me.Panel_penerima.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_penerima.Controls.Add(Me.tbCost)
        Me.Panel_penerima.Controls.Add(Me.tbReceiverCity)
        Me.Panel_penerima.Controls.Add(Me.tbSenderCity)
        Me.Panel_penerima.Controls.Add(Me.tbReceiverContact)
        Me.Panel_penerima.Controls.Add(Me.tbReceiverKota)
        Me.Panel_penerima.Controls.Add(Me.tbAddressReceiver)
        Me.Panel_penerima.Controls.Add(Me.tbNameReceiver)
        Me.Panel_penerima.Location = New System.Drawing.Point(86, 47)
        Me.Panel_penerima.Name = "Panel_penerima"
        Me.Panel_penerima.Size = New System.Drawing.Size(508, 312)
        Me.Panel_penerima.TabIndex = 13
        '
        'tbAddressReceiver
        '
        Me.tbAddressReceiver.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbAddressReceiver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAddressReceiver.Location = New System.Drawing.Point(82, 115)
        Me.tbAddressReceiver.Name = "tbAddressReceiver"
        Me.tbAddressReceiver.Size = New System.Drawing.Size(335, 15)
        Me.tbAddressReceiver.TabIndex = 2
        '
        'tbReceiverKota
        '
        Me.tbReceiverKota.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbReceiverKota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbReceiverKota.Location = New System.Drawing.Point(82, 148)
        Me.tbReceiverKota.Name = "tbReceiverKota"
        Me.tbReceiverKota.Size = New System.Drawing.Size(123, 15)
        Me.tbReceiverKota.TabIndex = 3
        '
        'tbReceiverContact
        '
        Me.tbReceiverContact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbReceiverContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbReceiverContact.Location = New System.Drawing.Point(293, 148)
        Me.tbReceiverContact.Name = "tbReceiverContact"
        Me.tbReceiverContact.Size = New System.Drawing.Size(123, 15)
        Me.tbReceiverContact.TabIndex = 4
        '
        'tbSenderCity
        '
        Me.tbSenderCity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbSenderCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSenderCity.Location = New System.Drawing.Point(82, 209)
        Me.tbSenderCity.Name = "tbSenderCity"
        Me.tbSenderCity.Size = New System.Drawing.Size(123, 15)
        Me.tbSenderCity.TabIndex = 5
        '
        'tbReceiverCity
        '
        Me.tbReceiverCity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbReceiverCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbReceiverCity.Location = New System.Drawing.Point(223, 208)
        Me.tbReceiverCity.Name = "tbReceiverCity"
        Me.tbReceiverCity.Size = New System.Drawing.Size(123, 15)
        Me.tbReceiverCity.TabIndex = 6
        '
        'tbCost
        '
        Me.tbCost.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCost.Location = New System.Drawing.Point(81, 240)
        Me.tbCost.Name = "tbCost"
        Me.tbCost.Size = New System.Drawing.Size(123, 15)
        Me.tbCost.TabIndex = 7
        '
        'PrintData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 512)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel_penerima)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PrintData"
        Me.Text = "Form7"
        Me.Panel_penerima.ResumeLayout(False)
        Me.Panel_penerima.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tbNameReceiver As System.Windows.Forms.TextBox
    Friend WithEvents Panel_penerima As System.Windows.Forms.Panel
    Friend WithEvents tbCost As System.Windows.Forms.TextBox
    Friend WithEvents tbReceiverCity As System.Windows.Forms.TextBox
    Friend WithEvents tbSenderCity As System.Windows.Forms.TextBox
    Friend WithEvents tbReceiverContact As System.Windows.Forms.TextBox
    Friend WithEvents tbReceiverKota As System.Windows.Forms.TextBox
    Friend WithEvents tbAddressReceiver As System.Windows.Forms.TextBox
End Class
