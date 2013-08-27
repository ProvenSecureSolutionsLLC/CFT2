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
    public partial class formMain : Form
    {
        private System.Drawing.Color saveHeaderColor;

        private Panel currentpanel = null; 

        private form_Settings_Container settingsForm = null;
        private form_About aboutForm = null;
        private form_Session_Container sessionForm = null;
        private formCAMture cameraForm = null;
        private form_AudioManager audioForm = null;

        private form_SystemUser systemuserForm = null;

        private form_RMMContainer rmmForm = null;

        private form_LowLevelATTVoice lowlevelattvoiceForm = null;

        public formMain()
        {
            InitializeComponent();
            saveHeaderColor = this.panelHeaderAbout.BackColor;
        }

        private void resetPanels()
        {
            this.panelHeaderAbout.BackColor = saveHeaderColor;
            this.panelHeaderSettings.BackColor = saveHeaderColor;
            this.panelHeaderAcquire.BackColor = saveHeaderColor;
            this.panelHeaderReview.BackColor = saveHeaderColor;
            this.panelHeaderTransform.BackColor = saveHeaderColor;
            this.panelHeaderAnalyze.BackColor = saveHeaderColor;
        }

        private void hoverpanel(Panel p)
        {
            p.BackColor = System.Drawing.Color.Black;
        }
        private void leavepanel(Panel p)
        {
            if (p != currentpanel)
            {
                p.BackColor = saveHeaderColor;
            }
        }

        private void panelHeaderAbout_MouseHover(object sender, EventArgs e)
        {
            //Panel p = (Panel)sender;
            //p.BackColor = System.Drawing.Color.Black;
            hoverpanel((Panel)sender);
        }

        private void panelHeaderAbout_MouseLeave(object sender, EventArgs e)
        {
            //Panel p = (Panel)sender;
            //p.BackColor = saveHeaderColor;
            leavepanel((Panel)sender);
        }

        private void panelHeaderAbout_MouseClick(object sender, MouseEventArgs e)
        {
            Panel p = (Panel)sender;

            currentpanel = p;

            resetPanels();

            hoverpanel(p);

            if (p.Name == "panelHeaderAbout")
            {
                if (aboutForm == null)
                {
                    aboutForm = new form_About();
                }
                this.panelBody.Controls.Clear();
                this.panelBody.Controls.Add(aboutForm.childbody());
            }
            if (p.Name == "panelHeaderSettings")
            {
                if (settingsForm == null)
                {
                    if (cameraForm == null)
                    {
                        cameraForm = new formCAMture();
                    }
                    if (audioForm == null)
                    {
                        audioForm = new form_AudioManager();
                    }
                    settingsForm = new form_Settings_Container(cameraForm, audioForm);
                }

                this.panelBody.Controls.Clear();
                this.panelBody.Controls.Add(settingsForm.form_Settings_childbody());
            }
            if (p.Name == "panelHeaderAcquire")
            {
                Boolean b = true;
                if (cameraForm == null) { b = false; }
                if (audioForm == null) { b = false; }
                if (systemuserForm == null) { b = false; }

                if (b == false)
                {
                    MessageBox.Show("Please visit Settings and be sure to choose a Camera, an Audio Device, and a Select or Create a User from the Main Menu.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (sessionForm == null)
                {
                    sessionForm = new form_Session_Container(cameraForm, audioForm, systemuserForm);
                }

                this.panelBody.Controls.Clear();
                this.panelBody.Controls.Add(sessionForm.childbody());
            }

            if (p.Name == "panelHeaderReview")
            {
                if (systemuserForm == null)
                {
                    systemuserForm = new form_SystemUser();
                }
                this.panelBody.Controls.Clear();
                this.panelBody.Controls.Add(systemuserForm.childpanel());
            }

            if (p.Name == "panelHeaderAnalyze")
            {
                if (rmmForm == null)
                {
                    rmmForm = new form_RMMContainer();
                }
                this.panelBody.Controls.Clear();
                this.panelBody.Controls.Add(rmmForm.childpanel());
            }

            if (p.Name == "panelHeaderTransform")
            {
                if (lowlevelattvoiceForm == null)
                {
                    lowlevelattvoiceForm = new form_LowLevelATTVoice();
                }
                lowlevelattvoiceForm.ShowDialog();
            }

        }


        private void ll_About_MouseHover(object sender, EventArgs e)
        {
            Panel p = null;
            LinkLabel l = null;

            l = (LinkLabel)sender;
            p = (Panel)l.Parent;

            this.hoverpanel(p);
        }

        private void ll_About_MouseClick(object sender, MouseEventArgs e)
        {
            Panel p = null;
            LinkLabel l = null;

            l = (LinkLabel)sender;
            p = (Panel)l.Parent;
            this.panelHeaderAbout_MouseClick(p, e);
        }

        private void panelHeaderReview_Paint(object sender, PaintEventArgs e)
        {
        }

    }
}
