using System.Runtime.InteropServices;

namespace MediCare_Plus
{
    public partial class Welcome : Form
    {
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn
        //    (
        //        int nLeft, 
        //        int nTop,
        //        int nRight,
        //        int nBottom,
        //        int nWidthEllipse,
        //        int nHeightEllipse
        //    );
        public Welcome()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Access obj = new Access();
            //this.Hide();
            //obj.Show();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            //button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 45, 45));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Access obj = new Access();
            this.Hide();
            obj.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Format of entered data is not valid..,!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            //MessageBox.Show("Patient registration successfully..,!.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            MessageBox.Show("You are going to get admissions with undefined values..!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}