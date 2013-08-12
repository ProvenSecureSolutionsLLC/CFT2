using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bench
{
    public partial class formCAMture : Form
    {

        Bitmap image;
        Image image1 = null;

        List<string> files = new List<string>();

        private VideoCaptureDevice VCD = null; 
        public FilterInfoCollection VCD_Collection = null;

        string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer();


        public formCAMture()
        {
            InitializeComponent();
        }

        public PictureBox picture()
        {
            return this.pictureBox1;
        }

        public Panel clientbody()
        {
            return this.panel_ChildBody;
        }


        public ImageList myimages()
        {
            return this.imageList1;
        }


        void VCD_NewFrame(object sender, NewFrameEventArgs eventargs)
        {
            image = (Bitmap)eventargs.Frame.Clone();

            if (this.cb_horiz.Checked == true)
            {
                image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
            if (cb_vert.Checked == true)
            {
                image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            }

            pictureBox1.Image = image;

            if (image != null)
            {
                if ((image.Width < this.panel_camera_image.Width - 4) || (image.Height < this.panel_camera_image.Height - 4))
                {
                    if (!timer2.Enabled)
                    {
                        timer2.Enabled = true;
                    }
                }
            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            /*
            try
            {
                VCD_Collection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                try
                {
                    string s = "";
                    // not needed anymore
                    
                    foreach (FilterInfo device in VCD_Collection)
                    {
                        //combo_Cameras.Items.Add(device.Name);
                        if (s == "") {
                            s = device.MonikerString;
                        }
                    }
                    VCD = new VideoCaptureDevice(s);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("There are no available video capture devices\n" + ex.Message);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to interact with video capture devices\n" + ex.Message);
            }


            
            VCD.NewFrame += new NewFrameEventHandler(VCD_NewFrame);
            VCD.Start(); */
        }


        private void ShutdownCam()
        {
            if (VCD != null && VCD.IsRunning)
            {
                //MessageBox.Show("Shutdown Cam");
                try
                {
                    VCD.SignalToStop();
                    VCD.WaitForStop();
                }
                catch
                {
                    MessageBox.Show("Exception while shutdown cam");
                }
            }

            if (VCD != null)
            {
                //MessageBox.Show("Stop Cam");
                try
                {
                    VCD.Stop();
                }
                catch
                {
                    MessageBox.Show("Exception while Stop cam");
                }
            }
        }

        private void Exit()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;

            ShutdownCam();

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }


        private void form_CAMture_FormClosed(object sender, FormClosedEventArgs e)
        {
            Exit();
        }

        private void combo_Cameras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //timer2.Enabled = false;

            if (image != null)
            {
                panel_camera_image.Width = image.Width + 4;
                panel_camera_image.Height = image.Height + 4;
            }
        }

        private void btn_CamSettings_Click(object sender, EventArgs e)
        {
            if ((VCD != null) && (VCD is VideoCaptureDevice))
            {
                try
                {
                    ((VideoCaptureDevice)VCD).DisplayPropertyPage(this.Handle);
                }
                catch (NotSupportedException)
                {
                    MessageBox.Show("Unable to Launch Property Editor.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btn_ChooseCamera_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;

            if ((VCD != null) && (!VCD.IsRunning))
            {
                VCD.Start();

                btn_ChooseCamera.Text = "Choose Camera";
               
                timer2.Enabled = true;
            }
            else
            {

                ShutdownCam();

                VideoCaptureDeviceForm f = new VideoCaptureDeviceForm();
                f.ShowDialog();
                if (f.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    VCD = f.VideoDevice;
                    VCD.NewFrame += new NewFrameEventHandler(VCD_NewFrame);
                    VCD.Start();

                    timer2.Enabled = true;
                }
            }
        }


        private void TakePic()
        {
        //    myPlayer.SoundLocation = appPath + "\\camera.wav";
        //    myPlayer.Play();

        //    listView1.Items.Clear();
        //    imageList1.Images.Clear();


            if ((VCD != null) && (VCD.IsRunning))
            {

                image1 = (Image)image.Clone();

                try
                {
                    VCD.SignalToStop();
                    VCD.WaitForStop();
                    VCD.Stop();
                }
                catch
                {
                    MessageBox.Show("Error during pause cam");
                }

                if (image1 != null)
                {
                    saveFileDialog1.Filter = "BMP|*.bmp|JPEG|*.jpg";
                    if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        image1.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                    }
                }

                image1 = null;
                VCD.Start();
            }

//            loadimages();
        }

        private void btn_Capture_Image_Click(object sender, EventArgs e)
        {
            TakePic();
        }

        private void loadimages()
        {

            files.Clear();
            imageList1.Images.Clear();
            listView1.Clear();
            string[] part1 = null, part2 = null, part3 = null;

            string p = "c:\\vs2013\\";

            part1 = Directory.GetFiles(p, "*.jpg");
            part2 = Directory.GetFiles(p, "*.jpeg");
            part3 = Directory.GetFiles(p, "*.bmp");


            for (int i = 0; i < part1.Length; i++)
            {
                imageList1.Images.Add(Image.FromFile(part1[i]));
                listView1.Items.Add("", i);
                files.Add(part1[i]);

            }
            for (int i = 0; i < part2.Length; i++)
            {

                imageList1.Images.Add(Image.FromFile(part2[i]));
                listView1.Items.Add("", i);
                files.Add(part2[i]);

            }
            for (int i = 0; i < part3.Length; i++)
            {

                imageList1.Images.Add(Image.FromFile(part3[i]));
                listView1.Items.Add("", i);
                files.Add(part3[i]);

            }
        //    check();
        //    PhotoPlace.Text = p;
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            loadimages();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void panel3_Leave(object sender, EventArgs e)
        {
            if ((VCD != null) && ( VCD.IsRunning ))
            {
                try
                {
                    ShutdownCam();
                    timer2.Enabled = false;
                    btn_ChooseCamera.Text = "Restart";
                }
                finally
                {
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exit();
        }

        

    }
}
