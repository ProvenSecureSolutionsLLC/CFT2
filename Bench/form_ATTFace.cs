﻿using System;
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
    public partial class form_ATTFace : Form
    {

        private formCAMture cameraForm = null;
        private string sessionfilename = "";

        public Double facescore = Double.NaN;

        public form_ATTFace(formCAMture parmf, string parmsessionfilename)
        {
            InitializeComponent();

            this.cameraForm = parmf;
            sessionfilename = parmsessionfilename;
        }

        public void setCameraForm(formCAMture parmf)
        {
            cameraForm = parmf;
        }

        public Panel childbody()
        {
            return this.panel_ChildBody;
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

        private void btn_Cheese_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Note to programmer, reset the camForm into childs in case revisit Settings");
            if (cameraForm != null)
            {
                if (cameraForm.picture() != null)
                {
                    this.pictureBox1.Size = cameraForm.picture().Size;
                    this.pictureBox1.Image = cameraForm.picture().Image;
                    this.pictureBox1.Image.Save(sessionfilename + ".attface.bmp");
                }
                else
                {
                    MessageBox.Show("cameraForm.Picture is null, please check settings.");
                }
            }
            timer1.Enabled = true;
        }
    }
}
