using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bench
{
    public partial class form_RMMContainer : Form
    {

        private string baseDir = "";
        private string startFolder = "";

//        private form_DataTransformation pickform = null;

        public void refresh()
        {
            System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
            baseDir = System.IO.Path.GetDirectoryName(a.Location);
            startFolder = baseDir + "\\UserData";


            bool isExists = System.IO.Directory.Exists(startFolder);

            if (!isExists)
                System.IO.Directory.CreateDirectory(startFolder);

            // Take a snapshot of the file system.
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(startFolder);

            // This method assumes that the application has discovery permissions 
            // for all folders under the specified path.
            IEnumerable<System.IO.DirectoryInfo> directoryList = dir.GetDirectories();

            clb_Users.Items.Clear();
            foreach (System.IO.DirectoryInfo d in directoryList)
            {
                clb_Users.Items.Add(d.Name);
            }
        }

        public form_RMMContainer()
        {
            InitializeComponent();
            refresh();
        }

        public Panel childpanel()
        {
            return this.panel_ChildBody;
        }



        private string getsuffix(string parmuser, int parmauthmech, string parmscore, string parmpriorg, string parmpriori)
        {
            string retval = "";

            System.Windows.Forms.CheckedListBox.CheckedItemCollection items = this.clb_Users.CheckedItems;

            //foreach (string s in items)
            //{

                class_highlowsession hls = class_gather_sessionstats.GETHighLowMeanStdDev_User(parmuser);

                // we need a score to run now
                // we need to pick an authenticator to get the mean,stddev and impostor mean,stddev

                //if (items.Count > 0)
                //{
                string myauthmech = ""; // combo_authmech.Text;
                double mymean = 0.00;
                double mystddev = 0.00;

                // not enough time/data available to know "impostor" data well 
                // have to improvise for now
                double imean = 0.00;
                double istddev = 0.00;

                int what = parmauthmech;
                switch (what)
                {
                        case 0:
                            mymean = hls._pwmean;
                            mystddev = hls._pwstddev;
                            myauthmech = "Password";
                            break;
                        case 1:
                            mymean = hls._smsmean;
                            mystddev = hls._smsstddev;
                            myauthmech = "SMS";
                            break;
                        case 2:
                            mymean = hls._attvoicemean;
                            mystddev = hls._attvoicestddev;
                            myauthmech = "ATT Voice";
                            break;
                        case 3:
                            mymean = hls._betafacemean;
                            mystddev = hls._betafacestddev;
                            myauthmech = "Betaface";
                            break;
                        case 4:
                            mymean = hls._knowledgemean;
                            mystddev = hls._knowledgestddev;
                            myauthmech = "Knowledge";
                            break;
                        default:
                            myauthmech = "Undefined";
                            mymean = 1.00;
                            mystddev = 0.00;
                            break;
                }

                    /* old
                    retval += "# " + s + "'s scores for "+myauthmech+" authenticator\r\n";
                    retval += "score <- c(" + tb_testscore.Text + ")\r\n";

                    //retval += "# "+s+"'s genuine/imposter (normal) distribution parameters\r\n";
                    retval += "mean  <- list(list(g="+mymean.ToString("#.######")+",i=-1.01))\r\n";
                    retval += "std   <- list(list(g="+mystddev.ToString("#.######")+",i=1))\r\n";

                    //retval += "# initial conditions for "+s+"\r\n";
                    retval += "prior <- list(g=1,i=1)\r\n";
                    retval += "evid  <- list(g=1,i=1)\r\n";

                    //retval += "# Does "+s+" pass?\r\n";
                    retval += "a <- 1\r\n";
                    retval += "check(\""+s+"\",score,mean,std,prior,evid,a,normal.postf)\r\n";
                    //retval += "check2("+s+",score,mean,std,evid,naive.auth.decider,normal.postf)\r\n";
                    retval += "\r\n";
                     */
                    // After 10/24/2013 it goes like this...

                //if (parmscore == "1")
               // {
                //    parmscore = "0.924293";
                //}
                if (mymean == 0.0)
                {
                    mymean = Convert.ToDouble(parmscore);
                }
                if (mystddev == 0.0)
                {
                    mystddev = 0.0001;
                }

                imean = mymean * 0.8;
                istddev = mystddev * 1.2;


                retval += "# " + parmuser + " scores for " + myauthmech + " authenticator\r\n";
                retval += "user <- \"" + parmuser + "\"\r\n";
                retval += "auth <- \"" + myauthmech + "\"\r\n";
                retval += "score <- c(" + parmscore + ")\r\n";
                retval += "mean  <- list(list(g=" + mymean.ToString("0.######") + ", i=" + imean.ToString("0.######") + "))\r\n\r\n";
                retval += "std   <- list(list(g=" + mystddev.ToString("0.######") + ", i=" + istddev.ToString("0.######") + "))\r\n\r\n";
                retval += "prior <- list(g="+parmpriorg+",i="+parmpriori+")\r\n\r\n";
                retval += "ans <- calc.bf(user,mean[[1]],std[[1]],score, prior,normal.postf)\r\n\r\n";
                retval += "bf <- ans$bf\r\n";
                retval += "post <- ans$post\r\n";

                retval += "cat( sprintf(\"user=%s\\n\", user) )\r\n";
                retval += "cat( sprintf(\"auth=%s\\n\", auth) )\r\n";
                retval += "cat( sprintf(\"bf=%s\\n\", bf) )\r\n";
                retval += "cat( sprintf(\"postg=%s\\n\", post$g) )\r\n";
                retval += "cat( sprintf(\"posti=%s\\n\", post$i) )\r\n";
                //}
            //}

            return retval;
        }


       private void btn_Transformations_Click(object sender, EventArgs e)
       {
       }

       private void panel_ChildBody_Paint(object sender, PaintEventArgs e)
       {

       }

       private void btn_Process3_Click(object sender, EventArgs e)
       {

       }

       private void btn_Process1_Click(object sender, EventArgs e)
       {
           tb_output2.Clear();
           tb_output2.AppendText("\"user\",\"pw score\",\"sms\",\"voice1\",\"betaface1\",\"knowledge\"\r\n");
           foreach (string parmuser in clb_Users.CheckedItems)
           {
               //tb_output2.AppendText(parmuser + "\r\n");

               IEnumerable<class_rawauthsession> ieras = class_gather_sessionstats.GET_IEnumerable_User(parmuser);

               foreach (class_rawauthsession raw in ieras)
               {
                   tb_output2.AppendText("\"" + raw.user + "\",");
                   //tb_output2.AppendText(raw.filename());
                   //tb_output2.AppendText(raw.startdatetime.ToString());
                   //tb_output2.AppendText(raw.enddatetime.ToString());
                   tb_output2.AppendText("\"" + raw.password_score + "\",");
                   tb_output2.AppendText("\"" + raw.sms_score + "\",");
                   tb_output2.AppendText("\"" + raw.attvoice_score1 + "\",");
                   tb_output2.AppendText("\"" + raw.betaface_score1 + "\",");
                   tb_output2.AppendText("\"" + raw.knowledge_score + "\"");
                   tb_output2.AppendText("\r\n");
               }
           }

       }

       private void btn_Process2_Click(object sender, EventArgs e)
       {
           tb_output2.Clear();

           //public static class_highlowsession GETHighLowMeanStdDev_User(string parmUser)
           foreach (string parmuser in clb_Users.CheckedItems)
           {
               class_highlowsession hls = class_gather_sessionstats.GETHighLowMeanStdDev_User(parmuser);

               tb_output2.AppendText("For user: " + parmuser + "\r\n\r\n");

               tb_output2.AppendText("pw Count: " + hls._pwcount.ToString() + "\r\n");
               tb_output2.AppendText("pw Sum: " + hls._pwsum.ToString() + "\r\n");
               tb_output2.AppendText("pw Max: " + hls._pwmax.ToString() + "\r\n");
               tb_output2.AppendText("pw Min: " + hls._pwmin.ToString() + "\r\n");
               tb_output2.AppendText("pw Mean: " + hls._pwmean.ToString() + "\r\n");
               tb_output2.AppendText("pw StdDev: " + hls._pwstddev.ToString() + "\r\n\r\n");

               tb_output2.AppendText("sms Count: " + hls._smscount.ToString() + "\r\n");
               tb_output2.AppendText("sms Sum: " + hls._smssum.ToString() + "\r\n");
               tb_output2.AppendText("sms Max: " + hls._smsmax.ToString() + "\r\n");
               tb_output2.AppendText("sms Min: " + hls._smsmin.ToString() + "\r\n");
               tb_output2.AppendText("sms Mean: " + hls._smsmean.ToString() + "\r\n");
               tb_output2.AppendText("sms StdDev: " + hls._smsstddev.ToString() + "\r\n\r\n");

               tb_output2.AppendText("Voice Count: " + hls._attvoicecount.ToString() + "\r\n");
               tb_output2.AppendText("Voice Sum: " + hls._attvoicesum.ToString() + "\r\n");
               tb_output2.AppendText("Voice Max: " + hls._attvoicemax.ToString() + "\r\n");
               tb_output2.AppendText("Voice Min: " + hls._attvoicemin.ToString() + "\r\n");
               tb_output2.AppendText("Voice Mean: " + hls._attvoicemean.ToString() + "\r\n");
               tb_output2.AppendText("Voice StdDev: " + hls._attvoicestddev.ToString() + "\r\n\r\n");

               tb_output2.AppendText("betaface Count: " + hls._betafacecount.ToString() + "\r\n");
               tb_output2.AppendText("betaface Sum: " + hls._betafacesum.ToString() + "\r\n");
               tb_output2.AppendText("betaface Max: " + hls._betafacemax.ToString() + "\r\n");
               tb_output2.AppendText("betaface Min: " + hls._betafacemin.ToString() + "\r\n");
               tb_output2.AppendText("betaface Mean: " + hls._betafacemean.ToString() + "\r\n");
               tb_output2.AppendText("betaface StdDev: " + hls._betafacestddev.ToString() + "\r\n\r\n");

               tb_output2.AppendText("knowledge Count: " + hls._knowledgecount.ToString() + "\r\n");
               tb_output2.AppendText("knowledge Sum: " + hls._knowledgesum.ToString() + "\r\n");
               tb_output2.AppendText("knowledge Max: " + hls._knowledgemax.ToString() + "\r\n");
               tb_output2.AppendText("knowledge Min: " + hls._knowledgemin.ToString() + "\r\n");
               tb_output2.AppendText("knowledge Mean: " + hls._knowledgemean.ToString() + "\r\n");
               tb_output2.AppendText("knowledge StdDev: " + hls._knowledgestddev.ToString() + "\r\n\r\n");

           }

       }


       private Boolean carryGI(ref string G, ref string I, ref string BF)
       {
           Boolean retval = false;
           Boolean hasI = false;
           Boolean hasG = false;

           string[] sray = tb_output.Text.Split('\n');

           string tempG = "";
           string tempI = "";
           string tempbf = "";

           foreach (string s in sray)
           {
               if (s.Contains("postg="))
               {
                   tempG = s;
                   tempG = tempG.Remove(0, 6);
                   hasG = true;
                   G = tempG.Trim();
               }
               if (s.Contains("posti="))
               {
                   tempI = s;
                   tempI = tempI.Remove(0, 6);
                   hasI = true;
                   I = tempI.Trim();
               }
               if (s.Contains("bf=")) 
               {
                   tempbf = s;
                   tempbf = tempbf.Remove(0,3);
                   BF = tempbf.Trim();
               }
           }

           retval = (hasG == hasI);

           return retval;
       }


        // use the user-entered values for just one run of R
       private void runone(string parmuser, int parmauthmech, string parmscore, ref string parmpriorg, ref string parmpriori, ref string BF)
       {

           string suffix = getsuffix(parmuser, parmauthmech, parmscore, parmpriorg, parmpriori);

           Boolean carried = false;

           System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
           string basedir = System.IO.Path.GetDirectoryName(a.Location);

           string rdir = basedir + "\\RData";

           bool isExists = System.IO.Directory.Exists(rdir);

           try
            {
                if (!isExists)
                    System.IO.Directory.CreateDirectory(rdir);
            }
            catch
            {
                MessageBox.Show("Unable to create folder: " + rdir, "Process Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string commandfilename = @"c:\Program Files\R\R-3.0.1\bin\x64\r.exe";
            string scriptfilename = basedir + @"\RData\inputToR.r";
            string scriptoutputfilename = basedir +@"\RData\outputFromR.txt";

            string args = "--vanilla --silent -f " + "\"" + scriptfilename + "\" > \"" + scriptoutputfilename + "\"";


            // Write the scirpt that R.Exe is going to read
            System.IO.StreamWriter sw = new System.IO.StreamWriter(scriptfilename);
            sw.Write(textBox_Script.Text + "\r\n" + suffix);
            sw.Close();

            ProcessStartInfo pinfo = new ProcessStartInfo();

            pinfo.FileName = commandfilename;
            pinfo.Arguments = args;

            Process p = Process.Start(pinfo);
            //p.WaitForInputIdle(); // probably don't use this with R this way

            int cnt = 0;

            while (cnt < 5)
            {
                p.WaitForExit(2000);
                if (p.HasExited == false)
                {
                    cnt++;
                }
                else
                {
                    cnt = 6;
                }
            }
            if (p.HasExited == false)
            {
                if (p.Responding)
                {
                    //listbox_output.Items.Add("R.exe Exceeded 10 seconds, still responding, sending shutdown message...");
                    tb_output.AppendText("R.exe Exceeded 10 seconds, still responding, sending shutdown message...");
                    p.CloseMainWindow();
                }
                else
                {
                    //listbox_output.Items.Add("R.exe Exceeded 10 seconds, not responding, issuing Kill order...");
                    tb_output.AppendText("R.exe Exceeded 10 seconds, not responding, issuing Kill order...");
                    p.Kill();
                }
            }
            else
            {
                //listbox_output.Items.Clear();
                tb_output.Clear();
                tb_suffix.Clear();

                //listbox_output.Items.Add(suffix); // ?
                tb_suffix.AppendText(suffix);

                var items = new List<string>();
                System.IO.StreamReader sr = new System.IO.StreamReader(scriptoutputfilename);
                string line;

                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    if (!checkbox_filter.Checked)
                    {
                        //listbox_output.Items.Add(line);
                        tb_output.AppendText(line + "\r\n");

                    }
                    else
                    {
                        if ((!line.StartsWith(">")) && (!line.StartsWith("+"))) 
                        {
                            //listbox_output.Items.Add(line);
                            tb_output.AppendText(line + "\r\n");
                        }
                        
                    }
                }
                sr.Close();
            }

            Application.DoEvents();

            carried = carryGI(ref parmpriorg, ref parmpriori, ref BF);
       }


       private void log(string s)
       {
           tb_log.AppendText(s + "\r\n");
       }



       private double lowpostf(double mean, double std, double score, double prior)
       {
           double retval = 0.00;

           //{( (1/(sqrt(2*pi)*std) ) * exp( (-1/2) * (((score-mean)/std)^2) )*prior)}

           double term1 = 1 / (Math.Sqrt(2 * Math.PI) * std);
           double term3 = (-1.00 / 2.00) * Math.Pow( (( score - mean ) / std), 2.00);
           double term2 = Math.Exp(term3);
           retval = (term1 * term2 * prior);

           return retval;
       }

       // function(mean,std,score,prior) {((1/(sqrt(2*pi)*std))*exp((-1/2)*(((score-mean)/std)^2))*prior)}
       private void postf(ref double bf, double meang, double stdg, double meani, double stdi, double score, ref double priorg, ref double priori)
       {
           priorg = lowpostf(meang, stdg, score, priorg);
           priori = lowpostf(meani, stdi, score, priori);

           bf = (priorg / priori);
       }

       // Try it in reverse, see what the bad-guy would score in terms of BF
       private void postfi(ref double bf, double meang, double stdg, double meani, double stdi, double score, ref double priorg, ref double priori)
       {
           priorg = lowpostf(meang, stdg, score, priorg);
           priori = lowpostf(meani, stdi, score, priori);

           bf = (priori / priorg);
       }

        // use all historic scores and run against means/stddev
       private void runbatch()
       {
           int parmauthmech = 0;
           string parmscore = "";
           string carryG = "";
           string carryI = "";
           string BF = "";

           foreach (string parmuser in clb_Users.CheckedItems)
           {
               IEnumerable<class_rawauthsession> ieras = class_gather_sessionstats.GET_IEnumerable_User(parmuser);

               foreach (class_rawauthsession raw in ieras)
               {
                   // need a way to set prior to 1,1 and then carry forward
                   carryG = "1"; carryI = "1";
                   parmauthmech = 0;
                   parmscore = raw.password_score.ToString("#.######");
                   runone(parmuser, parmauthmech, parmscore, ref carryG, ref carryI, ref BF);
                   log("password: BF=" + BF + " g=" + carryG + " i=" + carryI);

                   carryG = "1"; carryI = "1";
                   tb_output2.AppendText("\"" + raw.sms_score + "\",");
                   parmauthmech = 1;
                   parmscore = raw.sms_score.ToString("#.######");
                   runone(parmuser, parmauthmech, parmscore, ref carryG, ref carryI, ref BF);
                   log("sms: BF=" + BF + " g=" + carryG + " i=" + carryI);

                   carryG = "1"; carryI = "1";
                   tb_output2.AppendText("\"" + raw.attvoice_score1 + "\",");
                   parmauthmech = 2;
                   parmscore = raw.attvoice_score1.ToString("#.######");
                   runone(parmuser, parmauthmech, parmscore, ref carryG, ref carryI, ref BF);
                   log("voice: BF=" + BF + " g=" + carryG + " i=" + carryI);

                   carryG = "1"; carryI = "1";
                   tb_output2.AppendText("\"" + raw.betaface_score1 + "\",");
                   parmauthmech = 3;
                   parmscore = raw.betaface_score1.ToString("#.######");
                   runone(parmuser, parmauthmech, parmscore, ref carryG, ref carryI, ref BF);
                   log("betaface: BF=" + BF + " g=" + carryG + " i=" + carryI);

                   carryG = "1"; carryI = "1";
                   tb_output2.AppendText("\"" + raw.knowledge_score + "\"");
                   parmauthmech = 4;
                   parmscore = raw.knowledge_score.ToString("#.######");
                   runone(parmuser, parmauthmech, parmscore, ref carryG, ref carryI, ref BF);
                   log("knoweldge: BF=" + BF + " g=" + carryG + " i=" + carryI);
               }


           }
       }


       private void runbatch2()
       {
           double carryg = 1.00;
           double carryi = 1.00;
           double bf = 0.00;
           double mi = 0.00;
           double si = 0.00;

           // works
           //postf(ref bf, 0.986401, 0.032671, 0.789121, 0.039206, 0.9876, ref carryg, ref carryi);
           //log("password: BF=" + bf.ToString() + " g=" + carryg.ToString() + " i=" + carryi.ToString());

           tb_log.Clear();


           log(" ");
           log("Authentication (login) Session data was collected in a previous step.  This data involves ");
           log("a known valid user proceeding through a combination of password, sms, voice, face, and ");
           log("knowledge authentication all together at once, to record a single 'session'.  This data");
           log("then becomes a mean and standard deviation for each individual mechanism.");
           log(" ");
           log("This report first shows a sampling of computed Bayes Factor for each mechanism event.");
           log(" ");
           log("We then take a sample from a single authentication session for all mechanisms ");
           log("and we show what a Bayes Factor computation would be for two mechanisms used in combination.");
           log("The first Bayes Factor Computation feeds in to the 'prior' of the second.  ");
           log(" ");
           log("At this time, we report on password plus each other mechanism, and voice plus each other ");
           log("mechanism as these have proven most exemplary for our particular collected data and are");
           log("so far the best examples for discussion.");
           log(" ");
           log("Finally, a sampling is run in conjunction with a threshold ratio and a risk environment.");
           log(" ");
           log("'Risk Cards' have been established which follow an NIST standard risk assessment");
           log("form for Software Vulnerability.  We apply this concept more generically to 'risk'");
           log("associated with the authentication process.  This portion demonstrates a combination");
           log("of authentication mechanisms, how they combine statistically to 'prove' the ");
           log("identity of the user, and how they do this in conjuction under varying risk conditions.");

           log(" ");
           log("Summary Report for selected users:");
           log(" ");
           foreach (string u in clb_Users.CheckedItems)
           {
               log("  " + u);
           }

           foreach (string parmuser in clb_Users.CheckedItems)
           {
               IEnumerable<class_rawauthsession> ieras = class_gather_sessionstats.GET_IEnumerable_User(parmuser);
               class_highlowsession hls = class_gather_sessionstats.GETHighLowMeanStdDev_User(parmuser);

               log(" ");
               log("Summary for User: " + parmuser);
               log(" ");
               log("Bayes Factor for Password Only:");
               mi = hls._pwmean * 0.8; si = hls._pwstddev * 1.2;
               log("mean: " + hls._pwmean.ToString() + " stddev: " + hls._pwstddev.ToString() + " imean: " + mi.ToString() + " istddev: " + si.ToString());
               log("----------------------------------------------------------------------------");
               foreach (class_rawauthsession raw in ieras)
               {
                   carryg = 1.00; carryi = 1.00;
                   postf(ref bf, hls._pwmean, hls._pwstddev, mi, si, raw.password_score, ref carryg, ref carryi);
                   if (!Double.IsNaN(bf))
                   {
                       log("BF=" + bf.ToString() + " score="+raw.password_score.ToString() + " g=" + carryg.ToString() + " i=" + carryi.ToString());
                   }
               }

               /* - the statistics come out useless for this auth mechanism
               log(" ");
               log("Bayes Factor for SMS Only, no Carry:");
               log("----------------------------------------------------------------------------");
               foreach (class_rawauthsession raw in ieras)
               {
                   mi = hls._smsmean * 0.8; si = hls._smsstddev * 1.2;
                   carryg = 1.00; carryi = 1.00;
                   postf(ref bf, hls._smsmean, hls._smsstddev, mi, si, raw.sms_score, ref carryg, ref carryi);
                   if (!Double.IsNaN(bf))
                   {
                       log("BF=" + bf.ToString() + " score=" + raw.sms_score.ToString() + " g=" + carryg.ToString() + " i=" + carryi.ToString());
                   }
               }

               log(" ");
               log("Bayes Factor for SMS Only, with Carry:");
               log("----------------------------------------------------------------------------");
               carryg = 1.00; carryi = 1.00;
               foreach (class_rawauthsession raw in ieras)
               {
                   mi = hls._smsmean * 0.8; si = hls._smsstddev * 1.2;
                   postf(ref bf, hls._smsmean, hls._smsstddev, mi, si, raw.sms_score, ref carryg, ref carryi);
                   if (!Double.IsNaN(bf))
                   {
                       log("BF=" + bf.ToString() + " score=" + raw.sms_score.ToString() + " g=" + carryg.ToString() + " i=" + carryi.ToString());
                   }
               }
               */

               log(" ");
               log("Bayes Factor for Voice Only:");
               mi = hls._attvoicemean * 0.8; si = hls._attvoicestddev * 1.2;
               log("mean: " + hls._attvoicemean.ToString() + " stddev: " + hls._attvoicestddev.ToString() + " imean: " + mi.ToString() + " istddev: " + si.ToString());
               log("----------------------------------------------------------------------------");
               foreach (class_rawauthsession raw in ieras)
               {
                   carryg = 1.00; carryi = 1.00;
                   //mi = -1.01; si = 1.01;
                   postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                   if (!Double.IsNaN(bf))
                   {
                       log("BF=" + bf.ToString() + " score=" + raw.attvoice_score1.ToString() + " g=" + carryg.ToString() + " i=" + carryi.ToString());
                   }
               }

               log(" ");
               log("Bayes Factor for betaface Only:");
               mi = hls._betafacemean * 0.8; si = hls._betafacestddev * 1.2;
               log("mean: " + hls._betafacemean.ToString() + " stddev: " + hls._betafacestddev.ToString() + " imean: " + mi.ToString() + " istddev: " + si.ToString());
               log("----------------------------------------------------------------------------");
               foreach (class_rawauthsession raw in ieras)
               {
                   carryg = 1.00; carryi = 1.00;
                   //mi = -1.01; si = 1.01;
                   postf(ref bf, hls._betafacemean, hls._betafacestddev, mi, si, raw.betaface_score1, ref carryg, ref carryi);
                   log("BF=" + bf.ToString() + " score=" + raw.betaface_score1.ToString() + " g=" + carryg.ToString() + " i=" + carryi.ToString());
               }

               log(" ");
               log("Bayes Factor for Knowledge Only:");
               mi = hls._knowledgemean * 0.8; si = hls._knowledgestddev * 1.2;
               log("mean: " + hls._knowledgemean.ToString() + " stddev: " + hls._knowledgestddev.ToString() + " imean: " + mi.ToString() + " istddev: " + si.ToString());
               log("----------------------------------------------------------------------------");
               foreach (class_rawauthsession raw in ieras)
               {
                   carryg = 1.00; carryi = 1.00;
                   //mi = -1.01; si = 1.01;
                   postf(ref bf, hls._knowledgemean, hls._knowledgestddev, mi, si, raw.knowledge_score, ref carryg, ref carryi);
                   if (!Double.IsNaN(bf))
                   {
                       log("BF=" + bf.ToString() + " score=" + raw.knowledge_score.ToString() + " g=" + carryg.ToString() + " i=" + carryi.ToString());
                   }
               }

               // TAKE 5 to 10 from whatever the list of 0 to x
               // Password + Additional Authenticator
               int starttake = 5;
               int endtake = 5;
               int counter = 0;
               foreach (class_rawauthsession raw2 in ieras)
               {
                   counter++;

                   if ((counter >= starttake) && (counter <= endtake))
                   {

                       log(" ");
                       log("Password + Additional Authenticator:");
                       log("----------------------------------------------------------------------------");
                       carryg = 1.00; carryi = 1.00;
                       mi = hls._pwmean * 0.8; si = hls._pwstddev * 1.2;
                       postf(ref bf, hls._pwmean, hls._pwstddev, mi, si, raw2.password_score, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf))
                       {
                           log("Password Only: BF=" + bf.ToString() + " score=" + raw2.password_score.ToString() + " g=" + carryg.ToString() + " i=" + carryi.ToString());
                       }

                       double startg = carryg;
                       double starti = carryi;

                       foreach (class_rawauthsession raw in ieras)
                       {
                           mi = hls._smsmean * 0.8; si = hls._smsstddev * 1.2;
                           carryg = startg; carryi = starti;
                           postf(ref bf, hls._smsmean, hls._smsstddev, mi, si, raw.sms_score, ref carryg, ref carryi);
                           if (!Double.IsNaN(bf))
                           {
                               log("  password + SMS: BF=" + bf.ToString() + " score=" + raw.sms_score.ToString() + " g=" + carryg.ToString() + " i=" + carryi.ToString());
                           }
                       }
                       foreach (class_rawauthsession raw in ieras)
                       {
                           mi = hls._attvoicemean * 0.8; si = hls._attvoicestddev * 1.2;
                           carryg = startg; carryi = starti;
                           postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                           if (!Double.IsNaN(bf))
                           {
                               log("  password + voice: BF=" + bf.ToString() + " score=" + raw.attvoice_score1.ToString() + " g=" + carryg.ToString() + " i=" + carryi.ToString());
                           }
                       }

                       foreach (class_rawauthsession raw in ieras)
                       {
                           mi = hls._betafacemean * 0.8; si = hls._betafacestddev * 1.2;
                           carryg = startg; carryi = starti;
                           postf(ref bf, hls._betafacemean, hls._betafacestddev, mi, si, raw.betaface_score1, ref carryg, ref carryi);
                           if (!Double.IsNaN(bf))
                           {
                               log("  password + betaface: BF=" + bf.ToString() + " score=" + raw.betaface_score1.ToString() + " g=" + carryg.ToString() + " i=" + carryi.ToString());
                           }
                       }

                       foreach (class_rawauthsession raw in ieras)
                       {
                           mi = hls._knowledgemean * 0.8; si = hls._knowledgestddev * 1.2;
                           carryg = startg; carryi = starti;
                           postf(ref bf, hls._knowledgemean, hls._knowledgestddev, mi, si, raw.knowledge_score, ref carryg, ref carryi);
                           if (!Double.IsNaN(bf))
                           {
                               log("  password + knowledge: BF=" + bf.ToString() + " score=" + raw.knowledge_score.ToString() + " g=" + carryg.ToString() + " i=" + carryi.ToString());
                           }
                       }
                   } // take range
               }


               counter = 0;
               // Voice + Additional Authenticator
               foreach (class_rawauthsession raw2 in ieras)
               {
                   counter++;
                   if ((counter >= starttake) && (counter <= endtake))
                   {

                       log(" ");
                       log("Voice + Additional Authenticator:");
                       log("----------------------------------------------------------------------------");
                       carryg = 1.00; carryi = 1.00;
                       mi = hls._attvoicemean * 0.8; si = hls._attvoicestddev * 1.2;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw2.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf))
                       {
                           log("Voice Only: BF=" + bf.ToString() + " score=" + raw2.attvoice_score1.ToString() + " g=" + carryg.ToString() + " i=" + carryi.ToString());
                       }

                       double startg = carryg;
                       double starti = carryi;

                       foreach (class_rawauthsession raw in ieras)
                       {
                           mi = hls._pwmean * 0.8; si = hls._pwstddev * 1.2;
                           carryg = startg; carryi = starti;
                           postf(ref bf, hls._pwmean, hls._pwstddev, mi, si, raw2.password_score, ref carryg, ref carryi);
                           if (!Double.IsNaN(bf))
                           {
                               log("  Voice + Password: BF=" + bf.ToString() + " score=" + raw2.password_score.ToString() + " g=" + carryg.ToString() + " i=" + carryi.ToString());
                           }
                       }

                       foreach (class_rawauthsession raw in ieras)
                       {
                           mi = hls._smsmean * 0.8; si = hls._smsstddev * 1.2;
                           carryg = startg; carryi = starti;
                           postf(ref bf, hls._smsmean, hls._smsstddev, mi, si, raw.sms_score, ref carryg, ref carryi);
                           if (!Double.IsNaN(bf))
                           {
                               log("  voice + SMS: BF=" + bf.ToString() + " score=" + raw.sms_score.ToString() + " g=" + carryg.ToString() + " i=" + carryi.ToString());
                           }
                       }

                       foreach (class_rawauthsession raw in ieras)
                       {
                           mi = hls._betafacemean * 0.8; si = hls._betafacestddev * 1.2;
                           carryg = startg; carryi = starti;
                           postf(ref bf, hls._betafacemean, hls._betafacestddev, mi, si, raw.betaface_score1, ref carryg, ref carryi);
                           if (!Double.IsNaN(bf))
                           {
                               log("  voice + betaface: BF=" + bf.ToString() + " score=" + raw.betaface_score1.ToString() + " g=" + carryg.ToString() + " i=" + carryi.ToString());
                           }
                       }

                       foreach (class_rawauthsession raw in ieras)
                       {
                           mi = hls._knowledgemean * 0.8; si = hls._knowledgestddev * 1.2;
                           carryg = startg; carryi = starti;
                           postf(ref bf, hls._knowledgemean, hls._knowledgestddev, mi, si, raw.knowledge_score, ref carryg, ref carryi);
                           if (!Double.IsNaN(bf))
                           {
                               log("  voice + knowledge: BF=" + bf.ToString() + " score=" + raw.knowledge_score.ToString() + " g=" + carryg.ToString() + " i=" + carryi.ToString());
                           }
                       }
                   } // take range
               }


               counter = 0;
               // Voice + Additional Authenticator - WHAT WOULD IMPOSTOR BF BE ?
               foreach (class_rawauthsession raw2 in ieras)
               {
                   counter++;
                   if ((counter >= starttake) && (counter <= endtake))
                   {

                       log(" ");
                       log("Voice + Additional Authenticator ( IMPOSTOR BF WOULD BE... ):");
                       log("----------------------------------------------------------------------------");
                       carryg = 1.00; carryi = 1.00;
                       mi = hls._attvoicemean * 0.8; si = hls._attvoicestddev * 1.2;
                       postfi(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw2.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf))
                       {
                           log("Voice Only: BF=" + bf.ToString() + " score=" + raw2.attvoice_score1.ToString() + " g=" + carryg.ToString() + " i=" + carryi.ToString());
                       }

                       double startg = carryg;
                       double starti = carryi;

                       foreach (class_rawauthsession raw in ieras)
                       {
                           mi = hls._pwmean * 0.8; si = hls._pwstddev * 1.2;
                           carryg = startg; carryi = starti;
                           postfi(ref bf, hls._pwmean, hls._pwstddev, mi, si, raw2.password_score, ref carryg, ref carryi);
                           if (!Double.IsNaN(bf))
                           {
                               log("  Voice + Password: BF=" + bf.ToString() + " score=" + raw2.password_score.ToString() + " g=" + carryg.ToString() + " i=" + carryi.ToString());
                           }
                       }

                       foreach (class_rawauthsession raw in ieras)
                       {
                           mi = hls._smsmean * 0.8; si = hls._smsstddev * 1.2;
                           carryg = startg; carryi = starti;
                           postfi(ref bf, hls._smsmean, hls._smsstddev, mi, si, raw.sms_score, ref carryg, ref carryi);
                           if (!Double.IsNaN(bf))
                           {
                               log("  voice + SMS: BF=" + bf.ToString() + " score=" + raw.sms_score.ToString() + " g=" + carryg.ToString() + " i=" + carryi.ToString());
                           }
                       }

                       foreach (class_rawauthsession raw in ieras)
                       {
                           mi = hls._betafacemean * 0.8; si = hls._betafacestddev * 1.2;
                           carryg = startg; carryi = starti;
                           postfi(ref bf, hls._betafacemean, hls._betafacestddev, mi, si, raw.betaface_score1, ref carryg, ref carryi);
                           if (!Double.IsNaN(bf))
                           {
                               log("  voice + betaface: BF=" + bf.ToString() + " score=" + raw.betaface_score1.ToString() + " g=" + carryg.ToString() + " i=" + carryi.ToString());
                           }
                       }

                       foreach (class_rawauthsession raw in ieras)
                       {
                           mi = hls._knowledgemean * 0.8; si = hls._knowledgestddev * 1.2;
                           carryg = startg; carryi = starti;
                           postfi(ref bf, hls._knowledgemean, hls._knowledgestddev, mi, si, raw.knowledge_score, ref carryg, ref carryi);
                           if (!Double.IsNaN(bf))
                           {
                               log("  voice + knowledge: BF=" + bf.ToString() + " score=" + raw.knowledge_score.ToString() + " g=" + carryg.ToString() + " i=" + carryi.ToString());
                           }
                       }
                   } // take range
               }



               log(" ");
               log("Vary the priors and observe the effect on BF, PostG, PostI for Voice.");
               log("Explore to what degree the setting of priors initially can be used");
               log("to modulate the 'risk' environment using the current simple method. ");
               log("---------------------------------------------------------------------");
               int takestart = 10;
               int takeend = 14;
               mi = hls._attvoicemean * 0.8; si = hls._attvoicestddev * 1.2;
               counter = 0;
               double pg = 0.00;
               double pi = 0.00;

               foreach (class_rawauthsession raw in ieras)
               {
                   counter++;
                   if ((counter >= takestart) && (counter <= takeend))
                   {
                   
                       pg = 1.00; pi = 1.00; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("  BF=" + bf.ToString() + " score=" + raw.attvoice_score1.ToString() + " priorg=" + pg.ToString("0.00########") + " priori=" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + " posti=" + carryi.ToString("0.00########")); }

                       pg = 0.75; pi = 1.00; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("  BF=" + bf.ToString() + " score=" + raw.attvoice_score1.ToString() + " priorg=" + pg.ToString("0.00########") + " priori=" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + " posti=" + carryi.ToString("0.00########")); }

                       pg = 0.50; pi = 1.00; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("  BF=" + bf.ToString() + " score=" + raw.attvoice_score1.ToString() + " priorg=" + pg.ToString("0.00########") + " priori=" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + " posti=" + carryi.ToString("0.00########")); }

                       pg = 0.25; pi = 1.00; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("  BF=" + bf.ToString() + " score=" + raw.attvoice_score1.ToString() + " priorg=" + pg.ToString("0.00########") + " priori=" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + " posti=" + carryi.ToString("0.00########")); }

                       pg = 0.00; pi = 1.00; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("  BF=" + bf.ToString() + " score=" + raw.attvoice_score1.ToString() + " priorg=" + pg.ToString("0.00########") + " priori=" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + " posti=" + carryi.ToString("0.00########")); }

                       pg = -0.25; pi = 1.00; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("  BF=" + bf.ToString() + " score=" + raw.attvoice_score1.ToString() + " priorg=" + pg.ToString("0.00########") + " priori=" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + " posti=" + carryi.ToString("0.00########")); }

                       pg = -0.50; pi = 1.00; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("  BF=" + bf.ToString() + " score=" + raw.attvoice_score1.ToString() + " priorg=" + pg.ToString("0.00########") + " priori=" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + " posti=" + carryi.ToString("0.00########")); }

                       pg = -0.75; pi = 1.00; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("  BF=" + bf.ToString() + " score=" + raw.attvoice_score1.ToString() + " priorg=" + pg.ToString("0.00########") + " priori=" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + " posti=" + carryi.ToString("0.00########")); }

                       pg = -1.00; pi = 1.00; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("  BF=" + bf.ToString() + " score=" + raw.attvoice_score1.ToString() + " priorg=" + pg.ToString("0.00########") + " priori=" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + " posti=" + carryi.ToString("0.00########")); }


                       pg = 1.00; pi = 0.75; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("  BF=" + bf.ToString() + " score=" + raw.attvoice_score1.ToString() + " priorg=" + pg.ToString("0.00########") + " priori=" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + " posti=" + carryi.ToString("0.00########")); }

                       pg = 1.00; pi = 0.50; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("  BF=" + bf.ToString() + " score=" + raw.attvoice_score1.ToString() + " priorg=" + pg.ToString("0.00########") + " priori=" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + " posti=" + carryi.ToString("0.00########")); }

                       pg = 1.00; pi = 0.25; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("  BF=" + bf.ToString() + " score=" + raw.attvoice_score1.ToString() + " priorg=" + pg.ToString("0.00########") + " priori=" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + " posti=" + carryi.ToString("0.00########")); }

                       pg = 1.00; pi = 0.00; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("  BF=" + bf.ToString() + " score=" + raw.attvoice_score1.ToString() + " priorg=" + pg.ToString("0.00########") + " priori=" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + " posti=" + carryi.ToString("0.00########")); }

                       pg = 1.00; pi = -0.25; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("  BF=" + bf.ToString() + " score=" + raw.attvoice_score1.ToString() + " priorg=" + pg.ToString("0.00########") + " priori=" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + " posti=" + carryi.ToString("0.00########")); }

                       pg = 1.00; pi = -0.50; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("  BF=" + bf.ToString() + " score=" + raw.attvoice_score1.ToString() + " priorg=" + pg.ToString("0.00########") + " priori=" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + " posti=" + carryi.ToString("0.00########")); }

                       pg = 1.00; pi = -0.75; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("  BF=" + bf.ToString() + " score=" + raw.attvoice_score1.ToString() + " priorg=" + pg.ToString("0.00########") + " priori=" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + " posti=" + carryi.ToString("0.00########")); }

                       pg = 1.00; pi = -1.00; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("  BF=" + bf.ToString() + " score=" + raw.attvoice_score1.ToString() + " priorg=" + pg.ToString("0.00########") + " priori=" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + " posti=" + carryi.ToString("0.00########")); }
                   }
               }
               /*
                 BF=1034293.06926445 score=0.99431497 priorg=1.00 priori=1.00 postg=11.8576947399 posti=0.0000114645
                 BF=775719.801948334 score=0.99431497 priorg=0.75 priori=1.00 postg=8.8932710549 posti=0.0000114645
                 BF=517146.534632223 score=0.99431497 priorg=0.50 priori=1.00 postg=5.9288473699 posti=0.0000114645
                 BF=258573.267316111 score=0.99431497 priorg=0.25 priori=1.00 postg=2.964423685 posti=0.0000114645
                 BF=0 score=0.99431497 priorg=0.00 priori=1.00 postg=0.00 posti=0.0000114645
                 BF=-258573.267316111 score=0.99431497 priorg=-0.25 priori=1.00 postg=-2.964423685 posti=0.0000114645
                 BF=-517146.534632223 score=0.99431497 priorg=-0.50 priori=1.00 postg=-5.9288473699 posti=0.0000114645
                 BF=-775719.801948334 score=0.99431497 priorg=-0.75 priori=1.00 postg=-8.8932710549 posti=0.0000114645
                 BF=-1034293.06926445 score=0.99431497 priorg=-1.00 priori=1.00 postg=-11.8576947399 posti=0.0000114645 */
               log("- - - - - - - - -");
               log("Where an Impostor may typically score a Bayes Factor on a scale from 0 to 10 ( appx ), adjusting");
               log("the initial priors to establish a risk environment ( weighting ) is currently too coarse");
               log("and any setting would either not have a significant effect, or too much of an effect.");
               log("- - - - - - - - -");

               log(" ");
               log("So far:");
               log(" - raw data, if outliers are trimmed off, will appear generally as the above data");
               log("   - that is, an Impostor can achieve BF on an order of < 100 ( usually < 10 )");
               log("     while a genuine will achieve BF typically ranging 300 -> Infinity");
               log(" - in the current formulation, the priors are too coarse to modulate risk environment");
               log("   without high precision analysis on a user by user basis.");
              
           }
       }


       private void runbatch3()  // Runbatch2 in CSV
       {
           double carryg = 1.00;
           double carryi = 1.00;
           double bf = 0.00;
           double mi = 0.00;
           double si = 0.00;

           // works
           //postf(ref bf, 0.986401, 0.032671, 0.789121, 0.039206, 0.9876, ref carryg, ref carryi);
           //log("password: BF=" + bf.ToString() + " g=" + carryg.ToString() + " i=" + carryi.ToString());

           tb_log.Clear();

           log("\"Summary Report for selected users:\"");
           foreach (string u in clb_Users.CheckedItems)
           {
               log("  \"" + u + "\"");
           }

           foreach (string parmuser in clb_Users.CheckedItems)
           {
               IEnumerable<class_rawauthsession> ieras = class_gather_sessionstats.GET_IEnumerable_User(parmuser);
               class_highlowsession hls = class_gather_sessionstats.GETHighLowMeanStdDev_User(parmuser);

               log("\"Summary for User: " + parmuser + "\"");
               log("\"Bayes Factor for Password Only:\"");
               mi = hls._pwmean * 0.8; si = hls._pwstddev * 1.2;
               log("\"mean\", \"stddev\", \"imean\", \"istddev\"");
               log("\"" + hls._pwmean.ToString() + "\",\"" + hls._pwstddev.ToString() + "\",\"" + mi.ToString() + "\",\"" + si.ToString()+"\"");

               log("\"BF\",\"Score\",\"g\",\"i\"");
               foreach (class_rawauthsession raw in ieras)
               {
                   carryg = 1.00; carryi = 1.00;
                   postf(ref bf, hls._pwmean, hls._pwstddev, mi, si, raw.password_score, ref carryg, ref carryi);
                   if (!Double.IsNaN(bf))
                   {
                       log("\"" + bf.ToString() + "\",\"" + raw.password_score.ToString() + "\",\"" + carryg.ToString() + "\",\"" + carryi.ToString()+"\"");
                   }
               }

               log("\"Bayes Factor for Voice Only:\"");
               mi = hls._attvoicemean * 0.8; si = hls._attvoicestddev * 1.2;
               log("\"mean\",\"stddev\",\"imean\",\"istddev\"");
               log("\"" + hls._attvoicemean.ToString() + "\",\"" + hls._attvoicestddev.ToString() + "\",\"" + mi.ToString() + "\",\"" + si.ToString()+"\"");
               log("\"BF\",\"Score\",\"g\",\"i\"");
               foreach (class_rawauthsession raw in ieras)
               {
                   carryg = 1.00; carryi = 1.00;
                   //mi = -1.01; si = 1.01;
                   postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                   if (!Double.IsNaN(bf))
                   {
                       log("\"" + bf.ToString() + "\",\"" + raw.attvoice_score1.ToString() + "\",\"" + carryg.ToString() + "\",\"" + carryi.ToString()+"\"");
                   }
               }

               log("\"Bayes Factor for betaface Only:\"");
               mi = hls._betafacemean * 0.8; si = hls._betafacestddev * 1.2;
               log("\"mean\",\"stddev\",\"imean\",\"istddev\"");
               log("\"" + hls._betafacemean.ToString() + "\",\"" + hls._betafacestddev.ToString() + "\",\"" + mi.ToString() + "\",\"" + si.ToString()+"\"");
               log("\"BF\",\"Score\",\"g\",\"i\"");
               foreach (class_rawauthsession raw in ieras)
               {
                   carryg = 1.00; carryi = 1.00;
                   //mi = -1.01; si = 1.01;
                   postf(ref bf, hls._betafacemean, hls._betafacestddev, mi, si, raw.betaface_score1, ref carryg, ref carryi);
                   log("\"" + bf.ToString() + "\",\"" + raw.betaface_score1.ToString() + "\",\"" + carryg.ToString() + "\",\"" + carryi.ToString()+"\"");
               }

               log("\"Bayes Factor for Knowledge Only:\"");
               mi = hls._knowledgemean * 0.8; si = hls._knowledgestddev * 1.2;
               log("\"mean\",\"stddev\",\"imean\",\"istddev\"");
               log("\"" + hls._knowledgemean.ToString() + "\",\"" + hls._knowledgestddev.ToString() + "\",\"" + mi.ToString() + "\",\"" + si.ToString()+"\"");
               log("\"BF\",\"Score\",\"g\",\"i\"");
               foreach (class_rawauthsession raw in ieras)
               {
                   carryg = 1.00; carryi = 1.00;
                   //mi = -1.01; si = 1.01;
                   postf(ref bf, hls._knowledgemean, hls._knowledgestddev, mi, si, raw.knowledge_score, ref carryg, ref carryi);
                   if (!Double.IsNaN(bf))
                   {
                       log("\"" + bf.ToString() + "\",\"" + raw.knowledge_score.ToString() + "\",\"" + carryg.ToString() + "\",\"" + carryi.ToString()+"\"");
                   }
               }

               // TAKE 5 to 10 from whatever the list of 0 to x
               // Password + Additional Authenticator
               int starttake = 5;
               int endtake = 5;
               int counter = 0;
               foreach (class_rawauthsession raw2 in ieras)
               {
                   counter++;

                   if ((counter >= starttake) && (counter <= endtake))
                   {

                       log("\"Password + Additional Authenticator, first line is PW only\"");
                       carryg = 1.00; carryi = 1.00;
                       mi = hls._pwmean * 0.8; si = hls._pwstddev * 1.2;
                       postf(ref bf, hls._pwmean, hls._pwstddev, mi, si, raw2.password_score, ref carryg, ref carryi);
                       log("\"Mechanism\",\"BF\",\"Score\",\"g\",\"i\"");
                       if (!Double.IsNaN(bf))
                       {
                           log("\"PW Only\",\"" + bf.ToString() + "\",\"" + raw2.password_score.ToString() + "\",\"" + carryg.ToString() + "\",\"" + carryi.ToString()+"\"");
                       }

                       double startg = carryg;
                       double starti = carryi;

                       foreach (class_rawauthsession raw in ieras)
                       {
                           mi = hls._smsmean * 0.8; si = hls._smsstddev * 1.2;
                           carryg = startg; carryi = starti;
                           postf(ref bf, hls._smsmean, hls._smsstddev, mi, si, raw.sms_score, ref carryg, ref carryi);
                           if (!Double.IsNaN(bf))
                           {
                               log("\"password + SMS\",\"" + bf.ToString() + "\",\"" + raw.sms_score.ToString() + "\",\"" + carryg.ToString() + "\",\"" + carryi.ToString()+"\"");
                           }
                       }
                       foreach (class_rawauthsession raw in ieras)
                       {
                           mi = hls._attvoicemean * 0.8; si = hls._attvoicestddev * 1.2;
                           carryg = startg; carryi = starti;
                           postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                           if (!Double.IsNaN(bf))
                           {
                               log("\"password + voice\",\"" + bf.ToString() + "\",\"" + raw.attvoice_score1.ToString() + "\",\"" + carryg.ToString() + "\",\"" + carryi.ToString());
                           }
                       }

                       foreach (class_rawauthsession raw in ieras)
                       {
                           mi = hls._betafacemean * 0.8; si = hls._betafacestddev * 1.2;
                           carryg = startg; carryi = starti;
                           postf(ref bf, hls._betafacemean, hls._betafacestddev, mi, si, raw.betaface_score1, ref carryg, ref carryi);
                           if (!Double.IsNaN(bf))
                           {
                               log("\"password + betaface\",\"" + bf.ToString() + "\",\"" + raw.betaface_score1.ToString() + "\",\"" + carryg.ToString() + " i=" + carryi.ToString()+"\"");
                           }
                       }

                       foreach (class_rawauthsession raw in ieras)
                       {
                           mi = hls._knowledgemean * 0.8; si = hls._knowledgestddev * 1.2;
                           carryg = startg; carryi = starti;
                           postf(ref bf, hls._knowledgemean, hls._knowledgestddev, mi, si, raw.knowledge_score, ref carryg, ref carryi);
                           if (!Double.IsNaN(bf))
                           {
                               log("\"password + knowledge\",\"" + bf.ToString() + "\",\"" + raw.knowledge_score.ToString() + "\",\"" + carryg.ToString() + " i=" + carryi.ToString()+"\"");
                           }
                       }
                   } // take range
               }


               counter = 0;
               // Voice + Additional Authenticator
               foreach (class_rawauthsession raw2 in ieras)
               {
                   counter++;
                   if ((counter >= starttake) && (counter <= endtake))
                   {

                       log("\"Voice + Additional Authenticator\"");
                       carryg = 1.00; carryi = 1.00;
                       mi = hls._attvoicemean * 0.8; si = hls._attvoicestddev * 1.2;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw2.attvoice_score1, ref carryg, ref carryi);
                       log("\"Mechanism\",\"BF\",\"Score\",\"g\",\"i\"");
                       if (!Double.IsNaN(bf))
                       {
                           log("\"Voice Only\",\"" + bf.ToString() + "\",\"" + raw2.attvoice_score1.ToString() + "\",\"" + carryg.ToString() + "\",\"" + carryi.ToString()+"\"");
                       }

                       double startg = carryg;
                       double starti = carryi;

                       foreach (class_rawauthsession raw in ieras)
                       {
                           mi = hls._pwmean * 0.8; si = hls._pwstddev * 1.2;
                           carryg = startg; carryi = starti;
                           postf(ref bf, hls._pwmean, hls._pwstddev, mi, si, raw2.password_score, ref carryg, ref carryi);
                           if (!Double.IsNaN(bf))
                           {
                               log("\"Voice + Password\",\"" + bf.ToString() + "\",\"" + raw2.password_score.ToString() + "\",\"" + carryg.ToString() + "\",\"" + carryi.ToString()+"\"");
                           }
                       }

                       foreach (class_rawauthsession raw in ieras)
                       {
                           mi = hls._smsmean * 0.8; si = hls._smsstddev * 1.2;
                           carryg = startg; carryi = starti;
                           postf(ref bf, hls._smsmean, hls._smsstddev, mi, si, raw.sms_score, ref carryg, ref carryi);
                           if (!Double.IsNaN(bf))
                           {
                               log("\"voice + SMS\",\"" + bf.ToString() + "\",\"" + raw.sms_score.ToString() + "\",\"" + carryg.ToString() + "\",\"" + carryi.ToString()+"\"");
                           }
                       }

                       foreach (class_rawauthsession raw in ieras)
                       {
                           mi = hls._betafacemean * 0.8; si = hls._betafacestddev * 1.2;
                           carryg = startg; carryi = starti;
                           postf(ref bf, hls._betafacemean, hls._betafacestddev, mi, si, raw.betaface_score1, ref carryg, ref carryi);
                           if (!Double.IsNaN(bf))
                           {
                               log("\"voice + betaface\",\"" + bf.ToString() + "\",\"" + raw.betaface_score1.ToString() + "\",\"" + carryg.ToString() + "\",\"" + carryi.ToString()+"\"");
                           }
                       }

                       foreach (class_rawauthsession raw in ieras)
                       {
                           mi = hls._knowledgemean * 0.8; si = hls._knowledgestddev * 1.2;
                           carryg = startg; carryi = starti;
                           postf(ref bf, hls._knowledgemean, hls._knowledgestddev, mi, si, raw.knowledge_score, ref carryg, ref carryi);
                           if (!Double.IsNaN(bf))
                           {
                               log("\"voice + knowledge\",\"" + bf.ToString() + "\",\"" + raw.knowledge_score.ToString() + "\",\"" + carryg.ToString() + "\",\"" + carryi.ToString()+"\"");
                           }
                       }
                   } // take range
               }


               counter = 0;
               // Voice + Additional Authenticator - WHAT WOULD IMPOSTOR BF BE ?
               foreach (class_rawauthsession raw2 in ieras)
               {
                   counter++;
                   if ((counter >= starttake) && (counter <= endtake))
                   {
                       log("\"Voice + Additional Authenticator ( IMPOSTOR BF WOULD BE... ):\"");
                       carryg = 1.00; carryi = 1.00;
                       mi = hls._attvoicemean * 0.8; si = hls._attvoicestddev * 1.2;
                       postfi(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw2.attvoice_score1, ref carryg, ref carryi);
                       log("\"Mechanism\",\"BF\",\"Score\",\"g\",\"i\"");
                       if (!Double.IsNaN(bf))
                       {
                           log("\"Voice Only\",\"" + bf.ToString() + "\",\"" + raw2.attvoice_score1.ToString() + "\",\"" + carryg.ToString() + "\",\"" + carryi.ToString()+"\"");
                       }

                       double startg = carryg;
                       double starti = carryi;

                       foreach (class_rawauthsession raw in ieras)
                       {
                           mi = hls._pwmean * 0.8; si = hls._pwstddev * 1.2;
                           carryg = startg; carryi = starti;
                           postfi(ref bf, hls._pwmean, hls._pwstddev, mi, si, raw2.password_score, ref carryg, ref carryi);
                           if (!Double.IsNaN(bf))
                           {
                               log("\"Voice + Password\",\"" + bf.ToString() + "\",\"" + raw2.password_score.ToString() + "\",\"" + carryg.ToString() + "\",\"" + carryi.ToString()+"\"");
                           }
                       }

                       foreach (class_rawauthsession raw in ieras)
                       {
                           mi = hls._smsmean * 0.8; si = hls._smsstddev * 1.2;
                           carryg = startg; carryi = starti;
                           postfi(ref bf, hls._smsmean, hls._smsstddev, mi, si, raw.sms_score, ref carryg, ref carryi);
                           if (!Double.IsNaN(bf))
                           {
                               log("\"voice + SMS\",\"" + bf.ToString() + "\",\"" + raw.sms_score.ToString() + "\",\"" + carryg.ToString() + "\",\"" + carryi.ToString()+"\"");
                           }
                       }

                       foreach (class_rawauthsession raw in ieras)
                       {
                           mi = hls._betafacemean * 0.8; si = hls._betafacestddev * 1.2;
                           carryg = startg; carryi = starti;
                           postfi(ref bf, hls._betafacemean, hls._betafacestddev, mi, si, raw.betaface_score1, ref carryg, ref carryi);
                           if (!Double.IsNaN(bf))
                           {
                               log("\"voice + betaface\",\"" + bf.ToString() + "\",\"" + raw.betaface_score1.ToString() + "\",\"" + carryg.ToString() + "\",\"" + carryi.ToString()+"\"");
                           }
                       }

                       foreach (class_rawauthsession raw in ieras)
                       {
                           mi = hls._knowledgemean * 0.8; si = hls._knowledgestddev * 1.2;
                           carryg = startg; carryi = starti;
                           postfi(ref bf, hls._knowledgemean, hls._knowledgestddev, mi, si, raw.knowledge_score, ref carryg, ref carryi);
                           if (!Double.IsNaN(bf))
                           {
                               log("\"voice + knowledge\",\"" + bf.ToString() + "\",\"" + raw.knowledge_score.ToString() + "\",\"" + carryg.ToString() + "\",\"" + carryi.ToString()+"\"");
                           }
                       }
                   } // take range
               }


               log("\"Vary the priors and observe the effect on BF, PostG, PostI for Voice.\"");
               log("\"Explore to what degree the setting of priors initially can be used\"");
               log("\"to modulate the 'risk' environment using the current simple method.\"");
               int takestart = 10;
               int takeend = 14;
               mi = hls._attvoicemean * 0.8; si = hls._attvoicestddev * 1.2;
               counter = 0;
               double pg = 0.00;
               double pi = 0.00;

               log("\"BF\",\"score\",\"g\",\"i\",\"carryg\",\"carryi\"");
               foreach (class_rawauthsession raw in ieras)
               {
                   counter++;
                   if ((counter >= takestart) && (counter <= takeend))
                   {

                       pg = 1.00; pi = 1.00; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("\"" + bf.ToString() + "\",\"" + raw.attvoice_score1.ToString() + "\",\"" + pg.ToString("0.00########") + "\",\"" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + "\",\"" + carryi.ToString("0.00########")+"\""); }

                       pg = 0.75; pi = 1.00; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("  BF=" + bf.ToString() + " score=" + raw.attvoice_score1.ToString() + " priorg=" + pg.ToString("0.00########") + " priori=" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + " posti=" + carryi.ToString("0.00########")); }

                       pg = 0.50; pi = 1.00; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("\"" + bf.ToString() + "\",\"" + raw.attvoice_score1.ToString() + "\",\"" + pg.ToString("0.00########") + "\",\"" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + "\",\"" + carryi.ToString("0.00########") + "\""); }

                       pg = 0.25; pi = 1.00; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("\"" + bf.ToString() + "\",\"" + raw.attvoice_score1.ToString() + "\",\"" + pg.ToString("0.00########") + "\",\"" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + "\",\"" + carryi.ToString("0.00########") + "\""); }

                       pg = 0.00; pi = 1.00; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("\"" + bf.ToString() + "\",\"" + raw.attvoice_score1.ToString() + "\",\"" + pg.ToString("0.00########") + "\",\"" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + "\",\"" + carryi.ToString("0.00########") + "\""); }

                       pg = -0.25; pi = 1.00; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("\"" + bf.ToString() + "\",\"" + raw.attvoice_score1.ToString() + "\",\"" + pg.ToString("0.00########") + "\",\"" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + "\",\"" + carryi.ToString("0.00########") + "\""); }

                       pg = -0.50; pi = 1.00; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("\"" + bf.ToString() + "\",\"" + raw.attvoice_score1.ToString() + "\",\"" + pg.ToString("0.00########") + "\",\"" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + "\",\"" + carryi.ToString("0.00########") + "\""); }

                       pg = -0.75; pi = 1.00; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("\"" + bf.ToString() + "\",\"" + raw.attvoice_score1.ToString() + "\",\"" + pg.ToString("0.00########") + "\",\"" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + "\",\"" + carryi.ToString("0.00########") + "\""); }

                       pg = -1.00; pi = 1.00; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("\"" + bf.ToString() + "\",\"" + raw.attvoice_score1.ToString() + "\",\"" + pg.ToString("0.00########") + "\",\"" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + "\",\"" + carryi.ToString("0.00########") + "\""); }


                       pg = 1.00; pi = 0.75; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("\"" + bf.ToString() + "\",\"" + raw.attvoice_score1.ToString() + "\",\"" + pg.ToString("0.00########") + "\",\"" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + "\",\"" + carryi.ToString("0.00########") + "\""); }

                       pg = 1.00; pi = 0.50; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("\"" + bf.ToString() + "\",\"" + raw.attvoice_score1.ToString() + "\",\"" + pg.ToString("0.00########") + "\",\"" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + "\",\"" + carryi.ToString("0.00########") + "\""); }

                       pg = 1.00; pi = 0.25; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("\"" + bf.ToString() + "\",\"" + raw.attvoice_score1.ToString() + "\",\"" + pg.ToString("0.00########") + "\",\"" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + "\",\"" + carryi.ToString("0.00########") + "\""); }

                       pg = 1.00; pi = 0.00; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("\"" + bf.ToString() + "\",\"" + raw.attvoice_score1.ToString() + "\",\"" + pg.ToString("0.00########") + "\",\"" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + "\",\"" + carryi.ToString("0.00########") + "\""); }

                       pg = 1.00; pi = -0.25; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("\"" + bf.ToString() + "\",\"" + raw.attvoice_score1.ToString() + "\",\"" + pg.ToString("0.00########") + "\",\"" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + "\",\"" + carryi.ToString("0.00########") + "\""); }

                       pg = 1.00; pi = -0.50; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("\"" + bf.ToString() + "\",\"" + raw.attvoice_score1.ToString() + "\",\"" + pg.ToString("0.00########") + "\",\"" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + "\",\"" + carryi.ToString("0.00########") + "\""); }

                       pg = 1.00; pi = -0.75; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("\"" + bf.ToString() + "\",\"" + raw.attvoice_score1.ToString() + "\",\"" + pg.ToString("0.00########") + "\",\"" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + "\",\"" + carryi.ToString("0.00########") + "\""); }

                       pg = 1.00; pi = -1.00; carryg = pg; carryi = pi;
                       postf(ref bf, hls._attvoicemean, hls._attvoicestddev, mi, si, raw.attvoice_score1, ref carryg, ref carryi);
                       if (!Double.IsNaN(bf)) { log("\"" + bf.ToString() + "\",\"" + raw.attvoice_score1.ToString() + "\",\"" + pg.ToString("0.00########") + "\",\"" + pi.ToString("0.00########") + " postg=" + carryg.ToString("0.00########") + "\",\"" + carryi.ToString("0.00########") + "\""); }
                   }
               }
           }
       }

       private void button1_Click(object sender, EventArgs e)
       {
           if ((cb_runhistoric.Checked)||(cb_Native.Checked))
           {
               if (cb_Native.Checked)
               {
                   if (cb_csv.Checked)
                   {
                       runbatch3();
                   }
                   else
                   {
                       runbatch2();
                   }
               }
               else
               {
                   runbatch();
               }
           }
           else
           {
               string parmuser = clb_Users.SelectedItems[0].ToString();
               int parmauthmech = combo_authmech.SelectedIndex;
               string parmscore = tb_testscore.Text;
               string parmG = "1";
               string parmI = "1";
               string bf = "0.00";

               runone(parmuser, parmauthmech, parmscore, ref parmG, ref parmI, ref bf);

               MessageBox.Show("parmG=" + parmG + "  parmI=" + parmI, "  bf=" + bf);
           }
        }


    }    
}
