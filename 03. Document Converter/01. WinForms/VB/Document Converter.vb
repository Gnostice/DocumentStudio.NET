Imports Gnostice.Core
Imports Gnostice.Converter
Imports Gnostice.Documents
Imports System.Threading
Imports Gnostice.Documents.Image
Imports Gnostice.Documents.PDF

Public Class Demo

    Private Cancel As Boolean
    Private WithEvents DocConverter As DocumentConverter
    Private inputDocuments As List(Of String)
    Private outputFileFormat As String
    'Private merge As Boolean
    Private conversionMode As ConversionMode
    Private baseFileName As String
    Private outputDocDirectory As String
    Private ConverterSettings As ConverterSettings = Nothing
    Private EncoderSettings As EncoderSettings = Nothing
    Private inputDocPassword As String
    Private passwordAttempt As Integer
    Private currentFileIndex As Integer = 0
    Private prompt As Form = Nothing
    Private password As System.Windows.Forms.TextBox = Nothing
    Private WithEvents confirmation As Button
    Private WithEvents cancelBtn As Button
    Private errorMessage As String


    Private Sub Demo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbBxOutputFormat.SelectedIndex = 0
        cmbConversionMode.SelectedIndex = 0
    End Sub

    Private Sub EnableOrDisableButtons()
        If lstBxInputDocList.Items.Count = 0 Then
            btnRemove.Enabled = False
            btnUp.Enabled = False
            btnDown.Enabled = False
            btnConvert.Enabled = False
            Return
        Else
            btnRemove.Enabled = True
            btnUp.Enabled = True
            btnDown.Enabled = True
            btnConvert.Enabled = True
        End If
        If lstBxInputDocList.SelectedIndex = 0 Then
            btnUp.Enabled = False
        ElseIf lstBxInputDocList.SelectedIndex = lstBxInputDocList.Items.Count - 1 Then
            btnDown.Enabled = False
        Else
            btnUp.Enabled = True
            btnDown.Enabled = True
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'Add Files to Input List
        Try
            If openFile.ShowDialog = DialogResult.OK Then
                'Get all the Files selected
                For Each fileName As String In openFile.FileNames
                    lstBxInputDocList.Items.Add(fileName)
                Next
                'Point to last file in the list
                lstBxInputDocList.SelectedIndex = lstBxInputDocList.Items.Count - 1
                'Check for enabling or disabling of buttons
                EnableOrDisableButtons()
                lstBxInputDocList.Focus()
                'If Output Folder is not specified set default directory
                If txtBxOutputFolder.Text = String.Empty Then
                    txtBxOutputFolder.Text = System.IO.Path.GetDirectoryName(lstBxInputDocList.Items(lstBxInputDocList.Items.Count - 1).ToString())
                    folderBrowser.SelectedPath = txtBxOutputFolder.Text
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        'Remove a file from List
        Try
            'Retaining SelectedIndex
            Dim selectedIndex As Integer = lstBxInputDocList.SelectedIndex
            Try
                lstBxInputDocList.Items.Remove(lstBxInputDocList.SelectedItem)
                If selectedIndex <> 0 Then
                    lstBxInputDocList.SelectedIndex = selectedIndex
                ElseIf lstBxInputDocList.Items.Count <> 0 Then
                    lstBxInputDocList.SelectedIndex = 0
                End If
            Catch ex As Exception
                lstBxInputDocList.SelectedIndex = 0
            End Try
            lstBxInputDocList.Focus()
            EnableOrDisableButtons()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        'Move Selected File 1 step Upwards
        Dim selectedIndex As Integer = lstBxInputDocList.SelectedIndex
        Dim listItem As Object = lstBxInputDocList.SelectedItem
        If selectedIndex <> 0 Then
            lstBxInputDocList.Items.Remove(lstBxInputDocList.SelectedItem)
            lstBxInputDocList.Items.Insert(selectedIndex - 1, listItem)
            lstBxInputDocList.SelectedIndex = selectedIndex - 1
        End If
        lstBxInputDocList.Focus()
        EnableOrDisableButtons()
    End Sub

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        ' Move Selected File 1 step Downwards
        Dim selectedIndex As Integer = lstBxInputDocList.SelectedIndex
        Dim listItem As Object = lstBxInputDocList.SelectedItem
        If selectedIndex <> lstBxInputDocList.Items.Count - 1 Then
            lstBxInputDocList.Items.Remove(lstBxInputDocList.SelectedItem)
            lstBxInputDocList.Items.Insert(selectedIndex + 1, listItem)
            lstBxInputDocList.SelectedIndex = selectedIndex + 1
        End If
        lstBxInputDocList.Focus()
        EnableOrDisableButtons()
    End Sub

    Private Sub lstBxInputDocList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstBxInputDocList.SelectedIndexChanged
        ' Check for enabling or disabling of buttons
        EnableOrDisableButtons()
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        ' Select a directory to set as OutputDocDirectory
        If folderBrowser.ShowDialog() = DialogResult.OK Then
            txtBxOutputFolder.Text = folderBrowser.SelectedPath
            EnableOrDisableButtons()
        End If
    End Sub

    Private Sub performConversion()
        'New thread to perform conversion
        Try
            DocConverter.ConvertToFile(inputDocuments, outputFileFormat, outputDocDirectory, baseFileName, conversionMode, EncoderSettings, ConverterSettings, inputDocPassword)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'If Operation was Cancelled.
        If Cancel Then
            MessageBox.Show("Operation canceled")
        End If
        'Restore Default for next Conversion
        Cancel = False
        Animate(False)
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Sub() pages.Text = String.Empty))
            Me.Invoke(New Action(Sub() fileName.Text = String.Empty))
            Me.Invoke(New Action(Sub() documents.Text = String.Empty))
            Me.Invoke(New Action(Sub() btnConvert.Enabled = True))
            Me.Invoke(New Action(Sub() btnCancel.Enabled = False))
            Me.Invoke(New Action(Sub() prgsBrPageProgress.Value = 0))
            Me.Invoke(New Action(Sub() prgsBrOverallProgress.Value = 0))
        Else
            pages.Text = String.Empty
            fileName.Text = String.Empty
            documents.Text = String.Empty
            btnConvert.Enabled = True
            btnCancel.Enabled = False
            prgsBrPageProgress.Value = 0
            prgsBrOverallProgress.Value = 0
        End If
        ' Exit from Current Thread
        Application.ExitThread()
    End Sub

    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        errorMessage = String.Empty
        btnConvert.Enabled = False
        'Hide the Start Button and show the Progress Bars
        Animate(True)
        btnCancel.Enabled = True
        'Input Documents
        inputDocuments = New List(Of String)
        For Each fileName As String In lstBxInputDocList.Items
            inputDocuments.Add(fileName)
        Next
        'Output Directory
        outputFileFormat = cmbBxOutputFormat.Text.ToLower()
        'Output File Format
        If outputFileFormat = "tiff single page" Or outputFileFormat = "tiff multipage" Then
            outputFileFormat = "tiff"
        End If
        'Default name for converted files
        baseFileName = txtBxBaseFileName.Text
        outputDocDirectory = txtBxOutputFolder.Text
        ConverterSettings = Nothing
        EncoderSettings = Nothing
        If cmbBxOutputFormat.Text = "TIFF Single Page" Then
            EncoderSettings = New TIFFEncoderSettings()
            CType(EncoderSettings, TIFFEncoderSettings).MultiPage = False
        ElseIf cmbBxOutputFormat.Text = "TIFF Multipage" Then
            EncoderSettings = New TIFFEncoderSettings()
            CType(EncoderSettings, TIFFEncoderSettings).MultiPage = True
        End If
        ''Merging of files
        'merge = False
        'If chckBxMerge.Checked Then
        '    merge = True
        'End If
        Select Case cmbConversionMode.SelectedIndex
            Case 0
                conversionMode = ConversionMode.ConvertToSingleFile
            Case 1
                conversionMode = ConversionMode.ConvertToSeperateFiles
            Case 2
                conversionMode = ConversionMode.ConvertFirstFileAndAttachRestAsOriginal
                If cmbBxOutputFormat.Text = "PDF" And chkCreatePortfolio.Checked Then
                    EncoderSettings = New PDFEncoderSettings()
                    CType(EncoderSettings, PDFEncoderSettings).PDFPortfolioSettings.PortfolioCreationMode = PortfolioCreationMode.OnlyWhenAttachmentsExist
                End If
            Case 3
                conversionMode = ConversionMode.CreateNewFileAndAttachAllAsOriginal
                If cmbBxOutputFormat.Text = "PDF" And chkCreatePortfolio.Checked Then
                    EncoderSettings = New PDFEncoderSettings()
                    CType(EncoderSettings, PDFEncoderSettings).PDFPortfolioSettings.PortfolioCreationMode = PortfolioCreationMode.Always
                End If
        End Select

        inputDocPassword = String.Empty
        'Instance of Document Converter
        DocConverter = New DocumentConverter()
        AddHandler DocConverter.BeginJob, AddressOf DocConverter_StartJob
        AddHandler DocConverter.BeginDocument, AddressOf DocConverter_StartDocument
        AddHandler DocConverter.BeginPage, AddressOf DocConverter_StartPage
        AddHandler DocConverter.EndPage, AddressOf DocConverter_EndPage
        AddHandler DocConverter.EndDocument, AddressOf DocConverter_EndDocument
        AddHandler DocConverter.EndJob, AddressOf DocConverter_EndJob
        AddHandler DocConverter.NeedPassword, AddressOf DocConverter_NeedPassword
        AddHandler DocConverter.Error, AddressOf DocConverter_Error
        Try
            Dim conversion As Thread = New Thread(New ThreadStart(AddressOf performConversion))
            conversion.Start()
        Catch ex As Exception
            DocConverter.Dispose()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DocConverter_Error(ByVal sender As Object, ByVal e As ConverterErrorEventArgs)
        errorMessage += "\r\n\r\n"
        errorMessage += inputDocuments(e.InputDocumentIndex)
        errorMessage += "\r\n" + e.ErrorMessage
    End Sub

    Private Sub DocConverter_NeedPassword(ByVal sender As Object, ByVal e As NeedPasswordEventArgs)
        passwordAttempt = passwordAttempt + 1
        If passwordAttempt >= 4 Then
            e.Cancel = True
            Return
        End If
        inputDocPassword = ShowNeedPasswordDialog("Please enter password to open '" + System.IO.Path.GetFileName(lstBxInputDocList.Items(currentFileIndex).ToString()) + "'", "Gnostice Document Studio .NET - Need Password")
        e.Password = inputDocPassword
    End Sub

    Private Function ShowNeedPasswordDialog(ByVal text As String, ByVal caption As String) As String
        prompt = New Form()
        prompt.Width = 430
        prompt.Height = 125
        prompt.Text = caption
        prompt.ControlBox = False
        prompt.FormBorderStyle = FormBorderStyle.Fixed3D
        prompt.StartPosition = FormStartPosition.CenterScreen
        Dim textLabel As Label = New Label()
        textLabel.Left = 10
        textLabel.Top = 10
        textLabel.Text = text
        textLabel.AutoSize = True
        password = New System.Windows.Forms.TextBox()
        password.Left = 10
        password.Top = 30
        password.Width = 400
        password.PasswordChar = "*"
        confirmation = New Button()
        confirmation.Name = "confirmation"
        confirmation.Text = "&Ok"
        confirmation.Left = 190
        confirmation.Width = 100
        confirmation.Top = 60
        cancelBtn = New Button()
        cancelBtn.Name = "cancelBtn"
        cancelBtn.Text = "&Cancel"
        cancelBtn.Left = 310
        cancelBtn.Width = 100
        cancelBtn.Top = 60
        password.TabIndex = 0
        confirmation.TabIndex = 1
        cancelBtn.TabIndex = 2
        prompt.AcceptButton = confirmation
        prompt.CancelButton = cancelBtn
        AddHandler confirmation.Click, AddressOf confirmation_Click
        AddHandler cancelBtn.Click, AddressOf cancelBtn_Click
        prompt.Controls.Add(confirmation)
        prompt.Controls.Add(password)
        prompt.Controls.Add(cancelBtn)
        prompt.Controls.Add(textLabel)
        prompt.Focus()
        If prompt.IsDisposed = False Then
            prompt.ShowDialog()
        End If
        Return password.Text
    End Function

    Private Sub confirmation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles confirmation.Click
        prompt.Close()
    End Sub

    Private Sub cancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelBtn.Click
        password.Text = String.Empty
        prompt.Close()
    End Sub

    Private Sub Animate(ByVal flag As Boolean)
        'To Show Progress Bar
        If flag Then
            For i As Integer = 0 To 529
                grpBxProgress.Left += 1
                Me.Update()
            Next
        Else ' Hide Progress Bar
            For i As Integer = 0 To 529
                Me.Invoke(New Action(Sub() grpBxProgress.Left -= 1))
                Me.Invoke(New Action(Sub() Me.Update()))
            Next
        End If
    End Sub

    Private Sub DocConverter_EndJob(ByVal sender As Object, ByVal e As ConverterEndJobEventArgs)
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Sub() prgsBrPageProgress.Value = 100))
            Me.Invoke(New Action(Sub() prgsBrOverallProgress.Value = 100))
            Me.Invoke(New Action(Sub() Me.Update()))
        Else
            prgsBrPageProgress.Value = 100
            prgsBrOverallProgress.Value = 100
            Me.Update()
        End If
        If Cancel = False Then 'If Conversion is completed Successfully
            MessageBox.Show("Conversion Completed" + errorMessage)
            errorMessage = String.Empty
        End If
        DocConverter.Dispose()
    End Sub

    Private Sub DocConverter_EndDocument(ByVal sender As Object, ByVal e As ConverterEndDocumentEventArgs)
        'Calculate and Fill the progressbar
        Dim totalDocument As Integer = e.JobInfo.InputDocumentCount
        Dim inputIndex As Integer = e.InputDocument.InputIndex
        Dim percent As Integer = inputIndex * 100 / totalDocument
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Sub() prgsBrOverallProgress.Value = percent))
            Me.Invoke(New Action(Sub() Me.Update()))
        Else
            prgsBrOverallProgress.Value = percent
            Me.Update()
        End If
    End Sub

    Private Sub DocConverter_EndPage(ByVal sender As Object, ByVal e As ConverterEndPageEventArgs)
        'Fill Overall and Current Job Progress Bar
        Dim pageCount As Integer = e.InputDocument.PageCount
        Dim pageNumber As Integer = e.InputPageNumber
        Dim totalDocument As Integer = e.JobInfo.InputDocumentCount
        Dim inputIndex As Integer = e.InputDocument.InputIndex
        Dim percent As Integer = pageNumber * 100 / pageCount
        Dim percentage As Integer = (inputIndex - 1) * 100 / totalDocument
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Sub() prgsBrPageProgress.Value = percent))
            Me.Invoke(New Action(Sub() prgsBrOverallProgress.Value = percentage + percent / totalDocument))
            Me.Invoke(New Action(Sub() Me.Update()))
        Else

            ' Progress bar for current Job
            prgsBrPageProgress.Value = percent

            ' Update Overall Progress bar alone with pages.
            prgsBrOverallProgress.Value = percentage + percent / totalDocument
            Me.Update()
        End If
    End Sub

    Private Sub DocConverter_StartPage(ByVal sender As Object, ByVal e As ConverterBeginPageEventArgs)
        ' Update current page Number to be converted
        e.Cancel = Cancel
        Dim pageCount As Integer = e.InputDocument.PageCount
        Dim pageNumber As Integer = e.InputPageNumber
        Dim message As String = "Page(s) done: " + pageNumber.ToString() + " of " + pageCount.ToString()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Sub() pages.Text = message))
            Me.Invoke(New Action(Sub() pages.Location = New Point(404 - pages.Width, pages.Location.Y)))
            Me.Invoke(New Action(Sub() Me.Update()))
        Else
            pages.Text = message
            pages.Location = New Point(404 - pages.Width, pages.Location.Y)
            Me.Update()
        End If
    End Sub

    Private Sub DocConverter_StartDocument(ByVal sender As Object, ByVal e As ConverterBeginDocumentEventArgs)
        'set the current file name  
        e.Cancel = Cancel
        currentFileIndex = currentFileIndex + 1
        passwordAttempt = 0
        Dim totalDocument As Integer = e.JobInfo.InputDocumentCount
        Dim inputIndex As Integer = e.InputDocument.InputIndex
        Dim currentFileName As String = e.InputDocument.FileName
        Dim message As String = "Document(s) done : " + inputIndex.ToString() + " of " + totalDocument.ToString()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Sub() documents.Text = message))
            Dim startPosition As Integer = 404 - documents.Width
            Me.Invoke(New Action(Sub() documents.Location = New Point(startPosition, documents.Location.Y)))
            Dim len As Integer = (startPosition - 35 - fileName.Location.X) / 5
            If currentFileName.Length > len Then
                Dim filename As String = "...\" + System.IO.Path.GetFileNameWithoutExtension(currentFileName) + System.IO.Path.GetExtension(currentFileName)
                Dim remainingCharacters As Integer = len - filename.Length
                If remainingCharacters > 0 Then
                    currentFileName = currentFileName.Substring(0, remainingCharacters - 1) + filename
                Else
                    currentFileName = filename.Substring(0, len)
                End If
            End If
            Me.Invoke(New Action(Sub() fileName.Text = currentFileName))
            Me.Invoke(New Action(Sub() Me.Update()))
        Else
            documents.Text = message
            Dim startPosition As Integer = 404 - documents.Width
            documents.Location = New Point(startPosition, documents.Location.Y)
            Dim Len As Integer = (startPosition - 35 - fileName.Location.X) / 5
            If currentFileName.Length > Len Then
                Dim filename As String = "...\" + System.IO.Path.GetFileNameWithoutExtension(currentFileName) + System.IO.Path.GetExtension(currentFileName)
                Dim remainingCharacters As Integer = Len - filename.Length
                If remainingCharacters > 0 Then
                    currentFileName = currentFileName.Substring(0, remainingCharacters - 1) + filename
                Else
                    currentFileName = filename.Substring(0, Len)
                End If
            End If
            fileName.Text = currentFileName
            Me.Update()
        End If
    End Sub

    Private Sub DocConverter_StartJob(ByVal sender As Object, ByVal e As ConverterBeginJobEventArgs)
        e.Cancel = Cancel
        currentFileIndex = 0
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Sub() prgsBrPageProgress.Value = 0))
            Me.Invoke(New Action(Sub() prgsBrOverallProgress.Value = 0))
            Me.Invoke(New Action(Sub() Me.Update()))
        Else
            prgsBrPageProgress.Value = 0
            prgsBrOverallProgress.Value = 0
            Me.Update()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'Cancel the Operation
        Cancel = True
    End Sub

    Private Sub cmbBxOutputFormat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBxOutputFormat.SelectedIndexChanged
        If cmbBxOutputFormat.Text = "PDF" And (cmbConversionMode.SelectedIndex = 2 Or cmbConversionMode.SelectedIndex = 3) Then
            chkCreatePortfolio.Visible = True
        Else
            chkCreatePortfolio.Visible = False
        End If
    End Sub

    Private Sub cmbConversionMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbConversionMode.SelectedIndexChanged
        If cmbBxOutputFormat.Text = "PDF" And (cmbConversionMode.SelectedIndex = 2 Or cmbConversionMode.SelectedIndex = 3) Then
            chkCreatePortfolio.Visible = True
        Else
            chkCreatePortfolio.Visible = False
        End If
    End Sub
End Class
