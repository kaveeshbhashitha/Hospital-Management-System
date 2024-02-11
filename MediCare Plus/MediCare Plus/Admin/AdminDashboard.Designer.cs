namespace MediCare_Plus.Admin
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.btnback = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsystemusers = new MediCare_Plus.Styles.RJButton();
            this.btnpayments = new MediCare_Plus.Styles.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbacktohome = new MediCare_Plus.Styles.RJButton();
            this.btnaddnew = new MediCare_Plus.Styles.RJButton();
            this.btnfacilities = new MediCare_Plus.Styles.RJButton();
            this.btnpatients = new MediCare_Plus.Styles.RJButton();
            this.btnschedule = new MediCare_Plus.Styles.RJButton();
            this.btndoctors = new MediCare_Plus.Styles.RJButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminlayoutpannel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnback.BackgroundImage")));
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnback.Location = new System.Drawing.Point(601, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(164, 32);
            this.btnback.TabIndex = 17;
            this.btnback.Text = "Go Back";
            this.btnback.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.btnsystemusers);
            this.panel1.Controls.Add(this.btnpayments);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnbacktohome);
            this.panel1.Controls.Add(this.btnaddnew);
            this.panel1.Controls.Add(this.btnfacilities);
            this.panel1.Controls.Add(this.btnpatients);
            this.panel1.Controls.Add(this.btnschedule);
            this.panel1.Controls.Add(this.btndoctors);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 600);
            this.panel1.TabIndex = 18;
            // 
            // btnsystemusers
            // 
            this.btnsystemusers.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnsystemusers.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnsystemusers.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnsystemusers.BorderRadius = 0;
            this.btnsystemusers.BorderSize = 0;
            this.btnsystemusers.FlatAppearance.BorderSize = 0;
            this.btnsystemusers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsystemusers.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsystemusers.ForeColor = System.Drawing.Color.White;
            this.btnsystemusers.Location = new System.Drawing.Point(0, 440);
            this.btnsystemusers.Name = "btnsystemusers";
            this.btnsystemusers.Size = new System.Drawing.Size(211, 40);
            this.btnsystemusers.TabIndex = 0;
            this.btnsystemusers.Text = "            System Users";
            this.btnsystemusers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsystemusers.TextColor = System.Drawing.Color.White;
            this.btnsystemusers.UseVisualStyleBackColor = false;
            this.btnsystemusers.Click += new System.EventHandler(this.btnsystemusers_Click);
            // 
            // btnpayments
            // 
            this.btnpayments.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnpayments.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnpayments.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnpayments.BorderRadius = 0;
            this.btnpayments.BorderSize = 0;
            this.btnpayments.FlatAppearance.BorderSize = 0;
            this.btnpayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpayments.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnpayments.ForeColor = System.Drawing.Color.White;
            this.btnpayments.Location = new System.Drawing.Point(0, 483);
            this.btnpayments.Name = "btnpayments";
            this.btnpayments.Size = new System.Drawing.Size(211, 40);
            this.btnpayments.TabIndex = 13;
            this.btnpayments.Text = "            Payments";
            this.btnpayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpayments.TextColor = System.Drawing.Color.White;
            this.btnpayments.UseVisualStyleBackColor = false;
            this.btnpayments.Click += new System.EventHandler(this.btnpayments_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dasboard";
            // 
            // btnbacktohome
            // 
            this.btnbacktohome.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnbacktohome.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnbacktohome.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnbacktohome.BorderRadius = 0;
            this.btnbacktohome.BorderSize = 0;
            this.btnbacktohome.FlatAppearance.BorderSize = 0;
            this.btnbacktohome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbacktohome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnbacktohome.ForeColor = System.Drawing.Color.White;
            this.btnbacktohome.Location = new System.Drawing.Point(0, 526);
            this.btnbacktohome.Name = "btnbacktohome";
            this.btnbacktohome.Size = new System.Drawing.Size(211, 40);
            this.btnbacktohome.TabIndex = 9;
            this.btnbacktohome.Text = "            Back to home";
            this.btnbacktohome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbacktohome.TextColor = System.Drawing.Color.White;
            this.btnbacktohome.UseVisualStyleBackColor = false;
            this.btnbacktohome.Click += new System.EventHandler(this.btnbacktohome_Click);
            // 
            // btnaddnew
            // 
            this.btnaddnew.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnaddnew.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnaddnew.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnaddnew.BorderRadius = 0;
            this.btnaddnew.BorderSize = 0;
            this.btnaddnew.FlatAppearance.BorderSize = 0;
            this.btnaddnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddnew.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnaddnew.ForeColor = System.Drawing.Color.White;
            this.btnaddnew.Location = new System.Drawing.Point(0, 396);
            this.btnaddnew.Name = "btnaddnew";
            this.btnaddnew.Size = new System.Drawing.Size(211, 40);
            this.btnaddnew.TabIndex = 10;
            this.btnaddnew.Text = "            New doctor";
            this.btnaddnew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddnew.TextColor = System.Drawing.Color.White;
            this.btnaddnew.UseVisualStyleBackColor = false;
            this.btnaddnew.Click += new System.EventHandler(this.btnaddnew_Click);
            // 
            // btnfacilities
            // 
            this.btnfacilities.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnfacilities.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnfacilities.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnfacilities.BorderRadius = 0;
            this.btnfacilities.BorderSize = 0;
            this.btnfacilities.FlatAppearance.BorderSize = 0;
            this.btnfacilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfacilities.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnfacilities.ForeColor = System.Drawing.Color.White;
            this.btnfacilities.Location = new System.Drawing.Point(0, 352);
            this.btnfacilities.Name = "btnfacilities";
            this.btnfacilities.Size = new System.Drawing.Size(211, 40);
            this.btnfacilities.TabIndex = 8;
            this.btnfacilities.Text = "            Facilities";
            this.btnfacilities.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfacilities.TextColor = System.Drawing.Color.White;
            this.btnfacilities.UseVisualStyleBackColor = false;
            this.btnfacilities.Click += new System.EventHandler(this.btnfacilities_Click);
            // 
            // btnpatients
            // 
            this.btnpatients.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnpatients.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnpatients.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnpatients.BorderRadius = 0;
            this.btnpatients.BorderSize = 0;
            this.btnpatients.FlatAppearance.BorderSize = 0;
            this.btnpatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpatients.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnpatients.ForeColor = System.Drawing.Color.White;
            this.btnpatients.Location = new System.Drawing.Point(0, 307);
            this.btnpatients.Name = "btnpatients";
            this.btnpatients.Size = new System.Drawing.Size(211, 40);
            this.btnpatients.TabIndex = 6;
            this.btnpatients.Text = "            Patients";
            this.btnpatients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpatients.TextColor = System.Drawing.Color.White;
            this.btnpatients.UseVisualStyleBackColor = false;
            this.btnpatients.Click += new System.EventHandler(this.btnpatients_Click);
            // 
            // btnschedule
            // 
            this.btnschedule.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnschedule.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnschedule.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnschedule.BorderRadius = 0;
            this.btnschedule.BorderSize = 0;
            this.btnschedule.FlatAppearance.BorderSize = 0;
            this.btnschedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnschedule.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnschedule.ForeColor = System.Drawing.Color.White;
            this.btnschedule.Location = new System.Drawing.Point(0, 263);
            this.btnschedule.Name = "btnschedule";
            this.btnschedule.Size = new System.Drawing.Size(211, 40);
            this.btnschedule.TabIndex = 7;
            this.btnschedule.Text = "            Schedules";
            this.btnschedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnschedule.TextColor = System.Drawing.Color.White;
            this.btnschedule.UseVisualStyleBackColor = false;
            this.btnschedule.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // btndoctors
            // 
            this.btndoctors.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btndoctors.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btndoctors.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btndoctors.BorderRadius = 0;
            this.btndoctors.BorderSize = 0;
            this.btndoctors.FlatAppearance.BorderSize = 0;
            this.btndoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndoctors.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndoctors.ForeColor = System.Drawing.Color.White;
            this.btndoctors.Location = new System.Drawing.Point(0, 219);
            this.btndoctors.Name = "btndoctors";
            this.btndoctors.Size = new System.Drawing.Size(211, 40);
            this.btndoctors.TabIndex = 4;
            this.btndoctors.Text = "            Doctors";
            this.btndoctors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndoctors.TextColor = System.Drawing.Color.White;
            this.btndoctors.UseVisualStyleBackColor = false;
            this.btndoctors.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 95);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // adminlayoutpannel
            // 
            this.adminlayoutpannel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.adminlayoutpannel.Location = new System.Drawing.Point(236, 70);
            this.adminlayoutpannel.Name = "adminlayoutpannel";
            this.adminlayoutpannel.Size = new System.Drawing.Size(760, 520);
            this.adminlayoutpannel.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.Controls.Add(this.btnback);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(231, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 64);
            this.panel2.TabIndex = 19;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.adminlayoutpannel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnback;
        private Panel panel1;
        private Panel panel2;
        private Styles.RJButton btnpatients;
        private Styles.RJButton btnschedule;
        private Styles.RJButton btndoctors;
        private PictureBox pictureBox1;
        private Styles.RJButton btnbacktohome;
        private Styles.RJButton btnaddnew;
        private Styles.RJButton btnfacilities;
        private Label label1;
        private FlowLayoutPanel adminlayoutpannel;
        private Styles.RJButton btnpayments;
        private Styles.RJButton btnsystemusers;
    }
}