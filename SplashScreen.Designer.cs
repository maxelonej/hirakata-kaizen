namespace HiraKata_Kaizen {
    partial class SplashScreen {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTimer = new System.Windows.Forms.Timer(this.components);
            this.btnRunTimerX = new System.Windows.Forms.Timer(this.components);
            this.btnRunTimerY = new System.Windows.Forms.Timer(this.components);
            this.btnRun = new HiraKata_Kaizen.CustomButton();
            this.customPanel1 = new HiraKata_Kaizen.CustomPanel();
            this.customPanel2 = new HiraKata_Kaizen.CustomPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.customPanel1.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.ForeColor = System.Drawing.Color.Snow;
            this.panel1.Location = new System.Drawing.Point(6, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 14);
            this.panel1.TabIndex = 1;
            // 
            // labelTimer
            // 
            this.labelTimer.Enabled = true;
            this.labelTimer.Interval = 10;
            this.labelTimer.Tick += new System.EventHandler(this.labelTimer_Tick);
            // 
            // btnRunTimerX
            // 
            this.btnRunTimerX.Enabled = true;
            this.btnRunTimerX.Interval = 50;
            this.btnRunTimerX.Tick += new System.EventHandler(this.btnRunTimerX_Tick);
            // 
            // btnRunTimerY
            // 
            this.btnRunTimerY.Tick += new System.EventHandler(this.btnRunTimerY_Tick);
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.DarkRed;
            this.btnRun.BackgroundColor = System.Drawing.Color.DarkRed;
            this.btnRun.BorderColor = System.Drawing.Color.Transparent;
            this.btnRun.BorderRadius = 10;
            this.btnRun.BorderSize = 0;
            this.btnRun.Enabled = false;
            this.btnRun.FlatAppearance.BorderSize = 0;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Location = new System.Drawing.Point(190, 120);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(150, 40);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Запустить";
            this.btnRun.TextColor = System.Drawing.Color.White;
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Visible = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.Maroon;
            this.customPanel1.BorderRadius = ((byte)(5));
            this.customPanel1.Controls.Add(this.panel1);
            this.customPanel1.ForeColor = System.Drawing.Color.Snow;
            this.customPanel1.Location = new System.Drawing.Point(24, 81);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(483, 23);
            this.customPanel1.TabIndex = 0;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.customPanel2.BorderRadius = ((byte)(30));
            this.customPanel2.Controls.Add(this.label1);
            this.customPanel2.Controls.Add(this.customPanel1);
            this.customPanel2.Controls.Add(this.btnRun);
            this.customPanel2.ForeColor = System.Drawing.Color.Snow;
            this.customPanel2.Location = new System.Drawing.Point(274, 165);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(530, 183);
            this.customPanel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.label1.Location = new System.Drawing.Point(198, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "HiraKata";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1079, 513);
            this.Controls.Add(this.customPanel2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HiraKata";
            this.customPanel1.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel customPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer labelTimer;
        private CustomButton btnRun;
        private System.Windows.Forms.Timer btnRunTimerX;
        private System.Windows.Forms.Timer btnRunTimerY;
        private CustomPanel customPanel2;
        private System.Windows.Forms.Label label1;
    }
}