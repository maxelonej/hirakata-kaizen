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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz));
            this.timeToAnswer = new System.Windows.Forms.Timer(this.components);
            this.pnAnswers = new HiraKata_Kaizen.CustomPanel();
            this.btn4 = new HiraKata_Kaizen.CustomButton();
            this.btn1 = new HiraKata_Kaizen.CustomButton();
            this.btn2 = new HiraKata_Kaizen.CustomButton();
            this.btn3 = new HiraKata_Kaizen.CustomButton();
            this.pnStatus = new HiraKata_Kaizen.CustomPanel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWrongAnswers = new System.Windows.Forms.Label();
            this.lblCorrectAnswers = new System.Windows.Forms.Label();
            this.btnPractice = new HiraKata_Kaizen.CustomButton();
            this.pnQuestions = new HiraKata_Kaizen.CustomPanel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.toolTip = new HiraKata_Kaizen.CustomToolTip();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnAnswers.SuspendLayout();
            this.pnStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnQuestions.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeToAnswer
            // 
            this.timeToAnswer.Enabled = true;
            this.timeToAnswer.Interval = 1000;
            // 
            // pnAnswers
            // 
            this.pnAnswers.BackColor = System.Drawing.Color.Black;
            this.pnAnswers.BorderRadius = ((byte)(30));
            this.pnAnswers.Controls.Add(this.btn4);
            this.pnAnswers.Controls.Add(this.btn1);
            this.pnAnswers.Controls.Add(this.btn2);
            this.pnAnswers.Controls.Add(this.btn3);
            this.pnAnswers.ForeColor = System.Drawing.Color.Snow;
            this.pnAnswers.Location = new System.Drawing.Point(370, 223);
            this.pnAnswers.Name = "pnAnswers";
            this.pnAnswers.Size = new System.Drawing.Size(274, 167);
            this.pnAnswers.TabIndex = 17;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btn4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btn4.BorderColor = System.Drawing.Color.Transparent;
            this.btn4.BorderRadius = 10;
            this.btn4.BorderSize = 0;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(158, 93);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(68, 55);
            this.btn4.TabIndex = 2;
            this.btn4.Tag = "";
            this.btn4.Text = "4dd";
            this.btn4.TextColor = System.Drawing.Color.White;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btn1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btn1.BorderColor = System.Drawing.Color.Transparent;
            this.btn1.BorderRadius = 10;
            this.btn1.BorderSize = 0;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(48, 19);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(68, 55);
            this.btn1.TabIndex = 2;
            this.btn1.Tag = "";
            this.btn1.Text = "1ch";
            this.btn1.TextColor = System.Drawing.Color.White;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btn2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btn2.BorderColor = System.Drawing.Color.Transparent;
            this.btn2.BorderRadius = 10;
            this.btn2.BorderSize = 0;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(158, 19);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(68, 55);
            this.btn2.TabIndex = 2;
            this.btn2.Tag = "";
            this.btn2.Text = "2ts";
            this.btn2.TextColor = System.Drawing.Color.White;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btn3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btn3.BorderColor = System.Drawing.Color.Transparent;
            this.btn3.BorderRadius = 10;
            this.btn3.BorderSize = 0;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(48, 93);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(68, 55);
            this.btn3.TabIndex = 2;
            this.btn3.Tag = "";
            this.btn3.Text = "3sh";
            this.btn3.TextColor = System.Drawing.Color.White;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // pnStatus
            // 
            this.pnStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.pnStatus.BorderRadius = ((byte)(0));
            this.pnStatus.Controls.Add(this.lblTimer);
            this.pnStatus.Controls.Add(this.lblQuestions);
            this.pnStatus.Controls.Add(this.pictureBox2);
            this.pnStatus.Controls.Add(this.pictureBox1);
            this.pnStatus.Controls.Add(this.lblWrongAnswers);
            this.pnStatus.Controls.Add(this.lblCorrectAnswers);
            this.pnStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnStatus.ForeColor = System.Drawing.Color.Snow;
            this.pnStatus.Location = new System.Drawing.Point(0, 427);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(1015, 42);
            this.pnStatus.TabIndex = 3;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.lblTimer.Location = new System.Drawing.Point(477, 10);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(60, 23);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "timer";
            // 
            // lblQuestions
            // 
            this.lblQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestions.AutoSize = true;
            this.lblQuestions.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestions.Location = new System.Drawing.Point(12, 8);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(138, 23);
            this.lblQuestions.TabIndex = 0;
            this.lblQuestions.Text = "сейчас/всего";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(951, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox2, "Количество неправильных ответов");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(885, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox1, "Количество правильных ответов");
            // 
            // lblWrongAnswers
            // 
            this.lblWrongAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWrongAnswers.AutoSize = true;
            this.lblWrongAnswers.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongAnswers.Location = new System.Drawing.Point(976, 8);
            this.lblWrongAnswers.Name = "lblWrongAnswers";
            this.lblWrongAnswers.Size = new System.Drawing.Size(29, 23);
            this.lblWrongAnswers.TabIndex = 0;
            this.lblWrongAnswers.Text = "0 ";
            this.lblWrongAnswers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCorrectAnswers
            // 
            this.lblCorrectAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorrectAnswers.AutoSize = true;
            this.lblCorrectAnswers.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswers.Location = new System.Drawing.Point(910, 8);
            this.lblCorrectAnswers.Name = "lblCorrectAnswers";
            this.lblCorrectAnswers.Size = new System.Drawing.Size(29, 23);
            this.lblCorrectAnswers.TabIndex = 0;
            this.lblCorrectAnswers.Text = "0 ";
            this.lblCorrectAnswers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnPractice.Location = new System.Drawing.Point(6, 371);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnPractice.Size = new System.Drawing.Size(49, 49);
            this.btnPractice.TabIndex = 16;
            this.btnPractice.TextColor = System.Drawing.Color.White;
            this.toolTip.SetToolTip(this.btnPractice, "Выйти");
            this.btnPractice.UseVisualStyleBackColor = false;
            this.btnPractice.Click += new System.EventHandler(this.btnPractice_Click);
            // 
            // pnQuestions
            // 
            this.pnQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.pnQuestions.BorderRadius = ((byte)(30));
            this.pnQuestions.Controls.Add(this.lblQuestion);
            this.pnQuestions.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.pnQuestions.ForeColor = System.Drawing.Color.Snow;
            this.pnQuestions.Location = new System.Drawing.Point(370, 79);
            this.pnQuestions.Name = "pnQuestions";
            this.pnQuestions.Size = new System.Drawing.Size(274, 134);
            this.pnQuestions.TabIndex = 1;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Yu Gothic", 22F);
            this.lblQuestion.Location = new System.Drawing.Point(43, 48);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(174, 39);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "lblQuestions";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.toolTip.ForeColor = System.Drawing.Color.White;
            this.toolTip.OwnerDraw = true;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1015, 469);
            this.Controls.Add(this.pnAnswers);
            this.Controls.Add(this.pnStatus);
            this.Controls.Add(this.btnPractice);
            this.Controls.Add(this.pnQuestions);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.Snow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Quiz_Load);
            this.pnAnswers.ResumeLayout(false);
            this.pnStatus.ResumeLayout(false);
            this.pnStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnQuestions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CustomPanel pnQuestions;
        private CustomButton btn1;
        private CustomButton btn2;
        private CustomButton btn3;
        private CustomButton btn4;
        private CustomPanel pnStatus;
        public CustomButton btnPractice;
        private CustomToolTip toolTip;
        private System.Windows.Forms.Timer timeToAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWrongAnswers;
        private System.Windows.Forms.Label lblCorrectAnswers;
        private System.Windows.Forms.Label lblQuestions;
        private CustomPanel pnAnswers;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer;
    }
}