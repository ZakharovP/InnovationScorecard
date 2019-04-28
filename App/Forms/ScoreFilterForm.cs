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
    public partial class ScoreFilterForm : Form
    {
        public double MinScore;
        public double MaxScore;
        public ScoreFilterForm(double minScore, double maxScore)
        {
            InitializeComponent();
            MinNumericUpDown.Value = (decimal)minScore;
            MaxNumericUpDown.Value = (decimal)maxScore;
        }
        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (MinNumericUpDown.Value > MaxNumericUpDown.Value)
            {
                MessageBox.Show(@"Score Filter: minimum should be less or equal than maximum", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MinScore = (double)MinNumericUpDown.Value;
                MaxScore = (double)MaxNumericUpDown.Value;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
