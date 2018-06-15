Imports System.IO
Public Class ManualRename
    Dim SelectedPath As String
    Dim Files As String()
    Dim FileSelection As Integer = 0
    Dim Extension As String
    Private Sub BTNChooseDirectory_Click(sender As Object, e As EventArgs) Handles BTNChooseDirectory.Click
        FolderSelect.ShowDialog()
        TxtBxDirectory.Text = FolderSelect.SelectedPath
    End Sub

    Private Sub BTNReadFiles_Click(sender As Object, e As EventArgs) Handles BTNReadFiles.Click
        FileSelection = 0
        SelectedPath = TxtBxDirectory.Text
        If (CHKBXSubfolders.Checked = True) Then
            Files = Directory.GetFiles(SelectedPath, "*", SearchOption.AllDirectories)
        Else
            Files = Directory.GetFiles(SelectedPath, "*", SearchOption.TopDirectoryOnly)
        End If
        'Load first item
        If (FileSelection < Files.Length) Then
            LBLFileNameInfo.Text = Path.GetFileNameWithoutExtension(Files(FileSelection))
            LBLFileCreatedInfo.Text = File.GetCreationTime(Files(FileSelection))
            TxtBxNewName.Text = Path.GetFileNameWithoutExtension(Files(FileSelection))
            Extension = Path.GetExtension(Files(FileSelection))
        End If
    End Sub

    Private Sub BTNNewFilename_Click(sender As Object, e As EventArgs) Handles BTNNewFilename.Click
        'Start Renaming
        If (TxtBxNewName.Text = "") Then
            MsgBox("Please enter a name")
            Exit Sub
        End If
        If Not (TxtBxNewName.Text = Path.GetFileNameWithoutExtension(Files(FileSelection))) Then
            Try
                My.Computer.FileSystem.RenameFile(Files(FileSelection), TxtBxNewName.Text + Extension)
            Catch ex As Exception
                MsgBox("Please enter a different Name!")
                Exit Sub
            End Try
        End If
        LoadNextItem()
    End Sub

    Private Sub LoadNextItem()
        If (FileSelection + 1 < Files.Length) Then
            FileSelection += 1
            LBLFileNameInfo.Text = Path.GetFileNameWithoutExtension(Files(FileSelection))
            LBLFileCreatedInfo.Text = File.GetCreationTime(Files(FileSelection))
            TxtBxNewName.Text = Path.GetFileNameWithoutExtension(Files(FileSelection))
            Extension = Path.GetExtension(Files(FileSelection))
        Else
            LBLFileCreatedInfo.Text = ""
            LBLFileNameInfo.Text = ""
            TxtBxNewName.Text = ""
            MsgBox("No File left")
        End If
    End Sub
End Class