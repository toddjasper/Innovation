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
        public static string _enrollmentPath = @"C:\temp\Audio\Enrollment\";
        public static string _identificationPath = @"C:\temp\Audio\Identification\";

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

            /*
                COMMANDS:

                alignment integer
                any input
                any output
                audio all off
                audio all on
                audio left off
                audio left on
                audio right off
                audio right on
                bitspersample bit_count
                bytespersec byte_rate
                channels channel_count
                door closed
                door open
                format tag pcm
                format tag tag
                input integer
                output integer
                samplespersec integer
                time format bytes
                time format milliseconds
                time format samples 
            */

            SetFileCount();

            // ORIGINAL
            //mciSendString("open new Type waveaudio Alias recsound", "", 0, 0);
            //mciSendString("open new Type waveaudio channels 1 Alias recsound", "", 0, 0);
            mciSendString("open new Type waveaudio Alias recsound", "", 0, 0);
            //mciSendString("set recsound bitspersample 16 channels 1", "", 0, 0);
            mciSendString("set recsound channels 1", "", 0, 0);
            mciSendString("record recsound", "", 0, 0);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            mciSendString(@"save recsound " + _enrollmentPath + txtUsername.Text + _audioFileCount + ".wav", "", 0, 0);
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
            var wavBytes = fileHelper.FileToBytes(_enrollmentPath + txtUsername.Text + "0.wav");

            var enrollUri = new Uri(enrollQuery.ToString());
            var downloader = new HttpDownloader();

            var response = downloader.GetResponse(enrollUri, wavBytes);

            Clipboard.SetText(response);
            MessageBox.Show(response, "Registration Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetFileCount()
        {
            var fileCount = 1;
            if (File.Exists(_enrollmentPath + txtUsername.Text + "1.wav"))
            {
                fileCount++;
                _audioFileCount = fileCount;
            }

            if (File.Exists(_enrollmentPath + txtUsername.Text + "2.wav"))
            {
                fileCount++;
                _audioFileCount = fileCount;
            }

            if (File.Exists(_enrollmentPath + txtUsername.Text + "3.wav"))
            {
                fileCount++;
                _audioFileCount = fileCount;
            }
                
            if (_audioFileCount > 3)
            {
                _audioFileCount = 1;
            }
        }
    }
}
