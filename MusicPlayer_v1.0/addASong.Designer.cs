namespace MusicPlayer_v1._0
{
    partial class addASong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_addASongTittle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_SourceSong = new System.Windows.Forms.Label();
            this.lb_DataSong = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.webBrowserData = new System.Windows.Forms.WebBrowser();
            this.panel2 = new System.Windows.Forms.Panel();
            this.webBrowserSource = new System.Windows.Forms.WebBrowser();
            this.tbPathSouce = new System.Windows.Forms.TextBox();
            this.btnCopySong = new System.Windows.Forms.Button();
            this.btnRemoveSong = new System.Windows.Forms.Button();
            this.tbPathDatabase = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_addASongTittle
            // 
            this.lb_addASongTittle.AutoSize = true;
            this.lb_addASongTittle.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_addASongTittle.Location = new System.Drawing.Point(3, 0);
            this.lb_addASongTittle.Name = "lb_addASongTittle";
            this.lb_addASongTittle.Size = new System.Drawing.Size(200, 41);
            this.lb_addASongTittle.TabIndex = 0;
            this.lb_addASongTittle.Text = "Add A Song";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_addASongTittle);
            this.panel1.Location = new System.Drawing.Point(18, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 41);
            this.panel1.TabIndex = 0;
            // 
            // lb_SourceSong
            // 
            this.lb_SourceSong.AutoSize = true;
            this.lb_SourceSong.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SourceSong.Location = new System.Drawing.Point(307, 125);
            this.lb_SourceSong.Name = "lb_SourceSong";
            this.lb_SourceSong.Size = new System.Drawing.Size(209, 41);
            this.lb_SourceSong.TabIndex = 0;
            this.lb_SourceSong.Text = "Source Song";
            // 
            // lb_DataSong
            // 
            this.lb_DataSong.AutoSize = true;
            this.lb_DataSong.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DataSong.Location = new System.Drawing.Point(1197, 125);
            this.lb_DataSong.Name = "lb_DataSong";
            this.lb_DataSong.Size = new System.Drawing.Size(177, 41);
            this.lb_DataSong.TabIndex = 0;
            this.lb_DataSong.Text = "Data Song";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.webBrowserData);
            this.panel3.Location = new System.Drawing.Point(944, 250);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(765, 675);
            this.panel3.TabIndex = 1;
            // 
            // webBrowserData
            // 
            this.webBrowserData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserData.Location = new System.Drawing.Point(0, 0);
            this.webBrowserData.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserData.Name = "webBrowserData";
            this.webBrowserData.Size = new System.Drawing.Size(765, 675);
            this.webBrowserData.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.webBrowserSource);
            this.panel2.Location = new System.Drawing.Point(18, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 675);
            this.panel2.TabIndex = 1;
            // 
            // webBrowserSource
            // 
            this.webBrowserSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserSource.Location = new System.Drawing.Point(0, 0);
            this.webBrowserSource.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserSource.Name = "webBrowserSource";
            this.webBrowserSource.Size = new System.Drawing.Size(765, 675);
            this.webBrowserSource.TabIndex = 0;
            // 
            // tbPathSouce
            // 
            this.tbPathSouce.Location = new System.Drawing.Point(18, 222);
            this.tbPathSouce.Name = "tbPathSouce";
            this.tbPathSouce.ReadOnly = true;
            this.tbPathSouce.Size = new System.Drawing.Size(765, 20);
            this.tbPathSouce.TabIndex = 2;
            // 
            // btnCopySong
            // 
            this.btnCopySong.Location = new System.Drawing.Point(811, 511);
            this.btnCopySong.Name = "btnCopySong";
            this.btnCopySong.Size = new System.Drawing.Size(98, 51);
            this.btnCopySong.TabIndex = 3;
            this.btnCopySong.Text = ">>>>>";
            this.btnCopySong.UseVisualStyleBackColor = true;
            this.btnCopySong.Click += new System.EventHandler(this.btnCopySong_Click);
            // 
            // btnRemoveSong
            // 
            this.btnRemoveSong.Location = new System.Drawing.Point(811, 579);
            this.btnRemoveSong.Name = "btnRemoveSong";
            this.btnRemoveSong.Size = new System.Drawing.Size(98, 51);
            this.btnRemoveSong.TabIndex = 3;
            this.btnRemoveSong.Text = "<<<<<";
            this.btnRemoveSong.UseVisualStyleBackColor = true;
            // 
            // tbPathDatabase
            // 
            this.tbPathDatabase.Location = new System.Drawing.Point(944, 222);
            this.tbPathDatabase.Name = "tbPathDatabase";
            this.tbPathDatabase.ReadOnly = true;
            this.tbPathDatabase.Size = new System.Drawing.Size(765, 20);
            this.tbPathDatabase.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // addASong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1721, 939);
            this.Controls.Add(this.btnRemoveSong);
            this.Controls.Add(this.btnCopySong);
            this.Controls.Add(this.tbPathDatabase);
            this.Controls.Add(this.tbPathSouce);
            this.Controls.Add(this.lb_DataSong);
            this.Controls.Add(this.lb_SourceSong);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "addASong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addASong";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_addASongTittle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_SourceSong;
        private System.Windows.Forms.Label lb_DataSong;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.WebBrowser webBrowserData;
        private System.Windows.Forms.WebBrowser webBrowserSource;
        private System.Windows.Forms.TextBox tbPathSouce;
        private System.Windows.Forms.Button btnCopySong;
        private System.Windows.Forms.Button btnRemoveSong;
        private System.Windows.Forms.TextBox tbPathDatabase;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}