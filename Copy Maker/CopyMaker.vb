Imports System.IO

Public Class CopyMaker
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowseSourceFile.Click
        If dbLoadFile.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            txtPathSourceFile.Text = dbLoadFile.SafeFileName
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnExecute.Click

        If txtPathSourceFile.Text = "" Or txtPathOutputFolder.Text = "" Then
            MsgBox("Please select path first", vbCritical, "Error")
        Else
            Dim sourceFile As String = dbLoadFile.FileName

            'Creating folder with file name
            If Not System.IO.Directory.Exists(txtPathOutputFolder.Text + "/" + System.IO.Path.GetFileNameWithoutExtension(dbLoadFile.FileName)) Then
                System.IO.Directory.CreateDirectory(txtPathOutputFolder.Text + "/" + System.IO.Path.GetFileNameWithoutExtension(dbLoadFile.FileName))
            End If

            For Each strLine As String In txtNames.Text.Split(vbCrLf)

                Dim fileName As String = Trim(strLine)
                If fileName IsNot "" Then
                    Dim destinationFile As String = txtPathOutputFolder.Text + "/" + System.IO.Path.GetFileNameWithoutExtension(dbLoadFile.FileName) + "/" + fileName + Path.GetExtension(dbLoadFile.FileName)
                    clone(sourceFile, destinationFile)
                End If
            Next

            MsgBox("Task completed successfully", vbInformation, "Completed")

        End If

    End Sub

    Private Sub btnBrowseDestinationFolder_Click(sender As Object, e As EventArgs) Handles btnBrowseOutputFolder.Click
        If (dbFolderBrowser.ShowDialog() = DialogResult.OK) Then
            txtPathOutputFolder.Text = dbFolderBrowser.SelectedPath
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

End Class