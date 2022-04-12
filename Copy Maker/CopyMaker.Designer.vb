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
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.dbLoadFile = New System.Windows.Forms.OpenFileDialog()
        Me.lblLoadFile = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtNames = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(44, 98)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(94, 29)
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'dbLoadFile
        '
        Me.dbLoadFile.FileName = "OpenFileDialog1"
        '
        'lblLoadFile
        '
        Me.lblLoadFile.AutoSize = True
        Me.lblLoadFile.Location = New System.Drawing.Point(167, 102)
        Me.lblLoadFile.Name = "lblLoadFile"
        Me.lblLoadFile.Size = New System.Drawing.Size(45, 20)
        Me.lblLoadFile.TabIndex = 1
        Me.lblLoadFile.Text = "None"
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
        Me.txtNames.Location = New System.Drawing.Point(44, 149)
        Me.txtNames.Multiline = True
        Me.txtNames.Name = "txtNames"
        Me.txtNames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNames.Size = New System.Drawing.Size(282, 229)
        Me.txtNames.TabIndex = 3
        '
        'CopyMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtNames)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblLoadFile)
        Me.Controls.Add(Me.btnBrowse)
        Me.Name = "CopyMaker"
        Me.Text = "Copy Maker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBrowse As Button
    Friend WithEvents dbLoadFile As OpenFileDialog
    Friend WithEvents lblLoadFile As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents txtNames As TextBox
End Class
