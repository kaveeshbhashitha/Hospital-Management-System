using MediCare_Plus.Admin;
using MediCare_Plus.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCare_Plus.Classes
{
    internal class DoctorDetails
    {
        public string DoctorName { get; set; }
        public string DoctorSpecialization { get; set; }
        public string TreatmentArea { get; set; }
        public string Experience { get; set; }
        public string Email { get; set; }
        public double DoctorCharge { get; set; }
        public string Mobilenumber { get; set; }
        public DateTime AvailableDate { get; set; }
        public double AvailableTime { get; set; }
        public int RoomNumber { get; set; }

        public static bool Insert(DoctorDetails doctor)
        {
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();
                string query = "INSERT INTO doctor (doctor_name, doctor_specialization, treatment_area, doctor_experience, doctor_email, doctor_nic, doctor_mobile, available_time, available_date, room_number) VALUES (@DoctorName, @DoctorSpecialization, @TreatmentArea, @Experience, @Email, @DoctorCharge, @Mobilenumber, @AvailableTime, @AvailableDate, @RoomNumber)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@DoctorName", doctor.DoctorName);
                cmd.Parameters.AddWithValue("@DoctorSpecialization", doctor.DoctorSpecialization);
                cmd.Parameters.AddWithValue("@TreatmentArea", doctor.TreatmentArea);
                cmd.Parameters.AddWithValue("@Experience", doctor.Experience);
                cmd.Parameters.AddWithValue("@Email", doctor.Email);
                cmd.Parameters.AddWithValue("@DoctorCharge", doctor.DoctorCharge);
                cmd.Parameters.AddWithValue("@Mobilenumber", doctor.Mobilenumber);
                cmd.Parameters.AddWithValue("@AvailableTime", doctor.AvailableTime);
                cmd.Parameters.AddWithValue("@AvailableDate", doctor.AvailableDate);
                cmd.Parameters.AddWithValue("@RoomNumber", doctor.RoomNumber);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        //Update method
        public static bool Update(DoctorDetails doctor)
        {
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();
                string query = "UPDATE doctor SET doctor_name = @DoctorName, doctor_specialization = @DoctorSpecialization, treatment_area = @TreatmentArea, doctor_experience = @Experience, doctor_email = @Email, doctor_nic = @DoctorCharge, doctor_mobile = @Mobilenumber, available_date = @AvailableDate, available_time = @AvailableTime, room_number = @RoomNumber WHERE doctor_email = @Email";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@DoctorName", doctor.DoctorName);
                cmd.Parameters.AddWithValue("@DoctorSpecialization", doctor.DoctorSpecialization);
                cmd.Parameters.AddWithValue("@TreatmentArea", doctor.TreatmentArea);
                cmd.Parameters.AddWithValue("@Experience", doctor.Experience);
                cmd.Parameters.AddWithValue("@Email", doctor.Email);
                cmd.Parameters.AddWithValue("@DoctorCharge", doctor.DoctorCharge);
                cmd.Parameters.AddWithValue("@Mobilenumber", doctor.Mobilenumber);
                cmd.Parameters.AddWithValue("@AvailableDate", doctor.AvailableDate);
                cmd.Parameters.AddWithValue("@AvailableTime", doctor.AvailableTime);
                cmd.Parameters.AddWithValue("@RoomNumber", doctor.RoomNumber);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        //Delete method
        public static bool Delete(string doctoremail)
        {
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();
                string query = "DELETE FROM doctor WHERE doctor_email = @Email";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Email", doctoremail);

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
                string query = "SELECT * FROM doctor WHERE doctor_email LIKE @Keyword OR doctor_name LIKE @Keyword";
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
                string query = "SELECT * FROM doctor"; // Retrieve all data from the table
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }
    }
}

