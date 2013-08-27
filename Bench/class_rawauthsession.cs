using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bench
{
    class class_rawauthsession
    {
        //public Guid guid { get; set; } - we don't need this because user and datetime already qualify for this purpose

        // ultimately mean and variance per individual per authenticator - success
        // and mean and variance for - imposter

        // No - don't do this in data gathering mode
        // TestUser is authenticating, we know this
        // Or TestUser is having someone try to be TestUser "imposter" on purpose
        //public Boolean sessionpassed { get; set; } // did the over all session succeed or fail - see: test plan

        // A session is either completely valid or completely imposter
        // there is no This mechanism passed, that one failed, when training
        // This is TestUser x, we know this
        // Unless testuser x is implementing an Imposter record deliberately [x] Imposter

        public class_rawauthsession()
        {
            user = "Default";
            startdatetime = DateTime.Now;
            enddatetime = DateTime.Now;
            character = "Actual";
            password_score = Double.NaN;
            attvoice_score1 = Double.NaN;
            attvoice_score2 = Double.NaN;
            attvoice_score3 = Double.NaN;
            attface_score1 = Double.NaN;
            attface_score2 = Double.NaN;
            attface_score3 = Double.NaN;
            betaface_score1 = Double.NaN;
            betaface_score2 = Double.NaN;
            betaface_score3 = Double.NaN;
            knowledge_score = Double.NaN;
            sms_score = Double.NaN;
            sessionfilename = this.filename();


        }

        public class_rawauthsession(string parmuser)
        {
            if (parmuser.Trim() == "")
            {
                this.user = "Default";
            }
            else
            {
                this.user = parmuser;
            }

            startdatetime = DateTime.Now;
            enddatetime = DateTime.Now;
            character = "Actual";
            password_score = Double.NaN;
            attvoice_score1 = Double.NaN;
            attvoice_score2 = Double.NaN;
            attvoice_score3 = Double.NaN;
            attface_score1 = Double.NaN;
            attface_score2 = Double.NaN;
            attface_score3 = Double.NaN;
            betaface_score1 = Double.NaN;
            betaface_score2 = Double.NaN;
            betaface_score3 = Double.NaN;
            knowledge_score = Double.NaN;
            sms_score = Double.NaN;
            sessionfilename = this.filename();

        }

        public string sessionfilename { get; set; }

        // User + StartDateTime for a session IS a "guid"... haha it is "guid-enough" for our purposes
        public string user { get; set; }
        public string version = "Version 0.1"; // keep track if we change the data structure saved retrieved to disk
        public string character { get; set; }
        public DateTime startdatetime { get; set; }
        public DateTime enddatetime { get; set; }
        // not now  //public int sessionduration { get; set; } // seconds
        public Double password_score { get; set; }
        // OPTIONAL - keep track of running mean
        //Not now   //public int password_timeelapsed { get; set; }  // seconds
        // up to three attvoice scores ( adom will take up to three correlated attempts in bio-factors )
        // mean, variance, score - ultimately
        // get back bayes factor - I decide with that, send another voice sample(s) together, or use another authenticator
        public Double attvoice_score1 { get; set; }
        public Double attvoice_score2 { get; set; }
        public Double attvoice_score3 { get; set; }
        // OPTIONAL - keep track of running mean
        // public Double attvoice_running_mean - i.e., quality improving or deteriorating
        // technically this is a report, but it can be useful at actual operating time with RMM
        // keep the data used
        // attvoice file 1,2,3   user+startdatetime_attvoice1.wav, user_startdatetime_attvoice2.wav, user_startdatetime_attvoice3.wav
        // not now
        //public int attvoice_timeelapsed { get; set; }  // seconds
        public Double attface_score1 { get; set; }
        public Double attface_score2 { get; set; }
        public Double attface_score3 { get; set; }
        // now now public int attface_timeelapsed { get; set; } // seconds
        // OPTIONAL - keep track of running mean
        // keep the data used
        // user+startdatetime_attface_image1.bmp, user+startdatetime_attface_image2.bmp, user+startdatetime_attface_image3.bmp
        public Double betaface_score1 { get; set; }
        public Double betaface_score2 { get; set; }
        public Double betaface_score3 { get; set; }
        //not nowpublic int betaface_timeelapsed { get; set; } // seconds
        // OPTIONAL - keep track of running mean
        // keep the data used - USE THE SAME IMAGES AS ATTFACE - so we can compare the two mechanisms exactly
        public Double knowledge_score { get; set; }
        // OPTIONAL - keep track of running mean
        // not now public int knowledge_timeelapsed { get; set; } // seconds
        public Double sms_score { get; set; }
        // OPTIONAL - keep track of running mean
        // not now public int sms_timeelapsed { get; set; } // seconds


        public void randomize()
        {
            this.character = "Random";
            Random rng = new Random();

            this.password_score = rng.NextDouble();
            this.attvoice_score1 = rng.NextDouble();
            this.attvoice_score2 = rng.NextDouble();
            this.attvoice_score3 = rng.NextDouble();
            this.attface_score1 = rng.NextDouble();
            this.attface_score2 = rng.NextDouble();
            this.attface_score3 = rng.NextDouble();
            this.betaface_score1 = rng.NextDouble();
            this.betaface_score2 = rng.NextDouble();
            this.betaface_score3 = rng.NextDouble();
            this.knowledge_score = rng.NextDouble();
            this.sms_score = rng.NextDouble();
        }

        public Double rangedscore(Double max, Double min)
        {
            Random rng = new Random();

            Double retval = 0.00;

            int breaker = 0;

            while ((breaker < 1000) && ((retval > max) || (retval < min)))
            {
                breaker++;
                retval = rng.NextDouble();
            }

            return retval;
        }

        public void rangegen(class_highlowsession range)
        {
            this.character = "RangeGen";

            this.password_score = rangedscore(range._pwmax, range._pwmin);

            this.attvoice_score1 = rangedscore(range._attvoicemax, range._attvoicemin);
            this.attvoice_score2 = rangedscore(range._attvoicemax, range._attvoicemin);
            this.attvoice_score2 = rangedscore(range._attvoicemax, range._attvoicemin);

            this.attface_score1 = rangedscore(range._attfacemax, range._attfacemin);
            this.attface_score2 = rangedscore(range._attfacemax, range._attfacemin);
            this.attface_score3 = rangedscore(range._attfacemax, range._attfacemin);

            this.betaface_score1 = rangedscore(range._betafacemax, range._betafacemin);
            this.betaface_score1 = rangedscore(range._betafacemax, range._betafacemin);
            this.betaface_score1 = rangedscore(range._betafacemax, range._betafacemin);

            this.knowledge_score = rangedscore(range._knowledgemax, range._knowledgemin);

            this.sms_score = rangedscore(range._smsmax, range._smsmin);
        }

        public string savetostring()
        {
            string retval = "";

            retval += this.user + "|";
            retval += this.version + "|";
            retval += this.character + "|";
            retval += this.startdatetime.ToString() + "|";
            retval += this.enddatetime.ToString() + "|";
            retval += this.password_score + "|";
            retval += this.attvoice_score1 + "|";
            retval += this.attvoice_score2 + "|";
            retval += this.attvoice_score3 + "|";
            retval += this.attface_score1 + "|";
            retval += this.attface_score2 + "|";
            retval += this.attface_score3 + "|";
            retval += this.betaface_score1 + "|";
            retval += this.betaface_score2 + "|";
            retval += this.betaface_score3 + "|";
            retval += this.knowledge_score + "|";
            retval += this.sms_score + "|";

            return retval;
        }

        public void loadfromstring(string s)
        {
            string buffer = s; 
            string[] ray = buffer.Split(new Char[] { '|' });

            this.user = ray[0];
            this.version = ray[1];
            this.character = ray[2];
            this.startdatetime = Convert.ToDateTime(ray[3]);
            this.enddatetime = Convert.ToDateTime(ray[4]);
            this.password_score = Convert.ToDouble(ray[5]);
            this.attvoice_score1 = Convert.ToDouble(ray[6]);
            this.attvoice_score2 = Convert.ToDouble(ray[7]);
            this.attvoice_score3 = Convert.ToDouble(ray[8]);
            this.attface_score1 = Convert.ToDouble(ray[9]);
            this.attface_score2 = Convert.ToDouble(ray[10]);
            this.attface_score3 = Convert.ToDouble(ray[11]);
            this.betaface_score1 = Convert.ToDouble(ray[12]);
            this.betaface_score2 = Convert.ToDouble(ray[13]);
            this.betaface_score3 = Convert.ToDouble(ray[14]);
            this.knowledge_score = Convert.ToDouble(ray[15]);
            this.sms_score = Convert.ToDouble(ray[16]);
        }

        public void LoadFromFile(string filename)
        {
            string buffer = "";
            System.IO.StreamReader sr = new System.IO.StreamReader(filename);
            buffer = sr.ReadToEnd();
            sr.Close();
            this.loadfromstring(buffer);
        }


        public string filename()
        {
            string retval = "";

            retval += this.user + "_" + this.character + "_" + this.startdatetime.ToString("yyyyMMdd_hhmmss");
            retval = safestring_FILENAME(retval);

            System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
            string basedir = System.IO.Path.GetDirectoryName(a.Location);

            retval = basedir + "\\UserData\\" + this.user + "\\" + retval + ".session";

            sessionfilename = retval;

            return retval;
        }

        public string safestring_FILENAME(string parms)
        {
            string ts = "";

            ts = parms.Trim();
            ts = ts.Replace(' ', '_');
            ts = ts.Replace('|', '_');
            ts = ts.Replace('/', '_');
            ts = ts.Replace('\\', '_');
            ts = ts.Replace('`', '_');
            ts = ts.Replace('~', '_');
            ts = ts.Replace('!', '_');
            ts = ts.Replace('@', '_');
            ts = ts.Replace('#', '_');
            ts = ts.Replace('$', '_');
            ts = ts.Replace('%', '_');
            ts = ts.Replace('^', '_');
            ts = ts.Replace('&', '_');
            ts = ts.Replace('*', '_');
            ts = ts.Replace('(', '_');
            ts = ts.Replace(')', '_');
            ts = ts.Replace('+', '_');
            ts = ts.Replace('[', '_');
            ts = ts.Replace(']', '_');
            ts = ts.Replace('{', '_');
            ts = ts.Replace('}', '_');
            ts = ts.Replace(':', '_');
            ts = ts.Replace(';', '_');
            ts = ts.Replace('\"', '_');
            ts = ts.Replace('\'', '_');
            ts = ts.Replace('?', '_');
            ts = ts.Replace('<', '_');
            ts = ts.Replace('>', '_');
            ts = ts.Replace(',', '_');
            ts = ts.Replace('.', '_');

            return ts;
        }


        public Boolean savetofile()
        {
            Boolean retval = true;

            // I know, a little weird, just Once set, don't set it again
            if (sessionfilename == "")
            {
                sessionfilename = this.filename();
            }

            try
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(sessionfilename);
                sw.Write(this.savetostring());
                sw.Close();
            }
            catch
            {
                retval = false;
            }

            return retval;
        }

    }
}
