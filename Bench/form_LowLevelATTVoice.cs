using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;
using System.Net.Mail;

namespace Bench
{
    public partial class form_LowLevelATTVoice : Form
    {
        public form_LowLevelATTVoice()
        {
            InitializeComponent();
        }

        // RE: Json: http://james.newtonking.com/pages/json-net.aspx


        public string getrawoutput()
        {
            return this.tb_output.Text;
        }


        // It is necessary to use Asynchronous Handling of Responses or the UI can bomb
        void DoWithResponse(HttpWebRequest request, Action<HttpWebResponse> responseAction)
        {
            Action wrapperAction = () =>
            {
                request.BeginGetResponse(new AsyncCallback((iar) =>
                {
                    try
                    {
                        var response = (HttpWebResponse)((HttpWebRequest)iar.AsyncState).EndGetResponse(iar);
                        responseAction(response);
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine("BeginGetResponse Exception: {0}", e);
                    }
                }), request);
            };

            wrapperAction.BeginInvoke(new AsyncCallback((iar) =>
            {
                try
                {
                    var action = (Action)iar.AsyncState;
                    action.EndInvoke(iar);
                }
                catch (Exception e)
                {
                    Debug.WriteLine("wrapperAction BeginInvoke Exception: {0}", e);
                }
            }), wrapperAction);

        }


        public string check_probability { get; set; }
        public string texttosay { get; set; }
        public string verify_probability { get; set; }

        // ATT Voice API

