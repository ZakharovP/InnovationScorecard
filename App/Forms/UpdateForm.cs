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
    public partial class UpdateForm : Form
    {
        public Grade[] Grades;
        private NumericUpDown[] values;
        public UpdateForm(Country c)
        {
            InitializeComponent();
            values = new NumericUpDown[] {
                DiversityNumericUpDown, FreedomNumericUpDown,
                BroadbandNumericUpDown, HumanCapitalNumericUpDown,
                TaxFriendlinessNumericUpDown, RDInvestmentNumericUpDown,
                EntrepreneurialActivityNumericUpDown, UnicornsNumericUpDown,
                ResilienceNumericUpDown, DronesNumericUpDown,
                RidesharingNumericUpDown, ShortTermRentalsNumericUpDown,
                SelfDrivingVehiclesNumericUpDown, EnvironmentNumericUpDown
            };
            Grade[] grades = c.GetGrades();
            Text = "Update " + c.Name;
            for (int i = 0; i < grades.Length; i++)
            {
                values[i].Value = grades[i].Score;
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            Grade[] grades = new Grade[Utils.Categories.Length];
            for (int i = 0; i < Utils.Categories.Length; i++)
            {
                grades[i] = new Grade((int)values[i].Value);
            }
            Grades = grades;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
