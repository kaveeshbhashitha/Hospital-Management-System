using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCare_Plus.Classes
{
    internal class FacilityDetails
    {
        public int RoomNumber { get; set; }
        public string DoctorName { get; set; }
        public string DoctorSpecialization { get; set; }
        public DateTime AvailableDate { get; set; }
        public double AvailableTime { get; set; }
        public string Status { get; set; }
        public double RoomCharge { get; set; }
        public string RoomType { get; set; }

        public static bool Insert(FacilityDetails facility)
        {
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();
                string query = "INSERT INTO hospitalRoom (room_number, doctor_name, doctor_specialization, available_date, available_time, availability_status, room_charge, room_type) VALUES (@RoomNumber, @DoctorName, @DoctorSpecialization, @AvailableDate, @AvailableTime, @Status, @RoomCharge, @RoomType)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@RoomNumber", facility.RoomNumber);
                cmd.Parameters.AddWithValue("@DoctorName", facility.DoctorName);
                cmd.Parameters.AddWithValue("@DoctorSpecialization", facility.DoctorSpecialization);
                cmd.Parameters.AddWithValue("@AvailableDate", facility.AvailableDate);
                cmd.Parameters.AddWithValue("@AvailableTime", facility.AvailableTime);
                cmd.Parameters.AddWithValue("@Status", facility.Status);
                cmd.Parameters.AddWithValue("@RoomCharge", facility.RoomCharge);
                cmd.Parameters.AddWithValue("@RoomType", facility.RoomType);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public void SearchAndDisplayRecords(DateTime date,TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4, TextBox textBox5, TextBox textBox6, TextBox textBox7, TextBox textBox8)
        {
            DateTime today = date;

            try
            {
                SqlConfiguration sqlconfig = new SqlConfiguration();
                string config = sqlconfig.SqlConnectionAccess();

                using (SqlConnection connection = new SqlConnection(config))
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM hospitalRoom WHERE available_date >= @Today";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Today", today);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBox1.Text = reader["room_number"].ToString();
                                textBox2.Text = reader["doctor_name"].ToString();
                                textBox3.Text = reader["doctor_specialization"].ToString();
                                textBox4.Text = reader["available_date"].ToString();
                                textBox5.Text = reader["available_time"].ToString();
                                textBox6.Text = reader["availability_status"].ToString();
                                textBox7.Text = reader["room_charge"].ToString();
                                textBox8.Text = reader["room_type"].ToString();

                            }
                            else
                            {
                                MessageBox.Show("No available doctors found for today or later.");
                            }
                        }
                    }
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

            //to class this method
            //dateHandler.SearchAndDisplayRecords(textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8);
        }
        //search all facilIties method
        public static DataTable GetAllFacilityData()
        {
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();
                string query = "SELECT * FROM hospitalRoom"; // Retrieve all data from the table
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }
        //Search method
        public static DataTable facSearch(string keyword)
        {
            //get current date
            DateTime currentDate = DateTime.Today;
            //sql connection
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();
                string query = "SELECT * FROM hospitalRoom WHERE doctor_name LIKE @Keyword OR doctor_specialization LIKE @Keyword AND WHERE available_date >= @currentDate";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }
    }
}
