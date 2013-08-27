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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_NewUser = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.combo_systemuser = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel_ChildBody.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ChildBody
            // 
            this.panel_ChildBody.Controls.Add(this.groupBox2);
            this.panel_ChildBody.Controls.Add(this.groupBox1);
            this.panel_ChildBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ChildBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_ChildBody.Location = new System.Drawing.Point(0, 0);
            this.panel_ChildBody.Name = "panel_ChildBody";
            this.panel_ChildBody.Size = new System.Drawing.Size(718, 309);
            this.panel_ChildBody.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_NewUser);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(239, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 139);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Add a new System User ";
            // 
            // tb_NewUser
            // 
            this.tb_NewUser.Location = new System.Drawing.Point(23, 41);
            this.tb_NewUser.Name = "tb_NewUser";
            this.tb_NewUser.Size = new System.Drawing.Size(278, 23);
            this.tb_NewUser.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // combo_systemuser
            // 
            this.combo_systemuser.FormattingEnabled = true;
            this.combo_systemuser.Location = new System.Drawing.Point(23, 31);
            this.combo_systemuser.Name = "combo_systemuser";
            this.combo_systemuser.Size = new System.Drawing.Size(278, 24);
            this.combo_systemuser.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.combo_systemuser);
            this.groupBox2.Location = new System.Drawing.Point(239, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 75);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Select the System User:  ";
            // 
            // form_SystemUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 309);
            this.Controls.Add(this.panel_ChildBody);
            this.Name = "form_SystemUser";
            this.Text = "form_SystemUser";
            this.panel_ChildBody.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ChildBody;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox combo_systemuser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_NewUser;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}