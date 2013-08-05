namespace ProvenSecure_DARPA_CFT_2013
{
    partial class form_VoiceFactor
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
            this.components = new System.ComponentModel.Container();
            this.tb_Challenge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_SpeechRecognitionEnabled = new System.Windows.Forms.CheckBox();
            this.tb_Recognized = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbStopped = new System.Windows.Forms.RadioButton();
            this.rbSpeech = new System.Windows.Forms.RadioButton();
            this.rbSilence = new System.Windows.Forms.RadioButton();
            this.tb_Hidden = new System.Windows.Forms.TextBox();
            this.lbl_TextVerified = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.panel_ChildBody = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel_ChildBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Challenge
            // 
            this.tb_Challenge.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_Challenge.Location = new System.Drawing.Point(18, 78);
            this.tb_Challenge.Multiline = true;
            this.tb_Challenge.Name = "tb_Challenge";
            this.tb_Challenge.ReadOnly = true;
            this.tb_Challenge.Size = new System.Drawing.Size(409, 57);
            this.tb_Challenge.TabIndex = 7;
            this.tb_Challenge.Text = "This is a test of the emergency broadcast system this is only a test";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Click \"Start\" below and say the following phrase:";
            // 
            // cb_SpeechRecognitionEnabled
            // 
            this.cb_SpeechRecognitionEnabled.AutoSize = true;
            this.cb_SpeechRecognitionEnabled.Checked = true;
            this.cb_SpeechRecognitionEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_SpeechRecognitionEnabled.Location = new System.Drawing.Point(151, 22);
            this.cb_SpeechRecognitionEnabled.Name = "cb_SpeechRecognitionEnabled";
            this.cb_SpeechRecognitionEnabled.Size = new System.Drawing.Size(210, 21);
            this.cb_SpeechRecognitionEnabled.TabIndex = 9;
            this.cb_SpeechRecognitionEnabled.Text = "Speech Recognition Enabled";
            this.cb_SpeechRecognitionEnabled.UseVisualStyleBackColor = true;
            this.cb_SpeechRecognitionEnabled.CheckedChanged += new System.EventHandler(this.cb_SpeechRecognitionEnabled_CheckedChanged);
            // 
            // tb_Recognized
            // 
            this.tb_Recognized.BackColor = System.Drawing.SystemColors.Info;
            this.tb_Recognized.Location = new System.Drawing.Point(98, 141);
            this.tb_Recognized.Multiline = true;
            this.tb_Recognized.Name = "tb_Recognized";
            this.tb_Recognized.ReadOnly = true;
            this.tb_Recognized.Size = new System.Drawing.Size(329, 57);
            this.tb_Recognized.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.numericUpDown1.Location = new System.Drawing.Point(331, 320);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(70, 23);
            this.numericUpDown1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "# Retries: ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 260);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(409, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(196, 320);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(81, 23);
            this.textBox3.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 320);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(81, 23);
            this.textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 320);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(81, 23);
            this.textBox1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 296);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Fr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 296);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Fa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 299);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Score";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbStopped);
            this.groupBox1.Controls.Add(this.rbSpeech);
            this.groupBox1.Controls.Add(this.rbSilence);
            this.groupBox1.Location = new System.Drawing.Point(433, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 127);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AudioState";
            // 
            // rbStopped
            // 
            this.rbStopped.AutoSize = true;
            this.rbStopped.Location = new System.Drawing.Point(13, 88);
            this.rbStopped.Name = "rbStopped";
            this.rbStopped.Size = new System.Drawing.Size(79, 21);
            this.rbStopped.TabIndex = 2;
            this.rbStopped.TabStop = true;
            this.rbStopped.Text = "Stopped";
            this.rbStopped.UseVisualStyleBackColor = true;
            // 
            // rbSpeech
            // 
            this.rbSpeech.AutoSize = true;
            this.rbSpeech.Location = new System.Drawing.Point(13, 60);
            this.rbSpeech.Name = "rbSpeech";
            this.rbSpeech.Size = new System.Drawing.Size(74, 21);
            this.rbSpeech.TabIndex = 1;
            this.rbSpeech.TabStop = true;
            this.rbSpeech.Text = "Speech";
            this.rbSpeech.UseVisualStyleBackColor = true;
            // 
            // rbSilence
            // 
            this.rbSilence.AutoSize = true;
            this.rbSilence.Location = new System.Drawing.Point(13, 32);
            this.rbSilence.Name = "rbSilence";
            this.rbSilence.Size = new System.Drawing.Size(72, 21);
            this.rbSilence.TabIndex = 0;
            this.rbSilence.TabStop = true;
            this.rbSilence.Text = "Silence";
            this.rbSilence.UseVisualStyleBackColor = true;
            // 
            // tb_Hidden
            // 
            this.tb_Hidden.Location = new System.Drawing.Point(16, 359);
            this.tb_Hidden.Name = "tb_Hidden";
            this.tb_Hidden.Size = new System.Drawing.Size(172, 23);
            this.tb_Hidden.TabIndex = 25;
            // 
            // lbl_TextVerified
            // 
            this.lbl_TextVerified.AutoSize = true;
            this.lbl_TextVerified.Location = new System.Drawing.Point(99, 201);
            this.lbl_TextVerified.Name = "lbl_TextVerified";
            this.lbl_TextVerified.Size = new System.Drawing.Size(232, 17);
            this.lbl_TextVerified.TabIndex = 26;
            this.lbl_TextVerified.Text = "Text Verified Audio: has not passed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Transmitting: ";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(17, 141);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 57);
            this.btn_Start.TabIndex = 28;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // panel_ChildBody
            // 
            this.panel_ChildBody.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_ChildBody.Controls.Add(this.label7);
            this.panel_ChildBody.Controls.Add(this.groupBox1);
            this.panel_ChildBody.Controls.Add(this.btn_Start);
            this.panel_ChildBody.Controls.Add(this.tb_Challenge);
            this.panel_ChildBody.Controls.Add(this.label5);
            this.panel_ChildBody.Controls.Add(this.label4);
            this.panel_ChildBody.Controls.Add(this.lbl_TextVerified);
            this.panel_ChildBody.Controls.Add(this.cb_SpeechRecognitionEnabled);
            this.panel_ChildBody.Controls.Add(this.tb_Hidden);
            this.panel_ChildBody.Controls.Add(this.tb_Recognized);
            this.panel_ChildBody.Controls.Add(this.numericUpDown1);
            this.panel_ChildBody.Controls.Add(this.textBox3);
            this.panel_ChildBody.Controls.Add(this.label6);
            this.panel_ChildBody.Controls.Add(this.progressBar1);
            this.panel_ChildBody.Controls.Add(this.textBox2);
            this.panel_ChildBody.Controls.Add(this.label1);
            this.panel_ChildBody.Controls.Add(this.textBox1);
            this.panel_ChildBody.Controls.Add(this.label2);
            this.panel_ChildBody.Controls.Add(this.label3);
            this.panel_ChildBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ChildBody.Location = new System.Drawing.Point(0, 0);
            this.panel_ChildBody.MaximumSize = new System.Drawing.Size(4, 352);
            this.panel_ChildBody.MinimumSize = new System.Drawing.Size(560, 352);
            this.panel_ChildBody.Name = "panel_ChildBody";
            this.panel_ChildBody.Size = new System.Drawing.Size(560, 352);
            this.panel_ChildBody.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "AT&&T Voice";
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // form_VoiceFactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 379);
            this.Controls.Add(this.panel_ChildBody);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_VoiceFactor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AT&T Voice Factor";
            this.Shown += new System.EventHandler(this.form_VoiceFactor_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_ChildBody.ResumeLayout(false);
            this.panel_ChildBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Challenge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cb_SpeechRecognitionEnabled;
        private System.Windows.Forms.TextBox tb_Recognized;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbStopped;
        private System.Windows.Forms.RadioButton rbSpeech;
        private System.Windows.Forms.RadioButton rbSilence;
        private System.Windows.Forms.TextBox tb_Hidden;
        private System.Windows.Forms.Label lbl_TextVerified;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Panel panel_ChildBody;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer2;
    }
}