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
    public partial class Facilities : UserControl
    {
        public string doctorName;
        public int roomnumber;
        public Facilities()
        {
            InitializeComponent();
        }

        private void Facilities_Load(object sender, EventArgs e)
        {
            LoadDoctorNames();
            lblspecIalIzaton.Text = "";
            lblroomnumber.Text = "";
        }
        //Handle doctor names for combobox 
        private void LoadDoctorNames()
        {
            try
            {
                SqlConfiguration sqlconfig = new SqlConfiguration();
                string config = sqlconfig.SqlConnectionAccess();

                string SqldocName = "select doctor_name from doctor";

                SqlConnection conn = new SqlConnection(config);
                conn.Open();

                SqlCommand cmd = new SqlCommand(SqldocName, conn);

                SqlDataReader DR = cmd.ExecuteReader();

                while (DR.Read())
                {
                    cmbdoctorname.Items.Add(DR[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        //Handle doctor specialization for combobox 
        private void LoadDoctorSpecialization(string doctorname)
        {
            try
            {
                DataTable searchResults = DoctorDetails.Search(doctorName);

                if (searchResults.Rows.Count > 0)
                {
                    lblspecIalIzaton.Text = searchResults.Rows[0]["doctor_specialization"].ToString();
                    lblroomnumber.Text = searchResults.Rows[0]["room_number"].ToString();
                }
                else
                {
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

        //save facility data 
        private void btnaddfacIlIty_Click(object sender, EventArgs e)
        {
            doctorName = cmbdoctorname.Text;
            LoadDoctorSpecialization(doctorName);

            FacilityDetails newFacility = new FacilityDetails
            {
                RoomNumber = int.Parse(lblroomnumber.Text),
                DoctorName = cmbdoctorname.Text,
                DoctorSpecialization = lblspecIalIzaton.Text,
                AvailableDate = dtpservicedate.Value,
                AvailableTime = double.Parse(txtavailabletime.Text),
                Status = cmbstatus.Text,
                RoomCharge = double.Parse(txtroomcharge.Text),
                RoomType = cmbroomtype.Text
            };

            try
            {
                bool success = FacilityDetails.Insert(newFacility);
                if (success)
                {
                    MessageBox.Show("Facility inserted successfuly..!");
                    lblroomnumber.Text = "";
                    cmbdoctorname.Text = "";
                    lblspecIalIzaton.Text = "";
                    txtavailabletime.Clear();
                    cmbstatus.Text = "";
                    txtroomcharge.Clear();
                    cmbroomtype.Text = "";
                }
                else
                {
                    MessageBox.Show("User not inserted properly, Try again..!");
                }
            }
            catch (SqlException sqlEx)
            {
                // Handle SQL-specific exceptions 
                MessageBox.Show("SQL Exception: " + sqlEx.Message);
            }
            catch (FormatException formatEx)
            {
                // Handle format-related exceptions 
                MessageBox.Show("Format Exception: " + formatEx.Message);
            }
            catch (Exception ex)
            {
                // Handle other general exceptions.
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
    }
}


