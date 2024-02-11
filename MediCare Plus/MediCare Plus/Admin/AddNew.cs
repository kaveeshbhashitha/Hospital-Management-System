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
    public partial class AddNew : UserControl
    {
        public AddNew()
        {
            InitializeComponent();
        }

        private void btnadddoc_Click(object sender, EventArgs e)
        {
            DoctorDetails newDoctor = new DoctorDetails
            {
                DoctorName = txtdoctorname.Text,
                DoctorSpecialization = cmbspecialization.Text,
                TreatmentArea = cmbtreaatmentarea.Text,
                Experience = cmbexperience.Text,
                Email = txtemail.Text,
                DoctorCharge = double.Parse(txtdoctorcharge.Text),
                Mobilenumber = txtmobileno.Text,
                AvailableDate = dtpavailableon.Value.Date,
                AvailableTime = double.Parse(txtavailabletime.Text),
                RoomNumber = int.Parse(txtroomno.Text)
            };

            try
            {
                bool success = DoctorDetails.Insert(newDoctor);
                if (success)
                {
                    MessageBox.Show("Doctor inserted successfuly..!");
                    txtdoctorname.Text = "";
                    cmbspecialization.Text = "";
                    cmbtreaatmentarea.Text = "";
                    cmbexperience.Text = "";
                    txtemail.Text = "";
                    txtdoctorcharge.Text = "";
                    txtmobileno.Text = "";
                    txtavailabletime.Text = "";
                    txtroomno.Text = "";
                }
                else
                {
                    MessageBox.Show("Doctor not inserted properly, Try again..!");
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

        private void btnupdatedoctor_Click(object sender, EventArgs e)
        {
            DoctorDetails updateDoctor = new DoctorDetails
            {
                DoctorName = txtdoctorname.Text,
                DoctorSpecialization = cmbspecialization.Text,
                TreatmentArea = cmbtreaatmentarea.Text,
                Experience = cmbexperience.Text,
                Email = txtemail.Text,
                DoctorCharge = double.Parse(txtdoctorcharge.Text),
                Mobilenumber = txtmobileno.Text,
                AvailableDate = dtpavailableon.Value.Date,
                AvailableTime = double.Parse(txtavailabletime.Text),
                RoomNumber = int.Parse(txtroomno.Text)
            };

            try
            {
                bool success = DoctorDetails.Update(updateDoctor);
                if (success)
                {
                    MessageBox.Show("Doctor updated successfully.");
                    txtsearch.Clear();
                    txtdoctorname.Text = "";
                    cmbspecialization.Text = "";
                    cmbtreaatmentarea.Text = "";
                    cmbexperience.Text = "";
                    txtemail.Text = "";
                    txtdoctorcharge.Text = "";
                    txtmobileno.Text = "";
                    txtavailabletime.Text = "";
                    txtroomno.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to update Doctor.");
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

        private void btndeletedoctor_Click(object sender, EventArgs e)
        {
            string doctorIDToDelete = txtsearch.Text;

            try
            {
                bool success = DoctorDetails.Delete(doctorIDToDelete);
                if (success)
                {
                    MessageBox.Show("Doctor was deleted successfully.");
                    txtsearch.Clear();
                    txtdoctorname.Text = "";
                    cmbspecialization.Text = "";
                    cmbtreaatmentarea.Text = "";
                    cmbexperience.Text = "";
                    txtemail.Text = "";
                    txtdoctorcharge.Text = "";
                    txtmobileno.Text = "";
                    txtavailabletime.Text = "";
                    txtroomno.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to delete Doctor.");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("There is a problem with your database." + sqlEx.Message);
            }
            catch (FormatException formatEx)
            {
                MessageBox.Show("Format of inserted data is not matching properly. " + formatEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured. Please try again." + ex.Message);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtsearch.Text;

            try
            {
                DataTable searchResults = DoctorDetails.Search(searchKeyword);

                if (searchResults.Rows.Count > 0)
                {
                    txtdoctorname.Text = searchResults.Rows[0]["doctor_name"].ToString();
                    cmbspecialization.Text = searchResults.Rows[0]["doctor_specialization"].ToString();
                    cmbtreaatmentarea.Text = searchResults.Rows[0]["treatment_area"].ToString();
                    cmbexperience.Text = searchResults.Rows[0]["doctor_experience"].ToString();
                    txtemail.Text = searchResults.Rows[0]["doctor_email"].ToString();
                    txtdoctorcharge.Text = searchResults.Rows[0]["doctor_nic"].ToString();
                    txtmobileno.Text = searchResults.Rows[0]["doctor_mobile"].ToString();
                    dtpavailableon.Text = searchResults.Rows[0]["available_date"].ToString();
                    txtavailabletime.Text = searchResults.Rows[0]["available_time"].ToString();
                    txtroomno.Text = searchResults.Rows[0]["room_number"].ToString();
                }
                else
                {
                    txtdoctorname.Text = "";
                    cmbspecialization.Text = "";
                    cmbtreaatmentarea.Text = "";
                    cmbexperience.Text = "";
                    txtemail.Text = "";
                    txtdoctorcharge.Text = "";
                    txtmobileno.Text = "";
                    txtavailabletime.Text = "";
                    txtroomno.Text = "";

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

        private void btncleardoctor_Click(object sender, EventArgs e)
        {
            txtdoctorname.Text = "";
            cmbspecialization.Text = "";
            cmbtreaatmentarea.Text = "";
            cmbexperience.Text = "";
            txtemail.Text = "";
            txtdoctorcharge.Text = "";
            txtmobileno.Text = "";
            txtavailabletime.Text = "";
            txtroomno.Text = "";
        }
    }
}
