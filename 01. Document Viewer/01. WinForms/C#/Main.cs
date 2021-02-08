using Gnostice.Documents;
using Gnostice.Controls.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gnostice.Core.Viewer;
using Gnostice.Core;
using System.IO;
using Gnostice.PageManager;
using Gnostice.Core.DOM;

namespace WinForms_CS_Document_Viewer
{
    public partial class Main : Form
    {
        TextSearchResult textSearchResult;
        TextSearchOptions textSearchOptions;
        public Main()
        {
            InitializeComponent();
            DocumentViewer1.DocumentLoaded += DocumentViewer1_DocumentLoaded;
            DocumentViewer1.ZoomValuesUpdated += DocumentViewer1_ZoomListUpdated;
        }

        private void DocumentViewer1_DocumentLoaded(object sender, DocumentLoadedEventArgs e)
        {
            textSearchResult = null;
            txtSearchText.Text = "";


        }

        private void DocumentViewer1_ZoomListUpdated(object sender, ZoomValuesUpdatedEventArgs e)
        {
            cmbZoomPercent.SelectedIndexChanged -= cmbZoomPercent_SelectedIndexChanged;
            int index = cmbZoomPercent.ComboBox.SelectedIndex;
            cmbZoomPercent.ComboBox.DataSource = DocumentViewer1.GetZoomList();
            cmbZoomPercent.ComboBox.DisplayMember = e.DisplayMember;
            cmbZoomPercent.ComboBox.ValueMember = e.ValueMember;
            cmbZoomPercent.SelectedIndexChanged += cmbZoomPercent_SelectedIndexChanged;
            if (e.Index != -1)
                cmbZoomPercent.ComboBox.SelectedIndex = e.Index;
            cmbZoomPercent.Text = e.Zoom.ToString("#.##") + "%";
        }

        private int oldScrollingMode = -1;
        private string Filename = string.Empty;

        void DocumentViewer1_ZoomChanged(object sender, ZoomChangedEventArgs e)
        {
            cmbZoomPercent.Text = DocumentViewer1.Zoom.ZoomPercent.ToString("#.##") + "%";

            txtColumns.Text = DocumentViewer1.PageLayout.Columns.ToString();
        }

        private void DocumentViewer1_PageCountChanged(object sender, PageCountChangedEventArgs e)
        {
            lblPageCount.Text = e.PageCount.ToString();
        }

        void DocumentViewer1_PageChanged(object sender, PageChangedEventArgs e)
        {
            txtCurrentPage.Text = e.PageNumber.ToString();
        }

