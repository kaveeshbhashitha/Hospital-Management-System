using MediCare_Plus.Classes;
using MediCare_Plus.Patient;
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

namespace MediCare_Plus.Common
{
    public partial class ScheduleForm : Form
    {
        private const int CS_DropShadow = 0x00020000;

        public ScheduleForm()
        {
            InitializeComponent();
        }
        //add box shadow for this interface
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }
        }

        //method for close the window
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //form load method for load window and display details
        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            txtdate.Text = Calendar.syear + "/" + Calendar.smonth + "/" + UserControlarDays.static_day;
            lblpatientname.Text = PatientRegistration.FirstName +" "+PatientRegistration.LastName;
            lblpatientage.Text = PatientRegistration.Age.ToString();
            lblgender.Text = PatientRegistration.Gender;
            //free up lables until search doctor detaIls
            lbldoctorname.Text = "";
            lbldoctorspecializatIon.Text = "";
            lbldoctorchrger.Text = "";
            lblroomnumber.Text = "";
            lbldate.Text = "";
            lbltime.Text = "";
            lbltotalcharge.Text = "";
            lblhospitalcharge.Text = "";
            lblchannelid.Text = ChannelDetails.createId();

            LoadDoctorNames();
        }

        //make reservation for meet doctor
        private void btnreservation_Click(object sender, EventArgs e)
        {
            try
            {
                //create array object using channeling data class
                ChannelDetails newChannel = new ChannelDetails
                {
                    PatientName = lblpatientname.Text,
                    Age = int.TryParse(lblpatientage.Text, out int age) ? age : 0, 
                    Gender = lblgender.Text,
                    RoomNumber = int.TryParse(lblroomnumber.Text, out int roomNumber) ? roomNumber : 0, 
                    DoctorName = lbldoctorname.Text,
                    DoctorSpecialization = lbldoctorspecializatIon.Text,
                    AvailableDate = DateTime.TryParse(lbldate.Text, out DateTime date) ? date : DateTime.MinValue, 
                    AvailableTime = double.TryParse(lbltime.Text, out double time) ? time : 0.0, 
                    DoctorCharge = double.Parse(lbldoctorchrger.Text),
                    HospitalCharge = double.Parse(lblhospitalcharge.Text),
                    TotalCharge = double.Parse(lbltotalcharge.Text),
                    ChannelId = lblchannelid.Text
                    //HospitalCharge = double.TryParse(lblhospitalcharge.Text, out double hospitalCharge) ? hospitalCharge : 0.0, 
                };
                //try insert method
                bool success = ChannelDetails.Insert(newChannel);
                if (success)
                {
                    MessageBox.Show("User inserted successfuly..!");
                    lblpatientname.Text = "";
                    lblpatientage.Text = "";
                    lblgender.Text = "";
                    lblroomnumber.Text = "";
                    lbldoctorname.Text = "";
                    lbldoctorspecializatIon.Text = "";
                    lbldate.Text = "";
                    lbltime.Text = "";
                    lbldoctorchrger.Text = "";
                    lblhospitalcharge.Text = "";
                    lbltotalcharge.Text = "";
                    lblchannelid.Text = "";
                }
                else
                {
                    MessageBox.Show("User not inserted properly, Try again..!");
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

        //Handle doctor names and specialization for combobox 
        private void LoadDoctorNames()
        {
            try
            {
                SqlConfiguration sqlconfig = new SqlConfiguration();
                string config = sqlconfig.SqlConnectionAccess();

                string query = "SELECT doctor_name, doctor_specialization FROM doctor";
                SqlConnection con = new SqlConnection(config);
                con.Open();

                using (SqlCommand command = new SqlCommand(query, con))
                using (SqlDataReader sdr = command.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        cmbdoctorname.Items.Add(sdr["doctor_name"].ToString());
                        cmbspecialization.Items.Add(sdr["doctor_specialization"].ToString());
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        //search doctor details by doctor specialization
        private void btnsearch_Click(object sender, EventArgs e)
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
                    dgvschedule.DataSource = dataTable;
                }
            }
        }
        //search doctor details by doctor name
        private void btnsearchbyname_Click(object sender, EventArgs e)
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
                    dgvschedule.DataSource = dataTable;
                }
            }
        }
        //method to select one doctor row form data grid view and show it through text boxes
        private void btnadd_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dgvschedule.SelectedRows)
            {
                // You can access cell values using column indexes or column names.
                lbldoctorname.Text = selectedRow.Cells["doctor_name"].Value.ToString();
                lbldoctorspecializatIon.Text = selectedRow.Cells["doctor_specialization"].Value.ToString();
                lbldoctorchrger.Text = selectedRow.Cells["room_charge"].Value.ToString();
                lblroomnumber.Text = selectedRow.Cells["room_number"].Value.ToString();

                DateTime selectedDate = (DateTime)selectedRow.Cells["available_date"].Value;
                //lbldate.Text = selectedDate.ToString("yyyy-MM-dd");
                lbldate.Text = selectedRow.Cells["available_date"].Value.ToString();

                lbltime.Text = selectedRow.Cells["available_time"].Value.ToString();

                double hospitalCharge = 500.00;
                double docCharge = double.Parse(selectedRow.Cells["room_charge"].Value.ToString());
                double totalCharege = hospitalCharge + docCharge;
                lbltotalcharge.Text = totalCharege.ToString();
                lblhospitalcharge.Text = hospitalCharge.ToString();
            }
        }
        //update channeling information
        private void btnrenew_Click(object sender, EventArgs e)
        {
            try
            {
                ChannelDetails updateChannel = new ChannelDetails
                {
                    PatientName = lblpatientname.Text,
                    Age = int.TryParse(lblpatientage.Text, out int age) ? age : 0,
                    Gender = lblgender.Text,
                    RoomNumber = int.TryParse(lblroomnumber.Text, out int roomNumber) ? roomNumber : 0,
                    DoctorName = lbldoctorname.Text,
                    DoctorSpecialization = lbldoctorspecializatIon.Text,
                    AvailableDate = DateTime.TryParse(lbldate.Text, out DateTime date) ? date : DateTime.MinValue,
                    AvailableTime = double.TryParse(lbltime.Text, out double time) ? time : 0.0,
                    DoctorCharge = double.TryParse(lbldoctorchrger.Text, out double doctorCharge) ? doctorCharge : 0.0,
                    HospitalCharge = double.TryParse(lblhospitalcharge.Text, out double hospitalCharge) ? hospitalCharge : 0.0,
                    TotalCharge = double.TryParse(lbltotalcharge.Text, out double totalCharge) ? totalCharge : 0.0,
                    ChannelId = lblchannelid.Text
                };

                bool success = ChannelDetails.Update(updateChannel);
                if (success)
                {
                    MessageBox.Show("Channeling details updated successfuly..!");
                    lblpatientname.Text = "";
                    lblpatientage.Text = "";
                    lblgender.Text = "";
                    lblroomnumber.Text = "";
                    lbldoctorname.Text = "";
                    lbldoctorspecializatIon.Text = "";
                    lbldate.Text = "";
                    lbltime.Text = "";
                    lbldoctorchrger.Text = "";
                    lblhospitalcharge.Text = "";
                    lbltotalcharge.Text = "";
                    lblchannelid.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to update channeling data.");
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
        //delete channeling data
        private void btncancel_Click(object sender, EventArgs e)
        {
            string searchCiD = txtsearch.Text;

            try
            {
                bool success = ChannelDetails.Delete(searchCiD);
                if (success)
                {
                    MessageBox.Show("Record deleted successfully.");
                    txtsearch.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to delete Record.");
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

        //search method to search channeling data
        private void btnsearchreservation_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtsearch.Text;

            try
            {
                DataTable searchResults = ChannelDetails.Search(searchKeyword);

                if (searchResults.Rows.Count > 0)
                {
                    lblpatientname.Text = searchResults.Rows[0]["patient_name"].ToString();
                    lblpatientage.Text = searchResults.Rows[0]["patient_age"].ToString();
                    lblgender.Text = searchResults.Rows[0]["patient_gender"].ToString();
                    lblroomnumber.Text = searchResults.Rows[0]["doctor_name"].ToString();
                    lbldoctorname.Text = searchResults.Rows[0]["doctor_specialization"].ToString();
                    lbldoctorspecializatIon.Text = searchResults.Rows[0]["room_number"].ToString();
                    lbldate.Text = searchResults.Rows[0]["chanel_date"].ToString();
                    lbltime.Text = searchResults.Rows[0]["chanel_time"].ToString();
                    lbldoctorchrger.Text = searchResults.Rows[0]["doctor_charge"].ToString();
                    lblhospitalcharge.Text = searchResults.Rows[0]["hospital_charge"].ToString();
                    lbltotalcharge.Text = searchResults.Rows[0]["total_charge"].ToString();
                    lblchannelid.Text = searchResults.Rows[0]["channel_id"].ToString();
                }
                else
                {
                    lblpatientname.Text = "";
                    lblpatientage.Text = "";
                    lblgender.Text = "";
                    lblroomnumber.Text = "";
                    lbldoctorname.Text = "";
                    lbldoctorspecializatIon.Text = "";
                    lbldate.Text = "";
                    lbltime.Text = "";
                    lbldoctorchrger.Text = "";
                    lblhospitalcharge.Text = "";
                    lbltotalcharge.Text = "";
                    lblchannelid.Text = "";

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
