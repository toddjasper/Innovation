using System;
using System.Configuration;
using System.Windows.Forms;
using Innovation.Voice.Win.UI.Query.SpeechQueries;

namespace Innovation.Voice.Win.UI
{
    public partial class MainForm : Form
    {
        public static string _enrollmentPath = @"C:\temp\Audio\Enrollment\";
        public static string _identificationPath = @"C:\temp\Audio\Identification\";

        public MainForm()
        {
            InitializeComponent();
            cboUsername.SelectedIndex = 0;
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Per the speech identification spec we need 3 profile enrollments per user.
            for (var i = 1; i <= 3; i++)
            {
                var enrollQuery = new WebSpeechEnrollmentQuery
                {
                    ProfileId = ConfigurationManager.AppSettings["VerificationProfileId_" + cboUsername.Text + i],
                    ShortAudio = true
                };

                var fileHelper = new FileHelper();
                var wavBytes = fileHelper.FileToBytes(_enrollmentPath + cboUsername.Text + i + ".wav");

                var enrollUri = new Uri(enrollQuery.ToString());
                var downloader = new HttpDownloader();

                var response = downloader.GetRegistrationResponse(enrollUri, wavBytes);

                MessageBox.Show(response + " for " + cboUsername.Text + " " + i, "Registration Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAuthenticate_Click(object sender, EventArgs e)
        {
            //var accessGrantedForm = new AccessGrantedForm();
            //accessGrantedForm.Show();

            var identifyQuery = new WebSpeechIdentificationQuery()
            {
                IdentificationProfileIds = string.Format("{0},{1},{2}", 
                    ConfigurationManager.AppSettings["VerificationProfileId_" + cboUsername.Text + 1], 
                    ConfigurationManager.AppSettings["VerificationProfileId_" + cboUsername.Text + 2], 
                    ConfigurationManager.AppSettings["VerificationProfileId_" + cboUsername.Text + 3]),
                ShortAudio = true
            };

            var fileHelper = new FileHelper();
            var wavBytes = fileHelper.FileToBytes(_identificationPath + cboUsername.Text + ".identify.wav");

            var identifyUri = new Uri(identifyQuery.ToString());
            var downloader = new HttpDownloader();
            var response = downloader.GetIdentificationResponse(identifyUri, wavBytes);

            MessageBox.Show(response);
        }
    }
}
