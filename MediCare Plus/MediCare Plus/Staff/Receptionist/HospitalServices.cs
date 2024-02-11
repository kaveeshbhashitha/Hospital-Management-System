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
    public partial class HospitalServices : UserControl
    {
        public HospitalServices()
        {
            InitializeComponent();
        }

        //Handle doctor names and specialization for combobox 
        private void LoadDoctorNames()
        {
            try
            {
                SqlConfiguration sqlconfig = new SqlConfiguration();
                string config = sqlconfig.SqlConnectionAccess();

                string query = "SELECT doctor_name, doctor_specialization FROM doctor WHERE available_date >= @Today";
                SqlConnection con = new SqlConnection(config);
                con.Open();

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Add a parameter for the current date
                    command.Parameters.AddWithValue("@Today", DateTime.Today);

                    using (SqlDataReader sdr = command.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            cmbdoctorname.Items.Add(sdr["doctor_name"].ToString());
                            cmbspecialization.Items.Add(sdr["doctor_specialization"].ToString());
                        }
                    }
                }
                con.Close();
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

        //search doctor details by doctor specialization
        private void btnsbyspecial_Click(object sender, EventArgs e)
        {
            string docspecialization = cmbspecialization.Text;
            DateTime datetoday = DateTime.Today;

            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();

                string query = "SELECT * FROM hospitalRoom WHERE doctor_specialization = '" + docspecialization + "' AND available_date >= '" + datetoday + "'";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with the results
                    adapter.Fill(dataTable);

                    // Bind the DataGridView to the DataTable
                    dgvdoctordetails.DataSource = dataTable;
                }
            }
        }

        //search doctor details by doctor name
        private void btnsbydoctorname_Click(object sender, EventArgs e)
        {
            string docName = cmbdoctorname.Text;
            DateTime datetoday = DateTime.Today;

            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();

                string query = "SELECT * FROM hospitalRoom WHERE doctor_name = '" + docName + "' AND available_date >= '" + datetoday + "'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with the results
                    adapter.Fill(dataTable);

                    // Bind the DataGridView to the DataTable
                    dgvdoctordetails.DataSource = dataTable;
                }
            }
        }

        //show hospItal room details
        private void btnselectdoc_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dgvdoctordetails.SelectedRows)
            {
                txtchargerroom.Text = selectedRow.Cells["room_charge"].Value.ToString();
                txtroomnumber.Text = selectedRow.Cells["room_number"].Value.ToString();
                txtavailable.Text = selectedRow.Cells["availability_status"].Value.ToString();
                cmbdoctorname.Text = selectedRow.Cells["doctor_name"].Value.ToString();
                cmbspecialization.Text = selectedRow.Cells["doctor_specialization"].Value.ToString();
            }
        }

        //load combo boxes with form load
        private void HospitalServices_Load(object sender, EventArgs e)
        {
            lbladmitid.Text = HospitalAdmission.createId();
            LoadDoctorNames();
        }

        //method for admIt patIent to hospital
        private void btnadmit_Click(object sender, EventArgs e)
        {
            try
            {
                HospitalAdmission newAdmission = new HospitalAdmission
                {
                    PatientAge = int.Parse(ttxtpatientage.Text),
                    PatientName = txtpatientname.Text, 
                    PatientMobile = txtpmobilenumber.Text,
                    PatientNic = txtpatientnic.Text,
                    AdmissionDate = dtpadmitindate.Value,
                    DoctorName = cmbdoctorname.Text,
                    DoctorSpecialization = cmbspecialization.Text,
                    RoomNumber = int.Parse(txtroomnumber.Text),
                    Status = txtavailable.Text,
                    Charge = double.Parse(txtchargerroom.Text),
                    GuardName = txtguardianname.Text,
                    GuardNic = txtguardiannIc.Text,
                    GuardMobileNo = txtguardianmobile.Text,
                    AdmissionID = lbladmitid.Text
                };

                bool success = HospitalAdmission.Insert(newAdmission);
                if (success)
                {
                    //clear text fields after successful Insertion
                    MessageBox.Show("Admission inserted successfully");
                    ttxtpatientage.Clear();
                    txtpatientname.Clear();
                    txtpmobilenumber.Clear();
                    txtpatientnic.Clear();
                    cmbdoctorname.Text = "";
                    cmbspecialization.Text = "";
                    txtroomnumber.Clear();
                    txtavailable.Clear();
                    txtchargerroom.Clear();
                    txtguardianname.Clear();
                    txtguardiannIc.Clear();
                    txtguardianmobile.Clear();
                    lbladmitid.Text = "";
                }
                else
                {
                    MessageBox.Show("Admission not inserted properly, Try again..!");
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

        //method to update data in hospital admissions
        private void btndIscharge_Click(object sender, EventArgs e)
        {
            try
            {
                HospitalAdmission updateAdmission = new HospitalAdmission
                {
                    PatientAge = int.Parse(ttxtpatientage.Text),
                    PatientName = txtpatientname.Text,
                    PatientMobile = txtpmobilenumber.Text,
                    PatientNic = txtpatientnic.Text,
                    AdmissionDate = dtpadmitindate.Value,
                    DoctorName = cmbdoctorname.Text,
                    DoctorSpecialization = cmbspecialization.Text,
                    RoomNumber = int.Parse(txtroomnumber.Text),
                    Status = txtavailable.Text,
                    Charge = double.Parse(txtchargerroom.Text),
                    GuardName = txtguardianname.Text,
                    GuardNic = txtguardiannIc.Text,
                    GuardMobileNo = txtguardianmobile.Text,
                    AdmissionID = lbladmitid.Text
                };

                bool success = HospitalAdmission.Update(updateAdmission);
                if (success)
                {
                    MessageBox.Show("Admission updated successfully.");
                    ttxtpatientage.Clear();
                    txtpatientname.Clear();
                    txtpmobilenumber.Clear();
                    txtpatientnic.Clear();
                    cmbdoctorname.Text = "";
                    cmbspecialization.Text = "";
                    txtroomnumber.Clear();
                    txtavailable.Clear();
                    txtchargerroom.Clear();
                    txtguardianname.Clear();
                    txtguardiannIc.Clear();
                    txtguardianmobile.Clear();
                    lbladmitid.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to update Admission.");
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

        private void btnsearchadmin_Click(object sender, EventArgs e)
        {
            try
            {
                string searchKeyword = txtpatientsearch.Text;

                DataTable searchResults = HospitalAdmission.Search(searchKeyword);

                if (searchResults.Rows.Count > 0)
                {
                    ttxtpatientage.Text = searchResults.Rows[0]["patient_age"].ToString();
                    txtpatientname.Text = searchResults.Rows[0]["patient_name"].ToString();
                    txtpmobilenumber.Text = searchResults.Rows[0]["patient_mobileno"].ToString();
                    txtpatientnic.Text = searchResults.Rows[0]["patient_nic"].ToString();
                    cmbdoctorname.Text = searchResults.Rows[0]["doctor_name"].ToString();
                    cmbspecialization.Text = searchResults.Rows[0]["doctor_specialization"].ToString();
                    dtpadmitindate.Text = searchResults.Rows[0]["admited_date"].ToString();
                    txtroomnumber.Text = searchResults.Rows[0]["room_number"].ToString();
                    txtavailable.Text = searchResults.Rows[0]["room_status"].ToString();
                    txtchargerroom.Text = searchResults.Rows[0]["room_charge_perday"].ToString();
                    txtguardianname.Text = searchResults.Rows[0]["guardian_name"].ToString();
                    txtguardiannIc.Text = searchResults.Rows[0]["guardian_nic"].ToString();
                    txtguardianmobile.Text = searchResults.Rows[0]["guardian_mobileno"].ToString();
                    lbladmitid.Text = searchResults.Rows[0]["admitting_ID"].ToString();
                }
                else
                {
                    ttxtpatientage.Clear();
                    txtpatientname.Clear();
                    txtpmobilenumber.Clear();
                    txtpatientnic.Clear();
                    cmbdoctorname.Text = "";
                    cmbspecialization.Text = "";
                    txtroomnumber.Clear();
                    txtavailable.Clear();
                    txtchargerroom.Clear();
                    txtguardianname.Clear();
                    txtguardiannIc.Clear();
                    txtguardianmobile.Clear();
                    lbladmitid.Text = "";

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
    }
}
