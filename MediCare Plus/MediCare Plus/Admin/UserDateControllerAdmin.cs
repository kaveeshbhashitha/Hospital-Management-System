using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediCare_Plus.Admin
{
    public partial class UserDateControllerAdmin : UserControl
    {
        public static string static_day;
        public UserDateControllerAdmin()
        {
            InitializeComponent();
        }

        private void UserDateControllerAdmin_Load(object sender, EventArgs e)
        {

        }
        public void days(int numdays)
        {
            lbldayno.Text = numdays + "";
            //lblreservations.Text = ScheduleForm.d_name;
        }
    }
}
