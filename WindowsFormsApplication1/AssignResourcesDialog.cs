using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AssignResourcesDialog : Form
    {
        public AssignResourcesDialog()
        {
            InitializeComponent();

            foreach (var tile in Form1.Tiles)
            {
                if (Form1.MappedTiles == null)
                {
                    flowLayoutPanel1.Controls.Add(new ResourceSelector(tile));
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(new ResourceSelector(tile, Form1.MappedTiles[tile]));
                }
            }
        }

        public void ValidateSelections()
        {
            bool foundFailure = false;

            foreach (ResourceSelector selector in flowLayoutPanel1.Controls)
            {
                if (string.IsNullOrWhiteSpace((string)selector.ResourceType.SelectedItem))
                {
                    foundFailure = true;
                    break;
                }
            }

            button1.Enabled = !foundFailure;
        }
    }
}
