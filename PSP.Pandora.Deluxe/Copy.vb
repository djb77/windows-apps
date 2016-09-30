Imports System.IO
Imports ComponentAce.Compression.Archiver
Imports ComponentAce.Compression.ZipForge

Public Class Copy
    Public Shared Path As String = main.Path
    Public Shared path1 As String = main.Path1
    Public Shared path2 As String = main.Path2
    Public Shared path3 As String = main.Path3
    Public Shared path4 As String = main.Path4
    Public Shared path5 As String = main.Path5
    Public Shared path6 As String = main.Path6
    Public Shared path7 As String = main.Path7
    Public Shared PSPPath As String = main.PSPPath
    Public Shared FormatPath As String = main.FormatPath
    Public Shared Option_150 As String = main.Option_150
    Public Shared Option_371 As String = main.Option_371
    Public Shared Option_380 As String = main.Option_380
    Public Shared Option_390 As String = main.Option_390
    Public Shared Option_401 As String = main.Option_401
    Public Shared Option_500 As String = main.Option_500
    Public Shared Option_550 As String = main.Option_550
    Public Shared Option_Format As String = main.Option_Format
    Public Shared Option_Noobz As String = main.Option_Noobz
    Public Shared Option_DC3 As String = main.Option_DC3
    Public Shared Option_DC4 As String = main.Option_DC4
    Public Shared Option_DC5 As String = main.Option_DC5
    Public Shared Option_DC7 As String = main.Option_DC7
    Public Shared Option_DC8 As String = main.Option_DC8
    Public Shared Option_TM As String = main.Option_TM
    Public Shared Option_XGEN As String = main.Option_XGEN
    Public Shared Option_BackupBefore As String = main.Option_BackupBefore
    Public Shared Option_RestoreAfter As String = main.Option_RestoreAfter
    Public Shared Option_150Kernel As String = main.Option_150Kernel
    Public Shared Option_371_150Kernel As String = main.Option_371_150Kernel
    Public Shared Option_380_150Kernel As String = main.Option_380_150Kernel
    Public Shared Option_390_150Kernel As String = main.Option_390_150Kernel
    Public Shared Option_401_150Kernel As String = main.Option_401_150Kernel
    Public Shared Option_500_150Kernel As String = main.Option_500_150Kernel
    Public Shared Option_SupportPandora As String = main.Option_SupportPandora
    Public Shared Option_SupportXMB As String = main.Option_SupportXMB
    Public Shared Option_POPSLoader As String = main.Option_POPSLoader
    Public Shared Option_BootButton1 As String = main.Option_BootButton1
    Public Shared Option_BootButton2 As String = main.Option_BootButton2
    Public Shared Option_BootButton3 As String = main.Option_BootButton3
    Public Shared Option_BootButton4 As String = main.Option_BootButton4
    Public Shared Option_BootButton5 As String = main.Option_BootButton5
    Public Shared ErrorMsg As String = 0
    Public Shared RootTM As String = 1
    Public Shared CopyFail As String = 0
    Public Shared ErrorMessage As String = "There has been an unexpected problem. Stopping installation."
    Friend Shared WithEvents Extract As New ZipForge


    Private Sub Copy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        main.Log.Text = "Starting Installation..." + vbCrLf
        main.Log.Text = main.Log.Text + "Software Version:  v" + main.PPDVersion + vbCrLf
        main.Log.Text = main.Log.Text + "Target Firmware:  "
        If main.PSPType = 0 Then
            main.Log.Text = main.Log.Text + "1.50 FW" + vbCrLf + vbCrLf
        Else
            main.Log.Text = main.Log.Text + "Custom FW" + vbCrLf + vbCrLf
        End If
        main.RefreshScreen()

        'Backup Before Installation
        '--------------------------
        If Option_BackupBefore = 1 Then
            main.StatusLabel1.Text = "Backing up the Memory Stick..."
            main.RefreshScreen()
            With SaveBackup2
                .FilterIndex = 1
                .Filter = "ZIP Files (*.ZIP)|*.zip"
                .Title = "Please locate the Backup File"
                .OverwritePrompt = True
                .FileName = " "
            End With
            If SaveBackup2.ShowDialog <> DialogResult.OK Then
                Copy.ErrorMsg = 1
                GoTo CopyEnd
            End If
            If ErrorMsg = 0 Then
                main.Log.Text = main.Log.Text + "Backing up the Memory Stick...  "
                main.RefreshScreen()
                If IO.File.Exists(SaveBackup2.FileName) Then
                    IO.File.Delete(SaveBackup2.FileName)
                End If
                Try
                    Extract.FileName = SaveBackup2.FileName
                    Extract.BaseDir = main.PSPPath
                    If main.Option_BackupCompress = 1 Then
                        Extract.CompressionMethod = CompressionMethod.PPMd
                        Extract.CompressionLevel = CompressionLevel.Max
                    Else
                        Extract.CompressionMethod = CompressionMethod.Deflate
                        Extract.CompressionLevel = CompressionLevel.Fastest
                    End If
                    Extract.OpenArchive(System.IO.FileMode.Create)
                    Extract.AddFiles("*.*")
                    Extract.DeleteFiles("*.ind")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf + vbCrLf
                    main.RefreshScreen()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    main.RefreshScreen()
                    MessageBox.Show("Backup did not get created properly.", "Backup Error")
                    If IO.File.Exists(SaveBackup2.FileName) Then
                        IO.File.Delete(SaveBackup2.FileName)
                    End If
                    Copy.ErrorMsg = 1
                    GoTo CopyEnd
                End Try
            End If
        End If

        ' main Copy Script
        CopyScript()
        If CopyFail = 1 Then GoTo CopyEnd

        'Restore Backup after installation
        If Option_RestoreAfter = 1 Then
            main.StatusLabel1.Text = "Restoring Backup to the Memory Stick..."
            main.RefreshScreen()
            With LoadBackup2
                .FilterIndex = 1
                .Filter = "ZIP Files (*.ZIP)|*.zip"
                .Title = "Please select a Name and Path for your Backup"
                .Multiselect = False
                .FileName = " "
            End With
            If LoadBackup2.ShowDialog <> DialogResult.OK Then
                Copy.ErrorMsg = 1
                GoTo CopyEnd
            End If
            If ErrorMsg = 0 Then
                main.Log.Text = main.Log.Text + "Restoring Backup...  "
                main.RefreshScreen()
                Try
                    Extract.FileName = LoadBackup2.FileName
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf + vbCrLf
                Catch
                    Copy.ErrorMsg = 1
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    GoTo CopyEnd
                End Try
            End If
        End If
        'End
