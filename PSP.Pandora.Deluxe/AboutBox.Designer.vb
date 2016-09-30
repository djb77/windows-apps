<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutBox))
        Me.Label1 = New System.Windows.Forms.Label
        Me.About_Label7 = New System.Windows.Forms.LinkLabel
        Me.About_Label6 = New System.Windows.Forms.Label
        Me.About_Label5 = New System.Windows.Forms.Label
        Me.About_Label4 = New System.Windows.Forms.Label
        Me.About_Label3 = New System.Windows.Forms.Label
        Me.About_Label2 = New System.Windows.Forms.Label
        Me.About_Label1 = New System.Windows.Forms.Label
        Me.Button_About = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.About_Logo = New System.Windows.Forms.PictureBox
        CType(Me.About_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "and everyone who has helped with testing this program."
        '
        'About_Label7
        '
        Me.About_Label7.AutoSize = True
        Me.About_Label7.Location = New System.Drawing.Point(113, 255)
        Me.About_Label7.Name = "About_Label7"
        Me.About_Label7.Size = New System.Drawing.Size(120, 13)
        Me.About_Label7.TabIndex = 18
        Me.About_Label7.TabStop = True
        Me.About_Label7.Text = "http://www.psp-hq.com"
        '
        'About_Label6
        '
        Me.About_Label6.AutoSize = True
        Me.About_Label6.Location = New System.Drawing.Point(42, 200)
        Me.About_Label6.Name = "About_Label6"
        Me.About_Label6.Size = New System.Drawing.Size(272, 13)
        Me.About_Label6.TabIndex = 17
        Me.About_Label6.Text = "Forahobby, Klutsh, Noobz, Dark Alex, Hellcat, Jas0nuk, "
        '
        'About_Label5
        '
        Me.About_Label5.AutoSize = True
        Me.About_Label5.Location = New System.Drawing.Point(144, 180)
        Me.About_Label5.Name = "About_Label5"
        Me.About_Label5.Size = New System.Drawing.Size(55, 13)
        Me.About_Label5.TabIndex = 16
        Me.About_Label5.Text = "Thanks to"
        '
        'About_Label4
        '
        Me.About_Label4.AutoSize = True
        Me.About_Label4.Location = New System.Drawing.Point(95, 145)
        Me.About_Label4.Name = "About_Label4"
        Me.About_Label4.Size = New System.Drawing.Size(156, 13)
        Me.About_Label4.TabIndex = 15
        Me.About_Label4.Text = "using VB .NET (Framework 2.0)"
        '
        'About_Label3
        '
        Me.About_Label3.AutoSize = True
        Me.About_Label3.Location = New System.Drawing.Point(31, 130)
        Me.About_Label3.Name = "About_Label3"
        Me.About_Label3.Size = New System.Drawing.Size(277, 13)
        Me.About_Label3.TabIndex = 14
        Me.About_Label3.Text = "This program was designed with Visual Studio .NET 2008"
        '
        'About_Label2
        '
        Me.About_Label2.AutoSize = True
        Me.About_Label2.Location = New System.Drawing.Point(130, 110)
        Me.About_Label2.Name = "About_Label2"
        Me.About_Label2.Size = New System.Drawing.Size(81, 13)
        Me.About_Label2.TabIndex = 13
        Me.About_Label2.Text = "Created by DJB"
        '
        'About_Label1
        '
        Me.About_Label1.AutoSize = True
        Me.About_Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.About_Label1.Location = New System.Drawing.Point(99, 80)
        Me.About_Label1.Name = "About_Label1"
        Me.About_Label1.Size = New System.Drawing.Size(154, 13)
        Me.About_Label1.TabIndex = 12
        Me.About_Label1.Text = "PSP Pandora Deluxe v3.3"
        '
        'Button_About
        '
        Me.Button_About.Location = New System.Drawing.Point(154, 287)
        Me.Button_About.Name = "Button_About"
        Me.Button_About.Size = New System.Drawing.Size(36, 23)
        Me.Button_About.TabIndex = 10
        Me.Button_About.Text = "OK"
        Me.Button_About.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(287, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "the communities at PSP-HQ, PSP-Hacks, and MaxConsole,"
        '
        'About_Logo
        '
        Me.About_Logo.Image = Global.PPD.My.Resources.Resources.logospin
        Me.About_Logo.Location = New System.Drawing.Point(137, 10)
        Me.About_Logo.Name = "About_Logo"
        Me.About_Logo.Size = New System.Drawing.Size(70, 55)
        Me.About_Logo.TabIndex = 11
        Me.About_Logo.TabStop = False
        '
        'AboutBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 320)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.About_Label7)
        Me.Controls.Add(Me.About_Label6)
        Me.Controls.Add(Me.About_Label5)
        Me.Controls.Add(Me.About_Label4)
        Me.Controls.Add(Me.About_Label3)
        Me.Controls.Add(Me.About_Label2)
        Me.Controls.Add(Me.About_Label1)
        Me.Controls.Add(Me.About_Logo)
        Me.Controls.Add(Me.Button_About)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutBox"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.TopMost = True
        CType(Me.About_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents About_Label7 As System.Windows.Forms.LinkLabel
    Friend WithEvents About_Label6 As System.Windows.Forms.Label
    Friend WithEvents About_Label5 As System.Windows.Forms.Label
    Friend WithEvents About_Label4 As System.Windows.Forms.Label
    Friend WithEvents About_Label3 As System.Windows.Forms.Label
    Friend WithEvents About_Label2 As System.Windows.Forms.Label
    Friend WithEvents About_Label1 As System.Windows.Forms.Label
    Friend WithEvents About_Logo As System.Windows.Forms.PictureBox
    Friend WithEvents Button_About As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
