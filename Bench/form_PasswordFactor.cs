using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bench
{
    public partial class form_PasswordFactor : Form
    {

        private int pwMeterScore = 0;
        public Double pwscore = Double.NaN;

        public form_PasswordFactor()
        {
            InitializeComponent();
        }

        public Panel childpanel()
        {
            return this.panel_ChildBody;
        }

        private void recalculate()
        {
            double agereduce = 0.00;
            double retriesreduce = 0.00;
            int correct = 0;
            double fa = 0.00;

            if (updown_Age.Value >= 90)
            {
                agereduce = 0.00; // EXPIRED
            }
            else
            {
                agereduce = (double)(1 - (updown_Age.Value / 200));
            }
            if (updown_Attempts.Value > 5)
            {
                retriesreduce = 0; // no, that is ridiculous
            }
            else
            {
                retriesreduce = (double)(1 - (updown_Attempts.Value / 300));
            }
            if (cb_correct.Checked)
            {
                correct = 100;
            }
            else
            {
                correct = 0;
            }

            double finalscore = 0.00;

            finalscore = (pwMeterScore * agereduce * retriesreduce * correct) / 100;

            this.tb_Score.Text = finalscore.ToString("###.####");

            this.pwscore = finalscore;

            // False Accept - 1/ (126-32 * length) * some factor meaning there are dictionaries, etc.,
            if (tb_Password.Text.Length > 0)
            {
                fa = (1.00 / (94 * tb_Password.Text.Length)) * 100.00;
            }

        }


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void tb_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            PasswordStrength pwdStrength = new PasswordStrength();
            pwdStrength.SetPassword(tb_Password.Text);
            pwMeterScore = pwdStrength.GetPasswordScore();
            string ScoreDescription = pwdStrength.GetPasswordStrength();
            //DataTable dtScoreDetails=pwdStrength.GetStrengthDetails();

            string s = "";
            
            s = pwMeterScore.ToString();

            lbl_Strength.Text = ScoreDescription + ": " + s;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            recalculate();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            recalculate();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            recalculate();
        }
    }
}
