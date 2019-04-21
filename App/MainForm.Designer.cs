namespace App
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openResentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearRegistryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ParamDataGridView = new System.Windows.Forms.DataGridView();
            this.CountryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiversityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreedomColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BroadbandColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HumanCapitalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxFriendlinessColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RDInvestmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntrepreneurialActivityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnicornsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResilienceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DronesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RidesharingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortTermRentalsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelfDrivingVehiclesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnvironmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreDataGridView = new System.Windows.Forms.DataGridView();
            this.RankColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectButton = new System.Windows.Forms.Button();
            this.FilterScoreButton = new System.Windows.Forms.Button();
            this.DeleteScoreButton = new System.Windows.Forms.Button();
            this.AddParamButton = new System.Windows.Forms.Button();
            this.UpdateParamButton = new System.Windows.Forms.Button();
            this.FilterParamButton = new System.Windows.Forms.Button();
            this.DeleteParamButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParamDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1102, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.openResentToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.clearRegistryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem,
            this.sourceCodeToolStripMenuItem,
            this.sourceDataToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.authorToolStripMenuItem.Text = "Author";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.authorToolStripMenuItem_Click);
            // 
            // sourceCodeToolStripMenuItem
            // 
            this.sourceCodeToolStripMenuItem.Name = "sourceCodeToolStripMenuItem";
            this.sourceCodeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sourceCodeToolStripMenuItem.Text = "Source code";
            this.sourceCodeToolStripMenuItem.Click += new System.EventHandler(this.sourceCodeToolStripMenuItem_Click);
            // 
            // sourceDataToolStripMenuItem
            // 
            this.sourceDataToolStripMenuItem.Name = "sourceDataToolStripMenuItem";
            this.sourceDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sourceDataToolStripMenuItem.Text = "Source data";
            this.sourceDataToolStripMenuItem.Click += new System.EventHandler(this.sourceDataToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // openResentToolStripMenuItem
            // 
            this.openResentToolStripMenuItem.Name = "openResentToolStripMenuItem";
            this.openResentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openResentToolStripMenuItem.Text = "Open Resent";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // clearRegistryToolStripMenuItem
            // 
            this.clearRegistryToolStripMenuItem.Name = "clearRegistryToolStripMenuItem";
            this.clearRegistryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearRegistryToolStripMenuItem.Text = "Clear Registry";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // ParamDataGridView
            // 
            this.ParamDataGridView.AllowUserToAddRows = false;
            this.ParamDataGridView.AllowUserToDeleteRows = false;
            this.ParamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParamDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CountryColumn,
            this.DiversityColumn,
            this.FreedomColumn,
            this.BroadbandColumn,
            this.HumanCapitalColumn,
            this.TaxFriendlinessColumn,
            this.RDInvestmentColumn,
            this.EntrepreneurialActivityColumn,
            this.UnicornsColumn,
            this.ResilienceColumn,
            this.DronesColumn,
            this.RidesharingColumn,
            this.ShortTermRentalsColumn,
            this.SelfDrivingVehiclesColumn,
            this.EnvironmentColumn});
            this.ParamDataGridView.Location = new System.Drawing.Point(12, 62);
            this.ParamDataGridView.Name = "ParamDataGridView";
            this.ParamDataGridView.ReadOnly = true;
            this.ParamDataGridView.RowHeadersWidth = 20;
            this.ParamDataGridView.Size = new System.Drawing.Size(702, 327);
            this.ParamDataGridView.TabIndex = 1;
            this.ParamDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CountryColumn
            // 
            this.CountryColumn.HeaderText = "Country";
            this.CountryColumn.Name = "CountryColumn";
            this.CountryColumn.ReadOnly = true;
            this.CountryColumn.ToolTipText = "Country name";
            // 
            // DiversityColumn
            // 
            this.DiversityColumn.HeaderText = "Diversity";
            this.DiversityColumn.Name = "DiversityColumn";
            this.DiversityColumn.ReadOnly = true;
            this.DiversityColumn.ToolTipText = "Diversity  measures the concentrations of various ethnic groups within a country." +
    "";
            // 
            // FreedomColumn
            // 
            this.FreedomColumn.HeaderText = "Freedom";
            this.FreedomColumn.Name = "FreedomColumn";
            this.FreedomColumn.ReadOnly = true;
            // 
            // BroadbandColumn
            // 
            this.BroadbandColumn.HeaderText = "Broadband";
            this.BroadbandColumn.Name = "BroadbandColumn";
            this.BroadbandColumn.ReadOnly = true;
            // 
            // HumanCapitalColumn
            // 
            this.HumanCapitalColumn.HeaderText = "HumanCapital";
            this.HumanCapitalColumn.Name = "HumanCapitalColumn";
            this.HumanCapitalColumn.ReadOnly = true;
            // 
            // TaxFriendlinessColumn
            // 
            this.TaxFriendlinessColumn.HeaderText = "Tax Friendliness";
            this.TaxFriendlinessColumn.Name = "TaxFriendlinessColumn";
            this.TaxFriendlinessColumn.ReadOnly = true;
            // 
            // RDInvestmentColumn
            // 
            this.RDInvestmentColumn.HeaderText = "R&D Investment";
            this.RDInvestmentColumn.Name = "RDInvestmentColumn";
            this.RDInvestmentColumn.ReadOnly = true;
            // 
            // EntrepreneurialActivityColumn
            // 
            this.EntrepreneurialActivityColumn.HeaderText = "Entrepreneurial Activity";
            this.EntrepreneurialActivityColumn.Name = "EntrepreneurialActivityColumn";
            this.EntrepreneurialActivityColumn.ReadOnly = true;
            // 
            // UnicornsColumn
            // 
            this.UnicornsColumn.HeaderText = "Unicorns";
            this.UnicornsColumn.Name = "UnicornsColumn";
            this.UnicornsColumn.ReadOnly = true;
            // 
            // ResilienceColumn
            // 
            this.ResilienceColumn.HeaderText = "Resilience";
            this.ResilienceColumn.Name = "ResilienceColumn";
            this.ResilienceColumn.ReadOnly = true;
            // 
            // DronesColumn
            // 
            this.DronesColumn.HeaderText = "Drones";
            this.DronesColumn.Name = "DronesColumn";
            this.DronesColumn.ReadOnly = true;
            // 
            // RidesharingColumn
            // 
            this.RidesharingColumn.HeaderText = "Ridesharing";
            this.RidesharingColumn.Name = "RidesharingColumn";
            this.RidesharingColumn.ReadOnly = true;
            // 
            // ShortTermRentalsColumn
            // 
            this.ShortTermRentalsColumn.HeaderText = "Short-Term Rentals";
            this.ShortTermRentalsColumn.Name = "ShortTermRentalsColumn";
            this.ShortTermRentalsColumn.ReadOnly = true;
            // 
            // SelfDrivingVehiclesColumn
            // 
            this.SelfDrivingVehiclesColumn.HeaderText = "Self Driving Vehicles";
            this.SelfDrivingVehiclesColumn.Name = "SelfDrivingVehiclesColumn";
            this.SelfDrivingVehiclesColumn.ReadOnly = true;
            // 
            // EnvironmentColumn
            // 
            this.EnvironmentColumn.HeaderText = "Environment";
            this.EnvironmentColumn.Name = "EnvironmentColumn";
            this.EnvironmentColumn.ReadOnly = true;
            // 
            // ScoreDataGridView
            // 
            this.ScoreDataGridView.AllowUserToAddRows = false;
            this.ScoreDataGridView.AllowUserToDeleteRows = false;
            this.ScoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScoreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RankColumn,
            this.CountryScoreColumn,
            this.ScoreColumn});
            this.ScoreDataGridView.Location = new System.Drawing.Point(775, 62);
            this.ScoreDataGridView.Name = "ScoreDataGridView";
            this.ScoreDataGridView.ReadOnly = true;
            this.ScoreDataGridView.Size = new System.Drawing.Size(315, 327);
            this.ScoreDataGridView.TabIndex = 2;
            // 
            // RankColumn
            // 
            this.RankColumn.HeaderText = "Rank";
            this.RankColumn.Name = "RankColumn";
            this.RankColumn.ReadOnly = true;
            // 
            // CountryScoreColumn
            // 
            this.CountryScoreColumn.HeaderText = "Country";
            this.CountryScoreColumn.Name = "CountryScoreColumn";
            this.CountryScoreColumn.ReadOnly = true;
            // 
            // ScoreColumn
            // 
            this.ScoreColumn.HeaderText = "Score";
            this.ScoreColumn.Name = "ScoreColumn";
            this.ScoreColumn.ReadOnly = true;
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(720, 62);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(49, 327);
            this.SelectButton.TabIndex = 3;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // FilterScoreButton
            // 
            this.FilterScoreButton.Location = new System.Drawing.Point(774, 33);
            this.FilterScoreButton.Name = "FilterScoreButton";
            this.FilterScoreButton.Size = new System.Drawing.Size(75, 23);
            this.FilterScoreButton.TabIndex = 4;
            this.FilterScoreButton.Text = "Filter";
            this.FilterScoreButton.UseVisualStyleBackColor = true;
            // 
            // DeleteScoreButton
            // 
            this.DeleteScoreButton.Location = new System.Drawing.Point(855, 33);
            this.DeleteScoreButton.Name = "DeleteScoreButton";
            this.DeleteScoreButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteScoreButton.TabIndex = 5;
            this.DeleteScoreButton.Text = "Delete";
            this.DeleteScoreButton.UseVisualStyleBackColor = true;
            // 
            // AddParamButton
            // 
            this.AddParamButton.Location = new System.Drawing.Point(12, 33);
            this.AddParamButton.Name = "AddParamButton";
            this.AddParamButton.Size = new System.Drawing.Size(75, 23);
            this.AddParamButton.TabIndex = 6;
            this.AddParamButton.Text = "Add";
            this.AddParamButton.UseVisualStyleBackColor = true;
            // 
            // UpdateParamButton
            // 
            this.UpdateParamButton.Location = new System.Drawing.Point(94, 33);
            this.UpdateParamButton.Name = "UpdateParamButton";
            this.UpdateParamButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateParamButton.TabIndex = 7;
            this.UpdateParamButton.Text = "Update";
            this.UpdateParamButton.UseVisualStyleBackColor = true;
            // 
            // FilterParamButton
            // 
            this.FilterParamButton.Location = new System.Drawing.Point(176, 33);
            this.FilterParamButton.Name = "FilterParamButton";
            this.FilterParamButton.Size = new System.Drawing.Size(75, 23);
            this.FilterParamButton.TabIndex = 8;
            this.FilterParamButton.Text = "Filter";
            this.FilterParamButton.UseVisualStyleBackColor = true;
            // 
            // DeleteParamButton
            // 
            this.DeleteParamButton.Location = new System.Drawing.Point(258, 33);
            this.DeleteParamButton.Name = "DeleteParamButton";
            this.DeleteParamButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteParamButton.TabIndex = 9;
            this.DeleteParamButton.Text = "Delete";
            this.DeleteParamButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 402);
            this.Controls.Add(this.DeleteParamButton);
            this.Controls.Add(this.FilterParamButton);
            this.Controls.Add(this.UpdateParamButton);
            this.Controls.Add(this.AddParamButton);
            this.Controls.Add(this.DeleteScoreButton);
            this.Controls.Add(this.FilterScoreButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.ScoreDataGridView);
            this.Controls.Add(this.ParamDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "2019 International Innovation Scorecard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParamDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openResentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearRegistryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceDataToolStripMenuItem;
        private System.Windows.Forms.DataGridView ParamDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiversityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreedomColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BroadbandColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HumanCapitalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxFriendlinessColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RDInvestmentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntrepreneurialActivityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnicornsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResilienceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DronesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RidesharingColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortTermRentalsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelfDrivingVehiclesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnvironmentColumn;
        private System.Windows.Forms.DataGridView ScoreDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryScoreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreColumn;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button FilterScoreButton;
        private System.Windows.Forms.Button DeleteScoreButton;
        private System.Windows.Forms.Button AddParamButton;
        private System.Windows.Forms.Button UpdateParamButton;
        private System.Windows.Forms.Button FilterParamButton;
        private System.Windows.Forms.Button DeleteParamButton;
    }
}

