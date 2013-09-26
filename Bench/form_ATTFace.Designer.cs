namespace Bench
{
    partial class form_ATTFace
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
            this.btn_stopcam = new System.Windows.Forms.Button();
            this.btn_startcam = new System.Windows.Forms.Button();
            this.tb_betaface_Score = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Cheese = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Score = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel_ChildBody.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ChildBody
            // 
            this.panel_ChildBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ChildBody.Controls.Add(this.button1);
            this.panel_ChildBody.Controls.Add(this.btn_stopcam);
            this.panel_ChildBody.Controls.Add(this.btn_startcam);
            this.panel_ChildBody.Controls.Add(this.tb_betaface_Score);
            this.panel_ChildBody.Controls.Add(this.label2);
            this.panel_ChildBody.Controls.Add(this.panel1);
            this.panel_ChildBody.Controls.Add(this.btn_Cheese);
            this.panel_ChildBody.Controls.Add(this.label7);
            this.panel_ChildBody.Controls.Add(this.label1);
            this.panel_ChildBody.Controls.Add(this.tb_Score);
            this.panel_ChildBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ChildBody.Location = new System.Drawing.Point(0, 0);
            this.panel_ChildBody.Margin = new System.Windows.Forms.Padding(4);
            this.panel_ChildBody.Name = "panel_ChildBody";
            this.panel_ChildBody.Size = new System.Drawing.Size(1022, 286);
            this.panel_ChildBody.TabIndex = 0;
            // 
            // btn_stopcam
            // 
            this.btn_stopcam.Location = new System.Drawing.Point(601, 180);
            this.btn_stopcam.Name = "btn_stopcam";
            this.btn_stopcam.Size = new System.Drawing.Size(156, 29);
            this.btn_stopcam.TabIndex = 59;
            this.btn_stopcam.Text = "Pause the Camera";
            this.btn_stopcam.UseVisualStyleBackColor = true;
            this.btn_stopcam.Click += new System.EventHandler(this.btn_stopcam_Click);
            // 
            // btn_startcam
            // 
            this.btn_startcam.Location = new System.Drawing.Point(601, 142);
            this.btn_startcam.Name = "btn_startcam";
            this.btn_startcam.Size = new System.Drawing.Size(156, 29);
            this.btn_startcam.TabIndex = 58;
            this.btn_startcam.Text = "Re-Start the Camera";
            this.btn_startcam.UseVisualStyleBackColor = true;
            this.btn_startcam.Click += new System.EventHandler(this.btn_startcam_Click);
            // 
            // tb_betaface_Score
            // 
            this.tb_betaface_Score.Location = new System.Drawing.Point(901, 16);
            this.tb_betaface_Score.Margin = new System.Windows.Forms.Padding(4);
            this.tb_betaface_Score.Name = "tb_betaface_Score";
            this.tb_betaface_Score.Size = new System.Drawing.Size(81, 23);
            this.tb_betaface_Score.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(849, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "AT&&T";
            this.label2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(112, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 272);
            this.panel1.TabIndex = 53;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 262);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Cheese
            // 
            this.btn_Cheese.Location = new System.Drawing.Point(601, 245);
            this.btn_Cheese.Name = "btn_Cheese";
            this.btn_Cheese.Size = new System.Drawing.Size(156, 29);
            this.btn_Cheese.TabIndex = 50;
            this.btn_Cheese.Text = "Take Picture ";
            this.btn_Cheese.UseVisualStyleBackColor = true;
            this.btn_Cheese.Click += new System.EventHandler(this.btn_Cheese_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Face ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(848, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Score";
            // 
            // tb_Score
            // 
            this.tb_Score.Location = new System.Drawing.Point(901, 53);
            this.tb_Score.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Score.Name = "tb_Score";
            this.tb_Score.Size = new System.Drawing.Size(81, 23);
            this.tb_Score.TabIndex = 37;
            this.tb_Score.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 29);
            this.button1.TabIndex = 60;
            this.button1.Text = "Choose && Start Cam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_ATTFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 532);
            this.Controls.Add(this.panel_ChildBody);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_ATTFace";
            this.Text = "form_ATTFace";
            this.Load += new System.EventHandler(this.form_ATTFace_Load);
            this.panel_ChildBody.ResumeLayout(false);
            this.panel_ChildBody.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ChildBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Score;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Cheese;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_betaface_Score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_stopcam;
        private System.Windows.Forms.Button btn_startcam;
        private System.Windows.Forms.Button button1;
    }
}