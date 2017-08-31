using System;
using System.Windows.Forms;

namespace Innovation.Voice.Win.UI
{
    public partial class AccessDeniedForm : Form
    {
        public AccessDeniedForm()
        {
            InitializeComponent();
        }

        private void picAccessDenied_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccessDeniedForm_Load(object sender, EventArgs e)
        {
            var player = new System.Media.SoundPlayer
            {
                SoundLocation = @"C:\temp\InnovationProjects\Innovation\Innovation.Voice.Win.UI\Sound\access_denied.wav"
            };
            player.Play();
        }
    }
}
