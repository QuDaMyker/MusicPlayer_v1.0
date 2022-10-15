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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_addASongTittle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_SourceSong = new System.Windows.Forms.Label();
            this.lb_DataSong = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(18, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 736);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(889, 189);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(820, 736);
            this.panel3.TabIndex = 1;
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
            // addASong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1721, 939);
            this.Controls.Add(this.lb_DataSong);
            this.Controls.Add(this.lb_SourceSong);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "addASong";
            this.Text = "addASong";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_addASongTittle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_SourceSong;
        private System.Windows.Forms.Label lb_DataSong;
    }
}