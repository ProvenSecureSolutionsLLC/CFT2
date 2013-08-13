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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ATTFace));
            this.panel_ChildBody = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Cheese = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Score = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_ChildBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ChildBody
            // 
            this.panel_ChildBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ChildBody.Controls.Add(this.progressBar1);
            this.panel_ChildBody.Controls.Add(this.pictureBox1);
            this.panel_ChildBody.Controls.Add(this.btn_Cheese);
            this.panel_ChildBody.Controls.Add(this.label7);
            this.panel_ChildBody.Controls.Add(this.label1);
            this.panel_ChildBody.Controls.Add(this.tb_Score);
            this.panel_ChildBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ChildBody.Location = new System.Drawing.Point(0, 0);
            this.panel_ChildBody.Margin = new System.Windows.Forms.Padding(4);
            this.panel_ChildBody.Name = "panel_ChildBody";
            this.panel_ChildBody.Size = new System.Drawing.Size(1022, 178);
            this.panel_ChildBody.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(320, 54);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(421, 23);
            this.progressBar1.TabIndex = 52;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(140, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 135);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Cheese
            // 
            this.btn_Cheese.Location = new System.Drawing.Point(320, 20);
            this.btn_Cheese.Name = "btn_Cheese";
            this.btn_Cheese.Size = new System.Drawing.Size(126, 26);
            this.btn_Cheese.TabIndex = 50;
            this.btn_Cheese.Text = "Cheese";
            this.btn_Cheese.UseVisualStyleBackColor = true;
            this.btn_Cheese.Click += new System.EventHandler(this.btn_Cheese_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "AT&&T Face";
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // form_ATTFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 532);
            this.Controls.Add(this.panel_ChildBody);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_ATTFace";
            this.Text = "form_ATTFace";
            this.panel_ChildBody.ResumeLayout(false);
            this.panel_ChildBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ChildBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Score;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Cheese;
        private System.Windows.Forms.Timer timer1;
    }
}