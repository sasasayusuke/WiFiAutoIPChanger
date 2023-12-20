<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConf
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConf))
        Me.ConfSave = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioAutoObtainDNS = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioSpecificDNS = New System.Windows.Forms.RadioButton()
        Me.MaskedTextBoxPrimaryDNS = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxSecondaryDNS = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioAutoObtainIP = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioSpecificIP = New System.Windows.Forms.RadioButton()
        Me.MaskedTextBoxSubnet = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxGateway = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxIPAddress = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LabelAppName = New System.Windows.Forms.Label()
        Me.LabelAppCompany = New System.Windows.Forms.Label()
        Me.LabelAppVersion = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBoxWirelessNetwork = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxWiredNetwork = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ConfSave
        '
        Me.ConfSave.Location = New System.Drawing.Point(347, 376)
        Me.ConfSave.Name = "ConfSave"
        Me.ConfSave.Size = New System.Drawing.Size(75, 23)
        Me.ConfSave.TabIndex = 91
        Me.ConfSave.Text = "保存"
        Me.ConfSave.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(427, 343)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "会社IP"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioAutoObtainDNS)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 194)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(410, 143)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'RadioAutoObtainDNS
        '
        Me.RadioAutoObtainDNS.AutoSize = True
        Me.RadioAutoObtainDNS.Location = New System.Drawing.Point(26, 29)
        Me.RadioAutoObtainDNS.Name = "RadioAutoObtainDNS"
        Me.RadioAutoObtainDNS.Size = New System.Drawing.Size(219, 16)
        Me.RadioAutoObtainDNS.TabIndex = 17
        Me.RadioAutoObtainDNS.TabStop = True
        Me.RadioAutoObtainDNS.Text = "DNSサーバのアドレスを自動的に取得する"
        Me.RadioAutoObtainDNS.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 12)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "優先 DNS サーバ ："
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioSpecificDNS)
        Me.GroupBox3.Controls.Add(Me.MaskedTextBoxPrimaryDNS)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.MaskedTextBoxSecondaryDNS)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 51)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(381, 83)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        '
        'RadioSpecificDNS
        '
        Me.RadioSpecificDNS.AutoSize = True
        Me.RadioSpecificDNS.Checked = True
        Me.RadioSpecificDNS.Location = New System.Drawing.Point(20, 0)
        Me.RadioSpecificDNS.Name = "RadioSpecificDNS"
        Me.RadioSpecificDNS.Size = New System.Drawing.Size(172, 16)
        Me.RadioSpecificDNS.TabIndex = 18
        Me.RadioSpecificDNS.TabStop = True
        Me.RadioSpecificDNS.Text = "次のDNSサーバのアドレスを使う"
        Me.RadioSpecificDNS.UseVisualStyleBackColor = True
        '
        'MaskedTextBoxPrimaryDNS
        '
        Me.MaskedTextBoxPrimaryDNS.Location = New System.Drawing.Point(144, 21)
        Me.MaskedTextBoxPrimaryDNS.Mask = "000.000.000.000"
        Me.MaskedTextBoxPrimaryDNS.Name = "MaskedTextBoxPrimaryDNS"
        Me.MaskedTextBoxPrimaryDNS.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MaskedTextBoxPrimaryDNS.Size = New System.Drawing.Size(225, 19)
        Me.MaskedTextBoxPrimaryDNS.TabIndex = 14
        Me.MaskedTextBoxPrimaryDNS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 12)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "代替 DNS サーバ ："
        '
        'MaskedTextBoxSecondaryDNS
        '
        Me.MaskedTextBoxSecondaryDNS.Location = New System.Drawing.Point(144, 51)
        Me.MaskedTextBoxSecondaryDNS.Mask = "000.000.000.000"
        Me.MaskedTextBoxSecondaryDNS.Name = "MaskedTextBoxSecondaryDNS"
        Me.MaskedTextBoxSecondaryDNS.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MaskedTextBoxSecondaryDNS.Size = New System.Drawing.Size(225, 19)
        Me.MaskedTextBoxSecondaryDNS.TabIndex = 15
        Me.MaskedTextBoxSecondaryDNS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioAutoObtainIP)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 160)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'RadioAutoObtainIP
        '
        Me.RadioAutoObtainIP.AutoSize = True
        Me.RadioAutoObtainIP.Location = New System.Drawing.Point(26, 32)
        Me.RadioAutoObtainIP.Name = "RadioAutoObtainIP"
        Me.RadioAutoObtainIP.Size = New System.Drawing.Size(166, 16)
        Me.RadioAutoObtainIP.TabIndex = 15
        Me.RadioAutoObtainIP.TabStop = True
        Me.RadioAutoObtainIP.Text = "IPアドレスを自動的に取得する"
        Me.RadioAutoObtainIP.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioSpecificIP)
        Me.GroupBox4.Controls.Add(Me.MaskedTextBoxSubnet)
        Me.GroupBox4.Controls.Add(Me.MaskedTextBoxGateway)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.MaskedTextBoxIPAddress)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 54)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(381, 100)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        '
        'RadioSpecificIP
        '
        Me.RadioSpecificIP.AutoSize = True
        Me.RadioSpecificIP.Checked = True
        Me.RadioSpecificIP.Location = New System.Drawing.Point(20, 0)
        Me.RadioSpecificIP.Name = "RadioSpecificIP"
        Me.RadioSpecificIP.Size = New System.Drawing.Size(119, 16)
        Me.RadioSpecificIP.TabIndex = 16
        Me.RadioSpecificIP.TabStop = True
        Me.RadioSpecificIP.Text = "次のIPアドレスを使う"
        Me.RadioSpecificIP.UseVisualStyleBackColor = True
        '
        'MaskedTextBoxSubnet
        '
        Me.MaskedTextBoxSubnet.Location = New System.Drawing.Point(144, 47)
        Me.MaskedTextBoxSubnet.Mask = "000.000.000.000"
        Me.MaskedTextBoxSubnet.Name = "MaskedTextBoxSubnet"
        Me.MaskedTextBoxSubnet.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MaskedTextBoxSubnet.Size = New System.Drawing.Size(225, 19)
        Me.MaskedTextBoxSubnet.TabIndex = 12
        Me.MaskedTextBoxSubnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MaskedTextBoxGateway
        '
        Me.MaskedTextBoxGateway.Location = New System.Drawing.Point(144, 75)
        Me.MaskedTextBoxGateway.Mask = "000.000.000.000"
        Me.MaskedTextBoxGateway.Name = "MaskedTextBoxGateway"
        Me.MaskedTextBoxGateway.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MaskedTextBoxGateway.Size = New System.Drawing.Size(225, 19)
        Me.MaskedTextBoxGateway.TabIndex = 13
        Me.MaskedTextBoxGateway.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "デフォルト ゲートウェイ ："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "IPアドレス ："
        '
        'MaskedTextBoxIPAddress
        '
        Me.MaskedTextBoxIPAddress.Location = New System.Drawing.Point(144, 19)
        Me.MaskedTextBoxIPAddress.Mask = "000.000.000.000"
        Me.MaskedTextBoxIPAddress.Name = "MaskedTextBoxIPAddress"
        Me.MaskedTextBoxIPAddress.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MaskedTextBoxIPAddress.Size = New System.Drawing.Size(225, 19)
        Me.MaskedTextBoxIPAddress.TabIndex = 11
        Me.MaskedTextBoxIPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "サブネット マスク ："
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LabelAppName)
        Me.TabPage1.Controls.Add(Me.LabelAppCompany)
        Me.TabPage1.Controls.Add(Me.LabelAppVersion)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.ComboBoxWirelessNetwork)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.ComboBoxWiredNetwork)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(427, 343)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "全般"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LabelAppName
        '
        Me.LabelAppName.AutoSize = True
        Me.LabelAppName.Location = New System.Drawing.Point(284, 82)
        Me.LabelAppName.Name = "LabelAppName"
        Me.LabelAppName.Size = New System.Drawing.Size(0, 12)
        Me.LabelAppName.TabIndex = 101
        '
        'LabelAppCompany
        '
        Me.LabelAppCompany.AutoSize = True
        Me.LabelAppCompany.Location = New System.Drawing.Point(284, 63)
        Me.LabelAppCompany.Name = "LabelAppCompany"
        Me.LabelAppCompany.Size = New System.Drawing.Size(0, 12)
        Me.LabelAppCompany.TabIndex = 100
        '
        'LabelAppVersion
        '
        Me.LabelAppVersion.AutoSize = True
        Me.LabelAppVersion.Location = New System.Drawing.Point(284, 42)
        Me.LabelAppVersion.Name = "LabelAppVersion"
        Me.LabelAppVersion.Size = New System.Drawing.Size(0, 12)
        Me.LabelAppVersion.TabIndex = 99
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(209, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 12)
        Me.Label10.TabIndex = 98
        Me.Label10.Text = "会社名 ："
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(209, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 12)
        Me.Label9.TabIndex = 97
        Me.Label9.Text = "製品名 ："
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(200, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 12)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "バージョン ："
        '
        'ComboBoxWirelessNetwork
        '
        Me.ComboBoxWirelessNetwork.FormattingEnabled = True
        Me.ComboBoxWirelessNetwork.Items.AddRange(New Object() {"Wi-Fi"})
        Me.ComboBoxWirelessNetwork.Location = New System.Drawing.Point(105, 261)
        Me.ComboBoxWirelessNetwork.Name = "ComboBoxWirelessNetwork"
        Me.ComboBoxWirelessNetwork.Size = New System.Drawing.Size(121, 20)
        Me.ComboBoxWirelessNetwork.TabIndex = 94
        Me.ComboBoxWirelessNetwork.Text = "Wi-Fi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 12)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "無線アダプター ："
        '
        'ComboBoxWiredNetwork
        '
        Me.ComboBoxWiredNetwork.FormattingEnabled = True
        Me.ComboBoxWiredNetwork.Items.AddRange(New Object() {"イーサネット"})
        Me.ComboBoxWiredNetwork.Location = New System.Drawing.Point(105, 290)
        Me.ComboBoxWiredNetwork.Name = "ComboBoxWiredNetwork"
        Me.ComboBoxWiredNetwork.Size = New System.Drawing.Size(121, 20)
        Me.ComboBoxWiredNetwork.TabIndex = 92
        Me.ComboBoxWiredNetwork.Text = "イーサネット"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 290)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 12)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "有線アダプター ："
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WiFiAutoIPChanger.My.Resources.Resources.sdt
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(192, 219)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 95
        Me.PictureBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(435, 369)
        Me.TabControl1.TabIndex = 0
        '
        'FormConf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 411)
        Me.Controls.Add(Me.ConfSave)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormConf"
        Me.Text = "環境設定"
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ConfSave As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MaskedTextBoxGateway As MaskedTextBox
    Friend WithEvents MaskedTextBoxSubnet As MaskedTextBox
    Friend WithEvents MaskedTextBoxIPAddress As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ComboBoxWirelessNetwork As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxWiredNetwork As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LabelAppName As Label
    Friend WithEvents LabelAppCompany As Label
    Friend WithEvents LabelAppVersion As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioSpecificIP As RadioButton
    Friend WithEvents RadioAutoObtainIP As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioAutoObtainDNS As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioSpecificDNS As RadioButton
    Friend WithEvents MaskedTextBoxPrimaryDNS As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents MaskedTextBoxSecondaryDNS As MaskedTextBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
