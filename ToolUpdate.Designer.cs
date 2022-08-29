namespace TCM_Fortnite_Tool
{
    partial class ToolUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolUpdate));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.PercentageDone = new I_Laady_And_I_Chris_Project_MW3.NSLabel();
            this.ProgressFinished = new Bunifu.Framework.UI.BunifuProgressBar();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOOL UPDATE FOUND!";
            // 
            // PercentageDone
            // 
            this.PercentageDone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.PercentageDone.Location = new System.Drawing.Point(44, 70);
            this.PercentageDone.Name = "PercentageDone";
            this.PercentageDone.Size = new System.Drawing.Size(410, 23);
            this.PercentageDone.TabIndex = 2;
            this.PercentageDone.Value1 = "Percent Done: ";
            this.PercentageDone.Value2 = " ";
            // 
            // ProgressFinished
            // 
            this.ProgressFinished.BackColor = System.Drawing.Color.Silver;
            this.ProgressFinished.BorderRadius = 5;
            this.ProgressFinished.Location = new System.Drawing.Point(44, 99);
            this.ProgressFinished.MaximumValue = 100;
            this.ProgressFinished.Name = "ProgressFinished";
            this.ProgressFinished.ProgressColor = System.Drawing.Color.Teal;
            this.ProgressFinished.Size = new System.Drawing.Size(410, 27);
            this.ProgressFinished.TabIndex = 3;
            this.ProgressFinished.Value = 0;
            // 
            // ToolUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(495, 148);
            this.Controls.Add(this.ProgressFinished);
            this.Controls.Add(this.PercentageDone);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToolUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Downloading Tool Update..";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private I_Laady_And_I_Chris_Project_MW3.NSLabel PercentageDone;
        private Bunifu.Framework.UI.BunifuProgressBar ProgressFinished;
    }
}