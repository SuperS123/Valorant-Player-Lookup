namespace ValorantPlayerChecker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tag = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.compPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.elo5 = new System.Windows.Forms.Panel();
            this.date5 = new System.Windows.Forms.Label();
            this.rr5 = new System.Windows.Forms.Label();
            this.elo4 = new System.Windows.Forms.Panel();
            this.rr4 = new System.Windows.Forms.Label();
            this.date4 = new System.Windows.Forms.Label();
            this.elo2 = new System.Windows.Forms.Panel();
            this.rr2 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.elo1 = new System.Windows.Forms.Panel();
            this.date1 = new System.Windows.Forms.Label();
            this.rr1 = new System.Windows.Forms.Label();
            this.rankProgress = new System.Windows.Forms.Label();
            this.rank = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.elo3 = new System.Windows.Forms.Panel();
            this.date3 = new System.Windows.Forms.Label();
            this.rr3 = new System.Windows.Forms.Label();
            this.playerPanel = new System.Windows.Forms.Panel();
            this.levelLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.compPanel.SuspendLayout();
            this.elo5.SuspendLayout();
            this.elo4.SuspendLayout();
            this.elo2.SuspendLayout();
            this.elo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.elo3.SuspendLayout();
            this.playerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.settingsPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tag
            // 
            this.tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.tag.Location = new System.Drawing.Point(12, 8);
            this.tag.Name = "tag";
            this.tag.Size = new System.Drawing.Size(767, 35);
            this.tag.TabIndex = 0;
            this.tag.Text = "Player Tag (Ex. Player#1234)";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.button1.Location = new System.Drawing.Point(803, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.compPanel);
            this.mainPanel.Controls.Add(this.playerPanel);
            this.mainPanel.Controls.Add(this.tag);
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Location = new System.Drawing.Point(2, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1000, 519);
            this.mainPanel.TabIndex = 2;
            // 
            // compPanel
            // 
            this.compPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.compPanel.Controls.Add(this.label1);
            this.compPanel.Controls.Add(this.elo5);
            this.compPanel.Controls.Add(this.elo4);
            this.compPanel.Controls.Add(this.elo2);
            this.compPanel.Controls.Add(this.elo1);
            this.compPanel.Controls.Add(this.rankProgress);
            this.compPanel.Controls.Add(this.rank);
            this.compPanel.Controls.Add(this.pictureBox2);
            this.compPanel.Controls.Add(this.label5);
            this.compPanel.Controls.Add(this.label6);
            this.compPanel.Controls.Add(this.elo3);
            this.compPanel.Location = new System.Drawing.Point(457, 61);
            this.compPanel.Name = "compPanel";
            this.compPanel.Size = new System.Drawing.Size(526, 164);
            this.compPanel.TabIndex = 3;
            this.compPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "No Match History";
            this.label1.Visible = false;
            // 
            // elo5
            // 
            this.elo5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.elo5.Controls.Add(this.date5);
            this.elo5.Controls.Add(this.rr5);
            this.elo5.Location = new System.Drawing.Point(407, 65);
            this.elo5.Name = "elo5";
            this.elo5.Size = new System.Drawing.Size(47, 51);
            this.elo5.TabIndex = 9;
            this.elo5.Visible = false;
            // 
            // date5
            // 
            this.date5.AutoSize = true;
            this.date5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.date5.ForeColor = System.Drawing.Color.Black;
            this.date5.Location = new System.Drawing.Point(0, 33);
            this.date5.Name = "date5";
            this.date5.Size = new System.Drawing.Size(47, 18);
            this.date5.TabIndex = 14;
            this.date5.Text = "Jul 12";
            // 
            // rr5
            // 
            this.rr5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rr5.AutoSize = true;
            this.rr5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.rr5.Location = new System.Drawing.Point(-2, 2);
            this.rr5.Name = "rr5";
            this.rr5.Size = new System.Drawing.Size(49, 29);
            this.rr5.TabIndex = 0;
            this.rr5.Text = "-18";
            // 
            // elo4
            // 
            this.elo4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.elo4.Controls.Add(this.rr4);
            this.elo4.Controls.Add(this.date4);
            this.elo4.Location = new System.Drawing.Point(355, 65);
            this.elo4.Name = "elo4";
            this.elo4.Size = new System.Drawing.Size(44, 51);
            this.elo4.TabIndex = 9;
            this.elo4.Visible = false;
            // 
            // rr4
            // 
            this.rr4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rr4.AutoSize = true;
            this.rr4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.rr4.Location = new System.Drawing.Point(1, 2);
            this.rr4.Name = "rr4";
            this.rr4.Size = new System.Drawing.Size(49, 29);
            this.rr4.TabIndex = 0;
            this.rr4.Text = "-17";
            // 
            // date4
            // 
            this.date4.AutoSize = true;
            this.date4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.date4.ForeColor = System.Drawing.Color.Black;
            this.date4.Location = new System.Drawing.Point(-1, 33);
            this.date4.Name = "date4";
            this.date4.Size = new System.Drawing.Size(47, 18);
            this.date4.TabIndex = 13;
            this.date4.Text = "Jul 14";
            // 
            // elo2
            // 
            this.elo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.elo2.Controls.Add(this.rr2);
            this.elo2.Controls.Add(this.date2);
            this.elo2.Location = new System.Drawing.Point(251, 65);
            this.elo2.Name = "elo2";
            this.elo2.Size = new System.Drawing.Size(46, 51);
            this.elo2.TabIndex = 7;
            this.elo2.Visible = false;
            // 
            // rr2
            // 
            this.rr2.AutoSize = true;
            this.rr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.rr2.Location = new System.Drawing.Point(0, 0);
            this.rr2.Name = "rr2";
            this.rr2.Size = new System.Drawing.Size(36, 25);
            this.rr2.TabIndex = 0;
            this.rr2.Text = "+7";
            this.rr2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date2
            // 
            this.date2.AutoSize = true;
            this.date2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.date2.ForeColor = System.Drawing.Color.Black;
            this.date2.Location = new System.Drawing.Point(-1, 29);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(47, 18);
            this.date2.TabIndex = 11;
            this.date2.Text = "Jul 14";
            // 
            // elo1
            // 
            this.elo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.elo1.Controls.Add(this.date1);
            this.elo1.Controls.Add(this.rr1);
            this.elo1.Location = new System.Drawing.Point(199, 65);
            this.elo1.Name = "elo1";
            this.elo1.Size = new System.Drawing.Size(46, 51);
            this.elo1.TabIndex = 6;
            this.elo1.Visible = false;
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.date1.ForeColor = System.Drawing.Color.Black;
            this.date1.Location = new System.Drawing.Point(-1, 33);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(47, 18);
            this.date1.TabIndex = 10;
            this.date1.Text = "Jul 15";
            // 
            // rr1
            // 
            this.rr1.AutoSize = true;
            this.rr1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.rr1.Location = new System.Drawing.Point(0, 0);
            this.rr1.Name = "rr1";
            this.rr1.Size = new System.Drawing.Size(56, 29);
            this.rr1.TabIndex = 0;
            this.rr1.Text = "+20";
            this.rr1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rankProgress
            // 
            this.rankProgress.AutoSize = true;
            this.rankProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.rankProgress.ForeColor = System.Drawing.Color.White;
            this.rankProgress.Location = new System.Drawing.Point(103, 86);
            this.rankProgress.Name = "rankProgress";
            this.rankProgress.Size = new System.Drawing.Size(30, 25);
            this.rankProgress.TabIndex = 5;
            this.rankProgress.Text = "...";
            // 
            // rank
            // 
            this.rank.AutoSize = true;
            this.rank.ForeColor = System.Drawing.Color.White;
            this.rank.Location = new System.Drawing.Point(46, 136);
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(16, 13);
            this.rank.TabIndex = 4;
            this.rank.Text = "...";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(33, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(41, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Rank";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(175, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Competitive Status";
            // 
            // elo3
            // 
            this.elo3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.elo3.Controls.Add(this.date3);
            this.elo3.Controls.Add(this.rr3);
            this.elo3.Location = new System.Drawing.Point(303, 65);
            this.elo3.Name = "elo3";
            this.elo3.Size = new System.Drawing.Size(45, 51);
            this.elo3.TabIndex = 8;
            this.elo3.Visible = false;
            // 
            // date3
            // 
            this.date3.AutoSize = true;
            this.date3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.date3.ForeColor = System.Drawing.Color.Black;
            this.date3.Location = new System.Drawing.Point(-1, 29);
            this.date3.Name = "date3";
            this.date3.Size = new System.Drawing.Size(47, 18);
            this.date3.TabIndex = 12;
            this.date3.Text = "Jul 14";
            this.date3.Click += new System.EventHandler(this.label16_Click);
            // 
            // rr3
            // 
            this.rr3.AutoSize = true;
            this.rr3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rr3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.rr3.Location = new System.Drawing.Point(0, 0);
            this.rr3.Name = "rr3";
            this.rr3.Size = new System.Drawing.Size(48, 25);
            this.rr3.TabIndex = 0;
            this.rr3.Text = "+25";
            // 
            // playerPanel
            // 
            this.playerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.playerPanel.Controls.Add(this.levelLabel);
            this.playerPanel.Controls.Add(this.usernameLabel);
            this.playerPanel.Controls.Add(this.pictureBox1);
            this.playerPanel.Location = new System.Drawing.Point(12, 61);
            this.playerPanel.Name = "playerPanel";
            this.playerPanel.Size = new System.Drawing.Size(377, 164);
            this.playerPanel.TabIndex = 2;
            this.playerPanel.Visible = false;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.levelLabel.ForeColor = System.Drawing.Color.White;
            this.levelLabel.Location = new System.Drawing.Point(166, 78);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(30, 25);
            this.levelLabel.TabIndex = 2;
            this.levelLabel.Text = "...";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(166, 40);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(30, 25);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(852, 529);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Settings";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.label4);
            this.settingsPanel.Controls.Add(this.panel3);
            this.settingsPanel.Location = new System.Drawing.Point(1042, 125);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(1000, 519);
            this.settingsPanel.TabIndex = 3;
            this.settingsPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(365, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "MORE SETTINGS SOON!";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(24, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(377, 164);
            this.panel3.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "North America, Latin America or Brazil",
            "Europe",
            "Korea",
            "Asia-Pacific"});
            this.comboBox1.Location = new System.Drawing.Point(19, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(343, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Region";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1004, 561);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "VALORANT Player Lookup v1.1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.compPanel.ResumeLayout(false);
            this.compPanel.PerformLayout();
            this.elo5.ResumeLayout(false);
            this.elo5.PerformLayout();
            this.elo4.ResumeLayout(false);
            this.elo4.PerformLayout();
            this.elo2.ResumeLayout(false);
            this.elo2.PerformLayout();
            this.elo1.ResumeLayout(false);
            this.elo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.elo3.ResumeLayout(false);
            this.elo3.PerformLayout();
            this.playerPanel.ResumeLayout(false);
            this.playerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tag;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel playerPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel compPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label rank;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel elo5;
        private System.Windows.Forms.Label rr5;
        private System.Windows.Forms.Panel elo4;
        private System.Windows.Forms.Label rr4;
        private System.Windows.Forms.Panel elo3;
        private System.Windows.Forms.Label rr3;
        private System.Windows.Forms.Panel elo2;
        private System.Windows.Forms.Label rr2;
        private System.Windows.Forms.Panel elo1;
        private System.Windows.Forms.Label rr1;
        private System.Windows.Forms.Label rankProgress;
        private System.Windows.Forms.Label date5;
        private System.Windows.Forms.Label date4;
        private System.Windows.Forms.Label date3;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label label1;
    }
}

