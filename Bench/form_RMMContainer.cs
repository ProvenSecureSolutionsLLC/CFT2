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
        public form_RMMContainer()
        {
            InitializeComponent();
        }

        public Panel childpanel()
        {
            return this.panel_ChildBody;
        }

       private void btn_BatchGo_Click(object sender, EventArgs e)
        {

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
            sw.Write(textBox_Script.Text);
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
                    listbox_output.Items.Add("R.exe Exceeded 10 seconds, still responding, sending shutdown message...");
                    p.CloseMainWindow();
                }
                else
                {
                    listbox_output.Items.Add("R.exe Exceeded 10 seconds, not responding, issuing Kill order...");
                    p.Kill();
                }
            }
            else
            {
                listbox_output.Items.Clear();
                var items = new List<string>();
                System.IO.StreamReader sr = new System.IO.StreamReader(scriptoutputfilename);
                string line;

                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    if (!checkbox_filter.Checked)
                    {
                        listbox_output.Items.Add(line);
                    }
                    else
                    {
                        if ((!line.StartsWith(">")) && (!line.StartsWith("+"))) {
                            listbox_output.Items.Add(line);
                        }
                        
                    }
                }
                sr.Close();
            }
        }

    }    
}
