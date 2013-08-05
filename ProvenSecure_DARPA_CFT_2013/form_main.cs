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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel17_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formCVSS f = new formCVSS(null, this.cb_UIDebug.Checked);

            f.ShowDialog(this);

        }


        // not part of "sprint 1"
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                //this.groupbox_clientside.Enabled = true;
                //this.groupbox_serverside.Enabled = true;
            }
            else
            {
                //this.groupbox_clientside.Enabled = false;
                //this.groupbox_serverside.Enabled = false;
            }
        }



        private void ll_UserRiskSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formCVSSUser3 f = new formCVSSUser3(null, this.cb_UIDebug.Checked);
            f.ShowDialog(this);

        }

        private void ll_ATTVoiceFactorSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_AuthFactorSettings f = new form_AuthFactorSettings(0); // 0 for AT&T Voice
            f.ShowDialog(this);
        }

        private void ll_TraditionalPasswordFactorSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_AuthFactorSettings f = new form_AuthFactorSettings(1); // 1 for TraditionalPassword
            f.ShowDialog(this);
        }

        private void ll_TraditionalKnowledgeFactorSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_AuthFactorSettings f = new form_AuthFactorSettings(2); // 2 for Knowledge Factor
            f.ShowDialog(this);
        }

        private void ll_SMSTokenFactorSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_AuthFactorSettings f = new form_AuthFactorSettings(3); // 3 for SMS Token
            f.ShowDialog(this);
        }

        private void ll_Devices_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formCVSSDevices f = new formCVSSDevices(null, this.cb_UIDebug.Checked);
            f.ShowDialog(this);
        }

        private void ll_locations_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formCVSSLocations f = new formCVSSLocations(null, this.cb_UIDebug.Checked);
            f.ShowDialog(this);
        }

        private void ll_AuthenticationFactors_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formCVSSFactors f = new formCVSSFactors(null, this.cb_UIDebug.Checked);
            f.ShowDialog(this);
        }

        private void ll_Targets_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formCVSSTargets f = new formCVSSTargets(null, this.cb_UIDebug.Checked);
            f.ShowDialog(this);
        }


        private void formMain_Load(object sender, EventArgs e)
        {
            System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
            string basedir = System.IO.Path.GetDirectoryName(a.Location);

            string s = "file://"+basedir+"\\about\\templateabout.html";
            //Load build-in documentation

            webBrowser1.Navigate(s);
        }


        // here and beyond is "thinking out loud"
        // visual representation for team review
        // not part of "sprint 1"
        private void button1_Click(object sender, EventArgs e)
        {

            form_StartGatheringAuthentication fg = new form_StartGatheringAuthentication();
            fg.ShowDialog();
            if (fg.DialogResult == System.Windows.Forms.DialogResult.OK)
            {

                form_PasswordFactor fp = new form_PasswordFactor();

                fp.ShowDialog();

                form_VoiceFactor fv = new form_VoiceFactor();

                fv.ShowDialog();

                form_FACEFactorS ff = new form_FACEFactorS();

                ff.ShowDialog();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_AllAtOnce f = new form_AllAtOnce();
            f.ShowDialog();
        }
      

    }
}
