using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCare_Plus.Classes
{
    internal class PaymentDetails
    {
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public DateTime PaymentDate { get; set; }
        public double DoctorCharge { get; set; }
        public double HospitalCharge { get; set; }
        public double Othercharges { get; set; }
        public double TotalCharge { get; set; }
        public string ServiceType { get; set; }
        public string Pay_ID { get; set; }

        //insert method to insert channeling data
        public static bool Insert(PaymentDetails payments)
        {
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();
                string query = "INSERT INTO payments (patient_name, doctor_name, pay_date, doctor_charge, hospital_charge, other_charges, total_charge, service_type, pay_ID) VALUES (@PatientName, @DoctorName, @PaymentDate, @DoctorCharge, @HospitalCharge, @Othercharges, @TotalCharge, @ServiceType, @Pay_ID)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@PatientName", payments.PatientName);
                cmd.Parameters.AddWithValue("@DoctorName", payments.DoctorName);
                cmd.Parameters.AddWithValue("@PaymentDate", payments.PaymentDate);
                cmd.Parameters.AddWithValue("@DoctorCharge", payments.DoctorCharge);
                cmd.Parameters.AddWithValue("@HospitalCharge", payments.HospitalCharge);
                cmd.Parameters.AddWithValue("@Othercharges", payments.Othercharges);
                cmd.Parameters.AddWithValue("@TotalCharge", payments.TotalCharge);
                cmd.Parameters.AddWithValue("@ServiceType", payments.ServiceType);
                cmd.Parameters.AddWithValue("@Pay_ID", payments.Pay_ID);

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
                string query = "DELETE FROM payments WHERE pay_ID = @Pay_ID";
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
                string query = "SELECT * FROM payments WHERE pay_ID = @Pay_ID";
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
                string query = "SELECT * FROM payments"; // Retrieve all data from the table
                SqlCommand cmd = new SqlCommand(query, connection);

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

                string query = "SELECT MAX(payment_id) FROM payments";
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
            string generatedId = "PY00" + oldid;
            return generatedId;
        }
    }
}
