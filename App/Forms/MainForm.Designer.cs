using Lib;

namespace App.Forms
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
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openResentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearRegistryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openResentToolStripMenuItem
            // 
            this.openResentToolStripMenuItem.Name = "openResentToolStripMenuItem";
            this.openResentToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openResentToolStripMenuItem.Text = "Open Resent";
            this.openResentToolStripMenuItem.Click += new System.EventHandler(this.openResentToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // clearRegistryToolStripMenuItem
            // 
            this.clearRegistryToolStripMenuItem.Name = "clearRegistryToolStripMenuItem";
            this.clearRegistryToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.clearRegistryToolStripMenuItem.Text = "Clear Registry";
            this.clearRegistryToolStripMenuItem.Click += new System.EventHandler(this.clearRegistryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.authorToolStripMenuItem.Text = "Author";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.authorToolStripMenuItem_Click);
            // 
            // sourceCodeToolStripMenuItem
            // 
            this.sourceCodeToolStripMenuItem.Name = "sourceCodeToolStripMenuItem";
            this.sourceCodeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sourceCodeToolStripMenuItem.Text = "Source code";
            this.sourceCodeToolStripMenuItem.Click += new System.EventHandler(this.sourceCodeToolStripMenuItem_Click);
            // 
            // sourceDataToolStripMenuItem
            // 
            this.sourceDataToolStripMenuItem.Name = "sourceDataToolStripMenuItem";
            this.sourceDataToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sourceDataToolStripMenuItem.Text = "Source data";
            this.sourceDataToolStripMenuItem.Click += new System.EventHandler(this.sourceDataToolStripMenuItem_Click);
            // 
            // ParamDataGridView
            // 
            this.ParamDataGridView.AllowUserToAddRows = false;
            this.ParamDataGridView.AllowUserToDeleteRows = false;
            this.ParamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParamDataGridView.Location = new System.Drawing.Point(12, 62);
            this.ParamDataGridView.Name = "ParamDataGridView";
            this.ParamDataGridView.ReadOnly = true;
            this.ParamDataGridView.RowHeadersWidth = 20;
            this.ParamDataGridView.Size = new System.Drawing.Size(702, 327);
            this.ParamDataGridView.TabIndex = 1;
            // 
            // CountryColumn
            // 
            this.CountryColumn.Name = "CountryColumn";
            // 
            // DiversityColumn
            // 
            this.DiversityColumn.Name = "DiversityColumn";
            // 
            // FreedomColumn
            // 
            this.FreedomColumn.Name = "FreedomColumn";
            // 
            // BroadbandColumn
            // 
            this.BroadbandColumn.Name = "BroadbandColumn";
            // 
            // HumanCapitalColumn
            // 
            this.HumanCapitalColumn.Name = "HumanCapitalColumn";
            // 
            // TaxFriendlinessColumn
            // 
            this.TaxFriendlinessColumn.Name = "TaxFriendlinessColumn";
            // 
            // RDInvestmentColumn
            // 
            this.RDInvestmentColumn.Name = "RDInvestmentColumn";
            // 
            // EntrepreneurialActivityColumn
            // 
            this.EntrepreneurialActivityColumn.Name = "EntrepreneurialActivityColumn";
            // 
            // UnicornsColumn
            // 
            this.UnicornsColumn.Name = "UnicornsColumn";
            // 
            // ResilienceColumn
            // 
            this.ResilienceColumn.Name = "ResilienceColumn";
            // 
            // DronesColumn
            // 
            this.DronesColumn.Name = "DronesColumn";
            // 
            // RidesharingColumn
            // 
            this.RidesharingColumn.Name = "RidesharingColumn";
            // 
            // ShortTermRentalsColumn
            // 
            this.ShortTermRentalsColumn.Name = "ShortTermRentalsColumn";
            // 
            // SelfDrivingVehiclesColumn
            // 
            this.SelfDrivingVehiclesColumn.Name = "SelfDrivingVehiclesColumn";
            // 
            // EnvironmentColumn
            // 
            this.EnvironmentColumn.Name = "EnvironmentColumn";
            // 
            // ScoreDataGridView
            // 
            this.ScoreDataGridView.AllowUserToAddRows = false;
            this.ScoreDataGridView.AllowUserToDeleteRows = false;
            this.ScoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.RankColumn.ToolTipText = "Position of the country in the sorted list by score.";
            // 
            // CountryScoreColumn
            // 
            this.CountryScoreColumn.HeaderText = "Country";
            this.CountryScoreColumn.Name = "CountryScoreColumn";
            this.CountryScoreColumn.ReadOnly = true;
            this.CountryScoreColumn.ToolTipText = "Country name.";
            // 
            // ScoreColumn
            // 
            this.ScoreColumn.HeaderText = "Score";
            this.ScoreColumn.Name = "ScoreColumn";
            this.ScoreColumn.ReadOnly = true;
            this.ScoreColumn.ToolTipText = "Score measures an average score through all selected categories.";
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
            this.FilterScoreButton.Click += new System.EventHandler(this.FilterScoreButton_Click);
            // 
            // DeleteScoreButton
            // 
            this.DeleteScoreButton.Location = new System.Drawing.Point(855, 33);
            this.DeleteScoreButton.Name = "DeleteScoreButton";
            this.DeleteScoreButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteScoreButton.TabIndex = 5;
            this.DeleteScoreButton.Text = "Delete";
            this.DeleteScoreButton.UseVisualStyleBackColor = true;
            this.DeleteScoreButton.Click += new System.EventHandler(this.DeleteScoreButton_Click);
            // 
            // AddParamButton
            // 
            this.AddParamButton.Location = new System.Drawing.Point(12, 33);
            this.AddParamButton.Name = "AddParamButton";
            this.AddParamButton.Size = new System.Drawing.Size(75, 23);
            this.AddParamButton.TabIndex = 6;
            this.AddParamButton.Text = "Add";
            this.AddParamButton.UseVisualStyleBackColor = true;
            this.AddParamButton.Click += new System.EventHandler(this.AddParamButton_Click);
            // 
            // UpdateParamButton
            // 
            this.UpdateParamButton.Location = new System.Drawing.Point(94, 33);
            this.UpdateParamButton.Name = "UpdateParamButton";
            this.UpdateParamButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateParamButton.TabIndex = 7;
            this.UpdateParamButton.Text = "Update";
            this.UpdateParamButton.UseVisualStyleBackColor = true;
            this.UpdateParamButton.Click += new System.EventHandler(this.UpdateParamButton_Click);
            // 
            // FilterParamButton
            // 
            this.FilterParamButton.Location = new System.Drawing.Point(176, 33);
            this.FilterParamButton.Name = "FilterParamButton";
            this.FilterParamButton.Size = new System.Drawing.Size(75, 23);
            this.FilterParamButton.TabIndex = 8;
            this.FilterParamButton.Text = "Filter";
            this.FilterParamButton.UseVisualStyleBackColor = true;
            this.FilterParamButton.Click += new System.EventHandler(this.FilterParamButton_Click);
            // 
            // DeleteParamButton
            // 
            this.DeleteParamButton.Location = new System.Drawing.Point(258, 33);
            this.DeleteParamButton.Name = "DeleteParamButton";
            this.DeleteParamButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteParamButton.TabIndex = 9;
            this.DeleteParamButton.Text = "Delete";
            this.DeleteParamButton.UseVisualStyleBackColor = true;
            this.DeleteParamButton.Click += new System.EventHandler(this.DeleteParamButton_Click);
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
            this.Load += new System.EventHandler(this.Form_Load);
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

