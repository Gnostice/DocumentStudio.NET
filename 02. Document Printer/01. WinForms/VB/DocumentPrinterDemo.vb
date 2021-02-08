Imports Gnostice.Controls.WinForms
Imports System.Drawing.Printing
Imports System.Threading
Imports System.IO
Imports Gnostice.Core.Viewer
Imports Gnostice.Core.Printer
Imports Gnostice.Core

Public Class DocumentPrinterDemo

    Dim docPrinter As DocumentPrinter
    Dim printerSettings As PrinterSettings = Nothing
    Dim inputDocPassword As String = String.Empty
    Dim printStatus As Form
    Dim totalPages As Integer = 0
    Private currentPage As Integer = 0
    Private passwordAttempt As Integer = 0
    Private cancel As Boolean = False
    Private LicenseKey As String = "B7CA-6EC9-0544-649C-2C48-E5CB-1EA2-B48A"
    Private btn As Button
    Private prgsbr As ProgressBar
    Private lbl As Label
    Private prompt As Form = Nothing
    Private password As TextBox = Nothing
    Private WithEvents confirmation As Button
    Private WithEvents cancelBtn As Button

    Private Sub docPrinter_StartPrintPage(ByVal sender As Object, ByVal e As PrinterBeginPreparePageEventArgs)
        e.Cancel = cancel
        currentPage = e.PrintJobPageNumber
    End Sub

    Private Sub docPrinter_StartPrintJob(ByVal sender As Object, ByVal e As PrinterBeginJobEventArgs)
        e.Cancel = cancel
        totalPages = e.PrintJobPageCount
    End Sub

    Private Sub docPrinter_EndPrintJob(ByVal sender As Object, ByVal e As PrinterEndJobEventArgs)
        If cancel Then
            MessageBox.Show("Printing Canceled")
        Else
            MessageBox.Show("Printing Completed")
        End If
        cancel = False
        Me.Invoke(New Action(Sub() printStatus.Close()))
    End Sub

    Private Sub docPrinter_EndPrintPage(ByVal sender As Object, ByVal e As PrinterEndPreparePageEventArgs)
        e.Cancel = cancel
        Dim percent As Integer = e.PrintJobPageNumber * 100 / e.PrintJobPageCount
        Me.Invoke(New Action(Sub() prgsbr.Value = percent))
        Me.Invoke(New Action(Sub() lbl.Text = "Sent Page " + currentPage.ToString() + " of " + totalPages.ToString() + " to printer."))
        Me.Invoke(New Action(Sub() printStatus.Update()))
    End Sub

    Private Sub docPrinter_NeedPassword(ByVal sender As Object, ByVal e As NeedPasswordEventArgs)
        passwordAttempt = passwordAttempt + 1
        If passwordAttempt >= 4 Then
            e.Cancel = True
            Return
        End If
        inputDocPassword = ShowNeedPasswordDialog("Please enter password to open '" + System.IO.Path.GetFileName(txtInputFilePath.Text) + "'", "Gnostice Document Studio .NET - Need Password")
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
        password = New TextBox()
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

    Private Sub DocumentPrinterDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        docPrinter = New DocumentPrinter()
        AddHandler documentViewer.NeedPassword, AddressOf docPrinter_NeedPassword
        AddHandler docPrinter.BeginJob, AddressOf docPrinter_StartPrintJob
        AddHandler docPrinter.EndPreparePage, AddressOf docPrinter_EndPrintPage
        AddHandler docPrinter.EndJob, AddressOf docPrinter_EndPrintJob
        AddHandler docPrinter.BeginPreparePage, AddressOf docPrinter_StartPrintPage
        AddHandler txtInputFilePath.Click, AddressOf txtInputFilePath_Click
        AddHandler documentViewer.Click, AddressOf documentViewer_Click
        Dim tempPrinterSettings As PrinterSettings = New PrinterSettings()
        lblSelectedPrinter.Text = tempPrinterSettings.PrinterName
        cmbHorizontalPositioning.SelectedIndex = 0
        cmbVerticalPositioning.SelectedIndex = 0
        cmbScaling.SelectedIndex = 0
    End Sub

    Private Sub loadDocument()
        Me.Cursor = Cursors.WaitCursor
        passwordAttempt = 0
        Try
            'Dim file As Stream = New FileStream(txtInputFilePath.Text, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            documentViewer.LoadDocument(txtInputFilePath.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        If browseFile.ShowDialog() = DialogResult.OK Then
            txtInputFilePath.Text = browseFile.FileName
            loadDocument()
        End If
    End Sub

    Private Sub txtInputFilePath_Click(ByVal sender As Object, ByVal e As EventArgs)
        If browseFile.ShowDialog() = DialogResult.OK Then
            txtInputFilePath.Text = browseFile.FileName
            loadDocument()
        End If
    End Sub

    Private Sub documentViewer_Click(ByVal sender As Object, ByVal e As EventArgs)
        If browseFile.ShowDialog() = DialogResult.OK Then
            txtInputFilePath.Text = browseFile.FileName
            loadDocument()
        End If
    End Sub

    Private Sub btnSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetup.Click
        If printDialog1.ShowDialog() = DialogResult.OK Then
            printerSettings = printDialog1.PrinterSettings
            lblSelectedPrinter.Text = printerSettings.PrinterName
        End If
    End Sub

    Private Sub Print()
        Try
            docPrinter.Print(txtInputFilePath.Text, inputDocPassword)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.Invoke(New Action(Sub() printStatus.Close()))
            cancel = False
        End Try
        Application.ExitThread()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        'If documentViewer.IsDocumentLoaded = False Then
        'Return
        'End If
        Me.Enabled = False
        startPrinting()
    End Sub

    Private Sub startPrinting()
        printStatus = New Form()
        printStatus.ShowInTaskbar = False
        printStatus.ShowIcon = False
        printStatus.MinimizeBox = False
        printStatus.MaximizeBox = False
        printStatus.Width = 400
        printStatus.Height = 150
        printStatus.Padding = New System.Windows.Forms.Padding(0)
        currentPage = 0
        totalPages = 0
        lbl = New Label()
        lbl.Text = "Preparing..."
        lbl.Location = New Point(10, 20)
        lbl.AutoSize = True
        prgsbr = New ProgressBar()
        prgsbr.Value = 0
        prgsbr.Location = New Point(10, 40)
        prgsbr.Size = New System.Drawing.Size(360, 23)
        btn = New Button()
        AddHandler btn.Click, AddressOf btn_Click
        btn.Location = New Point(297, 75)
        btn.Text = "&Cancel"
        btn.TabIndex = 0
        printStatus.Controls.Add(prgsbr)
        printStatus.Controls.Add(lbl)
        printStatus.Controls.Add(btn)
        printStatus.CancelButton = btn
        printStatus.Text = "Printing Status"
        printStatus.StartPosition = FormStartPosition.CenterParent
        AddHandler printStatus.Shown, AddressOf printStatus_Shown
        AddHandler printStatus.FormClosed, AddressOf printStatus_FormClosed
        printStatus.ShowDialog()
    End Sub

    Private Sub btn_Click(ByVal sender As Object, ByVal e As EventArgs)
        cancel = True
    End Sub

    Private Sub printStatus_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        Me.Enabled = True
        totalPages = 0
        currentPage = 0
    End Sub

    Private Sub printStatus_Shown(ByVal sender As Object, ByVal e As EventArgs)
        'If documentViewer.IsDocumentLoaded = False Then
        'Return
        'End If
        If IsNothing(printerSettings) = False Then
            docPrinter.PrintDocument.PrinterSettings = printerSettings
        Else
            docPrinter.PrintDocument.PrinterSettings = New PrinterSettings()
        End If
        If chckAutoRotate.Checked Then
            docPrinter.AutoRotate = True
        End If
        Select Case cmbHorizontalPositioning.SelectedIndex
            Case 0
                docPrinter.PagePositioning.Horizontal = Printer.HPagePosition.Left
            Case 1
                docPrinter.PagePositioning.Horizontal = Printer.HPagePosition.Center
            Case 2
                docPrinter.PagePositioning.Horizontal = Printer.HPagePosition.Right
        End Select
        Select Case cmbVerticalPositioning.SelectedIndex
            Case 0
                docPrinter.PagePositioning.Vertical = Printer.VPagePosition.Top
            Case 1
                docPrinter.PagePositioning.Vertical = Printer.VPagePosition.Center
            Case 2
                docPrinter.PagePositioning.Vertical = Printer.VPagePosition.Bottom
        End Select
        Select Case cmbScaling.SelectedIndex
            Case 0
                docPrinter.PageScaling = Printer.PageScalingOptions.Original
            Case 1
                docPrinter.PageScaling = Printer.PageScalingOptions.Fit
            Case 2
                docPrinter.PageScaling = Printer.PageScalingOptions.ShrinkOverSizedPages
        End Select
        If rdbtnAll.Checked Then
            docPrinter.PageSelection.SelectionType = Printer.PageSelectionType.All
        ElseIf rdbtnEven.Checked Then
            docPrinter.PageSelection.SelectionType = Printer.PageSelectionType.Even
        ElseIf rdbtnOdd.Checked Then
            docPrinter.PageSelection.SelectionType = Printer.PageSelectionType.Odd
        ElseIf rdbtnSeletedRange.Checked Then
            docPrinter.PageSelection.SelectionType = Printer.PageSelectionType.CustomRange
            docPrinter.PageSelection.CustomRange = txtPageRange.Text
        End If
        docPrinter.PrintDocument.PrinterSettings.Copies = Short.Parse(copies.Value.ToString())
        docPrinter.PrintDocument.DefaultPageSettings.Margins.Bottom = 0
        docPrinter.PrintDocument.DefaultPageSettings.Margins.Top = 0
        docPrinter.PrintDocument.DefaultPageSettings.Margins.Left = 0
        docPrinter.PrintDocument.DefaultPageSettings.Margins.Right = 0
        Dim printThread As Thread = New Thread(New ThreadStart(AddressOf Print))
        printThread.Start()
    End Sub

    Private Sub documentViewer_Load(sender As Object, e As EventArgs) Handles documentViewer.Load

    End Sub
End Class
