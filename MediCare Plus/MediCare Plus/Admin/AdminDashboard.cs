using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediCare_Plus.Admin
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin staffSignIn = new AdminLogin();
            this.Hide();
            staffSignIn.Show();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            AdminLogin staffSignIn = new AdminLogin();
            this.Hide();
            staffSignIn.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            Doctors doctors = new Doctors();
            adminlayoutpannel.Controls.Add(doctors);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            adminlayoutpannel.Controls.Clear();
            Doctors doctors = new Doctors();
            adminlayoutpannel.Controls.Add(doctors);
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            adminlayoutpannel.Controls.Clear();
            Schedule schedule = new Schedule();
            adminlayoutpannel.Controls.Add(schedule);
        }

        private void btnpatients_Click(object sender, EventArgs e)
        {
            adminlayoutpannel.Controls.Clear();
            Patients patients = new Patients();
            adminlayoutpannel.Controls.Add(patients);
        }

        private void btnfacilities_Click(object sender, EventArgs e)
        {
            adminlayoutpannel.Controls.Clear();
            Facilities facilities = new Facilities();
            adminlayoutpannel.Controls.Add(facilities);
        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {
            adminlayoutpannel.Controls.Clear();
            AddNew addnew = new AddNew();
            adminlayoutpannel.Controls.Add(addnew);
        }

        private void btnpayments_Click(object sender, EventArgs e)
        {
            adminlayoutpannel.Controls.Clear();
            Payments payments = new Payments();
            adminlayoutpannel.Controls.Add(payments);
        }

        private void btnbacktohome_Click(object sender, EventArgs e)
        {
            Access access = new Access();
            this.Hide();
            access.Show();
        }

        private void btnsystemusers_Click(object sender, EventArgs e)
        {
            adminlayoutpannel.Controls.Clear();
            SystemUsers suser = new SystemUsers();
            adminlayoutpannel.Controls.Add(suser);
        }

        private void btnpayments_Click_1(object sender, EventArgs e)
        {
            adminlayoutpannel.Controls.Clear();
            Payments pay = new Payments();
            adminlayoutpannel.Controls.Add(pay);
        }
    }
}