        public string authcode(string parmclientid)
        {
            /* auth=`curl -s --data "client_id=$API_KEY&client_secret=$API_SECRET&grant_type=client_credentials&scope=VoiceVerification"  "https://auth.tfoundry.com/oauth/token"`
            echo $auth */
            //https://auth.tfoundry.com/oauth/authorize?client_id=chgeevn0tteexhh9b2coyfbqgunahw5u&response_type=token&scope=profile&redirect_uri=http://provsec.com/callback
            tb_token_url.Text = "https://auth.tfoundry.com/oauth/authorize" + "?client_id=" + parmclientid + "&response_type=code&scope=VoiceVerification&redirect_uri=http://provsec.com/callback";

            WebRequest request = WebRequest.Create(tb_token_url.Text);
            request.Method = WebRequestMethods.Http.Post;
            request.Credentials = CredentialCache.DefaultCredentials;

            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Display the status.
            //tb_output.Text += "RESPONSE DESCRIPTION: " + response.StatusDescription + "\r\n";
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content. 
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            tb_output.Text = responseFromServer; // Console.WriteLine(responseFromServer);
            // Cleanup the streams and the response.
            reader.Close();
            dataStream.Close();
            response.Close();

            /*
            try
            {
                string what = "";
                JsonTextReader jr = new JsonTextReader(new StringReader(tb_output.Text));
                while (jr.Read())
                {
                    if (jr.Value != null)
                        what += "TokenType: " + jr.TokenType + " Value: " + jr.Value + "\r\n";
                    else
                        what += "TokenType: " + jr.TokenType + "\r\n";
                    //                if (jr.TokenType.ToString() == "PropertyName")
                    //if (jr.Value.ToString() == "userId")
                    //{
                    //   jr.Read();
                    // tb_userid.Text = jr.Value.ToString();
                    // }
                }
            }
            finally { }
            //MessageBox.Show(what);
            */
            return tb_output.Text;
        }
        public string authtoken(string parmclientid, string parmclientsecret)
        {
            //authcode(parmclientid);
            //return "boo";
            /* auth=`curl -s --data "client_id=$API_KEY&client_secret=$API_SECRET&grant_type=client_credentials&scope=VoiceVerification"  "https://auth.tfoundry.com/oauth/token"`
            echo $auth */
            //https://auth.tfoundry.com/oauth/authorize?client_id=chgeevn0tteexhh9b2coyfbqgunahw5u&response_type=token&scope=profile&redirect_uri=http://provsec.com/callback
            tb_token_url.Text = tb_token_api.Text + "?client_id=" + parmclientid + "&client_secret=" + parmclientsecret + "&grant_type=client_credentials&scope=VoiceVerification";  //&redirect_uri=http://provsec.com/callback";

            WebRequest request = WebRequest.Create(tb_token_url.Text);
            request.Method = WebRequestMethods.Http.Post;
            request.Credentials = CredentialCache.DefaultCredentials;

            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Display the status.
            //tb_output.Text += "RESPONSE DESCRIPTION: " + response.StatusDescription + "\r\n";
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content. 
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            tb_output.Text = responseFromServer; // Console.WriteLine(responseFromServer);
            // Cleanup the streams and the response.
            reader.Close();
            dataStream.Close();
            response.Close();

            /*
             * {"access_token":"getadxfj4psjlyw1kms7fexsr8iks6ax","token_type":"bearer","refresh_token":"og214cas104gdyhna3a83rcql8r8jwjl","expires_in":7199,"scope":"voiceverification/rwx","user_guid":"7f05f37f-00b7-4183-a57c-94c509907a19","application_id":"chgeevn0tteexhh9b2coyfbqgunahw5u","application_name":"ProvenSecure"}
             */

            try
            {
                //string what = "";
                JsonTextReader jr = new JsonTextReader(new StringReader(tb_output.Text));
                while (jr.Read())
                {
                    //if (jr.Value != null)
                    //    what += "TokenType: " + jr.TokenType + " Value: " + jr.Value + "\r\n";
                    //else
                    //    what += "TokenType: " + jr.TokenType + "\r\n";
                    if (jr.TokenType.ToString().ToLower() == "propertyname")
                        if (jr.Value.ToString().ToLower() == "access_token")
                        {
                            jr.Read();
                            tb_Token.Text = jr.Value.ToString();
                        }
                }
            }
            finally { }

            return tb_Token.Text;
        }
        public string CreateUserId()
        {
            tb_createuser_url.Text = tb_Host.Text + tb_createuser_api.Text + "?access_token=" + tb_Token.Text;

            tb_userid.Text = "";
            tb_output.Text = "";
            Application.DoEvents();

            WebRequest request = WebRequest.Create(tb_createuser_url.Text);
            request.Method = WebRequestMethods.Http.Post;
            request.ContentType = "application/json";

            string postData = "{ }";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            string retval = "";
            string output = "";
            Boolean done = false;

            DoWithResponse((HttpWebRequest)request, (response) =>
            {
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                string responseFromServer = reader.ReadToEnd();
                output = responseFromServer;

                reader.Close();
                responseStream.Close();
                response.Close();

                JsonTextReader jr = new JsonTextReader(new StringReader(output));
                while (jr.Read())
                {
                    if (jr.TokenType.ToString().ToLower() == "propertyname")
                        if (jr.Value.ToString().ToLower() == "userid")
                        {
                            jr.Read();
                            retval = jr.Value.ToString();
                        }
                }

                done = true;
            });

            int cnt = 0;
            while ((!done) && (cnt < 60))
            {
                Thread.Sleep(500);
                cnt++;
            }

            if (done)
            {
                tb_userid.Text = retval;
                tb_output.Text = output;
            }
            return tb_userid.Text;
        }
        public string UserStatus(string parmUserId)
        {
            tb_userstatus_url.Text = tb_Host.Text + tb_userstatus_api.Text + "?userId=" + parmUserId + "&access_token=" + tb_Token.Text;

            tb_output.Text = "";
            Application.DoEvents();

            WebRequest request = WebRequest.Create(tb_userstatus_url.Text);
            request.Method = WebRequestMethods.Http.Get;

            request.Credentials = CredentialCache.DefaultCredentials;

            string output = "";
            Boolean done = false;

            DoWithResponse((HttpWebRequest)request, (response) =>
            {
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                string responseFromServer = reader.ReadToEnd();
                output = responseFromServer;

                reader.Close();
                responseStream.Close();
                response.Close();

                //JsonTextReader jr = new JsonTextReader(new StringReader(output));
                //while (jr.Read())
                //{
                //    if (jr.TokenType.ToString() == "PropertyName")
                //        if (jr.Value.ToString() == "userId")
                //        {
                //            jr.Read();
                //            retval = jr.Value.ToString();
                //        }
                //}

                done = true;
            });

            int cnt = 0;
            while ((!done) && (cnt < 60))
            {
                Thread.Sleep(500);
                cnt++;
            }

            if (done)
            {
                tb_output.Text = output;
            }
            return tb_output.Text;
        }
        public string RandomStatement(string parmSessionId)
        {
            tb_randomstatement_url.Text = tb_Host.Text + tb_randomstatement_api.Text + "?sessionId=" + parmSessionId + "&access_token=" + tb_Token.Text;

            tb_output.Text = "";
            Application.DoEvents();

            WebRequest request = WebRequest.Create(tb_randomstatement_url.Text);
            request.Method = WebRequestMethods.Http.Get;
            request.Credentials = CredentialCache.DefaultCredentials;


            string output = "";
            Boolean done = false;

            DoWithResponse((HttpWebRequest)request, (response) =>
            {
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                string responseFromServer = reader.ReadToEnd();
                output = responseFromServer;

                reader.Close();
                responseStream.Close();
                response.Close();

                JsonTextReader jr = new JsonTextReader(new StringReader(output));
                while (jr.Read())
                {
                    if (jr.TokenType.ToString().ToLower() == "propertyname")
                        if (jr.Value.ToString().ToLower() == "text")
                        {
                            jr.Read();
                            texttosay = jr.Value.ToString();
                        }
                }

                done = true;
            });

            int cnt = 0;
            while ((!done) && (cnt < 60))
            {
                Thread.Sleep(500);
                cnt++;
            }

            if (done)
            {
                tb_randomtext.Text = texttosay;
                tb_output.Text = output;
            }
            return texttosay;
        }
        public string CreateVoiceSession(string parmDeviceId, string parmUserId)
        {
            //https://api.foundry.att.com/a1/voiceverification/voicesession/create?access_token=sakmllld5z6rrt6bmvmn32pfk2ajkfo6

            tb_createvoicesession_url.Text = tb_Host.Text + tb_createvoicesession_api.Text + "?access_token=" + tb_Token.Text;
            tb_output.Text = "";
            Application.DoEvents();
            
            string url = (tb_createvoicesession_url.Text);
            Debug.WriteLine(url);

            WebRequest request = WebRequest.Create(tb_createvoicesession_url.Text);
            request.Method = WebRequestMethods.Http.Post;
            request.ContentType = "application/json";
            string postData = "{\"deviceId\":\"" + parmDeviceId + "\",\"userId\":\"" + parmUserId + "\" }";
            Debug.WriteLine(postData);

            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            string retval = "";
            string output = "";
            Boolean done = false;

            DoWithResponse((HttpWebRequest)request, (response) =>
            {
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                string responseFromServer = reader.ReadToEnd();
                output = responseFromServer;

                reader.Close();
                responseStream.Close();
                response.Close();

                JsonTextReader jr = new JsonTextReader(new StringReader(output));
                while (jr.Read())
                {
                    if (jr.TokenType.ToString().ToLower() == "propertyname")
                        if (jr.Value.ToString().ToLower() == "sessionid")
                        {
                            jr.Read();
                            retval = jr.Value.ToString();
                        }
                }

                done = true;
            });

            int cnt = 0;
            while ((!done) && (cnt < 60))
            {
                Thread.Sleep(500);
                cnt++;
            }

            if (done)
            {
                tb_sessionid.Text = retval;
                tb_output.Text = output;
            }
            return retval;
        }
        public string Check(string parmSessionId)
        {
            tb_check_url.Text = tb_Host.Text + tb_check_api.Text + "?sessionId=" + parmSessionId + "&access_token=" + tb_Token.Text;
            tb_output.Text = "";

            Application.DoEvents();

            WebRequest request = WebRequest.Create(tb_check_url.Text);
            request.Method = WebRequestMethods.Http.Get;
            request.Credentials = CredentialCache.DefaultCredentials;


            string output = "";
            Boolean done = false;

            DoWithResponse((HttpWebRequest)request, (response) =>
            {
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                string responseFromServer = reader.ReadToEnd();
                output = responseFromServer;

                reader.Close();
                responseStream.Close();
                response.Close();

                JsonTextReader jr = new JsonTextReader(new StringReader(output));
                while (jr.Read())
                {
                    if (jr.TokenType.ToString().ToLower() == "propertyname")
                        if (jr.Value.ToString().ToLower() == "probability")
                        {
                            jr.Read();
                            check_probability = jr.Value.ToString();
                        }
                }

                done = true;
            });

            int cnt = 0;
            while ((!done) && (cnt < 60))
            {
                Thread.Sleep(500);
                cnt++;
            }

            if (done)
            {
                tb_output.Text = output;
            }

            return check_probability;
        }
        public string Verify(string parmtextsaid, string parmsessionid, string parmfilename)
        {
            //https://api.foundry.att.com/a1/voiceverification/voicesession/verify?text=asdfasdfasdf&sessionId=c915a666-869b-4649-9c79-3353af9d0650&access_token=sakmllld5z6rrt6bmvmn32pfk2ajkfo6

            //"C:\vs2013\Projects\Bench\Bench\bin\Debug\UserData\Stephen\Stephen_Actual_20130825_085547.session.wav"
            //WebRequest request = WebRequest.Create(tb_createvoicesession_url.Text);
            //WebRequest request = WebRequest.Create("https://api.foundry.att.com/a1/voiceverification/voicesession/verify?text=This is a test of the emergency broadcast system this is only a test&sessionId=8d31e7b1-738c-4955-b128-788f9c202572&access_token=sakmllld5z6rrt6bmvmn32pfk2ajkfo6");
            //    worked: https://api.foundry.att.com/a1/voiceverification/voicesession/verify?text=This is a test of the emergency broadcast system this is only a test&sessionId=8d31e7b1-738c-4955-b128-788f9c202572&access_token=sakmllld5z6rrt6bmvmn32pfk2ajkfo6
            //0978a359-5887-43ce-867c-fb07c049b7a8


            tb_verify_url.Text = tb_Host.Text + tb_verify_api.Text + "?text=" + parmtextsaid + "&sessionId=" + parmsessionid + "&access_token=" + tb_Token.Text;

            tb_upload_file.Text = parmfilename;

            string whatiswrong = tb_verify_url.Text;   // does not like taking text straight out of a textbox.Text !!! go figure...

            tb_output.Text = "";
            Application.DoEvents();

            WebRequest request = WebRequest.Create(whatiswrong); //"https://api.foundry.att.com/a1/voiceverification/voicesession/verify?text=This is a test of the emergency broadcast system this is only a test&sessionId=0978a359-5887-43ce-867c-fb07c049b7a8&access_token=sakmllld5z6rrt6bmvmn32pfk2ajkfo6");

            request.Method = WebRequestMethods.Http.Post;
            request.ContentType = "audio/wav";
            FileStream f = new FileStream(parmfilename, FileMode.Open, FileAccess.Read);
            request.ContentLength = f.Length;

            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            f.CopyTo(dataStream);
            // Close the Stream object.
            dataStream.Close();
            f.Close();

            string output = "";
            Boolean done = false;

            DoWithResponse((HttpWebRequest)request, (response) =>
            {
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                string responseFromServer = reader.ReadToEnd();
                output = responseFromServer;

                reader.Close();
                responseStream.Close();
                response.Close();

                JsonTextReader jr = new JsonTextReader(new StringReader(output));
                while (jr.Read())
                {
                    if (jr.TokenType.ToString().ToLower() == "propertyname")
                        if (jr.Value.ToString().ToLower() == "probability")
                        {
                            jr.Read();
                            verify_probability = jr.Value.ToString();
                        }
                }

                done = true;
            });

            int cnt = 0;
            while ((!done) && (cnt < 60))
            {
                Thread.Sleep(500);
                cnt++;
            }

            if (done)
            {
                tb_verifyscore.Text = verify_probability;
                tb_output.Text = output;
            }

            return verify_probability;
        }
        public string Finalize(string parmsessionid)
        {
            tb_finalize_url.Text = tb_Host.Text + tb_finalize_api.Text + "?sessionId=" + parmsessionid + "&access_token=" + tb_Token.Text;
            tb_output.Text = "";
            Application.DoEvents();

            string whatiswrong = tb_finalize_url.Text + "&verified=true";
            WebRequest request = WebRequest.Create(whatiswrong);
            request.Method = WebRequestMethods.Http.Post;
            request.ContentType = "application/json";

            string postData = "{\"sessionId\":\"" + tb_sessionid.Text + "\",\"verified\":\"" + combo_verified.Text + "\"}";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            string output = "";
            Boolean done = false;
            string score1 = "";
            string score2 = "";
            string score3 = "";
            string sessionscore = "";

            DoWithResponse((HttpWebRequest)request, (response) =>
            {
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                string responseFromServer = reader.ReadToEnd();
                output = responseFromServer;

                reader.Close();
                responseStream.Close();
                response.Close();

                JsonTextReader jr = new JsonTextReader(new StringReader(output));
                int counter = 0;
                string v = "";
                while (jr.Read())
                {
                    //if (jr.Value != null)
                    //    what += "TokenType: " + jr.TokenType + " Value: " + jr.Value + "\r\n";
                    //else
                    //    what += "TokenType: " + jr.TokenType + "\r\n";
                    if (jr.TokenType.ToString().ToLower() == "propertyname")
                        if (jr.Value.ToString().ToLower() == "probability")
                        {
                            jr.Read();
                            v = jr.Value.ToString();

                            switch (counter)
                            {
                                case 0: score1 = v;
                                    break;
                                case 1: score2 = v;
                                    break;
                                case 2: score3 = v;
                                    break;
                                case 3: sessionscore = v;
                                    break;
                            }

                            counter++;
                        }
                    sessionscore = v; // last one goes in this field
                }

                done = true;
            });

            int cnt = 0;
            while ((!done) && (cnt < 60))
            {
                Thread.Sleep(500);
                cnt++;
            }

            if (done)
            {
                tb_score1.Text = score1;
                tb_score2.Text = score2;
                tb_score3.Text = score3;
                tb_sessionscore.Text = sessionscore;
                tb_output.Text = output;
            }

            string retval = tb_sessionscore.Text;
            return retval;
        }
        public string Train(string parmtextsaid, string parmsessionid, string parmfilename)
        {
            tb_train_url.Text = tb_Host.Text + tb_train_api.Text + "?text=" + parmtextsaid + "&sessionId=" + parmsessionid + "&access_token=" + tb_Token.Text;


            if (parmfilename == "")
            {
                parmfilename = tb_upload_file.Text;
            }

            tb_upload_file.Text = parmfilename;

            if (!File.Exists(parmfilename))
            {
                return "ERROR: Audio File: "+parmfilename+" does not exist";
            }

            string whatiswrong = tb_train_url.Text;
            tb_output.Text = "";
            Application.DoEvents();

            WebRequest request = WebRequest.Create(whatiswrong);
            request.Method = WebRequestMethods.Http.Post;
            request.ContentType = "audio/wav";
            FileStream f = new FileStream(parmfilename, FileMode.Open, FileAccess.Read);
            request.ContentLength = f.Length;

            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            f.CopyTo(dataStream);
            // Close the Stream object.
            dataStream.Close();
            f.Close();

            string output = "";
            Boolean done = false;

            DoWithResponse((HttpWebRequest)request, (response) =>
            {
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                string responseFromServer = reader.ReadToEnd();
                output = responseFromServer;

                reader.Close();
                responseStream.Close();
                response.Close();

                verify_probability = "ERROR: no result";

                //{"error":"sample not audibly correct: He moved his position, and the illusion was gone."}
                JsonTextReader jr = new JsonTextReader(new StringReader(output));
                while (jr.Read())
                {
                    if (jr.TokenType.ToString().ToLower() == "propertyname")
                    {
                        if (jr.Value.ToString().ToLower() == "probability")
                        {
                            jr.Read();
                            verify_probability = jr.Value.ToString();
                        }
                        if (jr.Value.ToString().ToLower() == "error")
                        {
                            jr.Read();
                            verify_probability = "ERROR: " + jr.Value.ToString();
                        }

                    }
                }

                done = true;
            });

            int cnt = 0;
            while ((!done) && (cnt < 60))
            {
                Thread.Sleep(500);
                cnt++;
            }

            if (done)
            {
                tb_output.Text = output;
            }

            return verify_probability;
        }


