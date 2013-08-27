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
    public partial class form_Settings_Container : Form
    {
        private System.Drawing.Color savecolor;
        private Panel currentpanel = null;

        private formCAMture cameraForm = null;
        private formCVSSDevices riskForm = null;
        private form_AuthFactorSettings authfactorForm = null;
        private form_AudioManager audioForm = null;

        public form_Settings_Container(formCAMture parmf, form_AudioManager parma)
        {
            InitializeComponent();
            savecolor = this.panel_cameraSetup.BackColor;
            cameraForm = parmf;
            audioForm = parma;
        }

        public void setCameraForm(formCAMture parmf)
        {
            cameraForm = parmf;
        }

        public void setAudioForm(form_AudioManager parma)
        {
            audioForm = parma;
        }

        public Panel form_Settings_childbody()
        {
            
            return this.panel_ChildBody;
        }

        private void resetPanels()
        {
            this.panel_cameraSetup.BackColor = savecolor;
            this.panel_audioSetup.BackColor = savecolor;

            this.panel_risk_Devices.BackColor = savecolor;
            //this.panel_risk_Locations.BackColor = savecolor;
            //this.panel_risk_Service.BackColor = savecolor;
            //this.panel_risk_role.BackColor = savecolor;
            //this.panel_risk_knowledge.BackColor = savecolor;

            this.panel_service_password.BackColor = savecolor;
            this.panel_service_ATTVoice.BackColor = savecolor;
            this.panel_service_Betaface.BackColor = savecolor;
            this.panel_service_knowledge.BackColor = savecolor;
            this.panel_service_ATTFace.BackColor = savecolor;
            this.panel_service_SMS.BackColor = savecolor;
            
        }

        private void hoverpanel(Panel p)
        {
            p.BackColor = System.Drawing.Color.Black;
        }
        private void leavepanel(Panel p)
        {
            if (p != currentpanel)
            {
                p.BackColor = savecolor;
            }
        }


        private void panel_cameraSetup_MouseHover(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            hoverpanel(p);
        }

        private void panel_cameraSetup_MouseLeave(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            leavepanel(p);
        }

        // Launching Events
        // ----------------------------------------------------------------
        private void panel_cameraSetup_Click(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;

            currentpanel = p;

            resetPanels();

            hoverpanel(p);

            if (p.Name == "panel_cameraSetup")
            {
                if (cameraForm == null)
                {
                    cameraForm = new formCAMture();
                }
                this.panelSettingsContainer.Controls.Clear();
                this.panelSettingsContainer.Controls.Add(cameraForm.clientbody());
            }

            if (p.Name == "panel_audioSetup")
            {
                if (audioForm == null)
                {
                    audioForm = new form_AudioManager();
                }
                this.panelSettingsContainer.Controls.Clear();
                this.panelSettingsContainer.Controls.Add(audioForm.clientpanel());
            }

            if (p.Name == "panel_risk_Devices")
            {
                if (riskForm == null)
                {
                    riskForm = new formCVSSDevices();
                }
                riskForm.setFormType("Risk Cards");
                riskForm.clear();
                this.panelSettingsContainer.Controls.Clear();
                this.panelSettingsContainer.Controls.Add(riskForm.clientpanel());
            }

            if (p.Name == "panel_service_password")
            {
                if (authfactorForm == null)
                {
                    authfactorForm = new form_AuthFactorSettings(0);
                }
                this.panelSettingsContainer.Controls.Clear();
                this.panelSettingsContainer.Controls.Add(authfactorForm.clientpanel());
                authfactorForm.setformtype(0);
            }

            if (p.Name == "panel_service_knowledge")
            {
                if (authfactorForm == null)
                {
                    authfactorForm = new form_AuthFactorSettings(1);
                }
                this.panelSettingsContainer.Controls.Clear();
                this.panelSettingsContainer.Controls.Add(authfactorForm.clientpanel());
                authfactorForm.setformtype(1);
            }

            if (p.Name == "panel_service_ATTVoice")
            {
                if (authfactorForm == null)
                {
                    authfactorForm = new form_AuthFactorSettings(2);
                }
                this.panelSettingsContainer.Controls.Clear();
                this.panelSettingsContainer.Controls.Add(authfactorForm.clientpanel());
                authfactorForm.setformtype(2);
            }
            if (p.Name == "panel_service_ATTFace")
            {
                if (authfactorForm == null)
                {
                    authfactorForm = new form_AuthFactorSettings(3);
                }
                this.panelSettingsContainer.Controls.Clear();
                this.panelSettingsContainer.Controls.Add(authfactorForm.clientpanel());
                authfactorForm.setformtype(3);
            }
            if (p.Name == "panel_service_Betaface")
            {
                if (authfactorForm == null)
                {
                    authfactorForm = new form_AuthFactorSettings(4);
                }
                this.panelSettingsContainer.Controls.Clear();
                this.panelSettingsContainer.Controls.Add(authfactorForm.clientpanel());
                authfactorForm.setformtype(4);
            }
            if (p.Name == "panel_service_SMS")
            {
                if (authfactorForm == null)
                {
                    authfactorForm = new form_AuthFactorSettings(5);
                }
                this.panelSettingsContainer.Controls.Clear();
                this.panelSettingsContainer.Controls.Add(authfactorForm.clientpanel());
                authfactorForm.setformtype(5);
            }

        }

        private void ll_Camera_Click(object sender, EventArgs e)
        {
            Panel p = null;
            LinkLabel l = null;

            l = (LinkLabel)sender;
            p = (Panel)l.Parent;
            this.panel_cameraSetup_Click(p, e);
        }

        private void ll_Camera_MouseHover(object sender, EventArgs e)
        {
            Panel p = null;
            LinkLabel l = null;

            l = (LinkLabel)sender;
            p = (Panel)l.Parent;

            this.hoverpanel(p);
        }

    }
}
