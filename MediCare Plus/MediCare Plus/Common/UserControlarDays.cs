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

namespace MediCare_Plus.Common
{
    public partial class UserControlarDays : UserControl
    {
        public static string static_day;
        public UserControlarDays()
        {
            InitializeComponent();
        }

        private void UserControlarDays_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        public void days(int numdays)
        {
            lbldays.Text = numdays + "";
            lbleventr.Text = "";
            //lblreservations.Text = ScheduleForm.d_name;
        }

        private void UserControlarDays_Click(object sender, EventArgs e)
        {
            static_day = lbldays.Text;
            ScheduleForm eventform = new ScheduleForm();
            eventform.Show();
        }
        //method for display number of reservations
        public void displayEvent()
        {
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();
                string query = "SELECT patient_name FROM schedule WHERE chanel_date = @Keyword"; // Select the patient_name column
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Keyword", DateTime.Now);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lbleventr.Text = reader["patient_name"].ToString();
                    MessageBox.Show("hello");
                }
                reader.Dispose();
                cmd.Dispose();
                connection.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }
}
