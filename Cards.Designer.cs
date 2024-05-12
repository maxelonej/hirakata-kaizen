namespace HiraKata_Kaizen {
    partial class Cards {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cards));
            this.pnAnswers = new HiraKata_Kaizen.CustomPanel();
            this.inputAnswer = new System.Windows.Forms.TextBox();
            this.pnQuestions = new HiraKata_Kaizen.CustomPanel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.pnStatus = new HiraKata_Kaizen.CustomPanel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWrongAnswers = new System.Windows.Forms.Label();
            this.lblUnanswered = new System.Windows.Forms.Label();
            this.lblCorrectAnswers = new System.Windows.Forms.Label();
            this.toolTip = new HiraKata_Kaizen.CustomToolTip();
            this.btnPractice = new HiraKata_Kaizen.CustomButton();
            this.timeToAnswer = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.totalTimer = new System.Windows.Forms.Timer(this.components);
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
            this.pnAnswers.SuspendLayout();
            this.pnQuestions.SuspendLayout();
            this.pnStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnAnswers
            // 
            this.pnAnswers.BackColor = System.Drawing.Color.Black;
            this.pnAnswers.BorderRadius = ((byte)(30));
            this.pnAnswers.Controls.Add(this.inputAnswer);
            this.pnAnswers.ForeColor = System.Drawing.Color.Snow;
            this.pnAnswers.Location = new System.Drawing.Point(370, 264);
            this.pnAnswers.Name = "pnAnswers";
            this.pnAnswers.Size = new System.Drawing.Size(274, 86);
            this.pnAnswers.TabIndex = 19;
            // 
            // inputAnswer
            // 
            this.inputAnswer.BackColor = System.Drawing.Color.Black;
            this.inputAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputAnswer.Font = new System.Drawing.Font("Yu Gothic", 14F);
            this.inputAnswer.ForeColor = System.Drawing.Color.White;
            this.inputAnswer.Location = new System.Drawing.Point(88, 25);
            this.inputAnswer.Name = "inputAnswer";
            this.inputAnswer.Size = new System.Drawing.Size(100, 37);
            this.inputAnswer.TabIndex = 0;
            this.inputAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputAnswer_KeyPress);
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
            this.pnQuestions.Location = new System.Drawing.Point(370, 118);
            this.pnQuestions.Name = "pnQuestions";
            this.pnQuestions.Size = new System.Drawing.Size(274, 134);
            this.pnQuestions.TabIndex = 18;
            this.pnQuestions.MouseLeave += new System.EventHandler(this.pnQuestions_MouseLeave);
            this.pnQuestions.MouseHover += new System.EventHandler(this.pnQuestions_MouseHover);
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
            this.lblQuestion.MouseLeave += new System.EventHandler(this.lblQuestion_MouseLeave);
            this.lblQuestion.MouseHover += new System.EventHandler(this.lblQuestion_MouseHover);
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
            this.pnStatus.TabIndex = 20;
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
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolTip.ForeColor = System.Drawing.Color.White;
            this.toolTip.OwnerDraw = true;
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
            this.btnPractice.TabIndex = 21;
            this.btnPractice.TextColor = System.Drawing.Color.White;
            this.toolTip.SetToolTip(this.btnPractice, "Выйти");
            this.btnPractice.UseVisualStyleBackColor = false;
            this.btnPractice.Click += new System.EventHandler(this.btnPractice_Click);
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
            // totalTimer
            // 
            this.totalTimer.Enabled = true;
            this.totalTimer.Interval = 1000;
            this.totalTimer.Tick += new System.EventHandler(this.totalTimer_Tick);
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
            this.pnResults.TabIndex = 22;
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
            this.label1.Location = new System.Drawing.Point(203, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Результаты карт";
            // 
            // Cards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1015, 469);
            this.Controls.Add(this.btnPractice);
            this.Controls.Add(this.pnStatus);
            this.Controls.Add(this.pnAnswers);
            this.Controls.Add(this.pnQuestions);
            this.Controls.Add(this.pnResults);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Cards";
            this.Text = "Cards";
            this.Load += new System.EventHandler(this.Cards_Load);
            this.pnAnswers.ResumeLayout(false);
            this.pnAnswers.PerformLayout();
            this.pnQuestions.ResumeLayout(false);
            this.pnStatus.ResumeLayout(false);
            this.pnStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnResults.ResumeLayout(false);
            this.pnResults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel pnAnswers;
        private CustomPanel pnQuestions;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox inputAnswer;
        private CustomPanel pnStatus;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblQuestions;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWrongAnswers;
        private System.Windows.Forms.Label lblUnanswered;
        private System.Windows.Forms.Label lblCorrectAnswers;
        private CustomToolTip toolTip;
        public CustomButton btnPractice;
        private System.Windows.Forms.Timer timeToAnswer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer totalTimer;
        private CustomPanel pnResults;
        private System.Windows.Forms.Label lblResultUnanswered;
        private System.Windows.Forms.Label lblResultWrongAnswers;
        private System.Windows.Forms.Label lblResultCorrectAnswers;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label lblTotalAnswered;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalQuestions;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalScore;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}