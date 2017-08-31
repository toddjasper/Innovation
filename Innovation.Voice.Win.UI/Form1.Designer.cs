namespace Innovation.Voice.Win.UI
{
    partial class VoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoiceForm));
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtOutputDirectory = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnSpeechRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRecord
            // 
            this.btnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.Location = new System.Drawing.Point(12, 149);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(211, 188);
            this.btnRecord.TabIndex = 0;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(341, 149);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(211, 188);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtOutputDirectory
            // 
            this.txtOutputDirectory.Location = new System.Drawing.Point(16, 33);
            this.txtOutputDirectory.Name = "txtOutputDirectory";
            this.txtOutputDirectory.Size = new System.Drawing.Size(540, 22);
            this.txtOutputDirectory.TabIndex = 2;
            this.txtOutputDirectory.Text = "C:\\temp\\Audio\\AuthAttempts\\";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(13, 13);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(51, 17);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "Output";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(12, 106);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(224, 22);
            this.txtUser.TabIndex = 4;
            this.txtUser.Text = "todd.jasper";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(13, 86);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 17);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "User";
            // 
            // btnSpeechRequest
            // 
            this.btnSpeechRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeechRequest.Location = new System.Drawing.Point(99, 516);
            this.btnSpeechRequest.Name = "btnSpeechRequest";
            this.btnSpeechRequest.Size = new System.Drawing.Size(301, 86);
            this.btnSpeechRequest.TabIndex = 6;
            this.btnSpeechRequest.Text = "Make Speech Request";
            this.btnSpeechRequest.UseVisualStyleBackColor = true;
            this.btnSpeechRequest.Click += new System.EventHandler(this.btnSpeechRequest_Click);
            // 
            // VoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 774);
            this.Controls.Add(this.btnSpeechRequest);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtOutputDirectory);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRecord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VoiceForm";
            this.Text = "Voice Authentication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtOutputDirectory;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnSpeechRequest;
    }
}

