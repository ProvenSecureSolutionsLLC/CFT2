namespace Bench
{
    partial class form_RMMContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_RMMContainer));
            this.panel_ChildBody = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_runhistoric = new System.Windows.Forms.CheckBox();
            this.tb_testscore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_authmech = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clb_Users = new System.Windows.Forms.CheckedListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_output2 = new System.Windows.Forms.TextBox();
            this.btn_Process3 = new System.Windows.Forms.Button();
            this.btn_Process2 = new System.Windows.Forms.Button();
            this.btn_Process1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cb_Native = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_log = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_suffix = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkbox_filter = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Script = new System.Windows.Forms.TextBox();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.cb_csv = new System.Windows.Forms.CheckBox();
            this.panel_ChildBody.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ChildBody
            // 
            this.panel_ChildBody.AutoScroll = true;
            this.panel_ChildBody.Controls.Add(this.tabControl1);
            this.panel_ChildBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ChildBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_ChildBody.Location = new System.Drawing.Point(0, 0);
            this.panel_ChildBody.Name = "panel_ChildBody";
            this.panel_ChildBody.Size = new System.Drawing.Size(1090, 767);
            this.panel_ChildBody.TabIndex = 0;
            this.panel_ChildBody.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_ChildBody_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1090, 767);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.clb_Users);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1082, 738);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Select Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_runhistoric);
            this.groupBox1.Controls.Add(this.tb_testscore);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.combo_authmech);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(364, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 483);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Invocation Settings ";
            // 
            // cb_runhistoric
            // 
            this.cb_runhistoric.AutoSize = true;
            this.cb_runhistoric.Location = new System.Drawing.Point(33, 130);
            this.cb_runhistoric.Name = "cb_runhistoric";
            this.cb_runhistoric.Size = new System.Drawing.Size(166, 21);
            this.cb_runhistoric.TabIndex = 4;
            this.cb_runhistoric.Text = "Run all historic scores";
            this.cb_runhistoric.UseVisualStyleBackColor = true;
            // 
            // tb_testscore
            // 
            this.tb_testscore.Location = new System.Drawing.Point(33, 194);
            this.tb_testscore.Name = "tb_testscore";
            this.tb_testscore.Size = new System.Drawing.Size(100, 23);
            this.tb_testscore.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Or provide a specific score to evaluate:";
            // 
            // combo_authmech
            // 
            this.combo_authmech.FormattingEnabled = true;
            this.combo_authmech.Items.AddRange(new object[] {
            "Password",
            "SMS",
            "AT&T Voice",
            "Betaface",
            "Knowledge"});
            this.combo_authmech.Location = new System.Drawing.Point(33, 76);
            this.combo_authmech.Name = "combo_authmech";
            this.combo_authmech.Size = new System.Drawing.Size(242, 24);
            this.combo_authmech.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Select an Authentication Mechanism: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select one or more Users to be Processed";
            // 
            // clb_Users
            // 
            this.clb_Users.CheckOnClick = true;
            this.clb_Users.FormattingEnabled = true;
            this.clb_Users.Location = new System.Drawing.Point(23, 62);
            this.clb_Users.Margin = new System.Windows.Forms.Padding(4);
            this.clb_Users.Name = "clb_Users";
            this.clb_Users.Size = new System.Drawing.Size(308, 454);
            this.clb_Users.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tb_output2);
            this.tabPage2.Controls.Add(this.btn_Process3);
            this.tabPage2.Controls.Add(this.btn_Process2);
            this.tabPage2.Controls.Add(this.btn_Process1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1082, 738);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Review \"Trained\" Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_output2
            // 
            this.tb_output2.Location = new System.Drawing.Point(25, 81);
            this.tb_output2.Multiline = true;
            this.tb_output2.Name = "tb_output2";
            this.tb_output2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_output2.Size = new System.Drawing.Size(939, 444);
            this.tb_output2.TabIndex = 6;
            // 
            // btn_Process3
            // 
            this.btn_Process3.Location = new System.Drawing.Point(482, 27);
            this.btn_Process3.Name = "btn_Process3";
            this.btn_Process3.Size = new System.Drawing.Size(108, 29);
            this.btn_Process3.TabIndex = 5;
            this.btn_Process3.Text = "NOOP";
            this.btn_Process3.UseVisualStyleBackColor = true;
            this.btn_Process3.Visible = false;
            this.btn_Process3.Click += new System.EventHandler(this.btn_Process3_Click);
            // 
            // btn_Process2
            // 
            this.btn_Process2.Location = new System.Drawing.Point(201, 27);
            this.btn_Process2.Name = "btn_Process2";
            this.btn_Process2.Size = new System.Drawing.Size(159, 29);
            this.btn_Process2.TabIndex = 4;
            this.btn_Process2.Text = "Statistical Summary";
            this.btn_Process2.UseVisualStyleBackColor = true;
            this.btn_Process2.Click += new System.EventHandler(this.btn_Process2_Click);
            // 
            // btn_Process1
            // 
            this.btn_Process1.Location = new System.Drawing.Point(25, 27);
            this.btn_Process1.Name = "btn_Process1";
            this.btn_Process1.Size = new System.Drawing.Size(148, 29);
            this.btn_Process1.TabIndex = 3;
            this.btn_Process1.Text = "Raw Training Data";
            this.btn_Process1.UseVisualStyleBackColor = true;
            this.btn_Process1.Click += new System.EventHandler(this.btn_Process1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.cb_csv);
            this.tabPage3.Controls.Add(this.cb_Native);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.tb_log);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.tb_suffix);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.checkbox_filter);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.textBox_Script);
            this.tabPage3.Controls.Add(this.tb_output);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1082, 738);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Output ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cb_Native
            // 
            this.cb_Native.AutoSize = true;
            this.cb_Native.Location = new System.Drawing.Point(229, 31);
            this.cb_Native.Name = "cb_Native";
            this.cb_Native.Size = new System.Drawing.Size(301, 21);
            this.cb_Native.TabIndex = 15;
            this.cb_Native.Text = "Use C# Native ( speed - Log: window Only )";
            this.cb_Native.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Log:";
            // 
            // tb_log
            // 
            this.tb_log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_log.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_log.Location = new System.Drawing.Point(379, 296);
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_log.Size = new System.Drawing.Size(682, 434);
            this.tb_log.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Invocation R Code:";
            // 
            // tb_suffix
            // 
            this.tb_suffix.Location = new System.Drawing.Point(9, 421);
            this.tb_suffix.Multiline = true;
            this.tb_suffix.Name = "tb_suffix";
            this.tb_suffix.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_suffix.Size = new System.Drawing.Size(349, 309);
            this.tb_suffix.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "2. Process R-Script";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkbox_filter
            // 
            this.checkbox_filter.AutoSize = true;
            this.checkbox_filter.Location = new System.Drawing.Point(548, 31);
            this.checkbox_filter.Name = "checkbox_filter";
            this.checkbox_filter.Size = new System.Drawing.Size(281, 21);
            this.checkbox_filter.TabIndex = 9;
            this.checkbox_filter.Text = "Suppress Echo of \"Library\" Code Output";
            this.checkbox_filter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "\"Library\" part of R Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Output:";
            // 
            // textBox_Script
            // 
            this.textBox_Script.Location = new System.Drawing.Point(6, 102);
            this.textBox_Script.Multiline = true;
            this.textBox_Script.Name = "textBox_Script";
            this.textBox_Script.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Script.Size = new System.Drawing.Size(352, 273);
            this.textBox_Script.TabIndex = 1;
            this.textBox_Script.Text = resources.GetString("textBox_Script.Text");
            this.textBox_Script.WordWrap = false;
            // 
            // tb_output
            // 
            this.tb_output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_output.Location = new System.Drawing.Point(379, 102);
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_output.Size = new System.Drawing.Size(682, 159);
            this.tb_output.TabIndex = 5;
            // 
            // cb_csv
            // 
            this.cb_csv.AutoSize = true;
            this.cb_csv.Location = new System.Drawing.Point(231, 59);
            this.cb_csv.Name = "cb_csv";
            this.cb_csv.Size = new System.Drawing.Size(105, 21);
            this.cb_csv.TabIndex = 16;
            this.cb_csv.Text = ".CSV Output";
            this.cb_csv.UseVisualStyleBackColor = true;
            // 
            // form_RMMContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 767);
            this.Controls.Add(this.panel_ChildBody);
            this.Name = "form_RMMContainer";
            this.Text = "form_RMMContainer";
            this.panel_ChildBody.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ChildBody;
        private System.Windows.Forms.TextBox textBox_Script;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clb_Users;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_runhistoric;
        private System.Windows.Forms.TextBox tb_testscore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_authmech;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkbox_filter;
        private System.Windows.Forms.TextBox tb_output2;
        private System.Windows.Forms.Button btn_Process3;
        private System.Windows.Forms.Button btn_Process2;
        private System.Windows.Forms.Button btn_Process1;
        private System.Windows.Forms.TextBox tb_suffix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.CheckBox cb_Native;
        private System.Windows.Forms.CheckBox cb_csv;
    }
}