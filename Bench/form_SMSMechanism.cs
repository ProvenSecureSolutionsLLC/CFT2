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


namespace Bench
{
    public partial class form_SMSMechanism : Form
    {
        public Double smsscore = Double.NaN;
        private string rightanswer = "";

        public form_SMSMechanism()
        {
            InitializeComponent();
        }

        public Panel childbody()
        {
            return this.panel_ChildBody;
        }


        public void SendSMS(string parmcarrier, string parmmessage)
        {
            WebRequest request = WebRequest.Create("http://www.provsec.com/DEMO/SMS/enroll/index.php");
            request.Method = WebRequestMethods.Http.Post;
            request.ContentType = "application/x-www-form-urlencoded";

            // Create POST data and convert it to a byte array.
            string postData = "phone=" + tb_phone.Text;
            postData += "&name=Default";
            postData += "&carrier=" + parmcarrier;
            postData += "&message=" + parmmessage;
            postData += "&submit=Enroll";

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
            MessageBox.Show(responseFromServer);
            // Display the content.
            //tb_output.Text = responseFromServer; // Console.WriteLine(responseFromServer);
            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            response.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string parmcarrier = "txt.att.net";

            if (this.combo_Carrier.Text == "AT&T Wireless") { parmcarrier = "txt.att.net"; }
            if (this.combo_Carrier.Text == "Sprint") { parmcarrier = "sprintpaging.com"; }
            if (this.combo_Carrier.Text == "Sprint PCS") { parmcarrier = "messaging.sprintpcs.com"; }
            if (this.combo_Carrier.Text == "T-Mobile") { parmcarrier = "tmomail.net"; }
            if (this.combo_Carrier.Text == "Verizon") { parmcarrier = "vtext.com"; }
            if (this.combo_Carrier.Text == "Virgin") { parmcarrier = "vmobl.com"; }

            /* 				<option value="txt.att.net" selected="true">AT&T Wireless</option>
							<option value="sprintpaging.com">Sprint</option>
							<option value="messaging.sprintpcs.com">Sprint PCS</option>
							<option value="tmomail.net">T-Mobile</option>
							<option value="vtext.com">Verizon</option>
							<option value="vmobl.com">Virgin</option>
            */

            Random rng = new Random();

            string temp = rng.NextDouble().ToString(".####");
            rightanswer = "";
            for (int x = 0; x < temp.Length; x++)
            {
                if (temp[x] != '.')
                {
                    rightanswer += temp[x];
                }
            }

            SendSMS(parmcarrier, rightanswer);
        }

        private void tb_code_TextChanged(object sender, EventArgs e)
        {
            Double x = double.NaN;
            int y = tb_code.TextLength;
            if (y == 0) { y = 20; }
            if (y > 5) { y = 5; }
            x = (y * 20) / 100.00;
            tb_Score.Text = x.ToString("###.####");
        }

    }
}
