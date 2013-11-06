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
    public partial class form_About : Form
    {
        private Boolean hasstarted = false;

        public form_About()
        {
            InitializeComponent();
        }

        public Panel childbody()
        {
            if (!hasstarted)
            {
                hasstarted = true;
                try
                {
                    System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                    string baseDir = System.IO.Path.GetDirectoryName(a.Location);
                    string filename = baseDir + "\\about\\templateabout.html";
                    //this.webBrowser1.Navigate(filename); - removed due to Paul's configuration issues
                }
                finally
                {
                }
            }
            return this.panel_ChildBody;
        }


    }
}
