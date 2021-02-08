Imports System.Drawing.Printing

Public Class frmPrinterOptions
    'Private mPageSizingOptions As PageScalingOptions
    'Private mPagePositioningOptions As PagePositioningOptions
    Private mPrint As Boolean
    Private mLandscape As Boolean
    Private mPrintRange As PrintRange


    Public ReadOnly Property PrintRange() As PrintRange
        Get
            Return mPrintRange
        End Get
    End Property

    'Public ReadOnly Property PageSizingOptions() As PageScalingOptions
    'Get
    'Return mPageSizingOptions
    'End Get
    'End Property

    Public ReadOnly Property Landscape() As Boolean
        Get
            Return mLandscape
        End Get
    End Property

    Public ReadOnly Property Print() As Boolean
        Get
            Return mPrint
        End Get
    End Property

    'Public ReadOnly Property PagePositioningOptions() As PagePositioningOptions
    'Get
    'Return mPagePositioningOptions
    'End Get
    'End Property


    Private Sub button2_Click(sender As System.Object, e As System.EventArgs) Handles button2.Click
        Select Case cbPages.SelectedIndex
            Case 0
                mPrintRange = System.Drawing.Printing.PrintRange.AllPages
                Exit Select
                'case 1:
                '    printRange = System.Drawing.Printing.PrintRange.Selection;
                '    break;
                'case 2:
                '    printRange = System.Drawing.Printing.PrintRange.SomePages;
                '    break;
            Case 1
                mPrintRange = System.Drawing.Printing.PrintRange.CurrentPage
                Exit Select
            Case Else
                mPrintRange = System.Drawing.Printing.PrintRange.AllPages
                Exit Select
        End Select

        Throw New NotImplementedException

        'Select Case cbPageSize.SelectedIndex
        '    Case 0
        '        mPageSizingOptions = Gnostice.Documents.Controls.WinForms.PageScalingOptions.Original
        '        Exit Select
        '    Case 1
        '        mPageSizingOptions = Gnostice.Documents.Controls.WinForms.PageScalingOptions.Fit
        '        Exit Select
        '    Case 2
        '        mPageSizingOptions = Gnostice.Documents.Controls.WinForms.PageScalingOptions.ShrinkOverSizedPages
        '        Exit Select
        '    Case Else
        '        mPageSizingOptions = Gnostice.Documents.Controls.WinForms.PageScalingOptions.Original
        '        Exit Select
        'End Select

        'Select Case cbPagePosition.SelectedIndex
        '    Case 0
        '        mPagePositioningOptions = Gnostice.Documents.Controls.WinForms.PagePositioningOptions.OriginalPosition
        '        Exit Select
        '    Case 1
        '        mPagePositioningOptions = Gnostice.Documents.Controls.WinForms.PagePositioningOptions.Centered
        '        Exit Select
        '    Case Else
        '        mPagePositioningOptions = Gnostice.Documents.Controls.WinForms.PagePositioningOptions.OriginalPosition
        '        Exit Select
        'End Select

        mPrint = True
        mLandscape = chkLandscape.Checked
        Close()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        cbPages.SelectedIndex = 0
        cbPagePosition.SelectedIndex = 0
        cbPageSize.SelectedIndex = 1
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class