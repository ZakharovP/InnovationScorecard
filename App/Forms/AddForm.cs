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
    public partial class AddForm : Form
    {
        public Country NewCountry;
        public AddForm()
        {
            InitializeComponent();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            NumericUpDown[] values = new NumericUpDown[] {
                DiversityNumericUpDown, FreedomNumericUpDown,
                BroadbandNumericUpDown, HumanCapitalNumericUpDown,
                TaxFriendlinessNumericUpDown, RDInvestmentNumericUpDown,
                EntrepreneurialActivityNumericUpDown, UnicornsNumericUpDown,
                ResilienceNumericUpDown, DronesNumericUpDown,
                RidesharingNumericUpDown, ShortTermRentalsNumericUpDown,
                SelfDrivingVehiclesNumericUpDown, EnvironmentNumericUpDown
            };
            Grade[] grades = new Grade[Utils.Categories.Length];
            for (int i = 0; i < Utils.Categories.Length; i++)
            {
                grades[i] = new Grade((int)values[i].Value);
            }
            NewCountry = new Country(CountryNameTextBox.Text, grades);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
