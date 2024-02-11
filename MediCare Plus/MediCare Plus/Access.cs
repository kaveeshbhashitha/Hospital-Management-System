using MediCare_Plus.Patient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediCare_Plus
{
    public partial class Access : Form
    {

        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn
        //    (
        //        int nLeft,
        //        int nTop,
        //        int nRight,
        //        int nBottom,
        //        int nWidthEllipse,
        //        int nHeightEllipse
        //    );
        public Access()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HospitalStaffLogin patientloging = new HospitalStaffLogin();
            this.Hide();
            patientloging.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            this.Hide();
            welcome.Show();
        }

        private void Access_Load(object sender, EventArgs e)
        {
            //button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));
            //button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));
            //button4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Registration registration = new Registration();
            //this.Hide();
            //registration.Show();
        }

        private void btnstafflogin_Click(object sender, EventArgs e)
        {
            AdminLogin staffsignin = new AdminLogin();
            this.Hide();
            staffsignin.Show();
        }
    }
}
