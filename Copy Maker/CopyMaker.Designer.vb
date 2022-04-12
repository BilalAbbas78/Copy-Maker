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
        Me.lblOutputFolder = New System.Windows.Forms.Label()
        Me.lblPathOutputFolder = New System.Windows.Forms.Label()
        Me.btnBrowseOutputFolder = New System.Windows.Forms.Button()
        Me.dbFolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBrowseSourceFile
        '
        Me.btnBrowseSourceFile.BackColor = System.Drawing.Color.White
        Me.btnBrowseSourceFile.Location = New System.Drawing.Point(122, 28)
        Me.btnBrowseSourceFile.Name = "btnBrowseSourceFile"
        Me.btnBrowseSourceFile.Size = New System.Drawing.Size(94, 29)
        Me.btnBrowseSourceFile.TabIndex = 0
        Me.btnBrowseSourceFile.Text = "Browse"
        Me.btnBrowseSourceFile.UseVisualStyleBackColor = False
        '
        'lblPathSourceFile
        '
        Me.lblPathSourceFile.AutoSize = True
        Me.lblPathSourceFile.ForeColor = System.Drawing.Color.White
        Me.lblPathSourceFile.Location = New System.Drawing.Point(12, 58)
        Me.lblPathSourceFile.Name = "lblPathSourceFile"
        Me.lblPathSourceFile.Size = New System.Drawing.Size(45, 20)
        Me.lblPathSourceFile.TabIndex = 1
        Me.lblPathSourceFile.Text = "None"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(182, 493)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(94, 29)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtNames
        '
        Me.txtNames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNames.Location = New System.Drawing.Point(12, 179)
        Me.txtNames.Multiline = True
        Me.txtNames.Name = "txtNames"
        Me.txtNames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNames.Size = New System.Drawing.Size(438, 293)
        Me.txtNames.TabIndex = 2
        '
        'lblSourceFile
        '
        Me.lblSourceFile.AutoSize = True
        Me.lblSourceFile.ForeColor = System.Drawing.Color.White
        Me.lblSourceFile.Location = New System.Drawing.Point(12, 32)
        Me.lblSourceFile.Name = "lblSourceFile"
        Me.lblSourceFile.Size = New System.Drawing.Size(84, 20)
        Me.lblSourceFile.TabIndex = 4
        Me.lblSourceFile.Text = "Source File:"
        '
        'lblOutputFolder
        '
        Me.lblOutputFolder.AutoSize = True
        Me.lblOutputFolder.ForeColor = System.Drawing.Color.White
        Me.lblOutputFolder.Location = New System.Drawing.Point(12, 94)
        Me.lblOutputFolder.Name = "lblOutputFolder"
        Me.lblOutputFolder.Size = New System.Drawing.Size(104, 20)
        Me.lblOutputFolder.TabIndex = 7
        Me.lblOutputFolder.Text = "Output Folder:"
        '
        'lblPathOutputFolder
        '
        Me.lblPathOutputFolder.AutoSize = True
        Me.lblPathOutputFolder.ForeColor = System.Drawing.Color.White
        Me.lblPathOutputFolder.Location = New System.Drawing.Point(12, 120)
        Me.lblPathOutputFolder.Name = "lblPathOutputFolder"
        Me.lblPathOutputFolder.Size = New System.Drawing.Size(45, 20)
        Me.lblPathOutputFolder.TabIndex = 6
        Me.lblPathOutputFolder.Text = "None"
        '
        'btnBrowseOutputFolder
        '
        Me.btnBrowseOutputFolder.BackColor = System.Drawing.Color.White
        Me.btnBrowseOutputFolder.Location = New System.Drawing.Point(122, 90)
        Me.btnBrowseOutputFolder.Name = "btnBrowseOutputFolder"
        Me.btnBrowseOutputFolder.Size = New System.Drawing.Size(94, 29)
        Me.btnBrowseOutputFolder.TabIndex = 1
        Me.btnBrowseOutputFolder.Text = "Browse"
        Me.btnBrowseOutputFolder.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Input File Names:"
        '
        'CopyMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(476, 534)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblOutputFolder)
        Me.Controls.Add(Me.lblPathOutputFolder)
        Me.Controls.Add(Me.btnBrowseOutputFolder)
        Me.Controls.Add(Me.lblSourceFile)
        Me.Controls.Add(Me.txtNames)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblPathSourceFile)
        Me.Controls.Add(Me.btnBrowseSourceFile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
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
    Friend WithEvents lblOutputFolder As Label
    Friend WithEvents lblPathOutputFolder As Label
    Friend WithEvents btnBrowseOutputFolder As Button
    Friend WithEvents dbFolderBrowser As FolderBrowserDialog
    Friend WithEvents Label1 As Label
End Class
