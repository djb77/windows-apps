Public Class AboutBox
    Private Sub Button_About_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_About.Click
        main.Enabled = True
        Me.Close()
    End Sub

    Private Sub About_Label7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles About_Label7.LinkClicked
        System.Diagnostics.Process.Start("http://www.psp-hq.com")
    End Sub
End Class