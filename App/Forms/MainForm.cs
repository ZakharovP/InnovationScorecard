using App.Server;
using Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Forms
{
    public partial class MainForm : Form
    {
        private Table table;
        private const string ResourcesFolder = "Resources";
        private const string DefaultFile = "default.xml";
        public MainForm()
        {
            InitializeComponent();
            table = new Table(ParamDataGridView, ScoreDataGridView);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            string fileName = Path.Combine(ResourcesFolder, DefaultFile);
            Country[] countries;
            using (StreamReader sr = new StreamReader(new FileStream(fileName, FileMode.Open, FileAccess.Read)))
            {
                countries = Utils.Deserialize(sr);
            }
            table.Add(countries);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            bool[] scoreFilter = table.GetScoreFilter();
            SelectForm form = new SelectForm(scoreFilter);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                table.Filter(form.ScoreFilter);
            }
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/id73114955");
        }

        private void sourceCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ZakharovP/InnovationScorecard");
        }

        private void sourceDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.cta.tech/Policy/Innovation-Scorecard/International/Data.aspx");
        }

        private void DeleteParamButton_Click(object sender, EventArgs e)
        {
            if (ParamDataGridView.SelectedRows.Count > 0)
            {
                DataRow[] dataRows = new DataRow[ParamDataGridView.SelectedRows.Count];
                for (int i = 0; i < ParamDataGridView.SelectedRows.Count; i++)
                {
                    dataRows[i] = ((DataRowView)ParamDataGridView.SelectedRows[i].DataBoundItem).Row;
                }
                table.Remove(dataRows);
            }
            else
            {
                MessageBox.Show(@"Delete: please select at least one row", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteScoreButton_Click(object sender, EventArgs e)
        {
            if (ScoreDataGridView.SelectedRows.Count > 0)
            {
                DataRow[] dataRows = new DataRow[ScoreDataGridView.SelectedRows.Count];
                for (int i = 0; i < ScoreDataGridView.SelectedRows.Count; i++)
                {
                    dataRows[i] = ((DataRowView)ScoreDataGridView.SelectedRows[i].DataBoundItem).Row;
                }
                table.Remove(dataRows);
            }
            else
            {
                MessageBox.Show(@"Delete: please select at least one row", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FilterScoreButton_Click(object sender, EventArgs e)
        {
            double minScore, maxScore;
            table.GetMinMaxScore(out minScore, out maxScore);
            ScoreFilterForm form = new ScoreFilterForm(minScore, maxScore);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                table.Filter(form.MinScore, form.MaxScore);
            }
        }

        private void FilterParamButton_Click(object sender, EventArgs e)
        {
            Country minCountry, maxCountry;
            table.GetMinMaxCountry(out minCountry, out maxCountry);
            ParamFilterForm form = new ParamFilterForm(minCountry, maxCountry);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                table.Filter(form.MinCountry, form.MaxCountry);
            }
        }
    }
}
