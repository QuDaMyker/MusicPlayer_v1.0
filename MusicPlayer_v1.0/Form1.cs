using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer_v1._0
{
    public partial class dashBoard : Form
    {
        public dashBoard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You Want Exit?", "Want something else?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("Thank For Using😍");
                Application.Exit();
            }
            else if(dr == DialogResult.No)
            {
                MessageBox.Show("Thank For Using😍");
            }
        }

        private void btn_addSong_Click(object sender, EventArgs e)
        {
            addASong addASong = new addASong();
            addASong.Show();
        }
    }
}
