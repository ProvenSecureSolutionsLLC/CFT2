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

            tb_NewUser.Text = "";

        }

        public form_SystemUser()
        {
            InitializeComponent();

            refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newdir = "";

            if (tb_NewUser.Text.Trim() != "") {

                newdir = startFolder + "\\" + tb_NewUser.Text;

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
                    }
                }
                catch
                {
                    MessageBox.Show("Failed to create: " + newdir);
                    tb_NewUser.Text = "";
                }


                combo_systemuser.Text = tb_NewUser.Text;

                refresh();
            }
        }
    }
}
