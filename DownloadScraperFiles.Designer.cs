namespace TCM_Fortnite_Tool
{
    partial class DownloadScraperFiles
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadScraperFiles));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ProgressFinished = new Bunifu.Framework.UI.BunifuProgressBar();
            this.PercentageDone = new I_Laady_And_I_Chris_Project_MW3.NSLabel();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ProgressFinished
            // 
            this.ProgressFinished.BackColor = System.Drawing.Color.Silver;
            this.ProgressFinished.BorderRadius = 5;
            this.ProgressFinished.Location = new System.Drawing.Point(39, 41);
            this.ProgressFinished.MaximumValue = 100;
            this.ProgressFinished.Name = "ProgressFinished";
            this.ProgressFinished.ProgressColor = System.Drawing.Color.Teal;
            this.ProgressFinished.Size = new System.Drawing.Size(410, 27);
            this.ProgressFinished.TabIndex = 5;
            this.ProgressFinished.Value = 0;
            // 
            // PercentageDone
            // 
            this.PercentageDone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.PercentageDone.Location = new System.Drawing.Point(39, 12);
            this.PercentageDone.Name = "PercentageDone";
            this.PercentageDone.Size = new System.Drawing.Size(410, 23);
            this.PercentageDone.TabIndex = 4;
            this.PercentageDone.Value1 = "Percent Done: ";
            this.PercentageDone.Value2 = " ";
            // 
            // DownloadScraperFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(479, 84);
            this.Controls.Add(this.ProgressFinished);
            this.Controls.Add(this.PercentageDone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DownloadScraperFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Downloading Scraper Files...";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuProgressBar ProgressFinished;
        private I_Laady_And_I_Chris_Project_MW3.NSLabel PercentageDone;
    }
}