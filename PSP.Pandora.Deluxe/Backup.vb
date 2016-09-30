Imports System.IO
Imports ComponentAce.Compression.ZipForge
Imports ComponentAce.Compression.Archiver

Public Class Backup
    Friend Shared WithEvents Extract As New ZipForge

    Private Sub Backup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim errormsg = 0
        With SaveBackup1
            .FilterIndex = 1
            .Filter = "ZIP Files (*.ZIP)|*.zip"
            .Title = "Please locate the Backup File"
            .OverwritePrompt = True
            .FileName = " "
        End With
        If SaveBackup1.ShowDialog <> DialogResult.OK Then
            errormsg = 1
        End If
        If errormsg = 0 Then
            main.StatusLabel1.Text = "Backing up the Memory Stick..."
            main.RefreshScreen()
            Try
                Extract.FileName = SaveBackup1.FileName
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
            Catch
                errormsg = 1
            End Try
        End If
        If errormsg = 0 Then
            main.StatusLabel1.Text = "Backing up the Memory Stick... Success..."
            main.RefreshScreen()
            MessageBox.Show("Backup successfully completed.", "Backup Complete")
        Else
            main.StatusLabel1.Text = "Backing up the Memory Stick... Error..."
            main.RefreshScreen()
            MessageBox.Show("The Backup did not get created properly.", "Backup Error")
            System.IO.Directory.Delete(SaveBackup1.FileName)
        End If
        main.StatusLabel1.Text = "Ready..."
        main.RefreshScreen()
    End Sub

End Class