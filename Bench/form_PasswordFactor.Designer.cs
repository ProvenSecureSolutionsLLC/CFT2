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
            this.cb_correct = new System.Windows.Forms.CheckBox();
            this.lbl_Strength = new System.Windows.Forms.Label();
            this.updown_Age = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.updown_Attempts = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_ChildBody = new System.Windows.Forms.Panel();
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
            this.label2.Location = new System.Drawing.Point(19, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password: ";
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(20, 73);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(271, 23);
            this.tb_Password.TabIndex = 4;
            this.tb_Password.TextChanged += new System.EventHandler(this.tb_Password_TextChanged);
            this.tb_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Password_KeyPress);
            // 
            // cb_correct
            // 
            this.cb_correct.AutoSize = true;
            this.cb_correct.Checked = true;
            this.cb_correct.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_correct.Location = new System.Drawing.Point(506, 75);
            this.cb_correct.Margin = new System.Windows.Forms.Padding(4);
            this.cb_correct.Name = "cb_correct";
            this.cb_correct.Size = new System.Drawing.Size(85, 21);
            this.cb_correct.TabIndex = 8;
            this.cb_correct.Text = "Correct ?";
            this.cb_correct.UseVisualStyleBackColor = true;
            this.cb_correct.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lbl_Strength
            // 
            this.lbl_Strength.AutoSize = true;
            this.lbl_Strength.Location = new System.Drawing.Point(173, 52);
            this.lbl_Strength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Strength.Name = "lbl_Strength";
            this.lbl_Strength.Size = new System.Drawing.Size(70, 17);
            this.lbl_Strength.TabIndex = 9;
            this.lbl_Strength.Text = "Strength: ";
            // 
            // updown_Age
            // 
            this.updown_Age.Location = new System.Drawing.Point(316, 73);
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
            this.updown_Age.TabIndex = 10;
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
            this.label3.Location = new System.Drawing.Point(313, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Age:";
            // 
            // updown_Attempts
            // 
            this.updown_Attempts.Location = new System.Drawing.Point(405, 73);
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
            this.updown_Attempts.TabIndex = 12;
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
            this.label4.Location = new System.Drawing.Point(402, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Attempts:";
            // 
            // panel_ChildBody
            // 
            this.panel_ChildBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ChildBody.Controls.Add(this.label1);
            this.panel_ChildBody.Controls.Add(this.tb_Score);
            this.panel_ChildBody.Controls.Add(this.label7);
            this.panel_ChildBody.Controls.Add(this.tb_Password);
            this.panel_ChildBody.Controls.Add(this.label2);
            this.panel_ChildBody.Controls.Add(this.label4);
            this.panel_ChildBody.Controls.Add(this.cb_correct);
            this.panel_ChildBody.Controls.Add(this.updown_Attempts);
            this.panel_ChildBody.Controls.Add(this.lbl_Strength);
            this.panel_ChildBody.Controls.Add(this.label3);
            this.panel_ChildBody.Controls.Add(this.updown_Age);
            this.panel_ChildBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ChildBody.Location = new System.Drawing.Point(0, 0);
            this.panel_ChildBody.MaximumSize = new System.Drawing.Size(1800, 150);
            this.panel_ChildBody.MinimumSize = new System.Drawing.Size(1019, 113);
            this.panel_ChildBody.Name = "panel_ChildBody";
            this.panel_ChildBody.Size = new System.Drawing.Size(1019, 113);
            this.panel_ChildBody.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(742, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Score";
            // 
            // tb_Score
            // 
            this.tb_Score.Location = new System.Drawing.Point(790, 17);
            this.tb_Score.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Score.Name = "tb_Score";
            this.tb_Score.Size = new System.Drawing.Size(81, 23);
            this.tb_Score.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Traditional Password";
            // 
            // form_PasswordFactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 164);
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
        private System.Windows.Forms.CheckBox cb_correct;
        private System.Windows.Forms.Label lbl_Strength;
        private System.Windows.Forms.NumericUpDown updown_Age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown updown_Attempts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_ChildBody;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Score;
    }
}