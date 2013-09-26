namespace Bench
{
    partial class form_SystemUser
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.combo_systemuser = new System.Windows.Forms.ComboBox();
            this.panel_ChildBody.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ChildBody
            // 
            this.panel_ChildBody.Controls.Add(this.linkLabel1);
            this.panel_ChildBody.Controls.Add(this.groupBox2);
            this.panel_ChildBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ChildBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_ChildBody.Location = new System.Drawing.Point(0, 0);
            this.panel_ChildBody.Name = "panel_ChildBody";
            this.panel_ChildBody.Size = new System.Drawing.Size(908, 309);
            this.panel_ChildBody.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(236, 157);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(238, 17);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Or, click here to Register a new user";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.combo_systemuser);
            this.groupBox2.Location = new System.Drawing.Point(239, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 111);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SELECT the current user";
            // 
            // combo_systemuser
            // 
            this.combo_systemuser.FormattingEnabled = true;
            this.combo_systemuser.Location = new System.Drawing.Point(23, 50);
            this.combo_systemuser.Name = "combo_systemuser";
            this.combo_systemuser.Size = new System.Drawing.Size(278, 24);
            this.combo_systemuser.TabIndex = 0;
            this.combo_systemuser.SelectedIndexChanged += new System.EventHandler(this.combo_systemuser_SelectedIndexChanged);
            // 
            // form_SystemUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 309);
            this.Controls.Add(this.panel_ChildBody);
            this.Name = "form_SystemUser";
            this.Text = "form_SystemUser";
            this.panel_ChildBody.ResumeLayout(false);
            this.panel_ChildBody.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ChildBody;
        private System.Windows.Forms.ComboBox combo_systemuser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}