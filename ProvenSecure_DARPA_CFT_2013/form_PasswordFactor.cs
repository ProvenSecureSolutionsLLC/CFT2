using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvenSecure_DARPA_CFT_2013
{
    public partial class form_PasswordFactor : Form
    {
        public form_PasswordFactor()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void tb_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            PasswordStrength pwdStrength = new PasswordStrength();
            pwdStrength.SetPassword(tb_Password.Text);
            int score = pwdStrength.GetPasswordScore();
            string ScoreDescription = pwdStrength.GetPasswordStrength();
            //DataTable dtScoreDetails=pwdStrength.GetStrengthDetails();

            string s = "";
            int i = 0;

            i = pwdStrength.GetPasswordScore();
            s = i.ToString();

            lbl_Strength.Text = ScoreDescription + ": " + s;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
