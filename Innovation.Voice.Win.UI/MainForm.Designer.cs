namespace Innovation.Voice.Win.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnAuthenticate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboUsername = new System.Windows.Forms.ComboBox();
            this.btnAuthenticationFailTest = new System.Windows.Forms.Button();
            this.btnCreateProfiles = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(530, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(37, 20);
            this.miFile.Text = "&File";
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(92, 22);
            this.miExit.Text = "E&xit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(410, 267);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(109, 37);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnAuthenticate
            // 
            this.btnAuthenticate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthenticate.Location = new System.Drawing.Point(10, 76);
            this.btnAuthenticate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAuthenticate.Name = "btnAuthenticate";
            this.btnAuthenticate.Size = new System.Drawing.Size(508, 59);
            this.btnAuthenticate.TabIndex = 2;
            this.btnAuthenticate.Text = "Authenticate";
            this.btnAuthenticate.UseVisualStyleBackColor = true;
            this.btnAuthenticate.Click += new System.EventHandler(this.btnAuthenticate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // cboUsername
            // 
            this.cboUsername.FormattingEnabled = true;
            this.cboUsername.Location = new System.Drawing.Point(11, 40);
            this.cboUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboUsername.Name = "cboUsername";
            this.cboUsername.Size = new System.Drawing.Size(167, 21);
            this.cboUsername.TabIndex = 6;
            // 
            // btnAuthenticationFailTest
            // 
            this.btnAuthenticationFailTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthenticationFailTest.Location = new System.Drawing.Point(11, 157);
            this.btnAuthenticationFailTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAuthenticationFailTest.Name = "btnAuthenticationFailTest";
            this.btnAuthenticationFailTest.Size = new System.Drawing.Size(508, 59);
            this.btnAuthenticationFailTest.TabIndex = 7;
            this.btnAuthenticationFailTest.Text = "Authenticate with other account";
            this.btnAuthenticationFailTest.UseVisualStyleBackColor = true;
            this.btnAuthenticationFailTest.Visible = false;
            this.btnAuthenticationFailTest.Click += new System.EventHandler(this.btnAuthenticationFailTest_Click);
            // 
            // btnCreateProfiles
            // 
            this.btnCreateProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateProfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateProfiles.Location = new System.Drawing.Point(218, 267);
            this.btnCreateProfiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateProfiles.Name = "btnCreateProfiles";
            this.btnCreateProfiles.Size = new System.Drawing.Size(188, 37);
            this.btnCreateProfiles.TabIndex = 8;
            this.btnCreateProfiles.Text = "Create Profiles";
            this.btnCreateProfiles.UseVisualStyleBackColor = true;
            this.btnCreateProfiles.Click += new System.EventHandler(this.btnCreateProfiles_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(12, 282);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(156, 20);
            this.txtUsername.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 314);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreateProfiles);
            this.Controls.Add(this.btnAuthenticationFailTest);
            this.Controls.Add(this.cboUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAuthenticate);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Voice Authentication";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnAuthenticate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboUsername;
        private System.Windows.Forms.Button btnAuthenticationFailTest;
        private System.Windows.Forms.Button btnCreateProfiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
    }
}

