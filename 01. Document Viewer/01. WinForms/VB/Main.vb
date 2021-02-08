Imports System.Drawing.Printing
Imports Gnostice.Core.Viewer
Imports Gnostice.Core
Imports Gnostice.Core.DOM

Public Class Form1

    Dim textSearchResult As TextSearchResult
    Dim textSearchOptions As TextSearchOptions
    Private Sub tsOpen_Click(sender As System.Object, e As System.EventArgs) Handles tsOpen.Click
        If odOpenDoc.ShowDialog() = DialogResult.OK Then
            txtZoom.Text = "100%"
            txtGoToPage.TextBoxTextAlign = HorizontalAlignment.Center
            txtGoToPage.Text = "1"
            Try
                DocumentViewer1.PageLayout = New PageLayout()
                DocumentViewer1.LoadDocument(odOpenDoc.FileName, "")
                Me.Text = System.IO.Path.GetFileName(odOpenDoc.FileName) + " - Gnostice Document Studio .NET"
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        If DocumentViewer1.IsDocumentLoaded Then
            Dim printerOptionsDlg As New frmPrinterOptions()
            printerOptionsDlg.ShowDialog()

            If printerOptionsDlg.Print Then
                Dim settings As New PrinterSettings()
                settings.FromPage = 2
                settings.ToPage = 3
                settings.PrintRange = printerOptionsDlg.PrintRange
                settings.Copies = 1
                settings.DefaultPageSettings.Landscape = printerOptionsDlg.Landscape

                settings.DefaultPageSettings.Margins.Left = 0
                settings.DefaultPageSettings.Margins.Top = 0
                settings.DefaultPageSettings.Margins.Right = 0
                settings.DefaultPageSettings.Margins.Bottom = 0

                Throw New NotImplementedException
                'DocumentViewer1.PrintDocument(settings, printerOptionsDlg.PageSizingOptions, printerOptionsDlg.PagePositioningOptions, True, "2-4")
            End If
        End If

    End Sub

    Private Sub btnFirstPage_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstPage.Click
        If DocumentViewer1.IsDocumentLoaded Then
            DocumentViewer1.FirstPage()
        End If
    End Sub

    Private Sub btnPrvPage_Click(sender As System.Object, e As System.EventArgs) Handles btnPrvPage.Click
        If DocumentViewer1.IsDocumentLoaded Then
            DocumentViewer1.PreviousPage()
        End If
    End Sub

    Private Sub btnNxtPage_Click(sender As System.Object, e As System.EventArgs) Handles btnNxtPage.Click
        If DocumentViewer1.IsDocumentLoaded Then
            DocumentViewer1.NextPage()
        End If
    End Sub

    Private Sub btnLastPage_Click(sender As System.Object, e As System.EventArgs) Handles btnLastPage.Click
        If DocumentViewer1.IsDocumentLoaded Then
            DocumentViewer1.LastPage()
        End If
    End Sub

    Private Sub tsActSize_Click(sender As System.Object, e As System.EventArgs) Handles tsActSize.Click
        If DocumentViewer1.IsDocumentLoaded Then
            DocumentViewer1.Zoom.ZoomMode = ZoomMode.ActualSize
        End If
    End Sub

    Private Sub tsFitPage_Click(sender As System.Object, e As System.EventArgs) Handles tsFitPage.Click
        If DocumentViewer1.IsDocumentLoaded Then
            DocumentViewer1.Zoom.ZoomMode = ZoomMode.FitPage
        End If
    End Sub

    Private Sub tsFitWidth_Click(sender As System.Object, e As System.EventArgs) Handles tsFitWidth.Click
        If DocumentViewer1.IsDocumentLoaded Then
            DocumentViewer1.Zoom.ZoomMode = ZoomMode.FitWidth
        End If
    End Sub

    Private Sub tsZoomOut_Click(sender As System.Object, e As System.EventArgs) Handles tsZoomOut.Click
        If DocumentViewer1.IsDocumentLoaded Then
            DocumentViewer1.ZoomOut()
        End If
    End Sub

    Private Sub tsZoomIn_Click(sender As System.Object, e As System.EventArgs) Handles tsZoomIn.Click
        If DocumentViewer1.IsDocumentLoaded Then
            DocumentViewer1.ZoomIn()
        End If
    End Sub

    Private Sub txtGoToPage_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtGoToPage.KeyDown
        Select Case e.KeyCode

            Case Keys.NumPad0, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3, Keys.NumPad4, Keys.NumPad5, _
             Keys.NumPad6, Keys.NumPad7, Keys.NumPad8, Keys.NumPad9, Keys.Delete, Keys.[End], _
             Keys.Home, Keys.Down, Keys.Up, Keys.Left, Keys.Right, Keys.Back
                e.SuppressKeyPress = False
                Exit Select

            Case Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, _
             Keys.D6, Keys.D7, Keys.D8, Keys.D9
                If e.Shift Then
                    e.SuppressKeyPress = True
                Else
                    e.SuppressKeyPress = False
                End If
                Exit Select

            Case Keys.Enter
                e.SuppressKeyPress = False
                If txtGoToPage.Text.Trim() <> "" Then
                    DocumentViewer1.GoToPage(Convert.ToInt32(txtGoToPage.Text))
                End If
                Exit Select
            Case Else

                e.SuppressKeyPress = True
                Exit Select
        End Select

    End Sub

    Private Sub txtZoom_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode

            Case Keys.NumPad0, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3, Keys.NumPad4, Keys.NumPad5,
             Keys.NumPad6, Keys.NumPad7, Keys.NumPad8, Keys.NumPad9, Keys.Delete, Keys.[End],
             Keys.Home, Keys.Down, Keys.Up, Keys.Left, Keys.Right, Keys.Back
                e.SuppressKeyPress = False
                Exit Select

            Case Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5,
             Keys.D6, Keys.D7, Keys.D8, Keys.D9
                If e.Shift Then
                    e.SuppressKeyPress = True
                Else
                    e.SuppressKeyPress = False
                End If
                Exit Select

            Case Keys.Enter
                e.SuppressKeyPress = False
                DocumentViewer1.Zoom.ZoomPercent = Double.Parse(txtZoom.Text)
                Exit Select
            Case Else

                e.SuppressKeyPress = True
                Exit Select
        End Select
    End Sub

    Private Sub DocumentViewer1_ZoomChanged(sender As System.Object, e As ZoomChangedEventArgs) Handles DocumentViewer1.ZoomChanged
        txtZoom.Text = e.ZoomPercent.ToString() + "%"
    End Sub


    Private Sub DocumentViewer1_PageChanged(sender As System.Object, e As PageChangedEventArgs) Handles DocumentViewer1.PageChanged
        txtGoToPage.Text = e.PageNumber.ToString()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub DocumentViewer1_NeedPassword(sender As System.Object, e As NeedPasswordEventArgs) Handles DocumentViewer1.NeedPassword

        Dim passwordDlg As New frmPassword()
        passwordDlg.ShowDialog()

        e.Password = passwordDlg.Password
        e.Cancel = False
    End Sub


    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        DocumentViewer1.RotatePagesAntiClockwise90()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        DocumentViewer1.RotatePagesClockwise90()
    End Sub

    Private Sub DocumentViewer1_Load(sender As Object, e As EventArgs) Handles DocumentViewer1.Load

    End Sub

    Private Sub ZoomPercent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtZoom.SelectedIndexChanged
        If (DocumentViewer1 IsNot Nothing) Then
            DocumentViewer1.Zoom.ZoomPercent = Double.Parse(Replace(txtZoom.Text, "%", ""))
        End If
    End Sub

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click
        If (DocumentViewer1 IsNot Nothing) Then
            DocumentViewer1.PageLayout.LayoutMode = PageLayoutMode.SinglePage
            DocumentViewer1.PageLayout.ScrollMode = ScrollMode.NonContinuous
        End If
    End Sub

    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click
        If (DocumentViewer1 IsNot Nothing) Then
            DocumentViewer1.PageLayout.LayoutMode = PageLayoutMode.SinglePage
            DocumentViewer1.PageLayout.ScrollMode = ScrollMode.Continuous
        End If
    End Sub

    Private Sub ToolStripButton13_Click(sender As Object, e As EventArgs) Handles ToolStripButton13.Click
        If (DocumentViewer1 IsNot Nothing) Then
            DocumentViewer1.PageLayout.LayoutMode = PageLayoutMode.TwoPage
            DocumentViewer1.PageLayout.ScrollMode = ScrollMode.NonContinuous
        End If
    End Sub

    Private Sub ToolStripButton14_Click(sender As Object, e As EventArgs) Handles ToolStripButton14.Click
        If (DocumentViewer1 IsNot Nothing) Then
            DocumentViewer1.PageLayout.LayoutMode = PageLayoutMode.TwoPage
            DocumentViewer1.PageLayout.ScrollMode = ScrollMode.Continuous
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        DocumentViewer1.RotatePagesAntiClockwise90(DocumentViewer1.CurrentPage)
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        DocumentViewer1.RotatePagesClockwise90(DocumentViewer1.CurrentPage)
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        DocumentViewer1.MouseMode = DOM.CursorPreferences.TextSelection
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        DocumentViewer1.MouseMode = DOM.CursorPreferences.Pan
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        DocumentViewer1.MouseMode = DOM.CursorPreferences.Marquee
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        DocumentViewer1.MouseMode = DOM.CursorPreferences.AreaSelection
    End Sub

    Private Sub ToolStripTextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearchText.TextChanged

    End Sub

    Private Sub ToolStripTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchText.KeyDown
        If (e.KeyCode = System.Windows.Forms.Keys.Enter) Then
            Dim searchText As String = txtSearchText.Text.Trim()
            textSearchResult = DocumentViewer1.FindNext(searchText, TextSearchMode.Literal, textSearchOptions, textSearchResult)
            ShowSearchedTextNotFound(textSearchResult)
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub ShowSearchedTextNotFound(textSearchResult As TextSearchResult)
        If textSearchResult Is Nothing Then
            MessageBox.Show("DocumentViewer has finished searching the document. No matches were found.")
        End If
    End Sub

    Private Sub ToolStripSplitButton1_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripSplitButton1.ButtonClick
        If (ToolStripSplitButton1.DropDown.Visible = True) Then
            ToolStripSplitButton1.HideDropDown()
        Else
            ToolStripSplitButton1.ShowDropDown()
        End If
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        Dim searchText As String = txtSearchText.Text.Trim()
        textSearchResult = DocumentViewer1.FindNext(searchText, TextSearchMode.Literal, textSearchOptions, textSearchResult)
        ShowSearchedTextNotFound(textSearchResult)
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        Dim searchText As String = txtSearchText.Text.Trim()
        textSearchResult = DocumentViewer1.FindPrevious(searchText, TextSearchMode.Literal, textSearchOptions, textSearchResult)
        ShowSearchedTextNotFound(textSearchResult)
    End Sub

    Private Sub WholeWordToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles WholeWordToolStripMenuItem.CheckedChanged
        If (WholeWordToolStripMenuItem.Checked = True) Then
            If Not textSearchOptions.HasFlag(TextSearchOptions.WholeWord) Then
                textSearchOptions = textSearchOptions Or TextSearchOptions.WholeWord
            End If
        Else
            If textSearchOptions.HasFlag(TextSearchOptions.WholeWord) Then
                textSearchOptions = textSearchOptions And Not TextSearchOptions.WholeWord
            End If
        End If
    End Sub

    Private Sub CaseSensitiveToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles CaseSensitiveToolStripMenuItem.CheckedChanged
        If CaseSensitiveToolStripMenuItem.Checked Then

            If Not textSearchOptions.HasFlag(TextSearchOptions.CaseSensitive) Then
                textSearchOptions = textSearchOptions Or TextSearchOptions.CaseSensitive
            End If
        Else

            If textSearchOptions.HasFlag(TextSearchOptions.CaseSensitive) Then
                textSearchOptions = textSearchOptions And Not TextSearchOptions.CaseSensitive
            End If
        End If
    End Sub

    Private Sub WrapAroundToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles WrapAroundToolStripMenuItem.CheckedChanged
        If WrapAroundToolStripMenuItem.Checked Then

            If Not textSearchOptions.HasFlag(TextSearchOptions.WrapAround) Then
                textSearchOptions = textSearchOptions Or TextSearchOptions.WrapAround
            End If
        Else

            If textSearchOptions.HasFlag(TextSearchOptions.WrapAround) Then
                textSearchOptions = textSearchOptions And Not TextSearchOptions.WrapAround
            End If
        End If
    End Sub
End Class
