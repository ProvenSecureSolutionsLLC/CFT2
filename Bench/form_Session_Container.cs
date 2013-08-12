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
    public partial class form_Session_Container : Form
    {

        form_ATTVoiceFactor attvoiceForm = null;
        Panel voicepanel = null;

        form_PasswordFactor passwordForm = null;
        Panel passwordpanel = null;

        form_ATTFace attfaceForm = null;
        Panel attfacepanel = null;

        form_Betaface betafaceForm = null;
        Panel betafacepanel = null;

        form_KnowledgeMechanism knowledgeForm = null;
        Panel knowledgepanel = null;

        form_SMSMechanism smsForm = null;
        Panel smspanel = null;

        formCAMture cameraForm = null;


        public form_Session_Container(formCAMture parmf)
        {
            InitializeComponent();

            this.cameraForm = parmf;
            // Although they appear functional
            // These are what we call "stubs" in Sprint 2, they are getting ready to be functional

            smsForm = new form_SMSMechanism();
            smspanel = smsForm.childbody();
            this.panel_ChildBody.Controls.Add(smspanel);
            smspanel.SendToBack();
            smspanel.Dock = DockStyle.Top;


            knowledgeForm = new form_KnowledgeMechanism();
            knowledgepanel = knowledgeForm.childbody();
            this.panel_ChildBody.Controls.Add(knowledgepanel);
            knowledgepanel.SendToBack();
            knowledgepanel.Dock = DockStyle.Top;

            betafaceForm = new form_Betaface(cameraForm);
            betafacepanel = betafaceForm.childbody();
            this.panel_ChildBody.Controls.Add(betafacepanel);
            betafacepanel.SendToBack();
            betafacepanel.Dock = DockStyle.Top;

            attfaceForm = new form_ATTFace(cameraForm);
            attfacepanel = attfaceForm.childbody();
            this.panel_ChildBody.Controls.Add(attfacepanel);
            attfacepanel.SendToBack();
            attfacepanel.Dock = DockStyle.Top;

            attvoiceForm = new form_ATTVoiceFactor();
            voicepanel = attvoiceForm.childpanel();
            this.panel_ChildBody.Controls.Add(voicepanel);
            voicepanel.SendToBack();
            voicepanel.Dock = DockStyle.Top;

            passwordForm = new form_PasswordFactor();
            passwordpanel = passwordForm.childpanel();
            this.panel_ChildBody.Controls.Add(passwordpanel);
            passwordpanel.Dock = DockStyle.Top;


            //this.panel_RMM.SendToBack();
            this.panel_session_header.SendToBack();
        }

        public void setCameraForm(formCAMture parmF)
        {
            cameraForm = parmF;
        }


        public Panel childbody()
        {
            return this.panel_ChildBody;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;

            x = this.panel_ChildBody.Controls.IndexOf(passwordpanel);
            if (x <= 1)
            {
                this.panel_ChildBody.Controls.SetChildIndex(passwordpanel, x + 1);
                this.panel_ChildBody.Invalidate();
            }
        }

        private void btn_recordsessionresult_Click(object sender, EventArgs e)
        {
            class_rawauthsession r = new class_rawauthsession();

            // Assumes user is "Default"
            r.character = "Actual";
            r.password_score = this.passwordForm.pwscore;
            r.attvoice_score1 = this.attvoiceForm.voicescore;
            r.attface_score1 = this.attfaceForm.facescore;
            r.betaface_score1 = this.betafaceForm.facescore;
            r.knowledge_score = this.knowledgeForm.knowledgescore;
            r.sms_score = this.smsForm.smsscore;

            MessageBox.Show("Note to programmer, this fishinshes with randomize() at the moment.");
            r.randomize();

            r.savetofile();
        }

    }
}
