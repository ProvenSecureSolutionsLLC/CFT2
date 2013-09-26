namespace Bench
{
    partial class form_PasswordFactor
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Strength = new System.Windows.Forms.Label();
            this.updown_Age = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.updown_Attempts = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_ChildBody = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_SMSScore = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.combo_Carrier = new System.Windows.Forms.ComboBox();
            this.btn_sendsms = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_SMSCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Score = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.updown_Age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updown_Attempts)).BeginInit();
            this.panel_ChildBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password: ";
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(34, 69);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(169, 23);
            this.tb_Password.TabIndex = 43;
            this.tb_Password.TextChanged += new System.EventHandler(this.tb_Password_TextChanged);
            this.tb_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Password_KeyPress);
            // 
            // lbl_Strength
            // 
            this.lbl_Strength.AutoSize = true;
            this.lbl_Strength.Location = new System.Drawing.Point(31, 163);
            this.lbl_Strength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Strength.Name = "lbl_Strength";
            this.lbl_Strength.Size = new System.Drawing.Size(96, 17);
            this.lbl_Strength.TabIndex = 9;
            this.lbl_Strength.Text = "PW Strength: ";
            // 
            // updown_Age
            // 
            this.updown_Age.Location = new System.Drawing.Point(34, 122);
            this.updown_Age.Margin = new System.Windows.Forms.Padding(4);
            this.updown_Age.Maximum = new decimal(new int[] {
            91,
            0,
            0,
            0});
            this.updown_Age.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updown_Age.Name = "updown_Age";
            this.updown_Age.Size = new System.Drawing.Size(72, 23);
            this.updown_Age.TabIndex = 44;
            this.updown_Age.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.updown_Age.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Age:";
            // 
            // updown_Attempts
            // 
            this.updown_Attempts.Location = new System.Drawing.Point(130, 122);
            this.updown_Attempts.Margin = new System.Windows.Forms.Padding(4);
            this.updown_Attempts.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.updown_Attempts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updown_Attempts.Name = "updown_Attempts";
            this.updown_Attempts.Size = new System.Drawing.Size(73, 23);
            this.updown_Attempts.TabIndex = 45;
            this.updown_Attempts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updown_Attempts.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Attempts:";
            // 
            // panel_ChildBody
            // 
            this.panel_ChildBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ChildBody.Controls.Add(this.label11);
            this.panel_ChildBody.Controls.Add(this.panel1);
            this.panel_ChildBody.Controls.Add(this.label10);
            this.panel_ChildBody.Controls.Add(this.tb_SMSScore);
            this.panel_ChildBody.Controls.Add(this.tb_phone);
            this.panel_ChildBody.Controls.Add(this.label9);
            this.panel_ChildBody.Controls.Add(this.label8);
            this.panel_ChildBody.Controls.Add(this.combo_Carrier);
            this.panel_ChildBody.Controls.Add(this.btn_sendsms);
            this.panel_ChildBody.Controls.Add(this.label5);
            this.panel_ChildBody.Controls.Add(this.tb_SMSCode);
            this.panel_ChildBody.Controls.Add(this.label1);
            this.panel_ChildBody.Controls.Add(this.tb_Score);
            this.panel_ChildBody.Controls.Add(this.label7);
            this.panel_ChildBody.Controls.Add(this.tb_Password);
            this.panel_ChildBody.Controls.Add(this.label2);
            this.panel_ChildBody.Controls.Add(this.label4);
            this.panel_ChildBody.Controls.Add(this.updown_Attempts);
            this.panel_ChildBody.Controls.Add(this.lbl_Strength);
            this.panel_ChildBody.Controls.Add(this.label3);
            this.panel_ChildBody.Controls.Add(this.updown_Age);
            this.panel_ChildBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ChildBody.Location = new System.Drawing.Point(0, 0);
            this.panel_ChildBody.MaximumSize = new System.Drawing.Size(1800, 225);
            this.panel_ChildBody.MinimumSize = new System.Drawing.Size(1019, 113);
            this.panel_ChildBody.Name = "panel_ChildBody";
            this.panel_ChildBody.Size = new System.Drawing.Size(1019, 225);
            this.panel_ChildBody.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(272, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 20);
            this.label11.TabIndex = 65;
            this.label11.Text = "SMS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(242, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 209);
            this.panel1.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(814, 45);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 63;
            this.label10.Text = "SMS Score";
            // 
            // tb_SMSScore
            // 
            this.tb_SMSScore.Location = new System.Drawing.Point(900, 42);
            this.tb_SMSScore.Margin = new System.Windows.Forms.Padding(4);
            this.tb_SMSScore.Name = "tb_SMSScore";
            this.tb_SMSScore.Size = new System.Drawing.Size(81, 23);
            this.tb_SMSScore.TabIndex = 51;
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(517, 67);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(184, 23);
            this.tb_phone.TabIndex = 47;
            this.tb_phone.TextChanged += new System.EventHandler(this.tb_phone_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(514, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 17);
            this.label9.TabIndex = 60;
            this.label9.Text = "SMS Phone# or Email Addr: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 17);
            this.label8.TabIndex = 59;
            this.label8.Text = "Mobile Phone / Method";
            // 
            // combo_Carrier
            // 
            this.combo_Carrier.FormattingEnabled = true;
            this.combo_Carrier.Items.AddRange(new object[] {
            "AT&T Wireless",
            "Sprint",
            "Sprint PCS",
            "T-Mobile",
            "Verizon",
            "Virgin",
            "Use My Email"});
            this.combo_Carrier.Location = new System.Drawing.Point(286, 68);
            this.combo_Carrier.Name = "combo_Carrier";
            this.combo_Carrier.Size = new System.Drawing.Size(214, 24);
            this.combo_Carrier.TabIndex = 46;
            this.combo_Carrier.Text = "AT&T Wireless";
            // 
            // btn_sendsms
            // 
            this.btn_sendsms.Location = new System.Drawing.Point(286, 101);
            this.btn_sendsms.Name = "btn_sendsms";
            this.btn_sendsms.Size = new System.Drawing.Size(134, 26);
            this.btn_sendsms.TabIndex = 48;
            this.btn_sendsms.Text = "Send SMS Code";
            this.btn_sendsms.UseVisualStyleBackColor = true;
            this.btn_sendsms.Click += new System.EventHandler(this.btn_sendsms_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Type-in the code that you receive: ";
            // 
            // tb_SMSCode
            // 
            this.tb_SMSCode.Location = new System.Drawing.Point(286, 163);
            this.tb_SMSCode.Name = "tb_SMSCode";
            this.tb_SMSCode.Size = new System.Drawing.Size(214, 23);
            this.tb_SMSCode.TabIndex = 49;
            this.tb_SMSCode.TextChanged += new System.EventHandler(this.tb_SMSCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(782, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Password Score";
            // 
            // tb_Score
            // 
            this.tb_Score.Location = new System.Drawing.Point(900, 16);
            this.tb_Score.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Score.Name = "tb_Score";
            this.tb_Score.Size = new System.Drawing.Size(81, 23);
            this.tb_Score.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Password";
            // 
            // form_PasswordFactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 235);
            this.Controls.Add(this.panel_ChildBody);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_PasswordFactor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Factor";
            ((System.ComponentModel.ISupportInitialize)(this.updown_Age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updown_Attempts)).EndInit();
            this.panel_ChildBody.ResumeLayout(false);
            this.panel_ChildBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lbl_Strength;
        private System.Windows.Forms.NumericUpDown updown_Age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown updown_Attempts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_ChildBody;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Score;
        private System.Windows.Forms.Button btn_sendsms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_SMSCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_SMSScore;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combo_Carrier;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
    }
}