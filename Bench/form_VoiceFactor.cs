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



namespace Bench
{
    public partial class form_ATTVoiceFactor : Form
    {
        //http://msdn.microsoft.com/en-us/library/hh361633(v=office.14).aspx
        //http://stackoverflow.com/questions/838190/voice-record-winmm-dll-using-c-net
        //http://speechrecognitionblog.blogspot.com/2012/05/audio-recording-and-playback-in-c-net.html

        private SpeechRecognizer recognizer = null; //new SpeechRecognizer();
        private form_AudioManager audioForm = null;
        private form_LowLevelATTVoice lowvoiceform = new form_LowLevelATTVoice();
        private class_rawauthsession r = null;
        private form_SystemUser su = null;

        string token = "";
        string voiceid = "";
        string attvoicesession = "";

        string originaltexttosay = ""; // FROM att api
        string fixeduptexttosay = "";  // remove punctuation for local text to speech processing

        //private form_SystemUser systemuserForm = null;
        //private string sessionfilename = "";

        private Boolean recognizerstartedlistening = false;

        public Double voicescore = Double.NaN;


        private string myfilename(string parmfilename)
        {
            return parmfilename + ".wav";
        }

        public form_ATTVoiceFactor(form_AudioManager parmf, class_rawauthsession parmr, form_SystemUser parmsu)
        {
            InitializeComponent();

            audioForm = parmf;
            //systemuserForm = parms;
            su = parmsu;
            r = parmr;
        }

        public void clear()
        {
            tb_Challenge.Text = "";
            tb_Score.Text = "";
            this.attvoicesession = "";
        }


        public Panel childpanel()
        {
            return this.panel_ChildBody;
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

        private void form_ATTVoiceFactor_Shown(object sender, EventArgs e)
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
            tb_Score.Text = "";
            recognizerstartedlistening = false;

            if (cb_SpeechRecognitionEnabled.Checked)
            {
                recognizer = new SpeechRecognizer();

                recognizer.SpeechHypothesized += new EventHandler<SpeechHypothesizedEventArgs>(didyousaysomething);
                recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);
            }

            btn_Start.Text = "Stop";

            timer1.Enabled = true;
            tb_Hidden.Focus();
        }

        private void stop()
        {
            timer1.Enabled = false;

            audioForm.StopRecording();

            btn_overrideandgo.Enabled = true;

            tb_Hidden.Text = "";
            // tb_Recognized.Text = "";
            btn_Start.Text = "Start or Re-Start";
            if (recognizer != null)
            {
                recognizer.Dispose();
            }
            recognizer = null;
            rbStopped.Checked = true;
        }

        private void startstop()
        {
            if (this.btn_Start.Text == "Start or Re-Start")
            {
                MessageBox.Show("Click OK and then begin speaking.  When finished, click 'Stop Recording and Go'.  Or, click 'Stop' if you messed up, and try again.");
                start();
            }
            else
            {
                stop();
            }
        }


        private void msgboxdebug(string s)
        {
           MessageBox.Show(s);
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //lbl_TextVerified.Text = "Text Verified Audio: has not passed";
                //progressBar1.Value = 0;

                Application.DoEvents();

                // get a new auth token
                token = lowvoiceform.authtoken("chgeevn0tteexhh9b2coyfbqgunahw5u", "arlllwmgziyitlylt3yxhjff5tagdcw6");
                // see if we need to get a user id
                voiceid = su.attvoiceid;
                if (voiceid == "")
                {
                    voiceid = lowvoiceform.CreateUserId();

                    // BORK
                    //msgboxdebug("Debug: CreateUserId Returns: " + lowvoiceform.getrawoutput());

                    if (voiceid != "")
                    {
                        su.attvoiceid = voiceid;
                    }
                    else
                    {
                        MessageBox.Show("Unable to retrieve or create userid.  Wait a moment and try again.");
                        return;
                    }
                }

                if (attvoicesession == "")
                {
                    attvoicesession = lowvoiceform.CreateVoiceSession("123456", voiceid);
                }
                //msgboxdebug("Debug: CreateVoiceSession Returns: " + lowvoiceform.getrawoutput());

                if (attvoicesession != "")
                {
                    originaltexttosay = "";

                    originaltexttosay = lowvoiceform.RandomStatement(attvoicesession);
                    //msgboxdebug("Debug: RandomStatement Returns: " + lowvoiceform.getrawoutput());

                    if (originaltexttosay != "")
                    {
                        // REMOVE puctuation
                        fixeduptexttosay = originaltexttosay.ToLower();
                        fixeduptexttosay = fixeduptexttosay.Replace(",", "");
                        fixeduptexttosay = fixeduptexttosay.Replace(".", "");

                        tb_Challenge.Text = fixeduptexttosay;
                        startstop();
                    }
                    else
                    {
                        MessageBox.Show("Unable to retrieve text_to_say.  Wait a moment and try again.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Could not create voice session, wait a moment and try again.");
                    return;
                }
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                Application.DoEvents();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tb_Hidden.Text != tb_Recognized.Text)
            {
                if (cb_SpeechRecognitionEnabled.Checked)
                {
                    tb_Recognized.Text = tb_Hidden.Text.ToLower();
                }
            }
            if (tb_Recognized.Text == tb_Challenge.Text)
            {
                //lbl_TextVerified.Text = "Text Verified Audio Captured.  Proceeding...";
                stop();
                timer2.Enabled = true;
            }
            else
            {
                //lbl_TextVerified.Text = "Text Verified Audio: has not passed";
            }

            if (cb_SpeechRecognitionEnabled.Checked)
            {
                if (recognizer != null)
                {
                    if (recognizer.AudioState == AudioState.Silence)
                    {
                        rbSilence.Checked = true;
                        if (recognizerstartedlistening == false)
                        {
                            audioForm.StartRecording(myfilename(r.sessionfilename));
                            recognizerstartedlistening = true;
                        }
                    }
                    if (recognizer.AudioState == AudioState.Speech)
                    {
                        rbSpeech.Checked = true;
                        if (recognizerstartedlistening == false)
                        {
                            audioForm.StartRecording(myfilename(r.sessionfilename));
                            recognizerstartedlistening = true;
                        }
                    }
                    if (recognizer.AudioState == AudioState.Stopped)
                    {
                        rbStopped.Checked = true;
                    }
                }
            }
            else
            {
                // if cb_SpeechRecognitionEnabled is not checked
                audioForm.StartRecording(myfilename(r.sessionfilename));
                // If user said "I don't have speech to text" or "I can't use it effectively" then we have to trust the bench user / scientist in him/her
                btn_overrideandgo.Enabled = true;
            }
        }


