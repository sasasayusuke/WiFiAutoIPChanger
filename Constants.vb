Imports System.IO

Public Class Constants
    ' 設定ファイルのパスを保持するShared ReadOnlyプロパティ
    Public Const APPLICATION_VERSION = "1.0.1"
    Public Const APPLICATION_COMPANY = "©SMSDatatech"
    Public Const APPLICATION_NAME = "WifiAutoIPChanger"

    Public Const EMPTY_IP_ADDRESS As String = "___.___.___.___"

    Public Const SETTING_FILE As String = "Settings.xml"
    Public Const SETTING_SECTION As String = "Settings"
    Public Const SETTING_TAG As String = "Setting"

    Public Const PAGE_IP As String = "IP"
    Public Const PAGE_CONF As String = "Conf"
    Public Const PAGE_CONF_GENERAL As String = "General"
    Public Const PAGE_CONF_COMPANY As String = "Company"

    Public Shared currentSSID As String = ""
    Public Shared currentWired As Boolean = False
    Public Shared currentUseCompany As Boolean = False

    Public Shared selectedSSID As String

    Public Shared ReadOnly Property APP_PATH As String
        Get
            Return Path.Combine(Application.StartupPath, SETTING_FILE)
        End Get
    End Property
End Class