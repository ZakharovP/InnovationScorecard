namespace App.Forms
{
    partial class CountryZoomForm
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
            this.ParamDataGridView = new System.Windows.Forms.DataGridView();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ParamDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ParamDataGridView
            // 
            this.ParamDataGridView.AllowUserToAddRows = false;
            this.ParamDataGridView.AllowUserToDeleteRows = false;
            this.ParamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParamDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ParamDataGridView.Name = "ParamDataGridView";
            this.ParamDataGridView.Size = new System.Drawing.Size(924, 207);
            this.ParamDataGridView.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CloseButton.Location = new System.Drawing.Point(0, 241);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(948, 50);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CountryZoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 291);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ParamDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CountryZoomForm";
            this.ShowIcon = false;
            this.Text = "Parameters of Country";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.ParamDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ParamDataGridView;
        private System.Windows.Forms.Button CloseButton;
    }
}