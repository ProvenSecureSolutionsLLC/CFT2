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
    public partial class form_AuthFactorSettings : Form
    {

        private string filename = "";

        public form_AuthFactorSettings()
        {
            InitializeComponent();
            MessageBox.Show("Don't use form_AuthFactorSettings with Default Constructor.");
        }

        public void setformtype(int item)
        {
            combo_AuthenticationFactor.SelectedIndex = item;

            System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
            string baseDir = System.IO.Path.GetDirectoryName(a.Location);

            // MessageBox.Show(baseDir);

            filename = baseDir;
            switch (combo_AuthenticationFactor.SelectedIndex)
            {
                case 0:
                    label_formtype.Text = "Password";
                    filename += "\\settings_Password.txt";
                    this.label_formtype.Text = "Password";
                    break;
                case 1:
                    label_formtype.Text = "Knowledge";
                    filename += "\\settings_knowledgefactor.txt";
                    break;
                case 2:
                    label_formtype.Text = "AT&&T Voice";
                    filename += "\\settings_attvoice.txt";
                    break;
                case 3:
                    label_formtype.Text = "AT&&T Face";
                    filename += "\\settings_attface.txt";
                    break;
                case 4:
                    label_formtype.Text = "Betaface";
                    filename += "\\settings_betaface.txt";
                    break;
                case 5:
                    label_formtype.Text = "SMS";
                    filename += "\\settings_sms.txt";
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

        public form_AuthFactorSettings(int item)
        {
            InitializeComponent();

            setformtype(item);
        }

        public Panel clientpanel()
        {
            return this.panel_ChildBody;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void save()
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter(this.filename);
            sw.Write(tb_Settings.Text);
            sw.Close();

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }


        private void panel_ChildBody_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show("TODO: Save Changes to: "+this.combo_AuthenticationFactor.Text+" ?");
            this.save();
        }
    }
}
