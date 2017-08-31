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

        }
    }
}
