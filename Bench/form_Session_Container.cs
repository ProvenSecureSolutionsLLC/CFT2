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

        form_AudioManager audioForm = null;

        form_SystemUser systemuserForm = null;

        class_rawauthsession r = null; 


        public form_Session_Container(formCAMture parmf, form_AudioManager parma, form_SystemUser parmu)
        {
            InitializeComponent();

            this.cameraForm = parmf;
            // Although they appear functional
            // These are what we call "stubs" in Sprint 2, they are getting ready to be functional

            this.audioForm = parma;
            this.systemuserForm = parmu;

            r = new class_rawauthsession(systemuserForm.systemuser);

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

            betafaceForm = new form_Betaface(cameraForm, r.sessionfilename);
            betafacepanel = betafaceForm.childbody();
            this.panel_ChildBody.Controls.Add(betafacepanel);
            betafacepanel.SendToBack();
            betafacepanel.Dock = DockStyle.Top;

            attfaceForm = new form_ATTFace(cameraForm, r.sessionfilename);
            attfacepanel = attfaceForm.childbody();
            this.panel_ChildBody.Controls.Add(attfacepanel);
            attfacepanel.SendToBack();
            attfacepanel.Dock = DockStyle.Top;

            attvoiceForm = new form_ATTVoiceFactor(audioForm, r.sessionfilename);
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

        public void setAudioForm(form_AudioManager parmA)
        {
            audioForm = parmA;
        }


        public Panel childbody()
        {
            return this.panel_ChildBody;
        }



        private void btn_recordsessionresult_Click(object sender, EventArgs e)
        {

            r.character = "Actual";
            r.user = this.systemuserForm.systemuser;
            r.password_score = this.passwordForm.pwscore;
            r.attvoice_score1 = this.attvoiceForm.voicescore;
            r.attface_score1 = this.attfaceForm.facescore;
            r.betaface_score1 = this.betafaceForm.facescore;
            r.knowledge_score = this.knowledgeForm.knowledgescore;
            r.sms_score = this.smsForm.smsscore;

            r.savetofile();
        }


    }
}
