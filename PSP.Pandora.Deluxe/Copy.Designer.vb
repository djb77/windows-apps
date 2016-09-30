<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Copy
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
        Me.LoadBackup2 = New System.Windows.Forms.OpenFileDialog
        Me.SaveBackup2 = New System.Windows.Forms.SaveFileDialog
        Me.SuspendLayout()
        '
        'LoadBackup2
        '
        Me.LoadBackup2.FileName = "LoadBackup2"
        '
        'Copy_Script
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.ClientSize = New System.Drawing.Size(15, 9)
        Me.ControlBox = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Copy_Script"
        Me.Opacity = 0
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LoadBackup2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveBackup2 As System.Windows.Forms.SaveFileDialog
End Class
