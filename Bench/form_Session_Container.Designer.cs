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
            this.panel_ChildBody = new System.Windows.Forms.Panel();
            this.panel_SessionResult = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_recordsessionresult = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_session_header = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel_SessionResult.Controls.Add(this.label16);
            this.panel_SessionResult.Controls.Add(this.btn_recordsessionresult);
            this.panel_SessionResult.Controls.Add(this.checkBox3);
            this.panel_SessionResult.Controls.Add(this.label2);
            this.panel_SessionResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_SessionResult.Location = new System.Drawing.Point(0, 392);
            this.panel_SessionResult.Name = "panel_SessionResult";
            this.panel_SessionResult.Size = new System.Drawing.Size(1019, 100);
            this.panel_SessionResult.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(179, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "Elapsed Time: ";
            // 
            // btn_recordsessionresult
            // 
            this.btn_recordsessionresult.Location = new System.Drawing.Point(466, 11);
            this.btn_recordsessionresult.Name = "btn_recordsessionresult";
            this.btn_recordsessionresult.Size = new System.Drawing.Size(239, 32);
            this.btn_recordsessionresult.TabIndex = 4;
            this.btn_recordsessionresult.Text = "Record Session Result";
            this.btn_recordsessionresult.UseVisualStyleBackColor = true;
            this.btn_recordsessionresult.Click += new System.EventHandler(this.btn_recordsessionresult_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(182, 11);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(128, 21);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Session Passed";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Session Result";
            // 
            // panel_session_header
            // 
            this.panel_session_header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_session_header.Controls.Add(this.checkBox2);
            this.panel_session_header.Controls.Add(this.button1);
            this.panel_session_header.Controls.Add(this.label1);
            this.panel_session_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_session_header.Location = new System.Drawing.Point(0, 0);
            this.panel_session_header.Name = "panel_session_header";
            this.panel_session_header.Size = new System.Drawing.Size(1019, 55);
            this.panel_session_header.TabIndex = 0;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(465, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(107, 21);
            this.checkBox2.TabIndex = 35;
            this.checkBox2.Text = "Enable RMM";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 29);
            this.button1.TabIndex = 34;
            this.button1.Text = "Timer is Off";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capture Authentication Session";
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
            this.panel_session_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ChildBody;
        private System.Windows.Forms.Panel panel_session_header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel panel_SessionResult;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_recordsessionresult;
    }
}