Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("c:/windows/explorer.exe ms-availablenetworks:")
    End Sub
End Class