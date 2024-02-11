using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCare_Plus.Classes
{
    internal class HospitalAdmission
    {
        public int PatientAge { get; set; }
        public string PatientName { get; set; }
        public string PatientMobile { get; set; }
        public string PatientNic { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string DoctorName { get; set; }
        public string DoctorSpecialization { get; set; }
        public int RoomNumber { get; set; }
        public string Status { get; set; }
        public double Charge { get; set; }
        public string GuardName { get; set; }
        public string GuardNic { get; set; }
        public string GuardMobileNo { get; set; }
        public string AdmissionID { get; set; }

        //method to insert admission data
        public static bool Insert(HospitalAdmission admission)
        {
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();
                string query = "INSERT INTO admission (patient_age, patient_name, patient_mobileno, patient_nic, admited_date, doctor_name, doctor_specialization, room_number, room_status, room_charge_perday, guardian_name, guardian_nic, guardian_mobileno, admitting_ID) VALUES (@PatientAge, @PatientName, @PatientMobile, @PatientNic, @AdmissionDate, @DoctorName, @DoctorSpecialization, @RoomNumber, @Status, @Charge, @GuardName, @GuardNic, @GuardMobileNo, @AdmissionID)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@PatientAge", admission.PatientAge);
                cmd.Parameters.AddWithValue("@PatientName", admission.PatientName);
                cmd.Parameters.AddWithValue("@PatientMobile", admission.PatientMobile);
                cmd.Parameters.AddWithValue("@PatientNic", admission.PatientNic);
                cmd.Parameters.AddWithValue("@AdmissionDate", admission.AdmissionDate);
                cmd.Parameters.AddWithValue("@DoctorName", admission.DoctorName);
                cmd.Parameters.AddWithValue("@DoctorSpecialization", admission.DoctorSpecialization);
                cmd.Parameters.AddWithValue("@RoomNumber", admission.RoomNumber);
                cmd.Parameters.AddWithValue("@Status", admission.Status);
                cmd.Parameters.AddWithValue("@Charge", admission.Charge);
                cmd.Parameters.AddWithValue("@GuardName", admission.GuardName);
                cmd.Parameters.AddWithValue("@GuardNic", admission.GuardNic);
                cmd.Parameters.AddWithValue("@GuardMobileNo", admission.GuardMobileNo);
                cmd.Parameters.AddWithValue("@AdmissionID", admission.AdmissionID);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        //method to update admission data
        public static bool Update(HospitalAdmission admission)
        {
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();
                string query = "UPDATE admission SET room_status = 'Discharged', room_charge_perday = DATEDIFF(day, admited_date, GETDATE()) * room_charge_perday WHERE admitting_ID = @AdmissionID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@AdmissionID", admission.AdmissionID);
                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if any rows were affected (updated)
                return rowsAffected > 0;
            }
        }

        //method to delete admission data
        public static bool Delete(string admissionid)
        {
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();
                string query = "DELETE FROM admission WHERE admitting_ID = @AdmissionID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@AdmissionID", admissionid);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        //method to search admission data
        public static DataTable Search(string keyword)
        {
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();
                string query = "SELECT * FROM admission WHERE patient_name LIKE @Keyword OR patient_nic LIKE @Keyword OR admitting_ID LIKE @Keyword";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }
        //method to search discharged patIents data
        public static DataTable SearchDischarged(string keyword)
        {
            SqlConfiguration sqlconfig = new SqlConfiguration();
            string config = sqlconfig.SqlConnectionAccess();

            using (SqlConnection connection = new SqlConnection(config))
            {
                connection.Open();
                string query = "SELECT * FROM admission WHERE patient_name LIKE @Keyword OR patient_nic LIKE @Keyword OR admitting_ID LIKE @Keyword AND room_status = 'Discharged'";
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

                string query = "SELECT MAX(admission_id) FROM admission";
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
            string generatedId = "AD00" + oldid;
            return generatedId;
        }
    }
}
