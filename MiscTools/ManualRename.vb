Option Explicit On
Option Strict On
Public Class ManualRename
    Dim SelectedPath As String
    Dim Files() As String
    Private Sub BTNChooseDirectory_Click(sender As Object, e As EventArgs) Handles BTNChooseDirectory.Click
        FolderSelect.ShowDialog()
        TxtBxDirectory.Text = FolderSelect.SelectedPath
    End Sub

    Private Sub BTNReadFiles_Click(sender As Object, e As EventArgs) Handles BTNReadFiles.Click
        Dim temp As Integer
        temp = 0
        SelectedPath = TxtBxDirectory.Text
        For Each file In IO.Directory.GetFiles(SelectedPath)
            Files(temp) = file
            temp += 1
        Next
        MsgBox(Files.ToString)
    End Sub
End Class