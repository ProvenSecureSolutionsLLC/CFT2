using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Bench
{
    public partial class form_PasswordFactor : Form
    {

        private int pwMeterScore = 0;
        public Double pwscore = Double.NaN;
        public Double smsscore = Double.NaN;
        private string rightanswer = "";

        public form_PasswordFactor()
        {
            InitializeComponent();
        }

        public Panel childpanel()
        {
            return this.panel_ChildBody;
        }

        public void clear()
        {
            tb_Password.Text = "";
            Application.DoEvents();
            tb_Score.Text = "";
            tb_SMSScore.Text = "";
            tb_SMSCode.Text = "";
        }

        private void recalculate()
        {
            double agereduce = 0.00;
            double retriesreduce = 0.00;
            double correct = 0.00;
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

            correct = 100;
            //correct = smsscore; - no, let Adom correlate SMS to PW score - not our job, RMM's job 
            /*if (cb_correct.Checked)
            {
                correct = 100;
            }
            else
            {
                correct = 0;
            }*/

            double finalscore = 0.00;

            finalscore = (pwMeterScore * agereduce * retriesreduce * correct) / 100;

            this.pwscore = finalscore;

            // False Accept - 1/ (126-32 * length) * some factor meaning there are dictionaries, etc.,
            if (tb_Password.Text.Length > 0)
            {
//                fa = (1.00 / (94 * tb_Password.Text.Length)) * 100.00;
                this.tb_Score.Text = finalscore.ToString("###.####");
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

        public static bool SendGmail(string gusername, string gpassword, string subject, string content, string recipient, string from)
        {
            bool success = recipient != null && recipient.Length > 0;

            if ((gusername == null) || (gusername == ""))
            {
                MessageBox.Show("Please enter a valid 'username@gmail.com'");
                return false;
            }
            else
            {
                if (!gusername.Contains("@gmail.com"))
                {
                    MessageBox.Show("Please enter a valid 'username@gmail.com'");
                    return false;
                }
            }

            if (success)
            {
                SmtpClient gmailClient = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential(gusername, gpassword)
                };


                using (MailMessage gMessage = new MailMessage(from, recipient, subject, content))
                {
                    //for (int i = 1; i < recipients.Length; i++) gMessage.To.Add(recipients[i]);

                    try
                    {
                        gmailClient.Send(gMessage);
                        success = true;
                    }
                    catch (Exception) { success = false; }
                }
            }
            return success;
        }

        private void btn_sendsms_Click(object sender, EventArgs e)
        {

            string parmcarrier = "txt.att.net";

            if (this.combo_Carrier.Text == "AT&T Wireless") { parmcarrier = "txt.att.net"; }
            if (this.combo_Carrier.Text == "Sprint") { parmcarrier = "sprintpaging.com"; }
            if (this.combo_Carrier.Text == "Sprint PCS") { parmcarrier = "messaging.sprintpcs.com"; }
            if (this.combo_Carrier.Text == "T-Mobile") { parmcarrier = "tmomail.net"; }
            if (this.combo_Carrier.Text == "Verizon") { parmcarrier = "vtext.com"; }
            if (this.combo_Carrier.Text == "Virgin") { parmcarrier = "vmobl.com"; }

            string recipient = tb_phone.Text + "@" + parmcarrier;

            if (this.combo_Carrier.Text == "Use My Email") { recipient = this.tb_gmail_username.Text; }

            Random rng = new Random();

            string temp = rng.NextDouble().ToString(".####");
            rightanswer = "";
            for (int x = 0; x < temp.Length; x++)
            {
                if (temp[x] != '.')
                {
                    rightanswer += temp[x];
                }
            }

            if (SendGmail(this.tb_gmail_username.Text, this.tb_Password.Text, "ProvenSecure - SMS Code", rightanswer, recipient, tb_gmail_username.Text))
            {
                MessageBox.Show("Message Sent, please check your Phone or Inbox");
            }
            else
            {
                MessageBox.Show("Error: Sending SMS Code");
            }
        }


        private void tb_SMSCode_TextChanged(object sender, EventArgs e)
        {

            if (tb_SMSCode.Text == rightanswer)
            {
                smsscore = 100.00;

                if (combo_Carrier.Text == "Use My Email")
                {
                    smsscore = 50.00;  // less value if it is not a more for sure "separate channel"
                }

                tb_SMSScore.Text = smsscore.ToString("#.####");
            }
            else
            {
                smsscore = 0.00;
                tb_SMSScore.Text = smsscore.ToString("#.####");
            }

            recalculate();

        }

    }
}
