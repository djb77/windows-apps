Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text

Module modINI
    <DllImport("kernel32.dll", SetLastError:=True)> _
    Public Function WritePrivateProfileString _
      (ByVal lpApplicationName As String, _
      ByVal lpKeyName As String, _
      ByVal lpString As String, _
      ByVal lpFileName As String) _
      As Integer
    End Function
    <DllImport("kernel32.dll", SetLastError:=True)> _
    Public Function GetPrivateProfileString( _
      ByVal lpAppName As String, _
      ByVal lpKeyName As String, _
      ByVal lpDefault As String, _
      ByVal lpReturnedString As StringBuilder, _
      ByVal nSize As Integer, _
      ByVal lpFileName As String) As Integer
    End Function
    Public Function ReadIni(ByVal strIniFile As String, ByVal strKey As String, _
                               ByVal strItem As String) As String
        Dim strValue As StringBuilder = New StringBuilder(255)
        Dim intSize As Integer
        intSize = GetPrivateProfileString(strKey, strItem, "", strValue, 255, strIniFile)
        Return strValue.ToString
    End Function
    Public Function WriteIni(ByVal strIniFile As String, ByVal strKey As String, _
                             ByVal strItem As String, ByVal strValue As String) _
                                As Boolean
        Return WritePrivateProfileString(strKey, strItem, strValue, strIniFile)
    End Function
End Module

