namespace Innovation.Voice.Win.UI
{
    partial class AccessDeniedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessDeniedForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.picAccessDenied = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAccessDenied)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            // 
            // picAccessDenied
            // 
            this.picAccessDenied.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAccessDenied.Image = ((System.Drawing.Image)(resources.GetObject("picAccessDenied.Image")));
            this.picAccessDenied.Location = new System.Drawing.Point(0, 0);
            this.picAccessDenied.Name = "picAccessDenied";
            this.picAccessDenied.Size = new System.Drawing.Size(1120, 798);
            this.picAccessDenied.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAccessDenied.TabIndex = 1;
            this.picAccessDenied.TabStop = false;
            this.picAccessDenied.Click += new System.EventHandler(this.picAccessDenied_Click);
            // 
            // AccessDeniedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1120, 798);
            this.Controls.Add(this.picAccessDenied);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccessDeniedForm";
            this.Text = "Access Denied";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AccessDeniedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAccessDenied)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox picAccessDenied;
    }
}