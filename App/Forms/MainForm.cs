using App.Server;
using Lib;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private static string ResourcesFullFolder = Path.GetFullPath(ResourcesFolder);
        private const string DefaultFile = "default.xml";
        private const string HelpFile = "Help.txt";
        private const string NewTag = "New...";
        private const string SubKey = @"INNOVATIONSCORECARD";
        private const string KeyName = @"LASTFILE";
        private const string Title = "2019 International Innovation Scorecard";
        public MainForm()
        {
            InitializeComponent();
            table = new Table(ParamDataGridView, ScoreDataGridView);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            string file = GetLastFile();
            if (file == NewTag)
            {
                SetLastFile(DefaultFile);
                file = DefaultFile;
            }
            string fileName = Path.Combine(ResourcesFolder, file);
            UpdateTitle(file);
            Country[] countries;
            using (StreamReader sr = new StreamReader(new FileStream(fileName, FileMode.Open, FileAccess.Read)))
            {
                countries = Utils.Deserialize(sr);
            }
            table.Add(countries);
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

        private void AddParamButton_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                bool r = table.Add(new Country[] { form.NewCountry });
                if (!r)
                {
                    MessageBox.Show(@"Add: country with such name already exists", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void UpdateParamButton_Click(object sender, EventArgs e)
        {
            if (ParamDataGridView.SelectedRows.Count == 1)
            {
                Country country;
                table.GetCountry(((DataRowView)ParamDataGridView.SelectedRows[0].DataBoundItem).Row, out country);
                UpdateForm form = new UpdateForm(country);
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    table.UpdateCountry(country.Name, form.Grades);
                }
            }
            else
            {
                MessageBox.Show(@"Update: please select one row", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "xml";
            saveFileDialog.Filter = "XML file (*.xml)|*.xml";
            saveFileDialog.InitialDirectory = ResourcesFullFolder;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (ResourcesFullFolder != Path.GetDirectoryName(saveFileDialog.FileName))
                {
                    MessageBox.Show($@"Save as: please save file in {ResourcesFullFolder} folder", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Path.GetFileName(saveFileDialog.FileName) == DefaultFile)
                {
                    MessageBox.Show($@"Save as: it is not allowed to change the {DefaultFile} file", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using (StreamWriter sw = new StreamWriter(new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate, FileAccess.Write)))
                {
                    table.Write(sw);
                }
                SetLastFile(Path.GetFileName(saveFileDialog.FileName));
                MessageBox.Show($@"Save as: file {saveFileDialog.FileName} is saved", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clearRegistryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registry.CurrentUser.DeleteSubKeyTree(SubKey);
            MessageBox.Show(@"Delete Registry Key: done", @"", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private string GetLastFile()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(SubKey, true);
            if (rk == null)
            {
                SetLastFile(DefaultFile);
                rk = Registry.CurrentUser.OpenSubKey(SubKey);
            }
            else
            {
                if (rk.GetValue(KeyName).ToString() == NewTag)
                {
                    return NewTag;
                }
                if (!File.Exists(Path.Combine(ResourcesFolder, rk.GetValue(KeyName).ToString())))
                {
                    SetLastFile(DefaultFile);
                    rk = Registry.CurrentUser.OpenSubKey(SubKey);
                }
            }
            return rk.GetValue(KeyName).ToString();
        }

        private void SetLastFile(string file)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(SubKey, true);
            if (rk == null)
            {
                rk = Registry.CurrentUser.CreateSubKey(SubKey, true);
            }
            if (rk.GetValue(KeyName) == null)
            {
                rk.CreateSubKey(KeyName, true);
            }
            rk.SetValue(KeyName, file);
            UpdateTitle(file);
        }
        private void UpdateTitle(string file)
        {
            Text = $@"{Title} - {Path.GetFileName(file)}";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentFile = GetLastFile();
            if (currentFile == DefaultFile)
            {
                MessageBox.Show($@"Save: it is not allowed to change the {DefaultFile} file", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (currentFile == NewTag)
            {
                saveAsToolStripMenuItem_Click(sender, e);
                return;
            }
            string filePath = Path.Combine(ResourcesFolder, currentFile);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            using (StreamWriter sw = new StreamWriter(new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write)))
            {
                table.Write(sw);
            }
            MessageBox.Show($@"Save: file {filePath} is saved", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table.Clear();
            SetLastFile(NewTag);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = "xml";
            openFileDialog.Filter = "XML file (*.xml)|*.xml";
            openFileDialog.InitialDirectory = ResourcesFullFolder;

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                OpenImpl(openFileDialog.FileName);
            }
        }
        private void OpenImpl(string fileName)
        {
            string d = Path.GetDirectoryName(fileName);
            string f = Path.GetFileName(fileName);
            if (d != ResourcesFullFolder)
            {
                MessageBox.Show($@"Open: please open file from {ResourcesFullFolder} folder", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Country[] countries;
            using (StreamReader reader = new StreamReader(new FileStream(fileName, FileMode.Open, FileAccess.Read)))
            {
                countries = Utils.Deserialize(reader);
            }
            table.Clear();
            table.Add(countries);
            SetLastFile(f);
        }

        private void openResentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] filesFullName = Directory.GetFiles(ResourcesFullFolder);
            List<string> files = new List<string>();
            for (int i=0; i<filesFullName.Length; i++)
            {
                if (Path.GetExtension(filesFullName[i]) == ".xml")
                {
                    files.Add(Path.GetFileName(filesFullName[i]));
                }
            }
            OpenRecentForm form = new OpenRecentForm(files.ToArray());
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                OpenImpl(Path.GetFullPath(Path.Combine(ResourcesFolder, form.SelectedFile)));
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Path.GetFullPath(Path.Combine(ResourcesFolder, HelpFile)));
        }

        private void ScoreDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (ScoreDataGridView.SelectedRows.Count == 1)
            {
                DataRow row = ((DataRowView)ScoreDataGridView.SelectedRows[0].DataBoundItem).Row;
                table.GetCountry(row, out Country country);
                CountryZoomForm form = new CountryZoomForm(country);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show($@"Please double click one row", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
