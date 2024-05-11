namespace HiraKata_Kaizen {
    partial class Choice {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choice));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPractice = new HiraKata_Kaizen.CustomButton();
            this.btnStart = new HiraKata_Kaizen.CustomButton();
            this.customPanel5 = new HiraKata_Kaizen.CustomPanel();
            this.cmbAnswers = new HiraKata_Kaizen.CustomComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.customPanel4 = new HiraKata_Kaizen.CustomPanel();
            this.cmbQuestions = new HiraKata_Kaizen.CustomComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.customPanel3 = new HiraKata_Kaizen.CustomPanel();
            this.cmbNumber = new HiraKata_Kaizen.CustomComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.customPanel2 = new HiraKata_Kaizen.CustomPanel();
            this.cmbTime = new HiraKata_Kaizen.CustomComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customPanel1 = new HiraKata_Kaizen.CustomPanel();
            this.customComboBox1 = new HiraKata_Kaizen.CustomComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customPanel6 = new HiraKata_Kaizen.CustomPanel();
            this.cmbPack = new HiraKata_Kaizen.CustomComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip = new HiraKata_Kaizen.CustomToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.customPanel5.SuspendLayout();
            this.customPanel4.SuspendLayout();
            this.customPanel3.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.customPanel1.SuspendLayout();
            this.customPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(494, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(59, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // btnPractice
            // 
            this.btnPractice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPractice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnPractice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnPractice.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPractice.BorderRadius = 10;
            this.btnPractice.BorderSize = 0;
            this.btnPractice.FlatAppearance.BorderSize = 0;
            this.btnPractice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPractice.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnPractice.ForeColor = System.Drawing.Color.White;
            this.btnPractice.Image = ((System.Drawing.Image)(resources.GetObject("btnPractice.Image")));
            this.btnPractice.Location = new System.Drawing.Point(394, 394);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnPractice.Size = new System.Drawing.Size(47, 44);
            this.btnPractice.TabIndex = 17;
            this.btnPractice.TextColor = System.Drawing.Color.White;
            this.toolTip.SetToolTip(this.btnPractice, "Назад");
            this.btnPractice.UseVisualStyleBackColor = false;
            this.btnPractice.Click += new System.EventHandler(this.btnPractice_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Maroon;
            this.btnStart.BackgroundColor = System.Drawing.Color.Maroon;
            this.btnStart.BorderColor = System.Drawing.Color.Transparent;
            this.btnStart.BorderRadius = 10;
            this.btnStart.BorderSize = 0;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(479, 397);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 40);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Начать";
            this.btnStart.TextColor = System.Drawing.Color.White;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // customPanel5
            // 
            this.customPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.customPanel5.BorderRadius = ((byte)(30));
            this.customPanel5.Controls.Add(this.cmbAnswers);
            this.customPanel5.Controls.Add(this.label7);
            this.customPanel5.ForeColor = System.Drawing.Color.Snow;
            this.customPanel5.Location = new System.Drawing.Point(322, 304);
            this.customPanel5.Name = "customPanel5";
            this.customPanel5.Size = new System.Drawing.Size(370, 51);
            this.customPanel5.TabIndex = 3;
            // 
            // cmbAnswers
            // 
            this.cmbAnswers.BackColor = System.Drawing.Color.Maroon;
            this.cmbAnswers.BorderColor = System.Drawing.Color.Black;
            this.cmbAnswers.BorderSize = 0;
            this.cmbAnswers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbAnswers.ForeColor = System.Drawing.Color.White;
            this.cmbAnswers.IconColor = System.Drawing.Color.White;
            this.cmbAnswers.ListBackColor = System.Drawing.Color.Black;
            this.cmbAnswers.ListTextColor = System.Drawing.Color.White;
            this.cmbAnswers.Location = new System.Drawing.Point(200, 11);
            this.cmbAnswers.MinimumSize = new System.Drawing.Size(121, 29);
            this.cmbAnswers.Name = "cmbAnswers";
            this.cmbAnswers.Size = new System.Drawing.Size(153, 29);
            this.cmbAnswers.TabIndex = 1;
            this.cmbAnswers.Texts = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ответы";
            this.toolTip.SetToolTip(this.label7, "В виде чего будут ответы");
            // 
            // customPanel4
            // 
            this.customPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.customPanel4.BorderRadius = ((byte)(30));
            this.customPanel4.Controls.Add(this.cmbQuestions);
            this.customPanel4.Controls.Add(this.label6);
            this.customPanel4.ForeColor = System.Drawing.Color.Snow;
            this.customPanel4.Location = new System.Drawing.Point(322, 234);
            this.customPanel4.Name = "customPanel4";
            this.customPanel4.Size = new System.Drawing.Size(370, 51);
            this.customPanel4.TabIndex = 3;
            // 
            // cmbQuestions
            // 
            this.cmbQuestions.BackColor = System.Drawing.Color.Maroon;
            this.cmbQuestions.BorderColor = System.Drawing.Color.Black;
            this.cmbQuestions.BorderSize = 0;
            this.cmbQuestions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbQuestions.ForeColor = System.Drawing.Color.White;
            this.cmbQuestions.IconColor = System.Drawing.Color.White;
            this.cmbQuestions.ListBackColor = System.Drawing.Color.Black;
            this.cmbQuestions.ListTextColor = System.Drawing.Color.White;
            this.cmbQuestions.Location = new System.Drawing.Point(200, 11);
            this.cmbQuestions.MinimumSize = new System.Drawing.Size(121, 29);
            this.cmbQuestions.Name = "cmbQuestions";
            this.cmbQuestions.Size = new System.Drawing.Size(153, 29);
            this.cmbQuestions.TabIndex = 1;
            this.cmbQuestions.Texts = "";
            this.cmbQuestions.OnSelectedIndexChanged += new System.EventHandler(this.cmbQuestions_OnSelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Вопросы";
            this.toolTip.SetToolTip(this.label6, "Какие вопросы будут задаваться");
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.customPanel3.BorderRadius = ((byte)(30));
            this.customPanel3.Controls.Add(this.cmbNumber);
            this.customPanel3.Controls.Add(this.label5);
            this.customPanel3.ForeColor = System.Drawing.Color.Snow;
            this.customPanel3.Location = new System.Drawing.Point(322, 166);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(370, 51);
            this.customPanel3.TabIndex = 3;
            // 
            // cmbNumber
            // 
            this.cmbNumber.BackColor = System.Drawing.Color.Maroon;
            this.cmbNumber.BorderColor = System.Drawing.Color.Black;
            this.cmbNumber.BorderSize = 0;
            this.cmbNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbNumber.ForeColor = System.Drawing.Color.White;
            this.cmbNumber.IconColor = System.Drawing.Color.White;
            this.cmbNumber.ListBackColor = System.Drawing.Color.Black;
            this.cmbNumber.ListTextColor = System.Drawing.Color.White;
            this.cmbNumber.Location = new System.Drawing.Point(200, 11);
            this.cmbNumber.MinimumSize = new System.Drawing.Size(121, 29);
            this.cmbNumber.Name = "cmbNumber";
            this.cmbNumber.Size = new System.Drawing.Size(153, 29);
            this.cmbNumber.TabIndex = 1;
            this.cmbNumber.Texts = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Количество";
            this.toolTip.SetToolTip(this.label5, "Количество иероглифов");
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.customPanel2.BorderRadius = ((byte)(30));
            this.customPanel2.Controls.Add(this.cmbTime);
            this.customPanel2.Controls.Add(this.label4);
            this.customPanel2.ForeColor = System.Drawing.Color.Snow;
            this.customPanel2.Location = new System.Drawing.Point(322, 99);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(370, 51);
            this.customPanel2.TabIndex = 4;
            // 
            // cmbTime
            // 
            this.cmbTime.BackColor = System.Drawing.Color.Maroon;
            this.cmbTime.BorderColor = System.Drawing.Color.Black;
            this.cmbTime.BorderSize = 0;
            this.cmbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbTime.ForeColor = System.Drawing.Color.White;
            this.cmbTime.IconColor = System.Drawing.Color.White;
            this.cmbTime.ListBackColor = System.Drawing.Color.Black;
            this.cmbTime.ListTextColor = System.Drawing.Color.White;
            this.cmbTime.Location = new System.Drawing.Point(200, 11);
            this.cmbTime.MinimumSize = new System.Drawing.Size(121, 29);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(153, 29);
            this.cmbTime.TabIndex = 1;
            this.cmbTime.Texts = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Время";
            this.toolTip.SetToolTip(this.label4, "Время на ответ, в секундах");
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.customPanel1.BorderRadius = ((byte)(30));
            this.customPanel1.Controls.Add(this.customComboBox1);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Enabled = false;
            this.customPanel1.ForeColor = System.Drawing.Color.Snow;
            this.customPanel1.Location = new System.Drawing.Point(12, 136);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(271, 51);
            this.customPanel1.TabIndex = 3;
            this.customPanel1.Visible = false;
            // 
            // customComboBox1
            // 
            this.customComboBox1.BackColor = System.Drawing.Color.Maroon;
            this.customComboBox1.BorderColor = System.Drawing.Color.Black;
            this.customComboBox1.BorderSize = 0;
            this.customComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customComboBox1.ForeColor = System.Drawing.Color.White;
            this.customComboBox1.IconColor = System.Drawing.Color.White;
            this.customComboBox1.Items.AddRange(new object[] {
            "Обычный",
            "Собственный"});
            this.customComboBox1.ListBackColor = System.Drawing.Color.Black;
            this.customComboBox1.ListTextColor = System.Drawing.Color.White;
            this.customComboBox1.Location = new System.Drawing.Point(107, 11);
            this.customComboBox1.MinimumSize = new System.Drawing.Size(121, 29);
            this.customComboBox1.Name = "customComboBox1";
            this.customComboBox1.Size = new System.Drawing.Size(153, 29);
            this.customComboBox1.TabIndex = 1;
            this.customComboBox1.Texts = "Выбрать";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Категория";
            // 
            // customPanel6
            // 
            this.customPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.customPanel6.BorderRadius = ((byte)(30));
            this.customPanel6.Controls.Add(this.cmbPack);
            this.customPanel6.Controls.Add(this.label3);
            this.customPanel6.ForeColor = System.Drawing.Color.Snow;
            this.customPanel6.Location = new System.Drawing.Point(12, 12);
            this.customPanel6.Name = "customPanel6";
            this.customPanel6.Size = new System.Drawing.Size(370, 51);
            this.customPanel6.TabIndex = 2;
            this.customPanel6.Visible = false;
            // 
            // cmbPack
            // 
            this.cmbPack.BackColor = System.Drawing.Color.Maroon;
            this.cmbPack.BorderColor = System.Drawing.Color.Black;
            this.cmbPack.BorderSize = 0;
            this.cmbPack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbPack.ForeColor = System.Drawing.Color.White;
            this.cmbPack.IconColor = System.Drawing.Color.White;
            this.cmbPack.ListBackColor = System.Drawing.Color.Black;
            this.cmbPack.ListTextColor = System.Drawing.Color.White;
            this.cmbPack.Location = new System.Drawing.Point(200, 11);
            this.cmbPack.MinimumSize = new System.Drawing.Size(121, 29);
            this.cmbPack.Name = "cmbPack";
            this.cmbPack.Size = new System.Drawing.Size(153, 29);
            this.cmbPack.TabIndex = 1;
            this.cmbPack.Texts = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Пак";
            this.toolTip.SetToolTip(this.label3, "Обычный, что сейчас заполняете либо собственный, что создавали на вкладке \"Создан" +
        "ие пака\"");
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolTip.ForeColor = System.Drawing.Color.White;
            this.toolTip.OwnerDraw = true;
            // 
            // Choice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1015, 469);
            this.Controls.Add(this.btnPractice);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.customPanel5);
            this.Controls.Add(this.customPanel4);
            this.Controls.Add(this.customPanel3);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.customPanel6);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Choice";
            this.Text = "Choice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Choice_FormClosing);
            this.Load += new System.EventHandler(this.Choice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.customPanel5.ResumeLayout(false);
            this.customPanel5.PerformLayout();
            this.customPanel4.ResumeLayout(false);
            this.customPanel4.PerformLayout();
            this.customPanel3.ResumeLayout(false);
            this.customPanel3.PerformLayout();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.customPanel6.ResumeLayout(false);
            this.customPanel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomPanel customPanel6;
        private System.Windows.Forms.Label label3;
        private CustomPanel customPanel1;
        private System.Windows.Forms.Label label2;
        private CustomPanel customPanel2;
        private System.Windows.Forms.Label label4;
        private CustomPanel customPanel3;
        private System.Windows.Forms.Label label5;
        private CustomPanel customPanel4;
        private System.Windows.Forms.Label label6;
        private CustomPanel customPanel5;
        private System.Windows.Forms.Label label7;
        private CustomButton btnStart;
        private CustomComboBox customComboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblTitle;
        public CustomButton btnPractice;
        private CustomToolTip toolTip;
        public CustomComboBox cmbPack;
        public CustomComboBox cmbAnswers;
        public CustomComboBox cmbQuestions;
        public CustomComboBox cmbNumber;
        public CustomComboBox cmbTime;
    }
}