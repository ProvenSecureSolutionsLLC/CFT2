namespace Bench
{
    partial class formMain
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelHeaderAnalyze = new System.Windows.Forms.Panel();
            this.ll_Analyze = new System.Windows.Forms.LinkLabel();
            this.panelHeaderTransform = new System.Windows.Forms.Panel();
            this.ll_Transform = new System.Windows.Forms.LinkLabel();
            this.panelHeaderReview = new System.Windows.Forms.Panel();
            this.ll_Review = new System.Windows.Forms.LinkLabel();
            this.panelHeaderAcquire = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panelHeaderSettings = new System.Windows.Forms.Panel();
            this.ll_Settings = new System.Windows.Forms.LinkLabel();
            this.panelHeaderAbout = new System.Windows.Forms.Panel();
            this.ll_About = new System.Windows.Forms.LinkLabel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelHeaderAnalyze.SuspendLayout();
            this.panelHeaderTransform.SuspendLayout();
            this.panelHeaderReview.SuspendLayout();
            this.panelHeaderAcquire.SuspendLayout();
            this.panelHeaderSettings.SuspendLayout();
            this.panelHeaderAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.panelHeaderAnalyze);
            this.panelHeader.Controls.Add(this.panelHeaderTransform);
            this.panelHeader.Controls.Add(this.panelHeaderReview);
            this.panelHeader.Controls.Add(this.panelHeaderAcquire);
            this.panelHeader.Controls.Add(this.panelHeaderSettings);
            this.panelHeader.Controls.Add(this.panelHeaderAbout);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1091, 118);
            this.panelHeader.TabIndex = 3;
            // 
            // panelHeaderAnalyze
            // 
            this.panelHeaderAnalyze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.panelHeaderAnalyze.Controls.Add(this.ll_Analyze);
            this.panelHeaderAnalyze.Location = new System.Drawing.Point(701, 24);
            this.panelHeaderAnalyze.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeaderAnalyze.Name = "panelHeaderAnalyze";
            this.panelHeaderAnalyze.Size = new System.Drawing.Size(89, 68);
            this.panelHeaderAnalyze.TabIndex = 6;
            this.panelHeaderAnalyze.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelHeaderAbout_MouseClick);
            this.panelHeaderAnalyze.MouseLeave += new System.EventHandler(this.panelHeaderAbout_MouseLeave);
            this.panelHeaderAnalyze.MouseHover += new System.EventHandler(this.panelHeaderAbout_MouseHover);
            // 
            // ll_Analyze
            // 
            this.ll_Analyze.AutoSize = true;
            this.ll_Analyze.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_Analyze.LinkColor = System.Drawing.Color.White;
            this.ll_Analyze.Location = new System.Drawing.Point(3, 3);
            this.ll_Analyze.Name = "ll_Analyze";
            this.ll_Analyze.Size = new System.Drawing.Size(58, 17);
            this.ll_Analyze.TabIndex = 5;
            this.ll_Analyze.TabStop = true;
            this.ll_Analyze.Text = "Analyze";
            this.ll_Analyze.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ll_About_MouseClick);
            this.ll_Analyze.MouseHover += new System.EventHandler(this.ll_About_MouseHover);
            // 
            // panelHeaderTransform
            // 
            this.panelHeaderTransform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.panelHeaderTransform.Controls.Add(this.ll_Transform);
            this.panelHeaderTransform.Location = new System.Drawing.Point(604, 24);
            this.panelHeaderTransform.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeaderTransform.Name = "panelHeaderTransform";
            this.panelHeaderTransform.Size = new System.Drawing.Size(89, 68);
            this.panelHeaderTransform.TabIndex = 5;
            this.panelHeaderTransform.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelHeaderAbout_MouseClick);
            this.panelHeaderTransform.MouseLeave += new System.EventHandler(this.panelHeaderAbout_MouseLeave);
            this.panelHeaderTransform.MouseHover += new System.EventHandler(this.panelHeaderAbout_MouseHover);
            // 
            // ll_Transform
            // 
            this.ll_Transform.AutoSize = true;
            this.ll_Transform.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_Transform.LinkColor = System.Drawing.Color.White;
            this.ll_Transform.Location = new System.Drawing.Point(3, 3);
            this.ll_Transform.Name = "ll_Transform";
            this.ll_Transform.Size = new System.Drawing.Size(69, 17);
            this.ll_Transform.TabIndex = 4;
            this.ll_Transform.TabStop = true;
            this.ll_Transform.Text = "TestHook";
            this.ll_Transform.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ll_About_MouseClick);
            this.ll_Transform.MouseHover += new System.EventHandler(this.ll_About_MouseHover);
            // 
            // panelHeaderReview
            // 
            this.panelHeaderReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.panelHeaderReview.Controls.Add(this.ll_Review);
            this.panelHeaderReview.Location = new System.Drawing.Point(410, 24);
            this.panelHeaderReview.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeaderReview.Name = "panelHeaderReview";
            this.panelHeaderReview.Size = new System.Drawing.Size(89, 68);
            this.panelHeaderReview.TabIndex = 4;
            this.panelHeaderReview.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeaderReview_Paint);
            this.panelHeaderReview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelHeaderAbout_MouseClick);
            this.panelHeaderReview.MouseLeave += new System.EventHandler(this.panelHeaderAbout_MouseLeave);
            this.panelHeaderReview.MouseHover += new System.EventHandler(this.panelHeaderAbout_MouseHover);
            // 
            // ll_Review
            // 
            this.ll_Review.AutoSize = true;
            this.ll_Review.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_Review.LinkColor = System.Drawing.Color.White;
            this.ll_Review.Location = new System.Drawing.Point(3, 3);
            this.ll_Review.Name = "ll_Review";
            this.ll_Review.Size = new System.Drawing.Size(38, 17);
            this.ll_Review.TabIndex = 3;
            this.ll_Review.TabStop = true;
            this.ll_Review.Text = "User";
            this.ll_Review.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ll_About_MouseClick);
            this.ll_Review.MouseHover += new System.EventHandler(this.ll_About_MouseHover);
            // 
            // panelHeaderAcquire
            // 
            this.panelHeaderAcquire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.panelHeaderAcquire.Controls.Add(this.linkLabel1);
            this.panelHeaderAcquire.Location = new System.Drawing.Point(507, 24);
            this.panelHeaderAcquire.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeaderAcquire.Name = "panelHeaderAcquire";
            this.panelHeaderAcquire.Size = new System.Drawing.Size(89, 68);
            this.panelHeaderAcquire.TabIndex = 3;
            this.panelHeaderAcquire.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelHeaderAbout_MouseClick);
            this.panelHeaderAcquire.MouseLeave += new System.EventHandler(this.panelHeaderAbout_MouseLeave);
            this.panelHeaderAcquire.MouseHover += new System.EventHandler(this.panelHeaderAbout_MouseHover);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(3, 3);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 17);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Acquire ";
            this.linkLabel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ll_About_MouseClick);
            this.linkLabel1.MouseHover += new System.EventHandler(this.ll_About_MouseHover);
            // 
            // panelHeaderSettings
            // 
            this.panelHeaderSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.panelHeaderSettings.Controls.Add(this.ll_Settings);
            this.panelHeaderSettings.Location = new System.Drawing.Point(313, 24);
            this.panelHeaderSettings.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeaderSettings.Name = "panelHeaderSettings";
            this.panelHeaderSettings.Size = new System.Drawing.Size(89, 68);
            this.panelHeaderSettings.TabIndex = 2;
            this.panelHeaderSettings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelHeaderAbout_MouseClick);
            this.panelHeaderSettings.MouseLeave += new System.EventHandler(this.panelHeaderAbout_MouseLeave);
            this.panelHeaderSettings.MouseHover += new System.EventHandler(this.panelHeaderAbout_MouseHover);
            // 
            // ll_Settings
            // 
            this.ll_Settings.AutoSize = true;
            this.ll_Settings.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_Settings.LinkColor = System.Drawing.Color.White;
            this.ll_Settings.Location = new System.Drawing.Point(3, 3);
            this.ll_Settings.Name = "ll_Settings";
            this.ll_Settings.Size = new System.Drawing.Size(59, 17);
            this.ll_Settings.TabIndex = 1;
            this.ll_Settings.TabStop = true;
            this.ll_Settings.Text = "Settings";
            this.ll_Settings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ll_About_MouseClick);
            this.ll_Settings.MouseHover += new System.EventHandler(this.ll_About_MouseHover);
            // 
            // panelHeaderAbout
            // 
            this.panelHeaderAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.panelHeaderAbout.Controls.Add(this.ll_About);
            this.panelHeaderAbout.Location = new System.Drawing.Point(216, 24);
            this.panelHeaderAbout.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeaderAbout.Name = "panelHeaderAbout";
            this.panelHeaderAbout.Size = new System.Drawing.Size(89, 68);
            this.panelHeaderAbout.TabIndex = 1;
            this.panelHeaderAbout.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelHeaderAbout_MouseClick);
            this.panelHeaderAbout.MouseLeave += new System.EventHandler(this.panelHeaderAbout_MouseLeave);
            this.panelHeaderAbout.MouseHover += new System.EventHandler(this.panelHeaderAbout_MouseHover);
            // 
            // ll_About
            // 
            this.ll_About.AutoSize = true;
            this.ll_About.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_About.LinkColor = System.Drawing.Color.White;
            this.ll_About.Location = new System.Drawing.Point(3, 3);
            this.ll_About.Name = "ll_About";
            this.ll_About.Size = new System.Drawing.Size(45, 17);
            this.ll_About.TabIndex = 0;
            this.ll_About.TabStop = true;
            this.ll_About.Text = "About";
            this.ll_About.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ll_About_MouseClick);
            this.ll_About.MouseHover += new System.EventHandler(this.ll_About_MouseHover);
            // 
            // panelBody
            // 
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 118);
            this.panelBody.Margin = new System.Windows.Forms.Padding(4);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1091, 496);
            this.panelBody.TabIndex = 4;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 614);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProvenSecure Solutions, LLC.  - Test Bench";
            this.panelHeader.ResumeLayout(false);
            this.panelHeaderAnalyze.ResumeLayout(false);
            this.panelHeaderAnalyze.PerformLayout();
            this.panelHeaderTransform.ResumeLayout(false);
            this.panelHeaderTransform.PerformLayout();
            this.panelHeaderReview.ResumeLayout(false);
            this.panelHeaderReview.PerformLayout();
            this.panelHeaderAcquire.ResumeLayout(false);
            this.panelHeaderAcquire.PerformLayout();
            this.panelHeaderSettings.ResumeLayout(false);
            this.panelHeaderSettings.PerformLayout();
            this.panelHeaderAbout.ResumeLayout(false);
            this.panelHeaderAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel panelHeader;
        internal System.Windows.Forms.Panel panelHeaderAnalyze;
        internal System.Windows.Forms.Panel panelHeaderTransform;
        internal System.Windows.Forms.Panel panelHeaderReview;
        internal System.Windows.Forms.Panel panelHeaderAcquire;
        internal System.Windows.Forms.Panel panelHeaderSettings;
        internal System.Windows.Forms.Panel panelHeaderAbout;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.LinkLabel ll_About;
        private System.Windows.Forms.LinkLabel ll_Review;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel ll_Settings;
        private System.Windows.Forms.LinkLabel ll_Analyze;
        private System.Windows.Forms.LinkLabel ll_Transform;
    }
}

