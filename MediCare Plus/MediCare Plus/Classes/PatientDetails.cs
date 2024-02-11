using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCare_Plus.Classes
{
    internal class PatientDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string AllergyStatus { get; set; }

        //insert method to insert patient data
        public static bool Insert(PatientDetails patient)
        {
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();
                string query = "INSERT INTO patients (patient_firstname, patient_lastname, patient_mobileno, patient_email, patient_age, patient_gender, patient_allergy) VALUES (@FirstName, @LastName, @MobileNumber, @Email, @Age, @Gender, @AllergyStatus)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@FirstName", patient.FirstName);
                cmd.Parameters.AddWithValue("@LastName", patient.LastName);
                cmd.Parameters.AddWithValue("@MobileNumber", patient.MobileNumber);
                cmd.Parameters.AddWithValue("@Email", patient.Email);
                cmd.Parameters.AddWithValue("@Age", patient.Age);
                cmd.Parameters.AddWithValue("@Gender", patient.Gender);
                cmd.Parameters.AddWithValue("@AllergyStatus", patient.AllergyStatus);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        //Update method
        public static bool Update(PatientDetails patient)
        {
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();
                string query = "UPDATE patients SET patient_firstname = @FirstName, patient_lastname = @LastName, patient_mobileno = @MobileNumber, patient_email = @Email, patient_age = @Age, patient_gender = @Gender, patient_allergy = @AllergyStatus WHERE patient_email = @Email";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@FirstName", patient.FirstName);
                cmd.Parameters.AddWithValue("@LastName", patient.LastName);
                cmd.Parameters.AddWithValue("@MobileNumber", patient.MobileNumber);
                cmd.Parameters.AddWithValue("@Email", patient.Email);
                cmd.Parameters.AddWithValue("@Age", patient.Age);
                cmd.Parameters.AddWithValue("@Gender", patient.Gender);
                cmd.Parameters.AddWithValue("@AllergyStatus", patient.AllergyStatus);

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
                string query = "DELETE FROM patients WHERE patient_email = @Email";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Email", patientemail);

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
                string query = "SELECT * FROM patients WHERE patient_firstname LIKE @Keyword OR patient_email LIKE @Keyword OR patient_lastname LIKE @Keyword";
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
                string query = "SELECT * FROM patients"; // Retrieve all data from the table
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }
    }
}
