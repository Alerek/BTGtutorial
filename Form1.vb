Public Class Form1
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        System.Diagnostics.Process.Start("https://www.blairtg.com/recovery")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("https://www.blairtg.com/warranty-program")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://www.blairtg.com/troubleshooting")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        System.Diagnostics.Process.Start("https://www.blairtg.com/faqs")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        System.Diagnostics.Process.Start("https://www.blairtg.com/")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        System.Diagnostics.Process.Start("https://www.blairtg.com/about-blair-technology-group")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        System.Diagnostics.Process.Start("https://www.blairtg.com/contact-us/")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        System.Diagnostics.Process.Start("https://www.blairtg.com/chat/")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Forms.Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.Form3.Show()
    End Sub
End Class

