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
    public partial class ParamFilterForm : Form
    {
        public Country MinCountry;
        public Country MaxCountry;
        private NumericUpDown[] mins;
        private NumericUpDown[] maxs;
        public ParamFilterForm(Country minCountry, Country maxCountry)
        {
            MinCountry = minCountry;
            MaxCountry = maxCountry;
            InitializeComponent();
            mins = new NumericUpDown[] {
                DiversityMinNumericUpDown, FreedomMinNumericUpDown,
                BroadbandMinNumericUpDown, HumanCapitalMinNumericUpDown,
                TaxFriendlinessMinNumericUpDown, RDInvestmentMinNumericUpDown,
                EntrepreneurialActivityMinNumericUpDown, UnicornsMinNumericUpDown,
                ResilienceMinNumericUpDown, DronesMinNumericUpDown,
                RidesharingMinNumericUpDown, ShortTermRentalsMinNumericUpDown,
                SelfDrivingVehiclesMinNumericUpDown, EnvironmentMinNumericUpDown
            };

            maxs = new NumericUpDown[] {
                DiversityMaxNumericUpDown, FreedomMaxNumericUpDown,
                BroadbandMaxNumericUpDown, HumanCapitalMaxNumericUpDown,
                TaxFriendlinessMaxNumericUpDown, RDInvestmentMaxNumericUpDown,
                EntrepreneurialActivityMaxNumericUpDown, UnicornsMaxNumericUpDown,
                ResilienceMaxNumericUpDown, DronesMaxNumericUpDown,
                RidesharingMaxNumericUpDown, ShortTermRentalsMaxNumericUpDown,
                SelfDrivingVehiclesMaxNumericUpDown, EnvironmentMaxNumericUpDown
            };
            Grade[] minGrades = minCountry.GetGrades();
            Grade[] maxGrades = maxCountry.GetGrades();
            for (int i = 0; i < minGrades.Length; i++)
            {
                mins[i].Value = minGrades[i].Score;
                maxs[i].Value = maxGrades[i].Score;
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mins.Length; i++)
            {
                if (mins[i].Value > maxs[i].Value)
                {
                    MessageBox.Show(@"Parameter Filter: minimum should be less or equal than maximum", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            Grade[] minGrades = MinCountry.GetGrades();
            Grade[] maxGrades = MaxCountry.GetGrades();
            for (int i = 0; i < mins.Length; i++)
            {
                minGrades[i] = new Grade((int)mins[i].Value);
                maxGrades[i] = new Grade((int)maxs[i].Value);
            }
            MinCountry = new Country("", minGrades);
            MaxCountry = new Country("", maxGrades);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
