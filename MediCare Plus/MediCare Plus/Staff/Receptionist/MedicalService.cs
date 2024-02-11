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
    public partial class MedicalService : UserControl
    {
        public MedicalService()
        {
            InitializeComponent();
        }

        //method for insert service data to database
        private void btnaddservice_Click(object sender, EventArgs e)
        {
            try
            {
                OtherMedIcalService newService = new OtherMedIcalService
                {
                    PatientAge = int.Parse(txtpatientage.Text),
                    PatientName = txtpatientname.Text,
                    MobileNumber = int.Parse(txtpmobilenumber.Text),
                    Email = txtpemail.Text,
                    Address = txtpaddress.Text,
                    RoomNumber = int.Parse(cmbroomnumber.Text),
                    ServiceType = cmbservicetype.Text,
                    Date = dtpdate.Value,
                    Time = double.Parse(cmbtime.Text)
                };

                bool success = OtherMedIcalService.Insert(newService);
                if (success)
                {
                    //clear text fields after successful Insertion
                    MessageBox.Show("Service inserted successfuly..!");
                    txtpatientage.Clear();
                    txtpatientname.Clear();
                    txtpmobilenumber.Clear();
                    txtpemail.Clear();
                    txtpaddress.Clear();
                    cmbroomnumber.Text = "";
                    cmbservicetype.Text = "";
                    cmbtime.Text = "";

                    dgvmedicalservice.DataSource = null;

                    //display all Inserted data through the datagridview
                    DataTable allData = OtherMedIcalService.GetAllData();
                    dgvmedicalservice.DataSource = allData;
                }
                else
                {
                    MessageBox.Show("Service not inserted properly, Try again..!");
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
        //method for display data through datagridview
        private void MedicalService_Load(object sender, EventArgs e)
        {
            //display all Inserted data through the datagridview
            DataTable allData = OtherMedIcalService.GetAllData();
            dgvmedicalservice.DataSource = allData;
        }
        //method for update service data to database
        private void btnrenew_Click(object sender, EventArgs e)
        {
            try
            {
                OtherMedIcalService updateService = new OtherMedIcalService
                {
                    PatientAge = int.Parse(txtpatientage.Text),
                    PatientName = txtpatientname.Text,
                    MobileNumber = int.Parse(txtpmobilenumber.Text),
                    Email = txtpemail.Text,
                    Address = txtpaddress.Text,
                    RoomNumber = int.Parse(cmbroomnumber.Text),
                    ServiceType = cmbservicetype.Text,
                    Date = dtpdate.Value,
                    Time = double.Parse(cmbtime.Text)
                };

                bool success = OtherMedIcalService.Update(updateService);
                if (success)
                {
                    MessageBox.Show("Service updated successfully.");
                    txtpatientage.Clear();
                    txtpatientname.Clear();
                    txtpmobilenumber.Clear();
                    txtpemail.Clear();
                    txtpaddress.Clear();
                    cmbroomnumber.Text = "";
                    cmbservicetype.Text = "";
                    cmbtime.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to update Service.");
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

        //search method for search medical service data
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtsearch.Text;

            try
            {
                DataTable searchResults = OtherMedIcalService.Search(searchKeyword);

                if (searchResults.Rows.Count > 0)
                {
                    txtpatientage.Text = searchResults.Rows[0]["patient_age"].ToString();
                    txtpatientname.Text = searchResults.Rows[0]["patient_name"].ToString();
                    txtpmobilenumber.Text = searchResults.Rows[0]["patient_mobileno"].ToString();
                    txtpemail.Text = searchResults.Rows[0]["patient_email"].ToString();
                    txtpaddress.Text = searchResults.Rows[0]["patient_address"].ToString();
                    cmbroomnumber.Text = searchResults.Rows[0]["room_no"].ToString();
                    cmbservicetype.Text = searchResults.Rows[0]["service_type"].ToString();
                    dtpdate.Text = searchResults.Rows[0]["service_date"].ToString();
                    cmbtime.Text = searchResults.Rows[0]["service_time"].ToString();
                }
                else
                {
                    txtpatientage.Clear();
                    txtpatientname.Clear();
                    txtpmobilenumber.Clear();
                    txtpemail.Clear();
                    txtpaddress.Clear();
                    cmbroomnumber.Text = "";
                    cmbservicetype.Text = "";
                    cmbtime.Text = "";

                    MessageBox.Show("No matching records found.");
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
    }
}
