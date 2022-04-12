Imports System.Text
Imports System.IO

Public Class CopyMaker
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowseSourceFile.Click
        If dbLoadFile.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            lblPathSourceFile.Text = dbLoadFile.SafeFileName
            'lblPathSourceFile.Text = System.IO.Path.GetFileNameWithoutExtension(dbLoadFile.FileName)


        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If lblPathSourceFile.Text = "None" Or lblPathDestinationFolder.Text = "None" Then
            MsgBox("Please select path first", vbCritical, "Error")
        Else
            Dim sourceFile As String = dbLoadFile.FileName


            'Creating folder with file name
            If Not System.IO.Directory.Exists(lblPathDestinationFolder.Text + "/" + System.IO.Path.GetFileNameWithoutExtension(dbLoadFile.FileName)) Then
                System.IO.Directory.CreateDirectory(lblPathDestinationFolder.Text + "/" + System.IO.Path.GetFileNameWithoutExtension(dbLoadFile.FileName))
            End If



            For Each strLine As String In txtNames.Text.Split(vbCrLf)
                'TextBox1.Text &= strLine & Environment.NewLine

                Dim fileName As String = Trim(strLine)
                If fileName IsNot "" Then

                    'TextBox1.AppendText(i & Environment.NewLine)


                    Dim destinationFile As String = lblPathDestinationFolder.Text + "/" + System.IO.Path.GetFileNameWithoutExtension(dbLoadFile.FileName) + "/" + fileName + Path.GetExtension(dbLoadFile.FileName)
                    clone(sourceFile, destinationFile)
                End If
            Next

            For Each i In txtNames.Text
                Dim fileName As String = i
                If fileName IsNot " " Then

                    'TextBox1.AppendText(i & Environment.NewLine)


                    'Dim destinationFile As String = "D:\" + fileName + Path.GetExtension(dbLoadFile.FileName)
                    'clone(sourceFile, destinationFile)
                End If

            Next
        End If


    End Sub

    Private Function clone(sourceFile As String, destinationFile As String)
        'Dim fileName As String = dbLoadFile.FileName

        Dim fi As New IO.FileInfo(sourceFile)
        'Dim destinationFile As String = "D:\"+ Copied + " + Path.GetExtension(dbLoadFile.FileName)
        Try
            fi.CopyTo(destinationFile, True)
        Catch iox As IOException
            Console.WriteLine(iox.Message)
        End Try
    End Function

    Private Sub btnBrowseDestinationFolder_Click(sender As Object, e As EventArgs) Handles btnBrowseDestinationFolder.Click
        If (dbFolderBrowser.ShowDialog() = DialogResult.OK) Then
            lblPathDestinationFolder.Text = dbFolderBrowser.SelectedPath
        End If




    End Sub

End Class