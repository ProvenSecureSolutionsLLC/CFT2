using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;



namespace ProvenSecure_DARPA_CFT_2013
{
    public partial class form_VoiceFactor : Form
    {
        //http://msdn.microsoft.com/en-us/library/hh361633(v=office.14).aspx
        //http://stackoverflow.com/questions/838190/voice-record-winmm-dll-using-c-net
        //http://speechrecognitionblog.blogspot.com/2012/05/audio-recording-and-playback-in-c-net.html

        private SpeechRecognizer recognizer = null; //new SpeechRecognizer();

        public form_VoiceFactor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            //recognizer.Dispose();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void form_VoiceFactor_Shown(object sender, EventArgs e)
        {
//            webBrowser1.Navigate("http://www.provsec.com/demo/");
        }

        // Create a simple handler for the SpeechRecognized event.
        void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            this.tb_Hidden.Text += e.Result.Text;
        }
        // Create a simple handler for the SpeechRecognized event.
        void didyousaysomething(object sender, SpeechHypothesizedEventArgs e)
        {
            this.tb_Hidden.Text += e.Result.Text;
        }



        private void start()
        {
            tb_Recognized.Text = "";
            tb_Hidden.Text = "";

            recognizer = new SpeechRecognizer();

            recognizer.SpeechHypothesized += new EventHandler<SpeechHypothesizedEventArgs>(didyousaysomething);
            recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);

            btn_Start.Text = "Stop";

            timer1.Enabled = true;
            tb_Hidden.Focus();
        }

        private void stop()
        {
            timer1.Enabled = false;
            tb_Hidden.Text = "";
            // tb_Recognized.Text = "";
            btn_Start.Text = "Start";
            recognizer.Dispose();
            recognizer = null;
            rbStopped.Checked = true;
        }

        private void startstop()
        {
            if (this.btn_Start.Text == "Start")
            {
                start();
            }
            else
            {
                stop();
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            startstop();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tb_Hidden.Text != tb_Recognized.Text)
            {
                tb_Recognized.Text = tb_Hidden.Text;
            }
            if (tb_Recognized.Text == tb_Challenge.Text)
            {
                lbl_TextVerified.Text = "Text Verified Audio Captured.  Proceeding...";
                stop();
                timer2.Enabled = true;
            }
            else
            {
                lbl_TextVerified.Text = "Text Verified Audio: has not passed";
            }


            if (recognizer != null)
            {
                if (recognizer.AudioState == AudioState.Silence)
                {
                    rbSilence.Checked = true;
                }
                if (recognizer.AudioState == AudioState.Speech)
                {
                    rbSpeech.Checked = true;
                }
                if (recognizer.AudioState == AudioState.Stopped)
                {
                    rbStopped.Checked = true;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value >= 100)
            {
                timer2.Enabled = false;
            }
        }

        private void cb_SpeechRecognitionEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cb_SpeechRecognitionEnabled.Checked)
            {
                tb_Recognized.ReadOnly = true;
            }
            else
            {
                tb_Recognized.ReadOnly = false;
            }
        }



    }
}