        // User Interface Methods for Testing
        private void btn_CreateUser_Click(object sender, EventArgs e)
        {
            string result = CreateUserId();
        }
        private void btn_UserStatus_Click(object sender, EventArgs e)
        {
            string result = UserStatus(tb_userid.Text);
        }
        private void btn_RandomStatement_Click(object sender, EventArgs e)
        {
            string retval = RandomStatement(tb_sessionid.Text);
        }
        private void btn_createvoicesession_Click(object sender, EventArgs e)
        {
            string retval = CreateVoiceSession(tb_deviceid.Text, tb_userid.Text);
        }
        private void btn_Check_Click(object sender, EventArgs e)
        {
            string retval = Check(tb_sessionid.Text);
        }
        private void btn_Verify_Click(object sender, EventArgs e)
        {
            string retval = Verify(tb_randomtext.Text, tb_sessionid.Text, tb_upload_file.Text);
        }
        private void btn_Finalize_Click(object sender, EventArgs e)
        {
            string retval = Finalize(tb_sessionid.Text);
        }
        private void btn_Train_Click(object sender, EventArgs e)
        {
            string retval = "";

            retval = Train(tb_randomtext.Text, tb_sessionid.Text, tb_upload_file.Text);
        }
        private void btn_gettoken_Click(object sender, EventArgs e)
        {
            string retval = authtoken(tb_attclientid.Text, tb_attclientsecret.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btn_AsynchInvoke_Click(object sender, EventArgs e)
        {
            tb_check_url.Text = tb_Host.Text + tb_check_api.Text + "?sessionId=" + tb_sessionid.Text + "&access_token=" + tb_Token.Text;
            tb_output.Text = "";

            Application.DoEvents();

            WebRequest request = WebRequest.Create(tb_check_url.Text);
            request.Method = WebRequestMethods.Http.Get;

            //tb_output.Text = "REQUEST: " + tb_userstatus_url.Text + "\r\n";
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;

            check_probability = "";
            string output = "";
            Boolean done = false;

            // init your request...then:
            DoWithResponse((HttpWebRequest)request, (response) =>
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                output = responseFromServer; 

                reader.Close();
                dataStream.Close();
                response.Close();

                JsonTextReader jr = new JsonTextReader(new StringReader(output));
                while (jr.Read())
                {
                    if (jr.TokenType.ToString().ToLower() == "propertyname")
                        if (jr.Value.ToString().ToLower() == "probability")
                        {
                            jr.Read();
                            check_probability = jr.Value.ToString();
                        }
                }

                done = true;
            });

            int cnt = 0;
            while ((!done)&&(cnt<60))
            {
                Thread.Sleep(500);
                cnt++;
            }

            if (done)
            {
                tb_output.Text = output;
            }
            //return check_probability;
        }


        /*
         * another method - using a "background worker"
         * var worker = new BackgroundWorker();

worker.DoWork += (sender, args) => {
    args.Result = new WebClient().DownloadString(settings.test_url);
};

worker.RunWorkerCompleted += (sender, e) => {
    if (e.Error != null) {
        connectivityLabel.Text = "Error: " + e.Error.Message;
    } else {
        connectivityLabel.Text = "Connectivity OK";
        Log.d("result:" + e.Result);
    }
};

connectivityLabel.Text = "Testing Connectivity";
worker.RunWorkerAsync();

         */


    }
}
