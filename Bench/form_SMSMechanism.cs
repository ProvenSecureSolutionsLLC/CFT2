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
    public partial class form_SMSMechanism : Form
    {
        public Double smsscore = Double.NaN;

        public form_SMSMechanism()
        {
            InitializeComponent();
        }

        public Panel childbody()
        {
            return this.panel_ChildBody;
        }

    }
}
