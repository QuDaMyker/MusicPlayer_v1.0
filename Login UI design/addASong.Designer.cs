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
            this.btnImport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_addASongTittle
            // 
            this.lb_addASongTittle.AutoSize = true;
            this.lb_addASongTittle.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_addASongTittle.Location = new System.Drawing.Point(4, 0);
            this.lb_addASongTittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_addASongTittle.Name = "lb_addASongTittle";
            this.lb_addASongTittle.Size = new System.Drawing.Size(253, 52);
            this.lb_addASongTittle.TabIndex = 0;
            this.lb_addASongTittle.Text = "Add A Song";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_addASongTittle);
            this.panel1.Location = new System.Drawing.Point(24, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 50);
            this.panel1.TabIndex = 0;
            // 
            // lb_SourceSong
            // 
            this.lb_SourceSong.AutoSize = true;
            this.lb_SourceSong.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SourceSong.Location = new System.Drawing.Point(409, 154);
            this.lb_SourceSong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_SourceSong.Name = "lb_SourceSong";
            this.lb_SourceSong.Size = new System.Drawing.Size(264, 52);
            this.lb_SourceSong.TabIndex = 0;
            this.lb_SourceSong.Text = "Source Song";
            // 
            // lb_DataSong
            // 
            this.lb_DataSong.AutoSize = true;
            this.lb_DataSong.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DataSong.Location = new System.Drawing.Point(1596, 154);
            this.lb_DataSong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_DataSong.Name = "lb_DataSong";
            this.lb_DataSong.Size = new System.Drawing.Size(222, 52);
            this.lb_DataSong.TabIndex = 0;
            this.lb_DataSong.Text = "Data Song";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.webBrowserData);
            this.panel3.Location = new System.Drawing.Point(1259, 308);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1020, 831);
            this.panel3.TabIndex = 1;
            // 
            // webBrowserData
            // 
            this.webBrowserData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserData.Location = new System.Drawing.Point(0, 0);
            this.webBrowserData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowserData.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowserData.Name = "webBrowserData";
            this.webBrowserData.Size = new System.Drawing.Size(1020, 831);
            this.webBrowserData.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.webBrowserSource);
            this.panel2.Location = new System.Drawing.Point(24, 308);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 831);
            this.panel2.TabIndex = 1;
            // 
            // webBrowserSource
            // 
            this.webBrowserSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserSource.Location = new System.Drawing.Point(0, 0);
            this.webBrowserSource.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowserSource.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowserSource.Name = "webBrowserSource";
            this.webBrowserSource.Size = new System.Drawing.Size(1020, 831);
            this.webBrowserSource.TabIndex = 0;
            // 
            // tbPathSouce
            // 
            this.tbPathSouce.Location = new System.Drawing.Point(24, 273);
            this.tbPathSouce.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPathSouce.Name = "tbPathSouce";
            this.tbPathSouce.ReadOnly = true;
            this.tbPathSouce.Size = new System.Drawing.Size(1019, 22);
            this.tbPathSouce.TabIndex = 2;
            // 
            // btnCopySong
            // 
            this.btnCopySong.Location = new System.Drawing.Point(1081, 629);
            this.btnCopySong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCopySong.Name = "btnCopySong";
            this.btnCopySong.Size = new System.Drawing.Size(131, 63);
            this.btnCopySong.TabIndex = 3;
            this.btnCopySong.Text = ">>>>>";
            this.btnCopySong.UseVisualStyleBackColor = true;
            this.btnCopySong.Click += new System.EventHandler(this.btnCopySong_Click);
            // 
            // btnRemoveSong
            // 
            this.btnRemoveSong.Location = new System.Drawing.Point(1081, 713);
            this.btnRemoveSong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveSong.Name = "btnRemoveSong";
            this.btnRemoveSong.Size = new System.Drawing.Size(131, 63);
            this.btnRemoveSong.TabIndex = 3;
            this.btnRemoveSong.Text = "<<<<<";
            this.btnRemoveSong.UseVisualStyleBackColor = true;
            // 
            // tbPathDatabase
            // 
            this.tbPathDatabase.Location = new System.Drawing.Point(1259, 273);
            this.tbPathDatabase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPathDatabase.Name = "tbPathDatabase";
            this.tbPathDatabase.ReadOnly = true;
            this.tbPathDatabase.Size = new System.Drawing.Size(1019, 22);
            this.tbPathDatabase.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(24, 187);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(235, 68);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // addASong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnImport);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnImport;
    }
}