namespace App.Forms
{
    partial class ScoreFilterForm
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
            this.FilterButton = new System.Windows.Forms.Button();
            this.MinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // FilterButton
            // 
            this.FilterButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FilterButton.Location = new System.Drawing.Point(0, 46);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(326, 50);
            this.FilterButton.TabIndex = 0;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // MinNumericUpDown
            // 
            this.MinNumericUpDown.DecimalPlaces = 1;
            this.MinNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.MinNumericUpDown.Location = new System.Drawing.Point(138, 12);
            this.MinNumericUpDown.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.MinNumericUpDown.Name = "MinNumericUpDown";
            this.MinNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.MinNumericUpDown.TabIndex = 1;
            this.MinNumericUpDown.ThousandsSeparator = true;
            // 
            // MaxNumericUpDown
            // 
            this.MaxNumericUpDown.DecimalPlaces = 1;
            this.MaxNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.MaxNumericUpDown.Location = new System.Drawing.Point(235, 12);
            this.MaxNumericUpDown.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.MaxNumericUpDown.Name = "MaxNumericUpDown";
            this.MaxNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.MaxNumericUpDown.TabIndex = 2;
            this.MaxNumericUpDown.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "from";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Score:";
            // 
            // ScoreFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 96);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaxNumericUpDown);
            this.Controls.Add(this.MinNumericUpDown);
            this.Controls.Add(this.FilterButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScoreFilterForm";
            this.ShowIcon = false;
            this.Text = "Score Filter";
            ((System.ComponentModel.ISupportInitialize)(this.MinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.NumericUpDown MinNumericUpDown;
        private System.Windows.Forms.NumericUpDown MaxNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}