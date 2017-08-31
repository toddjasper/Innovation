using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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

        private void btnRecord_Click(object sender, System.EventArgs e)
        {
            mciSendString("open new Type waveaudio Alias recsound", "", 0, 0);
            mciSendString("record recsound", "", 0, 0);
        }

        private void btnStop_Click(object sender, System.EventArgs e)
        {
            mciSendString(@"save recsound " + txtOutputDirectory.Text + txtUser.Text + ".wav", "", 0, 0);
            mciSendString("close recsound ", "", 0, 0);
        }

        private void btnSpeechRequest_Click(object sender, System.EventArgs e)
        {
            /*
            Endpoint: https://westus.api.cognitive.microsoft.com/spid/v1.0
            Key 1: d54d4d788d384a33b6e5dc0e7e492c8a
            Key 2: 0f80a15f531143c99ab1d7d9b3b7dc79             
            */

            var enrollUri = new Uri("https://westus.api.cognitive.microsoft.com/spid/v1.0/identificationProfiles/{identificationProfileId}/enroll");
        }
    }
}
