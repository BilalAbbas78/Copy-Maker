Imports System.IO

Public Class CopyMaker
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowseSourceFile.Click
        If dbLoadFile.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            lblPathSourceFile.Text = dbLoadFile.SafeFileName
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If lblPathSourceFile.Text = "None" Or lblPathOutputFolder.Text = "None" Then
            MsgBox("Please select path first", vbCritical, "Error")
        Else
            Dim sourceFile As String = dbLoadFile.FileName

            'Creating folder with file name
            If Not System.IO.Directory.Exists(lblPathOutputFolder.Text + "/" + System.IO.Path.GetFileNameWithoutExtension(dbLoadFile.FileName)) Then
                System.IO.Directory.CreateDirectory(lblPathOutputFolder.Text + "/" + System.IO.Path.GetFileNameWithoutExtension(dbLoadFile.FileName))
            End If

            For Each strLine As String In txtNames.Text.Split(vbCrLf)

                Dim fileName As String = Trim(strLine)
                If fileName IsNot "" Then
                    Dim destinationFile As String = lblPathOutputFolder.Text + "/" + System.IO.Path.GetFileNameWithoutExtension(dbLoadFile.FileName) + "/" + fileName + Path.GetExtension(dbLoadFile.FileName)
                    clone(sourceFile, destinationFile)
                End If
            Next
        End If

    End Sub

    Private Function clone(sourceFile As String, destinationFile As String)
        Dim fi As New IO.FileInfo(sourceFile)
        Try
            fi.CopyTo(destinationFile, True)
        Catch iox As IOException
            Console.WriteLine(iox.Message)
        End Try
        Return Nothing
    End Function

    Private Sub btnBrowseDestinationFolder_Click(sender As Object, e As EventArgs) Handles btnBrowseOutputFolder.Click
        If (dbFolderBrowser.ShowDialog() = DialogResult.OK) Then
            lblPathOutputFolder.Text = dbFolderBrowser.SelectedPath
        End If
    End Sub

End Class