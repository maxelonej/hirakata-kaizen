namespace HiraKata_Kaizen {
    partial class Settings {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.settingsContent = new HiraKata_Kaizen.CustomPanel();
            this.btnApply = new HiraKata_Kaizen.CustomButton();
            this.checkboxExpandSidebar = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.settingsContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsContent
            // 
            this.settingsContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingsContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.settingsContent.BorderRadius = ((byte)(30));
            this.settingsContent.Controls.Add(this.btnApply);
            this.settingsContent.Controls.Add(this.checkboxExpandSidebar);
            this.settingsContent.Controls.Add(this.checkBox2);
            this.settingsContent.ForeColor = System.Drawing.Color.White;
            this.settingsContent.Location = new System.Drawing.Point(81, 61);
            this.settingsContent.Name = "settingsContent";
            this.settingsContent.Size = new System.Drawing.Size(489, 279);
            this.settingsContent.TabIndex = 5;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnApply.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.btnApply.BorderColor = System.Drawing.Color.Transparent;
            this.btnApply.BorderRadius = 5;
            this.btnApply.BorderSize = 0;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnApply.Location = new System.Drawing.Point(173, 216);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(150, 40);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Применить";
            this.btnApply.TextColor = System.Drawing.Color.AliceBlue;
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // checkboxExpandSidebar
            // 
            this.checkboxExpandSidebar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkboxExpandSidebar.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkboxExpandSidebar.AutoSize = true;
            this.checkboxExpandSidebar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkboxExpandSidebar.FlatAppearance.BorderSize = 0;
            this.checkboxExpandSidebar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.checkboxExpandSidebar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.checkboxExpandSidebar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.checkboxExpandSidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkboxExpandSidebar.ForeColor = System.Drawing.Color.Snow;
            this.checkboxExpandSidebar.Image = ((System.Drawing.Image)(resources.GetObject("checkboxExpandSidebar.Image")));
            this.checkboxExpandSidebar.Location = new System.Drawing.Point(24, 32);
            this.checkboxExpandSidebar.Margin = new System.Windows.Forms.Padding(6);
            this.checkboxExpandSidebar.Name = "checkboxExpandSidebar";
            this.checkboxExpandSidebar.Size = new System.Drawing.Size(297, 35);
            this.checkboxExpandSidebar.TabIndex = 1;
            this.checkboxExpandSidebar.Text = " Развернуть боковую панель";
            this.checkboxExpandSidebar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkboxExpandSidebar.UseVisualStyleBackColor = true;
            this.checkboxExpandSidebar.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.FlatAppearance.BorderSize = 0;
            this.checkBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.checkBox2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.checkBox2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Image = ((System.Drawing.Image)(resources.GetObject("checkBox2.Image")));
            this.checkBox2.Location = new System.Drawing.Point(24, 72);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(67, 35);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = " ._.";
            this.checkBox2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.settingsContent);
            this.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.settingsContent.ResumeLayout(false);
            this.settingsContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkboxExpandSidebar;
        private System.Windows.Forms.CheckBox checkBox2;
        private CustomButton btnApply;
        private CustomPanel settingsContent;
    }
}