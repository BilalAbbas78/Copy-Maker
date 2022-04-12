<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CopyMaker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnBrowseSourceFile = New System.Windows.Forms.Button()
        Me.dbLoadFile = New System.Windows.Forms.OpenFileDialog()
        Me.lblPathSourceFile = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtNames = New System.Windows.Forms.TextBox()
        Me.lblSourceFile = New System.Windows.Forms.Label()
        Me.lblDestinationFolder = New System.Windows.Forms.Label()
        Me.lblPathDestinationFolder = New System.Windows.Forms.Label()
        Me.btnBrowseDestinationFolder = New System.Windows.Forms.Button()
        Me.dbFolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'btnBrowseSourceFile
        '
        Me.btnBrowseSourceFile.Location = New System.Drawing.Point(163, 28)
        Me.btnBrowseSourceFile.Name = "btnBrowseSourceFile"
        Me.btnBrowseSourceFile.Size = New System.Drawing.Size(94, 29)
        Me.btnBrowseSourceFile.TabIndex = 0
        Me.btnBrowseSourceFile.Text = "Browse"
        Me.btnBrowseSourceFile.UseVisualStyleBackColor = True
        '
        'dbLoadFile
        '
        Me.dbLoadFile.FileName = "OpenFileDialog1"
        '
        'lblPathSourceFile
        '
        Me.lblPathSourceFile.AutoSize = True
        Me.lblPathSourceFile.Location = New System.Drawing.Point(281, 32)
        Me.lblPathSourceFile.Name = "lblPathSourceFile"
        Me.lblPathSourceFile.Size = New System.Drawing.Size(45, 20)
        Me.lblPathSourceFile.TabIndex = 1
        Me.lblPathSourceFile.Text = "None"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(560, 255)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(94, 29)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtNames
        '
        Me.txtNames.Location = New System.Drawing.Point(23, 147)
        Me.txtNames.Multiline = True
        Me.txtNames.Name = "txtNames"
        Me.txtNames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNames.Size = New System.Drawing.Size(282, 229)
        Me.txtNames.TabIndex = 3
        '
        'lblSourceFile
        '
        Me.lblSourceFile.AutoSize = True
        Me.lblSourceFile.Location = New System.Drawing.Point(23, 32)
        Me.lblSourceFile.Name = "lblSourceFile"
        Me.lblSourceFile.Size = New System.Drawing.Size(84, 20)
        Me.lblSourceFile.TabIndex = 4
        Me.lblSourceFile.Text = "Source File:"
        '
        'lblDestinationFolder
        '
        Me.lblDestinationFolder.AutoSize = True
        Me.lblDestinationFolder.Location = New System.Drawing.Point(23, 67)
        Me.lblDestinationFolder.Name = "lblDestinationFolder"
        Me.lblDestinationFolder.Size = New System.Drawing.Size(134, 20)
        Me.lblDestinationFolder.TabIndex = 7
        Me.lblDestinationFolder.Text = "Destination Folder:"
        '
        'lblPathDestinationFolder
        '
        Me.lblPathDestinationFolder.AutoSize = True
        Me.lblPathDestinationFolder.Location = New System.Drawing.Point(281, 67)
        Me.lblPathDestinationFolder.Name = "lblPathDestinationFolder"
        Me.lblPathDestinationFolder.Size = New System.Drawing.Size(45, 20)
        Me.lblPathDestinationFolder.TabIndex = 6
        Me.lblPathDestinationFolder.Text = "None"
        '
        'btnBrowseDestinationFolder
        '
        Me.btnBrowseDestinationFolder.Location = New System.Drawing.Point(163, 63)
        Me.btnBrowseDestinationFolder.Name = "btnBrowseDestinationFolder"
        Me.btnBrowseDestinationFolder.Size = New System.Drawing.Size(94, 29)
        Me.btnBrowseDestinationFolder.TabIndex = 5
        Me.btnBrowseDestinationFolder.Text = "Browse"
        Me.btnBrowseDestinationFolder.UseVisualStyleBackColor = True
        '
        'CopyMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblDestinationFolder)
        Me.Controls.Add(Me.lblPathDestinationFolder)
        Me.Controls.Add(Me.btnBrowseDestinationFolder)
        Me.Controls.Add(Me.lblSourceFile)
        Me.Controls.Add(Me.txtNames)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblPathSourceFile)
        Me.Controls.Add(Me.btnBrowseSourceFile)
        Me.Name = "CopyMaker"
        Me.Text = "Copy Maker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBrowseSourceFile As Button
    Friend WithEvents dbLoadFile As OpenFileDialog
    Friend WithEvents lblPathSourceFile As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents txtNames As TextBox
    Friend WithEvents lblSourceFile As Label
    Friend WithEvents lblDestinationFolder As Label
    Friend WithEvents lblPathDestinationFolder As Label
    Friend WithEvents btnBrowseDestinationFolder As Button
    Friend WithEvents dbFolderBrowser As FolderBrowserDialog
End Class
