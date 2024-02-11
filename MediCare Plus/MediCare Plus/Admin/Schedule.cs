using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediCare_Plus.Admin
{
    public partial class Schedule : UserControl
    {
        int month;
        int year;
        //static variable for pass date month and year from this page to another page
        public static int smonth;
        public static int syear;
        public Schedule()
        {
            InitializeComponent();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblmonthname.Text = monthname + " " + year;

            smonth = month;
            syear = year;

            DateTime startofmonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayofweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d")) + 1;
            //int weekofweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("w"));

            for (int i = 1; i < dayofweek; i++)
            {
                AdminScheduleController adminblank = new AdminScheduleController();
                dayflopannel.Controls.Add(adminblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserDateControllerAdmin ucdays = new UserDateControllerAdmin();
                ucdays.days(i);
                dayflopannel.Controls.Add(ucdays);
            }
        }

        private void btnnextmonth_Click(object sender, EventArgs e)
        {
            //clear container
            dayflopannel.Controls.Clear();

            //increment month
            month++;
            DateTime startofmonth = new DateTime(year, month, 1);

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblmonthname.Text = monthname + " " + year;

            smonth = month;
            syear = year;

            int days = DateTime.DaysInMonth(year, month);

            int dayofweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d")) + 1;
            //int weekofweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("w"));

            for (int i = 1; i < dayofweek; i++)
            {
                AdminScheduleController adminblank = new AdminScheduleController();
                dayflopannel.Controls.Add(adminblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserDateControllerAdmin ucdays = new UserDateControllerAdmin();
                ucdays.days(i);
                dayflopannel.Controls.Add(ucdays);
            }
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            //clear container
            dayflopannel.Controls.Clear();

            //decrement month
            month--;
            DateTime startofmonth = new DateTime(year, month, 1);

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblmonthname.Text = monthname + " " + year;

            smonth = month;
            syear = year;

            int days = DateTime.DaysInMonth(year, month);

            int dayofweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d")) + 1;
            //int weekofweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("w"));

            for (int i = 1; i < dayofweek; i++)
            {
                AdminScheduleController adminblank = new AdminScheduleController();
                dayflopannel.Controls.Add(adminblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserDateControllerAdmin ucdays = new UserDateControllerAdmin();
                ucdays.days(i);
                dayflopannel.Controls.Add(ucdays);
            }
        }
    }
}
