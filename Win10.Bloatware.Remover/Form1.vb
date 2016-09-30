Public Class Form1

    Public Shared check21 = 0
    Public Shared check22 = 0
    Public Shared check23 = 0
    Public Shared check24 = 0
    Public Shared check25 = 0
    Public Shared check26 = 0
    Public Shared check27 = 0
    Public Shared check28 = 0
    Public Shared check29 = 0
    Public Shared check30 = 0
    Public Shared check31 = 0
    Public Shared check32 = 0
    Public Shared check33 = 0
    Public Shared check34 = 0
    Public Shared check35 = 0
    Public Shared check36 = 0
    Public Shared check37 = 0
    Public Shared check38 = 0
    Public Shared check39 = 0
    Public Shared check40 = 0
    Public Shared check41 = 0
    Public Shared check42 = 0
    Public Shared check43 = 0
    Const quote As String = """"

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        check21 = 1
        check22 = 1
        check23 = 0
        check24 = 1
        check25 = 1
        check26 = 1
        check27 = 1
        check29 = 1
        check43 = 1
        check30 = 1
        check31 = 1
        check32 = 1
        check33 = 1
        check34 = 1
        check35 = 1
        check36 = 1
        check37 = 1
        check38 = 0
        check39 = 1
        check40 = 1
        check41 = 1
        check42 = 0
        check28 = 0
        CheckBox21.Checked = True
        CheckBox22.Checked = True
        CheckBox23.Checked = False
        CheckBox24.Checked = True
        CheckBox25.Checked = True
        CheckBox26.Checked = True
        CheckBox27.Checked = True
        CheckBox29.Checked = True
        CheckBox1.Checked = True
        CheckBox30.Checked = True
        CheckBox31.Checked = True
        CheckBox32.Checked = True
        CheckBox33.Checked = True
        CheckBox34.Checked = True
        CheckBox35.Checked = True
        CheckBox36.Checked = True
        CheckBox37.Checked = True
        CheckBox38.Checked = False
        CheckBox39.Checked = True
        CheckBox40.Checked = True
        CheckBox41.Checked = True
        CheckBox42.Checked = False
        CheckBox28.Checked = False
        Me.Refresh()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        check21 = 1
        check22 = 1
        check23 = 1
        check24 = 1
        check25 = 1
        check26 = 1
        check27 = 1
        check29 = 1
        check43 = 1
        check30 = 1
        check31 = 1
        check32 = 1
        check33 = 1
        check34 = 1
        check35 = 1
        check36 = 1
        check37 = 1
        check38 = 1
        check39 = 1
        check40 = 1
        check41 = 1
        check42 = 1
        check28 = 1
        CheckBox21.Checked = True
        CheckBox22.Checked = True
        CheckBox23.Checked = True
        CheckBox24.Checked = True
        CheckBox25.Checked = True
        CheckBox26.Checked = True
        CheckBox27.Checked = True
        CheckBox29.Checked = True
        CheckBox1.Checked = True
        CheckBox30.Checked = True
        CheckBox31.Checked = True
        CheckBox32.Checked = True
        CheckBox33.Checked = True
        CheckBox34.Checked = True
        CheckBox35.Checked = True
        CheckBox36.Checked = True
        CheckBox37.Checked = True
        CheckBox38.Checked = True
        CheckBox39.Checked = True
        CheckBox40.Checked = True
        CheckBox41.Checked = True
        CheckBox42.Checked = True
        CheckBox28.Checked = True
        Me.Refresh()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        check21 = 0
        check22 = 0
        check23 = 0
        check24 = 0
        check25 = 0
        check26 = 0
        check27 = 0
        check29 = 0
        check43 = 0
        check30 = 0
        check31 = 0
        check32 = 0
        check33 = 0
        check34 = 0
        check35 = 0
        check36 = 0
        check37 = 0
        check38 = 0
        check39 = 0
        check40 = 0
        check41 = 0
        check42 = 0
        check28 = 0
        CheckBox21.Checked = False
        CheckBox22.Checked = False
        CheckBox23.Checked = False
        CheckBox24.Checked = False
        CheckBox25.Checked = False
        CheckBox26.Checked = False
        CheckBox27.Checked = False
        CheckBox29.Checked = False
        CheckBox1.Checked = False
        CheckBox30.Checked = False
        CheckBox31.Checked = False
        CheckBox32.Checked = False
        CheckBox33.Checked = False
        CheckBox34.Checked = False
        CheckBox35.Checked = False
        CheckBox36.Checked = False
        CheckBox37.Checked = False
        CheckBox38.Checked = False
        CheckBox39.Checked = False
        CheckBox40.Checked = False
        CheckBox41.Checked = False
        CheckBox42.Checked = False
        CheckBox28.Checked = False
        Me.Refresh()
    End Sub

    Private Sub CheckBox21_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox21.CheckedChanged
        If CheckBox21.Checked = True Then
            check21 = 1
        Else
            check21 = 0
        End If
    End Sub

    Private Sub CheckBox22_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox22.CheckedChanged
        If CheckBox22.Checked = True Then
            check22 = 1
        Else
            check22 = 0
        End If
    End Sub

    Private Sub CheckBox23_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox23.CheckedChanged
        If CheckBox23.Checked = True Then
            check23 = 1
        Else
            check23 = 0
        End If
    End Sub

    Private Sub CheckBox24_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox24.CheckedChanged
        If CheckBox24.Checked = True Then
            check24 = 1
        Else
            check24 = 0
        End If
    End Sub

    Private Sub CheckBox25_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox25.CheckedChanged
        If CheckBox25.Checked = True Then
            check25 = 1
        Else
            check25 = 0
        End If
    End Sub

    Private Sub CheckBox26_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox26.CheckedChanged
        If CheckBox26.Checked = True Then
            check26 = 1
        Else
            check26 = 0
        End If
    End Sub

    Private Sub CheckBox27_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox27.CheckedChanged
        If CheckBox27.Checked = True Then
            check27 = 1
        Else
            check27 = 0
        End If
    End Sub

    Private Sub CheckBox29_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox29.CheckedChanged
        If CheckBox21.Checked = True Then
            check29 = 1
        Else
            check29 = 0
        End If
    End Sub

    Private Sub CheckBox30_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox30.CheckedChanged
        If CheckBox21.Checked = True Then
            check30 = 1
        Else
            check30 = 0
        End If
    End Sub

    Private Sub CheckBox31_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox31.CheckedChanged
        If CheckBox31.Checked = True Then
            check31 = 1
        Else
            check31 = 0
        End If
    End Sub

    Private Sub CheckBox32_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox32.CheckedChanged
        If CheckBox32.Checked = True Then
            check32 = 1
        Else
            check32 = 0
        End If
    End Sub

    Private Sub CheckBox33_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox33.CheckedChanged
        If CheckBox33.Checked = True Then
            check33 = 1
        Else
            check33 = 0
        End If
    End Sub

    Private Sub CheckBox34_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox34.CheckedChanged
        If CheckBox34.Checked = True Then
            check34 = 1
        Else
            check34 = 0
        End If
    End Sub

    Private Sub CheckBox35_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox35.CheckedChanged
        If CheckBox35.Checked = True Then
            check35 = 1
        Else
            check35 = 0
        End If
    End Sub

    Private Sub CheckBox36_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox36.CheckedChanged
        If CheckBox36.Checked = True Then
            check36 = 1
        Else
            check36 = 0
        End If
    End Sub

    Private Sub CheckBox37_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox37.CheckedChanged
        If CheckBox37.Checked = True Then
            check37 = 1
        Else
            check37 = 0
        End If
    End Sub

    Private Sub CheckBox38_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox38.CheckedChanged
        If CheckBox38.Checked = True Then
            check38 = 1
        Else
            check38 = 0
        End If
    End Sub

    Private Sub CheckBox39_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox39.CheckedChanged
        If CheckBox39.Checked = True Then
            check39 = 1
        Else
            check39 = 0
        End If
    End Sub

    Private Sub CheckBox40_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox40.CheckedChanged
        If CheckBox40.Checked = True Then
            check40 = 1
        Else
            check40 = 0
        End If
    End Sub

    Private Sub CheckBox41_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox41.CheckedChanged
        If CheckBox41.Checked = True Then
            check41 = 1
        Else
            check41 = 0
        End If
    End Sub

    Private Sub CheckBox42_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox42.CheckedChanged
        If CheckBox42.Checked = True Then
            check42 = 1
        Else
            check42 = 0
        End If
    End Sub

    Private Sub CheckBox28_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox28.CheckedChanged
        If CheckBox28.Checked = True Then
            check28 = 1
        Else
            check28 = 0
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            check43 = 1
        Else
            check43 = 0
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CheckBox21.Enabled = False
        CheckBox22.Enabled = False
        CheckBox23.Enabled = False
        CheckBox24.Enabled = False
        CheckBox25.Enabled = False
        CheckBox26.Enabled = False
        CheckBox27.Enabled = False
        CheckBox29.Enabled = False
        CheckBox1.Enabled = False
        CheckBox30.Enabled = False
        CheckBox31.Enabled = False
        CheckBox32.Enabled = False
        CheckBox33.Enabled = False
        CheckBox34.Enabled = False
        CheckBox35.Enabled = False
        CheckBox36.Enabled = False
        CheckBox37.Enabled = False
        CheckBox38.Enabled = False
        CheckBox39.Enabled = False
        CheckBox40.Enabled = False
        CheckBox41.Enabled = False
        CheckBox42.Enabled = False
        CheckBox28.Enabled = False

        Me.Refresh()

        ' REMOVE 3D BUILDER
        ' -----------------
        If check21 = 1 Then
            CheckBox21.Enabled = True
            CheckBox21.Text = "Removing 3D Builder ..."
            CheckBox21.ForeColor = Color.Blue
            CheckBox21.CheckState = CheckState.Indeterminate
            Me.Refresh()
            Dim process As New Process
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/c powershell.exe -command " + quote + "Get-AppxPackage *3Dbuilder* | Remove-AppxPackage" + quote
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()
            process.Close()
            CheckBox21.Text = "Removed 3D Builder"
            CheckBox21.ForeColor = Color.Green
            CheckBox21.CheckState = CheckState.Checked
            Me.Refresh()
        End If

        ' REMOVE ALARMS & CLOCK
        ' ---------------------
        If check22 = 1 Then
            CheckBox22.Enabled = True
            CheckBox22.Text = "Removing Alarms && Clock ..."
            CheckBox22.ForeColor = Color.Blue
            CheckBox22.CheckState = CheckState.Indeterminate
            Me.Refresh()
            Dim process As New Process
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/c powershell.exe -command " + quote + "Get-AppxPackage *windowsalarms* | Remove-AppxPackage" + quote
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()
            process.Close()
            CheckBox22.Text = "Removed Alarms && Clock"
            CheckBox22.ForeColor = Color.Green
            CheckBox22.CheckState = CheckState.Checked
            Me.Refresh()
        End If

        ' REMOVE CALCULATOR
        ' -----------------
        If check23 = 1 Then
            CheckBox23.Enabled = True
            CheckBox23.Text = "Removing Calculator ..."
            CheckBox23.ForeColor = Color.Blue
            CheckBox23.CheckState = CheckState.Indeterminate
            Me.Refresh()
            Dim process As New Process
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/c powershell.exe -command " + quote + "Get-AppxPackage *windowscalculator* | Remove-AppxPackage" + quote
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()
            process.Close()
            CheckBox23.Text = "Removed Calculator"
            CheckBox23.ForeColor = Color.Green
            CheckBox23.CheckState = CheckState.Checked
            Me.Refresh()
        End If

        ' REMOVE CALENDAR & MAIL
        ' ----------------------
        If check24 = 1 Then
            CheckBox24.Enabled = True
            CheckBox24.Text = "Removing Calendar && Mail ..."
            CheckBox24.ForeColor = Color.Blue
            CheckBox24.CheckState = CheckState.Indeterminate
            Me.Refresh()
            Dim process As New Process
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/c powershell.exe -command " + quote + "Get-AppxPackage *windowscommunicationsapps* | Remove-AppxPackage" + quote
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()
            process.Close()
            CheckBox24.Text = "Removed Calendar && Mail"
            CheckBox24.ForeColor = Color.Green
            CheckBox24.CheckState = CheckState.Checked
            Me.Refresh()
        End If

        ' REMOVE CAMERA
        ' -------------
        If check25 = 1 Then
            CheckBox25.Enabled = True
            CheckBox25.Text = "Removing Camera ..."
            CheckBox25.ForeColor = Color.Blue
            CheckBox25.CheckState = CheckState.Indeterminate
            Me.Refresh()
            Dim process As New Process
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/c powershell.exe -command " + quote + "Get-AppxPackage *windowscamera* | Remove-AppxPackage" + quote
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()
            process.Close()
            CheckBox25.Text = "Removed Camera"
            CheckBox25.ForeColor = Color.Green
            CheckBox25.CheckState = CheckState.Checked
            Me.Refresh()
        End If

        ' REMOVE GET OFFICE
        ' -----------------
        If check26 = 1 Then
            CheckBox26.Enabled = True
            CheckBox26.Text = "Removing Get Office ..."
            CheckBox26.ForeColor = Color.Blue
            CheckBox26.CheckState = CheckState.Indeterminate
            Me.Refresh()
            Dim process As New Process
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/c powershell.exe -command " + quote + "Get-AppxPackage *officehub* | Remove-AppxPackage" + quote
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()
            process.Close()
            CheckBox26.Text = "Removed Get Office"
            CheckBox26.ForeColor = Color.Green
            CheckBox26.CheckState = CheckState.Checked
            Me.Refresh()
        End If

        ' REMOVE GET SKYPE
        ' ----------------
        If check27 = 1 Then
            CheckBox27.Enabled = True
            CheckBox27.Text = "Removing Get Skype ..."
            CheckBox27.ForeColor = Color.Blue
            CheckBox27.CheckState = CheckState.Indeterminate
            Me.Refresh()
            Dim process As New Process
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/c powershell.exe -command " + quote + "Get-AppxPackage *skypeapp* | Remove-AppxPackage" + quote
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()
            process.Close()
            CheckBox27.Text = "Removed Get Skype"
            CheckBox27.ForeColor = Color.Green
            CheckBox27.CheckState = CheckState.Checked
            Me.Refresh()
        End If

        ' REMOVE GET STARTED
        ' ------------------
        If check29 = 1 Then
            CheckBox29.Enabled = True
            CheckBox29.Text = "Removing Get Started ..."
            CheckBox29.ForeColor = Color.Blue
            CheckBox29.CheckState = CheckState.Indeterminate
            Me.Refresh()
            Dim process As New Process
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/c powershell.exe -command " + quote + "Get-AppxPackage *getstarted* | Remove-AppxPackage" + quote
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()
            process.Close()
            CheckBox29.Text = "Removed Get Started"
            CheckBox29.ForeColor = Color.Green
            CheckBox29.CheckState = CheckState.Checked
            Me.Refresh()
        End If

        ' REMOVE GROOVE MUSIC
        ' -------------------
        If check30 = 1 Then
            CheckBox30.Enabled = True
            CheckBox30.Text = "Removing Groove Music ..."
            CheckBox30.ForeColor = Color.Blue
            CheckBox30.CheckState = CheckState.Indeterminate
            Me.Refresh()
            Dim process As New Process
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/c powershell.exe -command " + quote + "Get-AppxPackage *zunemusic* | Remove-AppxPackage" + quote
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()
            process.Close()
            CheckBox30.Text = "Removed Groove Music"
            CheckBox30.ForeColor = Color.Green
            CheckBox30.CheckState = CheckState.Checked
            Me.Refresh()
        End If

        ' REMOVE MAPS
        ' -----------
        If check31 = 1 Then
            CheckBox31.Enabled = True
            CheckBox31.Text = "Removing Maps ..."
            CheckBox31.ForeColor = Color.Blue
            CheckBox31.CheckState = CheckState.Indeterminate
            Me.Refresh()
            Dim process As New Process
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/c powershell.exe -command " + quote + "Get-AppxPackage *windowsmaps* | Remove-AppxPackage" + quote
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()
            process.Close()
            CheckBox31.Text = "Removed Maps"
            CheckBox31.ForeColor = Color.Green
            CheckBox31.CheckState = CheckState.Checked
            Me.Refresh()
        End If

        ' REMOVE MICROSOFT SOLITAIRE COLLECTION
        ' -------------------------------------
        If check43 = 1 Then
            CheckBox1.Enabled = True
            CheckBox1.Text = "Removing Microsoft Solitaire Collection ..."
            CheckBox1.ForeColor = Color.Blue
            CheckBox1.CheckState = CheckState.Indeterminate
            Me.Refresh()
            Dim process As New Process
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/c powershell.exe -command " + quote + "Get-AppxPackage *solitairecollection* | Remove-AppxPackage" + quote
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()
            process.Close()
            CheckBox1.Text = "Removed Microsoft Solitaire Collection"
            CheckBox1.ForeColor = Color.Green
            CheckBox1.CheckState = CheckState.Checked
            Me.Refresh()
        End If

        ' REMOVE MONEY
        ' ------------
        If check32 = 1 Then
            CheckBox32.Enabled = True
            CheckBox32.Text = "Removing Money ..."
            CheckBox32.ForeColor = Color.Blue
            CheckBox32.CheckState = CheckState.Indeterminate
            Me.Refresh()
            Dim process As New Process
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/c powershell.exe -command " + quote + "Get-AppxPackage *bingfinance* | Remove-AppxPackage" + quote
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()
            process.Close()
            CheckBox32.Text = "Removed Money"
            CheckBox32.ForeColor = Color.Green
            CheckBox32.CheckState = CheckState.Checked
            Me.Refresh()
        End If

        ' REMOVE MOVIES & TV
        ' ------------------
        If check33 = 1 Then
            CheckBox33.Enabled = True
            CheckBox33.Text = "Removing Movies && TV ..."
            CheckBox33.ForeColor = Color.Blue
            CheckBox33.CheckState = CheckState.Indeterminate
            Me.Refresh()
            Dim process As New Process
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/c powershell.exe -command " + quote + "Get-AppxPackage *zunevideo* | Remove-AppxPackage" + quote
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()
            process.Close()
            CheckBox33.Text = "Removed Movies && TV"
            CheckBox33.ForeColor = Color.Green
            CheckBox33.CheckState = CheckState.Checked
            Me.Refresh()
        End If

        ' REMOVE NEWS
        ' -----------
        If check34 = 1 Then
            CheckBox34.Enabled = True
            CheckBox34.Text = "Removing News ..."
            CheckBox34.ForeColor = Color.Blue
            CheckBox34.CheckState = CheckState.Indeterminate
            Me.Refresh()
            Dim process As New Process
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/c powershell.exe -command " + quote + "Get-AppxPackage *bingnews* | Remove-AppxPackage" + quote
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()
            process.Close()
            CheckBox34.Text = "Removed News"
            CheckBox34.ForeColor = Color.Green
            CheckBox34.CheckState = CheckState.Checked
            Me.Refresh()
        End If

        ' REMOVE ONENOTE
        ' --------------
        If check35 = 1 Then
            CheckBox35.Enabled = True
            CheckBox35.Text = "Removing OneNote ..."
            CheckBox35.ForeColor = Color.Blue
            CheckBox35.CheckState = CheckState.Indeterminate
            Me.Refresh()
            Dim process As New Process
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/c powershell.exe -command " + quote + "Get-AppxPackage *onenote* | Remove-AppxPackage" + quote
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()
            process.Close()
            CheckBox35.Text = "Removed OneNote"
            CheckBox35.ForeColor = Color.Green
            CheckBox35.CheckState = CheckState.Checked
            Me.Refresh()
        End If

        ' REMOVE PEOPLE
        ' -------------
        If check36 = 1 Then
            CheckBox36.Enabled = True
            CheckBox36.Text = "Removing People ..."
            CheckBox36.ForeColor = Color.Blue
            CheckBox36.CheckState = CheckState.Indeterminate
            Me.Refresh()
            Dim process As New Process
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/c powershell.exe -command " + quote + "Get-AppxPackage *people* | Remove-AppxPackage" + quote
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()
            process.Close()
            CheckBox36.Text = "Removed People"
            CheckBox36.ForeColor = Color.Green
            CheckBox36.CheckState = CheckState.Checked
            Me.Refresh()
        End If

        ' REMOVE PHONE COMPANION
        ' ----------------------
        If check37 = 1 Then
            CheckBox37.Enabled = True
            CheckBox37.Text = "Removing Phone Companion ..."
            CheckBox37.ForeColor = Color.Blue
            CheckBox37.CheckState = CheckState.Indeterminate
            Me.Refresh()
            Dim process As New Process
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/c powershell.exe -command " + quote + "Get-AppxPackage *windowsphone* | Remove-AppxPackage" + quote
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()
            process.Close()
            CheckBox37.Text = "Removed Phone Companion"
            CheckBox37.ForeColor = Color.Green
            CheckBox37.CheckState = CheckState.Checked
            Me.Refresh()
        End If

        ' REMOVE PHOTOS
        ' -------------
        If check38 = 1 Then
            CheckBox38.Enabled = True
            CheckBox38.Text = "Removing Photos ..."
            CheckBox38.ForeColor = Color.Blue
            CheckBox38.CheckState = CheckState.Indeterminate
            Me.Refresh()
            Dim process As New Process
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/c powershell.exe -command " + quote + "Get-AppxPackage *photos* | Remove-AppxPackage" + quote
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()
            process.Close()
            CheckBox38.Text = "Removed Photos"
            CheckBox38.ForeColor = Color.Green
            CheckBox38.CheckState = CheckState.Checked
            Me.Refresh()
        End If

        ' REMOVE SPORTS
        ' -------------
        If check39 = 1 Then
            CheckBox39.Enabled = True
            CheckBox39.Text = "Removing Sports ..."
            CheckBox39.ForeColor = Color.Blue
            CheckBox39.CheckState = CheckState.Indeterminate
            Me.Refresh()
            Dim process As New Process
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/c powershell.exe -command " + quote + "Get-AppxPackage *bingsports* | Remove-AppxPackage" + quote
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()
            process.Close()
            CheckBox39.Text = "Removed Sports"
            CheckBox39.ForeColor = Color.Green
            CheckBox39.CheckState = CheckState.Checked
            Me.Refresh()
        End If

        ' REMOVE SOUND RECORDER
        ' ---------------------
        If check40 = 1 Then
            CheckBox40.Enabled = True
            CheckBox40.Text = "Removing Sound Recorder ..."
            CheckBox40.ForeColor = Color.Blue
            CheckBox40.CheckState = CheckState.Indeterminate
            Me.Refresh()
            Dim process As New Process
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/c powershell.exe -command " + quote + "Get-AppxPackage *soundrecorder* | Remove-AppxPackage" + quote
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()
            process.Close()
            CheckBox40.Text = "Removed Sound Recorder"
            CheckBox40.ForeColor = Color.Green
            CheckBox40.CheckState = CheckState.Checked
            Me.Refresh()
        End If

        ' REMOVE WEATHER
        ' --------------
        If check41 = 1 Then
            CheckBox41.Enabled = True
            CheckBox41.Text = "Removing Weather ..."
            CheckBox41.ForeColor = Color.Blue
            CheckBox41.CheckState = CheckState.Indeterminate
            Me.Refresh()
            Dim process As New Process
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/c powershell.exe -command " + quote + "Get-AppxPackage *bingweather* | Remove-AppxPackage" + quote
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()
            process.Close()
            CheckBox41.Text = "Removed Weather"
            CheckBox41.ForeColor = Color.Green
            CheckBox41.CheckState = CheckState.Checked
            Me.Refresh()
        End If

        ' REMOVE WINDOWS STORE
        ' --------------------
        If check42 = 1 Then
            CheckBox42.Enabled = True
            CheckBox42.Text = "Removing Windows Store ..."
            CheckBox42.ForeColor = Color.Blue
            CheckBox42.CheckState = CheckState.Indeterminate
            Me.Refresh()
            Dim process As New Process
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/c powershell.exe -command " + quote + "Get-AppxPackage *windowsstore* | Remove-AppxPackage" + quote
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()
            process.Close()
            CheckBox42.Text = "Removed Windows Store"
            CheckBox42.ForeColor = Color.Green
            CheckBox42.CheckState = CheckState.Checked
            Me.Refresh()
        End If

        ' REMOVE XBOX
        ' -----------
        If check28 = 1 Then
            CheckBox28.Enabled = True
            CheckBox28.Text = "Removing Xbox ..."
            CheckBox28.ForeColor = Color.Blue
            CheckBox28.CheckState = CheckState.Indeterminate
            Me.Refresh()
            Dim process As New Process
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/c powershell.exe -command " + quote + "Get-AppxPackage *xboxapp* | Remove-AppxPackage" + quote
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()
            process.Close()
            CheckBox28.Text = "Removed Xbox"
            CheckBox28.ForeColor = Color.Green
            CheckBox28.CheckState = CheckState.Checked
            Me.Refresh()
        End If

        Me.Close()
    End Sub

End Class
