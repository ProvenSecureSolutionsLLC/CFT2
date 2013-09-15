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
            this.panel_ChildBody.Size = new System.Drawing.Size(1019, 492);
            this.panel_ChildBody.TabIndex = 0;
            // 
            // panel_SessionResult
            // 
            this.panel_SessionResult.Controls.Add(this.label_ElapsedTime);
            this.panel_SessionResult.Controls.Add(this.btn_recordsessionresult);
            this.panel_SessionResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_SessionResult.Location = new System.Drawing.Point(0, 392);
            this.panel_SessionResult.Name = "panel_SessionResult";
            this.panel_SessionResult.Size = new System.Drawing.Size(1019, 100);
            this.panel_SessionResult.TabIndex = 1;
            // 
            // label_ElapsedTime
            // 
            this.label_ElapsedTime.AutoSize = true;
            this.label_ElapsedTime.Location = new System.Drawing.Point(303, 23);
            this.label_ElapsedTime.Name = "label_ElapsedTime";
            this.label_ElapsedTime.Size = new System.Drawing.Size(102, 17);
            this.label_ElapsedTime.TabIndex = 5;
            this.label_ElapsedTime.Text = "Elapsed Time: ";
            // 
            // btn_recordsessionresult
            // 
            this.btn_recordsessionresult.Location = new System.Drawing.Point(33, 15);
            this.btn_recordsessionresult.Name = "btn_recordsessionresult";
            this.btn_recordsessionresult.Size = new System.Drawing.Size(239, 32);
            this.btn_recordsessionresult.TabIndex = 4;
            this.btn_recordsessionresult.Text = "Session Completed";
            this.btn_recordsessionresult.UseVisualStyleBackColor = true;
            this.btn_recordsessionresult.Click += new System.EventHandler(this.btn_recordsessionresult_Click);
            // 
            // panel_session_header
            // 
            this.panel_session_header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_session_header.Controls.Add(this.button1);
            this.panel_session_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_session_header.Location = new System.Drawing.Point(0, 0);
            this.panel_session_header.Name = "panel_session_header";
            this.panel_session_header.Size = new System.Drawing.Size(1019, 50);
            this.panel_session_header.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 34);
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
            // form_Session_Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 492);
            this.Controls.Add(this.panel_ChildBody);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_Session_Container";
            this.Text = "form_Session_Container";
            this.panel_ChildBody.ResumeLayout(false);
            this.panel_SessionResult.ResumeLayout(false);
            this.panel_SessionResult.PerformLayout();
            this.panel_session_header.ResumeLayout(false);
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
    }
}