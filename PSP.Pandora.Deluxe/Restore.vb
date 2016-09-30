Imports System.IO
Imports ComponentAce.Compression.ZipForge

Public Class Restore
    Friend WithEvents Extract As New ZipForge
    Private Sub Restore_Script_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim errormsg = 0
        If main.Option_RestoreFormat = 1 Then
            main.StatusLabel1.Text = "Foarmatting the Memory Stick..."
            main.Refresh()
            Dim PSPVolumeName As String = "PPD_v" + main.PPDVersion
            main.StatusLabel1.Text = "Formatting the Memory Stick..."
            main.RefreshScreen()
            Dim writer2 As StreamWriter = New StreamWriter(main.Path + "\formatpsp.cmd")
            writer2.WriteLine("@echo off")
            If main.DoMSPFormat = 1 Then
                writer2.WriteLine(String.Concat(New String() {"echo y|""", main.Path + "\Files\mspformat.exe"" ", main.FormatPath}))
                GoTo closewriter
            End If
            If main.WindowsOS = "98" Then
                writer2.WriteLine(String.Concat(New String() {"echo y|""", "format.exe"" ", main.FormatPath + ":", "/V:" + PSPVolumeName}))
            End If
            If main.WindowsOS = "98SE" Then
                writer2.WriteLine(String.Concat(New String() {"echo y|""", "format.exe"" ", main.FormatPath + ":", "/V:" + PSPVolumeName}))
            End If
            If main.WindowsOS = "2000" Then
                writer2.WriteLine(String.Concat(New String() {"echo y|""", "format.exe"" ", main.FormatPath + ":", "/FS:FAT32 ", "/V:" + PSPVolumeName, "/X"}))
            End If
            If main.WindowsOS = "ME" Then
                writer2.WriteLine(String.Concat(New String() {"echo y|""", "format.exe"" ", main.FormatPath + ":", "/V:" + PSPVolumeName}))
            End If
            If main.WindowsOS = "XP" Then
                writer2.WriteLine(String.Concat(New String() {"echo y|""", "format.exe"" ", main.FormatPath + ":", "/FS:FAT32 ", "/V:" + PSPVolumeName, "/X"}))
            End If
            If main.WindowsOS = "2003" Then
                writer2.WriteLine(String.Concat(New String() {"echo y|""", "format.exe"" ", main.FormatPath + ":", "/FS:FAT32 ", "/V:" + PSPVolumeName, "/X"}))
            End If
            If main.WindowsOS = "Vista" Then
                writer2.WriteLine(String.Concat(New String() {"echo y|""", "format.exe"" ", main.FormatPath + ":", "/FS:FAT32 ", "/V:" + PSPVolumeName, "/X"}))
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
                End If
            Catch
                errormsg = 1
                GoTo EndOfFile
            End Try
        End If

        If main.Check_IPL.Checked = True Then
            main.StatusLabel1.Text = "Installing the IPL to the Memory Stick..."
            Dim FileName = main.Path + "\Files\Other\ipl.ppd"
            Try
                Extract.FileName = FileName
                Extract.Password = main.Password
                Extract.OpenArchive(System.IO.FileMode.Open)
                Extract.BaseDir = main.PSPPath
                Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                Extract.ExtractFiles("*.*")
                Extract.CloseArchive()
            Catch ex As Exception
                MessageBox.Show("Problem with ipl.ppd")
                GoTo EndOfFile
            End Try
            Try
                Dim writer2 As StreamWriter = New StreamWriter(main.Path + "\copyipl.cmd")
                writer2.WriteLine("@echo off")
                writer2.WriteLine(String.Concat(New String() {"echo y|""", main.Path + "\Files\", "msinst.exe"" ", main.FormatPath, " ", main.FormatPath, ":\msipl.bin"}))
                writer2.Close()
                Dim process2 As New Process
                process2.StartInfo.FileName = main.Path + "\copyipl.cmd"
                process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                process2.StartInfo.CreateNoWindow = True
                process2.Start()
                process2.WaitForExit()
                process2.Close()
                System.IO.File.Delete(main.PSPPath + "msipl.bin")
                System.IO.File.Delete(main.Path + "\copyipl.cmd")
            Catch
                MessageBox.Show("Error injectng the IPL.")
                errormsg = 1
            End Try
        End If

        errormsg = 0
        With LoadBackup1
            .FilterIndex = 1
            .Filter = "ZIP Files (*.ZIP)|*.zip"
            .Title = "Please select a Name and Path for your Backup"
            .Multiselect = False
            .FileName = " "
        End With
        If LoadBackup1.ShowDialog <> DialogResult.OK Then
            errormsg = 1
        End If
        If errormsg = 0 Then
            main.StatusLabel1.Text = "Restoring Backup to the Memory Stick..."
            main.Refresh()
            Try
                Extract.FileName = LoadBackup1.FileName
                Extract.OpenArchive(System.IO.FileMode.Open)
                Extract.BaseDir = main.PSPPath
                Extract.Options.Overwrite = Archiver.OverwriteMode.Always
                Extract.ExtractFiles("*.*")
                Extract.CloseArchive()
            Catch
                errormsg = 1
            End Try
        End If
EndOfFile:
        If errormsg = 0 Then
            main.StatusLabel1.Text = "Restoring Backup to the Memory Stick... Success..."
            main.Refresh()
            MessageBox.Show("Restore successfully completed.", "Restore Complete")
        Else
            main.StatusLabel1.Text = "Restoring Backup to the Memory Stick... Error..."
            main.Refresh()
            MessageBox.Show("The Restore did not get created properly.", "Restore Error")
            errormsg = 0
        End If
        main.StatusLabel1.Text = "Ready..."
        main.Refresh()
    End Sub

End Class


