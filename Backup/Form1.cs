using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace WaveRec
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox Text3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnWavRecStart;
		private System.Windows.Forms.Button btnWavRecStop;
		private System.Windows.Forms.Button btnWavPlayStart;
		private System.Windows.Forms.Button btnWavPlayStop;
		private AxVCProX.AxvcproWaveInDeviceX wavInDeviceX;
		private AxVCProX.AxvcproWaveRiffX recWaveRiffX;
		private AxVCProX.AxvcproWaveRiffX playWaveRiffX;
		private AxVCProX.AxvcproWaveOutDeviceX wavOutDeviceX;
		private System.Windows.Forms.TextBox Text4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnRSetup;
		private System.Windows.Forms.ComboBox cbRDevice;
		private System.Windows.Forms.Label laBytesRecorded;
		private AxVCProX.AxvcproDisplayBandsX bandR1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label laBytesPlayed;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cbPDevice;
		private System.Windows.Forms.Button btnPSetup;
		private System.Windows.Forms.CheckBox chPStereo;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtPBits;
		private System.Windows.Forms.TextBox txtPSamplingRate;
		private System.Windows.Forms.CheckBox chPLoop;
		private System.Windows.Forms.Label label71;
		private AxVCProX.AxvcproDisplayBandsX bandR2;
		private AxVCProX.AxvcproDisplayBandsX bandP2;
		private AxVCProX.AxvcproDisplayBandsX bandP1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnQuality;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuality = new System.Windows.Forms.Button();
            this.label71 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bandR2 = new AxVCProX.AxvcproDisplayBandsX();
            this.bandR1 = new AxVCProX.AxvcproDisplayBandsX();
            this.btnRSetup = new System.Windows.Forms.Button();
            this.cbRDevice = new System.Windows.Forms.ComboBox();
            this.laBytesRecorded = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.recWaveRiffX = new AxVCProX.AxvcproWaveRiffX();
            this.wavInDeviceX = new AxVCProX.AxvcproWaveInDeviceX();
            this.btnWavRecStop = new System.Windows.Forms.Button();
            this.btnWavRecStart = new System.Windows.Forms.Button();
            this.Text3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chPLoop = new System.Windows.Forms.CheckBox();
            this.txtPSamplingRate = new System.Windows.Forms.TextBox();
            this.txtPBits = new System.Windows.Forms.TextBox();
            this.chPStereo = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPSetup = new System.Windows.Forms.Button();
            this.cbPDevice = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.laBytesPlayed = new System.Windows.Forms.Label();
            this.bandP2 = new AxVCProX.AxvcproDisplayBandsX();
            this.bandP1 = new AxVCProX.AxvcproDisplayBandsX();
            this.label2 = new System.Windows.Forms.Label();
            this.wavOutDeviceX = new AxVCProX.AxvcproWaveOutDeviceX();
            this.playWaveRiffX = new AxVCProX.AxvcproWaveRiffX();
            this.btnWavPlayStop = new System.Windows.Forms.Button();
            this.btnWavPlayStart = new System.Windows.Forms.Button();
            this.Text4 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bandR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recWaveRiffX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wavInDeviceX)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bandP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wavOutDeviceX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playWaveRiffX)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuality);
            this.groupBox1.Controls.Add(this.bandR2);
            this.groupBox1.Controls.Add(this.bandR1);
            this.groupBox1.Controls.Add(this.btnRSetup);
            this.groupBox1.Controls.Add(this.cbRDevice);
            this.groupBox1.Controls.Add(this.laBytesRecorded);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.recWaveRiffX);
            this.groupBox1.Controls.Add(this.wavInDeviceX);
            this.groupBox1.Controls.Add(this.btnWavRecStop);
            this.groupBox1.Controls.Add(this.btnWavRecStart);
            this.groupBox1.Controls.Add(this.Text3);
            this.groupBox1.Controls.Add(this.label71);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recording";
            // 
            // btnQuality
            // 
            this.btnQuality.Location = new System.Drawing.Point(8, 56);
            this.btnQuality.Name = "btnQuality";
            this.btnQuality.Size = new System.Drawing.Size(75, 23);
            this.btnQuality.TabIndex = 19;
            this.btnQuality.Text = "Quality...";
            this.btnQuality.Click += new System.EventHandler(this.btnQuality_Click);
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(128, 216);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(73, 13);
            this.label71.TabIndex = 18;
            this.label71.Text = "Right channel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Left channel";
            // 
            // bandR2
            // 
            this.bandR2.Enabled = true;
            this.bandR2.Location = new System.Drawing.Point(128, 232);
            this.bandR2.Name = "bandR2";
            this.bandR2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("bandR2.OcxState")));
            this.bandR2.Size = new System.Drawing.Size(104, 56);
            this.bandR2.TabIndex = 16;
            // 
            // bandR1
            // 
            this.bandR1.Enabled = true;
            this.bandR1.Location = new System.Drawing.Point(8, 232);
            this.bandR1.Name = "bandR1";
            this.bandR1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("bandR1.OcxState")));
            this.bandR1.Size = new System.Drawing.Size(104, 56);
            this.bandR1.TabIndex = 15;
            // 
            // btnRSetup
            // 
            this.btnRSetup.Location = new System.Drawing.Point(184, 16);
            this.btnRSetup.Name = "btnRSetup";
            this.btnRSetup.Size = new System.Drawing.Size(48, 23);
            this.btnRSetup.TabIndex = 11;
            this.btnRSetup.Text = "Setup...";
            this.btnRSetup.Click += new System.EventHandler(this.btnRSetup_Click);
            // 
            // cbRDevice
            // 
            this.cbRDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRDevice.Location = new System.Drawing.Point(48, 16);
            this.cbRDevice.Name = "cbRDevice";
            this.cbRDevice.Size = new System.Drawing.Size(128, 21);
            this.cbRDevice.TabIndex = 10;
            // 
            // laBytesRecorded
            // 
            this.laBytesRecorded.AutoSize = true;
            this.laBytesRecorded.Location = new System.Drawing.Point(8, 192);
            this.laBytesRecorded.Name = "laBytesRecorded";
            this.laBytesRecorded.Size = new System.Drawing.Size(88, 13);
            this.laBytesRecorded.TabIndex = 9;
            this.laBytesRecorded.Text = "laBytesRecorded";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Device";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Save recording to file";
            // 
            // recWaveRiffX
            // 
            this.recWaveRiffX.Enabled = true;
            this.recWaveRiffX.Location = new System.Drawing.Point(184, 152);
            this.recWaveRiffX.Name = "recWaveRiffX";
            this.recWaveRiffX.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("recWaveRiffX.OcxState")));
            this.recWaveRiffX.Size = new System.Drawing.Size(48, 32);
            this.recWaveRiffX.TabIndex = 4;
            // 
            // wavInDeviceX
            // 
            this.wavInDeviceX.Enabled = true;
            this.wavInDeviceX.Location = new System.Drawing.Point(160, 136);
            this.wavInDeviceX.Name = "wavInDeviceX";
            this.wavInDeviceX.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wavInDeviceX.OcxState")));
            this.wavInDeviceX.Size = new System.Drawing.Size(48, 32);
            this.wavInDeviceX.TabIndex = 3;
            // 
            // btnWavRecStop
            // 
            this.btnWavRecStop.Location = new System.Drawing.Point(80, 160);
            this.btnWavRecStop.Name = "btnWavRecStop";
            this.btnWavRecStop.Size = new System.Drawing.Size(64, 23);
            this.btnWavRecStop.TabIndex = 2;
            this.btnWavRecStop.Text = "Stop";
            this.btnWavRecStop.Click += new System.EventHandler(this.btnWavRecStop_Click);
            // 
            // btnWavRecStart
            // 
            this.btnWavRecStart.Location = new System.Drawing.Point(8, 160);
            this.btnWavRecStart.Name = "btnWavRecStart";
            this.btnWavRecStart.Size = new System.Drawing.Size(64, 23);
            this.btnWavRecStart.TabIndex = 1;
            this.btnWavRecStart.Text = "Start";
            this.btnWavRecStart.Click += new System.EventHandler(this.btnWavRecStart_Click);
            // 
            // Text3
            // 
            this.Text3.Location = new System.Drawing.Point(8, 112);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(224, 20);
            this.Text3.TabIndex = 0;
            this.Text3.Text = "C:\\Temp\\Stream44.wav";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chPLoop);
            this.groupBox2.Controls.Add(this.txtPSamplingRate);
            this.groupBox2.Controls.Add(this.txtPBits);
            this.groupBox2.Controls.Add(this.chPStereo);
            this.groupBox2.Controls.Add(this.btnPSetup);
            this.groupBox2.Controls.Add(this.cbPDevice);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.laBytesPlayed);
            this.groupBox2.Controls.Add(this.bandP2);
            this.groupBox2.Controls.Add(this.bandP1);
            this.groupBox2.Controls.Add(this.wavOutDeviceX);
            this.groupBox2.Controls.Add(this.playWaveRiffX);
            this.groupBox2.Controls.Add(this.btnWavPlayStop);
            this.groupBox2.Controls.Add(this.btnWavPlayStart);
            this.groupBox2.Controls.Add(this.Text4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(256, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 296);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Playback";
            // 
            // chPLoop
            // 
            this.chPLoop.AutoSize = true;
            this.chPLoop.Location = new System.Drawing.Point(8, 136);
            this.chPLoop.Name = "chPLoop";
            this.chPLoop.Size = new System.Drawing.Size(50, 17);
            this.chPLoop.TabIndex = 32;
            this.chPLoop.Text = "Loop";
            // 
            // txtPSamplingRate
            // 
            this.txtPSamplingRate.BackColor = System.Drawing.SystemColors.Control;
            this.txtPSamplingRate.Enabled = false;
            this.txtPSamplingRate.Location = new System.Drawing.Point(88, 64);
            this.txtPSamplingRate.Name = "txtPSamplingRate";
            this.txtPSamplingRate.Size = new System.Drawing.Size(64, 20);
            this.txtPSamplingRate.TabIndex = 31;
            this.txtPSamplingRate.Text = "0";
            // 
            // txtPBits
            // 
            this.txtPBits.BackColor = System.Drawing.SystemColors.Control;
            this.txtPBits.Enabled = false;
            this.txtPBits.Location = new System.Drawing.Point(8, 64);
            this.txtPBits.Name = "txtPBits";
            this.txtPBits.Size = new System.Drawing.Size(40, 20);
            this.txtPBits.TabIndex = 30;
            this.txtPBits.Text = "0";
            // 
            // chPStereo
            // 
            this.chPStereo.BackColor = System.Drawing.SystemColors.Control;
            this.chPStereo.Enabled = false;
            this.chPStereo.Location = new System.Drawing.Point(168, 62);
            this.chPStereo.Name = "chPStereo";
            this.chPStereo.Size = new System.Drawing.Size(64, 24);
            this.chPStereo.TabIndex = 29;
            this.chPStereo.Text = "Stereo";
            this.chPStereo.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(88, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Sampling rate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Bits per samle";
            // 
            // btnPSetup
            // 
            this.btnPSetup.Location = new System.Drawing.Point(184, 16);
            this.btnPSetup.Name = "btnPSetup";
            this.btnPSetup.Size = new System.Drawing.Size(48, 23);
            this.btnPSetup.TabIndex = 24;
            this.btnPSetup.Text = "Setup...";
            this.btnPSetup.Click += new System.EventHandler(this.btnPSetup_Click);
            // 
            // cbPDevice
            // 
            this.cbPDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPDevice.Location = new System.Drawing.Point(48, 16);
            this.cbPDevice.Name = "cbPDevice";
            this.cbPDevice.Size = new System.Drawing.Size(128, 21);
            this.cbPDevice.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Device";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Right channel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Left channel";
            // 
            // laBytesPlayed
            // 
            this.laBytesPlayed.AutoSize = true;
            this.laBytesPlayed.Location = new System.Drawing.Point(8, 192);
            this.laBytesPlayed.Name = "laBytesPlayed";
            this.laBytesPlayed.Size = new System.Drawing.Size(73, 13);
            this.laBytesPlayed.TabIndex = 19;
            this.laBytesPlayed.Text = "laBytesPlayed";
            // 
            // bandP2
            // 
            this.bandP2.Enabled = true;
            this.bandP2.Location = new System.Drawing.Point(128, 232);
            this.bandP2.Name = "bandP2";
            this.bandP2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("bandP2.OcxState")));
            this.bandP2.Size = new System.Drawing.Size(104, 56);
            this.bandP2.TabIndex = 8;
            // 
            // bandP1
            // 
            this.bandP1.Enabled = true;
            this.bandP1.Location = new System.Drawing.Point(8, 232);
            this.bandP1.Name = "bandP1";
            this.bandP1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("bandP1.OcxState")));
            this.bandP1.Size = new System.Drawing.Size(104, 56);
            this.bandP1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "File Name";
            // 
            // wavOutDeviceX
            // 
            this.wavOutDeviceX.Enabled = true;
            this.wavOutDeviceX.Location = new System.Drawing.Point(184, 152);
            this.wavOutDeviceX.Name = "wavOutDeviceX";
            this.wavOutDeviceX.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wavOutDeviceX.OcxState")));
            this.wavOutDeviceX.Size = new System.Drawing.Size(48, 32);
            this.wavOutDeviceX.TabIndex = 4;
            // 
            // playWaveRiffX
            // 
            this.playWaveRiffX.Enabled = true;
            this.playWaveRiffX.Location = new System.Drawing.Point(160, 136);
            this.playWaveRiffX.Name = "playWaveRiffX";
            this.playWaveRiffX.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("playWaveRiffX.OcxState")));
            this.playWaveRiffX.Size = new System.Drawing.Size(48, 32);
            this.playWaveRiffX.TabIndex = 3;
            // 
            // btnWavPlayStop
            // 
            this.btnWavPlayStop.Location = new System.Drawing.Point(80, 160);
            this.btnWavPlayStop.Name = "btnWavPlayStop";
            this.btnWavPlayStop.Size = new System.Drawing.Size(64, 23);
            this.btnWavPlayStop.TabIndex = 2;
            this.btnWavPlayStop.Text = "Stop";
            this.btnWavPlayStop.Click += new System.EventHandler(this.btnWavPlayStop_Click);
            // 
            // btnWavPlayStart
            // 
            this.btnWavPlayStart.Location = new System.Drawing.Point(8, 160);
            this.btnWavPlayStart.Name = "btnWavPlayStart";
            this.btnWavPlayStart.Size = new System.Drawing.Size(64, 23);
            this.btnWavPlayStart.TabIndex = 1;
            this.btnWavPlayStart.Text = "Start";
            this.btnWavPlayStart.Click += new System.EventHandler(this.btnWavPlayStart_Click);
            // 
            // Text4
            // 
            this.Text4.Location = new System.Drawing.Point(8, 112);
            this.Text4.Name = "Text4";
            this.Text4.Size = new System.Drawing.Size(224, 20);
            this.Text4.TabIndex = 0;
            this.Text4.Text = "C:\\Temp\\Stream44.wav";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(506, 311);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "WaveRec ::  (C) Lake of Soft";
            this.Closed += new System.EventHandler(this.Form1_Closed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bandR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandR1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recWaveRiffX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wavInDeviceX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bandP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wavOutDeviceX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playWaveRiffX)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void SetLink(VCProX.IvcproProvider provider, VCProX.IvcproConsumer consumer)
		{
			provider.AddConsumer(consumer);
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			for (int i = 0; i < wavInDeviceX.GetDeviceCount(); i++)
				cbRDevice.Items.Add(wavInDeviceX.GetDeviceName(i));

			cbRDevice.SelectedIndex = 0;
    
			for (int i = 0; i < wavOutDeviceX.GetDeviceCount(); i++)
				cbPDevice.Items.Add(wavOutDeviceX.GetDeviceName(i));
			
		   cbPDevice.SelectedIndex = 0;

			SetLink((VCProX.IvcproProvider)wavInDeviceX.GetOcx(), (VCProX.IvcproConsumer)recWaveRiffX.GetOcx());
			SetLink((VCProX.IvcproProvider)playWaveRiffX.GetOcx(), (VCProX.IvcproConsumer)wavOutDeviceX.GetOcx());

			SetLink((VCProX.IvcproProvider)wavInDeviceX.GetOcx(), (VCProX.IvcproConsumer)bandR1.GetOcx());
			SetLink((VCProX.IvcproProvider)wavInDeviceX.GetOcx(), (VCProX.IvcproConsumer)bandR2.GetOcx());
			SetLink((VCProX.IvcproProvider)playWaveRiffX.GetOcx(), (VCProX.IvcproConsumer)bandP1.GetOcx());
			SetLink((VCProX.IvcproProvider)playWaveRiffX.GetOcx(), (VCProX.IvcproConsumer)bandP2.GetOcx());
		}

		private void Form1_Closed(object sender, System.EventArgs e)
		{
		   wavInDeviceX.Active = false;
			playWaveRiffX.Active = false;
		}

		private void btnWavRecStart_Click(object sender, System.EventArgs e)
		{
			wavInDeviceX.DeviceId = cbRDevice.SelectedIndex;

		    recWaveRiffX.FileName = Text3.Text;
			wavInDeviceX.Active = true;
		}

		private void btnWavRecStop_Click(object sender, System.EventArgs e)
		{
			wavInDeviceX.Active = false;
		}

		private void btnWavPlayStart_Click(object sender, System.EventArgs e)
		{
			wavOutDeviceX.DeviceId = cbPDevice.SelectedIndex;

			playWaveRiffX.Loop = chPLoop.Checked;
			playWaveRiffX.FileName = Text4.Text;
			playWaveRiffX.Active = true;

			txtPBits.Text = playWaveRiffX.PcmBitsPerSample.ToString();
			txtPSamplingRate.Text = playWaveRiffX.PcmSamplesPerSec.ToString();
			chPStereo.Checked = playWaveRiffX.PcmNumChannels == 2;
		}

		private void btnWavPlayStop_Click(object sender, System.EventArgs e)
		{
			playWaveRiffX.Active = false;
		}

		private void btnRSetup_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("sndvol32", "/r /d" +
				Convert.ToString(wavInDeviceX.GetMixerId(cbRDevice.SelectedIndex, true)));
		}

		private void btnPSetup_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("sndvol32", "/p /d" +
				Convert.ToString(wavOutDeviceX.GetMixerId(cbPDevice.SelectedIndex, false)));
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			laBytesRecorded.Text = "bytes recorded: " + wavInDeviceX.DataSizeOut.ToString();
			laBytesPlayed.Text = "bytes played back: " + wavOutDeviceX.DataSizeIn.ToString() +
				"/" + playWaveRiffX.FileSize.ToString();

         btnWavRecStart.Enabled = ! recWaveRiffX.Active;
         btnWavRecStop.Enabled = recWaveRiffX.Active;
			btnWavPlayStart.Enabled = ! playWaveRiffX.Active;
			btnWavPlayStop.Enabled = playWaveRiffX.Active;
		}

		private void btnQuality_Click(object sender, System.EventArgs e)
		{
			if (recWaveRiffX.FormatChoose("Sound quality", (int) this.Handle))
			{
				wavInDeviceX.PcmBitsPerSample = recWaveRiffX.PcmBitsPerSample;
				wavInDeviceX.PcmNumChannels   = recWaveRiffX.PcmNumChannels;
				wavInDeviceX.PcmSamplesPerSec = recWaveRiffX.PcmSamplesPerSec;
			}
		}
	}
}
