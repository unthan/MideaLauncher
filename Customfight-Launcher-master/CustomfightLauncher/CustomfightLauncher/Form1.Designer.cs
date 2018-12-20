namespace CustomfightLauncher
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progressLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.launcherVersionLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.onlineLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.forumLabel = new System.Windows.Forms.LinkLabel();
            this.changelogLabel = new System.Windows.Forms.LinkLabel();
            this.websiteLabel = new System.Windows.Forms.LinkLabel();
            this.newsLabel = new System.Windows.Forms.Label();
            this.richTextBoxNews = new System.Windows.Forms.RichTextBox();
            this.serverStatusLabel = new System.Windows.Forms.Label();
            this.BackgroundMoveFiles = new System.ComponentModel.BackgroundWorker();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.ForestGreen;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(598, 580);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(472, 84);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.progressBar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.progressBar.Location = new System.Drawing.Point(12, 580);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(578, 84);
            this.progressBar.TabIndex = 2;
            this.progressBar.Visible = false;
            this.progressBar.Click += new System.EventHandler(this.ProgressBar_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressLabel.Location = new System.Drawing.Point(250, 613);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(0, 20);
            this.progressLabel.TabIndex = 3;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.versionLabel.Location = new System.Drawing.Point(13, 667);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(0, 13);
            this.versionLabel.TabIndex = 4;
            // 
            // launcherVersionLabel
            // 
            this.launcherVersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.launcherVersionLabel.AutoSize = true;
            this.launcherVersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.launcherVersionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.launcherVersionLabel.Location = new System.Drawing.Point(945, 668);
            this.launcherVersionLabel.Name = "launcherVersionLabel";
            this.launcherVersionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.launcherVersionLabel.Size = new System.Drawing.Size(0, 13);
            this.launcherVersionLabel.TabIndex = 5;
            this.launcherVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.Controls.Add(this.onlineLabel);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.newsLabel);
            this.mainPanel.Controls.Add(this.richTextBoxNews);
            this.mainPanel.Controls.Add(this.serverStatusLabel);
            this.mainPanel.Font = new System.Drawing.Font("Futura Std Medium", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPanel.ForeColor = System.Drawing.Color.ForestGreen;
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1058, 562);
            this.mainPanel.TabIndex = 6;
            // 
            // onlineLabel
            // 
            this.onlineLabel.AutoSize = true;
            this.onlineLabel.BackColor = System.Drawing.Color.Transparent;
            this.onlineLabel.Font = new System.Drawing.Font("Futura Std Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineLabel.ForeColor = System.Drawing.Color.White;
            this.onlineLabel.Location = new System.Drawing.Point(149, 168);
            this.onlineLabel.Name = "onlineLabel";
            this.onlineLabel.Size = new System.Drawing.Size(71, 27);
            this.onlineLabel.TabIndex = 8;
            this.onlineLabel.Text = "Online";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CustomfightLauncher.Properties.Resources.customfight41;
            this.pictureBox1.Location = new System.Drawing.Point(242, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.forumLabel);
            this.panel1.Controls.Add(this.changelogLabel);
            this.panel1.Controls.Add(this.websiteLabel);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(28, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 222);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura Std Medium", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Important Links";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // forumLabel
            // 
            this.forumLabel.AutoSize = true;
            this.forumLabel.LinkColor = System.Drawing.Color.White;
            this.forumLabel.Location = new System.Drawing.Point(3, 73);
            this.forumLabel.Name = "forumLabel";
            this.forumLabel.Size = new System.Drawing.Size(63, 25);
            this.forumLabel.TabIndex = 1;
            this.forumLabel.TabStop = true;
            this.forumLabel.Text = "Forum";
            this.forumLabel.VisitedLinkColor = System.Drawing.Color.ForestGreen;
            this.forumLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForumLabel_LinkClicked);
            // 
            // changelogLabel
            // 
            this.changelogLabel.AutoSize = true;
            this.changelogLabel.LinkColor = System.Drawing.Color.White;
            this.changelogLabel.Location = new System.Drawing.Point(3, 162);
            this.changelogLabel.Name = "changelogLabel";
            this.changelogLabel.Size = new System.Drawing.Size(109, 25);
            this.changelogLabel.TabIndex = 5;
            this.changelogLabel.TabStop = true;
            this.changelogLabel.Text = "Changelogs";
            this.changelogLabel.VisitedLinkColor = System.Drawing.Color.ForestGreen;
            this.changelogLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChangelogLabel_LinkClicked);
            // 
            // websiteLabel
            // 
            this.websiteLabel.AutoSize = true;
            this.websiteLabel.LinkColor = System.Drawing.Color.White;
            this.websiteLabel.Location = new System.Drawing.Point(3, 118);
            this.websiteLabel.Name = "websiteLabel";
            this.websiteLabel.Size = new System.Drawing.Size(79, 25);
            this.websiteLabel.TabIndex = 2;
            this.websiteLabel.TabStop = true;
            this.websiteLabel.Text = "Website";
            this.websiteLabel.VisitedLinkColor = System.Drawing.Color.ForestGreen;
            this.websiteLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WebsiteLabel_LinkClicked);
            // 
            // newsLabel
            // 
            this.newsLabel.AutoSize = true;
            this.newsLabel.Font = new System.Drawing.Font("Futura Std Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsLabel.ForeColor = System.Drawing.Color.Black;
            this.newsLabel.Location = new System.Drawing.Point(581, 168);
            this.newsLabel.Name = "newsLabel";
            this.newsLabel.Size = new System.Drawing.Size(70, 27);
            this.newsLabel.TabIndex = 4;
            this.newsLabel.Text = "News:";
            // 
            // richTextBoxNews
            // 
            this.richTextBoxNews.BackColor = System.Drawing.Color.LightSteelBlue;
            this.richTextBoxNews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxNews.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxNews.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxNews.Location = new System.Drawing.Point(586, 198);
            this.richTextBoxNews.Name = "richTextBoxNews";
            this.richTextBoxNews.ReadOnly = true;
            this.richTextBoxNews.Size = new System.Drawing.Size(469, 361);
            this.richTextBoxNews.TabIndex = 3;
            this.richTextBoxNews.Text = "";
            // 
            // serverStatusLabel
            // 
            this.serverStatusLabel.AutoSize = true;
            this.serverStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.serverStatusLabel.Font = new System.Drawing.Font("Futura Std Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverStatusLabel.ForeColor = System.Drawing.Color.White;
            this.serverStatusLabel.Location = new System.Drawing.Point(23, 168);
            this.serverStatusLabel.Name = "serverStatusLabel";
            this.serverStatusLabel.Size = new System.Drawing.Size(131, 27);
            this.serverStatusLabel.TabIndex = 0;
            this.serverStatusLabel.Text = "Serverstatus:";
            // 
            // BackgroundMoveFiles
            // 
            this.BackgroundMoveFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundMoveFiles_DoWork);
            this.BackgroundMoveFiles.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundMoveFiles_ProgressChanged);
            this.BackgroundMoveFiles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundMoveFiles_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::CustomfightLauncher.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 690);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.launcherVersionLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customfight Launcher";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label launcherVersionLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label newsLabel;
        private System.Windows.Forms.RichTextBox richTextBoxNews;
        private System.Windows.Forms.LinkLabel websiteLabel;
        private System.Windows.Forms.LinkLabel forumLabel;
        private System.Windows.Forms.Label serverStatusLabel;
        private System.Windows.Forms.LinkLabel changelogLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label onlineLabel;
        private System.ComponentModel.BackgroundWorker BackgroundMoveFiles;
    }
}

