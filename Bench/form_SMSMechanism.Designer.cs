namespace Bench
{
    partial class form_SMSMechanism
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
            this.button1 = new System.Windows.Forms.Button();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Score = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_Carrier = new System.Windows.Forms.ComboBox();
            this.panel_ChildBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ChildBody
            // 
            this.panel_ChildBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ChildBody.Controls.Add(this.combo_Carrier);
            this.panel_ChildBody.Controls.Add(this.label2);
            this.panel_ChildBody.Controls.Add(this.button1);
            this.panel_ChildBody.Controls.Add(this.tb_code);
            this.panel_ChildBody.Controls.Add(this.label5);
            this.panel_ChildBody.Controls.Add(this.label4);
            this.panel_ChildBody.Controls.Add(this.tb_phone);
            this.panel_ChildBody.Controls.Add(this.label7);
            this.panel_ChildBody.Controls.Add(this.label1);
            this.panel_ChildBody.Controls.Add(this.tb_Score);
            this.panel_ChildBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ChildBody.Location = new System.Drawing.Point(0, 0);
            this.panel_ChildBody.Margin = new System.Windows.Forms.Padding(4);
            this.panel_ChildBody.Name = "panel_ChildBody";
            this.panel_ChildBody.Size = new System.Drawing.Size(1031, 117);
            this.panel_ChildBody.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(397, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 23);
            this.button1.TabIndex = 54;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_code
            // 
            this.tb_code.Location = new System.Drawing.Point(494, 60);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(158, 23);
            this.tb_code.TabIndex = 53;
            this.tb_code.TextChanged += new System.EventHandler(this.tb_code_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "Type the received code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "Phone#: ";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(267, 60);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(124, 23);
            this.tb_phone.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "SMS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(744, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Score";
            // 
            // tb_Score
            // 
            this.tb_Score.Location = new System.Drawing.Point(792, 20);
            this.tb_Score.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Score.Name = "tb_Score";
            this.tb_Score.Size = new System.Drawing.Size(81, 23);
            this.tb_Score.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Carrier: ";
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
            ""});
            this.combo_Carrier.Location = new System.Drawing.Point(105, 60);
            this.combo_Carrier.Name = "combo_Carrier";
            this.combo_Carrier.Size = new System.Drawing.Size(140, 24);
            this.combo_Carrier.TabIndex = 57;
            this.combo_Carrier.Text = "AT&T Wireless";
            // 
            // form_SMSMechanism
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 321);
            this.Controls.Add(this.panel_ChildBody);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_SMSMechanism";
            this.Text = "form_SMSMechanism";
            this.panel_ChildBody.ResumeLayout(false);
            this.panel_ChildBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ChildBody;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Score;
        private System.Windows.Forms.ComboBox combo_Carrier;
        private System.Windows.Forms.Label label2;
    }
}