using MediCare_Plus.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediCare_Plus.Admin
{
    public partial class Doctors : UserControl
    {
        public Doctors()
        {
            InitializeComponent();
        }

        private void Doctors_Load(object sender, EventArgs e)
        {
            //change this to doctor data
            DataTable allData = ChannelDetails.GetAllData();

            // Bind the data to the DataGridView
            dgvdoctors.DataSource = allData;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtsearch.Text;

            try
            {
                DataTable searchResults = DoctorDetails.Search(searchKeyword);

                if (searchResults.Rows.Count > 0)
                {
                    lbldname.Text = searchResults.Rows[0]["doctor_name"].ToString();
                    lblspecialization.Text = searchResults.Rows[0]["doctor_specialization"].ToString();
                    lbltreatmentarea.Text = searchResults.Rows[0]["treatment_area"].ToString();
                    lblexperience.Text = searchResults.Rows[0]["doctor_experience"].ToString();
                    lbldoctorcharge.Text = searchResults.Rows[0]["doctor_nic"].ToString();
                    lbldate.Text = searchResults.Rows[0]["available_date"].ToString();
                    lbltime.Text = searchResults.Rows[0]["available_time"].ToString();
                    lbloffice.Text = searchResults.Rows[0]["room_number"].ToString();
                }
                else
                {
                    lbldname.Text = "null";
                    lblspecialization.Text = "null";
                    lbltreatmentarea.Text = "null";
                    lblexperience.Text = "null";
                    lbldoctorcharge.Text = "null";
                    lbldate.Text = "null";
                    lbltime.Text = "null";
                    lbloffice.Text = "null";

                    MessageBox.Show("No matching records found.");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Exception: " + sqlEx.Message);
            }
            catch (FormatException formatEx)
            {
                MessageBox.Show("Format Exception: " + formatEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
    }
}
