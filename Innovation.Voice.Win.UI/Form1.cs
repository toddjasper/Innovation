using System;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Innovation.Voice.Win.UI.Query;
using Innovation.Voice.Win.UI.Query.SpeechQueries;

namespace Innovation.Voice.Win.UI
{
    public partial class VoiceForm : Form
    {
        public VoiceForm()
        {
            InitializeComponent();
        }

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        private void btnRecord_Click(object sender, EventArgs e)
        {
            //string command = "set recsound time format 16 bit";
            //command += " bitspersample 16K";
            //command += " channels mono";
            ////command += " samplespersec " + WaveSamplesPerSec;
            ////command += " bytespersec " + WaveBytesPerSec;
            ////command += " alignment " + WaveAlignment;

            //mciSendString("open new Type waveaudio Alias recsound", "", 0, 0);
            //mciSendString("record recsound", "", 0, 0);


            mciSendString("open new Type waveaudio Alias recsound", "", 0, 0);
            mciSendString("set recsound time format ms bitspersample 16 samplespersec 16000 channels mono", "", 0, 0);
            mciSendString("record recsound", "", 0, 0);


        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            mciSendString(@"save recsound " + txtOutputDirectory.Text + txtUser.Text + ".wav", "", 0, 0);
            mciSendString("close recsound ", "", 0, 0);
        }

        private void btnEnrollAudio_Click(object sender, EventArgs e)
        {
            var enrollQuery = new WebSpeechEnrollmentQuery
            {
                ProfileId = ConfigurationManager.AppSettings["VerificationProfileId"],
                ShortAudio = true
            };

            var fileHelper = new FileHelper();
            var wavBytes = fileHelper.FileToBytes(txtOutputDirectory.Text + txtUser.Text + ".wav");

            var enrollUri = new Uri(enrollQuery.ToString());
            var downloader = new HttpDownloader();
            
            txtApiResponse.Text = downloader.GetResponse(enrollUri, wavBytes);
        }
    }
}
