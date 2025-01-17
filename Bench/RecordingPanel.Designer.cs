﻿namespace Bench
{
    partial class RecordingPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordingPanel));
            this.buttonStartRecording = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStopRecording = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonWaveIn = new System.Windows.Forms.RadioButton();
            this.radioButtonWasapi = new System.Windows.Forms.RadioButton();
            this.comboWasapiDevices = new System.Windows.Forms.ComboBox();
            this.radioButtonWasapiLoopback = new System.Windows.Forms.RadioButton();
            this.radioButtonWaveInEvent = new System.Windows.Forms.RadioButton();
            this.listBoxRecordings = new System.Windows.Forms.ListBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.panel_audioSetup = new System.Windows.Forms.Panel();
            this.ll_Audio = new System.Windows.Forms.LinkLabel();
            this.panel_audioSetup.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStartRecording
            // 
            this.buttonStartRecording.Location = new System.Drawing.Point(45, 275);
            this.buttonStartRecording.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStartRecording.Name = "buttonStartRecording";
            this.buttonStartRecording.Size = new System.Drawing.Size(140, 28);
            this.buttonStartRecording.TabIndex = 0;
            this.buttonStartRecording.Text = "Test Recording";
            this.buttonStartRecording.UseVisualStyleBackColor = true;
            this.buttonStartRecording.Click += new System.EventHandler(this.OnButtonStartRecordingClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(41, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(781, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // buttonStopRecording
            // 
            this.buttonStopRecording.Location = new System.Drawing.Point(193, 275);
            this.buttonStopRecording.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStopRecording.Name = "buttonStopRecording";
            this.buttonStopRecording.Size = new System.Drawing.Size(140, 28);
            this.buttonStopRecording.TabIndex = 0;
            this.buttonStopRecording.Text = "Stop Recording";
            this.buttonStopRecording.UseVisualStyleBackColor = true;
            this.buttonStopRecording.Click += new System.EventHandler(this.OnButtonStopRecordingClick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(368, 273);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Maximum = 30;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(343, 28);
            this.progressBar1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 253);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Recording Progress:";
            // 
            // radioButtonWaveIn
            // 
            this.radioButtonWaveIn.AutoSize = true;
            this.radioButtonWaveIn.Checked = true;
            this.radioButtonWaveIn.Location = new System.Drawing.Point(65, 128);
            this.radioButtonWaveIn.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonWaveIn.Name = "radioButtonWaveIn";
            this.radioButtonWaveIn.Size = new System.Drawing.Size(69, 21);
            this.radioButtonWaveIn.TabIndex = 6;
            this.radioButtonWaveIn.TabStop = true;
            this.radioButtonWaveIn.Text = "waveIn";
            this.radioButtonWaveIn.UseVisualStyleBackColor = true;
            // 
            // radioButtonWasapi
            // 
            this.radioButtonWasapi.AutoSize = true;
            this.radioButtonWasapi.Location = new System.Drawing.Point(65, 199);
            this.radioButtonWasapi.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonWasapi.Name = "radioButtonWasapi";
            this.radioButtonWasapi.Size = new System.Drawing.Size(78, 21);
            this.radioButtonWasapi.TabIndex = 6;
            this.radioButtonWasapi.Text = "WASAPI";
            this.radioButtonWasapi.UseVisualStyleBackColor = true;
            // 
            // comboWasapiDevices
            // 
            this.comboWasapiDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboWasapiDevices.FormattingEnabled = true;
            this.comboWasapiDevices.Location = new System.Drawing.Point(247, 198);
            this.comboWasapiDevices.Margin = new System.Windows.Forms.Padding(4);
            this.comboWasapiDevices.Name = "comboWasapiDevices";
            this.comboWasapiDevices.Size = new System.Drawing.Size(464, 24);
            this.comboWasapiDevices.TabIndex = 7;
            // 
            // radioButtonWasapiLoopback
            // 
            this.radioButtonWasapiLoopback.AutoSize = true;
            this.radioButtonWasapiLoopback.Location = new System.Drawing.Point(65, 227);
            this.radioButtonWasapiLoopback.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonWasapiLoopback.Name = "radioButtonWasapiLoopback";
            this.radioButtonWasapiLoopback.Size = new System.Drawing.Size(144, 21);
            this.radioButtonWasapiLoopback.TabIndex = 6;
            this.radioButtonWasapiLoopback.Text = "WASAPI Loopback";
            this.radioButtonWasapiLoopback.UseVisualStyleBackColor = true;
            // 
            // radioButtonWaveInEvent
            // 
            this.radioButtonWaveInEvent.AutoSize = true;
            this.radioButtonWaveInEvent.Location = new System.Drawing.Point(65, 156);
            this.radioButtonWaveInEvent.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonWaveInEvent.Name = "radioButtonWaveInEvent";
            this.radioButtonWaveInEvent.Size = new System.Drawing.Size(173, 21);
            this.radioButtonWaveInEvent.TabIndex = 6;
            this.radioButtonWaveInEvent.Text = "waveIn Event Callbacks";
            this.radioButtonWaveInEvent.UseVisualStyleBackColor = true;
            // 
            // listBoxRecordings
            // 
            this.listBoxRecordings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRecordings.FormattingEnabled = true;
            this.listBoxRecordings.ItemHeight = 16;
            this.listBoxRecordings.Location = new System.Drawing.Point(45, 325);
            this.listBoxRecordings.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxRecordings.Name = "listBoxRecordings";
            this.listBoxRecordings.Size = new System.Drawing.Size(668, 116);
            this.listBoxRecordings.TabIndex = 8;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlay.Location = new System.Drawing.Point(722, 325);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(100, 28);
            this.buttonPlay.TabIndex = 9;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.OnButtonPlayClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(722, 360);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 28);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.OnButtonDeleteClick);
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFolder.Location = new System.Drawing.Point(722, 396);
            this.buttonOpenFolder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(100, 28);
            this.buttonOpenFolder.TabIndex = 10;
            this.buttonOpenFolder.Text = "Open Folder";
            this.buttonOpenFolder.UseVisualStyleBackColor = true;
            this.buttonOpenFolder.Click += new System.EventHandler(this.OnOpenFolderClick);
            // 
            // panel_audioSetup
            // 
            this.panel_audioSetup.BackColor = System.Drawing.Color.Black;
            this.panel_audioSetup.Controls.Add(this.ll_Audio);
            this.panel_audioSetup.Location = new System.Drawing.Point(39, 7);
            this.panel_audioSetup.Margin = new System.Windows.Forms.Padding(5);
            this.panel_audioSetup.Name = "panel_audioSetup";
            this.panel_audioSetup.Size = new System.Drawing.Size(118, 34);
            this.panel_audioSetup.TabIndex = 26;
            // 
            // ll_Audio
            // 
            this.ll_Audio.AutoSize = true;
            this.ll_Audio.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_Audio.LinkColor = System.Drawing.Color.White;
            this.ll_Audio.Location = new System.Drawing.Point(4, 3);
            this.ll_Audio.Name = "ll_Audio";
            this.ll_Audio.Size = new System.Drawing.Size(44, 17);
            this.ll_Audio.TabIndex = 0;
            this.ll_Audio.TabStop = true;
            this.ll_Audio.Text = "Audio";
            // 
            // RecordingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_audioSetup);
            this.Controls.Add(this.buttonOpenFolder);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.listBoxRecordings);
            this.Controls.Add(this.comboWasapiDevices);
            this.Controls.Add(this.radioButtonWasapiLoopback);
            this.Controls.Add(this.radioButtonWasapi);
            this.Controls.Add(this.radioButtonWaveInEvent);
            this.Controls.Add(this.radioButtonWaveIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStopRecording);
            this.Controls.Add(this.buttonStartRecording);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RecordingPanel";
            this.Size = new System.Drawing.Size(836, 468);
            this.panel_audioSetup.ResumeLayout(false);
            this.panel_audioSetup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartRecording;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStopRecording;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonWaveIn;
        private System.Windows.Forms.RadioButton radioButtonWasapi;
        private System.Windows.Forms.ComboBox comboWasapiDevices;
        private System.Windows.Forms.RadioButton radioButtonWasapiLoopback;
        private System.Windows.Forms.RadioButton radioButtonWaveInEvent;
        private System.Windows.Forms.ListBox listBoxRecordings;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonOpenFolder;
        internal System.Windows.Forms.Panel panel_audioSetup;
        private System.Windows.Forms.LinkLabel ll_Audio;
    }
}