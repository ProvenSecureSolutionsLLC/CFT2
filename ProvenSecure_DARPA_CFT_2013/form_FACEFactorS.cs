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
    public partial class form_FACEFactorS : Form
    {
        public form_FACEFactorS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formCAMture fc = new formCAMture();

            fc.ShowDialog();

            //imageList1 = fc.myimages;
        }
    }
}
