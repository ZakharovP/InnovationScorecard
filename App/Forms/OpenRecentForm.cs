using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Forms
{
    public partial class OpenRecentForm : Form
    {
        public string SelectedFile;
        public OpenRecentForm(string[] files)
        {
            InitializeComponent();
            for (int i=0; i<files.Length; i++)
            {
                FilesListBox.Items.Add(files[i]);
            }
            FilesListBox.SetSelected(0, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectedFile = (string)FilesListBox.SelectedItem;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
