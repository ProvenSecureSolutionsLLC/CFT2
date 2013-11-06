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
    public partial class form_ATTFace : Form
    {

        private formCAMture cameraForm = null;
        form_LowLevelBetaface betafaceform = new form_LowLevelBetaface();
        
        public Double facescore = Double.NaN;
        public Double betafacescore = Double.NaN;

        public class_rawauthsession r = null;

        public form_ATTFace(formCAMture parmf, class_rawauthsession parmr)
        {
            InitializeComponent();

            this.cameraForm = parmf;
            r = parmr;
        }



        public void clear()
        {
            this.tb_betaface_Score.Text = "";
            this.tb_Score.Text = "";
            facescore = Double.NaN;
            betafacescore = Double.NaN;
            this.pictureBox1.Image = null;
        }

        public void setCameraForm(formCAMture parmf)
        {
            cameraForm = parmf;
        }

        public Panel childbody()
        {
            return this.panel_ChildBody;
        }


        // if the camera is on, update the image so they can say "cheese !"
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cameraForm != null)
            {
                if (cameraForm.picture() != null)
                {
                    try
                    {
                        this.pictureBox1.Size = cameraForm.picture().Size;
                        this.pictureBox1.Image = cameraForm.picture().Image;
                        Application.DoEvents();
                    }
                    finally
                    {

                    }
                }
            }
        }

        private void btn_Cheese_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Note to programmer, reset the camForm into childs in case revisit Settings");

            timer1.Enabled = false;

            Boolean gotit = false;

            string betafacefilename = "";

            if (cameraForm != null)
            {
                if (cameraForm.picture() != null)
                {
                    try
                    {
                        this.pictureBox1.Size = cameraForm.picture().Size;
                        this.pictureBox1.Image = cameraForm.picture().Image;
                        this.pictureBox1.Image.Save(r.sessionfilename + ".attface.bmp");
                        betafacefilename = r.sessionfilename + ".betaface.bmp";
                        this.pictureBox1.Image.Save(betafacefilename);
                        gotit = true;
                    }
                    catch
                    {

                    }
                }
                else
                {
                    MessageBox.Show("cameraForm.Picture is null, please check settings.");
                }
            }
            //timer1.Enabled = true;
            if (gotit)
            {
                MessageBox.Show("Image Acquired, click ok to begin processing, please be patient.");

                Boolean hasface = false;
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    hasface = betafaceform.upload(betafacefilename);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }

                if (!hasface)
                {
                    MessageBox.Show("The system was unable to parse a face from the image, try again.\r\n\r\n");
                }
                else
                {
                    string recog = "";
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        recog = betafaceform.recognize(betafacefilename);
                    }
                    finally
                    {
                        Cursor.Current = Cursors.Default;
                    }

                    if (recog.Contains("ERROR"))
                    {
                        MessageBox.Show(recog);
                        this.tb_betaface_Score.Text = "0";
                    }
                    else
                    {
                        this.tb_betaface_Score.Text = recog;
                    }

                    this.betafacescore = Convert.ToDouble(this.tb_betaface_Score.Text);
                    this.tb_Score.Text = "-0.9999";
                    this.facescore = Convert.ToDouble(this.tb_Score.Text);
                }
            }

            string check = tb_betaface_Score.Text;
            if (check == "1")
            {
                MessageBox.Show("Warning: Perfect Score\r\nYou might want to take more pictures varying conditions to get a more reasonable score.");
            }

            this.cameraForm.ShutdownCam();

            MessageBox.Show("Done.");
        }

        private void form_ATTFace_Load(object sender, EventArgs e)
        {

        }

        private void btn_startcam_Click(object sender, EventArgs e)
        {
            this.cameraForm.StartupCam();
            timer1.Enabled = true;
        }

        private void btn_stopcam_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.cameraForm.ShutdownCam();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cameraForm.choosecamera();
            timer1.Enabled = true;
        }
    }
}
