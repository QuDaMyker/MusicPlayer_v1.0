using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer_v1._0
{
    
    public partial class addASong : Form
    {
        static string usernameAccountPC = Environment.UserName;
        public addASong()
        {
            InitializeComponent();
            loadSong();
        }
        private void loadSong()
        {
            using (FolderBrowserDialog sc = new FolderBrowserDialog() { Description = "Choose Path" })
            {
                
                //string usernameAccountPC = null;
                string defaultPath = $"C:\\Users\\{usernameAccountPC}\\Downloads\\Music";
                
                if(System.IO.Directory.Exists(defaultPath))
                {
                    sc.SelectedPath = defaultPath;
                    webBrowserSource.Url = new Uri(sc.SelectedPath);
                    tbPathSouce.Text = sc.SelectedPath;
                }
                else
                {
                    DialogResult ask = MessageBox.Show("Path Default Souce Song Not Found, Please Choose Your Path", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if(ask == DialogResult.Yes)
                    {
                        using (FolderBrowserDialog fd = new FolderBrowserDialog() { Description = "Choose Path" })
                        {
                            if(fd.ShowDialog() == DialogResult.OK)
                            {
                                webBrowserSource.Url = new Uri(fd.SelectedPath);
                                tbPathSouce.Text = fd.SelectedPath;
                            }
                        }
                    }
                    else if(ask == DialogResult.No)
                    {
                        DialogResult ask_n = MessageBox.Show("Can't Play Song, Please Choose Path Again!");
                        if(ask_n == DialogResult.OK)
                        {
                            using (FolderBrowserDialog fd = new FolderBrowserDialog() { Description = "Choose Path" })
                            {
                                if (fd.ShowDialog() == DialogResult.OK)
                                {
                                    webBrowserSource.Url = new Uri(fd.SelectedPath);
                                    tbPathSouce.Text = sc.SelectedPath;
                                }
                            }
                        }
                    }
                }
            }

            using (FolderBrowserDialog db = new FolderBrowserDialog() { Description = "Choose Path" })
            {
                db.SelectedPath = "E:\\UIT University\\Semester 3\\IT008.N13 - Lập trình trực quan\\Đồ Án\\MusicPlayer_v1.0\\listSong";
                webBrowserData.Url = new Uri(db.SelectedPath);
                tbPathDatabase.Text = db.SelectedPath;
            }

        }
        private void btnCopySong_Click(object sender, EventArgs e)
        {
            string fileName = null;
            string sourcePath = null;
            string databasePath = "E:\\UIT University\\Semester 3\\IT008.N13 - Lập trình trực quan\\Đồ Án\\MusicPlayer_v1.0\\listSong";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = Path.GetFileName(openFileDialog1.FileName);
                sourcePath = Path.GetFullPath(openFileDialog1.FileName);
                
                if(System.IO.Directory.Exists(databasePath + $"\\{fileName}") == false)
                {
                    File.Copy(sourcePath, databasePath + $"\\{fileName}");
                }
                else
                {
                    MessageBox.Show("File Exist, Can't Be Copy");
                }
                
            }
            else
            {
                MessageBox.Show("Please Select Your File");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fd = new FolderBrowserDialog() { Description = "Choose Path" })
            {
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    webBrowserSource.Url = new Uri(fd.SelectedPath);
                    tbPathSouce.Text = fd.SelectedPath;
                }
            }
        }
    }
}
