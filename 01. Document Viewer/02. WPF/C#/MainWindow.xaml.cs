using Gnostice.Documents;
using Gnostice.Controls.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Gnostice.Core.Viewer;
using Gnostice.Documents.PDF;
using Gnostice.Core;
using Gnostice.Documents.Word;
using Gnostice.Documents.Image;
using Gnostice.Core.Image;
using Gnostice.Converter;
using Gnostice.PageManager;
using Gnostice.Core.DOM;

namespace WPF_CS_Document_Viewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextSearchResult textSearchResult;
        TextSearchOptions textSearchOptions;
        public MainWindow()
        {
            InitializeComponent();
            DocumentViewer1.DocumentLoaded += DocumentViewer1_DocumentLoaded;
            this.DataContext = DocumentViewer1;
        }

        private void DocumentViewer1_DocumentLoaded(object sender, Gnostice.Controls.WPF.DocumentLoadedEventArgs e)
        {
            textSearchResult = null;
            txtInputText.Text = "";
        }

        

        private string FileName = string.Empty, OutputFileName = string.Empty, converterErrorMessage = string.Empty;
        private void DocumentViewer1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effects = DragDropEffects.Copy;
        }

        private void DocumentViewer1_Drop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 0)
            {
                try
                {
                    textSearchResult = null;
                    DocumentViewer1.LoadDocument(files[0]);
                    FileName = files[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            ConvertDocument();
        }
        private void ConvertDocument()
        {
            if (DocumentViewer1.IsDocumentLoaded)
            {
                Microsoft.Win32.SaveFileDialog saveDlg = new Microsoft.Win32.SaveFileDialog();
                saveDlg.Filter = "All Files|*.pdf;*.docx;*.doc;*.jpg;*.png;*.bmp;*.gif;*.tif;*.tiff;*.emf;*.wmf;*.txt;*.xps;|PDF Files|*.pdf|Word Documents|*.docx;*.doc|Image Files|*.jpg;*.png;*.bmp;*.gif;*.tiff;*.tif;*.emf;*.wmf;|Text Files|*.txt;|XPS Files|*.xps;|All Files|*.*";
                saveDlg.DefaultExt = ".pdf";

                string outputFormat = string.Empty;

                if (saveDlg.ShowDialog() == true)
                {
                    switch (System.IO.Path.GetExtension(saveDlg.FileName).ToLower())
                    {
                        case ".pdf": cmbSaveAs.SelectedIndex = 0; break;
                        case ".docx": cmbSaveAs.SelectedIndex = 1; break;
                        case ".txt": cmbSaveAs.SelectedIndex = 2; break;
                        case ".html": cmbSaveAs.SelectedIndex = 3; break;
                        case ".bmp": cmbSaveAs.SelectedIndex = 4; break;
                        case ".png": cmbSaveAs.SelectedIndex = 5; break;
                        case ".jpg": cmbSaveAs.SelectedIndex = 6; break;
                        case ".tiff": cmbSaveAs.SelectedIndex = 7; break;
                    }

                    OutputFileName = saveDlg.FileName;

                    popupSaveOptions.IsOpen = true;
                }
            }
        }

        private void btnSaveOptionsOK_Click(object sender, RoutedEventArgs e)
        {
            popupSaveOptions.IsOpen = false;
            if (OutputFileName != string.Empty)
            {

                ConverterSettings ConverterSettings = GetConverterSettings();
                EncoderSettings EncoderSettings = GetEncoderSettings();

                int lastIndex = OutputFileName.LastIndexOf(System.IO.Path.GetExtension(OutputFileName));

                switch (cmbSaveAs.SelectedIndex)
                {
                    case 0: // PDF
                        OutputFileName = OutputFileName.Substring(0, lastIndex) + ".pdf";
                        break;
                    case 1: // DOCX
                        OutputFileName = OutputFileName.Substring(0, lastIndex) + ".docx";
                        break;
                    case 2: // Text
                        OutputFileName = OutputFileName.Substring(0, lastIndex) + ".txt";
                        break;
                    case 3: // HTML
                        OutputFileName = OutputFileName.Substring(0, lastIndex) + ".html";
                        break;
                    case 4: // BMP
                        OutputFileName = OutputFileName.Substring(0, lastIndex) + ".bmp";
                        break;
                    case 5: // PNG
                        OutputFileName = OutputFileName.Substring(0, lastIndex) + ".png";
                        break;
                    case 6: // JPEG
                        OutputFileName = OutputFileName.Substring(0, lastIndex) + ".jpeg";
                        break;
                    case 7: // TIFF
                        OutputFileName = OutputFileName.Substring(0, lastIndex) + ".tiff";
                        break;
                    default:
                        break;
                }
                DocumentConverter docConvtr = new DocumentConverter();
                docConvtr.Error += docConvtr_Error;

                converterErrorMessage = string.Empty;
                docConvtr.ConvertToFile(FileName, OutputFileName, EncoderSettings, ConverterSettings);

                if (converterErrorMessage == string.Empty)
                    MessageBox.Show("File is saved as " + OutputFileName);
                else
                    MessageBox.Show(converterErrorMessage);
            }
            OutputFileName = string.Empty;
        }

        void docConvtr_Error(object sender, ConverterErrorEventArgs e)
        {
            converterErrorMessage += e.ErrorMessage + "\n\n";
        }

        private ConverterSettings GetConverterSettings()
        {
            ConverterSettings ConverterSettings = new ConverterSettings();
            switch (cmbPageRange.SelectedIndex)
            {
                case 0:
                    ConverterSettings.PageRange = Gnostice.Core.DOM.PageRange.All;
                    break;
                case 1:
                    ConverterSettings.PageRange = Gnostice.Core.DOM.PageRange.Even;
                    break;
                case 2:
                    ConverterSettings.PageRange = Gnostice.Core.DOM.PageRange.Odd;
                    break;
                case 3:
                    ConverterSettings.PageRange = Gnostice.Core.DOM.PageRange.Custom;
                    break;
            }
            ConverterSettings.CustomPageRange = txtPageRange.Text;

            return ConverterSettings;
        }

        private EncoderSettings GetEncoderSettings()
        {
            switch (cmbSaveAs.SelectedIndex)
            {
                case 0: // PDF
                    PDFEncoderSettings pdfEncoderSettings = new PDFEncoderSettings();
                    switch (cmbFontEmbedType.SelectedIndex)
                    {
                        case 0:
                            pdfEncoderSettings.FontEmbedType = Gnostice.Documents.FontEmbedType.Full;
                            break;
                        case 1:
                            pdfEncoderSettings.FontEmbedType = Gnostice.Documents.FontEmbedType.None;
                            break;
                        case 2:
                            pdfEncoderSettings.FontEmbedType = Gnostice.Documents.FontEmbedType.Subset;
                            break;
                    }
                    switch (cmbPDFVersion.SelectedIndex)
                    {
                        case 0:
                            pdfEncoderSettings.PDFVersion = Gnostice.Documents.PDF.PDFVersion.V1_4;
                            break;
                        case 1:
                            pdfEncoderSettings.PDFVersion = Gnostice.Documents.PDF.PDFVersion.V1_5;
                            break;
                        case 2:
                            pdfEncoderSettings.PDFVersion = Gnostice.Documents.PDF.PDFVersion.V1_6;
                            break;
                    }
                    return pdfEncoderSettings;
                case 2: // Text
                    TextEncoderSettings textEncoderSettings = new TextEncoderSettings();
                    switch (cmbFileEncoding.SelectedIndex)
                    {
                        case 0:
                            textEncoderSettings.FileEncoding = FileEncoding.UTF_8;
                            break;
                        case 1:
                            textEncoderSettings.FileEncoding = FileEncoding.US_ASCII;
                            break;
                        case 2:
                            textEncoderSettings.FileEncoding = FileEncoding.UTF_16BE;
                            break;
                        case 3:
                            textEncoderSettings.FileEncoding = FileEncoding.UTF_16LE;
                            break;
                        case 4:
                            textEncoderSettings.FileEncoding = FileEncoding.ISO_8859_1;
                            break;
                    }

                    if (chkBreakLines.IsChecked == true)
                        textEncoderSettings.TextFormatter.BreakLines = true;
                    else
                        textEncoderSettings.TextFormatter.BreakLines = false;

                    if (chkBreakPages.IsChecked == true)
                        textEncoderSettings.TextFormatter.BreakPages = true;
                    else
                        textEncoderSettings.TextFormatter.BreakPages = false;

                    if (chkBreakParagraphs.IsChecked == true)
                        textEncoderSettings.TextFormatter.BreakParagraphs = true;
                    else
                        textEncoderSettings.TextFormatter.BreakParagraphs = false;

                    if (txtPageBreakString.Text != string.Empty)
                    {
                        textEncoderSettings.TextFormatter.CustomPageBreak = true;
                        textEncoderSettings.TextFormatter.CustomPageBreakText = txtPageBreakString.Text;
                    }
                    return textEncoderSettings;
                case 4: // BMP
                    BMPEncoderSettings bmpEncoderSettings = new BMPEncoderSettings();

                    switch (cmbPageScalling.SelectedIndex)
                    {
                        case 0:
                            bmpEncoderSettings.PageScaling = PageScaling.None;
                            break;
                        case 1:
                            bmpEncoderSettings.PageScaling = PageScaling.UseRenderingResolution;
                            break;
                    }

                    bmpEncoderSettings.RenderingSettings = new Gnostice.Core.Graphics.RenderingSettings();

                    bmpEncoderSettings.ResolutionSettings = new Gnostice.Core.Graphics.ResolutionSettings();
                    bmpEncoderSettings.ResolutionSettings.DpiX = float.Parse(txtDPIX.Text);
                    bmpEncoderSettings.ResolutionSettings.DpiY = float.Parse(txtDPIY.Text);
                    return bmpEncoderSettings;
                case 5: // PNG
                    PNGEncoderSettings pngEncoderSettings = new PNGEncoderSettings();

                    switch (cmbPageScalling.SelectedIndex)
                    {
                        case 0:
                            pngEncoderSettings.PageScaling = PageScaling.None;
                            break;
                        case 1:
                            pngEncoderSettings.PageScaling = PageScaling.UseRenderingResolution;
                            break;
                    }

                    pngEncoderSettings.RenderingSettings = new Gnostice.Core.Graphics.RenderingSettings();

                    pngEncoderSettings.ResolutionSettings = new Gnostice.Core.Graphics.ResolutionSettings();
                    pngEncoderSettings.ResolutionSettings.DpiX = float.Parse(txtDPIX.Text);
                    pngEncoderSettings.ResolutionSettings.DpiY = float.Parse(txtDPIY.Text);
                    return pngEncoderSettings;
                case 6: // JPEG
                    JPEGEncoderSettings jpegEncoderSettings = new JPEGEncoderSettings();

                    switch (cmbPageScalling.SelectedIndex)
                    {
                        case 0:
                            jpegEncoderSettings.PageScaling = PageScaling.None;
                            break;
                        case 1:
                            jpegEncoderSettings.PageScaling = PageScaling.UseRenderingResolution;
                            break;
                    }

                    jpegEncoderSettings.RenderingSettings = new Gnostice.Core.Graphics.RenderingSettings();

                    jpegEncoderSettings.ResolutionSettings = new Gnostice.Core.Graphics.ResolutionSettings();
                    jpegEncoderSettings.ResolutionSettings.DpiX = float.Parse(txtDPIX.Text);
                    jpegEncoderSettings.ResolutionSettings.DpiY = float.Parse(txtDPIY.Text);

                    jpegEncoderSettings.QualityLevel = (long)sliderQuality.Value;
                    return jpegEncoderSettings;
                case 7: // TIFF
                    TIFFEncoderSettings tiffEncoderSettings = new TIFFEncoderSettings();

                    switch (cmbPageScalling.SelectedIndex)
                    {
                        case 0:
                            tiffEncoderSettings.PageScaling = PageScaling.None;
                            break;
                        case 1:
                            tiffEncoderSettings.PageScaling = PageScaling.UseRenderingResolution;
                            break;
                    }

                    tiffEncoderSettings.RenderingSettings = new Gnostice.Core.Graphics.RenderingSettings();

                    tiffEncoderSettings.ResolutionSettings = new Gnostice.Core.Graphics.ResolutionSettings();
                    tiffEncoderSettings.ResolutionSettings.DpiX = float.Parse(txtDPIX.Text);
                    tiffEncoderSettings.ResolutionSettings.DpiY = float.Parse(txtDPIY.Text);

                    switch (cmbCompression.SelectedIndex)
                    {
                        case 0:
                            tiffEncoderSettings.CompressionType = TiffCompressionType.None;
                            break;
                        case 1:
                            tiffEncoderSettings.CompressionType = TiffCompressionType.CCITT4;
                            break;
                        case 2:
                            tiffEncoderSettings.CompressionType = TiffCompressionType.LZW;
                            break;
                        case 3:
                            tiffEncoderSettings.CompressionType = TiffCompressionType.CCITT3;
                            break;
                        case 4:
                            tiffEncoderSettings.CompressionType = TiffCompressionType.Rle;
                            break;
                    }

                    if (chkMultipage.IsChecked == true)
                        tiffEncoderSettings.MultiPage = true;
                    else
                        tiffEncoderSettings.MultiPage = false;

                    return tiffEncoderSettings;
                default:
                    return null;
            }
        }

        private void btnSaveOptionsCancel_Click(object sender, RoutedEventArgs e)
        {

            OutputFileName = string.Empty;
            popupSaveOptions.IsOpen = false;
        }

        private void menuItemPageLayout_Click(object sender, RoutedEventArgs e)
        {
            ShowHideToolBar(toolBarPageLayout, menuItemPageLayout);
        }
        
        private void menuItemNavigationPane_Click(object sender, RoutedEventArgs e)
        {
            if (menuItemNavigationPane.Icon == null)
            {
                DocumentViewer1.NavigationPane.Visibility = Gnostice.Core.Viewer.Visibility.Auto;
                menuItemNavigationPane.Icon = new System.Windows.Controls.Image() { Source = new BitmapImage(new Uri("Resources/tick.png", UriKind.Relative)), Height = 16, Width = 16 };
            }
            else
            {
                DocumentViewer1.NavigationPane.Visibility = Gnostice.Core.Viewer.Visibility.Never;
                menuItemNavigationPane.Icon = null;
            }
        }

        private void ShowHideToolBar(Grid currentItem, MenuItem currentMenuItem)
        {
            if (currentItem.Visibility == System.Windows.Visibility.Visible)
            {
                currentItem.Visibility = System.Windows.Visibility.Collapsed;
                currentMenuItem.Icon = null;
            }
            else
            {
                currentItem.Visibility = System.Windows.Visibility.Visible;
                currentMenuItem.Icon = new System.Windows.Controls.Image() { Source = new BitmapImage(new Uri("Resources/tick.png", UriKind.Relative)), Height = 16, Width = 16 };
            }

            if (toolBarPageLayout.Visibility == System.Windows.Visibility.Collapsed && toolBarSaveOptions.Visibility == System.Windows.Visibility.Collapsed)
            {
                DocumentViewer1.Margin = new Thickness(5, 0, 5, 5);
            }
            else
            {
                DocumentViewer1.Margin = new Thickness(5, 0, 5, 0);
            }
        }

        private void menuItemShortcutManager_Click(object sender, RoutedEventArgs e)
        {
            if (popupShortcutManager.IsOpen)
            {
                popupShortcutManager.IsOpen = false;
            }
            else
            {
                popupShortcutManager.IsOpen = true;
            }
        }

        private void txtNumberPfPagesInRow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Tab)
            {
                try
                {
                    DocumentViewer1.PageLayout.Columns = int.Parse(txtNumberPfPagesInRow.Text);
                }
                catch { }
            }
        }

        private void LstbxBehavior_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            switch (lstbxBehavior.SelectedIndex)
            {
                case 0: // Begining of page
                    txtExistingShotcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.StartOfPage].ToString();
                    break;
                case 1: // End of page
                    txtExistingShotcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.EndOfPage].ToString();
                    break;
                case 2: // First page
                    txtExistingShotcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.FirstPage].ToString();
                    break;
                case 3: // Last page
                    txtExistingShotcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.LastPage].ToString();
                    break;
                case 4: // Previous page
                    txtExistingShotcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.PreviousPage].ToString();
                    break;
                case 5: // Next page
                    txtExistingShotcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.NextPage].ToString();
                    break;
                case 6: // Zoom In
                    txtExistingShotcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.ZoomIn].ToString();
                    break;
                case 7: // Zoom Out
                    txtExistingShotcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.ZoomOut].ToString();
                    break;
                case 8: // Rotate pages clockwise
                    txtExistingShotcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.RotateClockwise].ToString();
                    break;
                case 9: // Rotate pages anticlockwise
                    txtExistingShotcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.RotateAntiClockwise].ToString();
                    break;
                case 10: // Rotate current page clockwise
                    txtExistingShotcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.RotateCurrentPageClockwise].ToString();
                    break;
                case 11: // Rotate current page clockwise
                    txtExistingShotcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.RotateCurrentPageAnticlockwise].ToString();
                    break;
            }
            txtShotcutKey.Text = string.Empty;
        }
        
        private Gnostice.Core.DOM.Keys tempShortcutKey = Gnostice.Core.DOM.Keys.None;
        
        private void TxtShotcutKey_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            List<Key> keyList = Enum.GetValues(typeof(Key)).Cast<Key>().ToList();

            Gnostice.Core.DOM.Keys currentKey = Gnostice.Core.DOM.Keys.None;

            foreach (Key tempKey in keyList)
            {
                if (tempKey != Key.None && tempKey != Key.RightAlt && tempKey != Key.RightCtrl && tempKey != Key.RightShift &&
                    tempKey != Key.RWin && tempKey != Key.LeftAlt && tempKey != Key.LeftCtrl && tempKey != Key.LeftShift && tempKey != Key.LWin)
                {
                    if (Keyboard.IsKeyDown(tempKey))
                    {
                        currentKey |= Helper.WPFKeyMapping[e.Key];
                    }
                }
            }

            if (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl))
                currentKey |= Gnostice.Core.DOM.Keys.Control;

            if (Keyboard.IsKeyDown(Key.LeftAlt) || Keyboard.IsKeyDown(Key.RightAlt))
                currentKey |= Gnostice.Core.DOM.Keys.Alt;

            if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift))
                currentKey |= Gnostice.Core.DOM.Keys.Shift;

            tempShortcutKey = currentKey;

            txtShotcutKey.Text = currentKey.ToString();
        }

        private void cmbSeachOption_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textSearchResult = null;
        }

        private void btnPreviousSearch_Click(object sender, RoutedEventArgs e)
        {
            string text = txtInputText.Text.Trim();
            textSearchResult = DocumentViewer1.FindPrevious(searchText: text, searchOptions: textSearchOptions, lastSearchResult: textSearchResult);
            ShowSearchedTextNotFound(textSearchResult);
        }

        private void btnNextSearch_Click(object sender, RoutedEventArgs e)
        {
            string text = txtInputText.Text.Trim();
            textSearchResult = DocumentViewer1.FindNext(searchText: text, searchOptions: textSearchOptions, lastSearchResult: textSearchResult);
            ShowSearchedTextNotFound(textSearchResult);
        }

        private void ShowSearchedTextNotFound(TextSearchResult result)
        {
            if (result == null)
            {
                MessageBox.Show("DocumentViewer has finished searching the document. No matches were found.");
            }
        }



        private void txtInputText_TextChanged(object sender, TextChangedEventArgs e)
        {
            textSearchResult = null;
        }

        private void txtInputText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnNextSearch_Click(sender, e);
                e.Handled = true;
            }
        }

        private void MenuItem_Checked(object sender, RoutedEventArgs e)
        {
            if (!textSearchOptions.HasFlag(TextSearchOptions.WholeWord))
            {
                textSearchOptions |= TextSearchOptions.WholeWord;
            }
        }

        private void MenuItem_Unchecked(object sender, RoutedEventArgs e)
        {
            if (textSearchOptions.HasFlag(TextSearchOptions.WholeWord))
            {
                textSearchOptions &= ~TextSearchOptions.WholeWord;
            }
        }

        private void MenuItem_Checked_1(object sender, RoutedEventArgs e)
        {
            if (!textSearchOptions.HasFlag(TextSearchOptions.CaseSensitive))
            {
                textSearchOptions |= TextSearchOptions.CaseSensitive;
            }
        }

        private void MenuItem_Unchecked_1(object sender, RoutedEventArgs e)
        {
            if (textSearchOptions.HasFlag(TextSearchOptions.CaseSensitive))
            {
                textSearchOptions &= ~TextSearchOptions.CaseSensitive;
            }
        }

        private void MenuItem_Checked_2(object sender, RoutedEventArgs e)
        {
            if (!textSearchOptions.HasFlag(TextSearchOptions.WrapAround))
            {
                textSearchOptions |= TextSearchOptions.WrapAround;
            }
        }

        private void MenuItem_Unchecked_2(object sender, RoutedEventArgs e)
        {
            if (textSearchOptions.HasFlag(TextSearchOptions.WrapAround))
            {
                textSearchOptions &= ~TextSearchOptions.WrapAround;
            }
        }

        private void cmbZoomPercent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbZoomPercent.SelectedItem != null)
            {
                if ((cmbZoomPercent.SelectedItem as ZoomInfo).ZoomType == ZoomType.Standard)
                {
                    DocumentViewer1.Zoom.ZoomMode = (cmbZoomPercent.SelectedItem as ZoomInfo).ZoomMode;
                }
                else 
                {
                    DocumentViewer1.Zoom.ZoomPercent = (cmbZoomPercent.SelectedItem as ZoomInfo).Zoom;
                }
            }
        }

        private void BtnChangeShortcutKey_Click(object sender, RoutedEventArgs e)
        {
            string tempText = txtExistingShotcutKey.Text;
            try
            {
                switch (lstbxBehavior.SelectedIndex)
                {
                    case 0: // Begining of page
                        Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.StartOfPage] = tempShortcutKey;
                        txtExistingShotcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.StartOfPage].ToString();
                        break;
                    case 1: // End of page
                        Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.EndOfPage] = tempShortcutKey;
                        txtExistingShotcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.EndOfPage].ToString();
                        break;
                    case 2: // First page
                        Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.FirstPage] = tempShortcutKey;
                        txtExistingShotcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.FirstPage].ToString();
                        break;
                    case 3: // Last page
                        Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.LastPage] = tempShortcutKey;
                        txtExistingShotcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.LastPage].ToString();
                        break;
                    case 4: // Previous page
                        Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.PreviousPage] = tempShortcutKey;
                        txtExistingShotcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.PreviousPage].ToString();
                        break;
                    case 5: // Next page
                        Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.NextPage] = tempShortcutKey;
                        txtExistingShotcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.NextPage].ToString();
                        break;
                    case 6: // Zoom In
                        Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.ZoomIn] = tempShortcutKey;
                        txtExistingShotcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.ZoomIn].ToString();
                        break;
                    case 7: // Zoom Out
                        Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.ZoomOut] = tempShortcutKey;
                        txtExistingShotcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.ZoomOut].ToString();
                        break;
                    case 8: // Rotate pages clockwise
                        Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.RotateClockwise] = tempShortcutKey;
                        txtExistingShotcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.RotateClockwise].ToString();
                        break;
                    case 9: // Rotate pages anticlockwise
                        Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.RotateAntiClockwise] = tempShortcutKey;
                        txtExistingShotcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.RotateAntiClockwise].ToString();
                        break;
                    case 10: // Rotate current page clockwise
                        Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.RotateCurrentPageClockwise] = tempShortcutKey;
                        txtExistingShotcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.RotateCurrentPageClockwise].ToString();
                        break;
                    case 11: // Rotate current page clockwise
                        Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.RotateCurrentPageAnticlockwise] = tempShortcutKey;
                        txtExistingShotcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.RotateCurrentPageAnticlockwise].ToString();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtExistingShotcutKey.Text = tempText;
            }

            txtShotcutKey.Text = string.Empty;
            tempShortcutKey = Gnostice.Core.DOM.Keys.None;
        }
        private void BtnCloseShortcut_Click(object sender, RoutedEventArgs e)
        {
            popupShortcutManager.IsOpen = false;
        }
    }
}
