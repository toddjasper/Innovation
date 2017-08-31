namespace Innovation.Voice.Win.UI
{
    partial class AccessGrantedForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessGrantedForm));
            this.picAccessGranted = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAccessGranted)).BeginInit();
            this.SuspendLayout();
            // 
            // picAccessGranted
            // 
            this.picAccessGranted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAccessGranted.Image = ((System.Drawing.Image)(resources.GetObject("picAccessGranted.Image")));
            this.picAccessGranted.Location = new System.Drawing.Point(0, 0);
            this.picAccessGranted.Name = "picAccessGranted";
            this.picAccessGranted.Size = new System.Drawing.Size(1104, 708);
            this.picAccessGranted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAccessGranted.TabIndex = 0;
            this.picAccessGranted.TabStop = false;
            this.picAccessGranted.Click += new System.EventHandler(this.picAccessGranted_Click);
            // 
            // AccessGrantedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 708);
            this.Controls.Add(this.picAccessGranted);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccessGrantedForm";
            this.Text = "Access Granted";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AccessGrantedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAccessGranted)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picAccessGranted;
    }
}