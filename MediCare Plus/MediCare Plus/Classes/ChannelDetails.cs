using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCare_Plus.Classes
{
    internal class ChannelDetails
    {
        public string PatientName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int RoomNumber { get; set; }
        public string DoctorName { get; set; }
        public string DoctorSpecialization { get; set; }
        public DateTime AvailableDate { get; set; }
        public double AvailableTime { get; set; }
        public double DoctorCharge { get; set; }
        public double HospitalCharge { get; set; }
        public double TotalCharge { get; set; }
        public string ChannelId { get; set; }

        //insert method to insert channeling data
        public static bool Insert(ChannelDetails channeling)
        {
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();
                string query = "INSERT INTO schedule (patient_name, patient_age, patient_gender, doctor_name, doctor_specialization, room_number, chanel_date, chanel_time, doctor_charge, hospital_charge, total_charge, channel_id) VALUES (@PatientName, @Age, @Gender, @DoctorName, @DoctorSpecialization, @RoomNumber, @AvailableDate, @AvailableTime, @DoctorCharge, @HospitalCharge, @TotalCharge, @ChannelId)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@PatientName", channeling.PatientName);
                cmd.Parameters.AddWithValue("@Age", channeling.Age);
                cmd.Parameters.AddWithValue("@Gender", channeling.Gender);
                cmd.Parameters.AddWithValue("@RoomNumber", channeling.RoomNumber);
                cmd.Parameters.AddWithValue("@DoctorName", channeling.DoctorName);
                cmd.Parameters.AddWithValue("@DoctorSpecialization", channeling.DoctorSpecialization);
                cmd.Parameters.AddWithValue("@AvailableDate", channeling.AvailableDate);
                cmd.Parameters.AddWithValue("@AvailableTime", channeling.AvailableTime);
                cmd.Parameters.AddWithValue("@DoctorCharge", channeling.DoctorCharge);
                cmd.Parameters.AddWithValue("@HospitalCharge", channeling.HospitalCharge);
                cmd.Parameters.AddWithValue("@TotalCharge", channeling.TotalCharge);
                cmd.Parameters.AddWithValue("@ChannelId", channeling.ChannelId);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        //Update method
        public static bool Update(ChannelDetails channeling)
        {
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();
                string query = "UPDATE schedule SET patient_name = @PatientName, patient_age = @Age, patient_gender = @Gender, doctor_name = @DoctorName, doctor_specialization = @DoctorSpecialization, room_number = @RoomNumber, chanel_date = @AvailableDate, chanel_time = @AvailableTime, doctor_charge = @DoctorCharge, hospital_charge = @HospitalCharge, total_charge = @TotalCharge, channel_id = @ChannelId WHERE channel_id = @ChannelId";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@PatientName", channeling.PatientName);
                cmd.Parameters.AddWithValue("@Age", channeling.Age);
                cmd.Parameters.AddWithValue("@Gender", channeling.Gender);
                cmd.Parameters.AddWithValue("@RoomNumber", channeling.RoomNumber);
                cmd.Parameters.AddWithValue("@DoctorName", channeling.DoctorName);
                cmd.Parameters.AddWithValue("@DoctorSpecialization", channeling.DoctorSpecialization);
                cmd.Parameters.AddWithValue("@AvailableDate", channeling.AvailableDate);
                cmd.Parameters.AddWithValue("@AvailableTime", channeling.AvailableTime);
                cmd.Parameters.AddWithValue("@DoctorCharge", channeling.DoctorCharge);
                cmd.Parameters.AddWithValue("@HospitalCharge", channeling.HospitalCharge);
                cmd.Parameters.AddWithValue("@TotalCharge", channeling.TotalCharge);
                cmd.Parameters.AddWithValue("@ChannelId", channeling.ChannelId);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        //Delete method
        public static bool Delete(string patientemail)
        {
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();
                string query = "DELETE FROM schedule WHERE channel_id = @ChannelId";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ChannelId", patientemail);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        //Search method
        public static DataTable Search(string keyword)
        {
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();
                string query = "SELECT * FROM schedule WHERE patient_name LIKE @Keyword OR channel_id LIKE @Keyword";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }

        //search all method
        public static DataTable GetAllData()
        {
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();
                string query = "SELECT * FROM schedule"; // Retrieve all data from the table
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }

        //method for search all respect to patIent name 
        public static DataTable GetDataForPatientName(string keyword)
        {
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();
                string query = "SELECT * FROM schedule WHERE patient_name LIKE @Keyword"; // Retrieve all data from the table
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }

        //get id and generate proper id
        public static int GetLastInsertedId()
        {
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            int lastInsertedId = -1;

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();

                string query = "SELECT MAX(patient_id) FROM patients";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        lastInsertedId = Convert.ToInt32(result);
                    }
                }
            }
            return lastInsertedId;
        }
        //generate user controle id
        public static string createId()
        {
            string oldid = GetLastInsertedId().ToString();
            string generatedId = "CH00" + oldid;
            return generatedId;
        }
    }
}
