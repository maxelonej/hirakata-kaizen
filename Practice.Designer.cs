namespace HiraKata_Kaizen {
    partial class Practice {
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
            this.btnQuiz = new HiraKata_Kaizen.CustomButton();
            this.btnMatch = new HiraKata_Kaizen.CustomButton();
            this.btnCards = new HiraKata_Kaizen.CustomButton();
            this.btnDrag = new HiraKata_Kaizen.CustomButton();
            this.SuspendLayout();
            // 
            // btnQuiz
            // 
            this.btnQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnQuiz.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnQuiz.BorderColor = System.Drawing.Color.Transparent;
            this.btnQuiz.BorderRadius = 10;
            this.btnQuiz.BorderSize = 0;
            this.btnQuiz.FlatAppearance.BorderSize = 0;
            this.btnQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuiz.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnQuiz.ForeColor = System.Drawing.Color.White;
            this.btnQuiz.Location = new System.Drawing.Point(321, 172);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Size = new System.Drawing.Size(175, 50);
            this.btnQuiz.TabIndex = 2;
            this.btnQuiz.Text = "Викторина";
            this.btnQuiz.TextColor = System.Drawing.Color.White;
            this.btnQuiz.UseVisualStyleBackColor = false;
            this.btnQuiz.Click += new System.EventHandler(this.btnQuiz_Click);
            // 
            // btnMatch
            // 
            this.btnMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnMatch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnMatch.BorderColor = System.Drawing.Color.Transparent;
            this.btnMatch.BorderRadius = 10;
            this.btnMatch.BorderSize = 0;
            this.btnMatch.FlatAppearance.BorderSize = 0;
            this.btnMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatch.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnMatch.ForeColor = System.Drawing.Color.White;
            this.btnMatch.Location = new System.Drawing.Point(518, 172);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(175, 50);
            this.btnMatch.TabIndex = 2;
            this.btnMatch.Text = "Соответствие";
            this.btnMatch.TextColor = System.Drawing.Color.White;
            this.btnMatch.UseVisualStyleBackColor = false;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // btnCards
            // 
            this.btnCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnCards.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnCards.BorderColor = System.Drawing.Color.Transparent;
            this.btnCards.BorderRadius = 10;
            this.btnCards.BorderSize = 0;
            this.btnCards.FlatAppearance.BorderSize = 0;
            this.btnCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCards.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnCards.ForeColor = System.Drawing.Color.White;
            this.btnCards.Location = new System.Drawing.Point(321, 247);
            this.btnCards.Name = "btnCards";
            this.btnCards.Size = new System.Drawing.Size(175, 50);
            this.btnCards.TabIndex = 2;
            this.btnCards.Text = "Карты";
            this.btnCards.TextColor = System.Drawing.Color.White;
            this.btnCards.UseVisualStyleBackColor = false;
            this.btnCards.Click += new System.EventHandler(this.btnCards_Click);
            // 
            // btnDrag
            // 
            this.btnDrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnDrag.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnDrag.BorderColor = System.Drawing.Color.Transparent;
            this.btnDrag.BorderRadius = 10;
            this.btnDrag.BorderSize = 0;
            this.btnDrag.FlatAppearance.BorderSize = 0;
            this.btnDrag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrag.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnDrag.ForeColor = System.Drawing.Color.White;
            this.btnDrag.Location = new System.Drawing.Point(518, 247);
            this.btnDrag.Name = "btnDrag";
            this.btnDrag.Size = new System.Drawing.Size(175, 50);
            this.btnDrag.TabIndex = 2;
            this.btnDrag.Text = "Перетаскивание";
            this.btnDrag.TextColor = System.Drawing.Color.White;
            this.btnDrag.UseVisualStyleBackColor = false;
            this.btnDrag.Click += new System.EventHandler(this.btnDrag_Click);
            // 
            // Practice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1015, 469);
            this.Controls.Add(this.btnDrag);
            this.Controls.Add(this.btnCards);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.btnQuiz);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Practice";
            this.Text = "Practice";
            this.ResumeLayout(false);

        }

        #endregion
        private CustomButton btnQuiz;
        private CustomButton btnMatch;
        private CustomButton btnCards;
        private CustomButton btnDrag;
    }
}