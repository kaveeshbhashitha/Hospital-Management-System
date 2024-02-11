namespace MediCare_Plus.Staff.Receptionist
{
    partial class Payments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payments));
            this.btnmakepayment = new MediCare_Plus.Styles.RJButton();
            this.txtsearchpayment = new System.Windows.Forms.TextBox();
            this.btnsearch = new MediCare_Plus.Styles.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpatientname = new System.Windows.Forms.TextBox();
            this.txtdoctorname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotalcharge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdoctorcharge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtothercharges = new System.Windows.Forms.TextBox();
            this.txthospitalcharge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbservicetype = new System.Windows.Forms.ComboBox();
            this.btnprintbill = new MediCare_Plus.Styles.RJButton();
            this.dgvpaymentdetails = new System.Windows.Forms.DataGridView();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.lblpaymentid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpaymentdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmakepayment
            // 
            this.btnmakepayment.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnmakepayment.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnmakepayment.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnmakepayment.BorderRadius = 10;
            this.btnmakepayment.BorderSize = 0;
            this.btnmakepayment.FlatAppearance.BorderSize = 0;
            this.btnmakepayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmakepayment.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnmakepayment.ForeColor = System.Drawing.Color.White;
            this.btnmakepayment.Location = new System.Drawing.Point(74, 362);
            this.btnmakepayment.Name = "btnmakepayment";
            this.btnmakepayment.Size = new System.Drawing.Size(137, 40);
            this.btnmakepayment.TabIndex = 0;
            this.btnmakepayment.Text = "Make Payment";
            this.btnmakepayment.TextColor = System.Drawing.Color.White;
            this.btnmakepayment.UseVisualStyleBackColor = false;
            this.btnmakepayment.Click += new System.EventHandler(this.btnmakepayment_Click);
            // 
            // txtsearchpayment
            // 
            this.txtsearchpayment.Location = new System.Drawing.Point(396, 70);
            this.txtsearchpayment.Multiline = true;
            this.txtsearchpayment.Name = "txtsearchpayment";
            this.txtsearchpayment.PlaceholderText = "Search charge by patient email";
            this.txtsearchpayment.Size = new System.Drawing.Size(186, 23);
            this.txtsearchpayment.TabIndex = 1;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.SeaGreen;
            this.btnsearch.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnsearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnsearch.BorderRadius = 5;
            this.btnsearch.BorderSize = 0;
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(588, 67);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(86, 28);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "Search";
            this.btnsearch.TextColor = System.Drawing.Color.White;
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(74, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient Name";
            // 
            // txtpatientname
            // 
            this.txtpatientname.Location = new System.Drawing.Point(75, 127);
            this.txtpatientname.Multiline = true;
            this.txtpatientname.Name = "txtpatientname";
            this.txtpatientname.Size = new System.Drawing.Size(279, 30);
            this.txtpatientname.TabIndex = 4;
            // 
            // txtdoctorname
            // 
            this.txtdoctorname.Location = new System.Drawing.Point(396, 128);
            this.txtdoctorname.Multiline = true;
            this.txtdoctorname.Name = "txtdoctorname";
            this.txtdoctorname.Size = new System.Drawing.Size(280, 30);
            this.txtdoctorname.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(396, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Doctor\'s Name";
            // 
            // txttotalcharge
            // 
            this.txttotalcharge.Location = new System.Drawing.Point(74, 317);
            this.txttotalcharge.Multiline = true;
            this.txttotalcharge.Name = "txttotalcharge";
            this.txttotalcharge.Size = new System.Drawing.Size(280, 30);
            this.txttotalcharge.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(74, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total Charge (Rs.)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(74, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(396, 303);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 267);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(33, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 30);
            this.label9.TabIndex = 20;
            this.label9.Text = "Payments";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(74, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hospital charges (Rs.)";
            // 
            // txtdoctorcharge
            // 
            this.txtdoctorcharge.Location = new System.Drawing.Point(396, 182);
            this.txtdoctorcharge.Multiline = true;
            this.txtdoctorcharge.Name = "txtdoctorcharge";
            this.txtdoctorcharge.Size = new System.Drawing.Size(280, 30);
            this.txtdoctorcharge.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(396, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Other charges (Rs.)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(396, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Doctor charges (Rs.)";
            // 
            // txtothercharges
            // 
            this.txtothercharges.Location = new System.Drawing.Point(396, 237);
            this.txtothercharges.Multiline = true;
            this.txtothercharges.Name = "txtothercharges";
            this.txtothercharges.Size = new System.Drawing.Size(280, 30);
            this.txtothercharges.TabIndex = 16;
            // 
            // txthospitalcharge
            // 
            this.txthospitalcharge.Location = new System.Drawing.Point(74, 236);
            this.txthospitalcharge.Multiline = true;
            this.txthospitalcharge.Name = "txthospitalcharge";
            this.txthospitalcharge.Size = new System.Drawing.Size(280, 30);
            this.txthospitalcharge.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(75, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Service type";
            // 
            // cmbservicetype
            // 
            this.cmbservicetype.FormattingEnabled = true;
            this.cmbservicetype.Items.AddRange(new object[] {
            "Channeling",
            "Admission",
            "Reports"});
            this.cmbservicetype.Location = new System.Drawing.Point(75, 70);
            this.cmbservicetype.Name = "cmbservicetype";
            this.cmbservicetype.Size = new System.Drawing.Size(279, 23);
            this.cmbservicetype.TabIndex = 23;
            // 
            // btnprintbill
            // 
            this.btnprintbill.BackColor = System.Drawing.Color.IndianRed;
            this.btnprintbill.BackgroundColor = System.Drawing.Color.IndianRed;
            this.btnprintbill.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnprintbill.BorderRadius = 10;
            this.btnprintbill.BorderSize = 0;
            this.btnprintbill.FlatAppearance.BorderSize = 0;
            this.btnprintbill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprintbill.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnprintbill.ForeColor = System.Drawing.Color.White;
            this.btnprintbill.Location = new System.Drawing.Point(223, 362);
            this.btnprintbill.Name = "btnprintbill";
            this.btnprintbill.Size = new System.Drawing.Size(131, 40);
            this.btnprintbill.TabIndex = 24;
            this.btnprintbill.Text = "Print bill";
            this.btnprintbill.TextColor = System.Drawing.Color.White;
            this.btnprintbill.UseVisualStyleBackColor = false;
            this.btnprintbill.Click += new System.EventHandler(this.btnprintbill_Click);
            // 
            // dgvpaymentdetails
            // 
            this.dgvpaymentdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpaymentdetails.Location = new System.Drawing.Point(15, 418);
            this.dgvpaymentdetails.Name = "dgvpaymentdetails";
            this.dgvpaymentdetails.RowTemplate.Height = 25;
            this.dgvpaymentdetails.Size = new System.Drawing.Size(361, 140);
            this.dgvpaymentdetails.TabIndex = 25;
            // 
            // dtpdate
            // 
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate.Location = new System.Drawing.Point(74, 181);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(280, 23);
            this.dtpdate.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(559, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Payment ID :";
            // 
            // lblpaymentid
            // 
            this.lblpaymentid.AutoSize = true;
            this.lblpaymentid.Location = new System.Drawing.Point(632, 18);
            this.lblpaymentid.Name = "lblpaymentid";
            this.lblpaymentid.Size = new System.Drawing.Size(44, 15);
            this.lblpaymentid.TabIndex = 28;
            this.lblpaymentid.Text = "label11";
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.lblpaymentid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.dgvpaymentdetails);
            this.Controls.Add(this.btnprintbill);
            this.Controls.Add(this.cmbservicetype);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtothercharges);
            this.Controls.Add(this.txthospitalcharge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdoctorcharge);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txttotalcharge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdoctorname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpatientname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearchpayment);
            this.Controls.Add(this.btnmakepayment);
            this.Name = "Payments";
            this.Size = new System.Drawing.Size(767, 585);
            this.Load += new System.EventHandler(this.Payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpaymentdetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Styles.RJButton btnmakepayment;
        private TextBox txtsearchpayment;
        private Styles.RJButton btnsearch;
        private Label label1;
        private TextBox txtpatientname;
        private TextBox txtdoctorname;
        private Label label2;
        private TextBox txttotalcharge;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label9;
        private Label label5;
        private TextBox txtdoctorcharge;
        private Label label7;
        private Label label6;
        private TextBox txtothercharges;
        private TextBox txthospitalcharge;
        private Label label8;
        private ComboBox cmbservicetype;
        private Styles.RJButton btnprintbill;
        private DataGridView dgvpaymentdetails;
        private DateTimePicker dtpdate;
        private Label label10;
        private Label lblpaymentid;
    }
}