Public Class main
    Public Shared PPDVersion As String = "3.3"
    Public Shared UpdateURL As String = "http://www.psp-hq.com/ppd/version.txt"
    Public Shared UpdateFileURL As String = "http://www.psp-hq.com/ppd/url.txt"
    Public Shared Path As String = Application.StartupPath()
    Public Shared ConfigPath As String = Path + "\config.ini"
    Public Shared Path0 As String = Path + "\Eboots\"
    Public Shared Path1 As String = Path0 + "150.PBP"
    Public Shared Path2 As String = Path0 + "371.PBP"
    Public Shared Path3 As String = Path0 + "380.PBP"
    Public Shared Path4 As String = Path0 + "390.PBP"
    Public Shared Path5 As String = Path0 + "401.PBP"
    Public Shared Path6 As String = Path0 + "500.PBP"
    Public Shared Path7 As String = Path0 + "550.PBP"
    Public Shared FormatPath As String
    Public Shared PSPPath As String
    Public Shared PSPType As String = 1
    Public Shared WindowsOS As String
    Public Shared DoMSPFormat As String = 0
    Public Shared InjectIPL As String = 1
    Public Shared WindowsName As String
    Public Shared FileName1 As String
    Public Shared FileName2 As String
    Public Shared FileName3 As String
    Public Shared FileName4 As String
    Public Shared FileName5 As String
    Public Shared FileName6 As String
    Public Shared FileName7 As String
    Public Shared File1MD5 As String = "E32EB27980BA8B291EB803E3397E4B24"
    Public Shared File2MD5 As String = "6BABEE6E1415AE27999928566ADBD569"
    Public Shared File3MD5 As String = "923297BB6C6AEAD603D745E9E724FEA0"
    Public Shared File4MD5 As String = "64BAE5DD0D0F836BAEDF915FB106E9CC"
    Public Shared File5MD5 As String = "C593ABC023AA9B215710DF6E263B3FFF"
    Public Shared File6MD5 As String = "60AA0356D4C66F589B71CFC9ABC08713"
    Public Shared File7MD5 As String = "EACD91E92ABF817FF4CEAF02258F73A6"
    Public Shared Option_150 As String = 0
    Public Shared Option_371 As String = 0
    Public Shared Option_380 As String = 0
    Public Shared Option_390 As String = 0
    Public Shared Option_401 As String = 0
    Public Shared Option_500 As String = 0
    Public Shared Option_550 As String = 0
    Public Shared Option_Format As String = 0
    Public Shared Option_RestoreFormat As String = 0
    Public Shared Option_BackupCompress As String = 0
    Public Shared Option_Noobz As String = 0
    Public Shared Option_DC3 As String = 0
    Public Shared Option_DC4 As String = 0
    Public Shared Option_DC5 As String = 0
    Public Shared Option_DC7 As String = 0
    Public Shared Option_DC8 As String = 0
    Public Shared Option_XGEN As String = 0
    Public Shared Option_TM As String = 0
    Public Shared Option_BackupBefore As String = 0
    Public Shared Option_RestoreAfter As String = 0
    Public Shared Option_150Kernel As String = 0
    Public Shared Option_371_150Kernel As String = 0
    Public Shared Option_380_150Kernel As String = 0
    Public Shared Option_390_150Kernel As String = 0
    Public Shared Option_401_150Kernel As String = 0
    Public Shared Option_500_150Kernel As String = 0
    Public Shared Option_SupportPandora As String = 0
    Public Shared Option_SupportXMB As String = 0
    Public Shared Option_POPSLoader As String = 0
    Public Shared Option_BootButton1 As String
    Public Shared Option_BootButton2 As String
    Public Shared Option_BootButton3 As String
    Public Shared Option_BootButton4 As String
    Public Shared Option_BootButton5 As String
    Public Shared Option_Pandora_Nandtool As String = 0
    Public Shared Option_Pandora_RFlash As String = 0
    Public Shared Option_Pandora_KeyCleaner As String = 0
    Public Shared Option_XMB_All As String = 0
    Public Shared Option_XMB_500m33 As String = 0
    Public Shared Option_XMB_CFE As String = 0
    Public Shared Option_XMB_CPUModulator As String = 0
    Public Shared Option_XMB_CFWFolderBlocker As String = 0
    Public Shared Option_XMB_CWCheat As String = 0
    Public Shared Option_XMB_CXMB As String = 0
    Public Shared Option_XMB_FusaSCR As String = 0
    Public Shared Option_XMB_FusaSD As String = 0
    Public Shared Option_XMB_Hold As String = 0
    Public Shared Option_XMB_Joysens As String = 0
    Public Shared Option_XMB_KeyCleaner As String = 0
    Public Shared Option_XMB_MemStickTool As String = 0
    Public Shared Option_XMB_NandTool As String = 0
    Public Shared Option_XMB_NetConfBackup As String = 0
    Public Shared Option_XMB_PSPFiler As String = 0
    Public Shared Option_XMB_RSPSARDumper As String = 0
    Public Shared Option_XMB_UMDrip As String = 0
    Public Shared Option_XMB_XGEN As String = 0
    Public Shared FileMD5 As String
    Public Shared ReturnMD5 As String
    Public Shared BootCheck As String
    Public Shared DriveCheck As String
    Public Shared copyerror1 As String = "Please check that your are selecting the right file."
    Public Shared copyerror2 As String = "Cannot copy the File, Disk Error."
    Public Shared Password As String = "^D&HDG3jhg2387gdgYWU^#!GDHGDJDB&#@C#uh86yd872dG#@78d328dg37d2e32e78yde23ted87tee32eed3"
    Friend WithEvents Zipforge As New ZipForge

    ' Exit Program
    Private Sub MainClosing(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    ' Preload 
    '---------
    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ButtonConfig_Combo1.Text = "Up"
        Me.ButtonConfig_Combo2.Text = "Right"
        Me.ButtonConfig_Combo3.Text = "Down"
        Me.ButtonConfig_Combo4.Text = "Left"
        Me.ButtonConfig_Combo5.Text = "LTrigger"
        VersionText.Text = "v" + PPDVersion
        GetVersion()                               ' Detect the Windows OS
        WindowsOS = GetVersion()
        Dim BadOS As String = 0
        If WindowsOS = "95" Then
            BadOS = 1
        End If
        If WindowsOS = "NT351" Then
            BadOS = 1
        End If
        If WindowsOS = "NT4" Then
            BadOS = 1
        End If
        If WindowsOS = "Unknown" Then
            BadOS = 1
        End If
        If BadOS = 1 Then
            MessageBox.Show("This program will not run on this OS.", "OS Problem", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Me.Close()
        End If
        If WindowsOS = "Vista" Then                     ' Check for Windows Vista
            Menu_Options_MSPFormat.Enabled = False      ' and disable MSPForamt
            Check_MSPFormat.Enabled = False
            MessageBox.Show("Windows Vista is detected as your OS." & vbCrLf & "You will not be able to use MSPormat", "Vista Detected")
        End If
        If WindowsOS = "98" Then                        ' Create Names for OS Types
            WindowsName = "Windows 98"
        End If
        If WindowsOS = "98SE" Then
            WindowsName = "Windows 98 Second Edition"
        End If
        If WindowsOS = "ME" Then
            WindowsName = "Windows Millenium"
        End If
        If WindowsOS = "2000" Then
            WindowsName = "Windows 2000"
        End If
        If WindowsOS = "XP" Then
            WindowsName = "Windows XP"
        End If
        If WindowsOS = "2003" Then
            WindowsName = "Windows Server 2003"
        End If
        If WindowsOS = "Vista" Then
            WindowsName = "Windows Vista"
        End If
        If WindowsOS = "Win7" Then
            WindowsName = "Windows 7"
        End If
        If WindowsOS = "Unknown" Then
            WindowsName = "Unknown"
        End If
        OS_Label.Text = "Operating System: " + WindowsName
        Try
            System.IO.Directory.CreateDirectory(Path0)
        Catch
        End Try
        FindDrives()                               ' Find Removable Drives 
        If System.IO.File.Exists(Path1) Then            ' Detect 1.50 Eboot
            FileMD5 = Path1
            CreateMD5()
            If MD5Label.Text = File1MD5 Then
                Button_150.Enabled = False
                Menu_File_Open150.Enabled = False
                Install_150.Enabled = True
                Menu_Options_Install150.Enabled = True
            End If
        End If
        If System.IO.File.Exists(Path2) Then            ' Detect 3.71 Eboot
            FileMD5 = Path2
            CreateMD5()
            If MD5Label.Text = File2MD5 Then
                Button_371.Enabled = False
                Menu_File_Open371.Enabled = False
                Install_371.Enabled = True
                Menu_Options_Install371.Enabled = True
            End If
        End If
        If System.IO.File.Exists(Path3) Then            ' Detect 3.80 Eboot
            FileMD5 = Path3
            CreateMD5()
            If MD5Label.Text = File3MD5 Then
                Button_380.Enabled = False
                Menu_File_Open380.Enabled = False
                Install_380.Enabled = True
                Menu_Options_Install380.Enabled = True
            End If
        End If
        If System.IO.File.Exists(Path4) Then            ' Detect 3.90 Eboot
            FileMD5 = Path4
            CreateMD5()
            If MD5Label.Text = File4MD5 Then
                Button_390.Enabled = False
                Menu_File_Open390.Enabled = False
                Install_390.Enabled = True
                Menu_Options_Install390.Enabled = True
            End If
        End If
        If System.IO.File.Exists(Path5) Then            ' Detect 4.01 Eboot
            FileMD5 = Path5
            CreateMD5()
            If MD5Label.Text = File5MD5 Then
                Button_401.Enabled = False
                Menu_File_Open401.Enabled = False
                Install_401.Enabled = True
                Menu_Options_Install401.Enabled = True
            End If
        End If
        If System.IO.File.Exists(Path6) Then            ' Detect 5.00 Eboot
            FileMD5 = Path6
            CreateMD5()
            If MD5Label.Text = File6MD5 Then
                Button_500.Enabled = False
                Menu_File_Open500.Enabled = False
                Install_500.Enabled = True
                Menu_Options_Install500.Enabled = True
            End If
        End If
        If System.IO.File.Exists(Path7) Then            ' Detect 5.50 Eboot
            FileMD5 = Path7
            CreateMD5()
            If MD5Label.Text = File7MD5 Then
                Button_550.Enabled = False
                Menu_File_Open550.Enabled = False
                Install_550.Enabled = True
                Menu_Options_Install550.Enabled = True
            End If
        End If
    End Sub

    ' Menu Box -- File
    ' -------- 
    'Load 1.50 Eboot File
    Private Sub Menu_File_Open150_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_File_Open150.Click
        Load150()
    End Sub
    'Load 3.71 Eboot File
    Private Sub Menu_File_Open371_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_File_Open371.Click
        Load371()
    End Sub
    'Load 3.80 Eboot File
    Private Sub Menu_File_Open380_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_File_Open380.Click
        Load380()
    End Sub
    'Load 3.90 Eboot File
    Private Sub Menu_File_Open390_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_File_Open390.Click
        Load390()
    End Sub
    'Load 4.01 Eboot File
    Private Sub Menu_File_Open401_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_File_Open401.Click
        Load401()
    End Sub
    'Load 5.00 Eboot File
    Private Sub Menu_File_Open500_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_File_Open500.Click
        Call Load500()
    End Sub
    'Load 5.50 Eboot File
    Private Sub Menu_File_Open550_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_File_Open550.Click
        Call Load550()
    End Sub
    ' Load and Apply Configuration File
    Private Sub File_LoadConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles File_LoadConfig.Click
        LoadConfigSub()
    End Sub
    ' Save Configuration File
    Private Sub File_SaveConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles File_SaveConfig.Click
        SaveConfigSub()
    End Sub
    ' Reset Configuration
    Private Sub File_ConfigReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles File_ConfigReset.Click
        ClearConfig()
    End Sub
    'Detect PSP Drive
    Private Sub Menu_File_PSPDrive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_File_PSPDrive.Click
        FindDrives()
    End Sub
    'Start Installer
    Private Sub Menu_File_Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_File_Start.Click
        Sub_Start()
    End Sub
    'Exit
    Private Sub Menu_File_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_File_Exit.Click
        Me.Close()
    End Sub

    ' Menu Box -- Options
    '--------------------
    'Format + Prepare PSP
    Private Sub Menu_Options_Format_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_Format.Click
        If Menu_Options_Format.Checked = True Then
            Option_Format = 0
            Menu_Options_Format.Checked = False
            FormatPSP.Checked = False
        Else
            Option_Format = 1
            Menu_Options_Format.Checked = True
            FormatPSP.Checked = True
        End If
    End Sub
    'Use MSPFormat
    Private Sub Menu_Options_MSPFormat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_MSPFormat.Click
        If Menu_Options_MSPFormat.Checked = True Then
            Menu_Options_MSPFormat.Checked = False
            Check_MSPFormat.Checked = False
            DoMSPFormat = 0
        Else
            Menu_Options_MSPFormat.Checked = True
            Check_MSPFormat.Checked = True
            DoMSPFormat = 1
        End If
    End Sub
    'Inject IPL
    Private Sub Menu_Options_IPL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_IPL.Click
        If Menu_Options_IPL.Checked = True Then
            Menu_Options_IPL.Checked = False
            Check_IPL.Checked = False
            InjectIPL = 0
        Else
            Menu_Options_IPL.Checked = True
            Check_IPL.Checked = True
            InjectIPL = 1
        End If
    End Sub
    'PSP Type 1.50 Kernel
    Private Sub Menu_Options_PSPType_150_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_PSPType_150.Click
        If Menu_Options_PSPType_150.Checked = True Then
            Menu_Options_PSPType_150.Checked = False
            Radio_150.Checked = False
            Radio_M33.Checked = True
            Menu_Options_PSPType_M33.Checked = True
            PSPType = 1
        Else
            Menu_Options_PSPType_150.Checked = True
            Radio_150.Checked = True
            Radio_M33.Checked = False
            Menu_Options_PSPType_M33.Checked = False
            PSPType = 0
        End If
    End Sub
    'PSP Type M33 Kernel
    Private Sub Menu_Options_PSPType_M33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_PSPType_M33.Click
        If Menu_Options_PSPType_M33.Checked = True Then
            Menu_Options_PSPType_150.Checked = True
            Radio_150.Checked = True
            Radio_M33.Checked = False
            Menu_Options_PSPType_M33.Checked = False
            PSPType = 0
        Else
            Menu_Options_PSPType_150.Checked = False
            Radio_150.Checked = False
            Radio_M33.Checked = True
            Menu_Options_PSPType_M33.Checked = True
            PSPType = 1
        End If
    End Sub
    'Restore Memory Stick
    Private Sub Menu_Options_Restore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_Restore.Click
        Sub_Restore()
    End Sub
    'Backup Memory Stick
    Private Sub Menu_Options_Backup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_Backup.Click
        Sub_Backup()
    End Sub
    'Install 1.50
    Private Sub Menu_Options_Install150_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_Install150.Click
        If Menu_Options_Install150.Checked = True Then
            Option_150 = 0
            Install_150.Checked = False
            Menu_Options_Install150.Checked = False
            Menu_Options_Noobz.Enabled = False
        Else
            Option_150 = 1
            Install_150.Checked = True
            Menu_Options_Install150.Checked = True
            Menu_Options_Noobz.Enabled = True
        End If
        CheckBoot()
    End Sub
    'Install 3.71
    Private Sub Menu_Options_Install371_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_Install371.Click
        If Menu_Options_Install371.Checked = True Then
            Option_371 = 0
            Install_371.Checked = False
            Menu_Options_Install371.Checked = False
            Menu_Options_DC3.Enabled = False
        Else
            Option_371 = 1
            Install_371.Checked = True
            Menu_Options_Install371.Checked = True
            Menu_Options_DC3.Enabled = True
        End If
        CheckBoot()
        RFlash()
    End Sub
    'Install 3.80
    Private Sub Menu_Options_Install380_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_Install380.Click
        If Menu_Options_Install380.Checked = True Then
            Option_380 = 0
            Install_380.Checked = False
            Menu_Options_Install380.Checked = False
            Menu_Options_DC4.Enabled = False
        Else
            Option_380 = 1
            Install_380.Checked = True
            Menu_Options_Install380.Checked = True
            Menu_Options_DC4.Enabled = True
        End If
        CheckBoot()
    End Sub
    'Install 3.90
    Private Sub Menu_Options_Install390_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_Install390.Click
        If Menu_Options_Install390.Checked = True Then
            Option_390 = 0
            Install_390.Checked = False
            Menu_Options_Install380.Checked = False
            Menu_Options_DC5.Enabled = False
        Else
            Option_390 = 1
            Install_390.Checked = True
            Menu_Options_Install390.Checked = True
            Menu_Options_DC5.Enabled = True
        End If
    End Sub
    'Install 4.01
    Private Sub Menu_Options_Install401_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_Install401.Click
        If Menu_Options_Install401.Checked = True Then
            Option_401 = 0
            Install_401.Checked = False
            Menu_Options_Install401.Checked = False
            Menu_Options_DC7.Enabled = False
        Else
            Option_401 = 1
            Install_401.Checked = True
            Menu_Options_Install401.Checked = True
            Menu_Options_DC7.Enabled = True
        End If
        CheckBoot()
        RFlash()
    End Sub
    'Install 5.00
    Private Sub Menu_Options_Install500_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_Install500.Click
        If Menu_Options_Install500.Checked = True Then
            Option_500 = 0
            Install_500.Checked = False
            Menu_Options_Install500.Checked = False
            Menu_Options_DC8.Enabled = False
        Else
            Option_500 = 1
            Install_500.Checked = True
            Menu_Options_Install500.Checked = True
            Menu_Options_DC8.Enabled = True
        End If
        CheckBoot()
        RFlash()
    End Sub
    'Install 5.50
    Private Sub Menu_Options_Install550_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_Install550.Click
        If Menu_Options_Install550.Checked = True Then
            Option_550 = 0
            Option_XGEN = 0
            Option_XMB_XGEN = 0
            Install_550.Checked = False
            Menu_Options_Install550.Checked = False
            Menu_Options_XGEN.Enabled = False
            Install_XGEN.Checked = False
            Install_XGEN.Enabled = False
            XMB_XGEN.Enabled = False
            XMB_XGEN.Checked = False
        Else
            Option_550 = 1
            Install_550.Checked = True
            Menu_Options_Install550.Checked = True
            Menu_Options_XGEN.Enabled = True
            Install_XGEN.Enabled = True
            XMB_XGEN.Enabled = True
        End If
        CheckBoot()
    End Sub
    'Install Noobz 1.50 Downgrader
    Private Sub Menu_Options_Noobz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_Noobz.Click
        If Menu_Options_Noobz.Checked = True Then
            Option_Noobz = 0
            If Option_371 = 1 Then
                Install_DC3.Enabled = True
                Menu_Options_DC3.Enabled = True
            End If
            If Option_380 = 1 Then
                Install_DC4.Enabled = True
                Menu_Options_DC4.Enabled = True
            End If
            Options_SupportPandora.Enabled = True
            Menu_Options_Other_Pandora.Enabled = True
            Install_Noobz.Checked = False
            Menu_Options_Noobz.Checked = False
            Menu_Options_Noobz.Enabled = False
            If Options_SupportPandora.Checked = True Then
                SupportGroup_Pandora.Enabled = True
            End If
            Label1.Text = "ELF Menu / DC v3 and v4"
            Label1.Refresh()
        Else
            Option_Noobz = 1
            Install_DC3.Enabled = False
            Install_DC3.Checked = False
            Option_DC3 = 0
            Install_DC4.Enabled = False
            Install_DC4.Checked = False
            Option_DC4 = 0
            Options_SupportPandora.Enabled = False
            Options_SupportPandora.Checked = False
            Option_SupportPandora = 0
            Install_Noobz.Checked = True
            Menu_Options_Noobz.Checked = True
            Menu_Options_Noobz.Enabled = True
            SupportGroup_Pandora.Enabled = False
            Label1.Text = "Noobz 1.50 Downgrader"
            Label1.Refresh()
        End If
        CheckBoot()
    End Sub
    'Install DC3
    Private Sub Menu_Options_DC3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_DC3.Click
        If Menu_Options_DC3.Checked = True Then
            Option_DC3 = 0
            Install_DC3.Checked = False
            Menu_Options_DC3.Checked = False
        Else
            Option_DC3 = 1
            Install_DC3.Checked = True
            Menu_Options_DC3.Checked = True
        End If
        CheckBoot()
    End Sub
    'Install DC4
    Private Sub Menu_Options_DC4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_DC4.Click
        If Menu_Options_DC4.Checked = True Then
            Option_DC4 = 0
            Install_DC4.Checked = False
            Menu_Options_DC4.Checked = False
        Else
            Option_DC4 = 1
            Install_DC4.Checked = True
            Menu_Options_DC4.Checked = True
        End If
        CheckBoot()
    End Sub
    'Install DC5
    Private Sub Menu_Options_DC5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_DC5.Click
        If Menu_Options_DC5.Checked = True Then
            Option_DC5 = 0
            Install_DC5.Checked = False
            Menu_Options_DC5.Checked = False
        Else
            Option_DC5 = 1
            Install_DC5.Checked = True
            Menu_Options_DC5.Checked = True
        End If
    End Sub
    'Install DC7
    Private Sub Menu_Options_DC7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_DC7.Click
        If Menu_Options_DC7.Checked = True Then
            Option_DC7 = 0
            Install_DC7.Checked = False
            Menu_Options_DC7.Checked = False
        Else
            Option_DC7 = 1
            Install_DC7.Checked = True
            Menu_Options_DC7.Checked = True
        End If
        CheckBoot()
    End Sub
    'Install DC8
    Private Sub Menu_Options_DC8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_DC8.Click
        If Menu_Options_DC8.Checked = True Then
            Option_DC8 = 0
            Label4.Text = "XGEN Pandora Installer v5"
            Install_DC8.Checked = False
            Menu_Options_DC8.Checked = False
            Install_XGEN.Enabled = True
            Menu_Options_XGEN.Enabled = True
        Else
            Option_DC8 = 1
            Option_XGEN = 0
            Label4.Text = "Despertar Cementerio v8"
            Install_DC8.Checked = True
            Menu_Options_DC8.Checked = True
            Install_XGEN.Enabled = False
            Menu_Options_XGEN.Enabled = False
        End If
        RefreshScreen()
        CheckBoot()
    End Sub
    'Install TimeMachine
    Private Sub Menu_Options_TM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_TM.Click
        If Menu_Options_TM.Checked = True Then
            Option_TM = 0
            Install_TM.Checked = False
            Menu_Options_DC7.Checked = False
        Else
            Option_TM = 1
            Install_TM.Checked = True
            Menu_Options_TM.Checked = True
        End If
        CheckBoot()
    End Sub
    'Install XGEN
    Private Sub Menu_Options_XGEN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_XGEN.Click
        If Menu_Options_XGEN.Checked = True Then
            Option_XGEN = 0
            Label4.Text = "Despertar Cementerio v8"
            Install_XGEN.Checked = False
            Menu_Options_XGEN.Checked = False
            Install_DC8.Enabled = True
            Menu_Options_DC8.Enabled = True
        Else
            Option_XGEN = 1
            Label4.Text = "XGEN Pandora Installer v5"
            Option_DC8 = 0
            Install_XGEN.Checked = True
            Menu_Options_XGEN.Checked = True
            Install_DC8.Enabled = False
            Menu_Options_DC8.Enabled = False
        End If
        RefreshScreen()
        CheckBoot()
    End Sub

    ' Menu Box -- Options -- Other
    '-----------------------------
    'Backup Before Installation
    Private Sub Menu_Options_Other_Backup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_Other_Backup.Click
        If Menu_Options_Other_Backup.Checked = True Then
            Option_BackupBefore = 0
            Options_BackupBefore.Checked = False
            Menu_Options_Other_Backup.Checked = False
        Else
            Option_BackupBefore = 1
            Options_BackupBefore.Checked = True
            Menu_Options_Other_Backup.Checked = True
        End If
    End Sub
    'Restore Backup from PC after Installation
    Private Sub Menu_Options_Other_Restore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_Other_Restore.Click
        If Menu_Options_Other_Restore.Checked = True Then
            Option_RestoreAfter = 0
            Options_RestoreAfter.Checked = False
            Menu_Options_Other_Restore.Checked = False
        Else
            Option_RestoreAfter = 1
            Options_RestoreAfter.Checked = True
            Menu_Options_Other_Restore.Checked = True
        End If
    End Sub
    'Use Compression on Backup
    Private Sub Menu_Options_BackupCompression_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_BackupCompression.Click
        If Menu_Options_BackupCompression.Checked = True Then
            Option_BackupCompress = 0
            Options_BackupCompression.Checked = False
            Menu_Options_BackupCompression.Checked = False
        Else
            Option_BackupCompress = 1
            Options_BackupCompression.Checked = True
            Menu_Options_BackupCompression.Checked = True
        End If
    End Sub
    'Install the M33 1.50 Addons
    Private Sub Menu_Options_Other_150Addon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_Other_150Addon.Click
        If Option_XMB_XGEN <> 1 Then
            If Menu_Options_Other_150Addon.Checked = True Then
                Option_150Kernel = 0
                Option_371_150Kernel = 0
                Option_380_150Kernel = 0
                Option_390_150Kernel = 0
                Option_401_150Kernel = 0
                Option_500_150Kernel = 0
                Options_150kernel.Checked = False
                Menu_Options_Other_150Addon.Checked = False
                XMB_500m33.Enabled = True
                XMB_XGEN.Enabled = True
            Else
                If Option_150 = 1 Then
                    Option_150Kernel = 1
                    If Option_DC3 = 1 Then
                        Option_371_150Kernel = 1
                    End If
                    If Option_DC4 = 1 Then
                        Option_380_150Kernel = 1
                    End If
                    If Option_DC5 = 1 Then
                        Option_390_150Kernel = 1
                    End If
                    If Option_DC7 = 1 Then
                        Option_401_150Kernel = 1
                    End If
                    If Option_DC8 = 1 Then
                        Option_500_150Kernel = 1
                    End If
                    Options_150kernel.Checked = True
                    Menu_Options_Other_150Addon.Checked = True
                    XMB_500m33.Enabled = False
                    XMB_500m33.Checked = False
                    XMB_XGEN.Enabled = False
                    XMB_XGEN.Checked = False
                    Option_XMB_500m33 = 0
                    Option_XMB_XGEN = 0
                End If
            End If
        End If
    End Sub
    'Install Support Tools for Pandora
    Private Sub Menu_Options_Other_Pandora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_Other_Pandora.Click
        If Menu_Options_Other_Pandora.Checked = True Then
            Option_SupportPandora = 0
            Options_SupportPandora.Checked = False
            Menu_Options_Other_Pandora.Checked = False
        Else
            Option_SupportPandora = 1
            Options_SupportPandora.Checked = True
            Menu_Options_Other_Pandora.Checked = True
        End If
        CheckBoot()
    End Sub
    'Install Support Tools for XMB
    Private Sub Menu_Options_Other_XMB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_Other_XMB.Click
        If Menu_Options_Other_XMB.Checked = True Then
            Option_SupportXMB = 0
            Options_SupportXMB.Checked = False
            Menu_Options_Other_XMB.Checked = False
        Else
            Option_SupportXMB = 1
            Options_SupportXMB.Checked = True
            Menu_Options_Other_XMB.Checked = True
        End If
    End Sub
    'Install POPSLoader
    Private Sub Menu_Options_Other_POPSLoader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Options_Other_POPSLoader.Click
        If Menu_Options_Other_POPSLoader.Checked = True Then
            Option_POPSLoader = 0
            Options_Popsloader.Checked = False
            Menu_Options_Other_POPSLoader.Checked = False
        Else
            Option_POPSLoader = 1
            Options_Popsloader.Checked = True
            Menu_Options_Other_POPSLoader.Checked = True
        End If
    End Sub

    ' Menu Box -- Help
    '-----------------
    'Instruction Manual
    Private Sub Menu_Help_Manual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Help_Manual.Click
        System.Diagnostics.Process.Start(Path + "\Docs\manual.chm")
    End Sub
    ' Check for Update
    Private Sub Help_UpdateCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Help_UpdateCheck.Click
        UpdateCheck()
    End Sub
    'About PSP Pandora Deluxe
    Private Sub Menu_Help_About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Help_About.Click
        Me.Enabled = False
        AboutBox.Show()
    End Sub

    ' PSP Firmware Group Box
    '-----------------------
    '1.50 Firmware
    Private Sub Button_150_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_150.Click
        Load150()
    End Sub
    '3.71 Firmware
    Private Sub Button_371_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_371.Click
        Load371()
    End Sub
    '3.80 Firmware
    Private Sub Button_380_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_380.Click
        Load380()
    End Sub
    '3.90 Firmware
    Private Sub Button_390_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_390.Click
        Load390()
    End Sub
    '4.01 Firmware
    Private Sub Button_401_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_401.Click
        Load401()
    End Sub
    '5.00 Firmware
    Private Sub Button_500_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_500.Click
        Load500()
    End Sub
    '5.50 Firmware
    Private Sub Button_550_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_550.Click
        Load550()
    End Sub

    ' Install Firmwares
    '------------------
    '1.50 
    Private Sub Install_150_CheckeDChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Install_150.CheckedChanged
        If Install_150.Checked = True Then
            Option_150 = 1
            Menu_Options_Install150.Checked = True
            Install_Noobz.Enabled = True
            Options_150kernel.Enabled = True
            Menu_Options_Noobz.Enabled = True
            Menu_Options_Other_150Addon.Enabled = True
        Else
            Option_150 = 0
            Menu_Options_Install150.Checked = False
            Install_Noobz.Enabled = False
            Install_Noobz.Checked = False
            Options_150kernel.Enabled = False
            Options_150kernel.Checked = False
            Menu_Options_Noobz.Checked = False
            Menu_Options_Noobz.Enabled = False
            Menu_Options_Other_150Addon.Enabled = False
            Menu_Options_Other_150Addon.Checked = False
        End If
        CheckBoot()
    End Sub
    '3.71
    Private Sub Install_371_CheckeDChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Install_371.CheckedChanged
        If Install_371.Checked = True Then
            Option_371 = 1
            Menu_Options_Install371.Checked = True
            Install_DC3.Enabled = True
            Menu_Options_DC3.Enabled = True
        Else
            Option_371 = 0
            Menu_Options_Install371.Checked = False
            Install_DC3.Enabled = False
            Install_DC3.Checked = False
            Menu_Options_DC3.Checked = False
            Menu_Options_DC3.Enabled = False
        End If
        CheckBoot()
        RFlash()
    End Sub
    '3.80
    Private Sub Install_380_CheckeDChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Install_380.CheckedChanged
        If Install_380.Checked = True Then
            Option_380 = 1
            Menu_Options_Install380.Checked = True
            Install_DC4.Enabled = True
            Menu_Options_DC4.Enabled = True
        Else
            Option_380 = 0
            Menu_Options_Install380.Checked = False
            Install_DC4.Enabled = False
            Install_DC4.Checked = False
            Menu_Options_DC4.Checked = False
            Menu_Options_DC4.Enabled = False
        End If
        CheckBoot()
    End Sub
    '3.90
    Private Sub Install_390_CheckeDChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Install_390.CheckedChanged
        If Install_390.Checked = True Then
            Option_390 = 1
            Menu_Options_Install390.Checked = True
            Install_DC5.Enabled = True
            Menu_Options_DC5.Enabled = True
        Else
            Option_390 = 0
            Menu_Options_Install390.Checked = False
            Install_DC5.Enabled = False
            Install_DC5.Checked = False
            Menu_Options_DC5.Checked = False
            Menu_Options_DC5.Enabled = False
        End If
    End Sub
    '4.01
    Private Sub Install_401_CheckeDChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Install_401.CheckedChanged
        If Install_401.Checked = True Then
            Option_401 = 1
            Menu_Options_Install401.Checked = True
            Install_DC7.Enabled = True
            Menu_Options_DC7.Enabled = True
        Else
            Option_401 = 0
            Menu_Options_Install401.Checked = False
            Install_DC7.Enabled = False
            Install_DC7.Checked = False
            Menu_Options_DC7.Checked = False
            Menu_Options_DC7.Enabled = False
        End If
        CheckBoot()
        RFlash()
    End Sub
    '5.00
    Private Sub Install_500_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Install_500.CheckedChanged
        If Install_500.Checked = True Then
            Option_500 = 1
            Menu_Options_Install500.Checked = True
            Install_DC8.Enabled = True
            XMB_500m33.Enabled = True
            Menu_Options_DC8.Enabled = True
        Else
            Option_500 = 0
            Menu_Options_Install500.Checked = False
            Install_DC8.Enabled = False
            Install_DC8.Checked = False
            Menu_Options_DC8.Checked = False
            Menu_Options_DC8.Enabled = False
        End If
        CheckBoot()
        RFlash()
    End Sub
    '5.50
    Private Sub Install_550_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Install_550.CheckedChanged
        If Install_550.Checked = True Then
            Option_550 = 1
            Menu_Options_Install550.Checked = True
            Install_XGEN.Enabled = True
            XMB_XGEN.Enabled = True
            Menu_Options_XGEN.Enabled = True
        Else
            Option_550 = 0
            Option_XGEN = 0
            Option_XMB_XGEN = 0
            Menu_Options_Install550.Checked = False
            Install_XGEN.Enabled = False
            Install_XGEN.Checked = False
            Menu_Options_XGEN.Checked = False
            Menu_Options_XGEN.Enabled = False
            XMB_XGEN.Enabled = False
            XMB_XGEN.Checked = False
        End If
        CheckBoot()
    End Sub
    'Options
    '-------
    'Format + Prepare the PSP
    Private Sub FormatPSP_CheckeDChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormatPSP.CheckedChanged
        If FormatPSP.Checked = True Then
            Option_Format = 1
            Menu_Options_Format.Checked = True
        Else
            Option_Format = 0
            Menu_Options_Format.Checked = False
        End If
    End Sub
    'Use MSPFormat
    Private Sub Check_MSPFormat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check_MSPFormat.CheckedChanged
        If Check_MSPFormat.Checked = True Then
            DoMSPFormat = 1
            Menu_Options_MSPFormat.Checked = True
        Else
            DoMSPFormat = 0
            Menu_Options_MSPFormat.Checked = False
        End If
    End Sub
    'Inject IPL
    Private Sub Check_IPL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check_IPL.CheckedChanged
        If Check_IPL.Checked = True Then
            InjectIPL = 1
            Menu_Options_IPL.Checked = True
        Else
            InjectIPL = 0
            Menu_Options_IPL.Checked = False
        End If
    End Sub
    'Backup Memory Stick
    Private Sub Button_Backup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Backup.Click
        Sub_Backup()
    End Sub
    'Restore Memory Stick
    Private Sub Button_Restore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Restore.Click
        Sub_Restore()
    End Sub
    'Noobz 1.50 Downgrader
    Private Sub Install_Noobz_CheckeDChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Install_Noobz.CheckedChanged
        If Install_Noobz.Checked = True Then
            If Install_150.Enabled = True Then
                Option_Noobz = 1
                Option_150 = 1
                Install_150.Checked = True
                Menu_Options_Noobz.Enabled = True
                Menu_Options_Noobz.Checked = True
                Install_DC3.Enabled = False
                Install_DC3.Checked = False
                Option_DC3 = 0
                Install_DC4.Enabled = False
                Install_DC4.Checked = False
                Option_DC4 = 0
                Options_SupportPandora.Enabled = False
                Options_SupportPandora.Checked = False
                Option_SupportPandora = 0
                SupportGroup_Pandora.Enabled = False
                Label1.Text = "Noobz 1.50 Downgrader"
                Label1.Refresh()
            End If
        Else
            Option_Noobz = 0
            If Option_371 = 1 Then
                Install_DC3.Enabled = True
                Menu_Options_DC3.Enabled = True
            End If
            If Option_380 = 1 Then
                Install_DC4.Enabled = True
                Menu_Options_DC4.Enabled = True
            End If
            Options_SupportPandora.Enabled = True
            Menu_Options_Other_Pandora.Enabled = True
            Menu_Options_Noobz.Enabled = False
            Install_Noobz.Checked = False
            Menu_Options_Noobz.Checked = False
            If Options_SupportPandora.Checked Then
                SupportGroup_Pandora.Enabled = True
            End If
            Label1.Text = "ELF Menu / DC v3 and v4"
            Label1.Refresh()
        End If
        CheckBoot()
    End Sub
    'Despertar Cementerio 3
    Private Sub Install_DC3_CheckeDChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Install_DC3.CheckedChanged
        If Install_DC3.Checked = True Then
            If Install_371.Enabled = True Then
                Option_DC3 = 1
                Option_371 = 1
                Install_371.Checked = True
                Menu_Options_DC3.Checked = True
            End If
        Else
            Option_DC3 = 0
            Install_DC3.Checked = False
            Menu_Options_DC3.Checked = False
        End If
        CheckBoot()
    End Sub
    'Despertar Cementerio 4
    Private Sub Install_DC4_CheckeDChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Install_DC4.CheckedChanged
        If Install_DC4.Checked = True Then
            If Install_380.Enabled = True Then
                Option_DC4 = 1
                Option_380 = 1
                Install_380.Checked = True
                Menu_Options_DC4.Checked = True
            End If
        Else
            Option_DC4 = 0
            Install_DC4.Checked = False
            Menu_Options_DC4.Checked = False
        End If
        CheckBoot()
    End Sub
    'Despertar Cementerio 5
    Private Sub Install_DC5_CheckeDChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Install_DC5.CheckedChanged
        If Install_DC5.Checked = True Then
            If Install_390.Enabled = True Then
                Option_DC5 = 1
                Option_390 = 1
                Install_390.Checked = True
                Menu_Options_DC5.Checked = True
            End If
        Else
            Option_DC5 = 0
            Install_DC5.Checked = False
            Menu_Options_DC5.Checked = False
        End If
        CheckBoot()
    End Sub
    'Despertar Cementerio 7
    Private Sub Install_DC7_CheckeDChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Install_DC7.CheckedChanged
        If Install_DC7.Checked = True Then
            If Install_401.Enabled = True Then
                main.Option_DC7 = 1
                Option_401 = 1
                Install_401.Checked = True
                Menu_Options_DC7.Checked = True
            End If
        Else
            main.Option_DC7 = 0
            Install_DC7.Checked = False
            Menu_Options_DC7.Checked = False
        End If
        CheckBoot()
    End Sub
    'Despertar Cementerio 8
    Private Sub Install_DC8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Install_DC8.CheckedChanged
        If Install_DC8.Checked = True Then
            If Install_500.Enabled = True Then
                Label4.Text = "Despertar Cementerio v8"
                main.Option_DC8 = 1
                Option_XGEN = 0
                Option_500 = 1
                Install_500.Checked = True
                Menu_Options_DC8.Checked = True
                Install_XGEN.Enabled = False
                Install_XGEN.Checked = False
                Menu_Options_XGEN.Enabled = False
                Menu_Options_XGEN.Checked = False
            End If
        Else
            main.Option_DC8 = 0
            Label4.Text = "XGEN Pandora Installer v5"
            Install_DC8.Checked = False
            Menu_Options_DC8.Checked = False
            Install_XGEN.Enabled = True
            Menu_Options_XGEN.Enabled = True
        End If
        RefreshScreen()
        CheckBoot()
    End Sub
    'TimeMachine
    Private Sub Install_TM_CheckeDChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Install_TM.CheckedChanged
        If Install_TM.Checked = True Then
            main.Option_TM = 1
            Menu_Options_TM.Checked = True
        Else
            main.Option_TM = 0
            Install_TM.Checked = False
            Menu_Options_TM.Checked = False
        End If
        CheckBoot()
    End Sub
    'XGEN Installer
    Private Sub Install_XGEN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Install_XGEN.CheckedChanged
        If Install_XGEN.Checked = True Then
            If Install_550.Enabled = True Then
                main.Option_XGEN = 1
                Label4.Text = "XGEN Pandora Installer v5"
                Option_DC8 = 0
                Option_550 = 1
                Install_550.Checked = True
                Menu_Options_XGEN.Checked = True
                Install_DC8.Enabled = False
                Install_DC8.Checked = False
                Menu_Options_DC8.Enabled = False
                Menu_Options_DC8.Checked = False
            End If
        Else
            main.Option_XGEN = 0
            Label4.Text = "Despertar Cementerio v8"
            Install_XGEN.Checked = False
            Menu_Options_XGEN.Checked = False
            Install_DC8.Enabled = True
            Menu_Options_DC8.Enabled = True
        End If
        RefreshScreen()
        CheckBoot()
    End Sub
    'Backup Before Installation
    Private Sub Options_BackupBefore_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Options_BackupBefore.CheckedChanged
        If Options_BackupBefore.Checked = True Then
            Option_BackupBefore = 1
            Menu_Options_Other_Backup.Checked = True
        Else
            Option_BackupBefore = 0
            Options_BackupBefore.Checked = False
            Menu_Options_Other_Backup.Checked = False
        End If
    End Sub
    'Restore Backup from PC after Installation
    Private Sub Options_RestoreAfter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Options_RestoreAfter.CheckedChanged
        If Options_RestoreAfter.Checked = True Then
            Option_RestoreAfter = 1
            Menu_Options_Other_Restore.Checked = True
        Else
            Option_RestoreAfter = 0
            Options_RestoreAfter.Checked = False
            Menu_Options_Other_Restore.Checked = False
        End If
    End Sub
    'Use Compression on Backup
    Private Sub Options_BackupCompression_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Options_BackupCompression.CheckedChanged
        If Options_BackupCompression.Checked = True Then
            Option_BackupCompress = 1
            Options_BackupCompression.Checked = True
            Menu_Options_BackupCompression.Checked = True
        Else
            Option_BackupCompress = 0
            Options_BackupCompression.Checked = False
            Menu_Options_BackupCompression.Checked = False
        End If
    End Sub
    'Install the M33 1.50 Addons
    Private Sub Options_150kernel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Options_150kernel.CheckedChanged
        If Options_150kernel.Checked = True Then
            If Option_XGEN <> 1 Then
                If Option_150 = 1 Then
                    Option_150Kernel = 1
                    If Option_DC3 = 1 Then
                        Option_371_150Kernel = 1
                    End If
                    If Option_DC4 = 1 Then
                        Option_380_150Kernel = 1
                    End If
                    If Option_DC5 = 1 Then
                        Option_390_150Kernel = 1
                    End If
                    If Option_DC7 = 1 Then
                        Option_401_150Kernel = 1
                    End If
                    If Option_DC8 = 1 Then
                        Option_500_150Kernel = 1
                    End If
                    Menu_Options_Other_150Addon.Checked = True
                    XMB_500m33.Enabled = False
                    XMB_500m33.Checked = False
                    XMB_XGEN.Enabled = False
                    XMB_XGEN.Checked = False
                    Option_XMB_500m33 = 0
                    Option_XMB_XGEN = 0
                End If
            Else
                Option_150Kernel = 0
                Option_371_150Kernel = 0
                Option_380_150Kernel = 0
                Option_390_150Kernel = 0
                Option_401_150Kernel = 0
                Option_500_150Kernel = 0
                Options_150kernel.Checked = False
                Menu_Options_Other_150Addon.Checked = False
                XMB_500m33.Enabled = True
                XMB_XGEN.Enabled = True
            End If
        End If
    End Sub
    'Install Support Tools for Pandora
    Private Sub Options_SupportPandora_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Options_SupportPandora.CheckedChanged
        If Options_SupportPandora.Checked = True Then
            Option_SupportPandora = 1
            Menu_Options_Other_Pandora.Checked = True
            SupportGroup_Pandora.Enabled = True
        Else
            Option_SupportPandora = 0
            Options_SupportPandora.Checked = False
            Menu_Options_Other_Pandora.Checked = False
            SupportGroup_Pandora.Enabled = False
        End If
        CheckBoot()
    End Sub
    'Install Support Tools for XMB
    Private Sub Options_SupportXMB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Options_SupportXMB.CheckedChanged
        If Options_SupportXMB.Checked = True Then
            Option_SupportXMB = 1
            Menu_Options_Other_XMB.Checked = True
            SupportGroup_XMB.Enabled = True
        Else
            Option_SupportXMB = 0
            Options_SupportXMB.Checked = False
            Menu_Options_Other_XMB.Checked = False
            SupportGroup_XMB.Enabled = False
        End If
    End Sub
    'Install POPSLoader
    Private Sub Options_Popsloader_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Options_Popsloader.CheckedChanged
        If Options_Popsloader.Checked = True Then
            Option_POPSLoader = 1
            Menu_Options_Other_POPSLoader.Checked = True
        Else
            Option_POPSLoader = 0
            Options_Popsloader.Checked = False
            Menu_Options_Other_POPSLoader.Checked = False
        End If
    End Sub
    'PSP Info Box
    'Scan for Logical Drives Button
    Private Sub Button_Scan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Scan.Click
        FindDrives()
    End Sub
    ' PSP Type 1.50 Kernel
    Private Sub Radio_150_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio_150.CheckedChanged
        If Radio_150.Checked = True Then
            Menu_Options_PSPType_150.Checked = True
            Radio_M33.Checked = False
            Menu_Options_PSPType_M33.Checked = False
            PSPType = 0
        Else
            Menu_Options_PSPType_150.Checked = False
            Radio_M33.Checked = True
            Menu_Options_PSPType_M33.Checked = True
            PSPType = 1
        End If
    End Sub
    ' PSP Type M33 Kernel
    Private Sub Radio_M33_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio_M33.CheckedChanged
        If Radio_M33.Checked = True Then
            Menu_Options_PSPType_M33.Checked = True
            Radio_150.Checked = False
            Menu_Options_PSPType_150.Checked = False
            PSPType = 1
        Else
            Menu_Options_PSPType_M33.Checked = False
            Radio_150.Checked = True
            Menu_Options_PSPType_150.Checked = True
            PSPType = 0
        End If
    End Sub
    'Start Installer Button
    Private Sub Button_Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Start.Click
        Sub_Start()
    End Sub
    ' Select All Checkbox for XMB Support Tools
    Private Sub XMB_SelectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XMB_SelectAll.CheckedChanged
        If XMB_SelectAll.Checked = True Then
            XMBAll()
        Else
            XMBNone()
        End If
    End Sub
    ' Pandora Support Tools
    ' KeyCleaner
    Private Sub Pandora_KeyCleaner_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pandora_KeyCleaner.CheckedChanged
        If Pandora_KeyCleaner.Checked = True Then
            Option_Pandora_KeyCleaner = 1
        Else
            Option_Pandora_KeyCleaner = 0
        End If
    End Sub
    ' NandTool
    Private Sub Pandora_Nandtool_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pandora_Nandtool.CheckedChanged
        If Pandora_Nandtool.Checked = True Then
            Option_Pandora_Nandtool = 1
        Else
            Option_Pandora_Nandtool = 0
        End If
    End Sub
    ' Recovery Flasher
    Private Sub Pandora_RFlash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pandora_RFlash.CheckedChanged
        If Pandora_RFlash.Checked = True Then
            Option_Pandora_RFlash = 1
        Else
            Option_Pandora_RFlash = 0
        End If
    End Sub
    ' XMB Support Tools
    ' 500-M33 6 Installer
    Private Sub XMB_500m33_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XMB_500m33.CheckedChanged
        If XMB_500m33.Checked = True Then
            Option_XMB_500m33 = 1
            Option_XGEN = 0
            Option_150Kernel = 0
            Option_371_150Kernel = 0
            Option_380_150Kernel = 0
            Option_390_150Kernel = 0
            Option_401_150Kernel = 0
            Option_500_150Kernel = 0
            Options_150kernel.Checked = False
            Options_150kernel.Enabled = False
            Menu_Options_Other_150Addon.Checked = False
            Menu_Options_Other_150Addon.Enabled = False
            Menu_Options_XGEN.Enabled = False
            Menu_Options_XGEN.Checked = False
        Else
            Option_XMB_500m33 = 0
            Options_150kernel.Enabled = True
            Menu_Options_Other_150Addon.Enabled = True
            Menu_Options_XGEN.Enabled = True
        End If
    End Sub
    ' Config Cleaner
    Private Sub XMB_CFWFolderBlocker_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XMB_CFWFolderBlocker.CheckedChanged
        If XMB_CFWFolderBlocker.Checked = True Then
            Option_XMB_CFWFolderBlocker = 1
        Else
            Option_XMB_CFWFolderBlocker = 0
        End If
    End Sub
    'CPU-Modulator
    Private Sub XMB_CPUModulator_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XMB_CPUModulator.CheckedChanged
        If XMB_CPUModulator.Checked = True Then
            Option_XMB_CPUModulator = 1
        Else
            Option_XMB_CPUModulator = 0
        End If
    End Sub
    ' Custom Firmware Extender
    Private Sub XMB_CFE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XMB_CFE.CheckedChanged
        If XMB_CFE.Checked = True Then
            Option_XMB_CFE = 1
        Else
            Option_XMB_CFE = 0
        End If
    End Sub
    'CW Cheat
    Private Sub XMB_CWCheat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XMB_CWCheat.CheckedChanged
        If XMB_CWCheat.Checked = True Then
            Option_XMB_CWCheat = 1
        Else
            Option_XMB_CWCheat = 0
        End If
    End Sub
    ' CXMB
    Private Sub XMB_CXMB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XMB_CXMB.CheckedChanged
        If XMB_CXMB.Checked = True Then
            Option_XMB_CXMB = 1
        Else
            Option_XMB_CXMB = 0
        End If
    End Sub
    ' Fusa ScreenShoot
    Private Sub XMB_FusaScr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XMB_FusaScr.CheckedChanged
        If XMB_FusaScr.Checked = True Then
            Option_XMB_FusaSCR = 1
        Else
            Option_XMB_FusaSCR = 0
        End If
    End Sub
    ' Fusa SD
    Private Sub XMB_FusaSD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XMB_FusaSD.CheckedChanged
        If XMB_FusaSD.Checked = True Then
            Option_XMB_FusaSD = 1
        Else
            Option_XMB_FusaSD = 0
        End If
    End Sub
    ' Hold+
    Private Sub XMB_Hold_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XMB_Hold.CheckedChanged
        If XMB_Hold.Checked = True Then
            Option_XMB_Hold = 1
        Else
            Option_XMB_Hold = 0
        End If
    End Sub
    ' Joysens
    Private Sub XMB_Joysens_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XMB_Joysens.CheckedChanged
        If XMB_Joysens.Checked = True Then
            Option_XMB_Joysens = 1
        Else
            Option_XMB_Joysens = 0
        End If
    End Sub
    ' KeyCleaner
    Private Sub XMB_KeyCleaner_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XMB_KeyCleaner.CheckedChanged
        If XMB_KeyCleaner.Checked = True Then
            Option_XMB_KeyCleaner = 1
        Else
            Option_XMB_KeyCleaner = 0
        End If
    End Sub
    ' MemoryStick-Tool
    Private Sub XMB_MemStickTool_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XMB_MemStickTool.CheckedChanged
        If XMB_MemStickTool.Checked = True Then
            Option_XMB_MemStickTool = 1
        Else
            Option_XMB_MemStickTool = 0
        End If
    End Sub
    ' Nandtool
    Private Sub XMB_Nandtool_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XMB_Nandtool.CheckedChanged
        If XMB_Nandtool.Checked = True Then
            Option_XMB_NandTool = 1
        Else
            Option_XMB_NandTool = 0
        End If
    End Sub
    ' NetConfBackup
    Private Sub XMB_NetConfBackup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XMB_NetConfBackup.CheckedChanged
        If XMB_NetConfBackup.Checked = True Then
            Option_XMB_NetConfBackup = 1
        Else
            Option_XMB_NetConfBackup = 0
        End If
    End Sub
    ' PSP Filer
    Private Sub XMB_PSPFiler_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XMB_PSPFiler.CheckedChanged
        If XMB_PSPFiler.Checked = True Then
            Option_XMB_PSPFiler = 1
        Else
            Option_XMB_PSPFiler = 0
        End If
    End Sub
    ' RSPSARDumper
    Private Sub XMB_RSPSARDumper_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XMB_RSPSARDumper.CheckedChanged
        If XMB_RSPSARDumper.Checked = True Then
            Option_XMB_RSPSARDumper = 1
        Else
            Option_XMB_RSPSARDumper = 0
        End If
    End Sub
    ' UMDrip
    Private Sub XMB_UMDrip_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XMB_UMDrip.CheckedChanged
        If XMB_UMDrip.Checked = True Then
            Option_XMB_UMDrip = 1
        Else
            Option_XMB_UMDrip = 0
        End If
    End Sub
    ' XGEN Installer
    Private Sub XMB_XGEN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XMB_XGEN.CheckedChanged
        If XMB_XGEN.Checked = True Then
            Option_XGEN = 1
            Option_XMB_500m33 = 0
            Option_150Kernel = 0
            Option_371_150Kernel = 0
            Option_380_150Kernel = 0
            Option_390_150Kernel = 0
            Option_401_150Kernel = 0
            Option_500_150Kernel = 0
            Options_150kernel.Checked = False
            Options_150kernel.Enabled = False
            Menu_Options_Other_150Addon.Checked = False
            Menu_Options_Other_150Addon.Enabled = False
        Else
            Option_XMB_XGEN = 0
            Options_150kernel.Enabled = True
            Menu_Options_Other_150Addon.Enabled = True
            Menu_Options_XGEN.Enabled = True
        End If
    End Sub
    'Config Options
    'Load Config
    Private Sub Button_LoadConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_LoadConfig.Click
        LoadConfigSub()
    End Sub
    'Save Config
    Private Sub Button_SaveConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SaveConfig.Click
        SaveConfigSub()
    End Sub
    'Reset Config
    Private Sub Button_ResetConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_ResetConfig.Click
        ClearConfig()
    End Sub
    'Check for Update
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        UpdateCheck()
    End Sub

    'SUBROUTINES
    '-----------
    'Clear Config
    Private Sub ClearConfig()
        DoMSPFormat = 0
        InjectIPL = 1
        Option_Format = 0
        Option_150 = 0
        Option_371 = 0
        Option_380 = 0
        Option_390 = 0
        Option_401 = 0
        Option_500 = 0
        Option_550 = 0
        Option_BackupBefore = 0
        Option_RestoreAfter = 0
        Option_BackupCompress = 0
        Option_150Kernel = 0
        Option_SupportPandora = 0
        Option_SupportXMB = 0
        Option_POPSLoader = 0
        Option_DC3 = 0
        Option_DC4 = 0
        Option_DC5 = 0
        Option_DC7 = 0
        Option_DC8 = 0
        Option_TM = 0
        Option_XGEN = 0
        Option_Noobz = 0
        Option_Pandora_KeyCleaner = 0
        Option_Pandora_Nandtool = 0
        Option_Pandora_RFlash = 0
        Option_XMB_All = 0
        Option_XMB_500m33 = 0
        Option_XMB_CFE = 0
        Option_XMB_CFWFolderBlocker = 0
        Option_XMB_CPUModulator = 0
        Option_XMB_CWCheat = 0
        Option_XMB_CXMB = 0
        Option_XMB_FusaSCR = 0
        Option_XMB_FusaSD = 0
        Option_XMB_Hold = 0
        Option_XMB_Joysens = 0
        Option_XMB_KeyCleaner = 0
        Option_XMB_MemStickTool = 0
        Option_XMB_NandTool = 0
        Option_XMB_NetConfBackup = 0
        Option_XMB_PSPFiler = 0
        Option_XMB_RSPSARDumper = 0
        Option_XMB_UMDrip = 0
        Option_XMB_XGEN = 0
        PSPType = 1

        Me.ButtonConfig_Combo1.Text = "Up"
        Me.ButtonConfig_Combo2.Text = "Right"
        Me.ButtonConfig_Combo3.Text = "Down"
        Me.ButtonConfig_Combo4.Text = "Left"
        Me.ButtonConfig_Combo5.Text = "LTrigger"
        Check_IPL.Checked = True
        Check_MSPFormat.Checked = False
        FormatPSP.Checked = False
        Install_150.Checked = False
        Install_371.Checked = False
        Install_380.Checked = False
        Install_390.Checked = False
        Install_401.Checked = False
        Install_500.Checked = False
        Install_550.Checked = False
        Install_DC3.Checked = False
        Install_DC4.Checked = False
        Install_DC5.Checked = False
        Install_DC7.Checked = False
        Install_DC8.Checked = False
        Install_Noobz.Checked = False
        Install_TM.Checked = False
        Install_XGEN.Checked = False
        Label1.Text = "ELF Menu / DC v3 and v4"
        Label4.Text = "Despertar Cementerio v8"
        Options_BackupBefore.Checked = False
        Options_RestoreAfter.Checked = False
        Options_BackupCompression.Checked = False
        Options_150kernel.Checked = False
        Options_150kernel.Enabled = False
        Options_SupportPandora.Checked = False
        Options_SupportXMB.Checked = False
        Options_Popsloader.Checked = False
        Pandora_KeyCleaner.Checked = False
        Pandora_Nandtool.Checked = False
        Pandora_RFlash.Checked = False
        Radio_M33.Checked = True
        Radio_150.Checked = False
        SupportGroup_Pandora.Enabled = False
        SupportGroup_XMB.Enabled = False
        XMB_SelectAll.Checked = False
        XMB_500m33.Checked = False
        XMB_500m33.Enabled = False
        XMB_CFE.Checked = False
        XMB_CFWFolderBlocker.Checked = False
        XMB_CPUModulator.Checked = False
        XMB_CWCheat.Checked = False
        XMB_CXMB.Checked = False
        XMB_FusaScr.Checked = False
        XMB_FusaSD.Checked = False
        XMB_Hold.Checked = False
        XMB_Joysens.Checked = False
        XMB_KeyCleaner.Checked = False
        XMB_MemStickTool.Checked = False
        XMB_Nandtool.Checked = False
        XMB_NetConfBackup.Checked = False
        XMB_PSPFiler.Checked = False
        XMB_RSPSARDumper.Checked = False
        XMB_UMDrip.Checked = False
        XMB_XGEN.Checked = False
        XMB_XGEN.Enabled = False

        Menu_Options_Format.Checked = False
        Menu_Options_Install150.Checked = False
        Menu_Options_Install371.Checked = False
        Menu_Options_Install380.Checked = False
        Menu_Options_Install390.Checked = False
        Menu_Options_Install401.Checked = False
        Menu_Options_Install500.Checked = False
        Menu_Options_Install550.Checked = False
        Menu_Options_DC3.Checked = False
        Menu_Options_DC4.Checked = False
        Menu_Options_DC5.Checked = False
        Menu_Options_DC7.Checked = False
        Menu_Options_DC8.Checked = False
        Menu_Options_TM.Checked = False
        Menu_Options_XGEN.Checked = False
        Menu_Options_IPL.Checked = True
        Menu_Options_MSPFormat.Checked = False
        Menu_Options_Noobz.Checked = False
        Menu_Options_PSPType_150.Checked = False
        Menu_Options_PSPType_M33.Checked = True
        Menu_Options_Other_Backup.Checked = False
        Menu_Options_Other_Restore.Checked = False
        Menu_Options_BackupCompression.Checked = False
        Menu_Options_Other_150Addon.Checked = False
        Menu_Options_Other_150Addon.Enabled = False
        Menu_Options_Other_Pandora.Checked = False
        Menu_Options_Other_XMB.Checked = False
        Menu_Options_Other_POPSLoader.Checked = False

        Me.Refresh()

        XMBNone()
        CheckBoot()
    End Sub
    ' XMB Select All Turned off 
    Private Sub XMBNone()
        XMB_SelectAll.Checked = False
        XMB_CFE.Checked = False
        XMB_CFWFolderBlocker.Checked = False
        XMB_CPUModulator.Checked = False
        XMB_CWCheat.Checked = False
        XMB_CXMB.Checked = False
        XMB_FusaScr.Checked = False
        XMB_FusaSD.Checked = False
        XMB_Hold.Checked = False
        XMB_Joysens.Checked = False
        XMB_KeyCleaner.Checked = False
        XMB_MemStickTool.Checked = False
        XMB_Nandtool.Checked = False
        XMB_NetConfBackup.Checked = False
        XMB_PSPFiler.Checked = False
        XMB_RSPSARDumper.Checked = False
        XMB_UMDrip.Checked = False
        XMB_XGEN.Checked = False
        XMB_500m33.Checked = False
        Option_XMB_All = 0
        Option_XMB_500m33 = 0
        Option_XMB_CFE = 0
        Option_XMB_CFWFolderBlocker = 0
        Option_XMB_CPUModulator = 0
        Option_XMB_CWCheat = 0
        Option_XMB_CXMB = 0
        Option_XMB_FusaSCR = 0
        Option_XMB_FusaSD = 0
        Option_XMB_Hold = 0
        Option_XMB_Joysens = 0
        Option_XMB_KeyCleaner = 0
        Option_XMB_MemStickTool = 0
        Option_XMB_NandTool = 0
        Option_XMB_NetConfBackup = 0
        Option_XMB_PSPFiler = 0
        Option_XMB_RSPSARDumper = 0
        Option_XMB_UMDrip = 0
        Option_XMB_XGEN = 0
    End Sub
    ' XMB Select All Turned off 
    Private Sub XMBAll()
        XMB_SelectAll.Checked = True
        XMB_CFE.Checked = True
        XMB_CFWFolderBlocker.Checked = True
        XMB_CPUModulator.Checked = True
        XMB_CWCheat.Checked = True
        XMB_CXMB.Checked = True
        XMB_FusaScr.Checked = True
        XMB_FusaSD.Checked = True
        XMB_Hold.Checked = True
        XMB_Joysens.Checked = True
        XMB_KeyCleaner.Checked = True
        XMB_MemStickTool.Checked = True
        XMB_Nandtool.Checked = True
        XMB_NetConfBackup.Checked = True
        XMB_PSPFiler.Checked = True
        XMB_RSPSARDumper.Checked = True
        XMB_UMDrip.Checked = True
        Option_XMB_All = 1
        Option_XMB_CFE = 1
        Option_XMB_CFWFolderBlocker = 1
        Option_XMB_CPUModulator = 1
        Option_XMB_CWCheat = 1
        Option_XMB_CXMB = 1
        Option_XMB_FusaSCR = 1
        Option_XMB_FusaSD = 1
        Option_XMB_Hold = 1
        Option_XMB_Joysens = 1
        Option_XMB_KeyCleaner = 1
        Option_XMB_MemStickTool = 1
        Option_XMB_NandTool = 1
        Option_XMB_NetConfBackup = 1
        Option_XMB_PSPFiler = 1
        Option_XMB_RSPSARDumper = 1
        Option_XMB_UMDrip = 1
    End Sub
    'Logical Drives
    Private Sub FindDrives()
        Drive_ComboBox.Items.Clear()
        For Each drive As String In Directory.GetLogicalDrives()
            Dim a As New System.IO.DriveInfo(drive)
            If a.DriveType = IO.DriveType.Removable Then
                If drive = "A:\" Then
                    GoTo DriveJump
                End If
                If MessageBox.Show("Is " + drive + " Drive your PSP?", "PSP Detection", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Drive_ComboBox.Items.Add(drive)
                    Drive_ComboBox.SelectedIndex = 0
                End If
DriveJump:
            End If
        Next drive
    End Sub
    'Load 1.50 Firmware
    Private Sub Load150()
        Dim errormsg As String = 0
        With OpenFile_150
            .FilterIndex = 1
            .Filter = "PBP Files (*.PBP)|*.pbp"
            .Title = "Please locate the 1.50 Firmware Eboot File"
            .Multiselect = False
        End With
        If OpenFile_150.ShowDialog <> DialogResult.OK Then
            errormsg = 1
        End If
        If errormsg = 0 Then
            FileName1 = OpenFile_150.FileName
            FileMD5 = FileName1
            CreateMD5()
            If MD5Label.Text <> File1MD5 Then
                MessageBox.Show(copyerror1, "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
                Install_150.Enabled = False
                errormsg = 2
            End If
        End If
        If errormsg = 2 Then
            If System.IO.File.Exists(Path1) Then
                FileMD5 = Path1
                CreateMD5()
                If MD5Label.Text <> File1MD5 Then
                    Install_150.Enabled = False
                    errormsg = 1
                End If
                errormsg = 0
            End If
        End If
        If errormsg = 0 Then
            Try
                System.IO.File.Delete(Path1)
                System.IO.File.Copy(FileName1, Path1, True)
                Button_150.Enabled = False
                Menu_File_Open150.Enabled = False
                Install_150.Enabled = True
                Menu_Options_Install150.Enabled = True
            Catch
                MessageBox.Show(copyerror2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
                Install_150.Enabled = False
            End Try
            errormsg = 0
        End If
    End Sub
    'Load 3.71 Firmware
    Private Sub Load371()
        Dim errormsg As String = 0
        With OpenFile_371
            .FilterIndex = 1
            .Filter = "PBP Files (*.PBP)|*.pbp"
            .Title = "Please locate the 3.71 Firmware Eboot File"
            .Multiselect = False
        End With
        If OpenFile_371.ShowDialog <> DialogResult.OK Then
            errormsg = 1
        End If
        If errormsg = 0 Then
            FileName2 = OpenFile_371.FileName
            FileMD5 = FileName2
            CreateMD5()
            If MD5Label.Text <> File2MD5 Then
                MessageBox.Show(copyerror1, "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
                Install_371.Enabled = False
                errormsg = 2
            End If
        End If
        If errormsg = 2 Then
            If System.IO.File.Exists(Path2) Then
                FileMD5 = Path2
                CreateMD5()
                If MD5Label.Text <> File1MD5 Then
                    Install_371.Enabled = False
                    errormsg = 1
                End If
                errormsg = 0
            End If
        End If
        If errormsg = 0 Then
            Try
                System.IO.File.Delete(Path2)
                System.IO.File.Copy(FileName2, Path2, True)
                Button_371.Enabled = False
                Menu_File_Open371.Enabled = False
                Install_371.Enabled = True
                Menu_Options_Install371.Enabled = True
            Catch
                MessageBox.Show(copyerror2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
                Install_371.Enabled = False
            End Try
            errormsg = 0
        End If
    End Sub
    'Load 3.80 Firmware
    Private Sub Load380()
        Dim errormsg As String = 0
        With OpenFile_380
            .FilterIndex = 1
            .Filter = "PBP Files (*.PBP)|*.pbp"
            .Title = "Please locate the 3.80 Firmware Eboot File"
            .Multiselect = False
        End With
        If OpenFile_380.ShowDialog <> DialogResult.OK Then
            errormsg = 1
        End If
        If errormsg = 0 Then
            FileName3 = OpenFile_380.FileName
            FileMD5 = FileName3
            CreateMD5()
            If MD5Label.Text <> File3MD5 Then
                MessageBox.Show(copyerror1, "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
                Install_380.Enabled = False
                errormsg = 2
            End If
        End If
        If errormsg = 2 Then
            If System.IO.File.Exists(Path3) Then
                FileMD5 = Path3
                CreateMD5()
                If MD5Label.Text <> File3MD5 Then
                    Install_380.Enabled = False
                    errormsg = 1
                End If
                errormsg = 0
            End If
        End If
        If errormsg = 0 Then
            Try
                System.IO.File.Delete(Path3)
                System.IO.File.Copy(FileName3, Path3, True)
                Button_380.Enabled = False
                Menu_File_Open380.Enabled = False
                Install_380.Enabled = True
                Menu_Options_Install380.Enabled = True
            Catch
                MessageBox.Show(copyerror2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
                Install_380.Enabled = False
            End Try
            errormsg = 0
        End If
    End Sub
    'Load 3.90 Firmware
    Private Sub Load390()
        Dim errormsg As String = 0
        With OpenFile_390
            .FilterIndex = 1
            .Filter = "PBP Files (*.PBP)|*.pbp"
            .Title = "Please locate the 3.90 Firmware Eboot File"
            .Multiselect = False
        End With
        If OpenFile_390.ShowDialog <> DialogResult.OK Then
            errormsg = 1
        End If
        If errormsg = 0 Then
            FileName4 = OpenFile_390.FileName
            FileMD5 = FileName4
            CreateMD5()
            If MD5Label.Text <> File4MD5 Then
                MessageBox.Show(copyerror1, "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
                Install_390.Enabled = False
                errormsg = 2
            End If
        End If
        If errormsg = 2 Then
            If System.IO.File.Exists(Path4) Then
                FileMD5 = Path4
                CreateMD5()
                If MD5Label.Text <> File4MD5 Then
                    Install_390.Enabled = False
                    errormsg = 1
                End If
                errormsg = 0
            End If
        End If
        If errormsg = 0 Then
            Try
                System.IO.File.Delete(Path4)
                System.IO.File.Copy(FileName4, Path4, True)
                Button_390.Enabled = False
                Menu_File_Open390.Enabled = False
                Install_390.Enabled = True
                Menu_Options_Install390.Enabled = True
            Catch
                MessageBox.Show(copyerror2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
                Install_390.Enabled = False
            End Try
            errormsg = 0
        End If
    End Sub
    'Load 4.01 Firmware
    Private Sub Load401()
        Dim errormsg As String = 0
        With OpenFile_401
            .FilterIndex = 1
            .Filter = "PBP Files (*.PBP)|*.pbp"
            .Title = "Please locate the 4.01 Firmware Eboot File"
            .Multiselect = False
        End With
        If OpenFile_401.ShowDialog <> DialogResult.OK Then
            errormsg = 1
        End If
        If errormsg = 0 Then
            FileName5 = OpenFile_401.FileName
            FileMD5 = FileName5
            CreateMD5()
            If MD5Label.Text <> File5MD5 Then
                MessageBox.Show(copyerror1, "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
                Install_401.Enabled = False
                errormsg = 2
            End If
        End If
        If errormsg = 2 Then
            If System.IO.File.Exists(Path5) Then
                FileMD5 = Path5
                CreateMD5()
                If MD5Label.Text <> File5MD5 Then
                    Install_401.Enabled = False
                    errormsg = 1
                End If
                errormsg = 0
            End If
        End If
        If errormsg = 0 Then
            Try
                System.IO.File.Delete(Path5)
                System.IO.File.Copy(FileName5, Path5, True)
                Button_401.Enabled = False
                Menu_File_Open401.Enabled = False
                Install_401.Enabled = True
                Menu_Options_Install401.Enabled = True
            Catch
                MessageBox.Show(copyerror2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
                Install_401.Enabled = False
            End Try
            errormsg = 0
        End If
    End Sub
    'Load 5.00 Firmware
    Private Sub Load500()
        Dim errormsg As String = 0
        With OpenFile_500
            .FilterIndex = 1
            .Filter = "PBP Files (*.PBP)|*.pbp"
            .Title = "Please locate the 5.00 Firmware Eboot File"
            .Multiselect = False
        End With
        If OpenFile_500.ShowDialog <> DialogResult.OK Then
            errormsg = 1
        End If
        If errormsg = 0 Then
            FileName6 = OpenFile_500.FileName
            FileMD5 = FileName6
            CreateMD5()
            If MD5Label.Text <> File6MD5 Then
                MessageBox.Show(copyerror1, "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
                Install_500.Enabled = False
                errormsg = 2
            End If
        End If
        If errormsg = 2 Then
            If System.IO.File.Exists(Path6) Then
                FileMD5 = Path6
                CreateMD5()
                If MD5Label.Text <> File6MD5 Then
                    Install_500.Enabled = False
                    errormsg = 1
                End If
                errormsg = 0
            End If
        End If
        If errormsg = 0 Then
            Try
                System.IO.File.Delete(Path6)
                System.IO.File.Copy(FileName6, Path6, True)
                Button_500.Enabled = False
                Menu_File_Open500.Enabled = False
                Install_500.Enabled = True
                Menu_Options_Install500.Enabled = True
            Catch
                MessageBox.Show(copyerror2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
                Install_500.Enabled = False
            End Try
            errormsg = 0
        End If
    End Sub
    'Load 5.50 Firmware
    Private Sub Load550()
        Dim errormsg As String = 0
        With OpenFile_550
            .FilterIndex = 1
            .Filter = "PBP Files (*.PBP)|*.pbp"
            .Title = "Please locate the 5.50 Firmware Eboot File"
            .Multiselect = False
        End With
        If OpenFile_550.ShowDialog <> DialogResult.OK Then
            errormsg = 1
        End If
        If errormsg = 0 Then
            FileName7 = OpenFile_550.FileName
            FileMD5 = FileName7
            CreateMD5()
            If MD5Label.Text <> File7MD5 Then
                MessageBox.Show(copyerror1, "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
                Install_500.Enabled = False
                errormsg = 2
            End If
        End If
        If errormsg = 2 Then
            If System.IO.File.Exists(Path7) Then
                FileMD5 = Path7
                CreateMD5()
                If MD5Label.Text <> File7MD5 Then
                    Install_550.Enabled = False
                    errormsg = 1
                End If
                errormsg = 0
            End If
        End If
        If errormsg = 0 Then
            Try
                System.IO.File.Delete(Path7)
                System.IO.File.Copy(FileName7, Path7, True)
                Button_550.Enabled = False
                Menu_File_Open550.Enabled = False
                Install_550.Enabled = True
                Menu_Options_Install550.Enabled = True
            Catch
                MessageBox.Show(copyerror2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
                Install_550.Enabled = False
            End Try
            errormsg = 0
        End If
    End Sub
    'Get MD5 Hash
    Shared Sub CreateMD5()
        Dim md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider
        Dim f As FileStream = New FileStream(FileMD5, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        f = New FileStream(FileMD5, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        md5.ComputeHash(f)
        f.Close()
        Dim hash As Byte() = md5.Hash
        Dim buff As StringBuilder = New StringBuilder
        Dim hashByte As Byte
        For Each hashByte In hash
            buff.Append(String.Format("{0:X2}", hashByte))
        Next
        main.MD5Label.Text = buff.ToString()
    End Sub
    'Check to see if Boot Menus are needed
    Shared Sub CheckBoot()
        If main.Option_DC3 = 1 Or main.Option_DC4 = 1 Or main.Option_Noobz = 1 Or main.Option_SupportPandora = 1 Then
            main.ButtonConfig_Combo1.Enabled = True
        Else
            main.ButtonConfig_Combo1.Enabled = False
        End If
        If main.Option_DC5 = 1 Then
            main.ButtonConfig_Combo4.Enabled = True
        Else
            main.ButtonConfig_Combo4.Enabled = False
        End If
        If main.Option_DC7 = 1 Then
            main.ButtonConfig_Combo2.Enabled = True
        Else
            main.ButtonConfig_Combo2.Enabled = False
        End If
        If main.Option_DC8 = 1 Or main.Option_XGEN = 1 Then
            main.ButtonConfig_Combo5.Enabled = True
        Else
            main.ButtonConfig_Combo5.Enabled = False
        End If
        If main.Option_TM = 1 Then
            main.ButtonConfig_Combo3.Enabled = True
        Else
            main.ButtonConfig_Combo3.Enabled = False
        End If
    End Sub
    'Backup Memory Stick
    Private Sub Sub_Backup()
        If MessageBox.Show("Please note this will delete any previous backup made. Press OK to proceed.", "Backup Memory Stick", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            Me.TabBox.Enabled = False
            Me.PSP_Drive_Group.Enabled = False
            Me.Card_Options_Group.Enabled = False
            Me.MenuBox.Enabled = False
            Me.Button1.Enabled = False
            PSPPath = Drive_ComboBox.Text
            Backup.Show()
            Backup.Close()
            Me.TabBox.Enabled = True
            Me.PSP_Drive_Group.Enabled = True
            Me.Card_Options_Group.Enabled = True
            Me.MenuBox.Enabled = True
            Me.Button1.Enabled = True
        End If
    End Sub
    'Restore Memory Stick
    Private Sub Sub_Restore()
        If MessageBox.Show("This will restore the backup made of your PSP Memory Stick. Press OK to proceed.", "Restore Memory Stick", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            If MessageBox.Show("Do you wish to format your Memory Stick?", "Format Memory Stick", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Option_RestoreFormat = 1
            End If
            PSPPath = Drive_ComboBox.Text
            FormatPath = PSPPath.Remove(1, 2)
            Me.TabBox.Enabled = False
            Me.PSP_Drive_Group.Enabled = False
            Me.Card_Options_Group.Enabled = False
            Me.MenuBox.Enabled = False
            Me.Button1.Enabled = False
            Restore.Show()
            Restore.Close()
            Me.TabBox.Enabled = True
            Me.PSP_Drive_Group.Enabled = True
            Me.Card_Options_Group.Enabled = True
            Me.MenuBox.Enabled = True
            Me.Button1.Enabled = True
        End If
    End Sub
    'Start Installer
    Private Sub Sub_Start()
        Dim errormsg = 0
        Dim PSPPath = Drive_ComboBox.Text
        'Checking to see if a Drive is selected
        Try
            DriveCheck = PSPPath.Remove(0, 1)
        Catch
            MessageBox.Show("Please select a drive to install to.", "No Drive", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GoTo EndofStart
        End Try
        'Checking to make sure no triggers are doubled up
        errormsg = 0
        If ButtonConfig_Combo1.Enabled = True Then
            If ButtonConfig_Combo1.Text = ButtonConfig_Combo2.Text Or ButtonConfig_Combo1.Text = ButtonConfig_Combo3.Text Or ButtonConfig_Combo1.Text = ButtonConfig_Combo4.Text Or ButtonConfig_Combo1.Text = ButtonConfig_Combo5.Text Then
                errormsg = 1
            End If
        End If
        If ButtonConfig_Combo2.Enabled = True Then
            If ButtonConfig_Combo2.Text = ButtonConfig_Combo1.Text Or ButtonConfig_Combo2.Text = ButtonConfig_Combo3.Text Or ButtonConfig_Combo2.Text = ButtonConfig_Combo4.Text Or ButtonConfig_Combo2.Text = ButtonConfig_Combo5.Text Then
                errormsg = 1
            End If
        End If
        If ButtonConfig_Combo3.Enabled = True Then
            If ButtonConfig_Combo3.Text = ButtonConfig_Combo1.Text Or ButtonConfig_Combo3.Text = ButtonConfig_Combo2.Text Or ButtonConfig_Combo3.Text = ButtonConfig_Combo4.Text Or ButtonConfig_Combo3.Text = ButtonConfig_Combo5.Text Then
                errormsg = 1
            End If
        End If
        If ButtonConfig_Combo4.Enabled = True Then
            If ButtonConfig_Combo4.Text = ButtonConfig_Combo1.Text Or ButtonConfig_Combo4.Text = ButtonConfig_Combo2.Text Or ButtonConfig_Combo4.Text = ButtonConfig_Combo3.Text Or ButtonConfig_Combo4.Text = ButtonConfig_Combo5.Text Then
                errormsg = 1
            End If
        End If
        If ButtonConfig_Combo5.Enabled = True Then
            If ButtonConfig_Combo5.Text = ButtonConfig_Combo1.Text Or ButtonConfig_Combo5.Text = ButtonConfig_Combo2.Text Or ButtonConfig_Combo5.Text = ButtonConfig_Combo3.Text Or ButtonConfig_Combo5.Text = ButtonConfig_Combo4.Text Then
                errormsg = 1
            End If
        End If
        If errormsg = 1 Then
            MessageBox.Show("Please check that you are not using the same boot button twice.", "Problem with Boot Buttons", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GoTo EndofStart
        End If
        'Checking to see if Eboot files are loaded
        errormsg = 0
        If Option_150 = 1 Then
            If Button_150.Enabled = True Then
                errormsg = 1
            End If
        End If
        If Option_371 = 1 Then
            If Button_371.Enabled = True Then
                errormsg = 1
            End If
        End If
        If Option_380 = 1 Then
            If Button_380.Enabled = True Then
                errormsg = 1
            End If
        End If
        If Option_390 = 1 Then
            If Button_390.Enabled = True Then
                errormsg = 1
            End If
        End If
        If Option_401 = 1 Then
            If Button_401.Enabled = True Then
                errormsg = 1
            End If
        End If
        If Option_500 = 1 Then
            If Button_500.Enabled = True Then
                errormsg = 1
            End If
        End If
        If Option_550 = 1 Then
            If Button_550.Enabled = True Then
                errormsg = 1
            End If
        End If
        If errormsg = 1 Then
            MessageBox.Show("Please check that you loaded in the required Eboots.", "Problem with Eboot Files", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GoTo EndofStart
        End If
        errormsg = 0
        Me.TabBox.Enabled = False
        Me.PSP_Drive_Group.Enabled = False
        Me.Card_Options_Group.Enabled = False
        Me.MenuBox.Enabled = False
        Me.Button1.Enabled = False
        RefreshScreen()
        If MessageBox.Show("Do you wish to proceed.", "Start Installation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            FormatPath = PSPPath.Remove(1, 2)
            Option_BootButton1 = ButtonConfig_Combo1.Text
            Option_BootButton2 = ButtonConfig_Combo2.Text
            Option_BootButton3 = ButtonConfig_Combo3.Text
            Option_BootButton4 = ButtonConfig_Combo4.Text
            Option_BootButton5 = ButtonConfig_Combo5.Text
            TabBox.SelectedTab = TabPage4
            Log.Text = ""
            Me.Log.Enabled = True
            Copy.Show()
            Copy.Close()
        End If
        Me.TabBox.Enabled = True
        Me.PSP_Drive_Group.Enabled = True
        Me.Card_Options_Group.Enabled = True
        Me.MenuBox.Enabled = True
        Me.Button1.Enabled = True
EndofStart:
    End Sub
    'Get OS Version
    Public Function GetVersion() As String
        Dim os_version As OperatingSystem = System.Environment.OSVersion
        With os_version
            Select Case .Platform
                Case .Platform.Win32Windows
                    ' Win32.
                    Select Case (.Version.Minor)
                        Case 0
                            Return "95"
                        Case 10
                            If .Version.Revision.ToString() = "2222A" Then
                                Return "98SE"
                            Else
                                Return "98"
                            End If
                        Case 90
                            Return "ME"
                    End Select
                Case .Platform.Win32NT
                    ' WinNT.
                    Select Case (.Version.Major)
                        Case 3
                            Return "NT351"
                        Case 4
                            Return "NT4"
                        Case 5
                            Select Case (.Version.Minor)
                                Case 0
                                    Return "2000"
                                Case 1
                                    Return "XP"
                                Case 2
                                    Return "2003"
                            End Select
                        Case 6
                            Return "Vista"
                        Case 7
                            Return "Win7"
                        Case Else
                            Return "Unknown"
                    End Select
                Case Else
                    Return "Unknown"
            End Select
        End With
    End Function
    'Load + Apply Config
    Private Sub LoadConfigSub()
        StatusLabel1.Text = "Loading Configuration File..."
        main.RefreshScreen()
        With LoadConfig
            .FilterIndex = 1
            .Filter = "INI Files (*.INI)|*.ini"
            .Title = "Select a Configuration to Install"
            .ShowDialog()
        End With
        Dim ConfigFileName As String = LoadConfig.FileName
        If IO.File.Exists(ConfigPath) Then
            IO.File.Delete(ConfigPath)
        End If
        Try
            IO.File.Copy(ConfigFileName, ConfigPath, True)
        Catch
            MessageBox.Show("Failed to load the Configuration File.", "Error during Load", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ' Clear Config
        ClearConfig()
        ' Apply Configuration
        ' [Main] Section
        StatusLabel1.Text = "Applying Configuration File..."
        main.RefreshScreen()
        If ReadIni(ConfigPath, "Main", "PSPType") = "0" Then
            PSPType = 0
            Menu_Options_PSPType_M33.Checked = False
            Radio_M33.Checked = False
            Menu_Options_PSPType_150.Checked = True
            Radio_150.Checked = True
            Radio_M33.Refresh()
            Radio_150.Refresh()
        End If
        If ReadIni(ConfigPath, "Main", "Format") = "1" Then
            Option_Format = 1
            FormatPSP.Checked = True
            Menu_Options_Format.Checked = True
            FormatPSP.Refresh()
        End If
        If ReadIni(ConfigPath, "Main", "MSPFormat") = "1" Then
            DoMSPFormat = 1
            Check_MSPFormat.Checked = True
            Menu_Options_MSPFormat.Checked = True
            Check_MSPFormat.Refresh()
        End If
        If ReadIni(ConfigPath, "Main", "IPL") = "0" Then
            InjectIPL = 0
            Check_IPL.Checked = False
            Menu_Options_IPL.Checked = False
            Check_IPL.Refresh()
        End If
        ' Apply Configuration
        ' [Triggers] Section
        Dim TempButton1 As String = ReadIni(ConfigPath, "Triggers", "Button1")
        TempButton1 = ButtonConfig_Combo1.Text
        Dim TempButton2 As String = ReadIni(ConfigPath, "Triggers", "Button2")
        TempButton2 = ButtonConfig_Combo2.Text
        Dim TempButton3 As String = ReadIni(ConfigPath, "Triggers", "Button3")
        TempButton3 = ButtonConfig_Combo3.Text
        Dim TempButton4 As String = ReadIni(ConfigPath, "Triggers", "Button4")
        TempButton4 = ButtonConfig_Combo4.Text
        Dim TempButton5 As String = ReadIni(ConfigPath, "Triggers", "Button5")
        TempButton5 = ButtonConfig_Combo5.Text
        ButtonConfig_Combo1.Refresh()
        ButtonConfig_Combo2.Refresh()
        ButtonConfig_Combo3.Refresh()
        ButtonConfig_Combo4.Refresh()
        ButtonConfig_Combo5.Refresh()
        ' Apply Configuration
        ' [Firmware] Section
        If ReadIni(ConfigPath, "Firmware", "Install_150") = "1" Then
            Option_150 = 1
            Install_150.Enabled = True
            Install_150.Checked = True
            Menu_Options_Install150.Enabled = True
            Menu_Options_Install150.Checked = True
            Install_150.Refresh()
        End If
        If ReadIni(ConfigPath, "Firmware", "Install_371") = "1" Then
            Option_371 = 1
            Install_371.Enabled = True
            Install_371.Checked = True
            Menu_Options_Install371.Enabled = True
            Menu_Options_Install371.Checked = True
            Install_371.Refresh()
        End If
        If ReadIni(ConfigPath, "Firmware", "Install_380") = "1" Then
            Option_380 = 1
            Install_380.Enabled = True
            Install_380.Checked = True
            Menu_Options_Install380.Enabled = True
            Menu_Options_Install380.Checked = True
            Install_380.Refresh()
        End If
        If ReadIni(ConfigPath, "Firmware", "Install_390") = "1" Then
            Option_390 = 1
            Install_390.Enabled = True
            Install_390.Checked = True
            Menu_Options_Install390.Enabled = True
            Menu_Options_Install390.Checked = True
            Install_390.Refresh()
        End If
        If ReadIni(ConfigPath, "Firmware", "Install_401") = "1" Then
            Option_401 = 1
            Install_401.Enabled = True
            Install_401.Checked = True
            Menu_Options_Install401.Enabled = True
            Menu_Options_Install401.Checked = True
            Install_401.Refresh()
        End If
        If ReadIni(ConfigPath, "Firmware", "Install_500") = "1" Then
            Option_500 = 1
            Install_500.Enabled = True
            Install_500.Checked = True
            Menu_Options_Install500.Enabled = True
            Menu_Options_Install500.Checked = True
            Install_500.Refresh()
        End If
        If ReadIni(ConfigPath, "Firmware", "Install_550") = "1" Then
            Option_550 = 1
            Install_550.Enabled = True
            Install_550.Checked = True
            Menu_Options_Install550.Enabled = True
            Menu_Options_Install550.Checked = True
            Install_550.Refresh()
        End If

        ' Apply Configuration
        ' [Installers] Section
        If ReadIni(ConfigPath, "Installers", "Noobz") = "1" Then
            Label1.Text = "Noobz 1.50 Downgrader"
            Label1.Refresh()
            Option_Noobz = 1
            Install_Noobz.Checked = True
            Install_DC3.Enabled = False
            Install_DC4.Enabled = False
            Menu_Options_Noobz.Checked = True
            Menu_Options_DC3.Enabled = False
            Menu_Options_DC4.Enabled = False
            Install_Noobz.Refresh()
        End If
        If ReadIni(ConfigPath, "Installers", "DC3") = "1" Then
            Option_DC3 = 1
            Install_DC3.Enabled = True
            Install_DC3.Checked = True
            Menu_Options_DC3.Enabled = True
            Menu_Options_DC3.Checked = True
            Install_DC3.Refresh()
        End If
        If ReadIni(ConfigPath, "Installers", "DC4") = "1" Then
            Option_DC4 = 1
            Install_DC4.Enabled = True
            Install_DC4.Checked = True
            Menu_Options_DC4.Enabled = True
            Menu_Options_DC4.Checked = True
            Install_DC4.Refresh()
        End If
        If ReadIni(ConfigPath, "Installers", "DC5") = "1" Then
            Option_DC5 = 1
            Install_DC5.Enabled = True
            Install_DC5.Checked = True
            Menu_Options_DC5.Enabled = True
            Menu_Options_DC5.Checked = True
            Install_DC5.Refresh()
        End If
        If ReadIni(ConfigPath, "Installers", "DC7") = "1" Then
            Option_DC7 = 1
            Install_DC7.Enabled = True
            Install_DC7.Checked = True
            Menu_Options_DC7.Enabled = True
            Menu_Options_DC7.Checked = True
            Install_DC7.Refresh()
        End If
        If ReadIni(ConfigPath, "Installers", "DC8") = "1" Then
            Option_DC8 = 1
            Install_DC8.Enabled = True
            Install_DC8.Checked = True
            Menu_Options_DC8.Enabled = True
            Menu_Options_DC8.Checked = True
            Install_DC8.Refresh()
        End If
        If ReadIni(ConfigPath, "Installers", "TM") = "1" Then
            Option_TM = 1
            Install_TM.Checked = True
            Menu_Options_TM.Checked = True
            Install_TM.Refresh()
        End If
        If ReadIni(ConfigPath, "Installers", "XGEN") = "1" Then
            Label4.Text = "XGEN Pandora Installer v5"
            Option_XGEN = 1
            Install_XGEN.Enabled = True
            Install_XGEN.Checked = True
            Menu_Options_XGEN.Enabled = True
            Menu_Options_XGEN.Checked = True
            Label4.Refresh()
            Install_XGEN.Refresh()
        End If
        ' Apply Configuration
        ' [Other] Section
        If ReadIni(ConfigPath, "Other", "Backup_Before") = "1" Then
            Option_BackupBefore = 1
            Options_BackupBefore.Checked = True
            Menu_Options_Other_Backup.Checked = True
            Options_BackupBefore.Refresh()
        End If
        If ReadIni(ConfigPath, "Other", "Restore_After") = "1" Then
            Option_RestoreAfter = 1
            Options_RestoreAfter.Checked = True
            Menu_Options_Other_Restore.Checked = True
            Options_RestoreAfter.Refresh()
        End If
        If ReadIni(ConfigPath, "Other", "Compress_Backup") = "1" Then
            Option_BackupCompress = 1
            Options_BackupCompression.Checked = True
            Menu_Options_BackupCompression.Checked = True
            Options_150kernel.Refresh()
        End If
        If ReadIni(ConfigPath, "Other", "1.50_Addons") = "1" Then
            Option_150Kernel = 1
            Options_150kernel.Checked = True
            Menu_Options_Other_150Addon.Checked = True
            Options_150kernel.Refresh()
        End If
        If ReadIni(ConfigPath, "Other", "Support_Pandora") = "1" Then
            Option_SupportPandora = 1
            Options_SupportPandora.Checked = True
            Menu_Options_Other_Pandora.Checked = True
            SupportGroup_Pandora.Enabled = True
            Options_SupportPandora.Refresh()
        End If
        If ReadIni(ConfigPath, "Other", "Support_XMB") = "1" Then
            Option_SupportXMB = 1
            Options_SupportXMB.Checked = True
            Menu_Options_Other_XMB.Checked = True
            SupportGroup_XMB.Enabled = True
            Options_SupportXMB.Refresh()
        End If
        If ReadIni(ConfigPath, "Other", "POPSLoader") = "1" Then
            Option_POPSLoader = 1
            Options_Popsloader.Checked = True
            Menu_Options_Other_POPSLoader.Checked = True
            Options_Popsloader.Refresh()
        End If
        ' Apply Configuration
        ' [SupportPandora] Section
        If ReadIni(ConfigPath, "SupportPandora", "KeyCleaner") = "1" Then
            Option_Pandora_KeyCleaner = 1
            Pandora_KeyCleaner.Checked = True
            Pandora_KeyCleaner.Refresh()
        End If
        If ReadIni(ConfigPath, "SupportPandora", "Nandtool") = "1" Then
            Option_Pandora_Nandtool = 1
            Pandora_Nandtool.Checked = True
            Pandora_Nandtool.Refresh()
        End If
        If ReadIni(ConfigPath, "SupportPandora", "RFlash") = "1" Then
            Option_Pandora_RFlash = 1
            Pandora_RFlash.Checked = True
            Pandora_RFlash.Refresh()
        End If
        ' Apply Configuration
        ' [SupportXMB] Section
        If ReadIni(ConfigPath, "SupportXMB", "All") = "1" Then
            XMBAll()
        End If
        If ReadIni(ConfigPath, "SupportXMB", "5.00M33-6") = "1" Then
            Option_XMB_500m33 = 1
            XMB_500m33.Checked = True
            XMB_500m33.Refresh()
        End If
        If ReadIni(ConfigPath, "SupportXMB", "CFE") = "1" Then
            Option_XMB_CFE = 1
            XMB_CFE.Checked = True
            XMB_CFE.Refresh()
        End If
        If ReadIni(ConfigPath, "SupportXMB", "CFWFolderBlocker") = "1" Then
            Option_XMB_CFWFolderBlocker = 1
            XMB_CFWFolderBlocker.Checked = True
            XMB_CFWFolderBlocker.Refresh()
        End If
        If ReadIni(ConfigPath, "SupportXMB", "CPUModulator") = "1" Then
            Option_XMB_CPUModulator = 1
            XMB_CPUModulator.Checked = True
            XMB_CPUModulator.Refresh()
        End If
        If ReadIni(ConfigPath, "SupportXMB", "CWCheat") = "1" Then
            Option_XMB_CWCheat = 1
            XMB_CWCheat.Checked = True
            XMB_CWCheat.Refresh()
        End If
        If ReadIni(ConfigPath, "SupportXMB", "CXMB") = "1" Then
            Option_XMB_CXMB = 1
            XMB_CXMB.Checked = True
            XMB_CXMB.Refresh()
        End If
        If ReadIni(ConfigPath, "SupportXMB", "FusaSCR") = "1" Then
            Option_XMB_FusaSCR = 1
            XMB_FusaScr.Checked = True
            XMB_FusaScr.Refresh()
        End If
        If ReadIni(ConfigPath, "SupportXMB", "FusaSD") = "1" Then
            Option_XMB_FusaSD = 1
            XMB_FusaSD.Checked = True
            XMB_FusaSD.Refresh()
        End If
        If ReadIni(ConfigPath, "SupportXMB", "Hold") = "1" Then
            Option_XMB_Hold = 1
            XMB_Hold.Checked = True
            XMB_Hold.Refresh()
        End If
        If ReadIni(ConfigPath, "SupportXMB", "Joysens") = "1" Then
            Option_XMB_Joysens = 1
            XMB_Joysens.Checked = True
            XMB_Joysens.Refresh()
        End If
        If ReadIni(ConfigPath, "SupportXMB", "KeyCleaner") = "1" Then
            Option_XMB_KeyCleaner = 1
            XMB_KeyCleaner.Checked = True
            XMB_KeyCleaner.Refresh()
        End If
        If ReadIni(ConfigPath, "SupportXMB", "MemStickTool") = "1" Then
            Option_XMB_MemStickTool = 1
            XMB_MemStickTool.Checked = True
            XMB_MemStickTool.Refresh()
        End If
        If ReadIni(ConfigPath, "SupportXMB", "Nandtool") = "1" Then
            Option_XMB_NandTool = 1
            XMB_Nandtool.Checked = True
            XMB_Nandtool.Refresh()
        End If
        If ReadIni(ConfigPath, "SupportXMB", "NetConfBackup") = "1" Then
            Option_XMB_NetConfBackup = 1
            XMB_NetConfBackup.Checked = True
            XMB_NetConfBackup.Refresh()
        End If
        If ReadIni(ConfigPath, "SupportXMB", "PSARDumper") = "1" Then
            Option_XMB_RSPSARDumper = 1
            XMB_RSPSARDumper.Checked = True
            XMB_RSPSARDumper.Refresh()
        End If
        If ReadIni(ConfigPath, "SupportXMB", "PSPFiler") = "1" Then
            Option_XMB_PSPFiler = 1
            XMB_PSPFiler.Checked = True
            XMB_PSPFiler.Refresh()
        End If
        If ReadIni(ConfigPath, "SupportXMB", "UMDrip") = "1" Then
            Option_XMB_UMDrip = 1
            XMB_UMDrip.Checked = True
            XMB_UMDrip.Refresh()
        End If
        If ReadIni(ConfigPath, "SupportXMB", "XGEN") = "1" Then
            Option_XMB_XGEN = 1
            XMB_XGEN.Checked = True
            XMB_XGEN.Refresh()
        End If
        RefreshScreen()
        CheckBoot()
        StatusLabel1.Text = "Ready..."
        RefreshScreen()
    End Sub
    'Save Config
    Private Sub SaveConfigSub()
        StatusLabel1.Text = "Saving Configuration File..."
        main.RefreshScreen()
        If IO.File.Exists(ConfigPath) Then
            IO.File.Delete(ConfigPath)
        End If
        Dim Ini_Writer As StreamWriter = New StreamWriter(ConfigPath)
        Ini_Writer.WriteLine("[Main]")
        Ini_Writer.WriteLine("Version=" + PPDVersion)
        Ini_Writer.WriteLine("PSPType=" + PSPType)
        Ini_Writer.WriteLine("Format=" + Option_Format)
        Ini_Writer.WriteLine("MSPFormat=" + DoMSPFormat)
        Ini_Writer.WriteLine("IPL=" + InjectIPL)
        Ini_Writer.WriteLine("")
        Ini_Writer.WriteLine("[Triggers]")
        Ini_Writer.WriteLine("Button1=" + ButtonConfig_Combo1.Text)
        Ini_Writer.WriteLine("Button2=" + ButtonConfig_Combo2.Text)
        Ini_Writer.WriteLine("Button3=" + ButtonConfig_Combo3.Text)
        Ini_Writer.WriteLine("Button4=" + ButtonConfig_Combo4.Text)
        Ini_Writer.WriteLine("Button5=" + ButtonConfig_Combo5.Text)
        Ini_Writer.WriteLine("")
        Ini_Writer.WriteLine("[Firmware]")
        Ini_Writer.WriteLine("Install_150=" + Option_150)
        Ini_Writer.WriteLine("Install_371=" + Option_371)
        Ini_Writer.WriteLine("Install_380=" + Option_380)
        Ini_Writer.WriteLine("Install_390=" + Option_390)
        Ini_Writer.WriteLine("Install_401=" + Option_401)
        Ini_Writer.WriteLine("Install_500=" + Option_500)
        Ini_Writer.WriteLine("Install_550=" + Option_550)
        Ini_Writer.WriteLine("")
        Ini_Writer.WriteLine("[Installers]")
        Ini_Writer.WriteLine("Noobz=" + Option_Noobz)
        Ini_Writer.WriteLine("DC3=" + Option_DC3)
        Ini_Writer.WriteLine("DC4=" + Option_DC4)
        Ini_Writer.WriteLine("DC5=" + Option_DC5)
        Ini_Writer.WriteLine("DC7=" + Option_DC7)
        Ini_Writer.WriteLine("DC8=" + Option_DC8)
        Ini_Writer.WriteLine("TM=" + Option_TM)
        Ini_Writer.WriteLine("XGEN=" + Option_XGEN)
        Ini_Writer.WriteLine("")
        Ini_Writer.WriteLine("[Other]")
        Ini_Writer.WriteLine("Backup_Before=" + Option_BackupBefore)
        Ini_Writer.WriteLine("Restore_After=" + Option_RestoreAfter)
        Ini_Writer.WriteLine("Compress_Backup=" + Option_BackupCompress)
        Ini_Writer.WriteLine("1.50_Addons=" + Option_150Kernel)
        Ini_Writer.WriteLine("Support_Pandora=" + Option_SupportPandora)
        Ini_Writer.WriteLine("Support_XMB=" + Option_SupportXMB)
        Ini_Writer.WriteLine("POPSLoader=" + Option_POPSLoader)
        Ini_Writer.WriteLine("")
        Ini_Writer.WriteLine("[SupportPandora]")
        Ini_Writer.WriteLine("KeyCleaner=" + Option_Pandora_KeyCleaner)
        Ini_Writer.WriteLine("Nandtool=" + Option_Pandora_Nandtool)
        Ini_Writer.WriteLine("RFlash=" + Option_Pandora_RFlash)
        Ini_Writer.WriteLine("")
        Ini_Writer.WriteLine("[SupportXMB]")
        Ini_Writer.WriteLine("All=" + Option_XMB_All)
        Ini_Writer.WriteLine("500m33-6=" + Option_XMB_500m33)
        Ini_Writer.WriteLine("CFE=" + Option_XMB_CFE)
        Ini_Writer.WriteLine("CFWFolderBlocker=" + Option_XMB_CFWFolderBlocker)
        Ini_Writer.WriteLine("CPUModulator=" + Option_XMB_CPUModulator)
        Ini_Writer.WriteLine("CWCheat=" + Option_XMB_CWCheat)
        Ini_Writer.WriteLine("CXMB=" + Option_XMB_CXMB)
        Ini_Writer.WriteLine("FusaSCR=" + Option_XMB_FusaSCR)
        Ini_Writer.WriteLine("FusaSD=" + Option_XMB_FusaSD)
        Ini_Writer.WriteLine("Hold=" + Option_XMB_Hold)
        Ini_Writer.WriteLine("Joysens=" + Option_XMB_Joysens)
        Ini_Writer.WriteLine("KeyCleaner=" + Option_XMB_KeyCleaner)
        Ini_Writer.WriteLine("MemStickTool=" + Option_XMB_MemStickTool)
        Ini_Writer.WriteLine("Nandtool=" + Option_XMB_NandTool)
        Ini_Writer.WriteLine("NetConfBackup=" + Option_XMB_NetConfBackup)
        Ini_Writer.WriteLine("PSARDumper=" + Option_XMB_RSPSARDumper)
        Ini_Writer.WriteLine("PSPFiler=" + Option_XMB_PSPFiler)
        Ini_Writer.WriteLine("UMDrip=" + Option_XMB_UMDrip)
        Ini_Writer.WriteLine("XGEN=" + Option_XMB_XGEN)
        Ini_Writer.Close()
        With SaveConfig
            .FilterIndex = 1
            .Filter = "INI Files (*.INI)|*.ini"
            .Title = "Choose a File Name for your Configuration"
            .OverwritePrompt = True
            .ShowDialog()
        End With
        Dim ConfigFileName As String = SaveConfig.FileName
        Try
            If IO.File.Exists(ConfigFileName) Then
                IO.File.Delete(ConfigFileName)
            End If
            IO.File.Copy(ConfigPath, ConfigFileName, True)
        Catch
            MessageBox.Show("Failed to save the Configuration File.", "Error during Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Check for Update
    Private Sub UpdateCheck()
        Dim UpdateRequest As WebRequest = WebRequest.Create(UpdateURL)
        Dim UpdateResponse As WebResponse = CType(UpdateRequest.GetResponse, HttpWebResponse)
        Dim UpdateReader As New StreamReader(UpdateResponse.GetResponseStream())
        Dim PPDLatestVersion = UpdateReader.ReadLine
        Dim UpdateText As String = "Your version of PSP Pandora Deluxe: v" + PPDVersion + "." + vbCrLf + "Latest version of PSP Pandora Deluxe: v" + PPDLatestVersion + "."
        Dim OldVersion As String = vbCrLf + vbCrLf + "You are running an older version. Please update."
        Dim CurrentVersion As String = vbCrLf + vbCrLf + "You are running the latest version."
        If PPDVersion <> PPDLatestVersion Then
            UpdateText = UpdateText + OldVersion
            If MessageBox.Show(UpdateText, "Update Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim DownloadRequest As WebRequest = WebRequest.Create(UpdateFileURL)
                Dim DownloadResponse As WebResponse = CType(DownloadRequest.GetResponse, HttpWebResponse)
                Dim DownloadReader As New StreamReader(DownloadResponse.GetResponseStream())
                Dim DownloadURL = DownloadReader.ReadLine
                System.Diagnostics.Process.Start(DownloadURL)
            End If
        Else
            UpdateText = UpdateText + CurrentVersion
            MessageBox.Show(UpdateText, "Update Check", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    'Refresh Screen
    Shared Sub RefreshScreen()
        main.StatusStrip1.Refresh()
        main.Refresh()
    End Sub
    'Enable / Disable Recovery Flasher
    Shared Sub RFlash()
        If Option_150 = 1 Or Option_371 = 1 Or Option_401 = 1 Or Option_500 = 1 Then
            main.Pandora_RFlash.Enabled = True
        Else
            main.Pandora_RFlash.Enabled = False
            main.Pandora_RFlash.Checked = False
            main.Option_Pandora_RFlash = 0
        End If
    End Sub
End Class
