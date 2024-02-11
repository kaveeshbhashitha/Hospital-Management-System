using MediCare_Plus.Staff.Receptionist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediCare_Plus.Patient
{
    public partial class HospitalStaffLogin : Form
    {
        public HospitalStaffLogin()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Access access = new Access();
            this.Hide();
            access.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Registration registration = new Registration();
            //this.Hide();
            //registration.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReceptionistDashboard recepdash = new ReceptionistDashboard();

            string staffusername = txtstaffusername.Text;
            string staffpassword = txtstaffpassword.Text;

            if(staffusername == "rec" && staffpassword == "123")
            {
                this.Hide();
                recepdash.Show();
            }
            else if (staffusername == "doc" && staffpassword == "123")
            {
                
            }
            else if(staffusername == "" || staffpassword == "")
            {
                MessageBox.Show("Enter both username and password..!");
            }
            else
            {
                MessageBox.Show("Sorry, Login not success..!");
            }
        }
    }
}
