using iTextSharp.text;
using iTextSharp.text.pdf;
using MediCare_Plus.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediCare_Plus.Staff.Receptionist
{
    public partial class Payments : UserControl
    {
        public Payments()
        {
            InitializeComponent();
        }

        //search button code for search patient details to calcutate theIr payments
        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string service_type = cmbservicetype.Text;
                string searchkeyword = txtsearchpayment.Text;

                //claculate charges that patient who channel a doctor
                if (service_type == "Channeling")
                {
                    DataTable searchResults = ChannelDetails.Search(searchkeyword);

                    if (searchResults.Rows.Count > 0)
                    {
                        txtpatientname.Text = searchResults.Rows[0]["patient_name"].ToString();
                        txtdoctorname.Text = searchResults.Rows[0]["doctor_name"].ToString();
                        txtdoctorcharge.Text = searchResults.Rows[0]["doctor_charge"].ToString();
                        txthospitalcharge.Text = searchResults.Rows[0]["hospital_charge"].ToString();
                        dtpdate.Text = searchResults.Rows[0]["chanel_date"].ToString();

                        //small calculation for channeling charge calculation
                        int othercharge = 0;
                        txtothercharges.Text = othercharge.ToString();

                        lblpaymentid.Text = PaymentDetails.createId(); //generate an id
                        txttotalcharge.Text = searchResults.Rows[0]["total_charge"].ToString();
                    }
                    else
                    {
                        txtpatientname.Clear();
                        txtdoctorname.Clear();
                        txtdoctorcharge.Clear();
                        txthospitalcharge.Clear();
                        txtothercharges.Clear();
                        lblpaymentid.Text = "";
                        txttotalcharge.Clear();

                        MessageBox.Show("No matching records found.");
                    }
                }
                //claculate charges that patient who admItted to the hospital
                else if (service_type == "Admission") 
                {
                    DataTable searchResults = HospitalAdmission.SearchDischarged(searchkeyword);

                    if (searchResults.Rows.Count > 0)
                    {
                        txtpatientname.Text = searchResults.Rows[0]["patient_name"].ToString();
                        txtdoctorname.Text = searchResults.Rows[0]["doctor_name"].ToString();
                        txthospitalcharge.Text = searchResults.Rows[0]["room_charge_perday"].ToString();
                        dtpdate.Text = searchResults.Rows[0]["admited_date"].ToString();

                        //small calculation for channeling charge calculation
                        int othercharge = 0;

                        txtdoctorcharge.Text = othercharge.ToString();
                        txtothercharges.Text = othercharge.ToString();
                        txttotalcharge.Text = searchResults.Rows[0]["room_charge_perday"].ToString();
                        lblpaymentid.Text = PaymentDetails.createId(); //generate an id
                    }
                    else
                    {
                        txtpatientname.Clear();
                        txtdoctorname.Clear();
                        txtdoctorcharge.Clear();
                        txthospitalcharge.Clear();
                        txtothercharges.Clear();
                        lblpaymentid.Text = "";
                        txttotalcharge.Clear();

                        MessageBox.Show("No matching records found.");
                    }
                }
                //claculate charges that patient who come to collect reports from hospital
                else if (service_type == "Reports")
                {
                    DataTable searchResults = OtherMedIcalService.Search(searchkeyword);

                    if (searchResults.Rows.Count > 0)
                    {
                        txtpatientname.Text = searchResults.Rows[0]["patient_name"].ToString();
                        txtdoctorname.Text = "None";
                        dtpdate.Text = searchResults.Rows[0]["service_date"].ToString();
                        string servicecategory = searchResults.Rows[0]["service_type"].ToString();

                        //small calculation for channeling charge calculation
                        int othercharge = 0;
                        double serviceCharge = 0;

                        switch (servicecategory)
                        {
                            case "Blood":
                                serviceCharge = 1000.00;
                                break;
                            case "Urine":
                                serviceCharge = 1200.00;
                                break;
                            case "CT":
                                serviceCharge = 10000.00;
                                break;
                            case "MRI":
                                serviceCharge = 7500.00;
                                break;
                            case "x - Ray":
                                serviceCharge = 3000.00;
                                break;
                            case "Ultra Sound":
                                serviceCharge = 4000.00;
                                break;
                            case "ECG":
                                serviceCharge = 750.00;
                                break;
                        }

                        txthospitalcharge.Text = othercharge.ToString();
                        txtdoctorcharge.Text = othercharge.ToString();
                        txtothercharges.Text = serviceCharge.ToString();
                        txttotalcharge.Text = serviceCharge.ToString();
                        lblpaymentid.Text = PaymentDetails.createId(); //generate an id
                    }
                    else
                    {
                        txtpatientname.Clear();
                        txtdoctorname.Clear();
                        txtdoctorcharge.Clear();
                        txthospitalcharge.Clear();
                        txtothercharges.Clear();
                        lblpaymentid.Text = "";
                        txttotalcharge.Clear();

                        MessageBox.Show("No matching records found.");
                    }
                }
                else if(service_type == "" || searchkeyword == "") 
                {
                    MessageBox.Show("Select service type and search keyword first..!");
                }
                else
                {
                    MessageBox.Show("Failed to retrieve data.");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("There is a problem with your database." + sqlEx.Message);
            }
            catch (FormatException formatEx)
            {
                MessageBox.Show("Format of inserted data is not matching properly. " + formatEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured. Please try again." + ex.Message);
            }
        }
        //insert payment data to the database
        private void btnmakepayment_Click(object sender, EventArgs e)
        {
            try
            {
                PaymentDetails newPayement = new PaymentDetails
                {
                    PatientName = txtpatientname.Text,
                    DoctorName = txtdoctorname.Text,
                    PaymentDate = dtpdate.Value,
                    DoctorCharge = double.Parse(txtdoctorcharge.Text),
                    HospitalCharge = double.Parse(txthospitalcharge.Text),
                    Othercharges = double.Parse(txtothercharges.Text),
                    TotalCharge = double.Parse(txttotalcharge.Text),
                    ServiceType = cmbservicetype.Text,
                    Pay_ID = lblpaymentid.Text
                };

                bool success = PaymentDetails.Insert(newPayement);
                if (success)
                {
                    //clear text fields after successful Insertion
                    MessageBox.Show("Payment inserted successfuly..!");

                    dgvpaymentdetails.DataSource = null;
                    //display all Inserted data through the datagridview
                    DataTable allData = PaymentDetails.GetAllData();
                    dgvpaymentdetails.DataSource = allData;
                }
                else
                {
                    MessageBox.Show("Payment not inserted properly, Try again..!");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("There is a problem with your database." + sqlEx.Message);
            }
            catch (FormatException formatEx)
            {
                MessageBox.Show("Format of inserted data is not matching properly. " + formatEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured. Please try again." + ex.Message);
            }
        }

        //print data through datagridview
        private void btnprintbill_Click(object sender, EventArgs e)
        {
            iTextSharp.text.Document doc = new iTextSharp.text.Document();

            try
            {
                // Prompt the user to select a location to save the PDF
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveDialog.Title = "Save PDF File";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveDialog.FileName;

                    // Create a FileStream to write the PDF
                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        PdfWriter writer = PdfWriter.GetInstance(doc, fs);

                        // Open the document for writing
                        doc.Open();

                        // Set the title for the PDF
                        doc.AddTitle("MediCare Plus Hospital");

                        // Add a table to the document
                        PdfPTable table = new PdfPTable(dgvpaymentdetails.ColumnCount);

                        // Add column headers to the table
                        for (int i = 0; i < dgvpaymentdetails.ColumnCount; i++)
                        {
                            table.AddCell(new Phrase(dgvpaymentdetails.Columns[i].HeaderText));
                        }

                        // Add data rows to the table
                        for (int i = 0; i < dgvpaymentdetails.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvpaymentdetails.ColumnCount; j++)
                            {
                                if (dgvpaymentdetails.Rows[i].Cells[j].Value != null)
                                {
                                    table.AddCell(new Phrase(dgvpaymentdetails.Rows[i].Cells[j].Value.ToString()));
                                }
                            }
                        }

                        // Add the table to the document
                        doc.Add(table);

                        // Close the document and flush the writer
                        doc.Close();
                        writer.Close();

                        MessageBox.Show("PDF created successfully!");
                        txtpatientname.Clear();
                        txtdoctorname.Clear();
                        txtdoctorcharge.Clear();
                        txthospitalcharge.Clear();
                        txtothercharges.Clear();
                        txttotalcharge.Clear();
                        cmbservicetype.Text = "";
                        lblpaymentid.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                doc.Close();
            }
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            //dgvpaymentdetails.Visible = false;
        }
    }
}
