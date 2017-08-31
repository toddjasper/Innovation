using System;
using System.Configuration;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Innovation.Voice.Win.UI.Query.SpeechQueries;

namespace Innovation.Voice.Win.UI
{
    public partial class EnrollmentForm : Form
    {
        private int _audioFileCount = 0;

        public EnrollmentForm()
        {
            InitializeComponent();
        }

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            //string command = "set recsound time format 16 bit";
            //command += " bitspersample 16K";
            //command += " channels mono";
            ////command += " samplespersec " + WaveSamplesPerSec;
            ////command += " bytespersec " + WaveBytesPerSec;
            ////command += " alignment " + WaveAlignment;


            //mciSendString("open new Type waveaudio Alias recsound", "", 0, 0);
            //mciSendString("set recsound time format ms bitspersample 16 samplespersec 16000 channels mono", "", 0, 0);
            //mciSendString("record recsound", "", 0, 0);

            _audioFileCount = GetFileCount();

            mciSendString("open new Type waveaudio Alias recsound", "", 0, 0);
            mciSendString("record recsound", "", 0, 0);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            mciSendString(@"save recsound " + MainForm._enrollmentPath + txtUsername.Text + _audioFileCount + ".wav", "", 0, 0);
            mciSendString("close recsound ", "", 0, 0);
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            var enrollQuery = new WebSpeechEnrollmentQuery
            {
                ProfileId = ConfigurationManager.AppSettings["VerificationProfileId"],
                ShortAudio = true
            };

            var fileHelper = new FileHelper();
            var wavBytes = fileHelper.FileToBytes(MainForm._enrollmentPath + txtUsername.Text + _audioFileCount + ".wav");

            var enrollUri = new Uri(enrollQuery.ToString());
            var downloader = new HttpDownloader();

            var response = downloader.GetResponse(enrollUri, wavBytes);

            Clipboard.SetText(response);
            MessageBox.Show(response, "Registration Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int GetFileCount()
        {
            var directory = Directory.GetFiles(MainForm._identificationPath + txtUsername.Text + "*.wav");
            var fileCount = directory.Length;
            return fileCount++;
        }
    }
}
