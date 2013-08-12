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
    public partial class Form1 : Form
    {
        private System.Drawing.Color saveHeaderColor;

        public Form1()
        {
            InitializeComponent();
            saveHeaderColor = this.panelHeaderAbout.BackColor;
        }

        private void panelHeaderAbout_MouseHover(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            p.BackColor = System.Drawing.Color.Black;
        }

        private void panelHeaderAbout_MouseLeave(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            p.BackColor = saveHeaderColor;
        }

        private void panelHeaderAbout_MouseClick(object sender, MouseEventArgs e)
        {
            Panel p = (Panel)sender;
            MessageBox.Show(p.Name);
        }

    }
}
