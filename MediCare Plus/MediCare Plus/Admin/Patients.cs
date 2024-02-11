using MediCare_Plus.Patient;
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
    public partial class Patients : UserControl
    {
        public Patients()
        {
            InitializeComponent();
        }

        private void btnseemore_Click(object sender, EventArgs e)
        {
            PatientProfile pprofile = new PatientProfile();
            pprofile.Show();
        }
    }
}
