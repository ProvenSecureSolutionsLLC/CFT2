namespace Bench
{
    partial class form_LowLevelBetaface
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
            this.tb_selectedfile = new System.Windows.Forms.TextBox();
            this.btn_pickfile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_request = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_response = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Go = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_factorytest = new System.Windows.Forms.Button();
            this.btn_upload = new System.Windows.Forms.Button();
            this.btn_FolderTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image File: ";
            // 
            // tb_selectedfile
            // 
            this.tb_selectedfile.Location = new System.Drawing.Point(21, 39);
            this.tb_selectedfile.Margin = new System.Windows.Forms.Padding(4);
            this.tb_selectedfile.Name = "tb_selectedfile";
            this.tb_selectedfile.Size = new System.Drawing.Size(657, 23);
            this.tb_selectedfile.TabIndex = 1;
            // 
            // btn_pickfile
            // 
            this.btn_pickfile.Location = new System.Drawing.Point(578, 70);
            this.btn_pickfile.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pickfile.Name = "btn_pickfile";
            this.btn_pickfile.Size = new System.Drawing.Size(100, 28);
            this.btn_pickfile.TabIndex = 2;
            this.btn_pickfile.Text = "Pick File";
            this.btn_pickfile.UseVisualStyleBackColor = true;
            this.btn_pickfile.Click += new System.EventHandler(this.btn_pickfile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(701, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tb_request
            // 
            this.tb_request.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_request.Location = new System.Drawing.Point(21, 239);
            this.tb_request.Margin = new System.Windows.Forms.Padding(4);
            this.tb_request.Multiline = true;
            this.tb_request.Name = "tb_request";
            this.tb_request.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_request.Size = new System.Drawing.Size(964, 168);
            this.tb_request.TabIndex = 4;
            this.tb_request.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Request: ";
            // 
            // tb_response
            // 
            this.tb_response.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_response.Location = new System.Drawing.Point(21, 440);
            this.tb_response.Multiline = true;
            this.tb_response.Name = "tb_response";
            this.tb_response.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_response.Size = new System.Drawing.Size(964, 247);
            this.tb_response.TabIndex = 6;
            this.tb_response.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 420);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Response: ";
            // 
            // btn_Go
            // 
            this.btn_Go.Location = new System.Drawing.Point(167, 122);
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(318, 28);
            this.btn_Go.TabIndex = 8;
            this.btn_Go.Text = "Recognize vs. Other Existing Faceuids in folder";
            this.btn_Go.UseVisualStyleBackColor = true;
            this.btn_Go.Click += new System.EventHandler(this.btn_Go_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "BMP|*.bmp|JPG|*.jpg";
            // 
            // btn_factorytest
            // 
            this.btn_factorytest.Location = new System.Drawing.Point(546, 122);
            this.btn_factorytest.Name = "btn_factorytest";
            this.btn_factorytest.Size = new System.Drawing.Size(132, 28);
            this.btn_factorytest.TabIndex = 9;
            this.btn_factorytest.Text = "Factory Test";
            this.btn_factorytest.UseVisualStyleBackColor = true;
            this.btn_factorytest.Click += new System.EventHandler(this.btn_factorytest_Click);
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(20, 122);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(141, 28);
            this.btn_upload.TabIndex = 10;
            this.btn_upload.Text = "Upload the image";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // btn_FolderTest
            // 
            this.btn_FolderTest.Location = new System.Drawing.Point(546, 156);
            this.btn_FolderTest.Name = "btn_FolderTest";
            this.btn_FolderTest.Size = new System.Drawing.Size(132, 27);
            this.btn_FolderTest.TabIndex = 11;
            this.btn_FolderTest.Text = "Folder Test";
            this.btn_FolderTest.UseVisualStyleBackColor = true;
            this.btn_FolderTest.Click += new System.EventHandler(this.btn_FolderTest_Click);
            // 
            // form_LowLevelBetaface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 719);
            this.Controls.Add(this.btn_FolderTest);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.btn_factorytest);
            this.Controls.Add(this.btn_Go);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_response);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_request);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_pickfile);
            this.Controls.Add(this.tb_selectedfile);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_LowLevelBetaface";
            this.Text = "Betaface";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_selectedfile;
        private System.Windows.Forms.Button btn_pickfile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_request;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_response;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Go;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_factorytest;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Button btn_FolderTest;
    }
}