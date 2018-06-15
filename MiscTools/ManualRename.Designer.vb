<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManualRename
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
        Me.FolderSelect = New System.Windows.Forms.FolderBrowserDialog()
        Me.TxtBxDirectory = New System.Windows.Forms.TextBox()
        Me.BTNChooseDirectory = New System.Windows.Forms.Button()
        Me.GRPFileInfo = New System.Windows.Forms.GroupBox()
        Me.LBLFileNameInfo = New System.Windows.Forms.Label()
        Me.LBLFileCreatedInfo = New System.Windows.Forms.Label()
        Me.LBL2 = New System.Windows.Forms.Label()
        Me.LBL1 = New System.Windows.Forms.Label()
        Me.TxtBxNewName = New System.Windows.Forms.TextBox()
        Me.BTNNewFilename = New System.Windows.Forms.Button()
        Me.BTNReadFiles = New System.Windows.Forms.Button()
        Me.GRPFileInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtBxDirectory
        '
        Me.TxtBxDirectory.Location = New System.Drawing.Point(12, 12)
        Me.TxtBxDirectory.Name = "TxtBxDirectory"
        Me.TxtBxDirectory.Size = New System.Drawing.Size(558, 20)
        Me.TxtBxDirectory.TabIndex = 0
        '
        'BTNChooseDirectory
        '
        Me.BTNChooseDirectory.Location = New System.Drawing.Point(576, 10)
        Me.BTNChooseDirectory.Name = "BTNChooseDirectory"
        Me.BTNChooseDirectory.Size = New System.Drawing.Size(103, 23)
        Me.BTNChooseDirectory.TabIndex = 1
        Me.BTNChooseDirectory.Text = "Choose Directory"
        Me.BTNChooseDirectory.UseVisualStyleBackColor = True
        '
        'GRPFileInfo
        '
        Me.GRPFileInfo.Controls.Add(Me.LBLFileNameInfo)
        Me.GRPFileInfo.Controls.Add(Me.LBLFileCreatedInfo)
        Me.GRPFileInfo.Controls.Add(Me.LBL2)
        Me.GRPFileInfo.Controls.Add(Me.LBL1)
        Me.GRPFileInfo.Location = New System.Drawing.Point(12, 38)
        Me.GRPFileInfo.Name = "GRPFileInfo"
        Me.GRPFileInfo.Size = New System.Drawing.Size(776, 63)
        Me.GRPFileInfo.TabIndex = 2
        Me.GRPFileInfo.TabStop = False
        Me.GRPFileInfo.Text = "File Information"
        '
        'LBLFileNameInfo
        '
        Me.LBLFileNameInfo.AutoSize = True
        Me.LBLFileNameInfo.Location = New System.Drawing.Point(93, 16)
        Me.LBLFileNameInfo.Name = "LBLFileNameInfo"
        Me.LBLFileNameInfo.Size = New System.Drawing.Size(0, 13)
        Me.LBLFileNameInfo.TabIndex = 3
        '
        'LBLFileCreatedInfo
        '
        Me.LBLFileCreatedInfo.AutoSize = True
        Me.LBLFileCreatedInfo.Location = New System.Drawing.Point(93, 40)
        Me.LBLFileCreatedInfo.Name = "LBLFileCreatedInfo"
        Me.LBLFileCreatedInfo.Size = New System.Drawing.Size(0, 13)
        Me.LBLFileCreatedInfo.TabIndex = 2
        '
        'LBL2
        '
        Me.LBL2.AutoSize = True
        Me.LBL2.Location = New System.Drawing.Point(6, 40)
        Me.LBL2.Name = "LBL2"
        Me.LBL2.Size = New System.Drawing.Size(81, 13)
        Me.LBL2.TabIndex = 1
        Me.LBL2.Text = "File Created on:"
        '
        'LBL1
        '
        Me.LBL1.AutoSize = True
        Me.LBL1.Location = New System.Drawing.Point(6, 16)
        Me.LBL1.Name = "LBL1"
        Me.LBL1.Size = New System.Drawing.Size(57, 13)
        Me.LBL1.TabIndex = 0
        Me.LBL1.Text = "File Name:"
        '
        'TxtBxNewName
        '
        Me.TxtBxNewName.Location = New System.Drawing.Point(12, 109)
        Me.TxtBxNewName.Name = "TxtBxNewName"
        Me.TxtBxNewName.Size = New System.Drawing.Size(667, 20)
        Me.TxtBxNewName.TabIndex = 3
        '
        'BTNNewFilename
        '
        Me.BTNNewFilename.Location = New System.Drawing.Point(685, 107)
        Me.BTNNewFilename.Name = "BTNNewFilename"
        Me.BTNNewFilename.Size = New System.Drawing.Size(103, 23)
        Me.BTNNewFilename.TabIndex = 4
        Me.BTNNewFilename.Text = "Rename"
        Me.BTNNewFilename.UseVisualStyleBackColor = True
        '
        'BTNReadFiles
        '
        Me.BTNReadFiles.Location = New System.Drawing.Point(685, 10)
        Me.BTNReadFiles.Name = "BTNReadFiles"
        Me.BTNReadFiles.Size = New System.Drawing.Size(103, 23)
        Me.BTNReadFiles.TabIndex = 5
        Me.BTNReadFiles.Text = "Read Files"
        Me.BTNReadFiles.UseVisualStyleBackColor = True
        '
        'ManualRename
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 141)
        Me.Controls.Add(Me.BTNReadFiles)
        Me.Controls.Add(Me.BTNNewFilename)
        Me.Controls.Add(Me.TxtBxNewName)
        Me.Controls.Add(Me.GRPFileInfo)
        Me.Controls.Add(Me.BTNChooseDirectory)
        Me.Controls.Add(Me.TxtBxDirectory)
        Me.Name = "ManualRename"
        Me.Text = "ManualRename"
        Me.GRPFileInfo.ResumeLayout(False)
        Me.GRPFileInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FolderSelect As FolderBrowserDialog
    Friend WithEvents TxtBxDirectory As TextBox
    Friend WithEvents BTNChooseDirectory As Button
    Friend WithEvents GRPFileInfo As GroupBox
    Friend WithEvents LBLFileNameInfo As Label
    Friend WithEvents LBLFileCreatedInfo As Label
    Friend WithEvents LBL2 As Label
    Friend WithEvents LBL1 As Label
    Friend WithEvents TxtBxNewName As TextBox
    Friend WithEvents BTNNewFilename As Button
    Friend WithEvents BTNReadFiles As Button
End Class
