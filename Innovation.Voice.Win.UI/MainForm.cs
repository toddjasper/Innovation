using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Innovation.Voice.Win.UI.DataAccess;
using Innovation.Voice.Win.UI.Helpers;
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
            BindUsernames();
            cboUsername.SelectedIndex = 0;
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var profileIds = GetProfileIds();  

            // Per the speech identification spec we need 3 profile enrollments per user.
            var index = 1;
            foreach (var profileId in profileIds)
            {
                var enrollQuery = new WebSpeechEnrollmentQuery
                {
                    ProfileId = profileId,
                    ShortAudio = true
                };

                var fileHelper = new FileHelper();
                var wavBytes = fileHelper.FileToBytes(_enrollmentPath + cboUsername.Text + index + ".wav");

                var enrollUri = new Uri(enrollQuery.ToString());
                var downloader = new HttpDownloader();

                var response = downloader.GetRegistrationResponse(enrollUri, wavBytes);

                MessageBox.Show(response + " for " + cboUsername.Text + " " + index, "Registration Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                index++;
            }
        }

        private void btnAuthenticate_Click(object sender, EventArgs e)
        {
            if (!File.Exists(_identificationPath + "attempt.wav"))
            {
                ShowAccessDenied();
                return;
            }

            var profileIds = GetProfileIds();
            WebSpeechIdentificationQuery identifyQuery;
            if (profileIds != null && profileIds.Any())
            {
                identifyQuery = new WebSpeechIdentificationQuery { ShortAudio = true };
                foreach (var id in profileIds)
                    identifyQuery.IdentificationProfileIds += id + ",";

                identifyQuery.IdentificationProfileIds = identifyQuery.IdentificationProfileIds.Substring(0, identifyQuery.IdentificationProfileIds.Length - 1);
            }
            else
            {
                identifyQuery = new WebSpeechIdentificationQuery
                {
                    IdentificationProfileIds = Guid.Empty.ToString(),
                    ShortAudio = true
                };
            }

            var fileHelper = new FileHelper();
            var wavBytes = fileHelper.FileToBytes(_identificationPath + "attempt.wav");
            var identifyUri = new Uri(identifyQuery.ToString());
            var downloader = new HttpDownloader();
            var operationLocation = downloader.GetIdentificationResponse(identifyUri, wavBytes);
            var operationResponseModel = downloader.GetOperationResponse(new Uri(operationLocation));
            Authenticate(operationResponseModel);
        }

        private void btnAuthenticationFailTest_Click(object sender, EventArgs e)
        {
            var profileIds = GetProfileIds();
            var identifyQuery = new WebSpeechIdentificationQuery { ShortAudio = true };
            foreach (var id in profileIds)
                identifyQuery.IdentificationProfileIds += id;

            var fileHelper = new FileHelper();
            var wavBytes = fileHelper.FileToBytes(_identificationPath + "kait.stecher.identify.wav");
            var identifyUri = new Uri(identifyQuery.ToString());
            var downloader = new HttpDownloader();
            var operationLocation = downloader.GetIdentificationResponse(identifyUri, wavBytes);

            var operationResponseModel = downloader.GetOperationResponse(new Uri(operationLocation));
            Authenticate(operationResponseModel);
        }

        private void btnCreateProfiles_Click(object sender, EventArgs e)
        {
            for (var i = 1; i <= 3; i++)
            {
                var profileQuery = new WebSpeechProfileQuery();
                var profileUri = new Uri(profileQuery.ToString());
                var downloader = new HttpDownloader();
                var response = downloader.CreateProfile(profileUri);
                var profileId = JsonConvert.DeserializeObject<ProfileModel>(response).ProfileId;

                var speechDataAccess = new SpeechDataAccess();
                speechDataAccess.InsertProfileId(txtUsername.Text, profileId);
            }

            MessageBox.Show("Profiles created successfully", "Profile Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Authenticate(IdentificationModel model)
        {
            if (model.Status.ToLower() == "succeeded")
            {
                switch (model.ProcessingResult.Confidence.ToLower())
                {
                    case "high":

                        if (model.ProcessingResult.IdentifiedProfileId.ToGuid() == Guid.Empty)
                            ShowAccessDenied();
                        else
                            ShowAccessGranted();

                        return;

                    case "normal":

                        ShowAccessDenied();
                        return;

                    case "now":

                        ShowAccessDenied();
                        return;
                }
            }
            else
            {
                ShowAccessDenied();
            }
        }

        private IEnumerable<string> GetProfileIds()
        {
            var speechDataAccess = new SpeechDataAccess();
            return speechDataAccess.GetProfileIds(cboUsername.Text).Ids;
        }

        private IEnumerable<string> GetAllProfileIds()
        {
            var speechDataAccess = new SpeechDataAccess();
            return speechDataAccess.GetAllProfileIds().Ids;
        }

        private void ShowAccessGranted()
        {
            var accessGrantedForm = new AccessGrantedForm();
            accessGrantedForm.Show();
        }

        private void ShowAccessDenied()
        {
            var accessDeniedForm = new AccessDeniedForm();
            accessDeniedForm.Show();
        }

        private void BindUsernames()
        {
            cboUsername.Items.Add("dc.fisher");
            cboUsername.Items.Add("frank.venezia");
            cboUsername.Items.Add("kait.stecher");
            cboUsername.Items.Add("dave.delphia");
            cboUsername.Items.Add("todd.jasper");
        }
    }
}
