using MediCare_Plus.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediCare_Plus.Admin
{
    public partial class SystemUsers : UserControl
    {
        public SystemUsers()
        {
            InitializeComponent();
        }

        // Inseert system user records
        private void btnadduser_Click(object sender, EventArgs e)
        {
            SystemUser newUser = new SystemUser
            {
                EmployeeName = txtname.Text,
                UserID = txtuserid.Text,
                UserName = txtusername.Text,
                Password = txtpassword.Text,
                UserRole = txtuserrole.Text
            };

            try
            {
                bool success = SystemUser.Insert(newUser);
                if (success)
                {
                    MessageBox.Show("User inserted successfuly..!");
                    txtname.Clear();
                    txtuserid.Clear();
                    txtusername.Clear();
                    txtpassword.Clear();
                    txtuserrole.Clear();
                }
                else
                {
                    MessageBox.Show("User not inserted properly, Try again..!");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("There is a problem with your database." + sqlEx.Message);
            }
            catch (FormatException formatEx)
            {
                MessageBox.Show(",Format of inserted data is not matching properly. " + formatEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured. Please try again." + ex.Message);
            }
        }

        // Update user details
        private void btnupdateuser_Click(object sender, EventArgs e)
        {
            try
            {
                SystemUser updatedUser = new SystemUser
                {
                    EmployeeName = txtname.Text,
                    UserID = txtuserid.Text,
                    UserName = txtusername.Text,
                    Password = txtpassword.Text,
                    UserRole = txtuserrole.Text
                };

                bool success = SystemUser.Update(updatedUser);
                if (success)
                {
                    MessageBox.Show("User updated successfully.");
                    txtname.Clear();
                    txtuserid.Clear();
                    txtusername.Clear();
                    txtpassword.Clear();
                    txtuserrole.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to update user.");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("There is a problem with your database." + sqlEx.Message);
            }
            catch (FormatException formatEx)
            {
                MessageBox.Show(",Format of inserted data is not matching properly. " + formatEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured. Please try again." + ex.Message);
            }
        }

        // Delete user details
        private void btnremoveuser_Click(object sender, EventArgs e)
        {
            string userIDToDelete = txtsearch.Text;

            try
            {
                bool success = SystemUser.Delete(userIDToDelete);
                if (success)
                {
                    MessageBox.Show("User deleted successfully.");
                    txtsearch.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to delete user.");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("There is a problem with your database." + sqlEx.Message);
            }
            catch (FormatException formatEx)
            {
                MessageBox.Show(",Format of inserted data is not matching properly. " + formatEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured. Please try again." + ex.Message);
            }
        }

        // Search user data
        private void txtsearchuser_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtsearch.Text;

            try
            {
                DataTable searchResults = SystemUser.Search(searchKeyword);

                if (searchResults.Rows.Count > 0)
                {
                    txtname.Text = searchResults.Rows[0]["employee_name"].ToString();
                    txtuserid.Text = searchResults.Rows[0]["empID"].ToString();
                    txtusername.Text = searchResults.Rows[0]["employee_username"].ToString();
                    txtpassword.Text = searchResults.Rows[0]["employee_password"].ToString();
                    txtuserrole.Text = searchResults.Rows[0]["employee_position"].ToString();
                }
                else
                {
                    txtname.Clear();
                    txtuserid.Clear();
                    txtusername.Clear();
                    txtpassword.Clear();
                    txtuserrole.Clear();

                    MessageBox.Show("No matching records found.");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("There is a problem with your database." + sqlEx.Message);
            }
            catch (FormatException formatEx)
            {
                MessageBox.Show(",Format of inserted data is not matching properly. " + formatEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured. Please try again." + ex.Message);
            }
        }
    }
}
