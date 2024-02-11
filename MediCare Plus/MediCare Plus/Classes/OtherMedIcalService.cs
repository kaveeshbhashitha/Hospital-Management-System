using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCare_Plus.Classes
{
    internal class OtherMedIcalService
    {
        public int PatientAge { get; set; }
        public string PatientName { get; set; }
        public int MobileNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int RoomNumber { get; set; }
        public string ServiceType { get; set; }
        public DateTime Date { get; set; }
        public double Time { get; set; }

        //Insert method
        public static bool Insert(OtherMedIcalService services)
        {
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();
                string query = "INSERT INTO services (patient_age, patient_name, patient_mobileno, patient_email, patient_address, room_no, service_type, service_date, service_time) VALUES (@PatientAge, @PatientName, @MobileNumber, @Email, @Address, @RoomNumber, @ServiceType, @Date, @Time)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@PatientAge", services.PatientAge);
                cmd.Parameters.AddWithValue("@PatientName", services.PatientName);
                cmd.Parameters.AddWithValue("@MobileNumber", services.MobileNumber);
                cmd.Parameters.AddWithValue("@Email", services.Email);
                cmd.Parameters.AddWithValue("@Address", services.Address);
                cmd.Parameters.AddWithValue("@RoomNumber", services.RoomNumber);
                cmd.Parameters.AddWithValue("@ServiceType", services.ServiceType);
                cmd.Parameters.AddWithValue("@Date", services.Date);
                cmd.Parameters.AddWithValue("@Time", services.Time);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        //Update method
        public static bool Update(OtherMedIcalService services)
        {
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();
                string query = "UPDATE services SET patient_age = @PatientAge, patient_name = @PatientName, patient_mobileno = @MobileNumber, patient_email = @Email, patient_address = @Address, room_no = @RoomNumber, service_type = @ServiceType, service_date = @Date, service_time = @Time  WHERE patient_email = @Email";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@PatientAge", services.PatientAge);
                cmd.Parameters.AddWithValue("@PatientName", services.PatientName);
                cmd.Parameters.AddWithValue("@MobileNumber", services.MobileNumber);
                cmd.Parameters.AddWithValue("@Email", services.Email);
                cmd.Parameters.AddWithValue("@Address", services.Address);
                cmd.Parameters.AddWithValue("@RoomNumber", services.RoomNumber);
                cmd.Parameters.AddWithValue("@ServiceType", services.ServiceType);
                cmd.Parameters.AddWithValue("@Date", services.Date);
                cmd.Parameters.AddWithValue("@Time", services.Time);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        //Delete method
        public static bool Delete(string pemail)
        {
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();
                string query = "DELETE FROM services WHERE patient_email = @Email";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Email", pemail);

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
                string query = "SELECT * FROM services WHERE patient_email LIKE @Keyword";
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
                string query = "SELECT * FROM services"; // Retrieve all data from the table
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }
    }
}
