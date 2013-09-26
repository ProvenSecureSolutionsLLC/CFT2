namespace Bench
{
    partial class form_Session_Container
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
            this.panel_ChildBody = new System.Windows.Forms.Panel();
            this.panel_SessionResult = new System.Windows.Forms.Panel();
            this.label_ElapsedTime = new System.Windows.Forms.Label();
            this.btn_recordsessionresult = new System.Windows.Forms.Button();
            this.panel_session_header = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.timer_session = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Filename = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_ChildBody.SuspendLayout();
            this.panel_SessionResult.SuspendLayout();
            this.panel_session_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ChildBody
            // 
            this.panel_ChildBody.AutoScroll = true;
            this.panel_ChildBody.Controls.Add(this.panel_SessionResult);
            this.panel_ChildBody.Controls.Add(this.panel_session_header);
            this.panel_ChildBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ChildBody.Location = new System.Drawing.Point(0, 0);
            this.panel_ChildBody.Margin = new System.Windows.Forms.Padding(4);
            this.panel_ChildBody.Name = "panel_ChildBody";
            this.panel_ChildBody.Size = new System.Drawing.Size(1019, 514);
            this.panel_ChildBody.TabIndex = 0;
            // 
            // panel_SessionResult
            // 
            this.panel_SessionResult.Controls.Add(this.label5);
            this.panel_SessionResult.Controls.Add(this.label4);
            this.panel_SessionResult.Controls.Add(this.label3);
            this.panel_SessionResult.Controls.Add(this.label2);
            this.panel_SessionResult.Controls.Add(this.label_ElapsedTime);
            this.panel_SessionResult.Controls.Add(this.btn_recordsessionresult);
            this.panel_SessionResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_SessionResult.Location = new System.Drawing.Point(0, 396);
            this.panel_SessionResult.Name = "panel_SessionResult";
            this.panel_SessionResult.Size = new System.Drawing.Size(1019, 118);
            this.panel_SessionResult.TabIndex = 1;
            // 
            // label_ElapsedTime
            // 
            this.label_ElapsedTime.AutoSize = true;
            this.label_ElapsedTime.Location = new System.Drawing.Point(12, 65);
            this.label_ElapsedTime.Name = "label_ElapsedTime";
            this.label_ElapsedTime.Size = new System.Drawing.Size(102, 17);
            this.label_ElapsedTime.TabIndex = 5;
            this.label_ElapsedTime.Text = "Elapsed Time: ";
            // 
            // btn_recordsessionresult
            // 
            this.btn_recordsessionresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recordsessionresult.Location = new System.Drawing.Point(9, 15);
            this.btn_recordsessionresult.Name = "btn_recordsessionresult";
            this.btn_recordsessionresult.Size = new System.Drawing.Size(239, 38);
            this.btn_recordsessionresult.TabIndex = 4;
            this.btn_recordsessionresult.Text = "Finish Authenitcation Session";
            this.btn_recordsessionresult.UseVisualStyleBackColor = true;
            this.btn_recordsessionresult.Click += new System.EventHandler(this.btn_recordsessionresult_Click);
            // 
            // panel_session_header
            // 
            this.panel_session_header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_session_header.Controls.Add(this.label_Filename);
            this.panel_session_header.Controls.Add(this.label1);
            this.panel_session_header.Controls.Add(this.button1);
            this.panel_session_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_session_header.Location = new System.Drawing.Point(0, 0);
            this.panel_session_header.Name = "panel_session_header";
            this.panel_session_header.Size = new System.Drawing.Size(1019, 74);
            this.panel_session_header.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(8, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 39);
            this.button1.TabIndex = 34;
            this.button1.Text = "Start Authentication Session";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer_session
            // 
            this.timer_session.Interval = 1000;
            this.timer_session.Tick += new System.EventHandler(this.timer_session_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "<-- This sets/resets the Datetime Filename to record for this session when you cl" +
    "ick Finish below";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "<-- This saves the session results to disk and clears the form";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(655, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Go back to the top and press Start Authentication Session when ready to create an" +
    "other session result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(606, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "If you do not click Start again, you can Overwrite the existing session result wh" +
    "ich can be useful";
            // 
            // label_Filename
            // 
            this.label_Filename.AutoSize = true;
            this.label_Filename.Location = new System.Drawing.Point(293, 41);
            this.label_Filename.Name = "label_Filename";
            this.label_Filename.Size = new System.Drawing.Size(16, 17);
            this.label_Filename.TabIndex = 36;
            this.label_Filename.Text = "::";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Some fields are not cleared, for your convenience";
            // 
            // form_Session_Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 514);
            this.Controls.Add(this.panel_ChildBody);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_Session_Container";
            this.Text = "form_Session_Container";
            this.panel_ChildBody.ResumeLayout(false);
            this.panel_SessionResult.ResumeLayout(false);
            this.panel_SessionResult.PerformLayout();
            this.panel_session_header.ResumeLayout(false);
            this.panel_session_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ChildBody;
        private System.Windows.Forms.Panel panel_session_header;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_SessionResult;
        private System.Windows.Forms.Label label_ElapsedTime;
        private System.Windows.Forms.Button btn_recordsessionresult;
        private System.Windows.Forms.Timer timer_session;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Filename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}