Imports System.IO
Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("explorer.exe ms-settings:activation")
    End Sub
End Class