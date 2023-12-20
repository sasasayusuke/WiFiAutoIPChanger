
Public Class FormIp

    ' フォームのロード時に一度だけマスクを設定します。
    Private Sub FormIp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 全てのMaskedTextBoxの共通の設定
        Dim mtbs = {MaskedTextBoxIPAddress, MaskedTextBoxSubnet, MaskedTextBoxGateway, MaskedTextBoxPrimaryDNS, MaskedTextBoxSecondaryDNS}
        Dim rbs = {CheckSpecificCompanyIP, RadioAutoObtainIP, RadioSpecificIP, RadioAutoObtainDNS, RadioSpecificDNS}

        For Each mtb In mtbs
            mtb.Mask = "000\.000\.000\.000"
            mtb.PromptChar = "_"
            Dim ip As String = Util.ReadValueFromXml(Constants.PAGE_IP, Constants.selectedSSID, mtb.Name)
            If String.IsNullOrEmpty(ip) Then
                mtb.Text = Constants.EMPTY_IP_ADDRESS
            Else
                mtb.Text = Util.ConvertIpAddressFormat(ip)
            End If
        Next

        For Each rb In rbs
            Dim check = Util.ReadValueFromXml(Constants.PAGE_IP, Constants.selectedSSID, rb.Name)
            If String.IsNullOrEmpty(check) Then
            Else
                rb.Checked = Boolean.Parse(check)
            End If
        Next



    End Sub

    ' IPアドレスのバリデーションチェック
    Private Sub MaskedTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MaskedTextBoxIPAddress.Validating, MaskedTextBoxSubnet.Validating, MaskedTextBoxGateway.Validating, MaskedTextBoxPrimaryDNS.Validating, MaskedTextBoxSecondaryDNS.Validating
        Dim mtb As MaskedTextBox = CType(sender, MaskedTextBox)
        If Util.IsValidIpAddress(mtb.Text) Then
            mtb.Text = Util.ConvertIpAddressFormat(mtb.Text)
        Else
            ' 入力が無効ならば、イベントをキャンセルし、ユーザーにエラーメッセージを表示します。
            MessageBox.Show("無効なIPアドレスです。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mtb.Text = Constants.EMPTY_IP_ADDRESS
            e.Cancel = True
        End If
    End Sub
    Private Sub CheckSpecificCompanyIP_Changed(sender As Object, e As EventArgs) Handles CheckSpecificCompanyIP.CheckedChanged
        ' 会社のIP情報を使う をチェックした場合は全アイテム無効化
        Dim check = Not CheckSpecificCompanyIP.Checked
        MaskedTextBoxIPAddress.Enabled = check
        MaskedTextBoxSubnet.Enabled = check
        MaskedTextBoxGateway.Enabled = check
        MaskedTextBoxPrimaryDNS.Enabled = check
        MaskedTextBoxSecondaryDNS.Enabled = check
        RadioSpecificIP.Enabled = check
        RadioAutoObtainDNS.Enabled = check
        RadioAutoObtainIP.Enabled = check
        RadioSpecificDNS.Enabled = check
    End Sub
    Private Sub RadioAutoObtainIP_Changed(sender As Object, e As EventArgs) Handles RadioAutoObtainIP.CheckedChanged
        ' IPアドレスを自動的に取得する をチェックした場合は以下のテキストボックスを無効化
        If RadioAutoObtainIP.Checked Then
            MaskedTextBoxIPAddress.Enabled = False
            MaskedTextBoxSubnet.Enabled = False
            MaskedTextBoxGateway.Enabled = False
            RadioSpecificIP.Checked = False
        End If
    End Sub
    Private Sub RadioSpecificIP_Changed(sender As Object, e As EventArgs) Handles RadioSpecificIP.CheckedChanged
        ' 次のIPアドレスを使う をチェックした場合は以下のテキストボックスを有効化
        If RadioSpecificIP.Checked Then
            MaskedTextBoxIPAddress.Enabled = True
            MaskedTextBoxSubnet.Enabled = True
            MaskedTextBoxGateway.Enabled = True
            RadioAutoObtainIP.Checked = False
        End If
    End Sub
    Private Sub RadioAutoObtainDNS_Changed(sender As Object, e As EventArgs) Handles RadioAutoObtainDNS.CheckedChanged
        ' DNSサーバのアドレスを自動的に取得する をチェックした場合は以下のテキストボックスを無効化
        If RadioAutoObtainDNS.Checked Then
            MaskedTextBoxPrimaryDNS.Enabled = False
            MaskedTextBoxSecondaryDNS.Enabled = False
            RadioSpecificDNS.Checked = False
        End If
    End Sub
    Private Sub RadioSpecificDNS_Changed(sender As Object, e As EventArgs) Handles RadioSpecificDNS.CheckedChanged
        ' 次のDNSサーバのアドレスを自動的に取得する をチェックした場合は以下のテキストボックスを有効化
        If RadioSpecificDNS.Checked Then
            MaskedTextBoxPrimaryDNS.Enabled = True
            MaskedTextBoxSecondaryDNS.Enabled = True
            RadioAutoObtainDNS.Checked = False
        End If
    End Sub


    ' 保存ボタンクリック
    Private Sub IpSave_Click(sender As Object, e As EventArgs) Handles IpSave.Click
        ' XMLファイルに書き込み
        Dim mtbs = {MaskedTextBoxIPAddress, MaskedTextBoxSubnet, MaskedTextBoxGateway, MaskedTextBoxPrimaryDNS, MaskedTextBoxSecondaryDNS}
        Dim rbs = {CheckSpecificCompanyIP, RadioAutoObtainIP, RadioSpecificIP, RadioAutoObtainDNS, RadioSpecificDNS}

        For Each mtb In mtbs
            Dim ip As String = mtb.Text.Replace(" ", "")
            Util.WriteValueToXml(Constants.PAGE_IP, Constants.selectedSSID, mtb.Name, ip)
        Next
        For Each rb In rbs
            Util.WriteValueToXml(Constants.PAGE_IP, Constants.selectedSSID, rb.Name, rb.Checked)
        Next
        MessageBox.Show("設定内容を保存しました", "保存", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class