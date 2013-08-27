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
    public partial class form_Betaface : Form
    {

        private formCAMture cameraForm = null;

        public Double facescore = Double.NaN;

        private string sessionfilename = "";

        public form_Betaface(formCAMture parmf, string parmsessionfilename)
        {
            InitializeComponent();

            this.cameraForm = parmf;
            sessionfilename = parmsessionfilename;
        }

        public Panel childbody()
        {
            return this.panel_ChildBody;
        }


        public void setCameraForm(formCAMture parmf)
        {
            cameraForm = parmf;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(5);
            if (progressBar1.Value >= 100)
            {
                timer1.Enabled = false;
                Random rx = new Random();

                Double finalscore = rx.NextDouble();

                this.facescore = finalscore;

                tb_Score.Text = finalscore.ToString("#.#####");
            }
        }

        private void btn_Cheese_Click_1(object sender, EventArgs e)
        {
            if (cameraForm != null)
            {
                this.pictureBox1.Image = cameraForm.picture().Image;
                this.pictureBox1.Image.Save(sessionfilename + ".betaface.bmp");
            }
            timer1.Enabled = true;
        }
    }
}
