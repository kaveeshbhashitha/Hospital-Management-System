using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCare_Plus.Classes
{
    internal class TreatmentDetails
    {
        public string PatientName { get; set; }
        public int PatientAge { get; set; }
        public string Gender { get; set; }
        public string AppointmentNumber { get; set; }
        public string Illness { get; set; }
        public string Notes { get; set; }
        public string Drug1 { get; set; }
        public string Drug2 { get; set; }
        public string Drug3 { get; set; }
        public string Drug4 { get; set; }
        public string Drug5 { get; set; }
        public string Drug6 { get; set; }
        public string Drug7 { get; set; }
        public string Drug8 { get; set; }

        //Insert method
        public static bool Insert(TreatmentDetails treatment)
        {
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();
                string query = "INSERT INTO diagnosis (treatment_Id, patient_age, patient_name, gender, illness, note, drug_1, drug_2, drug_3, drug_4, drug_5, drug_6, drug_7, drug_8) VALUES (@AppointmentNumber, @PatientAge, @PatientName, @Gender, @Illness, @Notes, @Drug1, @Drug2, @Drug3, @Drug4, @Drug5, @Drug6, @Drug7, @Drug8)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@AppointmentNumber", treatment.AppointmentNumber);
                cmd.Parameters.AddWithValue("@PatientName", treatment.PatientName);
                cmd.Parameters.AddWithValue("@PatientAge", treatment.PatientAge);
                cmd.Parameters.AddWithValue("@Gender", treatment.Gender);
                cmd.Parameters.AddWithValue("@Illness", treatment.Illness);
                cmd.Parameters.AddWithValue("@Notes", treatment.Notes);
                cmd.Parameters.AddWithValue("@Drug1", treatment.Drug1);
                cmd.Parameters.AddWithValue("@Drug2", treatment.Drug2);
                cmd.Parameters.AddWithValue("@Drug3", treatment.Drug3);
                cmd.Parameters.AddWithValue("@Drug4", treatment.Drug4);
                cmd.Parameters.AddWithValue("@Drug5", treatment.Drug5);
                cmd.Parameters.AddWithValue("@Drug6", treatment.Drug6);
                cmd.Parameters.AddWithValue("@Drug7", treatment.Drug7);
                cmd.Parameters.AddWithValue("@Drug8", treatment.Drug8);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        //Update method
        public static bool Update(TreatmentDetails treatment)
        {
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();
                string query = "UPDATE diagnosis SET treatment_Id = @AppointmentNumber, patient_age = @PatientAge, patient_name = @PatientName, gender = @Gender, illness = @Illness, note = @Notes, drug_1 = @Drug1, drug_2 = @Drug2, drug_3 = @Drug3, drug_4 = @Drug4, drug_5 = @Drug5, drug_6 = @Drug6, drug_7 = @Drug7, drug_8 = @Drug8 WHERE treatment_Id = @AppointmentNumber";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@AppointmentNumber", treatment.AppointmentNumber);
                cmd.Parameters.AddWithValue("@PatientName", treatment.PatientName);
                cmd.Parameters.AddWithValue("@PatientAge", treatment.PatientAge);
                cmd.Parameters.AddWithValue("@Gender", treatment.Gender);
                cmd.Parameters.AddWithValue("@Illness", treatment.Illness);
                cmd.Parameters.AddWithValue("@Notes", treatment.Notes);
                cmd.Parameters.AddWithValue("@Drug1", treatment.Drug1);
                cmd.Parameters.AddWithValue("@Drug2", treatment.Drug2);
                cmd.Parameters.AddWithValue("@Drug3", treatment.Drug3);
                cmd.Parameters.AddWithValue("@Drug4", treatment.Drug4);
                cmd.Parameters.AddWithValue("@Drug5", treatment.Drug5);
                cmd.Parameters.AddWithValue("@Drug6", treatment.Drug6);
                cmd.Parameters.AddWithValue("@Drug7", treatment.Drug7);
                cmd.Parameters.AddWithValue("@Drug8", treatment.Drug8);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        //Delete method
        public static bool Delete(string tratmentid)
        {
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();
                string query = "DELETE FROM diagnosis WHERE treatment_Id = @AppointmentNumber";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserID", tratmentid);

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
                string query = "SELECT * FROM diagnosis WHERE treatment_Id LIKE @Keyword OR patient_name LIKE @Keyword";
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
