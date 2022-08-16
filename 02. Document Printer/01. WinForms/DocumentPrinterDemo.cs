using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;
using Gnostice.Controls.WinForms;
using System.Threading;
using Gnostice.Core;
using Gnostice.Core.Printer;
using Gnostice.Printer;

namespace Printer_Demo
{
    public partial class DocumentPrinterDemo : Form
    {
        private DocumentPrinter docPrinter;
        private PrinterSettings printerSettings = null;
        private string inputDocPassword = string.Empty;
        private Form printStatus;
        private int totalPages = 0;
        private int currentPage = 0;
        private int passwordAttempt = 0;
        bool cancel = false;
        private Button btn;
        private ProgressBar prgsbr;
        private Label lbl;

        public DocumentPrinterDemo()
        {
            InitializeComponent();
            documentViewer.NeedPassword += new EventHandler<NeedPasswordEventArgs>(DocPrinter_NeedPassword);
            docPrinter = new DocumentPrinter();
            docPrinter.BeginJob += new EventHandler<PrinterBeginJobEventArgs>(DocPrinter_StartPrintJob);
            docPrinter.EndPreparePage += new EventHandler<PrinterEndPreparePageEventArgs>(DocPrinter_EndPrintPage);
            docPrinter.EndJob += new EventHandler<PrinterEndJobEventArgs>(DocPrinter_EndPrintJob);
            docPrinter.BeginPreparePage += new EventHandler<PrinterBeginPreparePageEventArgs>(DocPrinter_StartPrintPage);
            PrinterSettings tempPrinterSettings = new PrinterSettings();
            lblSelectedPrinter.Text = tempPrinterSettings.PrinterName;
        }

        void DocPrinter_StartPrintPage(object sender, PrinterBeginPreparePageEventArgs e)
        {
            e.Cancel = cancel;
            currentPage = e.PrintJobPageNumber;
        }

        void DocPrinter_StartPrintJob(object sender, PrinterBeginJobEventArgs e)
        {
            e.Cancel = cancel;
            totalPages = e.PrintJobPageCount;
        }

        void DocPrinter_EndPrintJob(object sender, PrinterEndJobEventArgs e)
        {
            MessageBox.Show(cancel ? "Printing Canceled": "Printing Completed");
            cancel = false;
            Invoke(new Action(() => printStatus.Close()));
        }

        void DocPrinter_EndPrintPage(object sender, PrinterEndPreparePageEventArgs e)
        {
            e.Cancel = cancel;
            int percent = e.PrintJobPageNumber * 100 / e.PrintJobPageCount;
            Invoke(new Action(() => prgsbr.Value = percent));
            Invoke(new Action(() => lbl.Text = "Sent Page " + currentPage.ToString() + " of " + totalPages.ToString() + " to printer."));
            Invoke(new Action(() => printStatus.Update()));
        }

        void DocPrinter_NeedPassword(object sender, NeedPasswordEventArgs e)
        {
            passwordAttempt++;
            if (passwordAttempt >= 4)
            {
                e.Cancel = true;
                return;
            }
            inputDocPassword = ShowDialog("Please enter password to open '" + System.IO.Path.GetFileName(txtInputFilePath.Text) + "'", "Gnostice XDocumentStudio .NET - Need Password");
            e.Password = inputDocPassword;
        }

        private void DocumentPrinter_Load(object sender, EventArgs e)
        {
            cmbHorizontalPositioning.SelectedIndex = 0;
            cmbVerticalPositioning.SelectedIndex = 0;
            cmbScaling.SelectedIndex = 0;
        }

        private void LoadDocument()
        {
            Cursor = Cursors.WaitCursor;
            passwordAttempt = 0;
            try
            {
                documentViewer.LoadDocument(txtInputFilePath.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            Cursor = Cursors.Default;
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            if (browseFile.ShowDialog() == DialogResult.OK)
            {
                txtInputFilePath.Text = browseFile.FileName;
                LoadDocument();
            }
        }

        private string ShowDialog(string text, string caption)
        {
            Button confirmation = new Button() { Text = "&Ok", Left = 190, Width = 100, Top = 60, TabIndex = 1 };
            Button cancel = new Button() { Text = "&Cancel", Left = 310, Width = 100, Top = 60, TabIndex = 2 };
            var prompt = new Form
            {
                Width = 430,
                Height = 125,
                Text = caption,
                ControlBox = false,
                FormBorderStyle = FormBorderStyle.Fixed3D,
                StartPosition = FormStartPosition.CenterScreen,
                AcceptButton = confirmation,
                CancelButton = cancel
            };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);
            Label textLabel = new Label() { Left = 10, Top = 10, Text = text, AutoSize = true, TabIndex = 0 };
            prompt.Controls.Add(textLabel);
            TextBox textBox = new TextBox() { Left = 10, Top = 30, Width = 400, PasswordChar = '*' };
            prompt.Controls.Add(textBox);
            confirmation.Click += (sender, e) => { prompt.Close(); };
            cancel.Click += (sender, e) => { textBox.Text = string.Empty; prompt.Close(); };
            prompt.ShowDialog();
            return textBox.Text;
        }

        void TxtInputFilePath_Click(object sender, EventArgs e)
        {
            if (browseFile.ShowDialog() == DialogResult.OK)
            {
                txtInputFilePath.Text = browseFile.FileName;
                LoadDocument();
            }
        }

        void DocumentViewer_Click(object sender, EventArgs e)
        {
            if (browseFile.ShowDialog() == DialogResult.OK)
            {
                txtInputFilePath.Text = browseFile.FileName;
                LoadDocument();
            }
        }

        private void BtnSetup_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printerSettings = printDialog1.PrinterSettings;
                lblSelectedPrinter.Text = printerSettings.PrinterName;
            }
        }

