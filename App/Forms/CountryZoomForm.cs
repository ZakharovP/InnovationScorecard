using Lib;
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
    public partial class CountryZoomForm : Form
    {
        public CountryZoomForm(Country country)
        {
            InitializeComponent();
            DataTable paramTable = new DataTable();
            ParamDataGridView.DataSource = paramTable;

            paramTable.Columns.Add(Utils.CountryParam.Text, typeof(string));
            for (int i = 0; i < Utils.Categories.Length; i++)
            {
                paramTable.Columns.Add(Utils.Categories[i].Text, typeof(int));
                ParamDataGridView.Columns[i].ToolTipText = Utils.Categories[i].Description;
            }
            DataRow row = paramTable.NewRow();
            row[Utils.CountryParam.Text] = country.Name;
            Grade[] grades = country.GetGrades();
            for (int i = 0; i < grades.Length; i++)
            {
                row[Utils.Categories[i].Text] = grades[i].Score;
            }
            paramTable.Rows.Add(row);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