CopyEnd:
        If Copy.CopyFail = 0 Then
            MessageBox.Show("Installation was completed successfully.", "Installation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            main.StatusLabel1.Text = "Error..."
            main.RefreshScreen()
            MessageBox.Show(Copy.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Try
            If IO.File.Exists(main.Path + "\log.txt") Then
                IO.File.Delete(main.Path + "\log.txt")
            End If
            Dim logwriter As StreamWriter = New StreamWriter(main.Path + "\log.txt")
            logwriter.WriteLine(main.Log.Text)
            logwriter.Close()
        Catch
        End Try

        Copy.ErrorMsg = 0
        main.StatusLabel1.Text = "Ready..."
        main.RefreshScreen()
    End Sub

    Public Shared Sub CopyScript()
        Dim FileName As String

        ' Format + Prepare PSP
        '----------------------
        If Option_Format = 1 Then
            Dim PSPVolumeName As String = "PPD_v" + main.PPDVersion
            main.StatusLabel1.Text = "Formatting the Memory Stick..."
            main.Log.Text = main.Log.Text + "Formatting the Memory Stick...  "
            main.RefreshScreen()
            Dim writer2 As StreamWriter = New StreamWriter(main.Path + "\formatpsp.cmd")
            writer2.WriteLine("@echo off")
            If main.DoMSPFormat = 1 Then
                writer2.WriteLine(String.Concat(New String() {"echo y|""", main.Path + "\Files\mspformat.exe"" ", FormatPath}))
                GoTo closewriter
            End If
            If main.WindowsOS = "98" Then
                writer2.WriteLine(String.Concat(New String() {"echo y|""", "format.exe"" ", FormatPath + ":", "/V:" + PSPVolumeName}))
            End If
            If main.WindowsOS = "98SE" Then
                writer2.WriteLine(String.Concat(New String() {"echo y|""", "format.exe"" ", FormatPath + ":", "/V:" + PSPVolumeName}))
            End If
            If main.WindowsOS = "2000" Then
                writer2.WriteLine(String.Concat(New String() {"echo y|""", "format.exe"" ", FormatPath + ":", "/FS:FAT32 ", "/V:" + PSPVolumeName, "/X"}))
            End If
            If main.WindowsOS = "ME" Then
                writer2.WriteLine(String.Concat(New String() {"echo y|""", "format.exe"" ", FormatPath + ":", "/V:" + PSPVolumeName}))
            End If
            If main.WindowsOS = "XP" Then
                writer2.WriteLine(String.Concat(New String() {"echo y|""", "format.exe"" ", FormatPath + ":", "/FS:FAT32 ", "/V:" + PSPVolumeName, "/X"}))
            End If
            If main.WindowsOS = "2003" Then
                writer2.WriteLine(String.Concat(New String() {"echo y|""", "format.exe"" ", FormatPath + ":", "/FS:FAT32 ", "/V:" + PSPVolumeName, "/X"}))
            End If
            If main.WindowsOS = "Vista" Then
                writer2.WriteLine(String.Concat(New String() {"echo y|""", "format.exe"" ", FormatPath + ":", "/FS:FAT32 ", "/V:" + PSPVolumeName, "/X"}))
            End If
CloseWriter:
            writer2.Close()
            Try
                Dim process2 As New Process
                process2.StartInfo.FileName = main.Path + "\formatpsp.cmd"
                process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                process2.StartInfo.CreateNoWindow = True
                process2.Start()
                process2.WaitForExit()
                process2.Close()
                System.IO.File.Delete(main.Path + "\formatpsp.cmd")
                If main.DoMSPFormat = 1 Then
                    main.StatusLabel1.Text = "Formatting the Memory Stick... Remove and Restart USB..."
                    main.RefreshScreen()
                    MessageBox.Show("You now must disconnect your USB from the PSP, and remove the Memory Stick." & vbCrLf & "Leave the Memory Stick out of the PSP for about 5 seconds, re-insert it, and re-enable the USB connection.")
                    main.Drive_ComboBox.Items.Clear()
                    For Each drive As String In Directory.GetLogicalDrives()
                        Dim a As New System.IO.DriveInfo(drive)
                        If a.DriveType = IO.DriveType.Removable Then
                            If drive = "A:\" Then
                                GoTo DriveJump
                            End If
                            If MessageBox.Show("Is " + drive + " Drive your PSP?", "PSP Detection", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                main.Drive_ComboBox.Items.Add(drive)
                                main.Drive_ComboBox.SelectedIndex = 0
                            End If
DriveJump:
                        End If
                    Next drive
                    main.PSPPath = main.Drive_ComboBox.Text
                    main.FormatPath = main.PSPPath.Remove(1, 2)
                    Copy.PSPPath = main.PSPPath
                    Copy.FormatPath = main.FormatPath
                End If
                main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
            Catch
                main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                ErrorMsg = 1
                GoTo EndOfFile
            End Try
            main.StatusLabel1.Text = "Ready..."
            main.RefreshScreen()
        End If

        ' Install the IPL Loader
        '------------------------
        ErrorMsg = 0
        If main.Check_IPL.Checked = True Then
            main.StatusLabel1.Text = "Installing the IPL to the Memory Stick..."
            main.Log.Text = main.Log.Text + "Installing the IPL...  "
            main.RefreshScreen()
            FileName = Path + "\Files\Other\ipl.ppd"
            Try
                Extract.FileName = FileName
                Extract.Password = main.Password
                Extract.OpenArchive(System.IO.FileMode.Open)
                Extract.BaseDir = main.PSPPath
                Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                Extract.ExtractFiles("*.*")
                Extract.CloseArchive()
            Catch ex As Exception
                ErrorMsg = 1
                main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                MessageBox.Show("Problem with ipl.ppd")
                GoTo EndOfFile
            End Try
            Try
                Dim writer2 As StreamWriter = New StreamWriter(main.Path + "\copyipl.cmd")
                writer2.WriteLine("@echo off")
                writer2.WriteLine(String.Concat(New String() {"echo y|""", Path + "\Files\", "msinst.exe"" ", FormatPath, " ", FormatPath, ":\msipl.bin"}))
                writer2.Close()
                Dim process2 As New Process
                process2.StartInfo.FileName = main.Path + "\copyipl.cmd"
                process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                process2.StartInfo.CreateNoWindow = True
                process2.Start()
                process2.WaitForExit()
                process2.Close()
                System.IO.File.Delete(PSPPath + "msipl.bin")
                System.IO.File.Delete(main.Path + "\copyipl.cmd")
                main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
            Catch
                main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                MessageBox.Show("Error injectng the IPL.")
                ErrorMsg = 1
                GoTo EndOfFile
            End Try
        End If

        main.StatusLabel1.Text = "Creating Folders on the Memory Stick..."
        main.Log.Text = main.Log.Text + "Creating Folders on the Memory Stick...  "
        main.RefreshScreen()
        Try
            System.IO.Directory.CreateDirectory(PSPPath + "ISO\VIDEO")
            System.IO.Directory.CreateDirectory(PSPPath + "MP_ROOT\100MNV01")
            System.IO.Directory.CreateDirectory(PSPPath + "MP_ROOT\100ANV01")
            System.IO.Directory.CreateDirectory(PSPPath + "MUSIC")
            System.IO.Directory.CreateDirectory(PSPPath + "PICTURE")
            System.IO.Directory.CreateDirectory(PSPPath + "PSP\COMMON")
            System.IO.Directory.CreateDirectory(PSPPath + "PSP\GAME\UPDATE")
            System.IO.Directory.CreateDirectory(PSPPath + "PSP\GAME150")
            If main.Option_DC3 = 1 Then
                System.IO.Directory.CreateDirectory(PSPPath + "PSP\GAME371")
            End If
            If main.Option_DC4 = 1 Then
                System.IO.Directory.CreateDirectory(PSPPath + "PSP\GAME380")
            End If
            If main.Option_DC7 = 1 Then
                System.IO.Directory.CreateDirectory(PSPPath + "PSP\GAME4XX")
            End If
            If main.Option_XGEN = 1 Or main.Option_XMB_XGEN = 1 Or main.Option_Pandora_RFlash = 1 Then
                System.IO.Directory.CreateDirectory(PSPPath + "PSP\GAME5XX")
            End If
            System.IO.Directory.CreateDirectory(PSPPath + "PSP\RSSCH\IMPORT")
            System.IO.Directory.CreateDirectory(PSPPath + "PSP\SAVEDATA")
            System.IO.Directory.CreateDirectory(PSPPath + "PSP\SYSTEM")
            System.IO.Directory.CreateDirectory(PSPPath + "PSP\THEME")
            System.IO.Directory.CreateDirectory(PSPPath + "TM")
            System.IO.Directory.CreateDirectory(PSPPath + "SEPLUGINS")
            System.IO.Directory.CreateDirectory(PSPPath + "VIDEO")
            main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
            main.RefreshScreen()
        Catch
            main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
            Copy.ErrorMsg = 1
            MessageBox.Show("Problem creating new Folders on the Memory Stick.")
            GoTo EndFormat
        End Try
EndFormat:
        If Copy.ErrorMsg = 1 Then
            GoTo EndOfFile
        Else
        End If

        ' Copy Root Files
        '-----------------
        main.StatusLabel1.Text = "Copying Root Files to the Memory Stick..."
        main.Log.Text = main.Log.Text + "Copying Root Files...  "
        main.RefreshScreen()
        If Option_DC3 = 1 Or Option_DC4 = 1 Or Option_SupportPandora = 1 Then
            RootTM = 0
        End If
        If RootTM = 1 Then
            FileName = Path + "\Files\Other\roottm.ppd"
            Try
                Extract.FileName = FileName
                Extract.Password = main.Password
                Extract.OpenArchive(System.IO.FileMode.Open)
                Extract.BaseDir = main.PSPPath
                Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                Extract.ExtractFiles("*.*")
                Extract.CloseArchive()
            Catch ex As Exception
                MessageBox.Show("Problem with roottm.ppd")
                Copy.ErrorMsg = 1
                GoTo EndOfFile
            End Try
        Else
            FileName = Path + "\Files\Other\root.ppd"
            Try
                Extract.FileName = FileName
                Extract.Password = main.Password
                Extract.OpenArchive(System.IO.FileMode.Open)
                Extract.BaseDir = main.PSPPath
                Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                Extract.ExtractFiles("*.*")
                Extract.CloseArchive()
            Catch ex As Exception
                MessageBox.Show("Problem with root.ppd")
                Copy.ErrorMsg = 1
                GoTo EndOfFile
            End Try
        End If
        If main.PSPType = 1 Then
            FileName = Path + "\Files\Other\hellcat.ppd"
            Try
                Extract.FileName = FileName
                Extract.Password = main.Password
                Extract.OpenArchive(System.IO.FileMode.Open)
                Extract.BaseDir = main.PSPPath
                Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                Extract.ExtractFiles("*.*")
                Extract.CloseArchive()
            Catch ex As Exception
                MessageBox.Show("Problem with hellcat.ppd")
                Copy.ErrorMsg = 1
                GoTo EndOfFile
            End Try
        Else
            FileName = Path + "\Files\Other\cdbattery.ppd"
            Try
                Extract.FileName = FileName
                Extract.Password = main.Password
                Extract.OpenArchive(System.IO.FileMode.Open)
                Extract.BaseDir = main.PSPPath
                Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                Extract.ExtractFiles("*.*")
                Extract.CloseArchive()
            Catch ex As Exception
                MessageBox.Show("Problem with cdbattery.ppd")
                Copy.ErrorMsg = 1
                GoTo EndOfFile
            End Try
        End If
        If ErrorMsg = 0 Then
            main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf + vbCrLf
            main.RefreshScreen()
        Else
            main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
            GoTo EndOfFile
        End If

        ' Copy Eboots
        '-------------
        If Option_150 = 1 Then
            main.StatusLabel1.Text = "Copying the 1.50 Eboot to the Memory Stick..."
            main.Log.Text = main.Log.Text + "Copying the 1.50 Eboot...  "
            main.RefreshScreen()
            If Option_Noobz = 1 Then
                Try
                    System.IO.File.Copy(path1, PSPPath + "UPDATE.PBP", True)
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem Copying the 1.50 EBOOT.PBP File")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
            If Option_150Kernel = 1 Then
                Try
                    System.IO.File.Copy(path1, PSPPath + "150.PBP", True)
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem Copying the 1.50 EBOOT.PBP File")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
        End If
        If ErrorMsg = 0 And (Option_Noobz = 1 Or Option_150Kernel = 1) Then
            main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
            main.RefreshScreen()
        End If
        If Option_371 = 1 Then
            main.StatusLabel1.Text = "Copying the 3.71 Eboot to the Memory Stick..."
            main.Log.Text = main.Log.Text + "Copying the 3.71 Eboot...  "
            main.RefreshScreen()
            Try
                System.IO.File.Copy(path2, PSPPath + "371.PBP", True)
                main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                main.RefreshScreen()
            Catch
                main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                MessageBox.Show("Problem Copying the 3.71 EBOOT.PBP File")
                Copy.ErrorMsg = 1
                GoTo EndOfFile
            End Try
        End If
        If Option_380 = 1 Then
            main.StatusLabel1.Text = "Copying the 3.80 Eboot to the Memory Stick..."
            main.Log.Text = main.Log.Text + "Copying the 3.80 Eboot...  "
            main.RefreshScreen()
            Try
                System.IO.File.Copy(path3, PSPPath + "380.PBP", True)
                main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                main.RefreshScreen()
            Catch
                main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                MessageBox.Show("Problem Copying the 3.80 EBOOT.PBP File")
                Copy.ErrorMsg = 1
                GoTo EndOfFile
            End Try
        End If
        If Option_390 = 1 Then
            main.StatusLabel1.Text = "Copying the 3.90 Eboot to the Memory Stick..."
            main.Log.Text = main.Log.Text + "Copying the 3.90 Eboot...  "
            main.RefreshScreen()
            Try
                System.IO.File.Copy(path4, PSPPath + "390.PBP", True)
                main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                main.RefreshScreen()
            Catch
                main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                MessageBox.Show("Problem Copying the 3.90 EBOOT.PBP File")
                Copy.ErrorMsg = 1
                GoTo EndOfFile
            End Try
        End If
        If Option_401 = 1 Then
            main.StatusLabel1.Text = "Copying the 4.01 Eboot to the Memory Stick..."
            main.Log.Text = main.Log.Text + "Copying the 4.01 Eboot...  "
            main.RefreshScreen()
            Try
                System.IO.File.Copy(path5, PSPPath + "401.PBP", True)
                main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                main.RefreshScreen()
            Catch
                main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                MessageBox.Show("Problem Copying the 4.01 EBOOT.PBP File")
                Copy.ErrorMsg = 1
                GoTo EndOfFile
            End Try
        End If
        If Option_500 = 1 Then
            main.StatusLabel1.Text = "Copying the 5.00 Eboot to the Memory Stick..."
            main.Log.Text = main.Log.Text + "Copying the 5.00 Eboot...  "
            main.RefreshScreen()
            Try
                System.IO.File.Copy(path6, PSPPath + "500.PBP", True)
                main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                main.RefreshScreen()
            Catch
                main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                MessageBox.Show("Problem Copying the 5.00 EBOOT.PBP File")
                Copy.ErrorMsg = 1
                GoTo EndOfFile
            End Try
        End If
        If Option_550 = 1 Then
            main.StatusLabel1.Text = "Copying the 5.50 Eboot to the Memory Stick..."
            main.Log.Text = main.Log.Text + "Copying the 5.50 Eboot...  "
            main.RefreshScreen()
            Try
                System.IO.File.Copy(path7, PSPPath + "550.PBP", True)
                main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                main.RefreshScreen()
            Catch
                main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                MessageBox.Show("Problem Copying the 5.50 EBOOT.PBP File")
                Copy.ErrorMsg = 1
                GoTo EndOfFile
            End Try
        End If
        If Option_Noobz = 1 Or Option_150Kernel = 1 Or Option_371 = 1 Or Option_380 = 1 Or Option_390 = 1 Or Option_401 = 1 Or Option_500 = 1 Then
            main.Log.Text = main.Log.Text + vbCrLf
        End If

        ' Copying Programs
        '------------------
        ' Noobz 1.50 Downgrader
        If Option_Noobz = 1 Then
            main.StatusLabel1.Text = "Copying Noobz 1.50 Downgrader to the Memory Stick..."
            main.Log.Text = main.Log.Text + "Copying Noobz 1.50 Downgrader...  "
            main.RefreshScreen()
            FileName = Path + "\Files\Installers\noobz.ppd"
            Try
                Extract.FileName = FileName
                Extract.Password = main.Password
                Extract.OpenArchive(System.IO.FileMode.Open)
                Extract.BaseDir = main.PSPPath
                Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                Extract.ExtractFiles("*.*")
                Extract.CloseArchive()
                main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                main.RefreshScreen()
            Catch
                main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                MessageBox.Show("Problem with noobz.ppd")
                Copy.ErrorMsg = 1
                GoTo EndOfFile
            End Try
        End If
        ' Despertar Cementerio 3
        If Option_DC3 = 1 Then
            main.StatusLabel1.Text = "Copying Despertar Cementerio 3 to the Memory Stick..."
            main.Log.Text = main.Log.Text + "Copying Despertar Cementerio 3...  "
            main.RefreshScreen()
            FileName = Path + "\Files\Installers\dc3.ppd"
            Try
                Extract.FileName = FileName
                Extract.Password = main.Password
                Extract.OpenArchive(System.IO.FileMode.Open)
                Extract.BaseDir = main.PSPPath
                Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                Extract.ExtractFiles("*.*")
                Extract.CloseArchive()
                main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                main.RefreshScreen()
            Catch
                main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                MessageBox.Show("Problem with dc3.ppd")
                Copy.ErrorMsg = 1
                GoTo EndOfFile
            End Try
        End If
        ' Despertar Cementerio 4
        If Option_DC4 = 1 Then
            main.StatusLabel1.Text = "Copying Despertar Cementerio 4 to the Memory Stick..."
            main.Log.Text = main.Log.Text + "Copying Despertar Cementerio 4...  "
            main.RefreshScreen()
            FileName = Path + "\Files\Installers\dc4.ppd"
            Try
                Extract.FileName = FileName
                Extract.Password = main.Password
                Extract.OpenArchive(System.IO.FileMode.Open)
                Extract.BaseDir = main.PSPPath
                Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                Extract.ExtractFiles("*.*")
                Extract.CloseArchive()
                main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                main.RefreshScreen()
            Catch
                main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                MessageBox.Show("Problem with dc4.ppd")
                Copy.ErrorMsg = 1
                GoTo EndOfFile
            End Try
        End If
        ' Despertar Cementerio 5
        If Option_DC5 = 1 Then
            main.StatusLabel1.Text = "Copying Despertar Cementerio 5 to the Memory Stick..."
            main.Log.Text = main.Log.Text + "Copying Despertar Cementerio 5...  "
            main.RefreshScreen()
            If RootTM = 0 Or main.Option_SupportPandora = 1 Then
                FileName = Path + "\Files\Installers\dc5elf.ppd"
                Try
                    Extract.FileName = FileName
                    Extract.Password = main.Password
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem with dc5elf.ppd")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
            FileName = Path + "\Files\Installers\dc5.ppd"
            Try
                Extract.FileName = FileName
                Extract.Password = main.Password
                Extract.OpenArchive(System.IO.FileMode.Open)
                Extract.BaseDir = main.PSPPath
                Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                Extract.ExtractFiles("*.*")
                Extract.CloseArchive()
            Catch
                main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                MessageBox.Show("Problem with dc5.ppd")
                Copy.ErrorMsg = 1
                GoTo EndOfFile
            End Try
        End If
        If Option_DC5 = 1 Then
            If ErrorMsg = 0 Then
                main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                main.RefreshScreen()
            End If
        End If
        ' Despertar Cementerio 7
        If Option_DC7 = 1 Then
            main.StatusLabel1.Text = "Copying Despertar Cementerio 7 to the Memory Stick..."
            main.Log.Text = main.Log.Text + "Copying Despertar Cementerio 7...  "
            main.RefreshScreen()
            FileName = Path + "\Files\Installers\dc7.ppd"
            Try
                Extract.FileName = FileName
                Extract.Password = main.Password
                Extract.OpenArchive(System.IO.FileMode.Open)
                Extract.BaseDir = main.PSPPath
                Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                Extract.ExtractFiles("*.*")
                Extract.CloseArchive()
                main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                main.RefreshScreen()
            Catch
                main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                MessageBox.Show("Problem with dc7.ppd")
                Copy.ErrorMsg = 1
                GoTo EndOfFile
            End Try
        End If
        ' Despertar Cementerio 8
        If Option_DC8 = 1 Then
            main.StatusLabel1.Text = "Copying Despertar Cementerio 8 to the Memory Stick..."
            main.Log.Text = main.Log.Text + "Copying Despertar Cementerio 8...  "
            main.RefreshScreen()
            FileName = Path + "\Files\Installers\dc8.ppd"
            Try
                Extract.FileName = FileName
                Extract.Password = main.Password
                Extract.OpenArchive(System.IO.FileMode.Open)
                Extract.BaseDir = main.PSPPath
                Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                Extract.ExtractFiles("*.*")
                Extract.CloseArchive()
                main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                main.RefreshScreen()
            Catch
                main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                MessageBox.Show("Problem with dc8.ppd")
                Copy.ErrorMsg = 1
                GoTo EndOfFile
            End Try
        End If
        ' Time Machine
        If Option_TM = 1 Then
            main.StatusLabel1.Text = "Copying Time Machine to the Memory Stick..."
            main.Log.Text = main.Log.Text + "Copying Time Machine...  "
            main.RefreshScreen()
            FileName = Path + "\Files\Installers\tm.ppd"
            Try
                Extract.FileName = FileName
                Extract.Password = main.Password
                Extract.OpenArchive(System.IO.FileMode.Open)
                Extract.BaseDir = main.PSPPath
                Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                Extract.ExtractFiles("*.*")
                Extract.CloseArchive()
                main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                main.RefreshScreen()
            Catch
                main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                MessageBox.Show("Problem with tm.ppd")
                Copy.ErrorMsg = 1
                GoTo EndOfFile
            End Try
        End If
        ' XGEN Installer
        If Option_XGEN = 1 Then
            main.StatusLabel1.Text = "Copying XGEN Pandora 5 to the Memory Stick..."
            main.Log.Text = main.Log.Text + "Copying XGEN Pandora 5...  "
            main.RefreshScreen()
            FileName = Path + "\Files\Installers\dc8.ppd"
            Try
                Extract.FileName = FileName
                Extract.Password = main.Password
                Extract.OpenArchive(System.IO.FileMode.Open)
                Extract.BaseDir = main.PSPPath
                Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                Extract.ExtractFiles("*.*")
                Extract.CloseArchive()
            Catch
                main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                MessageBox.Show("Problem with dc8.ppd")
                Copy.ErrorMsg = 1
                GoTo EndOfFile
            End Try
            FileName = Path + "\Files\Installers\xgen.ppd"
            Try
                Extract.FileName = FileName
                Extract.Password = main.Password
                Extract.OpenArchive(System.IO.FileMode.Open)
                Extract.BaseDir = main.PSPPath
                Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                Extract.ExtractFiles("*.*")
                Extract.CloseArchive()
                main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                main.RefreshScreen()
            Catch
                main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                MessageBox.Show("Problem with xgen.ppd")
                Copy.ErrorMsg = 1
                GoTo EndOfFile
            End Try
        End If
        If Option_Noobz = 1 Or Option_DC3 = 1 Or Option_DC4 = 1 Or Option_DC5 = 1 Or Option_DC7 = 1 Or Option_DC8 = 1 Then
            main.Log.Text = main.Log.Text + vbCrLf
        End If

        'M33 1.50 Kernel Installers
        If Option_150Kernel = 1 Then
            If Option_371_150Kernel = 1 Then
                main.StatusLabel1.Text = "Copying 3.71 M33 1.50 Kernel Addon Installer to the Memory Stick..."
                main.Log.Text = main.Log.Text + "Copying 3.71 M33 1.50 Kernel Addon Installer...  "
                main.RefreshScreen()
                FileName = Path + "\Files\150addons\371m33_150.ppd"
                Try
                    Extract.FileName = FileName
                    Extract.Password = main.Password
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                    main.RefreshScreen()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem with 371m33_150.ppd")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
            If Option_380_150Kernel = 1 Then
                main.StatusLabel1.Text = "Copying 3.80 M33 1.50 Kernel Addon Installer to the Memory Stick..."
                main.Log.Text = main.Log.Text + "Copying 3.80 M33 1.50 Kernel Addon Installer...  "
                main.RefreshScreen()
                FileName = Path + "\Files\150addons\380m33_150.ppd"
                Try
                    Extract.FileName = FileName
                    Extract.Password = main.Password
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                    main.RefreshScreen()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem with 380m33_150.ppd")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
            If Option_390_150Kernel = 1 Then
                main.StatusLabel1.Text = "Copying 3.90 M33 1.50 Kernel Addon Installer to the Memory Stick..."
                main.Log.Text = main.Log.Text + "Copying 3.90 M33 1.50 Kernel Addon Installer...  "
                main.RefreshScreen()
                FileName = Path + "\Files\150addons\390m33_150.ppd"
                Try
                    Extract.FileName = FileName
                    Extract.Password = main.Password
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                    main.RefreshScreen()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem with 390m33_150.ppd")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
            If Option_401_150Kernel = 1 Then
                main.StatusLabel1.Text = "Copying 4.01 M33 1.50 Kernel Addon Installer to the Memory Stick..."
                main.Log.Text = main.Log.Text + "Copying 4.01 M33 1.50 Kernel Addon Installer...  "
                main.RefreshScreen()
                FileName = Path + "\Files\150addons\401m33_150.ppd"
                Try
                    Extract.FileName = FileName
                    Extract.Password = main.Password
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                    main.RefreshScreen()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem with 401m33_150.ppd")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
            If Option_500_150Kernel = 1 Then
                main.StatusLabel1.Text = "Copying 5.00 M33 1.50 Kernel Addon Installer to the Memory Stick..."
                main.Log.Text = main.Log.Text + "Copying 5.00 M33 1.50 Kernel Addon Installer...  "
                main.RefreshScreen()
                FileName = Path + "\Files\150addons\500m33_150.ppd"
                Try
                    Extract.FileName = FileName
                    Extract.Password = main.Password
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                    main.RefreshScreen()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem with 500m33_150.ppd")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
        End If
        If Option_371_150Kernel = 1 Or Option_380_150Kernel = 1 Or Option_390_150Kernel = 1 Or Option_401_150Kernel = 1 Or Option_500_150Kernel = 1 Then
            main.Log.Text = main.Log.Text + vbCrLf
        End If

        'POPSLoader
        If Option_POPSLoader = 1 Then
            main.StatusLabel1.Text = "Copying POPSLoader to the Memory Stick..."
            main.Log.Text = main.Log.Text + "Copying POPSLoader...  "
            main.RefreshScreen()
            FileName = Path + "\Files\other\popsloader.ppd"
            Try
                Extract.FileName = FileName
                Extract.Password = main.Password
                Extract.OpenArchive(System.IO.FileMode.Open)
                Extract.BaseDir = main.PSPPath
                Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                Extract.ExtractFiles("*.*")
                Extract.CloseArchive()
                main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf + vbCrLf
                main.RefreshScreen()
            Catch
                main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                MessageBox.Show("Problem with popsloader.ppd")
                Copy.ErrorMsg = 1
                GoTo EndOfFile
            End Try
        End If

        'Support Tools for Pandora
        Dim Support As String = 0
        If Option_SupportPandora = 1 Then
            'Support Tools - Nandtool
            If main.Pandora_Nandtool.Checked = True Then
                Support = 1
                main.StatusLabel1.Text = "Copying (Pandora Support) nandTool to the Memory Stick..."
                main.Log.Text = main.Log.Text + "Copying Nandtool (Pandora)...  "
                main.RefreshScreen()
                FileName = Path + "\Files\Pandora\nandtool.ppd"
                Try
                    Extract.FileName = FileName
                    Extract.Password = main.Password
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                    main.RefreshScreen()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem with nandtool.ppd")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
            'Support Tools - KeyCleaner
            If main.Pandora_KeyCleaner.Checked = True Then
                Support = 1
                main.StatusLabel1.Text = "Copying (Pandora Support) KeyCleaner to the Memory Stick..."
                main.Log.Text = main.Log.Text + "Copying KeyCleaner (Pandora)...  "
                main.RefreshScreen()
                FileName = Path + "\Files\Pandora\keycleaner.ppd"
                Try
                    Extract.FileName = FileName
                    Extract.Password = main.Password
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                    main.RefreshScreen()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem with keycleaner.ppd")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
            'Support Tools - Recovery Flasher
            If main.Pandora_RFlash.Checked = True Then
                Support = 1
                main.StatusLabel1.Text = "Copying (Pandora Support) Recovery Flasher to the Memory Stick..."
                main.Log.Text = main.Log.Text + "Copying Recovery Flasher (Pandora)...  "
                main.RefreshScreen()
                FileName = Path + "\Files\Pandora\rflash.ppd"
                Try
                    Extract.FileName = FileName
                    Extract.Password = main.Password
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                    main.RefreshScreen()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem with rflash.ppd")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
        End If

        'Support Tools for XMB
        If Option_SupportXMB = 1 Then
            ' XMB Tools - 5.00 M33-6 CFW Installer
            If main.XMB_500m33.Checked = True Then
                Support = 1
                main.StatusLabel1.Text = "Copying 5.00 M33-6 CFW Installer to the Memory Stick..."
                main.Log.Text = main.Log.Text + "Copying 5.00 M33-6 CFW Installer...  "
                main.RefreshScreen()
                FileName = Path + "\Files\XMB\500m33.ppd"
                Try
                    Extract.FileName = FileName
                    Extract.Password = main.Password
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                    main.RefreshScreen()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem with 500m33.ppd")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
            ' XMB Tools - CFW Folder Blocker
            If main.XMB_CFWFolderBlocker.Checked = True Then
                Support = 1
                main.StatusLabel1.Text = "Copying (XMB Support) CFW Folder Blocker to the Memory Stick..."
                main.Log.Text = main.Log.Text + "Copying CFW Folder Blocker (XMB)...  "
                main.RefreshScreen()
                FileName = Path + "\Files\XMB\cfwfb.ppd"
                Try
                    Extract.FileName = FileName
                    Extract.Password = main.Password
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                    main.RefreshScreen()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem with cfwfb.ppd")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
            ' XMB Tools - CPU-Modulator
            If main.XMB_CPUModulator.Checked = True Then
                Support = 1
                main.StatusLabel1.Text = "Copying (XMB Support) CPU-Modulator to the Memory Stick..."
                main.Log.Text = main.Log.Text + "Copying CPU-Modulator (XMB)...  "
                main.RefreshScreen()
                FileName = Path + "\Files\XMB\cpumodulator.ppd"
                Try
                    Extract.FileName = FileName
                    Extract.Password = main.Password
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                    main.RefreshScreen()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem with cpumodulator.ppd")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
            ' XMB Tools - Custom Firmware Extender
            If main.XMB_CFE.Checked = True Then
                Support = 1
                main.StatusLabel1.Text = "Copying (XMB Support) Custom Firmware Extender to the Memory Stick..."
                main.Log.Text = main.Log.Text + "Copying Custom Firmware Extender (XMB)...  "
                main.RefreshScreen()
                If Option_TM = 1 Then
                    FileName = Path + "\Files\XMB\cfe-tm.ppd"
                    Try
                        Extract.FileName = FileName
                        Extract.Password = main.Password
                        Extract.OpenArchive(System.IO.FileMode.Open)
                        Extract.BaseDir = main.PSPPath
                        Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                        Extract.ExtractFiles("*.*")
                        Extract.CloseArchive()
                        main.RefreshScreen()
                    Catch
                        main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                        MessageBox.Show("Problem with cfe-tm.ppd")
                        Copy.ErrorMsg = 1
                        GoTo EndOfFile
                    End Try
                End If
                FileName = Path + "\Files\XMB\cfe.ppd"
                Try
                    Extract.FileName = FileName
                    Extract.Password = main.Password
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                    main.RefreshScreen()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem with cfe.ppd")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
            ' XMB Tools - CW Cheat
            If main.XMB_CWCheat.Checked = True Then
                Support = 1
                main.StatusLabel1.Text = "Copying (XMB Support) CW Cheat to the Memory Stick..."
                main.Log.Text = main.Log.Text + "Copying CW Cheat (XMB)...  "
                main.RefreshScreen()
                FileName = Path + "\Files\XMB\cwcheat.ppd"
                Try
                    Extract.FileName = FileName
                    Extract.Password = main.Password
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                    main.RefreshScreen()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem with cwcheat.ppd")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
            ' XMB Tools - CXMB
            If main.XMB_CXMB.Checked = True Then
                Support = 1
                main.StatusLabel1.Text = "Copying (XMB Support) CXMB to the Memory Stick..."
                main.Log.Text = main.Log.Text + "Copying CXMB (XMB)...  "
                main.RefreshScreen()
                FileName = Path + "\Files\XMB\cxmb.ppd"
                Try
                    Extract.FileName = FileName
                    Extract.Password = main.Password
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                    main.RefreshScreen()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem with cxmb.ppd")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
            ' XMB Tools - Fusa Screenshoot
            If main.XMB_FusaScr.Checked = True Then
                Support = 1
                main.StatusLabel1.Text = "Copying (XMB Support) FuSa screenShoot to the Memory Stick..."
                main.Log.Text = main.Log.Text + "Copying FuSa screenShoot (XMB)...  "
                main.RefreshScreen()
                FileName = Path + "\Files\XMB\fusascr.ppd"
                Try
                    Extract.FileName = FileName
                    Extract.Password = main.Password
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                    main.RefreshScreen()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem with fusascr.ppd")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
            ' XMB Tools - Fusa SD
            If main.XMB_FusaSD.Checked = True Then
                Support = 1
                main.StatusLabel1.Text = "Copying (XMB Support) FuSa SD to the Memory Stick..."
                main.Log.Text = main.Log.Text + "Copying FuSa SD (XMB)...  "
                main.RefreshScreen()
                FileName = Path + "\Files\XMB\fusasd.ppd"
                Try
                    Extract.FileName = FileName
                    Extract.Password = main.Password
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                    main.RefreshScreen()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem with fusasd.ppd")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
            ' XMB Tools - Hold+
            If main.XMB_Hold.Checked = True Then
                Support = 1
                main.StatusLabel1.Text = "Copying (XMB Support) Hold+ to the Memory Stick..."
                main.Log.Text = main.Log.Text + "Copying Hold+ (XMB)...  "
                main.RefreshScreen()
                FileName = Path + "\Files\XMB\hold.ppd"
                Try
                    Extract.FileName = FileName
                    Extract.Password = main.Password
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                    main.RefreshScreen()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem with hold.ppd")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
            ' XMB Tools - Joysens
            If main.XMB_Joysens.Checked = True Then
                Support = 1
                main.StatusLabel1.Text = "Copying (XMB Support) JoySens to the Memory Stick..."
                main.Log.Text = main.Log.Text + "Copying JoySens (XMB)...  "
                main.RefreshScreen()
                FileName = Path + "\Files\XMB\joysens.ppd"
                Try
                    Extract.FileName = FileName
                    Extract.Password = main.Password
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                    main.RefreshScreen()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem with joysens.ppd")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
            ' XMB Tools - KeyCleaner
            If main.XMB_KeyCleaner.Checked = True Then
                Support = 1
                main.StatusLabel1.Text = "Copying (XMB Support) KeyCleaner to the Memory Stick..."
                main.Log.Text = main.Log.Text + "Copying KeyCleaner (XMB)...  "
                main.RefreshScreen()
                FileName = Path + "\Files\XMB\keycleaner.ppd"
                Try
                    Extract.FileName = FileName
                    Extract.Password = main.Password
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                    main.RefreshScreen()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem with keycleaner.ppd")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
            ' XMB Tools - MemoryStick-Tool
            If main.XMB_MemStickTool.Checked = True Then
                Support = 1
                main.StatusLabel1.Text = "Copying (XMB Support) MemoryStick-Tool to the Memory Stick..."
                main.Log.Text = main.Log.Text + "Copying MemoryStick-Tool (XMB)...  "
                main.RefreshScreen()
                FileName = Path + "\Files\XMB\memsticktool.ppd"
                Try
                    Extract.FileName = FileName
                    Extract.Password = main.Password
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                    main.RefreshScreen()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem with memsticktool.ppd")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
            ' XMB Tools - Nandtool
            If main.XMB_Nandtool.Checked = True Then
                Support = 1
                main.StatusLabel1.Text = "Copying (XMB Support) nandTool to the Memory Stick..."
                main.Log.Text = main.Log.Text + "Copying nandTool (XMB)...  "
                main.RefreshScreen()
                FileName = Path + "\Files\XMB\nandtool.ppd"
                Try
                    Extract.FileName = FileName
                    Extract.Password = main.Password
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                    main.RefreshScreen()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem with nandtool.ppd")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
            ' XMB Tools - NetConfBackup
            If main.XMB_NetConfBackup.Checked = True Then
                Support = 1
                main.StatusLabel1.Text = "Copying (XMB Support) NetConfBackup to the Memory Stick..."
                main.Log.Text = main.Log.Text + "Copying NetConfBackup (XMB)...  "
                main.RefreshScreen()
                FileName = Path + "\Files\XMB\netconfbackup.ppd"
                Try
                    Extract.FileName = FileName
                    Extract.Password = main.Password
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                    main.RefreshScreen()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem with netconfbackup.ppd")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
            ' XMB Tools - PSP Filer
            If main.XMB_PSPFiler.Checked = True Then
                Support = 1
                main.StatusLabel1.Text = "Copying (XMB Support) PSP Filer to the Memory Stick..."
                main.Log.Text = main.Log.Text + "Copying PSP Filer (XMB)...  "
                main.RefreshScreen()
                FileName = Path + "\Files\XMB\pspfiler.ppd"
                Try
                    Extract.FileName = FileName
                    Extract.Password = main.Password
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                    main.RefreshScreen()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem with pspfiler.ppd")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
            ' XMB Tools - PSARDumper
            If main.XMB_RSPSARDumper.Checked = True Then
                Support = 1
                main.StatusLabel1.Text = "Copying (XMB Support) PSARDumper to the Memory Stick..."
                main.Log.Text = main.Log.Text + "Copying PSARDumper (XMB)...  "
                main.RefreshScreen()
                FileName = Path + "\Files\XMB\psardumper.ppd"
                Try
                    Extract.FileName = FileName
                    Extract.Password = main.Password
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                    main.RefreshScreen()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem with rspsardumper.ppd")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
            ' XMB Tools - UMDrip
            If main.XMB_UMDrip.Checked = True Then
                Support = 1
                main.StatusLabel1.Text = "Copying (XMB Support) UMDrip to the Memory Stick..."
                main.Log.Text = main.Log.Text + "Copying UMDrip (XMB)...  "
                main.RefreshScreen()
                FileName = Path + "\Files\XMB\umdrip.ppd"
                Try
                    Extract.FileName = FileName
                    Extract.Password = main.Password
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                    main.RefreshScreen()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem with umdrip.ppd")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
            ' XMB Tools - XGEN Installer
            If main.XMB_XGEN.Checked = True Then
                Support = 1
                main.StatusLabel1.Text = "Copying (XMB Support) XGEN Installer to the Memory Stick..."
                main.Log.Text = main.Log.Text + "Copying XGEN Installer (XMB)...  "
                main.RefreshScreen()
                FileName = Path + "\Files\XMB\xgen.ppd"
                Try
                    Extract.FileName = FileName
                    Extract.Password = main.Password
                    Extract.OpenArchive(System.IO.FileMode.Open)
                    Extract.BaseDir = main.PSPPath
                    Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                    Extract.ExtractFiles("*.*")
                    Extract.CloseArchive()
                    main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
                    main.RefreshScreen()
                Catch
                    main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
                    MessageBox.Show("Problem with xgen.ppd")
                    Copy.ErrorMsg = 1
                    GoTo EndOfFile
                End Try
            End If
        End If
        If Support = 1 Then
            main.Log.Text = main.Log.Text + vbCrLf
        End If

        'Creating Config Files
        '---------------------
        'Create config.txt file
        main.StatusLabel1.Text = "Creating and Copying config.txt..."
        main.Log.Text = main.Log.Text + "Creating and Copying config.txt...  "
        main.RefreshScreen()
        Try
            Dim Config_creator As StreamWriter = New StreamWriter(main.Path + "\config.txt")
            If Option_TM = 1 Then
                Config_creator.WriteLine(Option_BootButton3 + " = ""/TM/150_340/ipl.bin"";")
            End If
            If Option_DC5 = 1 Then
                Config_creator.WriteLine(Option_BootButton4 + " = ""/TM/DC5/ipl.bin"";")
            End If
            If Option_DC7 = 1 Then
                Config_creator.WriteLine(Option_BootButton2 + " = ""/TM/DC7/ipl.bin"";")
            End If
            If Option_DC8 = 1 Then
                Config_creator.WriteLine(Option_BootButton5 + " = ""/TM/DC8/ipl.bin"";")
            End If
            If Option_XGEN = 1 Then
                Config_creator.WriteLine(Option_BootButton5 + " = ""/TM/DC8/ipl.bin"";")
            End If
            Dim pandora = 0
            If Option_Noobz = 1 Or Option_DC3 = 1 Or Option_DC4 = 1 Or Option_SupportPandora = 1 Then
                pandora = 1
            End If
            If pandora = 1 Then
                Config_creator.WriteLine(Option_BootButton1 + " = ""/TM/pandora.bin"";")
            End If
            pandora = 0
            Config_creator.WriteLine("NOTHING = ""NAND"";")
            Config_creator.Close()
            If System.IO.File.Exists(PSPPath + "\TM\config.txt") Then
                System.IO.File.Delete(PSPPath + "\TM\config.txt")
            End If
            System.IO.File.Copy(main.Path + "\config.txt", PSPPath + "\TM\config.txt", True)
            System.IO.File.Delete(main.Path + "\config.txt")
            main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
            main.RefreshScreen()
        Catch
            main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
            Copy.ErrorMsg = 1
            GoTo EndOfFile
        End Try

        'Creating vsh.txt File
        main.StatusLabel1.Text = "Creating and Copying vsh.txt..."
        main.Log.Text = main.Log.Text + "Creating and Copying vsh.txt...  "

        main.RefreshScreen()
        Dim vshtxt_code As StreamWriter = New StreamWriter(main.Path + "\vsh.txt")
        If main.XMB_CFE.Checked = True Then
            vshtxt_code.WriteLine("ms0:/SEPLUGINS/CFE/cfe_loader.prx")
        End If
        If main.XMB_CPUModulator.Checked = True Then
            vshtxt_code.WriteLine("ms0:/SEPLUGINS/cpumodulator.prx")
        End If
        If main.XMB_CXMB.Checked = True Then
            vshtxt_code.WriteLine("ms0:/CXMB/cxmb.prx")
        End If
        If main.XMB_FusaScr.Checked = True Then
            vshtxt_code.WriteLine("ms0:/SEPLUGINS/fusascr.prx")
        End If
        If main.XMB_FusaSD.Checked = True Then
            vshtxt_code.WriteLine("ms0:/SEPLUGINS/fusasd.prx")
        End If
        If main.XMB_Hold.Checked = True Then
            vshtxt_code.WriteLine("ms0:/SEPLUGINS/hold.prx")
        End If
        If main.XMB_Joysens.Checked = True Then
            vshtxt_code.WriteLine("ms0:/SEPLUGINS/joysens.prx")
        End If
        If main.XMB_XGEN.Checked = True Then
            vshtxt_code.WriteLine("ms0:/SEPLUGINS/usbversionfake.prx")
        End If
        vshtxt_code.Close()
        Try
            If System.IO.File.Exists(PSPPath + "\SEPLUGINS\vsh.txt") Then
                System.IO.File.Delete(PSPPath + "\SEPLUGINS\vsh.txt")
            End If
            System.IO.File.Copy(main.Path + "\vsh.txt", PSPPath + "\SEPLUGINS\vsh.txt", True)
            System.IO.File.Delete(main.Path + "\vsh.txt")
            main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
            main.RefreshScreen()
        Catch
            main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
            Copy.ErrorMsg = 1
            GoTo EndOfFile
        End Try

        'Creating game.txt File
        main.StatusLabel1.Text = "Creating and Copying game.txt..."
        main.Log.Text = main.Log.Text + "Creating and Copying game.txt...  "

        main.RefreshScreen()
        Dim gametxt_code As StreamWriter = New StreamWriter(main.Path + "\game.txt")
        If main.XMB_CFWFolderBlocker.Checked = True Then
            gametxt_code.WriteLine("ms0:/SEPLUGINS/cfwblock.prx")
        End If
        If main.XMB_CPUModulator.Checked = True Then
            gametxt_code.WriteLine("ms0:/SEPLUGINS/cpumodulator.prx")
        End If
        If main.XMB_CFE.Checked = True Then
            gametxt_code.WriteLine("ms0:/SEPLUGINS/CFE/cfe_loader.prx")
        End If
        If main.XMB_CWCheat.Checked = True Then
            gametxt_code.WriteLine("ms0:/SEPLUGINS/CWCheat/cwcheat.prx")
        End If
        If main.XMB_FusaScr.Checked = True Then
            gametxt_code.WriteLine("ms0:/SEPLUGINS/fusascr.prx")
        End If
        If main.XMB_FusaSD.Checked = True Then
            gametxt_code.WriteLine("ms0:/SEPLUGINS/fusasd.prx")
        End If
        If main.XMB_Hold.Checked = True Then
            gametxt_code.WriteLine("ms0:/SEPLUGINS/hold.prx")
        End If
        If main.XMB_Joysens.Checked = True Then
            gametxt_code.WriteLine("ms0:/SEPLUGINS/joysens.prx")
        End If
        gametxt_code.Close()
        Try
            If System.IO.File.Exists(PSPPath + "\SEPLUGINS\game.txt") Then
                System.IO.File.Delete(PSPPath + "\SEPLUGINS\game.txt")
            End If
            System.IO.File.Copy(main.Path + "\game.txt", PSPPath + "\SEPLUGINS\game.txt", True)
            System.IO.File.Delete(main.Path + "\game.txt")
            main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
            main.RefreshScreen()
        Catch
            main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
            Copy.ErrorMsg = 1
            GoTo EndOfFile
        End Try

        'Creating pops.txt File
        main.StatusLabel1.Text = "Creating and Copying pops.txt..."
        main.Log.Text = main.Log.Text + "Creating and Copying pops.txt...  "

        main.RefreshScreen()
        Dim popstxt_code As StreamWriter = New StreamWriter(main.Path + "\pops.txt")
        If Option_POPSLoader = 1 Then
            popstxt_code.WriteLine("ms0:/SEPLUGINS/popsloader.prx")
        End If
        If main.XMB_CPUModulator.Checked = True Then
            popstxt_code.WriteLine("ms0:/SEPLUGINS/cpumodulator.prx")
        End If
        If main.XMB_CWCheat.Checked = True Then
            popstxt_code.WriteLine("ms0:/SEPLUGINS/CWCheat/cwcheat.prx")
        End If
        If main.XMB_FusaScr.Checked = True Then
            popstxt_code.WriteLine("ms0:/SEPLUGINS/fusascr.prx")
        End If
        If main.XMB_FusaSD.Checked = True Then
            popstxt_code.WriteLine("ms0:/SEPLUGINS/fusasd.prx")
        End If
        If main.XMB_Joysens.Checked = True Then
            popstxt_code.WriteLine("ms0:/SEPLUGINS/joysens.prx")
        End If
        popstxt_code.Close()
        Try
            If System.IO.File.Exists(PSPPath + "\SEPLUGINS\pops.txt") Then
                System.IO.File.Delete(PSPPath + "\SEPLUGINS\pops.txt")
            End If
            System.IO.File.Copy(main.Path + "\pops.txt", PSPPath + "\SEPLUGINS\pops.txt", True)
            System.IO.File.Delete(main.Path + "\pops.txt")
            main.Log.Text = main.Log.Text + "SUCCESS" + vbCrLf
            main.RefreshScreen()
        Catch
            main.Log.Text = main.Log.Text + "FAILED" + vbCrLf + vbCrLf
            Copy.ErrorMsg = 1
            GoTo EndOfFile
        End Try
EndOfFile:
        If Copy.ErrorMsg = 1 Then
            Copy.CopyFail = 1
        Else
            Copy.CopyFail = 0
        End If
    End Sub

End Class


