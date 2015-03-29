using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ResourceSelector : UserControl
    {
        private ResourceSelector()
        {
            InitializeComponent();
        }

        public ResourceSelector(string letter) : this()
        {
            Letter.Text = letter;
        }

        public ResourceSelector(string letter, string selectedValue) : this(letter)
        {
            ResourceType.SelectedItem = selectedValue;
        }

        private void ResourceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((AssignResourcesDialog)Parent.Parent).ValidateSelections();
        }
    }
}
