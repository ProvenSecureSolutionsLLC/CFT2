using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvenSecure_DARPA_CFT_2013
{
    public partial class form_AuthFactorSettings : Form
    {
        public form_AuthFactorSettings()
        {
            InitializeComponent();
            MessageBox.Show("Don't use form_AuthFactorSettings with Default Constructor.");
        }

        public form_AuthFactorSettings(int item)
        {
            InitializeComponent();
            combo_AuthenticationFactor.SelectedIndex = item;

            System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
            string baseDir = System.IO.Path.GetDirectoryName(a.Location);

            // MessageBox.Show(baseDir);

            string filename = baseDir;
            switch (combo_AuthenticationFactor.SelectedIndex)
            {
                case 0:
                    filename += "\\settings_attvoice.txt";
                    break;
                case 1:
                    filename += "\\settings_password.txt";
                    break;
                case 2:
                    filename += "\\settings_knowledgefactor.txt";
                    break;
                case 3:
                    filename += "\\settings_smstoken.txt";
                    break;
            }

            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(filename);
                tb_Settings.Text = sr.ReadToEnd();
                sr.Close();
            }
            catch 
            {
                tb_Settings.Text = "empty";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
            string baseDir = System.IO.Path.GetDirectoryName(a.Location);

            // MessageBox.Show(baseDir);

            string filename = baseDir;
            switch (combo_AuthenticationFactor.SelectedIndex) 
            {
                case 0:
                    filename += "\\settings_attvoice.txt";
                    break;
                case 1:
                    filename += "\\settings_password.txt";
                    break;
                case 2:
                    filename += "\\settings_knowledgefactor.txt";
                    break;
                case 3:
                    filename += "\\settings_smstoken.txt";
                    break;
            }


            System.IO.StreamWriter sw = new System.IO.StreamWriter(filename);
            sw.Write(tb_Settings.Text);
            sw.Close();


            this.DialogResult = System.Windows.Forms.DialogResult.OK;

        }
    }
}
