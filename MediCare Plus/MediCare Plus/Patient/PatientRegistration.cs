using MediCare_Plus.Classes;
using MediCare_Plus.Common;
using MediCare_Plus.Staff.Receptionist;
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

namespace MediCare_Plus.Patient
{
    public partial class PatientRegistration : UserControl
    {
        //create static variables to hold patIent details temporary
        public static string FirstName;
        public static string LastName;
        public static string MobileNumber;
        public static string Email;
        public static int Age;
        public static string Gender;
        public static string AllergyStatus;
        public PatientRegistration()
        {
            InitializeComponent();
        }

        //method to register patient for hospital
        private void btnchannel_Click(object sender, EventArgs e)
        {
            try
            {
                //assign values for static variables whIHc given by the user
                FirstName = txtpfirstname.Text;
                LastName = txtplastname.Text;
                Age = int.Parse(txtpage.Text);
                Gender = cmbpgender.Text;

                //create objects to handle window displaying
                Calendar cd = new Calendar();
                ReceptionistDashboard rd = new ReceptionistDashboard();

                PatientDetails newPatient = new PatientDetails
                {
                    FirstName = txtpfirstname.Text,
                    LastName = txtplastname.Text,
                    MobileNumber = txtpmobilenum.Text,
                    Email = txtpemail.Text,
                    Age = int.Parse(txtpage.Text),
                    Gender = cmbpgender.Text,
                    AllergyStatus = cmballergystatus.Text
                };

                bool success = PatientDetails.Insert(newPatient);
                if (success)
                {
                    //clear text fields after successful Insertion
                    MessageBox.Show("Patient inserted successfuly..!");
                    txtpfirstname.Clear();
                    txtplastname.Clear();
                    txtpmobilenum.Clear();
                    txtpemail.Clear();
                    txtpage.Clear();
                    cmbpgender.Text = "";
                    cmballergystatus.Text = "";
                    //show next window and hide this window
                    rd.Hide();
                    cd.Show();
                }
                else
                {
                    MessageBox.Show("Patient not inserted properly, Try again..!");
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

        //update patient method
        private void btnupdatepatient_Click(object sender, EventArgs e)
        {
            try
            {
                PatientDetails updatePatient = new PatientDetails
                {
                    FirstName = txtpfirstname.Text,
                    LastName = txtplastname.Text,
                    MobileNumber = txtpmobilenum.Text,
                    Email = txtpemail.Text,
                    Age = int.Parse(txtpage.Text),
                    Gender = cmbpgender.Text,
                    AllergyStatus = cmballergystatus.Text
                };

                bool success = PatientDetails.Update(updatePatient);
                if (success)
                {
                    MessageBox.Show("Patient updated successfully.");
                    txtpfirstname.Clear();
                    txtplastname.Clear();
                    txtpmobilenum.Clear();
                    txtpemail.Clear();
                    txtpage.Clear();
                    cmbpgender.Text = "";
                    cmballergystatus.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to update Patient.");
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

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchKeyword = txtpsearch.Text;

                DataTable searchResults = PatientDetails.Search(searchKeyword);

                if (searchResults.Rows.Count > 0)
                {
                    txtpfirstname.Text = searchResults.Rows[0]["patient_firstname"].ToString();
                    txtplastname.Text = searchResults.Rows[0]["patient_lastname"].ToString();
                    txtpmobilenum.Text = searchResults.Rows[0]["patient_mobileno"].ToString();
                    txtpemail.Text = searchResults.Rows[0]["patient_email"].ToString();
                    txtpage.Text = searchResults.Rows[0]["patient_age"].ToString();
                    cmbpgender.Text = searchResults.Rows[0]["patient_gender"].ToString();
                    cmballergystatus.Text = searchResults.Rows[0]["patient_allergy"].ToString();
                }
                else
                {
                    txtpfirstname.Clear();
                    txtplastname.Clear();
                    txtpmobilenum.Clear();
                    txtpemail.Clear();
                    txtpage.Clear();
                    cmbpgender.Text = "";
                    cmballergystatus.Text = "";

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

        private void btnchanneldirectly_Click(object sender, EventArgs e)
        {
            FirstName = txtpfirstname.Text;
            LastName = txtplastname.Text;
            Age = int.Parse(txtpage.Text);
            Gender = cmbpgender.Text;
            //create objects to handle window displaying
            Calendar cd = new Calendar();
            ReceptionistDashboard rd = new ReceptionistDashboard();

            rd.Hide();
            cd.Show();
        }
    }
}