        private void pageLayoutOptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripPageLayoutOptions.Visible == false)
            {
                toolStripPageLayoutOptions.Visible = true;
                pageLayoutOptionToolStripMenuItem.Image = WinForms_CS_Document_Viewer.Properties.Resources.tick;
            }
            else
            {
                toolStripPageLayoutOptions.Visible = false;
                pageLayoutOptionToolStripMenuItem.Image = null;
            }
        }

        private void btnShowCoverPage_Click(object sender, EventArgs e)
        {
            if (btnShowCoverPage.Image == null)
            {
                DocumentViewer1.PageLayout.ShowCoverPage = true;
                showCoverPageToolStripMenuItem.Image = WinForms_CS_Document_Viewer.Properties.Resources.tick;
                btnShowCoverPage.Image = WinForms_CS_Document_Viewer.Properties.Resources.tick;
            }
            else
            {
                DocumentViewer1.PageLayout.ShowCoverPage = false;
                showCoverPageToolStripMenuItem.Image = null;
                btnShowCoverPage.Image = null;
            }
        }

        private void navigationPaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DocumentViewer1.NavigationPane.Visibility==Visibility.Auto)
            {
                navigationPaneToolStripMenuItem.Image = null;
                DocumentViewer1.NavigationPane.Visibility = Visibility.Never;
            }
            else
            {
                navigationPaneToolStripMenuItem.Image = WinForms_CS_Document_Viewer.Properties.Resources.tick;
                DocumentViewer1.NavigationPane.Visibility = Visibility.Auto;
                DocumentViewer1.Zoom.ZoomMode = ZoomMode.FitWidth;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Filename = openFileDialog1.FileName;
                    this.Text = System.IO.Path.GetFileName(Filename) + " - Gnostice WinForms Document Viewer";
                    DocumentViewer1.LoadDocument(openFileDialog1.FileName);
                    cmbZoomPercent.FlatStyle = FlatStyle.Standard;

                    

                    //DocumentViewer1.Zoom.ZoomPercent = double.Parse(cmbZoomPercent.Text.Remove(cmbZoomPercent.Text.Length - 1));
                    DocumentViewer1_LastPageRead(DocumentViewer1, e as Gnostice.Core.LoadCompletedEventArgs);
                    lblPageCount.Text = DocumentViewer1.PageCount.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DocumentViewer1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void DocumentViewer1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 0)
            {
                try
                {
                    DocumentViewer1.LoadDocument(files[0]);

                    cmbZoomPercent.FlatStyle = FlatStyle.Standard;
                    DocumentViewer1.Zoom.ZoomPercent = double.Parse(cmbZoomPercent.Text.Remove(cmbZoomPercent.Text.Length - 1));
                    lblPageCount.Text = DocumentViewer1.PageCount.ToString();
                    DocumentViewer1_LastPageRead(DocumentViewer1, new Gnostice.Core.LoadCompletedEventArgs(DocumentViewer1.PageCount));
                    this.Filename = files[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (DocumentViewer1.IsDocumentLoaded)
            {
                Print print = new Print(DocumentViewer1);
                print.ShowDialog();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DocumentViewer1.IsDocumentLoaded)
            {
                string outputFormat = string.Empty;

                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    SavingOptions ep = new SavingOptions(Filename, saveFileDialog1.FileName);
                    ep.ShowDialog();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            DocumentViewer1.FirstPage();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            DocumentViewer1.PreviousPage();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DocumentViewer1.NextPage();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            DocumentViewer1.LastPage();
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            DocumentViewer1.ZoomOut();
            cmbZoomPercent.Text = DocumentViewer1.Zoom.ZoomPercent.ToString("#.##") + "%";
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            DocumentViewer1.ZoomIn();
            cmbZoomPercent.Text = DocumentViewer1.Zoom.ZoomPercent.ToString("#.##") + "%";
        }

        private void btnRotateClockwise_Click(object sender, EventArgs e)
        {
            DocumentViewer1.RotatePagesClockwise90();
        }

        private void btnRotateAnticlockwise_Click(object sender, EventArgs e)
        {
            DocumentViewer1.RotatePagesAntiClockwise90();
        }

        private void btnRotateCurrentPageClockwise_Click(object sender, EventArgs e)
        {
            DocumentViewer1.RotatePagesClockwise90(DocumentViewer1.CurrentPage.ToString());
        }

        private void btnRotateCurrentPageAnticlockwise_Click(object sender, EventArgs e)
        {
            DocumentViewer1.RotatePagesAntiClockwise90(DocumentViewer1.CurrentPage.ToString());
        }

        private void btnSingleNonContinuous_Click(object sender, EventArgs e)
        {
            cmbLayoutMode.SelectedIndex = 0;
            cmbScrollMode.SelectedIndex = 1;
        }

        private void btnSingleContinuous_Click(object sender, EventArgs e)
        {
            cmbLayoutMode.SelectedIndex = 0;
            cmbScrollMode.SelectedIndex = 0;
        }

        private void btnTwoPageNonContinuous_Click(object sender, EventArgs e)
        {
            cmbLayoutMode.SelectedIndex = 1;
            cmbScrollMode.SelectedIndex = 1;
        }

        private void btnTwoPageContinuous_Click(object sender, EventArgs e)
        {
            cmbLayoutMode.SelectedIndex = 1;
            cmbScrollMode.SelectedIndex = 0;
        }

        private void allowPageShiftingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (allowPageShiftingToolStripMenuItem.Image == null)
            {
                cmbScrollMode.SelectedIndex = oldScrollingMode;
                allowPageShiftingToolStripMenuItem.Image = WinForms_CS_Document_Viewer.Properties.Resources.tick;
            }
            else
            {
                oldScrollingMode = cmbScrollMode.SelectedIndex;
                cmbScrollMode.SelectedIndex = 2;
                allowPageShiftingToolStripMenuItem.Image = null;
            }
        }

        private void cmbLayoutMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbLayoutMode.SelectedIndex)
            {
                case 0:
                    DocumentViewer1.PageLayout.LayoutMode = Gnostice.Core.Viewer.PageLayoutMode.SinglePage;
                    break;
                case 1:
                    DocumentViewer1.PageLayout.LayoutMode = Gnostice.Core.Viewer.PageLayoutMode.TwoPage;
                    break;
                case 2:
                    DocumentViewer1.PageLayout.LayoutMode = Gnostice.Core.Viewer.PageLayoutMode.AutoFitPagesInWindow;
                    break;
                case 3:
                    DocumentViewer1.PageLayout.LayoutMode = Gnostice.Core.Viewer.PageLayoutMode.SpecifiedColumns;
                    break;
            }

            txtColumns.Text = DocumentViewer1.PageLayout.Columns.ToString();
        }

        private void txtColumns_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                try
                {
                    DocumentViewer1.PageLayout.Columns = int.Parse(txtColumns.Text);
                }
                catch { }
            }
        }

        private void cmbScrollMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbScrollMode.SelectedIndex)
            {
                case 0:
                    DocumentViewer1.PageLayout.ScrollMode = Gnostice.Core.Viewer.ScrollMode.Continuous;
                    allowPageShiftingToolStripMenuItem.Image = WinForms_CS_Document_Viewer.Properties.Resources.tick;
                    break;
                case 1:
                    DocumentViewer1.PageLayout.ScrollMode = Gnostice.Core.Viewer.ScrollMode.NonContinuous;
                    allowPageShiftingToolStripMenuItem.Image = WinForms_CS_Document_Viewer.Properties.Resources.tick;
                    break;
                case 2:
                    DocumentViewer1.PageLayout.ScrollMode = Gnostice.Core.Viewer.ScrollMode.NonPageSwitching;
                    allowPageShiftingToolStripMenuItem.Image = null;
                    break;
            }

            txtColumns.Text = DocumentViewer1.PageLayout.Columns.ToString();
        }

        private void txtHorizontalSpacing_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    try
            //    {
            //        DocumentViewer1..PageLayout.HorizontalSpacing = int.Parse(txtHorizontalSpacing.Text);
            //    }
            //    catch { }
            //}
        }

        private void txtVerticalSpacing_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    try
            //    {
            //        DocumentViewer1..PageLayout.VerticalSpacing = int.Parse(txtVerticalSpacing.Text);
            //    }
            //    catch { }
            //}
        }

        private void shortcutManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShortcutManager sm = new ShortcutManager();
            sm.ShowDialog();
        }

        private void cmbZoomPercent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter || e.KeyCode == System.Windows.Forms.Keys.Tab)
            {
                try
                {
                    DocumentViewer1.Zoom.ZoomPercent = double.Parse(cmbZoomPercent.Text.Split('%')[0]);
                }
                catch { }
            }
            e.Handled = true;
        }

        private void cmbZoomPercent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DocumentViewer1 != null && DocumentViewer1.IsDocumentLoaded && cmbZoomPercent.SelectedIndex != -1)
            {
                ZoomInfo currentZoom = cmbZoomPercent.SelectedItem as ZoomInfo;
                if(currentZoom.ZoomType == ZoomType.Standard)
                {
                    DocumentViewer1.Zoom.ZoomMode = currentZoom.ZoomMode;
                }
                else
                {
                    DocumentViewer1.Zoom.ZoomPercent = (cmbZoomPercent.SelectedItem as ZoomInfo).Zoom;
                }
            }
        }

        private void DocumentViewer1_LastPageRead(object sender, Gnostice.Core.LoadCompletedEventArgs e)
        {
            cmbLayoutMode.SelectedIndex = 0;
            cmbScrollMode.SelectedIndex = 0;
            try
            {
                if (this.InvokeRequired)
                    this.Invoke(new Action(() => lblPageCount.Text = DocumentViewer1.PageCount.ToString()));
                if (this.InvokeRequired)
                    this.Invoke(new Action(() => cmbZoomPercent.Text = DocumentViewer1.Zoom.ZoomPercent.ToString("#.##") + "%"));
                else
                    cmbZoomPercent.Text = DocumentViewer1.Zoom.ZoomPercent.ToString("#.##") + "%";
                if (this.InvokeRequired)
                    this.Invoke(new Action(() => txtCurrentPage.Text = DocumentViewer1.CurrentPage.ToString()));
                else
                    txtCurrentPage.Text = DocumentViewer1.CurrentPage.ToString();
            }
            catch { }
        }


        
        private void Main_Resize(object sender, EventArgs e)
        {
            //if (DocumentViewer1 != null && DocumentViewer1..PageLayout != null)
            //    txtColumns.Text = DocumentViewer1..PageLayout.Columns.ToString();
        }

        private void btnArrow_Click(object sender, EventArgs e)
        {
            this.DocumentViewer1.MouseMode = Gnostice.Core.DOM.CursorPreferences.TextSelection;
        }

        private void btnPan_Click(object sender, EventArgs e)
        {
            this.DocumentViewer1.MouseMode = Gnostice.Core.DOM.CursorPreferences.Pan;
        }

        private void btnMarquee_Click(object sender, EventArgs e)
        {
            this.DocumentViewer1.MouseMode = Gnostice.Core.DOM.CursorPreferences.Marquee;
        }

        private void btnHorizontal_Click(object sender, EventArgs e)
        {
            DocumentViewer1.Orientation = Gnostice.Core.Viewer.ViewerOrientation.Horizontal;
        }

        private void btnVertical_Click(object sender, EventArgs e)
        {
            DocumentViewer1.Orientation = Gnostice.Core.Viewer.ViewerOrientation.Vertical;
        }

        float x1, y1, x2, y2, x, y;

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void AreaSelectionButton1_Click(object sender, EventArgs e)
        {
            this.DocumentViewer1.MouseMode = Gnostice.Core.DOM.CursorPreferences.AreaSelection;

        }

        private void txtSearchText_Validated(object sender, EventArgs e)
        {

        }

        private void txtSearchText_TextChanged(object sender, EventArgs e)
        {
            textSearchResult = null;
        }

        private void txtSearchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                string searchText = txtSearchText.Text.Trim();
                textSearchResult = DocumentViewer1.FindNext(searchText, lastSearchResult: textSearchResult, searchOptions: textSearchOptions);
                ShowSearchedTextNotFound(textSearchResult);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void ShowSearchedTextNotFound(TextSearchResult result)
        {
            if (result == null)
            {
                MessageBox.Show("DocumentViewer has finished searching the document. No matches were found.");
            }
        }

        private void btnNextSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchText.Text.Trim();
            textSearchResult = DocumentViewer1.FindNext(searchText, lastSearchResult: textSearchResult, searchOptions: textSearchOptions);
            ShowSearchedTextNotFound(textSearchResult);
           
        }

        private void btnPrevSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchText.Text.Trim();
            textSearchResult = DocumentViewer1.FindPrevious(searchText, lastSearchResult: textSearchResult, searchOptions: textSearchOptions);
            ShowSearchedTextNotFound(textSearchResult);
        }


        private void wholeWorldToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (wholeWorldToolStripMenuItem.Checked)
            {
                if (!textSearchOptions.HasFlag(TextSearchOptions.WholeWord))
                {
                    textSearchOptions |= TextSearchOptions.WholeWord;
                }
            }
            else
            {
                if (textSearchOptions.HasFlag(TextSearchOptions.WholeWord))
                {
                    textSearchOptions &= ~TextSearchOptions.WholeWord;
                }
            }
        }

        private void caseSensitiveToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (caseSensitiveToolStripMenuItem.Checked)
            {
                if (!textSearchOptions.HasFlag(TextSearchOptions.CaseSensitive))
                {
                    textSearchOptions |= TextSearchOptions.CaseSensitive;
                }
            }
            else
            {
                if (textSearchOptions.HasFlag(TextSearchOptions.CaseSensitive))
                {
                    textSearchOptions &= ~TextSearchOptions.CaseSensitive;
                }
            }
        }

        private void wrapAroundToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (wrapAroundToolStripMenuItem.Checked)
            {
                if (!textSearchOptions.HasFlag(TextSearchOptions.WrapAround))
                {
                    textSearchOptions |= TextSearchOptions.WrapAround;
                }
            }
            else
            {
                if (textSearchOptions.HasFlag(TextSearchOptions.WrapAround))
                {
                    textSearchOptions &= ~TextSearchOptions.WrapAround;
                }
            }
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            if (toolStripSplitButton1.DropDown.Visible)
                toolStripSplitButton1.HideDropDown();
            else
                toolStripSplitButton1.ShowDropDown();
        }

        private void TxtCurrentPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter || e.KeyCode == System.Windows.Forms.Keys.Tab)
            {
                int pageNumber;
                if (int.TryParse(txtCurrentPage.Text, out pageNumber))
                    DocumentViewer1.GoToPage(pageNumber);
                else
                    txtCurrentPage.Text = DocumentViewer1.CurrentPage.ToString();
            }
        }

        Stream imageStream;

        private void DocumentViewer1_MouseUp(object sender, Gnostice.Core.Viewer.MouseActivityEventArgs e)
        {
            x2 = (e as WinFormsMouseActivityEventArgs).PosRelativetoPage.X;
            y2 = (e as WinFormsMouseActivityEventArgs).PosRelativetoPage.Y;
            Rectangle rect = new Rectangle((int)Math.Min(x1, x2), (int)Math.Min(y1, y2), (int)Math.Abs(x1 - x2), (int)Math.Abs(y1 - y2));
            imageStream = e.ImageStream;
        }

        private void DocumentViewer1_MouseDown(object sender, Gnostice.Core.Viewer.MouseActivityEventArgs e)
        {
            x1 = (e as WinFormsMouseActivityEventArgs).PosRelativetoPage.X;
            y1 = (e as WinFormsMouseActivityEventArgs).PosRelativetoPage.Y;
        }

        private void DocumentViewer1_MouseMove(object sender, Gnostice.Core.Viewer.MouseActivityEventArgs e)
        {
            x = (e as WinFormsMouseActivityEventArgs).PosRelativetoPage.X;
            y = (e as WinFormsMouseActivityEventArgs).PosRelativetoPage.Y;
        }
        
    }
}
