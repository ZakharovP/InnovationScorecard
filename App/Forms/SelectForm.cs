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
    public partial class SelectForm : Form
    {
        public bool[] ScoreFilter { private set; get; }
        private CheckBox[] radioButtons;
        public SelectForm(bool[] scoreFilter)
        {
            InitializeComponent();
            radioButtons = new[] {
                DiversityCheckBox,
                FreedomCheckBox,
                BroadbandCheckBox,
                HumanCapitalCheckBox,
                TaxFriendlinessCheckBox,
                RDInvestmentCheckBox,
                EntrepreneurialActivityCheckBox,
                UnicornsCheckBox,
                ResilienceCheckBox,
                DronesCheckBox,
                RidesharingCheckBox,
                ShortTermRentalsheckBox,
                SelfDrivingVehiclesCheckBox,
                EnvironmentCheckBox
            };
            ScoreFilter = scoreFilter;
            for (int i=0; i<scoreFilter.Length; i++)
            {
                radioButtons[i].Checked = scoreFilter[i];
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            bool r = false;
            for (int i = 0; i < radioButtons.Length; i++)
            {
                r |= radioButtons[i].Checked;
            }
            if (r)
            {
                for (int i = 0; i < ScoreFilter.Length; i++)
                {
                    ScoreFilter[i] = radioButtons[i].Checked;
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(@"Select: please select at least one parameter", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
