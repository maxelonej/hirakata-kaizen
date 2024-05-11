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
            this.btnMinimize = new HiraKata_Kaizen.CustomButton();
            this.btnClose = new HiraKata_Kaizen.CustomButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.Panel();
            this.btnAchievements = new HiraKata_Kaizen.CustomButton();
            this.btnSettings = new HiraKata_Kaizen.CustomButton();
            this.btnCreate = new HiraKata_Kaizen.CustomButton();
            this.btnAbout = new HiraKata_Kaizen.CustomButton();
            this.btnStatistics = new HiraKata_Kaizen.CustomButton();
            this.btnPractice = new HiraKata_Kaizen.CustomButton();
            this.btnExplore = new HiraKata_Kaizen.CustomButton();
            this.btnHome = new HiraKata_Kaizen.CustomButton();
            this.content = new System.Windows.Forms.Panel();
            this.toolTip = new HiraKata_Kaizen.CustomToolTip();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Black;
            this.header.Controls.Add(this.btnMinimize);
            this.header.Controls.Add(this.btnClose);
            this.header.Controls.Add(this.logo);
            this.header.Controls.Add(this.lblTitle);
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
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Black;
            this.btnMinimize.BackgroundColor = System.Drawing.Color.Black;
            this.btnMinimize.BorderColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BorderRadius = 0;
            this.btnMinimize.BorderSize = 0;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(993, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(43, 44);
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.TextColor = System.Drawing.Color.White;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.BackgroundColor = System.Drawing.Color.Black;
            this.btnClose.BorderColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 0;
            this.btnClose.BorderSize = 0;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1036, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 44);
            this.btnClose.TabIndex = 12;
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(17, 5);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(36, 35);
            this.logo.TabIndex = 10;
            this.logo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(64, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(159, 23);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "HiraKata Kaizen";
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.sidebar.Controls.Add(this.btnAchievements);
            this.sidebar.Controls.Add(this.btnSettings);
            this.sidebar.Controls.Add(this.btnCreate);
            this.sidebar.Controls.Add(this.btnAbout);
            this.sidebar.Controls.Add(this.btnStatistics);
            this.sidebar.Controls.Add(this.btnPractice);
            this.sidebar.Controls.Add(this.btnExplore);
            this.sidebar.Controls.Add(this.btnHome);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 44);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(64, 469);
            this.sidebar.TabIndex = 10;
            // 
            // btnAchievements
            // 
            this.btnAchievements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnAchievements.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnAchievements.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAchievements.BorderRadius = 10;
            this.btnAchievements.BorderSize = 0;
            this.btnAchievements.Enabled = false;
            this.btnAchievements.FlatAppearance.BorderSize = 0;
            this.btnAchievements.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAchievements.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAchievements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAchievements.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnAchievements.ForeColor = System.Drawing.Color.White;
            this.btnAchievements.Image = ((System.Drawing.Image)(resources.GetObject("btnAchievements.Image")));
            this.btnAchievements.Location = new System.Drawing.Point(11, 415);
            this.btnAchievements.Name = "btnAchievements";
            this.btnAchievements.Size = new System.Drawing.Size(42, 40);
            this.btnAchievements.TabIndex = 17;
            this.btnAchievements.Text = "   Достижения";
            this.btnAchievements.TextColor = System.Drawing.Color.White;
            this.toolTip.SetToolTip(this.btnAchievements, "Достижения");
            this.btnAchievements.UseVisualStyleBackColor = false;
            this.btnAchievements.Visible = false;
            this.btnAchievements.Click += new System.EventHandler(this.btnAchievements_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnSettings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnSettings.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSettings.BorderRadius = 10;
            this.btnSettings.BorderSize = 0;
            this.btnSettings.Enabled = false;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(11, 369);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(42, 40);
            this.btnSettings.TabIndex = 17;
            this.btnSettings.Text = "   Настройки";
            this.btnSettings.TextColor = System.Drawing.Color.White;
            this.toolTip.SetToolTip(this.btnSettings, "Настройки");
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Visible = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnCreate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnCreate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCreate.BorderRadius = 10;
            this.btnCreate.BorderSize = 0;
            this.btnCreate.Enabled = false;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.Location = new System.Drawing.Point(11, 323);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(42, 40);
            this.btnCreate.TabIndex = 17;
            this.btnCreate.Text = "   Создать";
            this.btnCreate.TextColor = System.Drawing.Color.White;
            this.toolTip.SetToolTip(this.btnCreate, "Создать пак иероглифов");
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Visible = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnAbout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnAbout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAbout.BorderRadius = 10;
            this.btnAbout.BorderSize = 0;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.Location = new System.Drawing.Point(11, 101);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(42, 40);
            this.btnAbout.TabIndex = 17;
            this.btnAbout.Text = "   О проекте";
            this.btnAbout.TextColor = System.Drawing.Color.White;
            this.toolTip.SetToolTip(this.btnAbout, "О проекте");
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnStatistics.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnStatistics.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnStatistics.BorderRadius = 10;
            this.btnStatistics.BorderSize = 0;
            this.btnStatistics.Enabled = false;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnStatistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnStatistics.ForeColor = System.Drawing.Color.White;
            this.btnStatistics.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistics.Image")));
            this.btnStatistics.Location = new System.Drawing.Point(12, 277);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(42, 40);
            this.btnStatistics.TabIndex = 17;
            this.btnStatistics.Text = "   Статистика";
            this.btnStatistics.TextColor = System.Drawing.Color.White;
            this.toolTip.SetToolTip(this.btnStatistics, "Статистика");
            this.btnStatistics.UseVisualStyleBackColor = false;
            this.btnStatistics.Visible = false;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnPractice
            // 
            this.btnPractice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnPractice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnPractice.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPractice.BorderRadius = 10;
            this.btnPractice.BorderSize = 0;
            this.btnPractice.FlatAppearance.BorderSize = 0;
            this.btnPractice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnPractice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPractice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPractice.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnPractice.ForeColor = System.Drawing.Color.White;
            this.btnPractice.Image = ((System.Drawing.Image)(resources.GetObject("btnPractice.Image")));
            this.btnPractice.Location = new System.Drawing.Point(11, 55);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.Size = new System.Drawing.Size(42, 40);
            this.btnPractice.TabIndex = 17;
            this.btnPractice.Text = "   Практика";
            this.btnPractice.TextColor = System.Drawing.Color.White;
            this.toolTip.SetToolTip(this.btnPractice, "Практика");
            this.btnPractice.UseVisualStyleBackColor = false;
            this.btnPractice.Click += new System.EventHandler(this.btnPractice_Click);
            // 
            // btnExplore
            // 
            this.btnExplore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnExplore.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnExplore.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExplore.BorderRadius = 10;
            this.btnExplore.BorderSize = 0;
            this.btnExplore.FlatAppearance.BorderSize = 0;
            this.btnExplore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnExplore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnExplore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExplore.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnExplore.ForeColor = System.Drawing.Color.White;
            this.btnExplore.Image = ((System.Drawing.Image)(resources.GetObject("btnExplore.Image")));
            this.btnExplore.Location = new System.Drawing.Point(12, 9);
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.Size = new System.Drawing.Size(42, 40);
            this.btnExplore.TabIndex = 16;
            this.btnExplore.Text = "   Исследовать";
            this.btnExplore.TextColor = System.Drawing.Color.White;
            this.toolTip.SetToolTip(this.btnExplore, "Исследовать");
            this.btnExplore.UseVisualStyleBackColor = false;
            this.btnExplore.Click += new System.EventHandler(this.btnExplore_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnHome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnHome.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHome.BorderRadius = 10;
            this.btnHome.BorderSize = 0;
            this.btnHome.Enabled = false;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(11, 231);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(42, 40);
            this.btnHome.TabIndex = 15;
            this.btnHome.Text = "   Главная";
            this.btnHome.TextColor = System.Drawing.Color.White;
            this.toolTip.SetToolTip(this.btnHome, "Главная");
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Visible = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.Black;
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(64, 44);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1015, 469);
            this.content.TabIndex = 12;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 200;
            this.toolTip.AutoPopDelay = 4000;
            this.toolTip.BackColor = System.Drawing.Color.Black;
            this.toolTip.ForeColor = System.Drawing.Color.White;
            this.toolTip.InitialDelay = 200;
            this.toolTip.OwnerDraw = true;
            this.toolTip.ReshowDelay = 40;
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
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox logo;
        public System.Windows.Forms.Panel sidebar;
        public CustomButton btnHome;
        public CustomButton btnExplore;
        public CustomButton btnPractice;
        public CustomButton btnStatistics;
        public CustomButton btnAbout;
        private CustomToolTip toolTip;
        public System.Windows.Forms.Panel content;
        public CustomButton btnAchievements;
        public CustomButton btnSettings;
        private CustomButton btnClose;
        private CustomButton btnMinimize;
        public CustomButton btnCreate;
    }
}

