using System;
using System.Windows.Forms;

namespace Innovation.Voice.Win.UI
{
    public partial class AccessGrantedForm : Form
    {
        public AccessGrantedForm()
        {
            InitializeComponent();
        }

        private void picAccessGranted_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccessGrantedForm_Load(object sender, EventArgs e)
        {
            var player = new System.Media.SoundPlayer
            {
                SoundLocation = @"C:\temp\InnovationProjects\Innovation\Innovation.Voice.Win.UI\Sound\access_granted.wav"
            };
            player.Play();
        }
    }
}
