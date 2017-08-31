using System;
using System.Configuration;
using System.Windows.Forms;
using Innovation.Voice.Win.UI.Models;
using Innovation.Voice.Win.UI.Query.SpeechQueries;
using Newtonsoft.Json;

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
            var identifyQuery = new WebSpeechIdentificationQuery
            {
                IdentificationProfileIds = string.Format("{0},{1},{2}",
                    ConfigurationManager.AppSettings["VerificationProfileId_todd.jasper1"],
                    ConfigurationManager.AppSettings["VerificationProfileId_frank.venezia1"],
                    ConfigurationManager.AppSettings["VerificationProfileId_kait.stecher1"]),
                ShortAudio = true
            };

            var fileHelper = new FileHelper();
            var wavBytes = fileHelper.FileToBytes(_identificationPath + cboUsername.Text + ".identify.wav");

            var identifyUri = new Uri(identifyQuery.ToString());
            var downloader = new HttpDownloader();
            var operationLocation = downloader.GetIdentificationResponse(identifyUri, wavBytes);

            var response = downloader.GetOperationResponse(new Uri(operationLocation));
            var responseModel = JsonConvert.DeserializeObject<IdentificationModel>(response);

            if (responseModel.Status.ToLower() == "success")
            {
                var accessGrantedForm = new AccessGrantedForm();
                accessGrantedForm.Show();
            }
            else
            {
                var accessDeniedForm = new AccessDeniedForm();
                accessDeniedForm.Show();
            }
        }
    }
}
