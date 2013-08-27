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
            this.checkbox_filter = new System.Windows.Forms.CheckBox();
            this.listbox_output = new System.Windows.Forms.ListBox();
            this.textBox_Script = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_ChildBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ChildBody
            // 
            this.panel_ChildBody.AutoScroll = true;
            this.panel_ChildBody.Controls.Add(this.checkbox_filter);
            this.panel_ChildBody.Controls.Add(this.listbox_output);
            this.panel_ChildBody.Controls.Add(this.textBox_Script);
            this.panel_ChildBody.Controls.Add(this.button1);
            this.panel_ChildBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ChildBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_ChildBody.Location = new System.Drawing.Point(0, 0);
            this.panel_ChildBody.Name = "panel_ChildBody";
            this.panel_ChildBody.Size = new System.Drawing.Size(573, 516);
            this.panel_ChildBody.TabIndex = 0;
            // 
            // checkbox_filter
            // 
            this.checkbox_filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkbox_filter.AutoSize = true;
            this.checkbox_filter.Location = new System.Drawing.Point(215, 221);
            this.checkbox_filter.Name = "checkbox_filter";
            this.checkbox_filter.Size = new System.Drawing.Size(191, 21);
            this.checkbox_filter.TabIndex = 3;
            this.checkbox_filter.Text = "Filter out excess feedback";
            this.checkbox_filter.UseVisualStyleBackColor = true;
            // 
            // listbox_output
            // 
            this.listbox_output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listbox_output.FormattingEnabled = true;
            this.listbox_output.ItemHeight = 16;
            this.listbox_output.Location = new System.Drawing.Point(34, 258);
            this.listbox_output.Name = "listbox_output";
            this.listbox_output.ScrollAlwaysVisible = true;
            this.listbox_output.Size = new System.Drawing.Size(507, 228);
            this.listbox_output.TabIndex = 2;
            // 
            // textBox_Script
            // 
            this.textBox_Script.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Script.Location = new System.Drawing.Point(34, 12);
            this.textBox_Script.Multiline = true;
            this.textBox_Script.Name = "textBox_Script";
            this.textBox_Script.Size = new System.Drawing.Size(507, 179);
            this.textBox_Script.TabIndex = 1;
            this.textBox_Script.Text = resources.GetString("textBox_Script.Text");
            this.textBox_Script.WordWrap = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(33, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Process R-Script";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_BatchGo_Click);
            // 
            // form_RMMContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 516);
            this.Controls.Add(this.panel_ChildBody);
            this.Name = "form_RMMContainer";
            this.Text = "form_RMMContainer";
            this.panel_ChildBody.ResumeLayout(false);
            this.panel_ChildBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ChildBody;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listbox_output;
        private System.Windows.Forms.TextBox textBox_Script;
        private System.Windows.Forms.CheckBox checkbox_filter;
    }
}