        private void doScoring()
        {
            string tscore = "";

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Application.DoEvents();

                if (cb_Train.Checked)
                {
                    tscore = lowvoiceform.Train(this.originaltexttosay, attvoicesession, myfilename(r.sessionfilename));
                    if ((tscore != null) && (tscore != ""))
                    {
                        if (!tscore.Contains("ERROR:"))
                        {
                            tb_Score.Text = tscore;
                            this.voicescore = Convert.ToDouble(tscore);
                            Application.DoEvents();

                            //msgboxdebug("Debug: Train() Returns: " + lowvoiceform.getrawoutput());

                            DialogResult dr = MessageBox.Show("Finalize This Training Event Now ?  Click 'No' to try to get a better score.", "Voice Sample Collected", MessageBoxButtons.YesNo);
                            if (dr == System.Windows.Forms.DialogResult.Yes)
                            {
                                lowvoiceform.Finalize(attvoicesession);
                                attvoicesession = "";
                            }

                            tb_Challenge.Text = "";
                            tb_Hidden.Text = "";
                            tb_Recognized.Text = "";
                            //progressBar1.Value = 0;

                            Application.DoEvents();
                            //lbl_TextVerified.Text = "Text Verified Audio: has not passed";
                        }
                    }
                    else
                    {
                        if (tscore == "")
                        {
                            MessageBox.Show("No result.  Please try again.");
                        }
                    }
                

                }
                else
                {
                    tscore = lowvoiceform.Verify(this.originaltexttosay, attvoicesession, myfilename(r.sessionfilename));

                    //msgboxdebug("Debug: Verify() Returns: " + lowvoiceform.getrawoutput());
                    string jj = lowvoiceform.getrawoutput();

                    if ((tscore != null) && (tscore != ""))
                    {
                        if (!tscore.Contains("ERROR:"))
                        {
                            tb_Score.Text = tscore;
                            this.voicescore = Convert.ToDouble(tscore);
                            Application.DoEvents();

                            DialogResult dr = MessageBox.Show("Finalize now with this score ?  Click 'No' to try to score better.", "Voice Sample Collected", MessageBoxButtons.YesNo);
                            if (dr == System.Windows.Forms.DialogResult.Yes)
                            {
                                lowvoiceform.Finalize(attvoicesession);
                                attvoicesession = "";
                            }
                        }
                    }
                    else
                    {
                        if (tscore == "")
                        {
                            MessageBox.Show("No result. Please try again.");
                        }
                    }
                }
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                Application.DoEvents();
            }

            if (tscore != "")
            {
                tb_Score.Text = tscore;
                this.voicescore = Convert.ToDouble(tscore);
            }
        }



        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            doScoring();
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


        // User must not have speech to text, let them click "I did it right" and continue
        private void btn_overrideandgo_Click(object sender, EventArgs e)
        {
            // lbl_TextVerified.Text = "Override speech to text.  Proceeding...";
            stop();
            timer2.Enabled = true;
        }



    }
}
