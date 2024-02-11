namespace MediCare_Plus.Common
{
    partial class UserControlarDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbldays = new System.Windows.Forms.Label();
            this.lbleventr = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbldays
            // 
            this.lbldays.AutoSize = true;
            this.lbldays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbldays.ForeColor = System.Drawing.SystemColors.Window;
            this.lbldays.Location = new System.Drawing.Point(12, 12);
            this.lbldays.Name = "lbldays";
            this.lbldays.Size = new System.Drawing.Size(26, 18);
            this.lbldays.TabIndex = 0;
            this.lbldays.Text = "00";
            // 
            // lbleventr
            // 
            this.lbleventr.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbleventr.ForeColor = System.Drawing.SystemColors.Window;
            this.lbleventr.Location = new System.Drawing.Point(3, 54);
            this.lbleventr.Name = "lbleventr";
            this.lbleventr.Size = new System.Drawing.Size(158, 23);
            this.lbleventr.TabIndex = 1;
            this.lbleventr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControlarDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Controls.Add(this.lbleventr);
            this.Controls.Add(this.lbldays);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UserControlarDays";
            this.Size = new System.Drawing.Size(164, 84);
            this.Load += new System.EventHandler(this.UserControlarDays_Load);
            this.Click += new System.EventHandler(this.UserControlarDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbldays;
        private Label lbleventr;
        private System.Windows.Forms.Timer timer1;
    }
}
