<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormIp
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormIp))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioSpecificDNS = New System.Windows.Forms.RadioButton()
        Me.MaskedTextBoxSecondaryDNS = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxPrimaryDNS = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IpSave = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbSsid = New System.Windows.Forms.TextBox()
        Me.CheckSpecificCompanyIP = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxIPAddress = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxSubnet = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxGateway = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioSpecificIP = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioAutoObtainIP = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioAutoObtainDNS = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioSpecificDNS)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBoxSecondaryDNS)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBoxPrimaryDNS)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 232)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'RadioSpecificDNS
        '
        Me.RadioSpecificDNS.AutoSize = True
        Me.RadioSpecificDNS.Checked = True
        Me.RadioSpecificDNS.Location = New System.Drawing.Point(6, 0)
        Me.RadioSpecificDNS.Name = "RadioSpecificDNS"
        Me.RadioSpecificDNS.Size = New System.Drawing.Size(172, 16)
        Me.RadioSpecificDNS.TabIndex = 907
        Me.RadioSpecificDNS.TabStop = True
        Me.RadioSpecificDNS.Text = "次のDNSサーバのアドレスを使う"
        Me.RadioSpecificDNS.UseVisualStyleBackColor = True
        '
        'MaskedTextBoxSecondaryDNS
        '
        Me.MaskedTextBoxSecondaryDNS.Location = New System.Drawing.Point(156, 65)
        Me.MaskedTextBoxSecondaryDNS.Mask = "000.000.000.000"
        Me.MaskedTextBoxSecondaryDNS.Name = "MaskedTextBoxSecondaryDNS"
        Me.MaskedTextBoxSecondaryDNS.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MaskedTextBoxSecondaryDNS.Size = New System.Drawing.Size(225, 19)
        Me.MaskedTextBoxSecondaryDNS.TabIndex = 305
        Me.MaskedTextBoxSecondaryDNS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 12)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "代替 DNS サーバ ："
        '
        'MaskedTextBoxPrimaryDNS
        '
        Me.MaskedTextBoxPrimaryDNS.Location = New System.Drawing.Point(156, 31)
        Me.MaskedTextBoxPrimaryDNS.Mask = "000.000.000.000"
        Me.MaskedTextBoxPrimaryDNS.Name = "MaskedTextBoxPrimaryDNS"
        Me.MaskedTextBoxPrimaryDNS.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MaskedTextBoxPrimaryDNS.Size = New System.Drawing.Size(225, 19)
        Me.MaskedTextBoxPrimaryDNS.TabIndex = 304
        Me.MaskedTextBoxPrimaryDNS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 12)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "優先 DNS サーバ ："
        '
        'IpSave
        '
        Me.IpSave.Location = New System.Drawing.Point(333, 346)
        Me.IpSave.Name = "IpSave"
        Me.IpSave.Size = New System.Drawing.Size(75, 23)
        Me.IpSave.TabIndex = 901
        Me.IpSave.Text = "保存"
        Me.IpSave.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 12)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "対象SSID ："
        '
        'tbSsid
        '
        Me.tbSsid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSsid.Location = New System.Drawing.Point(90, 15)
        Me.tbSsid.Name = "tbSsid"
        Me.tbSsid.ReadOnly = True
        Me.tbSsid.Size = New System.Drawing.Size(318, 19)
        Me.tbSsid.TabIndex = 0
        Me.tbSsid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckSpecificCompanyIP
        '
        Me.CheckSpecificCompanyIP.AutoSize = True
        Me.CheckSpecificCompanyIP.Location = New System.Drawing.Point(31, 47)
        Me.CheckSpecificCompanyIP.Name = "CheckSpecificCompanyIP"
        Me.CheckSpecificCompanyIP.Size = New System.Drawing.Size(120, 16)
        Me.CheckSpecificCompanyIP.TabIndex = 101
        Me.CheckSpecificCompanyIP.Text = "会社のIP情報を使う"
        Me.CheckSpecificCompanyIP.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "IPアドレス ："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "サブネット マスク ："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "デフォルト ゲートウェイ ："
        '
        'MaskedTextBoxIPAddress
        '
        Me.MaskedTextBoxIPAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MaskedTextBoxIPAddress.Location = New System.Drawing.Point(156, 20)
        Me.MaskedTextBoxIPAddress.Mask = "000.000.000.000"
        Me.MaskedTextBoxIPAddress.Name = "MaskedTextBoxIPAddress"
        Me.MaskedTextBoxIPAddress.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MaskedTextBoxIPAddress.Size = New System.Drawing.Size(225, 19)
        Me.MaskedTextBoxIPAddress.TabIndex = 301
        Me.MaskedTextBoxIPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MaskedTextBoxSubnet
        '
        Me.MaskedTextBoxSubnet.Location = New System.Drawing.Point(156, 47)
        Me.MaskedTextBoxSubnet.Mask = "000.000.000.000"
        Me.MaskedTextBoxSubnet.Name = "MaskedTextBoxSubnet"
        Me.MaskedTextBoxSubnet.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MaskedTextBoxSubnet.Size = New System.Drawing.Size(225, 19)
        Me.MaskedTextBoxSubnet.TabIndex = 302
        Me.MaskedTextBoxSubnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MaskedTextBoxGateway
        '
        Me.MaskedTextBoxGateway.Location = New System.Drawing.Point(156, 73)
        Me.MaskedTextBoxGateway.Mask = "000.000.000.000"
        Me.MaskedTextBoxGateway.Name = "MaskedTextBoxGateway"
        Me.MaskedTextBoxGateway.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MaskedTextBoxGateway.Size = New System.Drawing.Size(225, 19)
        Me.MaskedTextBoxGateway.TabIndex = 303
        Me.MaskedTextBoxGateway.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioSpecificIP)
        Me.GroupBox2.Controls.Add(Me.MaskedTextBoxGateway)
        Me.GroupBox2.Controls.Add(Me.MaskedTextBoxSubnet)
        Me.GroupBox2.Controls.Add(Me.MaskedTextBoxIPAddress)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(387, 100)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'RadioSpecificIP
        '
        Me.RadioSpecificIP.AutoSize = True
        Me.RadioSpecificIP.Checked = True
        Me.RadioSpecificIP.Location = New System.Drawing.Point(7, 1)
        Me.RadioSpecificIP.Name = "RadioSpecificIP"
        Me.RadioSpecificIP.Size = New System.Drawing.Size(119, 16)
        Me.RadioSpecificIP.TabIndex = 905
        Me.RadioSpecificIP.TabStop = True
        Me.RadioSpecificIP.Text = "次のIPアドレスを使う"
        Me.RadioSpecificIP.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioAutoObtainIP)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 60)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(414, 136)
        Me.GroupBox3.TabIndex = 902
        Me.GroupBox3.TabStop = False
        '
        'RadioAutoObtainIP
        '
        Me.RadioAutoObtainIP.AutoSize = True
        Me.RadioAutoObtainIP.Location = New System.Drawing.Point(20, 14)
        Me.RadioAutoObtainIP.Name = "RadioAutoObtainIP"
        Me.RadioAutoObtainIP.Size = New System.Drawing.Size(166, 16)
        Me.RadioAutoObtainIP.TabIndex = 904
        Me.RadioAutoObtainIP.TabStop = True
        Me.RadioAutoObtainIP.Text = "IPアドレスを自動的に取得する"
        Me.RadioAutoObtainIP.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioAutoObtainDNS)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 194)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(414, 138)
        Me.GroupBox4.TabIndex = 903
        Me.GroupBox4.TabStop = False
        '
        'RadioAutoObtainDNS
        '
        Me.RadioAutoObtainDNS.AutoSize = True
        Me.RadioAutoObtainDNS.Location = New System.Drawing.Point(19, 16)
        Me.RadioAutoObtainDNS.Name = "RadioAutoObtainDNS"
        Me.RadioAutoObtainDNS.Size = New System.Drawing.Size(219, 16)
        Me.RadioAutoObtainDNS.TabIndex = 906
        Me.RadioAutoObtainDNS.TabStop = True
        Me.RadioAutoObtainDNS.Text = "DNSサーバのアドレスを自動的に取得する"
        Me.RadioAutoObtainDNS.UseVisualStyleBackColor = True
        '
        'FormIp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 381)
        Me.Controls.Add(Me.CheckSpecificCompanyIP)
        Me.Controls.Add(Me.tbSsid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.IpSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormIp"
        Me.Text = "IP設定"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents IpSave As Button
    Friend WithEvents MaskedTextBoxSecondaryDNS As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents MaskedTextBoxPrimaryDNS As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbSsid As TextBox
    Friend WithEvents CheckSpecificCompanyIP As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MaskedTextBoxIPAddress As MaskedTextBox
    Friend WithEvents MaskedTextBoxSubnet As MaskedTextBox
    Friend WithEvents MaskedTextBoxGateway As MaskedTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RadioSpecificDNS As RadioButton
    Friend WithEvents RadioSpecificIP As RadioButton
    Friend WithEvents RadioAutoObtainIP As RadioButton
    Friend WithEvents RadioAutoObtainDNS As RadioButton
End Class
