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
    public partial class form_Question : Form
    {
        public form_Question()
        {
            InitializeComponent();
        }

        public string username
        {
            get
            {
                return this.tb_Username.Text;
            }
            set
            {
                this.tb_Username.Text = value;
            }
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
