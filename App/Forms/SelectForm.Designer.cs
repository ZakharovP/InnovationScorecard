using Lib;

namespace App.Forms
{
    partial class SelectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectButton = new System.Windows.Forms.Button();
            this.DiversityCheckBox = new System.Windows.Forms.CheckBox();
            this.FreedomCheckBox = new System.Windows.Forms.CheckBox();
            this.BroadbandCheckBox = new System.Windows.Forms.CheckBox();
            this.HumanCapitalCheckBox = new System.Windows.Forms.CheckBox();
            this.TaxFriendlinessCheckBox = new System.Windows.Forms.CheckBox();
            this.EntrepreneurialActivityCheckBox = new System.Windows.Forms.CheckBox();
            this.UnicornsCheckBox = new System.Windows.Forms.CheckBox();
            this.ResilienceCheckBox = new System.Windows.Forms.CheckBox();
            this.RDInvestmentCheckBox = new System.Windows.Forms.CheckBox();
            this.DronesCheckBox = new System.Windows.Forms.CheckBox();
            this.RidesharingCheckBox = new System.Windows.Forms.CheckBox();
            this.ShortTermRentalsheckBox = new System.Windows.Forms.CheckBox();
            this.SelfDrivingVehiclesCheckBox = new System.Windows.Forms.CheckBox();
            this.EnvironmentCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SelectButton
            // 
            this.SelectButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SelectButton.Location = new System.Drawing.Point(0, 131);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(424, 50);
            this.SelectButton.TabIndex = 0;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // DiversityCheckBox
            // 
            this.DiversityCheckBox.AutoSize = true;
            this.DiversityCheckBox.Location = new System.Drawing.Point(12, 12);
            this.DiversityCheckBox.Name = "DiversityCheckBox";
            this.DiversityCheckBox.Size = new System.Drawing.Size(66, 17);
            this.DiversityCheckBox.TabIndex = 16;
            this.DiversityCheckBox.Text = Utils.Categories[0].Text;
            this.DiversityCheckBox.UseVisualStyleBackColor = true;
            // 
            // FreedomCheckBox
            // 
            this.FreedomCheckBox.AutoSize = true;
            this.FreedomCheckBox.Location = new System.Drawing.Point(12, 35);
            this.FreedomCheckBox.Name = "FreedomCheckBox";
            this.FreedomCheckBox.Size = new System.Drawing.Size(67, 17);
            this.FreedomCheckBox.TabIndex = 18;
            this.FreedomCheckBox.Text = "Freedom";
            this.FreedomCheckBox.UseVisualStyleBackColor = true;
            // 
            // BroadbandCheckBox
            // 
            this.BroadbandCheckBox.AutoSize = true;
            this.BroadbandCheckBox.Location = new System.Drawing.Point(12, 58);
            this.BroadbandCheckBox.Name = "BroadbandCheckBox";
            this.BroadbandCheckBox.Size = new System.Drawing.Size(78, 17);
            this.BroadbandCheckBox.TabIndex = 19;
            this.BroadbandCheckBox.Text = "Broadband";
            this.BroadbandCheckBox.UseVisualStyleBackColor = true;
            // 
            // HumanCapitalCheckBox
            // 
            this.HumanCapitalCheckBox.AutoSize = true;
            this.HumanCapitalCheckBox.Location = new System.Drawing.Point(12, 81);
            this.HumanCapitalCheckBox.Name = "HumanCapitalCheckBox";
            this.HumanCapitalCheckBox.Size = new System.Drawing.Size(95, 17);
            this.HumanCapitalCheckBox.TabIndex = 20;
            this.HumanCapitalCheckBox.Text = "Human Capital";
            this.HumanCapitalCheckBox.UseVisualStyleBackColor = true;
            // 
            // TaxFriendlinessCheckBox
            // 
            this.TaxFriendlinessCheckBox.AutoSize = true;
            this.TaxFriendlinessCheckBox.Location = new System.Drawing.Point(12, 104);
            this.TaxFriendlinessCheckBox.Name = "TaxFriendlinessCheckBox";
            this.TaxFriendlinessCheckBox.Size = new System.Drawing.Size(102, 17);
            this.TaxFriendlinessCheckBox.TabIndex = 21;
            this.TaxFriendlinessCheckBox.Text = "Tax Friendliness";
            this.TaxFriendlinessCheckBox.UseVisualStyleBackColor = true;
            // 
            // EntrepreneurialActivityCheckBox
            // 
            this.EntrepreneurialActivityCheckBox.AutoSize = true;
            this.EntrepreneurialActivityCheckBox.Location = new System.Drawing.Point(146, 35);
            this.EntrepreneurialActivityCheckBox.Name = "EntrepreneurialActivityCheckBox";
            this.EntrepreneurialActivityCheckBox.Size = new System.Drawing.Size(134, 17);
            this.EntrepreneurialActivityCheckBox.TabIndex = 22;
            this.EntrepreneurialActivityCheckBox.Text = "Entrepreneurial Activity";
            this.EntrepreneurialActivityCheckBox.UseVisualStyleBackColor = true;
            // 
            // UnicornsCheckBox
            // 
            this.UnicornsCheckBox.AutoSize = true;
            this.UnicornsCheckBox.Location = new System.Drawing.Point(146, 58);
            this.UnicornsCheckBox.Name = "UnicornsCheckBox";
            this.UnicornsCheckBox.Size = new System.Drawing.Size(68, 17);
            this.UnicornsCheckBox.TabIndex = 23;
            this.UnicornsCheckBox.Text = "Unicorns";
            this.UnicornsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ResilienceCheckBox
            // 
            this.ResilienceCheckBox.AutoSize = true;
            this.ResilienceCheckBox.Location = new System.Drawing.Point(146, 81);
            this.ResilienceCheckBox.Name = "ResilienceCheckBox";
            this.ResilienceCheckBox.Size = new System.Drawing.Size(75, 17);
            this.ResilienceCheckBox.TabIndex = 24;
            this.ResilienceCheckBox.Text = "Resilience";
            this.ResilienceCheckBox.UseVisualStyleBackColor = true;
            // 
            // RDInvestmentCheckBox
            // 
            this.RDInvestmentCheckBox.AutoSize = true;
            this.RDInvestmentCheckBox.Location = new System.Drawing.Point(146, 12);
            this.RDInvestmentCheckBox.Name = "RDInvestmentCheckBox";
            this.RDInvestmentCheckBox.Size = new System.Drawing.Size(97, 17);
            this.RDInvestmentCheckBox.TabIndex = 25;
            this.RDInvestmentCheckBox.Text = "RD Investment";
            this.RDInvestmentCheckBox.UseVisualStyleBackColor = true;
            // 
            // DronesCheckBox
            // 
            this.DronesCheckBox.AutoSize = true;
            this.DronesCheckBox.Location = new System.Drawing.Point(146, 104);
            this.DronesCheckBox.Name = "DronesCheckBox";
            this.DronesCheckBox.Size = new System.Drawing.Size(60, 17);
            this.DronesCheckBox.TabIndex = 26;
            this.DronesCheckBox.Text = "Drones";
            this.DronesCheckBox.UseVisualStyleBackColor = true;
            // 
            // RidesharingCheckBox
            // 
            this.RidesharingCheckBox.AutoSize = true;
            this.RidesharingCheckBox.Location = new System.Drawing.Point(291, 12);
            this.RidesharingCheckBox.Name = "RidesharingCheckBox";
            this.RidesharingCheckBox.Size = new System.Drawing.Size(82, 17);
            this.RidesharingCheckBox.TabIndex = 27;
            this.RidesharingCheckBox.Text = "Ridesharing";
            this.RidesharingCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShortTermRentalsheckBox
            // 
            this.ShortTermRentalsheckBox.AutoSize = true;
            this.ShortTermRentalsheckBox.Location = new System.Drawing.Point(291, 35);
            this.ShortTermRentalsheckBox.Name = "ShortTermRentalsheckBox";
            this.ShortTermRentalsheckBox.Size = new System.Drawing.Size(117, 17);
            this.ShortTermRentalsheckBox.TabIndex = 28;
            this.ShortTermRentalsheckBox.Text = "Short-Term Rentals";
            this.ShortTermRentalsheckBox.UseVisualStyleBackColor = true;
            // 
            // SelfDrivingVehiclesCheckBox
            // 
            this.SelfDrivingVehiclesCheckBox.AutoSize = true;
            this.SelfDrivingVehiclesCheckBox.Location = new System.Drawing.Point(291, 58);
            this.SelfDrivingVehiclesCheckBox.Name = "SelfDrivingVehiclesCheckBox";
            this.SelfDrivingVehiclesCheckBox.Size = new System.Drawing.Size(123, 17);
            this.SelfDrivingVehiclesCheckBox.TabIndex = 29;
            this.SelfDrivingVehiclesCheckBox.Text = "Self-Driving Vehicles";
            this.SelfDrivingVehiclesCheckBox.UseVisualStyleBackColor = true;
            // 
            // EnvironmentCheckBox
            // 
            this.EnvironmentCheckBox.AutoSize = true;
            this.EnvironmentCheckBox.Location = new System.Drawing.Point(291, 81);
            this.EnvironmentCheckBox.Name = "EnvironmentCheckBox";
            this.EnvironmentCheckBox.Size = new System.Drawing.Size(85, 17);
            this.EnvironmentCheckBox.TabIndex = 30;
            this.EnvironmentCheckBox.Text = "Environment";
            this.EnvironmentCheckBox.UseVisualStyleBackColor = true;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(424, 181);
            this.Controls.Add(this.EnvironmentCheckBox);
            this.Controls.Add(this.SelfDrivingVehiclesCheckBox);
            this.Controls.Add(this.ShortTermRentalsheckBox);
            this.Controls.Add(this.RidesharingCheckBox);
            this.Controls.Add(this.DronesCheckBox);
            this.Controls.Add(this.RDInvestmentCheckBox);
            this.Controls.Add(this.ResilienceCheckBox);
            this.Controls.Add(this.UnicornsCheckBox);
            this.Controls.Add(this.EntrepreneurialActivityCheckBox);
            this.Controls.Add(this.TaxFriendlinessCheckBox);
            this.Controls.Add(this.HumanCapitalCheckBox);
            this.Controls.Add(this.BroadbandCheckBox);
            this.Controls.Add(this.FreedomCheckBox);
            this.Controls.Add(this.DiversityCheckBox);
            this.Controls.Add(this.SelectButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectForm";
            this.ShowIcon = false;
            this.Text = "Select Parameters";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.CheckBox DiversityCheckBox;
        private System.Windows.Forms.CheckBox FreedomCheckBox;
        private System.Windows.Forms.CheckBox BroadbandCheckBox;
        private System.Windows.Forms.CheckBox HumanCapitalCheckBox;
        private System.Windows.Forms.CheckBox TaxFriendlinessCheckBox;
        private System.Windows.Forms.CheckBox EntrepreneurialActivityCheckBox;
        private System.Windows.Forms.CheckBox UnicornsCheckBox;
        private System.Windows.Forms.CheckBox ResilienceCheckBox;
        private System.Windows.Forms.CheckBox RDInvestmentCheckBox;
        private System.Windows.Forms.CheckBox DronesCheckBox;
        private System.Windows.Forms.CheckBox RidesharingCheckBox;
        private System.Windows.Forms.CheckBox ShortTermRentalsheckBox;
        private System.Windows.Forms.CheckBox SelfDrivingVehiclesCheckBox;
        private System.Windows.Forms.CheckBox EnvironmentCheckBox;
    }
}