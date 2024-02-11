using MediCare_Plus.Admin;
using MediCare_Plus.Classes;
using MediCare_Plus.Common;
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
    public partial class PatientProfile : Form
    {
        public PatientProfile()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //private void rjButton1_Click(object sender, EventArgs e)
        //{
        //    Calendar calender = new Calendar();
        //    this.Hide();
        //    calender.Show();
        //}

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string patientName = txtsearch.Text;
            //change this to doctor data
            DataTable allData = ChannelDetails.GetDataForPatientName(patientName);

            // Bind the data to the DataGridView
            dgvpatIentdetails.DataSource = allData;
        }
    }
}
