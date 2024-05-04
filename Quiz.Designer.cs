namespace HiraKata_Kaizen {
    partial class Quiz {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz));
            this.btnHome = new HiraKata_Kaizen.CustomButton();
            this.statusline = new HiraKata_Kaizen.CustomPanel();
            this.label166 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn4 = new HiraKata_Kaizen.CustomButton();
            this.btn3 = new HiraKata_Kaizen.CustomButton();
            this.btn2 = new HiraKata_Kaizen.CustomButton();
            this.btn1 = new HiraKata_Kaizen.CustomButton();
            this.customPanel1 = new HiraKata_Kaizen.CustomPanel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.toolTip = new HiraKata_Kaizen.CustomToolTip();
            this.statusline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnHome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnHome.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHome.BorderRadius = 10;
            this.btnHome.BorderSize = 0;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(11, 372);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnHome.Size = new System.Drawing.Size(49, 49);
            this.btnHome.TabIndex = 16;
            this.btnHome.TextColor = System.Drawing.Color.White;
            this.toolTip.SetToolTip(this.btnHome, "Выйти");
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // statusline
            // 
            this.statusline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.statusline.BorderRadius = ((byte)(0));
            this.statusline.Controls.Add(this.label6);
            this.statusline.Controls.Add(this.label166);
            this.statusline.Controls.Add(this.pictureBox2);
            this.statusline.Controls.Add(this.pictureBox1);
            this.statusline.Controls.Add(this.lblQuestions);
            this.statusline.Controls.Add(this.label4);
            this.statusline.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusline.ForeColor = System.Drawing.Color.Snow;
            this.statusline.Location = new System.Drawing.Point(0, 432);
            this.statusline.Name = "statusline";
            this.statusline.Size = new System.Drawing.Size(1015, 37);
            this.statusline.TabIndex = 3;
            // 
            // label166
            // 
            this.label166.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label166.Location = new System.Drawing.Point(907, 2);
            this.label166.Name = "label166";
            this.label166.Size = new System.Drawing.Size(23, 28);
            this.label166.TabIndex = 4;
            this.label166.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(498, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(872, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(942, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblQuestions
            // 
            this.lblQuestions.AutoSize = true;
            this.lblQuestions.Location = new System.Drawing.Point(12, 7);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(61, 21);
            this.lblQuestions.TabIndex = 1;
            this.lblQuestions.Text = "0/1000";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label4.Location = new System.Drawing.Point(980, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "0";
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btn4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btn4.BorderColor = System.Drawing.Color.Transparent;
            this.btn4.BorderRadius = 10;
            this.btn4.BorderSize = 0;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(526, 322);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(161, 55);
            this.btn4.TabIndex = 2;
            this.btn4.Tag = "4";
            this.btn4.Text = "Вариант ответа 4";
            this.btn4.TextColor = System.Drawing.Color.White;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btn3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btn3.BorderColor = System.Drawing.Color.Transparent;
            this.btn3.BorderRadius = 10;
            this.btn3.BorderSize = 0;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(328, 322);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(161, 55);
            this.btn3.TabIndex = 2;
            this.btn3.Tag = "3";
            this.btn3.Text = "Вариант ответа 3";
            this.btn3.TextColor = System.Drawing.Color.White;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btn2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btn2.BorderColor = System.Drawing.Color.Transparent;
            this.btn2.BorderRadius = 10;
            this.btn2.BorderSize = 0;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(526, 252);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(161, 55);
            this.btn2.TabIndex = 2;
            this.btn2.Tag = "2";
            this.btn2.Text = "Вариант ответа 2";
            this.btn2.TextColor = System.Drawing.Color.White;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btn1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btn1.BorderColor = System.Drawing.Color.Transparent;
            this.btn1.BorderRadius = 10;
            this.btn1.BorderSize = 0;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(328, 252);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(161, 55);
            this.btn1.TabIndex = 2;
            this.btn1.Tag = "1";
            this.btn1.Text = "Вариант ответа 1";
            this.btn1.TextColor = System.Drawing.Color.White;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.customPanel1.BorderRadius = ((byte)(30));
            this.customPanel1.Controls.Add(this.lblQuestion);
            this.customPanel1.ForeColor = System.Drawing.Color.Snow;
            this.customPanel1.Location = new System.Drawing.Point(339, 92);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(336, 140);
            this.customPanel1.TabIndex = 1;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(137, 60);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(62, 21);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Вопрос";
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.toolTip.ForeColor = System.Drawing.Color.White;
            this.toolTip.OwnerDraw = true;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(1015, 469);
            this.Controls.Add(this.statusline);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.customPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.Snow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.statusline.ResumeLayout(false);
            this.statusline.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private CustomPanel customPanel1;
        private CustomButton btn1;
        private CustomButton btn2;
        private CustomButton btn3;
        private CustomButton btn4;
        private CustomPanel statusline;
        private System.Windows.Forms.Label lblQuestions;
        public CustomButton btnHome;
        private CustomToolTip toolTip;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label166;
    }
}