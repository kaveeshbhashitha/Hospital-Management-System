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

namespace MediCare_Plus.Staff.Receptionist
{
    public partial class Treatments : UserControl
    {
        public Treatments()
        {
            InitializeComponent();
        }

        private void btnsearchpatIent_Click(object sender, EventArgs e)
        {
            try
            {
                string searchKeyword = txtpatientsearch.Text;

                DataTable searchResults1 = PatientDetails.Search(searchKeyword); //get selected data from channeling details table
                DataTable searchResults2 = ChannelDetails.GetDataForPatientName(searchKeyword); //get selected data from channeling details table
                DataTable allData = ChannelDetails.GetAllData(); //get all data from channeling details table

                if (searchResults1.Rows.Count > 0 && searchResults2.Rows.Count > 0)
                {
                    lblpname.Text = searchResults1.Rows[0]["patient_firstname"].ToString() +" "+ searchResults1.Rows[0]["patient_lastname"].ToString();
                    lblpage.Text = searchResults1.Rows[0]["patient_age"].ToString();
                    lblpgender.Text = searchResults1.Rows[0]["patient_gender"].ToString();
                    lblappoitmentno.Text = searchResults2.Rows[0]["channel_id"].ToString();
                    // Bind the data to the DataGridView
                    dgvdiagnosis.DataSource = allData;
                }
                else
                {
                    lblpname.Text = "";
                    lblpage.Text = "";
                    lblpgender.Text = "";
                    lblappoitmentno.Text = "";

                    MessageBox.Show("No matching records found.");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("There is a problem with your database." + sqlEx.Message);
            }
            catch (FormatException formatEx)
            {
                MessageBox.Show(",Format of inserted data is not matching properly. " + formatEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured. Please try again." + ex.Message);
            }
        }

        //add treatment record method
        private void btnaddrecord_Click(object sender, EventArgs e)
        {
            try
            {
                TreatmentDetails newTreatment = new TreatmentDetails
                {
                    PatientName = lblpname.Text,
                    PatientAge = int.Parse(lblpage.Text),
                    Gender = lblpgender.Text,
                    AppointmentNumber = lblappoitmentno.Text,
                    Illness = txtillness.Text,
                    Notes = txtnotes.Text,
                    Drug1 = txtdrug1.Text,
                    Drug2 = txtdrug2.Text,
                    Drug3 = txtdrug3.Text,
                    Drug4 = txtdrug4.Text,
                    Drug5 = txtdrug5.Text,
                    Drug6 = txtdrug6.Text,
                    Drug7 = txtdrug7.Text,
                    Drug8 = txtdrug8.Text
                };

                bool success = TreatmentDetails.Insert(newTreatment);
                if (success)
                {
                    //clear text fields after successful Insertion
                    MessageBox.Show("Treatment inserted successfuly..!");
                    lblpname.Text = "";
                    lblpage.Text = "";
                    lblpgender.Text = "";
                    lblappoitmentno.Text = "";
                    txtillness.Clear();
                    txtnotes.Clear();
                    txtdrug1.Clear();
                    txtdrug2.Clear();
                    txtdrug3.Clear();
                    txtdrug4.Clear();
                    txtdrug5.Clear();
                    txtdrug6.Clear();
                    txtdrug7.Clear();
                    txtdrug8.Clear();
                    dgvdiagnosis.DataSource = null;
                }
                else
                {
                    MessageBox.Show("Treatment not inserted properly, Try again..!");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("There is a problem with your database." + sqlEx.Message);
            }
            catch (FormatException formatEx)
            {
                MessageBox.Show(",Format of inserted data is not matching properly. " + formatEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured. Please try again." + ex.Message);
            }
        }
    }
}
