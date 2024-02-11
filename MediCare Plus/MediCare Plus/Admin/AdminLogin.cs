using MediCare_Plus.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MediCare_Plus.Classes;

namespace MediCare_Plus
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Access access = new Access();
            this.Hide();
            access.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You cannot request access for portral right now. Try again later..!");
        }

        // Login method for admin login
        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboard admindashboard = new AdminDashboard();

            string enteredUsername = txtstaffusername.Text;
            string enteredPassword = txtstaffpassword.Text;

            try
            {
                bool loginSuccessful = SystemUser.Login(enteredUsername, enteredPassword);

                if (loginSuccessful)
                {
                    MessageBox.Show("Login successful..!");
                    this.Hide();
                    admindashboard.Show();
                }
                else
                {
                    MessageBox.Show("Login failed. Please check your username and password.");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Exception: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
    }
}
