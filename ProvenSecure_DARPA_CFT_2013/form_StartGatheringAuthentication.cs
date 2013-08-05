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
    public partial class form_StartGatheringAuthentication : Form
    {
        public form_StartGatheringAuthentication()
        {
            InitializeComponent();
        }

        public void MoveItem(int direction, ListBox listBox1)
        {
            // Checking selected item
            if (listBox1.SelectedItem == null || listBox1.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = listBox1.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= listBox1.Items.Count)
                return; // Index out of range - nothing to do

            object selected = listBox1.SelectedItem;

            // Removing removable element
            listBox1.Items.Remove(selected);
            // Insert it in new position
            listBox1.Items.Insert(newIndex, selected);
            // Restore selection
            listBox1.SetSelected(newIndex, true);
        }

        private void btn_MoveUp_Click(object sender, EventArgs e)
        {
            MoveItem(-1, this.lb_AuthenticationEnvironment);
        }

        private void btn_MoveDown_Click(object sender, EventArgs e)
        {
            MoveItem(1, this.lb_AuthenticationEnvironment);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
