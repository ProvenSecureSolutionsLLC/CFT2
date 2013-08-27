namespace Bench
{
    partial class form_KnowledgeMechanism
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
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Score = new System.Windows.Forms.TextBox();
            this.tb_right = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_risk = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_maybe = new System.Windows.Forms.TextBox();
            this.panel_ChildBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ChildBody
            // 
            this.panel_ChildBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ChildBody.Controls.Add(this.tb_maybe);
            this.panel_ChildBody.Controls.Add(this.label4);
            this.panel_ChildBody.Controls.Add(this.label3);
            this.panel_ChildBody.Controls.Add(this.combo_risk);
            this.panel_ChildBody.Controls.Add(this.label2);
            this.panel_ChildBody.Controls.Add(this.tb_right);
            this.panel_ChildBody.Controls.Add(this.label7);
            this.panel_ChildBody.Controls.Add(this.label1);
            this.panel_ChildBody.Controls.Add(this.tb_Score);
            this.panel_ChildBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ChildBody.Location = new System.Drawing.Point(0, 0);
            this.panel_ChildBody.Margin = new System.Windows.Forms.Padding(4);
            this.panel_ChildBody.Name = "panel_ChildBody";
            this.panel_ChildBody.Size = new System.Drawing.Size(1030, 117);
            this.panel_ChildBody.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Knowledge";
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
            this.tb_Score.TabIndex = 56;
            // 
            // tb_right
            // 
            this.tb_right.Location = new System.Drawing.Point(247, 51);
            this.tb_right.Name = "tb_right";
            this.tb_right.Size = new System.Drawing.Size(385, 23);
            this.tb_right.TabIndex = 53;
            this.tb_right.TextChanged += new System.EventHandler(this.tb_right_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Right Answer: ";
            // 
            // combo_risk
            // 
            this.combo_risk.FormattingEnabled = true;
            this.combo_risk.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.combo_risk.Location = new System.Drawing.Point(247, 21);
            this.combo_risk.Name = "combo_risk";
            this.combo_risk.Size = new System.Drawing.Size(121, 24);
            this.combo_risk.TabIndex = 52;
            this.combo_risk.Text = "Easy";
            this.combo_risk.SelectedIndexChanged += new System.EventHandler(this.combo_risk_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Risk Level:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Right or Wrong Answer: ";
            // 
            // tb_maybe
            // 
            this.tb_maybe.Location = new System.Drawing.Point(247, 78);
            this.tb_maybe.Name = "tb_maybe";
            this.tb_maybe.Size = new System.Drawing.Size(385, 23);
            this.tb_maybe.TabIndex = 55;
            this.tb_maybe.TextChanged += new System.EventHandler(this.tb_maybe_TextChanged);
            // 
            // form_KnowledgeMechanism
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 273);
            this.Controls.Add(this.panel_ChildBody);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_KnowledgeMechanism";
            this.Text = "form_KnowledgeMechanism";
            this.panel_ChildBody.ResumeLayout(false);
            this.panel_ChildBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ChildBody;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Score;
        private System.Windows.Forms.TextBox tb_maybe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_risk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_right;
    }
}