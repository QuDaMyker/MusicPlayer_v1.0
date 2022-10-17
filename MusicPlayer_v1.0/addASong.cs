using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer_v1._0
{
    public partial class addASong : Form
    {
        public addASong()
        {
            InitializeComponent();
            loadSongInSource();
            loadSongInDatabase();
        }
        private void loadSongInSource()
        {
            using (FolderBrowserDialog sc = new FolderBrowserDialog() { Description = "Choose Path" })
            {
                string usernameAccountPC = Environment.UserName;
                sc.SelectedPath = $"C:\\Users\\{usernameAccountPC}\\Downloads\\Music";
                webBrowserSource.Url = new Uri(sc.SelectedPath);
                tbPath.Text = sc.SelectedPath;
            }
        }

        private void loadSongInDatabase()
        {
            using (FolderBrowserDialog db = new FolderBrowserDialog() { Description = "Choose Path" })
            {
                db.SelectedPath = "C:\\Users\\quocd\\Downloads\\Music";
                webBrowserSource.Url = new Uri(db.SelectedPath);
                tbPath.Text = db.SelectedPath;
            }
        }
    }
}
