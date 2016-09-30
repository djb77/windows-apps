<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.gh_folders = New System.Windows.Forms.CheckBox
        Me.gh_samepath = New System.Windows.Forms.CheckBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.gh_drums = New System.Windows.Forms.CheckBox
        Me.gh_bass = New System.Windows.Forms.CheckBox
        Me.gh_guitar = New System.Windows.Forms.CheckBox
        Me.gh_vocals = New System.Windows.Forms.CheckBox
        Me.BikFile = New System.Windows.Forms.OpenFileDialog
        Me.OutputFolder = New System.Windows.Forms.FolderBrowserDialog
        Me.GHList = New System.Windows.Forms.ListBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ghac.My.Resources.Resources.logo
        Me.PictureBox1.InitialImage = Global.ghac.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 250)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 241)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Audio Converter"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(270, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 38)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select the .BIK File(s) to Convert"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(236, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 20)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(224, 20)
        Me.TextBox1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.gh_folders)
        Me.GroupBox2.Controls.Add(Me.gh_samepath)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(270, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 88)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select the Output Folder"
        '
        'gh_folders
        '
        Me.gh_folders.AutoSize = True
        Me.gh_folders.Location = New System.Drawing.Point(6, 63)
        Me.gh_folders.Name = "gh_folders"
        Me.gh_folders.Size = New System.Drawing.Size(241, 17)
        Me.gh_folders.TabIndex = 3
        Me.gh_folders.Text = "Do not create folders for the extracted Tracks"
        Me.gh_folders.UseVisualStyleBackColor = True
        '
        'gh_samepath
        '
        Me.gh_samepath.AutoSize = True
        Me.gh_samepath.Location = New System.Drawing.Point(6, 41)
        Me.gh_samepath.Name = "gh_samepath"
        Me.gh_samepath.Size = New System.Drawing.Size(245, 17)
        Me.gh_samepath.TabIndex = 2
        Me.gh_samepath.Text = "Extract Files to the same folder as this Program"
        Me.gh_samepath.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(236, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 20)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Browse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 14)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(224, 20)
        Me.TextBox2.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(487, 244)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "START"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'gh_drums
        '
        Me.gh_drums.AutoSize = True
        Me.gh_drums.Location = New System.Drawing.Point(276, 161)
        Me.gh_drums.Name = "gh_drums"
        Me.gh_drums.Size = New System.Drawing.Size(92, 17)
        Me.gh_drums.TabIndex = 6
        Me.gh_drums.Text = "Extract Drums"
        Me.gh_drums.UseVisualStyleBackColor = True
        '
        'gh_bass
        '
        Me.gh_bass.AutoSize = True
        Me.gh_bass.Location = New System.Drawing.Point(276, 181)
        Me.gh_bass.Name = "gh_bass"
        Me.gh_bass.Size = New System.Drawing.Size(85, 17)
        Me.gh_bass.TabIndex = 7
        Me.gh_bass.Text = "Extract Bass"
        Me.gh_bass.UseVisualStyleBackColor = True
        '
        'gh_guitar
        '
        Me.gh_guitar.AutoSize = True
        Me.gh_guitar.Location = New System.Drawing.Point(276, 201)
        Me.gh_guitar.Name = "gh_guitar"
        Me.gh_guitar.Size = New System.Drawing.Size(90, 17)
        Me.gh_guitar.TabIndex = 8
        Me.gh_guitar.Text = "Extract Guitar"
        Me.gh_guitar.UseVisualStyleBackColor = True
        '
        'gh_vocals
        '
        Me.gh_vocals.AutoSize = True
        Me.gh_vocals.Location = New System.Drawing.Point(276, 221)
        Me.gh_vocals.Name = "gh_vocals"
        Me.gh_vocals.Size = New System.Drawing.Size(176, 17)
        Me.gh_vocals.TabIndex = 9
        Me.gh_vocals.Text = "Extract Vocals + Backing Track"
        Me.gh_vocals.UseVisualStyleBackColor = True
        '
        'GHList
        '
        Me.GHList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GHList.FormattingEnabled = True
        Me.GHList.Location = New System.Drawing.Point(6, 18)
        Me.GHList.Name = "GHList"
        Me.GHList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.GHList.Size = New System.Drawing.Size(548, 117)
        Me.GHList.TabIndex = 10
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(406, 244)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Clear List"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GHList)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 269)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(560, 151)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Selected Files to be Converted:"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 432)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.gh_vocals)
        Me.Controls.Add(Me.gh_guitar)
        Me.Controls.Add(Me.gh_bass)
        Me.Controls.Add(Me.gh_drums)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guitar Hero Audio Converter v1.3"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents gh_drums As System.Windows.Forms.CheckBox
    Friend WithEvents gh_bass As System.Windows.Forms.CheckBox
    Friend WithEvents gh_guitar As System.Windows.Forms.CheckBox
    Friend WithEvents gh_vocals As System.Windows.Forms.CheckBox
    Friend WithEvents BikFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OutputFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents gh_folders As System.Windows.Forms.CheckBox
    Friend WithEvents gh_samepath As System.Windows.Forms.CheckBox
    Friend WithEvents GHList As System.Windows.Forms.ListBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox

End Class
