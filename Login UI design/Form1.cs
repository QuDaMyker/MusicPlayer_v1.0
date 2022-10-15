using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_UI_design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (guna2PictureBox3.Tag == "hide")
            {
                guna2PictureBox3.Image = Login_UI_design.Properties.Resources.eye;
                guna2TextBox3.PasswordChar = '\0';
                guna2PictureBox3.Tag = "eye";
            }
            else
            {
                guna2PictureBox3.Image = Login_UI_design.Properties.Resources.hidden;
                guna2TextBox3.PasswordChar = '●';
                guna2PictureBox3.Tag = "hide";

            }
        }

        private void guna2Button2_MouseHover(object sender, EventArgs e)
        {
            guna2CirclePictureBox1.BackColor = Color.RoyalBlue;
        }

        private void guna2Button2_MouseMove(object sender, MouseEventArgs e)
        {
            guna2CirclePictureBox1.BackColor = Color.DodgerBlue;
        }
    }
}
