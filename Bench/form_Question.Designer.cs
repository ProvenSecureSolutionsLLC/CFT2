namespace Bench
{
    partial class form_Question
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
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_Question = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(158, 107);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 26);
            this.btn_Ok.TabIndex = 0;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(298, 107);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 26);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.Location = new System.Drawing.Point(27, 38);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(343, 17);
            this.lbl_Question.TabIndex = 2;
            this.lbl_Question.Text = "Add a new Bench User, with the following Username: ";
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(30, 58);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(477, 23);
            this.tb_Username.TabIndex = 3;
            // 
            // form_Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 157);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lbl_Question);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_Question";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.TextBox tb_Username;
    }
}