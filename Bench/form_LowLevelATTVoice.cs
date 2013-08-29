using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Bench
{
    public partial class form_LowLevelATTVoice : Form
    {
        public form_LowLevelATTVoice()
        {
            InitializeComponent();
        }

        // RE: Json: http://james.newtonking.com/pages/json-net.aspx


        public string check_probability { get; set; }
        public string texttosay { get; set; }
        public string verify_probability { get; set; }


        private void recalculate()
        {
            tb_createuser_url.Text = tb_Host.Text + tb_createuser_api.Text + "?access_token=" + tb_Token.Text;

            tb_userstatus_url.Text = tb_Host.Text + tb_userstatus_api.Text + "?userId=" + tb_userid.Text + "&access_token=" + tb_Token.Text;

            tb_randomstatement_url.Text = tb_Host.Text + tb_randomstatement_api.Text + "?access_token=" + tb_Token.Text;

            tb_createvoicesession_url.Text = tb_Host.Text + tb_createvoicesession_api.Text + "?access_token=" + tb_Token.Text;

            tb_randomstatement_url.Text = tb_Host.Text + tb_randomstatement_api.Text + "?sessionId=" + tb_sessionid.Text + "&access_token=" + tb_Token.Text;

            tb_check_url.Text = tb_Host.Text + tb_check_api.Text + "?sessionId=" + tb_sessionid.Text + "&access_token=" + tb_Token.Text;

            tb_verify_url.Text = tb_Host.Text + tb_verify_api.Text + "?text=" + tb_randomtext.Text + "&sessionId=" + tb_sessionid.Text + "&access_token=" + tb_Token.Text;

            tb_finalize_url.Text = tb_Host.Text + tb_finalize_api.Text + "?sessionId=" + tb_sessionid.Text + "&access_token=" + tb_Token.Text; 

            tb_train_url.Text = tb_Host.Text + tb_train_api.Text + "?text=" + tb_randomtext.Text + "&sessionId=" + tb_sessionid.Text + "&access_token=" + tb_Token.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tb_Host_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            recalculate(); // tb_createuser_url.Text = tb_Host.Text + tb_createuser_api.Text + "?access_token=" + tb_Token.Text;
        }

        private void btn_CreateUser_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create(tb_createuser_url.Text);
            request.Method = WebRequestMethods.Http.Post;
            request.ContentType = "application/json";

            // Create POST data and convert it to a byte array.
            string postData = "{ }";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            // Set the ContentType property of the WebRequest.
            //request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;
            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();
            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            tb_output.Text = responseFromServer; // Console.WriteLine(responseFromServer);
            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            response.Close();

            string what = "";
            JsonTextReader jr = new JsonTextReader(new StringReader(tb_output.Text));
            while (jr.Read())
            {
                if (jr.Value != null)
                    what += "TokenType: " + jr.TokenType + " Value: " + jr.Value + "\r\n";
                else
                    what += "TokenType: " + jr.TokenType + "\r\n";
                if (jr.TokenType.ToString() == "PropertyName")
                    if (jr.Value.ToString() == "userId")
                    {
                        jr.Read();
                        tb_userid.Text = jr.Value.ToString();
                    }
            }
            //MessageBox.Show(what);

        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            ///voicesession/staus?userid=XXXXXX
            // tb_userstatus_url.Text = tb_Host.Text + tb_userstatus_api.Text + "?userid=" + tb_userid.Text;
        }

        private void tb_userid_TextChanged(object sender, EventArgs e)
        {
            recalculate(); // tb_userstatus_url.Text = tb_Host.Text + tb_userstatus_api.Text + "?userId=" + tb_userid.Text + "&access_token=" + tb_Token.Text;
        }

        private void btn_UserStatus_Click(object sender, EventArgs e)
        {
            recalculate();
            WebRequest request = WebRequest.Create(tb_userstatus_url.Text);
            request.Method = WebRequestMethods.Http.Get;

            //tb_output.Text = "REQUEST: " + tb_userstatus_url.Text + "\r\n";
            // If required by the server, set the credentials.
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
            //MessageBox.Show(what);

        }

        private void btn_RandomStatement_Click(object sender, EventArgs e)
        {
            recalculate();
            WebRequest request = WebRequest.Create(tb_randomstatement_url.Text);
            request.Method = WebRequestMethods.Http.Get;

            //tb_output.Text = "REQUEST: " + tb_userstatus_url.Text + "\r\n";
            // If required by the server, set the credentials.
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

            string what = "";
            JsonTextReader jr = new JsonTextReader(new StringReader(tb_output.Text));
            while (jr.Read())
            {
                //if (jr.Value != null)
                //    what += "TokenType: " + jr.TokenType + " Value: " + jr.Value + "\r\n";
                //else
                //    what += "TokenType: " + jr.TokenType + "\r\n";
                if (jr.TokenType.ToString() == "PropertyName")
                if (jr.Value.ToString() == "text")
                {
                   jr.Read();
                   texttosay = jr.Value.ToString();
                   tb_randomtext.Text = texttosay;
                }
            }
            //MessageBox.Show(what);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_createvoicesession_Click(object sender, EventArgs e)
        {
            //https://api.foundry.att.com/a1/voiceverification/voicesession/create?access_token=sakmllld5z6rrt6bmvmn32pfk2ajkfo6
            recalculate();

            WebRequest request = WebRequest.Create(tb_createvoicesession_url.Text);
            request.Method = WebRequestMethods.Http.Post;
            request.ContentType = "application/json";

            // Create POST data and convert it to a byte array.
            // {"deviceId":"1234567890","userId":"e00db1a7e678265a457c9fc0b6fb174d-1410764394740916750"}
            string postData = "{\"deviceId\":\"" + tb_deviceid.Text + "\",\"userId\":\"" + tb_userid.Text + "\" }";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            // Set the ContentType property of the WebRequest.
            //request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;
            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();
            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            tb_output.Text = responseFromServer; // Console.WriteLine(responseFromServer);
            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            response.Close();

            string what = "";
            JsonTextReader jr = new JsonTextReader(new StringReader(tb_output.Text));
            while (jr.Read())
            {
                //if (jr.Value != null)
                //    what += "TokenType: " + jr.TokenType + " Value: " + jr.Value + "\r\n";
                //else
                //    what += "TokenType: " + jr.TokenType + "\r\n";
                                if (jr.TokenType.ToString() == "PropertyName")
                if (jr.Value.ToString() == "sessionid")
                {
                   jr.Read();
                   tb_sessionid.Text = jr.Value.ToString();
                }
            }
            //MessageBox.Show(what);

        }

        private void tb_createvoicesession_api_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            recalculate();

            WebRequest request = WebRequest.Create(tb_check_url.Text);
            request.Method = WebRequestMethods.Http.Get;

            //tb_output.Text = "REQUEST: " + tb_userstatus_url.Text + "\r\n";
            // If required by the server, set the credentials.
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

            string what = "";
            JsonTextReader jr = new JsonTextReader(new StringReader(tb_output.Text));
            while (jr.Read())
            {
                //if (jr.Value != null)
                //    what += "TokenType: " + jr.TokenType + " Value: " + jr.Value + "\r\n";
                //else
                //    what += "TokenType: " + jr.TokenType + "\r\n";
                if (jr.TokenType.ToString() == "PropertyName")
                if (jr.Value.ToString() == "probability")
                {
                   jr.Read();
                   check_probability = jr.Value.ToString();
                }
            }
            //MessageBox.Show(what);
        }

        private void btn_Verify_Click(object sender, EventArgs e)
        {
            //https://api.foundry.att.com/a1/voiceverification/voicesession/verify?text=asdfasdfasdf&sessionId=c915a666-869b-4649-9c79-3353af9d0650&access_token=sakmllld5z6rrt6bmvmn32pfk2ajkfo6
            recalculate();

            //"C:\vs2013\Projects\Bench\Bench\bin\Debug\UserData\Stephen\Stephen_Actual_20130825_085547.session.wav"
            //WebRequest request = WebRequest.Create(tb_createvoicesession_url.Text);
            //WebRequest request = WebRequest.Create("https://api.foundry.att.com/a1/voiceverification/voicesession/verify?text=This is a test of the emergency broadcast system this is only a test&sessionId=8d31e7b1-738c-4955-b128-788f9c202572&access_token=sakmllld5z6rrt6bmvmn32pfk2ajkfo6");
            //    worked: https://api.foundry.att.com/a1/voiceverification/voicesession/verify?text=This is a test of the emergency broadcast system this is only a test&sessionId=8d31e7b1-738c-4955-b128-788f9c202572&access_token=sakmllld5z6rrt6bmvmn32pfk2ajkfo6
            //0978a359-5887-43ce-867c-fb07c049b7a8

            string whatiswrong = tb_verify_url.Text;   // does not like taking text straight out of a textbox.Text !!! go figure...

            //WebRequest request = WebRequest.Create("https://api.foundry.att.com/a1/voiceverification/voicesession/verify?text=This is a test of the emergency broadcast system this is only a test&sessionId=0978a359-5887-43ce-867c-fb07c049b7a8&access_token=sakmllld5z6rrt6bmvmn32pfk2ajkfo6");
            WebRequest request = WebRequest.Create(whatiswrong); //"https://api.foundry.att.com/a1/voiceverification/voicesession/verify?text=This is a test of the emergency broadcast system this is only a test&sessionId=0978a359-5887-43ce-867c-fb07c049b7a8&access_token=sakmllld5z6rrt6bmvmn32pfk2ajkfo6");

            request.Method = WebRequestMethods.Http.Post;
            request.ContentType = "audio/wav";

            //tb_output.Text = "REQUEST: " + whatiswrong + "\r\n";

            FileStream f = new FileStream(tb_upload_file.Text, FileMode.Open, FileAccess.Read);

            request.ContentLength = f.Length;

            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            f.CopyTo(dataStream);
            // Close the Stream object.
            dataStream.Close();
            f.Close();
            // Get the response.
            WebResponse response = null;
            try
            {
                response = request.GetResponse();
            }
            finally { }
            // Display the status.
            //tb_output.Text += "RESPONSE STATUS: " + (((HttpWebResponse)response).StatusDescription) + "\r\n";
            // Get the stream containing content returned by the server.
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            tb_output.Text = responseFromServer; // Console.WriteLine(responseFromServer);
            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            response.Close();


            string what = "";
            JsonTextReader jr = new JsonTextReader(new StringReader(tb_output.Text));
            while (jr.Read())
            {
//                if (jr.Value != null)
//                    what += "TokenType: " + jr.TokenType + " Value: " + jr.Value + "\r\n";
//                else
//                    what += "TokenType: " + jr.TokenType + "\r\n";
                if (jr.TokenType.ToString() == "PropertyName")
                    if (jr.Value.ToString() == "probability")
                    {
                        jr.Read();
                        verify_probability = jr.Value.ToString();
                        tb_verifyscore.Text = verify_probability;
                    }
            }
            //MessageBox.Show(what);
        }


        // Crashes the .exe
        private void btn_Finalize_Click(object sender, EventArgs e)
        {
            recalculate();
            string whatiswrong = tb_finalize_url.Text + "&verified=true";
            WebRequest request = WebRequest.Create(whatiswrong);
            request.Method = WebRequestMethods.Http.Post;
            request.ContentType = "application/json";

            //tb_output.Text = "REQUEST: " + whatiswrong + "\r\n";

            // Create POST data and convert it to a byte array.
            // {"deviceId":"1234567890","userId":"e00db1a7e678265a457c9fc0b6fb174d-1410764394740916750"}
            string postData = "{\"sessionId\":\"" + tb_sessionid.Text + "\",\"verified\":\""+combo_verified.Text+"\"}";
            //MessageBox.Show("PostData: " + postData);
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            // Set the ContentType property of the WebRequest.
            //request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;
            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();
            // Get the response.
            WebResponse response = null;
            try
            {
                response = request.GetResponse();
            }
            finally { } 
            // Display the status.
            //tb_output.Text += "RESPONSE STATUS: " + (((HttpWebResponse)response).StatusDescription) + "\r\n";
            // Get the stream containing content returned by the server.
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            tb_output.Text = responseFromServer; // Console.WriteLine(responseFromServer);
            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            response.Close();

            string what = "";
            JsonTextReader jr = new JsonTextReader(new StringReader(tb_output.Text));
            int counter = 0;
            string v = "";
            while (jr.Read())
            {
                //if (jr.Value != null)
                //    what += "TokenType: " + jr.TokenType + " Value: " + jr.Value + "\r\n";
                //else
                //    what += "TokenType: " + jr.TokenType + "\r\n";
                if (jr.TokenType.ToString() == "PropertyName")
                if (jr.Value.ToString() == "probability")
                {
                    jr.Read();
                    v = jr.Value.ToString();

                    switch (counter)
                    {
                        case 0: tb_score1.Text = v; 
                            break;
                        case 1: tb_score2.Text = v; 
                            break;
                        case 2: tb_score3.Text = v;
                            break;
                        case 3: tb_sessionscore.Text = v;
                            break;
                    }

                    counter++;
                }
                tb_sessionscore.Text = v; // last one goes in this field

                /*
                 * {"status":"verified","score":{"fr":1.0E-4,"fa":1.0E-4,"probability":0.9999},"userid":"e00db1a7e678265a457c9fc0b6fb174d-3651198513698772735","sessionid":"49bf142b-26b8-4796-9b41-e42ddd4d1f7e","samples":["riwtx02bh09wt-201308280226-5363B","riwtx02bh09wt-201308280227-0163E"],"sample":{"id":"riwtx02bh09wt-201308280227-0163E","challenge":-1,"norm":13.8679848,"words":58,"rawnorm":13.8679848,"fr":1,"fa":1.0E-4,"probability":0.9999,"meanASR":50}}
                 */

            }
            //MessageBox.Show(what);
        }

        private void btn_Train_Click(object sender, EventArgs e)
        {
            recalculate();

            string whatiswrong = tb_train_url.Text;

            WebRequest request = WebRequest.Create(whatiswrong); 

            request.Method = WebRequestMethods.Http.Post;
            request.ContentType = "audio/wav";

            //tb_output.Text = "REQUEST: " + whatiswrong + "\r\n";

            FileStream f = new FileStream(tb_upload_file.Text, FileMode.Open, FileAccess.Read);

            request.ContentLength = f.Length;

            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            f.CopyTo(dataStream);
            // Close the Stream object.
            dataStream.Close();
            f.Close();
            // Get the response.
            WebResponse response = null;
            try
            {
                response = request.GetResponse();
            }
            finally { }
            // Display the status.
            //tb_output.Text += "RESPONSE STATUS: " + (((HttpWebResponse)response).StatusDescription) + "\r\n";
            // Get the stream containing content returned by the server.
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            tb_output.Text = responseFromServer; // Console.WriteLine(responseFromServer);
            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            response.Close();
        }
    }
}
