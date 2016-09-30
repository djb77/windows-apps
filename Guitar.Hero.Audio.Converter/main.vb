Imports System.IO
Public Class main
    Public Shared Folder1 As String = ""
    Public Shared SongName As String = ""
    Public Shared SongName1 As String = ""
    Public Shared Folder2 As String = ""
    Public Shared GHError As String = 0
    Public Shared SamePath As String = 0
    Public Shared Folders As String = 1
    Public Shared QM As String = ControlChars.Quote
    Public Shared Convert As New Process
    Public Shared Path As String = Application.StartupPath() + "\"
    Public Shared TempPath As String = IO.Path.GetTempPath() + "\GHAC\"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gh_bass.Checked = True
        gh_drums.Checked = True
        gh_guitar.Checked = True
        gh_vocals.Checked = True
        gh_folders.Checked = False
        gh_samepath.Checked = False
        IO.Directory.CreateDirectory(TempPath)
        SongName = ""
        Folder1 = ""
        Folder2 = ""
    End Sub

    'SELECT BIK FILE
    '---------------
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With BikFile
            .FilterIndex = 1
            .Filter = "BIK Audio Files (*.bik)|*.bik"
            .Title = "Please locate your .BIK File to Convert"
            .Multiselect = True
        End With
        If BikFile.ShowDialog <> DialogResult.OK Then
            GHError = 1
        End If
        If GHError = 0 Then
            TextBox1.Text = BikFile.FileName
            SongName = IO.Path.GetFileNameWithoutExtension(Folder1)
            Refresh()
            For Each File_Name As String In BikFile.FileNames
                GHList.Items.Add(File_Name)
            Next File_Name
        Else
            MessageBox.Show("Please try to load the BIK file again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'SELECT OUTPUT FOLDER
    '--------------------
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        With OutputFolder
            If OutputFolder.ShowDialog <> DialogResult.OK Then
                GHError = 1
            End If
            If GHError = 0 Then
                Folder2 = OutputFolder.SelectedPath
                TextBox2.Text = Folder2
                Refresh()
            Else
                MessageBox.Show("Please select a folder to save the files.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End With
    End Sub

    'EXTRACT FILES IN THE SAME FOLDER
    '--------------------------------
    Private Sub gh_samepath_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gh_samepath.CheckedChanged
        If gh_samepath.Checked = True Then
            Button2.Enabled = False
            TextBox2.Enabled = False
            SamePath = 1
        Else
            Button2.Enabled = True
            TextBox2.Enabled = True
            SamePath = 0
        End If
    End Sub

    'DO NOT CREATE FOLDERS
    '---------------------
    Private Sub gh_folders_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gh_folders.CheckedChanged
        If gh_folders.Checked = True Then
            Folders = 0
        Else
            Folders = 1
        End If
    End Sub

    'CLEAR LIST
    '-----------
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        GHList.Items.Clear()
    End Sub

    'START CONVERSION
    '----------------
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Enabled = False
        System.IO.File.WriteAllBytes(TempPath + "convert.exe", My.Resources.convert1)
        System.IO.File.WriteAllBytes(TempPath + "convert.dll", My.Resources.convert2)

        Dim Writer As StreamWriter = New StreamWriter(TempPath + "convert.cmd")
        Writer.WriteLine("@echo off")

        Dim GHAmount As String = GHList.Items.Count
        Dim i As Integer
        For i = 0 To GHAmount - 1
            GHList.SetSelected(i, True)
            Dim Folder1 As String = GHList.SelectedItems(i)
            Dim SongName As String = IO.Path.GetFileNameWithoutExtension(Folder1)

            If Folders = 1 And SamePath = 1 Then
                IO.Directory.CreateDirectory(Path + SongName)
            End If
            If Folders = 1 And SamePath = 0 Then
                IO.Directory.CreateDirectory(Folder2 + "\" + SongName)
            End If

            If Folders = 0 And SamePath = 0 Then
                If gh_drums.Checked = True Then
                    Writer.WriteLine(QM + TempPath + "convert.exe" + QM + " " + QM + Folder1 + QM + " " + QM + Folder2 + "\" + SongName + "-drums1.wav" + QM + " /v /n0 /z1 /#")
                    Writer.WriteLine(QM + TempPath + "convert.exe" + QM + " " + QM + Folder1 + QM + " " + QM + Folder2 + "\" + SongName + "-drums2.wav" + QM + " /v /n1 /z1 /#")
                    Writer.WriteLine(QM + TempPath + "convert.exe" + QM + " " + QM + Folder1 + QM + " " + QM + Folder2 + "\" + SongName + "-drums3.wav" + QM + " /v /n2 /z1 /#")
                End If
                If gh_guitar.Checked = True Then
                    Writer.WriteLine(QM + TempPath + "convert.exe" + QM + " " + QM + Folder1 + QM + " " + QM + Folder2 + "\" + SongName + "-guitar.wav" + QM + " /v /n3 /z1 /#")
                End If
                If gh_bass.Checked = True Then
                    Writer.WriteLine(QM + TempPath + "convert.exe" + QM + " " + QM + Folder1 + QM + " " + QM + Folder2 + "\" + SongName + "-bass.wav" + QM + " /v /n4 /z1 /#")
                End If
                If gh_vocals.Checked = True Then
                    Writer.WriteLine(QM + TempPath + "convert.exe" + QM + " " + QM + Folder1 + QM + " " + QM + Folder2 + "\" + SongName + "-vocals.wav" + QM + " /v /n5 /z1 /#")
                End If
            End If

            If Folders = 0 And SamePath = 1 Then
                If gh_drums.Checked = True Then
                    Writer.WriteLine(QM + TempPath + "convert.exe" + QM + " " + QM + Folder1 + QM + " " + QM + Path + SongName + "-drums1.wav" + QM + " /v /n0 /z1 /#")
                    Writer.WriteLine(QM + TempPath + "convert.exe" + QM + " " + QM + Folder1 + QM + " " + QM + Path + SongName + "-drums2.wav" + QM + " /v /n1 /z1 /#")
                    Writer.WriteLine(QM + TempPath + "convert.exe" + QM + " " + QM + Folder1 + QM + " " + QM + Path + SongName + "-drums3.wav" + QM + " /v /n2 /z1 /#")
                End If
                If gh_guitar.Checked = True Then
                    Writer.WriteLine(QM + TempPath + "convert.exe" + QM + " " + QM + Folder1 + QM + " " + QM + Path + SongName + "-guitar.wav" + QM + " /v /n3 /z1 /#")
                End If
                If gh_bass.Checked = True Then
                    Writer.WriteLine(QM + TempPath + "convert.exe" + QM + " " + QM + Folder1 + QM + " " + QM + Path + SongName + "-bass.wav" + QM + " /v /n4 /z1 /#")
                End If
                If gh_vocals.Checked = True Then
                    Writer.WriteLine(QM + TempPath + "convert.exe" + QM + " " + QM + Folder1 + QM + " " + QM + Path + SongName + "-vocals.wav" + QM + " /v /n5 /z1 /#")
                End If
            End If

            If Folders = 1 And SamePath = 0 Then
                If gh_drums.Checked = True Then
                    Writer.WriteLine(QM + TempPath + "convert.exe" + QM + " " + QM + Folder1 + QM + " " + QM + Folder2 + "\" + SongName + "\" + SongName + "-drums1.wav" + QM + " /v /n0 /z1 /#")
                    Writer.WriteLine(QM + TempPath + "convert.exe" + QM + " " + QM + Folder1 + QM + " " + QM + Folder2 + "\" + SongName + "\" + SongName + "-drums2.wav" + QM + " /v /n1 /z1 /#")
                    Writer.WriteLine(QM + TempPath + "convert.exe" + QM + " " + QM + Folder1 + QM + " " + QM + Folder2 + "\" + SongName + "\" + SongName + "-drums3.wav" + QM + " /v /n2 /z1 /#")
                End If
                If gh_guitar.Checked = True Then
                    Writer.WriteLine(QM + TempPath + "convert.exe" + QM + " " + QM + Folder1 + QM + " " + QM + Folder2 + "\" + SongName + "\" + SongName + "-guitar.wav" + QM + " /v /n3 /z1 /#")
                End If
                If gh_bass.Checked = True Then
                    Writer.WriteLine(QM + TempPath + "convert.exe" + QM + " " + QM + Folder1 + QM + " " + QM + Folder2 + "\" + SongName + "\" + SongName + "-bass.wav" + QM + " /v /n4 /z1 /#")
                End If
                If gh_vocals.Checked = True Then
                    Writer.WriteLine(QM + TempPath + "convert.exe" + QM + " " + QM + Folder1 + QM + " " + QM + Folder2 + "\" + SongName + "\" + SongName + "-vocals.wav" + QM + " /v /n5 /z1 /#")
                End If
            End If

            If Folders = 1 And SamePath = 1 Then
                If gh_drums.Checked = True Then
                    Writer.WriteLine(QM + TempPath + "convert.exe" + QM + " " + QM + Folder1 + QM + " " + QM + Path + SongName + "\" + SongName + "-drums1.wav" + QM + " /v /n0 /z1 /#")
                    Writer.WriteLine(QM + TempPath + "convert.exe" + QM + " " + QM + Folder1 + QM + " " + QM + Path + SongName + "\" + SongName + "-drums2.wav" + QM + " /v /n1 /z1 /#")
                    Writer.WriteLine(QM + TempPath + "convert.exe" + QM + " " + QM + Folder1 + QM + " " + QM + Path + SongName + "\" + SongName + "-drums3.wav" + QM + " /v /n2 /z1 /#")
                End If
                If gh_guitar.Checked = True Then
                    Writer.WriteLine(QM + TempPath + "convert.exe" + QM + " " + QM + Folder1 + QM + " " + QM + Path + SongName + "\" + SongName + "-guitar.wav" + QM + " /v /n3 /z1 /#")
                End If
                If gh_bass.Checked = True Then
                    Writer.WriteLine(QM + TempPath + "convert.exe" + QM + " " + QM + Folder1 + QM + " " + QM + Path + SongName + "\" + SongName + "-bass.wav" + QM + " /v /n4 /z1 /#")
                End If
                If gh_vocals.Checked = True Then
                    Writer.WriteLine(QM + TempPath + "convert.exe" + QM + " " + QM + Folder1 + QM + " " + QM + Path + SongName + "\" + SongName + "-vocals.wav" + QM + " /v /n5 /z1 /#")
                End If
            End If
        Next i

        Writer.Close()
        Convert.StartInfo.FileName = TempPath + "convert.cmd"
        Convert.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        Convert.StartInfo.CreateNoWindow = True
        Convert.Start()
        Convert.WaitForExit()
        Convert.Close()

        IO.File.Delete(TempPath + "convert.cmd")
        IO.File.Delete(TempPath + "convert.exe")
        IO.File.Delete(TempPath + "convert.dll")

        For i = 0 To GHAmount - 1
            GHList.SetSelected(i, False)
        Next i
        Me.Enabled = True
    End Sub
End Class