        private void Print()
        {
            try
            {
                docPrinter.Print(txtInputFilePath.Text, inputDocPassword);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Invoke(new Action(() => printStatus.Close()));
                cancel = false;
            }
            Application.ExitThread();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (!documentViewer.IsDocumentLoaded)
            {
                return;
            }
            Enabled = false;
            StartPrinting();
        }

        private void StartPrinting()
        {
            currentPage = 0;
            totalPages = 0;
            printStatus = new Form
            {
                ShowInTaskbar = false,
                ShowIcon = false,
                MinimizeBox = false,
                MaximizeBox = false,
                Width = 400,
                Height = 150,
                Padding = new Padding(0),
                Text = "Printing Status",
                StartPosition = FormStartPosition.CenterParent
            };
            printStatus.Shown += new EventHandler(PrintStatus_Shown);
            printStatus.FormClosed += new FormClosedEventHandler(PrintStatus_FormClosed);
            prgsbr = new ProgressBar
            {
                Value = 0,
                Location = new Point(10, 40),
                Size = new Size(360, 23)
            };
            printStatus.Controls.Add(prgsbr);
            lbl = new Label
            {
                Text = "Preparing...",
                Location = new Point(10, 20),
                AutoSize = true
            };
            printStatus.Controls.Add(lbl);
            btn = new Button
            {
                Location = new Point(297, 75),
                Text = "&Cancel",
                TabIndex = 0
            };
            btn.Click += new EventHandler(BtnCancel_Click);
            printStatus.Controls.Add(btn);
            printStatus.CancelButton = btn;
            printStatus.ShowDialog();
        }

        void PrintStatus_FormClosed(object sender, FormClosedEventArgs e)
        {
            Enabled = true;
            totalPages = 0;
            currentPage = 0;
        }

        void PrintStatus_Shown(object sender, EventArgs e)
        {
            if (!documentViewer.IsDocumentLoaded)
            {
                return;
            }
            if (printerSettings != null)
            {
                docPrinter.PrintDocument.PrinterSettings = printerSettings;
            }
            else
            {
                docPrinter.PrintDocument.PrinterSettings = new PrinterSettings();
            }
            if (chckAutoRotate.Checked)
            {
                docPrinter.AutoRotate = true;
            }
            switch (cmbHorizontalPositioning.SelectedIndex)
            {
                case 0: docPrinter.PagePositioning.Horizontal = HPagePosition.Left;
                    break;
                case 1: docPrinter.PagePositioning.Horizontal = HPagePosition.Center;
                    break;
                case 2: docPrinter.PagePositioning.Horizontal = HPagePosition.Right;
                    break;
            }
            switch (cmbVerticalPositioning.SelectedIndex)
            {
                case 0: docPrinter.PagePositioning.Vertical = VPagePosition.Top;
                    break;
                case 1: docPrinter.PagePositioning.Vertical = VPagePosition.Center;
                    break;
                case 2: docPrinter.PagePositioning.Vertical = VPagePosition.Bottom;
                    break;
            }
            switch (cmbScaling.SelectedIndex)
            {
                case 0: docPrinter.PageScaling = PageScalingOptions.Original;
                    break;
                case 1: docPrinter.PageScaling = PageScalingOptions.Fit;
                    break;
                case 2: docPrinter.PageScaling = PageScalingOptions.ShrinkOverSizedPages;
                    break;
            }
            if (rdbtnAll.Checked)
            {
                docPrinter.PrintDocument.PrinterSettings.PrintRange = PrintRange.AllPages;
            }
            else if (rdbtnEven.Checked)
            {
                docPrinter.PageSelection.SelectionType = PageSelectionType.Even;
            }
            else if (rdbtnOdd.Checked)
            {
                docPrinter.PageSelection.SelectionType = PageSelectionType.Odd;
            }
            else if (rdbtnSeletedRange.Checked)
            {
                docPrinter.PageSelection.SelectionType = PageSelectionType.CustomRange;
                docPrinter.PageSelection.CustomRange = txtPageRange.Text;
            }
            docPrinter.PrintDocument.PrinterSettings.Copies = short.Parse(copies.Value.ToString());
            docPrinter.PrintDocument.DefaultPageSettings.Margins.Top = 0;
            docPrinter.PrintDocument.DefaultPageSettings.Margins.Right = 0;
            docPrinter.PrintDocument.DefaultPageSettings.Margins.Bottom = 0;
            docPrinter.PrintDocument.DefaultPageSettings.Margins.Left = 0;
            Thread printThread = new Thread(Print);
            printThread.Start();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
