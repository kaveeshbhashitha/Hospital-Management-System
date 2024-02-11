namespace MediCare_Plus.Common
{
    partial class Calendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnpriviousmonth = new MediCare_Plus.Styles.RJButton();
            this.btnnextmonth = new MediCare_Plus.Styles.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.lbldate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // daycontainer
            // 
            this.daycontainer.BackColor = System.Drawing.SystemColors.Window;
            this.daycontainer.Location = new System.Drawing.Point(2, 146);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(1194, 507);
            this.daycontainer.TabIndex = 0;
            // 
            // btnpriviousmonth
            // 
            this.btnpriviousmonth.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnpriviousmonth.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnpriviousmonth.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnpriviousmonth.BorderRadius = 0;
            this.btnpriviousmonth.BorderSize = 0;
            this.btnpriviousmonth.FlatAppearance.BorderSize = 0;
            this.btnpriviousmonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpriviousmonth.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnpriviousmonth.ForeColor = System.Drawing.Color.White;
            this.btnpriviousmonth.Location = new System.Drawing.Point(890, 668);
            this.btnpriviousmonth.Name = "btnpriviousmonth";
            this.btnpriviousmonth.Size = new System.Drawing.Size(150, 39);
            this.btnpriviousmonth.TabIndex = 1;
            this.btnpriviousmonth.Text = "Previous";
            this.btnpriviousmonth.TextColor = System.Drawing.Color.White;
            this.btnpriviousmonth.UseVisualStyleBackColor = false;
            this.btnpriviousmonth.Click += new System.EventHandler(this.btnpriviousmonth_Click);
            // 
            // btnnextmonth
            // 
            this.btnnextmonth.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnnextmonth.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnnextmonth.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnnextmonth.BorderRadius = 0;
            this.btnnextmonth.BorderSize = 0;
            this.btnnextmonth.FlatAppearance.BorderSize = 0;
            this.btnnextmonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnextmonth.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnnextmonth.ForeColor = System.Drawing.Color.White;
            this.btnnextmonth.Location = new System.Drawing.Point(1046, 668);
            this.btnnextmonth.Name = "btnnextmonth";
            this.btnnextmonth.Size = new System.Drawing.Size(150, 39);
            this.btnnextmonth.TabIndex = 2;
            this.btnnextmonth.Text = "Next";
            this.btnnextmonth.TextColor = System.Drawing.Color.White;
            this.btnnextmonth.UseVisualStyleBackColor = false;
            this.btnnextmonth.Click += new System.EventHandler(this.btnnextmonth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sunday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(225, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Monday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(398, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tuesday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(555, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Wednesday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(736, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Thursday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(913, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Friday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1070, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Saturday";
            // 
            // btnback
            // 
            this.btnback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnback.BackgroundImage")));
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnback.Location = new System.Drawing.Point(1010, 36);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(164, 32);
            this.btnback.TabIndex = 16;
            this.btnback.Text = "Go Back";
            this.btnback.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbldate.Location = new System.Drawing.Point(63, 43);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(134, 25);
            this.lbldate.TabIndex = 17;
            this.lbldate.Text = "MONTH YEAR";
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1200, 716);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnnextmonth);
            this.Controls.Add(this.btnpriviousmonth);
            this.Controls.Add(this.daycontainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.Calendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel daycontainer;
        private Styles.RJButton btnpriviousmonth;
        private Styles.RJButton btnnextmonth;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnback;
        private Label lbldate;
    }
}