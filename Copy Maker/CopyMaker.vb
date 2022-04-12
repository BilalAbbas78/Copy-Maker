Imports System.Text
Imports System.IO

Public Class CopyMaker
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If dbLoadFile.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            lblLoadFile.Text = dbLoadFile.SafeFileName
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If lblLoadFile.Text = "None" Then
            MsgBox("Please select path first", vbCritical, "Error")
        End If


        Dim sourceFile As String = dbLoadFile.FileName

        For Each strLine As String In txtNames.Text.Split(vbNewLine)
            'TextBox1.Text &= strLine & Environment.NewLine

            Dim fileName As String = Trim(strLine)
            If fileName IsNot "" Then

                'TextBox1.AppendText(i & Environment.NewLine)


                Dim destinationFile As String = "D:\" + fileName + Path.GetExtension(dbLoadFile.FileName)
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
End Class