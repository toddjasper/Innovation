using System;
using System.Windows.Forms;

namespace Innovation.Voice.Win.UI
{
    public partial class MainForm : Form
    {
        public static string _enrollmentPath = @"C:\temp\Audio\Enrollment\";
        public static string _identificationPath = @"C:\temp\Audio\Identification\";

        public MainForm()
        {
            InitializeComponent();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miEnroll_Click(object sender, EventArgs e)
        {
            ShowEnrollmentForm();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ShowEnrollmentForm();
        }

        private void ShowEnrollmentForm()
        {
            var form = new EnrollmentForm();
            form.Show();
        }
    }
}
