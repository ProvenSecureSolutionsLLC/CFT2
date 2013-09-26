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
    public partial class form_SystemUser : Form
    {
        private string baseDir = "";
        private string startFolder = "";

        public string systemuser { get { return this.combo_systemuser.Text; }  set { } }
        public string attvoiceid
        {
            get 
            {
                System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                baseDir = System.IO.Path.GetDirectoryName(a.Location);
                startFolder = baseDir + "\\UserData\\" + systemuser;
                string startFile = startFolder + "\\attvoice.id";

                string retval = "";

                if (!System.IO.Directory.Exists(startFolder))
                {
                    // the user folder should have already existed
                    MessageBox.Show(startFolder, "Folder should have already existed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    System.IO.Directory.CreateDirectory(startFolder);
                }

                if (System.IO.File.Exists(startFile))
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(startFile);
                    retval = sr.ReadToEnd();
                    sr.Close();
                }

                return retval;
            }
            set 
            {
                System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                baseDir = System.IO.Path.GetDirectoryName(a.Location);
                startFolder = baseDir + "\\UserData\\" + systemuser;
                string startFile = startFolder + "\\attvoice.id";

                if (!System.IO.Directory.Exists(startFolder))
                {
                    // the user folder should have already existed
                    MessageBox.Show(startFolder, "Folder should have already existed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    System.IO.Directory.CreateDirectory(startFolder);
                }

                if (System.IO.File.Exists(startFile)) 
                {
                    System.IO.File.Delete(startFile);
                }

                System.IO.StreamWriter sw = new System.IO.StreamWriter(startFile);
                sw.Write(value);
                sw.Close();
            }
        }

        public Panel childpanel()
        {
            return panel_ChildBody;
        }


        public void refresh()
        {
            System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
            baseDir = System.IO.Path.GetDirectoryName(a.Location);
            startFolder = baseDir + "\\UserData";


            string repickme = combo_systemuser.Text;

            bool isExists = System.IO.Directory.Exists(startFolder);

            if (!isExists)
                System.IO.Directory.CreateDirectory(startFolder);

            // Take a snapshot of the file system.
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(startFolder);

            // This method assumes that the application has discovery permissions 
            // for all folders under the specified path.
            IEnumerable<System.IO.DirectoryInfo> directoryList = dir.GetDirectories();

            combo_systemuser.Items.Clear();
            foreach (System.IO.DirectoryInfo d in directoryList)
            {
                combo_systemuser.Items.Add(d.Name);
            }

            if (repickme != "")
            {
                combo_systemuser.SelectedIndex = combo_systemuser.FindStringExact(repickme, -1);
            }
        }

        public form_SystemUser()
        {
            InitializeComponent();

            refresh();
        }

        private void createnewuser()
        {
            string newdir = "";

            string strnewuser = "";
            form_Question q = new form_Question();
            q.username = "";
            if (q.ShowDialog() == DialogResult.OK)
            {
                strnewuser = q.username;
            }
            else
            {
                return;
            }

            strnewuser = strnewuser.Trim();

            if (strnewuser != "") {

                newdir = startFolder + "\\" + strnewuser;

                bool isExists = System.IO.Directory.Exists(newdir);

                try
                {
                    if (!isExists)
                    {
                        System.IO.Directory.CreateDirectory(newdir);

                        MessageBox.Show("Created: " + newdir);
                    }
                    else
                    {
                        MessageBox.Show(newdir,"Already Exists!");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Failed to create: " + newdir);
                }

                combo_systemuser.Text = strnewuser;
                refresh();

                MessageBox.Show("User: " + strnewuser + " was added successfully.");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            createnewuser();
        }

        private void combo_systemuser_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you.  With the user now set, you may proceed additional features.");
        }
    }
}
