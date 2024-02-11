using MediCare_Plus.Patient;
using MediCare_Plus.Staff.Receptionist;
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

namespace MediCare_Plus.Common
{
    public partial class Calendar : Form
    {
        int month;
        int year;
        //static variable for pass date month and year from this page to another page
        public static int smonth;
        public static int syear;
        public Calendar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientProfile patientprofile = new PatientProfile();
            this.Hide();
            patientprofile.Show();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbldate.Text = monthname + " " + year;

            smonth = month;
            syear = year;

            DateTime startofmonth = new DateTime(year, month, 1);
            
            int days = DateTime.DaysInMonth(year, month);

            int dayofweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d")) +1;
            //int weekofweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("w"));

            for(int i = 1; i < dayofweek; i++)
            {
                CalendarController ccblank = new CalendarController();
                daycontainer.Controls.Add(ccblank);
            }
            for(int i = 1; i <= days; i++)
            {
                UserControlarDays ucdays = new UserControlarDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnnextmonth_Click(object sender, EventArgs e)
        {
            //clear container
            daycontainer.Controls.Clear();

            //increment month
            month++;
            DateTime startofmonth = new DateTime(year, month, 1);

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbldate.Text = monthname + " " + year;

            smonth = month;
            syear = year;

            int days = DateTime.DaysInMonth(year, month);

            int dayofweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d")) + 1;
            //int weekofweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("w"));

            for (int i = 1; i < dayofweek; i++)
            {
                CalendarController ccblank = new CalendarController();
                daycontainer.Controls.Add(ccblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlarDays ucdays = new UserControlarDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnpriviousmonth_Click(object sender, EventArgs e)
        {
            //clear container
            daycontainer.Controls.Clear();

            //decrement month
            month--;
            DateTime startofmonth = new DateTime(year, month, 1);

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbldate.Text = monthname + " " + year;

            smonth = month;
            syear = year;

            int days = DateTime.DaysInMonth(year, month);

            int dayofweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d")) + 1;
            //int weekofweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("w"));

            for (int i = 1; i < dayofweek; i++)
            {
                CalendarController ccblank = new CalendarController();
                daycontainer.Controls.Add(ccblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlarDays ucdays = new UserControlarDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
