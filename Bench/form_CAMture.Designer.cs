namespace Bench
{
    partial class formCAMture
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl_Child = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Capture_Image = new System.Windows.Forms.Button();
            this.cb_vert = new System.Windows.Forms.CheckBox();
            this.cb_horiz = new System.Windows.Forms.CheckBox();
            this.btn_ChooseCamera = new System.Windows.Forms.Button();
            this.btn_CamSettings = new System.Windows.Forms.Button();
            this.panel_camera_image = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel_ChildBody = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_cameraSetup = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl_Child.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_camera_image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel_ChildBody.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_cameraSetup.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 524);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(640, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl_Child
            // 
            this.tabControl_Child.Controls.Add(this.tabPage1);
            this.tabControl_Child.Controls.Add(this.tabPage2);
            this.tabControl_Child.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Child.ItemSize = new System.Drawing.Size(58, 29);
            this.tabControl_Child.Location = new System.Drawing.Point(39, 57);
            this.tabControl_Child.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl_Child.Name = "tabControl_Child";
            this.tabControl_Child.SelectedIndex = 0;
            this.tabControl_Child.Size = new System.Drawing.Size(601, 467);
            this.tabControl_Child.TabIndex = 4;
            this.tabControl_Child.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(593, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Setup Camera / Acquire New Images ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.btn_Capture_Image);
            this.panel3.Controls.Add(this.cb_vert);
            this.panel3.Controls.Add(this.cb_horiz);
            this.panel3.Controls.Add(this.btn_ChooseCamera);
            this.panel3.Controls.Add(this.btn_CamSettings);
            this.panel3.Controls.Add(this.panel_camera_image);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(585, 422);
            this.panel3.TabIndex = 1;
            this.panel3.Leave += new System.EventHandler(this.panel3_Leave);
            // 
            // btn_Capture_Image
            // 
            this.btn_Capture_Image.Location = new System.Drawing.Point(458, 16);
            this.btn_Capture_Image.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Capture_Image.Name = "btn_Capture_Image";
            this.btn_Capture_Image.Size = new System.Drawing.Size(147, 28);
            this.btn_Capture_Image.TabIndex = 7;
            this.btn_Capture_Image.Text = "Capture Image";
            this.btn_Capture_Image.UseVisualStyleBackColor = true;
            this.btn_Capture_Image.Click += new System.EventHandler(this.btn_Capture_Image_Click);
            // 
            // cb_vert
            // 
            this.cb_vert.AutoSize = true;
            this.cb_vert.Location = new System.Drawing.Point(379, 8);
            this.cb_vert.Margin = new System.Windows.Forms.Padding(4);
            this.cb_vert.Name = "cb_vert";
            this.cb_vert.Size = new System.Drawing.Size(53, 21);
            this.cb_vert.TabIndex = 6;
            this.cb_vert.Text = "Vert";
            this.cb_vert.UseVisualStyleBackColor = true;
            // 
            // cb_horiz
            // 
            this.cb_horiz.AutoSize = true;
            this.cb_horiz.Location = new System.Drawing.Point(379, 30);
            this.cb_horiz.Margin = new System.Windows.Forms.Padding(4);
            this.cb_horiz.Name = "cb_horiz";
            this.cb_horiz.Size = new System.Drawing.Size(60, 21);
            this.cb_horiz.TabIndex = 5;
            this.cb_horiz.Text = "Horiz";
            this.cb_horiz.UseVisualStyleBackColor = true;
            // 
            // btn_ChooseCamera
            // 
            this.btn_ChooseCamera.Location = new System.Drawing.Point(10, 16);
            this.btn_ChooseCamera.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ChooseCamera.Name = "btn_ChooseCamera";
            this.btn_ChooseCamera.Size = new System.Drawing.Size(181, 28);
            this.btn_ChooseCamera.TabIndex = 4;
            this.btn_ChooseCamera.Text = "Choose Camera";
            this.btn_ChooseCamera.UseVisualStyleBackColor = true;
            this.btn_ChooseCamera.Click += new System.EventHandler(this.btn_ChooseCamera_Click);
            // 
            // btn_CamSettings
            // 
            this.btn_CamSettings.Location = new System.Drawing.Point(213, 16);
            this.btn_CamSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CamSettings.Name = "btn_CamSettings";
            this.btn_CamSettings.Size = new System.Drawing.Size(148, 28);
            this.btn_CamSettings.TabIndex = 3;
            this.btn_CamSettings.Text = "Fine Tuning";
            this.btn_CamSettings.UseVisualStyleBackColor = true;
            this.btn_CamSettings.Click += new System.EventHandler(this.btn_CamSettings_Click);
            // 
            // panel_camera_image
            // 
            this.panel_camera_image.AutoSize = true;
            this.panel_camera_image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_camera_image.Controls.Add(this.pictureBox1);
            this.panel_camera_image.Location = new System.Drawing.Point(13, 59);
            this.panel_camera_image.Margin = new System.Windows.Forms.Padding(4);
            this.panel_camera_image.Name = "panel_camera_image";
            this.panel_camera_image.Size = new System.Drawing.Size(592, 394);
            this.panel_camera_image.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(588, 390);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(593, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " Image Library ";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(4, 4);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(585, 398);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(120, 116);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel_ChildBody
            // 
            this.panel_ChildBody.Controls.Add(this.tabControl_Child);
            this.panel_ChildBody.Controls.Add(this.panel1);
            this.panel_ChildBody.Controls.Add(this.panel2);
            this.panel_ChildBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ChildBody.Location = new System.Drawing.Point(0, 0);
            this.panel_ChildBody.Name = "panel_ChildBody";
            this.panel_ChildBody.Size = new System.Drawing.Size(640, 524);
            this.panel_ChildBody.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_cameraSetup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(39, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 57);
            this.panel1.TabIndex = 5;
            // 
            // panel_cameraSetup
            // 
            this.panel_cameraSetup.BackColor = System.Drawing.Color.Black;
            this.panel_cameraSetup.Controls.Add(this.label1);
            this.panel_cameraSetup.Location = new System.Drawing.Point(0, 7);
            this.panel_cameraSetup.Margin = new System.Windows.Forms.Padding(5);
            this.panel_cameraSetup.Name = "panel_cameraSetup";
            this.panel_cameraSetup.Size = new System.Drawing.Size(118, 34);
            this.panel_cameraSetup.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Camera";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(39, 524);
            this.panel2.TabIndex = 6;
            // 
            // formCAMture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 546);
            this.Controls.Add(this.panel_ChildBody);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formCAMture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Bench - CAM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_CAMture_FormClosed);
            this.tabControl_Child.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_camera_image.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel_ChildBody.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel_cameraSetup.ResumeLayout(false);
            this.panel_cameraSetup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl_Child;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_ChooseCamera;
        private System.Windows.Forms.Button btn_CamSettings;
        private System.Windows.Forms.Panel panel_camera_image;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cb_vert;
        private System.Windows.Forms.CheckBox cb_horiz;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btn_Capture_Image;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel_ChildBody;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Panel panel_cameraSetup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}

