using Gnostice.Controls.WinForms;
using Gnostice.Core.Printer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_CS_Document_Viewer
{
    public partial class Print : Form
    {
        private DocumentViewer docViewer = null;
        public Print()
        {
            InitializeComponent();
        }

        public Print(DocumentViewer docViewer)
        {
            this.docViewer = docViewer;
            InitializeComponent();

            cmbPagePosition.SelectedIndex = 0;
            cmbPages.SelectedIndex = 0;
            cmbPageSizing.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrinterSettings settings = new PrinterSettings();

            switch (cmbPages.SelectedIndex)
            {
                case 0: settings.PrintRange = PrintRange.AllPages;
                    break;
                case 1: settings.PrintRange = PrintRange.CurrentPage;
                    break;
            }
            settings.Copies = 1;
            if (chkLandscape.Checked)
                settings.DefaultPageSettings.Landscape = true;
            else
                settings.DefaultPageSettings.Landscape = false;

            settings.DefaultPageSettings.Margins.Left = 0;
            settings.DefaultPageSettings.Margins.Top = 0;
            settings.DefaultPageSettings.Margins.Right = 0;
            settings.DefaultPageSettings.Margins.Bottom = 0;

            PageScalingOptions pso = PageScalingOptions.Original;
            switch (cmbPageSizing.SelectedIndex)
            {
                case 0: pso = PageScalingOptions.Original;
                    break;
                case 1: pso = PageScalingOptions.Fit;
                    break;
                case 2: pso = PageScalingOptions.ShrinkOverSizedPages;
                    break;
            }

            PagePositioningOptions ppo = PagePositioningOptions.OriginalPosition;
            switch (cmbPagePosition.SelectedIndex)
            {
                case 0: ppo = PagePositioningOptions.OriginalPosition;
                    break;
                case 1: ppo = PagePositioningOptions.Centered;
                    break;
            }

            docViewer.PrintDocument(settings, pso, ppo, true);

            this.Close();
        }
    }
}
