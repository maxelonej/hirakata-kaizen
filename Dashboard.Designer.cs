namespace HiraKata_Kaizen
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.header = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.Panel();
            this.content = new System.Windows.Forms.Panel();
            this.btnAbout = new HiraKata_Kaizen.CustomButton();
            this.btnSettings = new HiraKata_Kaizen.CustomButton();
            this.btnAchievements = new HiraKata_Kaizen.CustomButton();
            this.btnStatistics = new HiraKata_Kaizen.CustomButton();
            this.btnLearn = new HiraKata_Kaizen.CustomButton();
            this.btnExplore = new HiraKata_Kaizen.CustomButton();
            this.btnHome = new HiraKata_Kaizen.CustomButton();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.header.Controls.Add(this.logo);
            this.header.Controls.Add(this.lblTitle);
            this.header.Controls.Add(this.btnMinimize);
            this.header.Controls.Add(this.btnMaximize);
            this.header.Controls.Add(this.btnClose);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1079, 44);
            this.header.TabIndex = 1;
            this.header.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.header_MouseDoubleClick);
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.header_MouseMove);
            this.header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.header_MouseUp);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(11, 5);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(36, 35);
            this.logo.TabIndex = 10;
            this.logo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(51, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(159, 23);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "HiraKata Kaizen";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(946, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(43, 44);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimize.TabIndex = 8;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(989, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(45, 44);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMaximize.TabIndex = 8;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1034, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 44);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClose.TabIndex = 8;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.sidebar.Controls.Add(this.btnAbout);
            this.sidebar.Controls.Add(this.btnSettings);
            this.sidebar.Controls.Add(this.btnAchievements);
            this.sidebar.Controls.Add(this.btnStatistics);
            this.sidebar.Controls.Add(this.btnLearn);
            this.sidebar.Controls.Add(this.btnExplore);
            this.sidebar.Controls.Add(this.btnHome);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 44);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(235, 469);
            this.sidebar.TabIndex = 10;
            // 
            // content
            // 
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(235, 44);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(844, 469);
            this.content.TabIndex = 12;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnAbout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnAbout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAbout.BorderRadius = 10;
            this.btnAbout.BorderSize = 0;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(11, 299);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAbout.Size = new System.Drawing.Size(208, 40);
            this.btnAbout.TabIndex = 17;
            this.btnAbout.Text = "   О проекте";
            this.btnAbout.TextColor = System.Drawing.Color.White;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnSettings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnSettings.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSettings.BorderRadius = 10;
            this.btnSettings.BorderSize = 0;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(11, 253);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.btnSettings.Size = new System.Drawing.Size(208, 40);
            this.btnSettings.TabIndex = 17;
            this.btnSettings.Text = "   Настройки";
            this.btnSettings.TextColor = System.Drawing.Color.White;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAchievements
            // 
            this.btnAchievements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnAchievements.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnAchievements.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAchievements.BorderRadius = 10;
            this.btnAchievements.BorderSize = 0;
            this.btnAchievements.FlatAppearance.BorderSize = 0;
            this.btnAchievements.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnAchievements.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnAchievements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAchievements.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnAchievements.ForeColor = System.Drawing.Color.White;
            this.btnAchievements.Image = ((System.Drawing.Image)(resources.GetObject("btnAchievements.Image")));
            this.btnAchievements.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAchievements.Location = new System.Drawing.Point(13, 207);
            this.btnAchievements.Name = "btnAchievements";
            this.btnAchievements.Padding = new System.Windows.Forms.Padding(10, 0, 7, 0);
            this.btnAchievements.Size = new System.Drawing.Size(206, 40);
            this.btnAchievements.TabIndex = 17;
            this.btnAchievements.Text = "   Достижения";
            this.btnAchievements.TextColor = System.Drawing.Color.White;
            this.btnAchievements.UseVisualStyleBackColor = false;
            this.btnAchievements.Click += new System.EventHandler(this.btnAchievements_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnStatistics.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnStatistics.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnStatistics.BorderRadius = 10;
            this.btnStatistics.BorderSize = 0;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnStatistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnStatistics.ForeColor = System.Drawing.Color.White;
            this.btnStatistics.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistics.Image")));
            this.btnStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistics.Location = new System.Drawing.Point(13, 161);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Padding = new System.Windows.Forms.Padding(10, 0, 13, 0);
            this.btnStatistics.Size = new System.Drawing.Size(206, 40);
            this.btnStatistics.TabIndex = 17;
            this.btnStatistics.Text = "   Статистика";
            this.btnStatistics.TextColor = System.Drawing.Color.White;
            this.btnStatistics.UseVisualStyleBackColor = false;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnLearn
            // 
            this.btnLearn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnLearn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnLearn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLearn.BorderRadius = 10;
            this.btnLearn.BorderSize = 0;
            this.btnLearn.FlatAppearance.BorderSize = 0;
            this.btnLearn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnLearn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnLearn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLearn.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnLearn.ForeColor = System.Drawing.Color.White;
            this.btnLearn.Image = ((System.Drawing.Image)(resources.GetObject("btnLearn.Image")));
            this.btnLearn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLearn.Location = new System.Drawing.Point(13, 115);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Padding = new System.Windows.Forms.Padding(10, 0, 42, 0);
            this.btnLearn.Size = new System.Drawing.Size(206, 40);
            this.btnLearn.TabIndex = 17;
            this.btnLearn.Text = "   Изучить";
            this.btnLearn.TextColor = System.Drawing.Color.White;
            this.btnLearn.UseVisualStyleBackColor = false;
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            // 
            // btnExplore
            // 
            this.btnExplore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnExplore.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnExplore.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExplore.BorderRadius = 10;
            this.btnExplore.BorderSize = 0;
            this.btnExplore.FlatAppearance.BorderSize = 0;
            this.btnExplore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnExplore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnExplore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExplore.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnExplore.ForeColor = System.Drawing.Color.White;
            this.btnExplore.Image = ((System.Drawing.Image)(resources.GetObject("btnExplore.Image")));
            this.btnExplore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExplore.Location = new System.Drawing.Point(13, 69);
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExplore.Size = new System.Drawing.Size(206, 40);
            this.btnExplore.TabIndex = 16;
            this.btnExplore.Text = "   Исследовать";
            this.btnExplore.TextColor = System.Drawing.Color.White;
            this.btnExplore.UseVisualStyleBackColor = false;
            this.btnExplore.Click += new System.EventHandler(this.btnExplore_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnHome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnHome.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHome.BorderRadius = 10;
            this.btnHome.BorderSize = 0;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(13, 23);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 43, 0);
            this.btnHome.Size = new System.Drawing.Size(206, 40);
            this.btnHome.TabIndex = 15;
            this.btnHome.Text = "   Главная";
            this.btnHome.TextColor = System.Drawing.Color.White;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(1079, 513);
            this.Controls.Add(this.content);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.header);
            this.ForeColor = System.Drawing.Color.Snow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HiraKata Kaizen";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel content;
        public System.Windows.Forms.Panel sidebar;
        public CustomButton btnHome;
        public CustomButton btnExplore;
        public CustomButton btnLearn;
        public CustomButton btnStatistics;
        public CustomButton btnAchievements;
        public CustomButton btnSettings;
        public CustomButton btnAbout;
    }
}

