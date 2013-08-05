namespace ProvenSecure_DARPA_CFT_2013
{
    partial class formCVSS
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
            this.label1 = new System.Windows.Forms.Label();
            this.combo_CATEGORY = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.combo_AccessVector = new System.Windows.Forms.ComboBox();
            this.combo_AccessComplexity = new System.Windows.Forms.ComboBox();
            this.combo_Authentication = new System.Windows.Forms.ComboBox();
            this.combo_availimpact = new System.Windows.Forms.ComboBox();
            this.combo_integimpact = new System.Windows.Forms.ComboBox();
            this.combo_confimpact = new System.Windows.Forms.ComboBox();
            this.combo_systemavailabilityrequirement = new System.Windows.Forms.ComboBox();
            this.combo_integrityrequirement = new System.Windows.Forms.ComboBox();
            this.combo_confidentialityrequirement = new System.Windows.Forms.ComboBox();
            this.combo_targetdistribution = new System.Windows.Forms.ComboBox();
            this.combo_collateraldamagepotential = new System.Windows.Forms.ComboBox();
            this.combo_reportconfidence = new System.Windows.Forms.ComboBox();
            this.combo_remediationlevel = new System.Windows.Forms.ComboBox();
            this.combo_exploitability = new System.Windows.Forms.ComboBox();
            this.tb_Output = new System.Windows.Forms.TextBox();
            this.ll_testformcalculations = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tb_Scorecardname = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // combo_CATEGORY
            // 
            this.combo_CATEGORY.FormattingEnabled = true;
            this.combo_CATEGORY.Items.AddRange(new object[] {
            "AUTHENTICATION MECHANISMS",
            "DEVICE 1",
            "DEVICE 2",
            "DEVICE 3",
            "LOCATIONS",
            "TARGETS",
            "USER ROLES"});
            this.combo_CATEGORY.Location = new System.Drawing.Point(45, 59);
            this.combo_CATEGORY.Margin = new System.Windows.Forms.Padding(4);
            this.combo_CATEGORY.Name = "combo_CATEGORY";
            this.combo_CATEGORY.Size = new System.Drawing.Size(331, 24);
            this.combo_CATEGORY.Sorted = true;
            this.combo_CATEGORY.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Scorecard Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Exploitability";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Exploit Range: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Attack Complexity: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Authentication Needed: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(448, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Collateral Damage Potential: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(416, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Generic Modifiers";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(506, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Target Distribution: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(42, 357);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Impact Metrics";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 387);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Confidentiality Impact: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(66, 414);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "Integrity Impact: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(51, 442);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 17);
            this.label15.TabIndex = 17;
            this.label15.Text = "Availability Impact: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(416, 357);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 17);
            this.label16.TabIndex = 18;
            this.label16.Text = "Impact Modifiers";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(453, 387);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(193, 17);
            this.label17.TabIndex = 19;
            this.label17.Text = "Confidentiality Requirement:  ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(491, 414);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(155, 17);
            this.label18.TabIndex = 20;
            this.label18.Text = "Integrity Requirement:  ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(425, 442);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(221, 17);
            this.label19.TabIndex = 21;
            this.label19.Text = "System Availability Requirement:  ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(43, 495);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(180, 17);
            this.label20.TabIndex = 22;
            this.label20.Text = "Temporal Score Metrics";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(86, 524);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 17);
            this.label21.TabIndex = 23;
            this.label21.Text = "Exploitability: ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(46, 551);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(133, 17);
            this.label22.TabIndex = 24;
            this.label22.Text = "Remediation Level: ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(46, 579);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(134, 17);
            this.label23.TabIndex = 25;
            this.label23.Text = "Report Confidence: ";
            // 
            // combo_AccessVector
            // 
            this.combo_AccessVector.FormattingEnabled = true;
            this.combo_AccessVector.Items.AddRange(new object[] {
            "undefined:",
            "Requires Local Access:",
            "Local Network Accessible:",
            "Network Accessible:"});
            this.combo_AccessVector.Location = new System.Drawing.Point(183, 250);
            this.combo_AccessVector.Name = "combo_AccessVector";
            this.combo_AccessVector.Size = new System.Drawing.Size(193, 24);
            this.combo_AccessVector.TabIndex = 31;
            this.combo_AccessVector.SelectedIndexChanged += new System.EventHandler(this.combo_AccessVector_SelectedIndexChanged);
            // 
            // combo_AccessComplexity
            // 
            this.combo_AccessComplexity.FormattingEnabled = true;
            this.combo_AccessComplexity.Items.AddRange(new object[] {
            "undefined:",
            "high:",
            "medium:",
            "low:"});
            this.combo_AccessComplexity.Location = new System.Drawing.Point(183, 277);
            this.combo_AccessComplexity.Name = "combo_AccessComplexity";
            this.combo_AccessComplexity.Size = new System.Drawing.Size(193, 24);
            this.combo_AccessComplexity.TabIndex = 32;
            this.combo_AccessComplexity.SelectedIndexChanged += new System.EventHandler(this.combo_AccessVector_SelectedIndexChanged);
            // 
            // combo_Authentication
            // 
            this.combo_Authentication.FormattingEnabled = true;
            this.combo_Authentication.Items.AddRange(new object[] {
            "undefined:",
            "none required",
            "requires single instance",
            "requires multiple instances"});
            this.combo_Authentication.Location = new System.Drawing.Point(183, 305);
            this.combo_Authentication.Name = "combo_Authentication";
            this.combo_Authentication.Size = new System.Drawing.Size(193, 24);
            this.combo_Authentication.TabIndex = 33;
            this.combo_Authentication.SelectedIndexChanged += new System.EventHandler(this.combo_AccessVector_SelectedIndexChanged);
            // 
            // combo_availimpact
            // 
            this.combo_availimpact.FormattingEnabled = true;
            this.combo_availimpact.Items.AddRange(new object[] {
            "none:",
            "partial:",
            "complete:"});
            this.combo_availimpact.Location = new System.Drawing.Point(183, 439);
            this.combo_availimpact.Name = "combo_availimpact";
            this.combo_availimpact.Size = new System.Drawing.Size(193, 24);
            this.combo_availimpact.TabIndex = 36;
            this.combo_availimpact.SelectedIndexChanged += new System.EventHandler(this.combo_AccessVector_SelectedIndexChanged);
            // 
            // combo_integimpact
            // 
            this.combo_integimpact.FormattingEnabled = true;
            this.combo_integimpact.Items.AddRange(new object[] {
            "none:",
            "partial:",
            "complete:"});
            this.combo_integimpact.Location = new System.Drawing.Point(183, 411);
            this.combo_integimpact.Name = "combo_integimpact";
            this.combo_integimpact.Size = new System.Drawing.Size(193, 24);
            this.combo_integimpact.TabIndex = 35;
            this.combo_integimpact.SelectedIndexChanged += new System.EventHandler(this.combo_AccessVector_SelectedIndexChanged);
            // 
            // combo_confimpact
            // 
            this.combo_confimpact.FormattingEnabled = true;
            this.combo_confimpact.Items.AddRange(new object[] {
            "none:",
            "partial:",
            "complete:"});
            this.combo_confimpact.Location = new System.Drawing.Point(183, 384);
            this.combo_confimpact.Name = "combo_confimpact";
            this.combo_confimpact.Size = new System.Drawing.Size(193, 24);
            this.combo_confimpact.TabIndex = 34;
            this.combo_confimpact.SelectedIndexChanged += new System.EventHandler(this.combo_AccessVector_SelectedIndexChanged);
            // 
            // combo_systemavailabilityrequirement
            // 
            this.combo_systemavailabilityrequirement.FormattingEnabled = true;
            this.combo_systemavailabilityrequirement.Items.AddRange(new object[] {
            "Low:",
            "Medium or not-defined:",
            "High:"});
            this.combo_systemavailabilityrequirement.Location = new System.Drawing.Point(645, 439);
            this.combo_systemavailabilityrequirement.Name = "combo_systemavailabilityrequirement";
            this.combo_systemavailabilityrequirement.Size = new System.Drawing.Size(171, 24);
            this.combo_systemavailabilityrequirement.TabIndex = 39;
            this.combo_systemavailabilityrequirement.SelectedIndexChanged += new System.EventHandler(this.combo_AccessVector_SelectedIndexChanged);
            // 
            // combo_integrityrequirement
            // 
            this.combo_integrityrequirement.FormattingEnabled = true;
            this.combo_integrityrequirement.Items.AddRange(new object[] {
            "Low:",
            "Medium or not-defined:",
            "High:"});
            this.combo_integrityrequirement.Location = new System.Drawing.Point(645, 411);
            this.combo_integrityrequirement.Name = "combo_integrityrequirement";
            this.combo_integrityrequirement.Size = new System.Drawing.Size(171, 24);
            this.combo_integrityrequirement.TabIndex = 38;
            this.combo_integrityrequirement.SelectedIndexChanged += new System.EventHandler(this.combo_AccessVector_SelectedIndexChanged);
            // 
            // combo_confidentialityrequirement
            // 
            this.combo_confidentialityrequirement.FormattingEnabled = true;
            this.combo_confidentialityrequirement.Items.AddRange(new object[] {
            "Low:",
            "Medium or not-defined:",
            "High:"});
            this.combo_confidentialityrequirement.Location = new System.Drawing.Point(645, 384);
            this.combo_confidentialityrequirement.Name = "combo_confidentialityrequirement";
            this.combo_confidentialityrequirement.Size = new System.Drawing.Size(171, 24);
            this.combo_confidentialityrequirement.TabIndex = 37;
            this.combo_confidentialityrequirement.SelectedIndexChanged += new System.EventHandler(this.combo_AccessVector_SelectedIndexChanged);
            // 
            // combo_targetdistribution
            // 
            this.combo_targetdistribution.FormattingEnabled = true;
            this.combo_targetdistribution.Items.AddRange(new object[] {
            "none:",
            "low:",
            "medium:",
            "high or not defined:"});
            this.combo_targetdistribution.Location = new System.Drawing.Point(645, 277);
            this.combo_targetdistribution.Name = "combo_targetdistribution";
            this.combo_targetdistribution.Size = new System.Drawing.Size(171, 24);
            this.combo_targetdistribution.TabIndex = 41;
            this.combo_targetdistribution.SelectedIndexChanged += new System.EventHandler(this.combo_AccessVector_SelectedIndexChanged);
            // 
            // combo_collateraldamagepotential
            // 
            this.combo_collateraldamagepotential.FormattingEnabled = true;
            this.combo_collateraldamagepotential.Items.AddRange(new object[] {
            "none or not-defined:",
            "low:",
            "low-medium:",
            "medium-high:",
            "high:"});
            this.combo_collateraldamagepotential.Location = new System.Drawing.Point(645, 250);
            this.combo_collateraldamagepotential.Name = "combo_collateraldamagepotential";
            this.combo_collateraldamagepotential.Size = new System.Drawing.Size(171, 24);
            this.combo_collateraldamagepotential.TabIndex = 40;
            this.combo_collateraldamagepotential.SelectedIndexChanged += new System.EventHandler(this.combo_AccessVector_SelectedIndexChanged);
            // 
            // combo_reportconfidence
            // 
            this.combo_reportconfidence.FormattingEnabled = true;
            this.combo_reportconfidence.Items.AddRange(new object[] {
            "unconfirmed:",
            "uncorroborated:",
            "unconfirmed or not-defined:"});
            this.combo_reportconfidence.Location = new System.Drawing.Point(183, 576);
            this.combo_reportconfidence.Name = "combo_reportconfidence";
            this.combo_reportconfidence.Size = new System.Drawing.Size(193, 24);
            this.combo_reportconfidence.TabIndex = 44;
            this.combo_reportconfidence.SelectedIndexChanged += new System.EventHandler(this.combo_AccessVector_SelectedIndexChanged);
            // 
            // combo_remediationlevel
            // 
            this.combo_remediationlevel.FormattingEnabled = true;
            this.combo_remediationlevel.Items.AddRange(new object[] {
            "official-fix:",
            "temporary-fix:",
            "workaround:",
            "unavailable or not-defined:"});
            this.combo_remediationlevel.Location = new System.Drawing.Point(183, 548);
            this.combo_remediationlevel.Name = "combo_remediationlevel";
            this.combo_remediationlevel.Size = new System.Drawing.Size(193, 24);
            this.combo_remediationlevel.TabIndex = 43;
            this.combo_remediationlevel.SelectedIndexChanged += new System.EventHandler(this.combo_AccessVector_SelectedIndexChanged);
            // 
            // combo_exploitability
            // 
            this.combo_exploitability.FormattingEnabled = true;
            this.combo_exploitability.Items.AddRange(new object[] {
            "unproven:",
            "proof-of-concept:",
            "functional:",
            "high or not-defined:"});
            this.combo_exploitability.Location = new System.Drawing.Point(183, 521);
            this.combo_exploitability.Name = "combo_exploitability";
            this.combo_exploitability.Size = new System.Drawing.Size(193, 24);
            this.combo_exploitability.TabIndex = 42;
            this.combo_exploitability.SelectedIndexChanged += new System.EventHandler(this.combo_AccessVector_SelectedIndexChanged);
            // 
            // tb_Output
            // 
            this.tb_Output.BackColor = System.Drawing.SystemColors.Info;
            this.tb_Output.Location = new System.Drawing.Point(419, 485);
            this.tb_Output.Multiline = true;
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.ReadOnly = true;
            this.tb_Output.Size = new System.Drawing.Size(397, 115);
            this.tb_Output.TabIndex = 45;
            // 
            // ll_testformcalculations
            // 
            this.ll_testformcalculations.AutoSize = true;
            this.ll_testformcalculations.Location = new System.Drawing.Point(683, 24);
            this.ll_testformcalculations.Name = "ll_testformcalculations";
            this.ll_testformcalculations.Size = new System.Drawing.Size(146, 17);
            this.ll_testformcalculations.TabIndex = 46;
            this.ll_testformcalculations.TabStop = true;
            this.ll_testformcalculations.Text = "Test form calculations";
            this.ll_testformcalculations.Visible = false;
            this.ll_testformcalculations.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_testformcalculations_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tb_Scorecardname
            // 
            this.tb_Scorecardname.Location = new System.Drawing.Point(404, 60);
            this.tb_Scorecardname.Name = "tb_Scorecardname";
            this.tb_Scorecardname.Size = new System.Drawing.Size(412, 23);
            this.tb_Scorecardname.TabIndex = 51;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 53;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tb_Description
            // 
            this.tb_Description.Location = new System.Drawing.Point(44, 106);
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(772, 84);
            this.tb_Description.TabIndex = 54;
            // 
            // formCVSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 632);
            this.Controls.Add(this.tb_Description);
            this.Controls.Add(this.tb_Scorecardname);
            this.Controls.Add(this.ll_testformcalculations);
            this.Controls.Add(this.tb_Output);
            this.Controls.Add(this.combo_reportconfidence);
            this.Controls.Add(this.combo_remediationlevel);
            this.Controls.Add(this.combo_exploitability);
            this.Controls.Add(this.combo_targetdistribution);
            this.Controls.Add(this.combo_collateraldamagepotential);
            this.Controls.Add(this.combo_systemavailabilityrequirement);
            this.Controls.Add(this.combo_integrityrequirement);
            this.Controls.Add(this.combo_confidentialityrequirement);
            this.Controls.Add(this.combo_availimpact);
            this.Controls.Add(this.combo_integimpact);
            this.Controls.Add(this.combo_confimpact);
            this.Controls.Add(this.combo_Authentication);
            this.Controls.Add(this.combo_AccessComplexity);
            this.Controls.Add(this.combo_AccessVector);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combo_CATEGORY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCVSS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base CVSS";
            this.Shown += new System.EventHandler(this.formCVSS_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_CATEGORY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox combo_AccessVector;
        private System.Windows.Forms.ComboBox combo_AccessComplexity;
        private System.Windows.Forms.ComboBox combo_Authentication;
        private System.Windows.Forms.ComboBox combo_availimpact;
        private System.Windows.Forms.ComboBox combo_integimpact;
        private System.Windows.Forms.ComboBox combo_confimpact;
        private System.Windows.Forms.ComboBox combo_systemavailabilityrequirement;
        private System.Windows.Forms.ComboBox combo_integrityrequirement;
        private System.Windows.Forms.ComboBox combo_confidentialityrequirement;
        private System.Windows.Forms.ComboBox combo_targetdistribution;
        private System.Windows.Forms.ComboBox combo_collateraldamagepotential;
        private System.Windows.Forms.ComboBox combo_reportconfidence;
        private System.Windows.Forms.ComboBox combo_remediationlevel;
        private System.Windows.Forms.ComboBox combo_exploitability;
        private System.Windows.Forms.TextBox tb_Output;
        private System.Windows.Forms.LinkLabel ll_testformcalculations;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tb_Scorecardname;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox tb_Description;
    }
}