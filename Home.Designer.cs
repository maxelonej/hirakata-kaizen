namespace HiraKata_Kaizen {
    partial class Home {
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLearn = new HiraKata_Kaizen.CustomButton();
            this.btnPractice = new HiraKata_Kaizen.CustomButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.25F);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(404, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать";
            // 
            // btnLearn
            // 
            this.btnLearn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnLearn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnLearn.BorderColor = System.Drawing.Color.Transparent;
            this.btnLearn.BorderRadius = 10;
            this.btnLearn.BorderSize = 0;
            this.btnLearn.FlatAppearance.BorderSize = 0;
            this.btnLearn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLearn.ForeColor = System.Drawing.Color.White;
            this.btnLearn.Location = new System.Drawing.Point(339, 247);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(150, 40);
            this.btnLearn.TabIndex = 1;
            this.btnLearn.Text = "Алфавиты";
            this.btnLearn.TextColor = System.Drawing.Color.White;
            this.btnLearn.UseVisualStyleBackColor = false;
            // 
            // btnPractice
            // 
            this.btnPractice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnPractice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnPractice.BorderColor = System.Drawing.Color.Transparent;
            this.btnPractice.BorderRadius = 10;
            this.btnPractice.BorderSize = 0;
            this.btnPractice.FlatAppearance.BorderSize = 0;
            this.btnPractice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPractice.ForeColor = System.Drawing.Color.White;
            this.btnPractice.Location = new System.Drawing.Point(526, 247);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.Size = new System.Drawing.Size(150, 40);
            this.btnPractice.TabIndex = 1;
            this.btnPractice.Text = "Практика";
            this.btnPractice.TextColor = System.Drawing.Color.White;
            this.btnPractice.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1015, 469);
            this.Controls.Add(this.btnPractice);
            this.Controls.Add(this.btnLearn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.Snow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomButton btnLearn;
        private CustomButton btnPractice;
    }
}