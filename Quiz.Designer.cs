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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnResults = new HiraKata_Kaizen.CustomPanel();
            this.lblResultUnanswered = new System.Windows.Forms.Label();
            this.lblResultWrongAnswers = new System.Windows.Forms.Label();
            this.lblResultCorrectAnswers = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblTotalAnswered = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalQuestions = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalScore = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnAnswers = new HiraKata_Kaizen.CustomPanel();
            this.btn4 = new HiraKata_Kaizen.CustomButton();
            this.btn1 = new HiraKata_Kaizen.CustomButton();
            this.btn2 = new HiraKata_Kaizen.CustomButton();
            this.btn3 = new HiraKata_Kaizen.CustomButton();
            this.pnStatus = new HiraKata_Kaizen.CustomPanel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWrongAnswers = new System.Windows.Forms.Label();
            this.lblUnanswered = new System.Windows.Forms.Label();
            this.lblCorrectAnswers = new System.Windows.Forms.Label();
            this.btnPractice = new HiraKata_Kaizen.CustomButton();
            this.pnQuestions = new HiraKata_Kaizen.CustomPanel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.toolTip = new HiraKata_Kaizen.CustomToolTip();
            this.totalTimer = new System.Windows.Forms.Timer(this.components);
            this.pnResults.SuspendLayout();
            this.pnAnswers.SuspendLayout();
            this.pnStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnQuestions.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeToAnswer
            // 
            this.timeToAnswer.Enabled = true;
            this.timeToAnswer.Interval = 1000;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pnResults
            // 
            this.pnResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.pnResults.BorderRadius = ((byte)(30));
            this.pnResults.Controls.Add(this.lblResultUnanswered);
            this.pnResults.Controls.Add(this.lblResultWrongAnswers);
            this.pnResults.Controls.Add(this.lblResultCorrectAnswers);
            this.pnResults.Controls.Add(this.lblTotalTime);
            this.pnResults.Controls.Add(this.lblTotalAnswered);
            this.pnResults.Controls.Add(this.label4);
            this.pnResults.Controls.Add(this.lblTotalQuestions);
            this.pnResults.Controls.Add(this.label9);
            this.pnResults.Controls.Add(this.lblTotalScore);
            this.pnResults.Controls.Add(this.label11);
            this.pnResults.Controls.Add(this.label8);
            this.pnResults.Controls.Add(this.label6);
            this.pnResults.Controls.Add(this.label5);
            this.pnResults.Controls.Add(this.label3);
            this.pnResults.Controls.Add(this.label1);
            this.pnResults.Enabled = false;
            this.pnResults.ForeColor = System.Drawing.Color.Snow;
            this.pnResults.Location = new System.Drawing.Point(222, 98);
            this.pnResults.Name = "pnResults";
            this.pnResults.Size = new System.Drawing.Size(570, 272);
            this.pnResults.TabIndex = 18;
            this.pnResults.Visible = false;
            // 
            // lblResultUnanswered
            // 
            this.lblResultUnanswered.AutoSize = true;
            this.lblResultUnanswered.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblResultUnanswered.Location = new System.Drawing.Point(231, 142);
            this.lblResultUnanswered.Name = "lblResultUnanswered";
            this.lblResultUnanswered.Size = new System.Drawing.Size(32, 25);
            this.lblResultUnanswered.TabIndex = 6;
            this.lblResultUnanswered.Text = "00";
            // 
            // lblResultWrongAnswers
            // 
            this.lblResultWrongAnswers.AutoSize = true;
            this.lblResultWrongAnswers.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblResultWrongAnswers.Location = new System.Drawing.Point(502, 105);
            this.lblResultWrongAnswers.Name = "lblResultWrongAnswers";
            this.lblResultWrongAnswers.Size = new System.Drawing.Size(32, 25);
            this.lblResultWrongAnswers.TabIndex = 5;
            this.lblResultWrongAnswers.Text = "00";
            // 
            // lblResultCorrectAnswers
            // 
            this.lblResultCorrectAnswers.AutoSize = true;
            this.lblResultCorrectAnswers.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblResultCorrectAnswers.Location = new System.Drawing.Point(480, 68);
            this.lblResultCorrectAnswers.Name = "lblResultCorrectAnswers";
            this.lblResultCorrectAnswers.Size = new System.Drawing.Size(32, 25);
            this.lblResultCorrectAnswers.TabIndex = 4;
            this.lblResultCorrectAnswers.Text = "00";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblTotalTime.Location = new System.Drawing.Point(141, 178);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(32, 25);
            this.lblTotalTime.TabIndex = 3;
            this.lblTotalTime.Text = "00";
            // 
            // lblTotalAnswered
            // 
            this.lblTotalAnswered.AutoSize = true;
            this.lblTotalAnswered.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblTotalAnswered.Location = new System.Drawing.Point(212, 105);
            this.lblTotalAnswered.Name = "lblTotalAnswered";
            this.lblTotalAnswered.Size = new System.Drawing.Size(32, 25);
            this.lblTotalAnswered.TabIndex = 1;
            this.lblTotalAnswered.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label4.Location = new System.Drawing.Point(37, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Отвечено вопросов:";
            // 
            // lblTotalQuestions
            // 
            this.lblTotalQuestions.AutoSize = true;
            this.lblTotalQuestions.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblTotalQuestions.Location = new System.Drawing.Point(288, 68);
            this.lblTotalQuestions.Name = "lblTotalQuestions";
            this.lblTotalQuestions.Size = new System.Drawing.Size(32, 25);
            this.lblTotalQuestions.TabIndex = 1;
            this.lblTotalQuestions.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label9.Location = new System.Drawing.Point(348, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Неверные ответы:";
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.AutoSize = true;
            this.lblTotalScore.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblTotalScore.Location = new System.Drawing.Point(316, 232);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Size = new System.Drawing.Size(47, 25);
            this.lblTotalScore.TabIndex = 1;
            this.lblTotalScore.Text = "00%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label11.Location = new System.Drawing.Point(207, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "Общий балл:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label8.Location = new System.Drawing.Point(348, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Верные ответы:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label6.Location = new System.Drawing.Point(37, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Пройден за:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label5.Location = new System.Drawing.Point(37, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Пропущено вопросов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label3.Location = new System.Drawing.Point(37, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Общее количество вопросов:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Результаты викторины";
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
            this.btn4.Font = new System.Drawing.Font("Yu Gothic", 14F);
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
            this.btn1.Font = new System.Drawing.Font("Yu Gothic", 14F);
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
            this.btn2.Font = new System.Drawing.Font("Yu Gothic", 14F);
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
            this.btn3.Font = new System.Drawing.Font("Yu Gothic", 14F);
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
            this.pnStatus.Controls.Add(this.pictureBox3);
            this.pnStatus.Controls.Add(this.pictureBox1);
            this.pnStatus.Controls.Add(this.lblWrongAnswers);
            this.pnStatus.Controls.Add(this.lblUnanswered);
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
            this.lblTimer.Location = new System.Drawing.Point(496, 10);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(22, 23);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "0";
            // 
            // lblQuestions
            // 
            this.lblQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestions.AutoSize = true;
            this.lblQuestions.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestions.Location = new System.Drawing.Point(7, 10);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(43, 23);
            this.lblQuestions.TabIndex = 0;
            this.lblQuestions.Text = "0/0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(957, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox2, "Неверные ответы");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(831, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox3, "Без ответа");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(894, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox1, "Верные ответы");
            // 
            // lblWrongAnswers
            // 
            this.lblWrongAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWrongAnswers.AutoSize = true;
            this.lblWrongAnswers.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongAnswers.Location = new System.Drawing.Point(979, 9);
            this.lblWrongAnswers.Name = "lblWrongAnswers";
            this.lblWrongAnswers.Size = new System.Drawing.Size(29, 23);
            this.lblWrongAnswers.TabIndex = 0;
            this.lblWrongAnswers.Text = "0 ";
            this.lblWrongAnswers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUnanswered
            // 
            this.lblUnanswered.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnanswered.AutoSize = true;
            this.lblUnanswered.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnanswered.Location = new System.Drawing.Point(853, 9);
            this.lblUnanswered.Name = "lblUnanswered";
            this.lblUnanswered.Size = new System.Drawing.Size(29, 23);
            this.lblUnanswered.TabIndex = 0;
            this.lblUnanswered.Text = "0 ";
            this.lblUnanswered.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCorrectAnswers
            // 
            this.lblCorrectAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorrectAnswers.AutoSize = true;
            this.lblCorrectAnswers.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswers.Location = new System.Drawing.Point(916, 9);
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
            this.btnPractice.Location = new System.Drawing.Point(6, 372);
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
            // totalTimer
            // 
            this.totalTimer.Enabled = true;
            this.totalTimer.Interval = 1000;
            this.totalTimer.Tick += new System.EventHandler(this.totalTimer_Tick);
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
            this.Controls.Add(this.pnResults);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.Snow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Quiz_Load);
            this.pnResults.ResumeLayout(false);
            this.pnResults.PerformLayout();
            this.pnAnswers.ResumeLayout(false);
            this.pnStatus.ResumeLayout(false);
            this.pnStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private CustomPanel pnResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalScore;
        private System.Windows.Forms.Label lblTotalAnswered;
        private System.Windows.Forms.Label lblTotalQuestions;
        private System.Windows.Forms.Label lblResultUnanswered;
        private System.Windows.Forms.Label lblResultWrongAnswers;
        private System.Windows.Forms.Label lblResultCorrectAnswers;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblUnanswered;
        private System.Windows.Forms.Timer totalTimer;
    }
}