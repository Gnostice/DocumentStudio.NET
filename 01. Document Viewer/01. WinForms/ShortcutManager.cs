using Gnostice.Documents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_CS_Document_Viewer
{
    public partial class ShortcutManager : Form
    {
        private Gnostice.Core.DOM.Keys tempShortcutKey = Gnostice.Core.DOM.Keys.None;

        public ShortcutManager()
        {
            InitializeComponent();
            cmbComponent.SelectedIndex = 0;
        }

        private void lstBehaviour_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lstBehaviour.SelectedIndex)
            {
                case 0: // Begining of page
                    txtShortcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.StartOfPage].ToString();
                    break;
                case 1: // End of page
                    txtShortcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.EndOfPage].ToString();
                    break;
                case 2: // First page
                    txtShortcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.FirstPage].ToString();
                    break;
                case 3: // Last page
                    txtShortcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.LastPage].ToString();
                    break;
                case 4: // Previous page
                    txtShortcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.PreviousPage].ToString();
                    break;
                case 5: // Next page
                    txtShortcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.NextPage].ToString();
                    break;
                case 6: // Zoom In
                    txtShortcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.ZoomIn].ToString();
                    break;
                case 7: // Zoom Out
                    txtShortcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.ZoomOut].ToString();
                    break;
                case 8: // Rotate pages clockwise
                    txtShortcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.RotateClockwise].ToString();
                    break;
                case 9: // Rotate pages anticlockwise
                    txtShortcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.RotateAntiClockwise].ToString();
                    break;
                case 10: // Rotate current page clockwise
                    txtShortcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.RotateCurrentPageClockwise].ToString();
                    break;
                case 11: // Rotate current page clockwise
                    txtShortcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.RotateCurrentPageAnticlockwise].ToString();
                    break;
            }
            txtNewKey.Text = string.Empty;
        }

        private void txtNewKey_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            List<Keys> keyList = Enum.GetValues(typeof(Keys)).Cast<Keys>().ToList();

            Gnostice.Core.DOM.Keys currentKey = Gnostice.Core.DOM.Keys.None;

            currentKey |= (Gnostice.Core.DOM.Keys)e.KeyCode;

            if (e.Control)
                currentKey |= Gnostice.Core.DOM.Keys.Control;

            if (e.Alt)
                currentKey |= Gnostice.Core.DOM.Keys.Alt;

            if (e.Shift)
                currentKey |= Gnostice.Core.DOM.Keys.Shift;

            tempShortcutKey = currentKey;

            txtNewKey.Text = currentKey.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string tempText = txtShortcutKey.Text;
            try
            {
                switch (lstBehaviour.SelectedIndex)
                {
                    case 0: // Begining of page
                        Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.StartOfPage] = tempShortcutKey;
                        txtShortcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.StartOfPage].ToString();
                        break;
                    case 1: // End of page
                        Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.EndOfPage] = tempShortcutKey;
                        txtShortcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.EndOfPage].ToString();
                        break;
                    case 2: // First page
                        Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.FirstPage] = tempShortcutKey;
                        txtShortcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.FirstPage].ToString();
                        break;
                    case 3: // Last page
                        Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.LastPage] = tempShortcutKey;
                        txtShortcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.LastPage].ToString();
                        break;
                    case 4: // Previous page
                        Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.PreviousPage] = tempShortcutKey;
                        txtShortcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.PreviousPage].ToString();
                        break;
                    case 5: // Next page
                        Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.NextPage] = tempShortcutKey;
                        txtShortcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.NextPage].ToString();
                        break;
                    case 6: // Zoom In
                        Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.ZoomIn] = tempShortcutKey;
                        txtShortcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.ZoomIn].ToString();
                        break;
                    case 7: // Zoom Out
                        Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.ZoomOut] = tempShortcutKey;
                        txtShortcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.ZoomOut].ToString();
                        break;
                    case 8: // Rotate pages clockwise
                        Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.RotateClockwise] = tempShortcutKey;
                        txtShortcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.RotateClockwise].ToString();
                        break;
                    case 9: // Rotate pages anticlockwise
                        Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.RotateAntiClockwise] = tempShortcutKey;
                        txtShortcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.RotateAntiClockwise].ToString();
                        break;
                    case 10: // Rotate current page clockwise
                        Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.RotateCurrentPageClockwise] = tempShortcutKey;
                        txtShortcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.RotateCurrentPageClockwise].ToString();
                        break;
                    case 11: // Rotate current page clockwise
                        Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.RotateCurrentPageAnticlockwise] = tempShortcutKey;
                        txtShortcutKey.Text = Framework.KeyBindings[KeyBindableControls.Viewer][KeyBindableBehaviors.RotateCurrentPageAnticlockwise].ToString();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtShortcutKey.Text = tempText;
            }

            txtNewKey.Text = string.Empty;
            tempShortcutKey = Gnostice.Core.DOM.Keys.None;
        }
    }
}
