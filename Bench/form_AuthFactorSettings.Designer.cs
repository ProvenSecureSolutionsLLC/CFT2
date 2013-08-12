namespace Bench
{
    partial class form_AuthFactorSettings
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
            this.combo_AuthenticationFactor = new System.Windows.Forms.ComboBox();
            this.tb_Settings = new System.Windows.Forms.TextBox();
            this.panel_ChildBody = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_header = new System.Windows.Forms.Panel();
            this.label_formtype = new System.Windows.Forms.Label();
            this.panel_ChildBody.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // combo_AuthenticationFactor
            // 
            this.combo_AuthenticationFactor.Enabled = false;
            this.combo_AuthenticationFactor.Items.AddRange(new object[] {
            "Password",
            "Knowledge",
            "AT&T Voice",
            "AT&T Face",
            "Betaface",
            "SMS Token"});
            this.combo_AuthenticationFactor.Location = new System.Drawing.Point(298, 16);
            this.combo_AuthenticationFactor.Margin = new System.Windows.Forms.Padding(4);
            this.combo_AuthenticationFactor.Name = "combo_AuthenticationFactor";
            this.combo_AuthenticationFactor.Size = new System.Drawing.Size(373, 24);
            this.combo_AuthenticationFactor.TabIndex = 1;
            // 
            // tb_Settings
            // 
            this.tb_Settings.Location = new System.Drawing.Point(39, 33);
            this.tb_Settings.Multiline = true;
            this.tb_Settings.Name = "tb_Settings";
            this.tb_Settings.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_Settings.Size = new System.Drawing.Size(632, 292);
            this.tb_Settings.TabIndex = 0;
            this.tb_Settings.WordWrap = false;
            // 
            // panel_ChildBody
            // 
            this.panel_ChildBody.Controls.Add(this.panel2);
            this.panel_ChildBody.Controls.Add(this.panel1);
            this.panel_ChildBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ChildBody.Location = new System.Drawing.Point(0, 0);
            this.panel_ChildBody.Name = "panel_ChildBody";
            this.panel_ChildBody.Size = new System.Drawing.Size(713, 407);
            this.panel_ChildBody.TabIndex = 5;
            this.panel_ChildBody.Leave += new System.EventHandler(this.panel_ChildBody_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tb_Settings);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 340);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Settings";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_header);
            this.panel1.Controls.Add(this.combo_AuthenticationFactor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 67);
            this.panel1.TabIndex = 5;
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.Black;
            this.panel_header.Controls.Add(this.label_formtype);
            this.panel_header.Location = new System.Drawing.Point(39, 6);
            this.panel_header.Margin = new System.Windows.Forms.Padding(5);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(159, 34);
            this.panel_header.TabIndex = 16;
            // 
            // label_formtype
            // 
            this.label_formtype.AutoSize = true;
            this.label_formtype.ForeColor = System.Drawing.Color.White;
            this.label_formtype.Location = new System.Drawing.Point(4, 4);
            this.label_formtype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_formtype.Name = "label_formtype";
            this.label_formtype.Size = new System.Drawing.Size(83, 17);
            this.label_formtype.TabIndex = 1;
            this.label_formtype.Text = "AT&&T Voice";
            // 
            // form_AuthFactorSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 407);
            this.Controls.Add(this.panel_ChildBody);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_AuthFactorSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication Factor Settings";
            this.panel_ChildBody.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_AuthenticationFactor;
        private System.Windows.Forms.TextBox tb_Settings;
        private System.Windows.Forms.Panel panel_ChildBody;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label label_formtype;
    }
}