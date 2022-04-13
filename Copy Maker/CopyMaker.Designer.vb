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
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.txtNames = New System.Windows.Forms.TextBox()
        Me.btnBrowseOutputFolder = New System.Windows.Forms.Button()
        Me.dbFolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPathSourceFile = New System.Windows.Forms.TextBox()
        Me.txtPathOutputFolder = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBrowseSourceFile
        '
        Me.btnBrowseSourceFile.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnBrowseSourceFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBrowseSourceFile.ForeColor = System.Drawing.Color.White
        Me.btnBrowseSourceFile.Location = New System.Drawing.Point(423, 90)
        Me.btnBrowseSourceFile.Name = "btnBrowseSourceFile"
        Me.btnBrowseSourceFile.Size = New System.Drawing.Size(154, 27)
        Me.btnBrowseSourceFile.TabIndex = 0
        Me.btnBrowseSourceFile.Text = "COPY FILE"
        Me.btnBrowseSourceFile.UseVisualStyleBackColor = False
        '
        'btnExecute
        '
        Me.btnExecute.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnExecute.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExecute.ForeColor = System.Drawing.Color.White
        Me.btnExecute.Location = New System.Drawing.Point(599, 111)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(103, 33)
        Me.btnExecute.TabIndex = 3
        Me.btnExecute.Text = "EXECUTE"
        Me.btnExecute.UseVisualStyleBackColor = False
        '
        'txtNames
        '
        Me.txtNames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNames.ForeColor = System.Drawing.Color.Black
        Me.txtNames.Location = New System.Drawing.Point(12, 207)
        Me.txtNames.Multiline = True
        Me.txtNames.Name = "txtNames"
        Me.txtNames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNames.Size = New System.Drawing.Size(709, 293)
        Me.txtNames.TabIndex = 2
        '
        'btnBrowseOutputFolder
        '
        Me.btnBrowseOutputFolder.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnBrowseOutputFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBrowseOutputFolder.ForeColor = System.Drawing.Color.White
        Me.btnBrowseOutputFolder.Location = New System.Drawing.Point(423, 132)
        Me.btnBrowseOutputFolder.Name = "btnBrowseOutputFolder"
        Me.btnBrowseOutputFolder.Size = New System.Drawing.Size(154, 27)
        Me.btnBrowseOutputFolder.TabIndex = 1
        Me.btnBrowseOutputFolder.Text = "OUTPUT LOCATION"
        Me.btnBrowseOutputFolder.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Paste output file names here ..."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.RoyalBlue
        Me.PictureBox1.Location = New System.Drawing.Point(-15, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(760, 57)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(293, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 35)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Copy Maker"
        '
        'txtPathSourceFile
        '
        Me.txtPathSourceFile.BackColor = System.Drawing.Color.White
        Me.txtPathSourceFile.Location = New System.Drawing.Point(12, 90)
        Me.txtPathSourceFile.Name = "txtPathSourceFile"
        Me.txtPathSourceFile.ReadOnly = True
        Me.txtPathSourceFile.Size = New System.Drawing.Size(405, 27)
        Me.txtPathSourceFile.TabIndex = 11
        '
        'txtPathOutputFolder
        '
        Me.txtPathOutputFolder.BackColor = System.Drawing.Color.White
        Me.txtPathOutputFolder.Location = New System.Drawing.Point(12, 132)
        Me.txtPathOutputFolder.Name = "txtPathOutputFolder"
        Me.txtPathOutputFolder.ReadOnly = True
        Me.txtPathOutputFolder.Size = New System.Drawing.Size(405, 27)
        Me.txtPathOutputFolder.TabIndex = 12
        '
        'CopyMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(733, 518)
        Me.Controls.Add(Me.txtPathOutputFolder)
        Me.Controls.Add(Me.txtPathSourceFile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBrowseOutputFolder)
        Me.Controls.Add(Me.txtNames)
        Me.Controls.Add(Me.btnExecute)
        Me.Controls.Add(Me.btnBrowseSourceFile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CopyMaker"
        Me.Text = "Copy Maker"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBrowseSourceFile As Button
    Friend WithEvents dbLoadFile As OpenFileDialog
    Friend WithEvents btnExecute As Button
    Friend WithEvents txtNames As TextBox
    Friend WithEvents btnBrowseOutputFolder As Button
    Friend WithEvents dbFolderBrowser As FolderBrowserDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPathSourceFile As TextBox
    Friend WithEvents txtPathOutputFolder As TextBox
End Class
