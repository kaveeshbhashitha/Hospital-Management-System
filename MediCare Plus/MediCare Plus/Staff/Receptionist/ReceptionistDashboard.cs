using MediCare_Plus.Common;
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

namespace MediCare_Plus.Staff.Receptionist
{
    public partial class ReceptionistDashboard : Form
    {
        public ReceptionistDashboard()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Access access = new Access();
            this.Hide();
            access.Show();
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            this.Hide();
            welcome.Show();
        }

        private void ReceptionistDashboard_Load(object sender, EventArgs e)
        {
            PatientRegistration pregistration = new PatientRegistration();
            recepdashcontainer.Controls.Add(pregistration);
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            recepdashcontainer.Controls.Clear();
            Payments payments = new Payments();
            recepdashcontainer.Controls.Add(payments);
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            recepdashcontainer.Controls.Clear();
            HospitalServices hospitalservices = new HospitalServices();
            recepdashcontainer.Controls.Add(hospitalservices);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            recepdashcontainer.Controls.Clear();
            PatientRegistration patientRegistration = new PatientRegistration();
            recepdashcontainer.Controls.Add(patientRegistration);
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            Calendar calender = new Calendar();
            this.Hide();
            calender.Show();
        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            //Allocation allo = new Allocation();
            //this.Hide();
            //allo.Show();
        }

        private void btntreatment_Click(object sender, EventArgs e)
        {
            recepdashcontainer.Controls.Clear();
            Treatments patientRegistration = new Treatments();
            recepdashcontainer.Controls.Add(patientRegistration);
        }

        private void rjButton6_Click_1(object sender, EventArgs e)
        {
            MedicalService service = new MedicalService();
            recepdashcontainer.Controls.Clear();
            recepdashcontainer.Controls.Add(service);
        }
    }
}
