using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HiraKata_Kaizen {
    public partial class SplashScreen : Form {
        Label[] labels;
        Random random;

        public SplashScreen() {
            InitializeComponent();

            labels = new Label[46];
            random = new Random();

            for (byte i = 0; i < labels.Length; i++) {
                labels[i] = new Label();
                labels[i].Font = new Font("Yu Gothic", 14);
                int x = random.Next(ClientRectangle.Width - labels[i].Width);
                int y = random.Next(ClientRectangle.Height - labels[i].Height);
                labels[i].Location = new Point(x, y);
                Controls.Add(labels[i]);
            }

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\HiraKata_Kaizen.mdf;Integrated Security=True;Connect Timeout=30")) {
                connection.Open();
                string query = "SELECT hiragana, katakana FROM japanese_characters";
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        int index = 0;
                        while (reader.Read()) {
                            bool useHiragana = random.Next(2) == 0; // 50% chance of using Hiragana
                            labels[index].Text = useHiragana ? reader["hiragana"].ToString() : reader["katakana"].ToString();
                            index++;
                        }
                    }
                }
            }

            timer1.Interval = 12; // adjust the interval as needed
            timer1.Start();
        }

        void timer1_Tick(object sender, EventArgs e) {
            panel1.Width += 4;
            if (panel1.Width >= 470) {
                timer1.Stop();
                btnRun.Visible = true;
                btnRun.Enabled = true;
            }
        }

        void labelTimer_Tick(object sender, EventArgs e) {
            MoveLabels(labels);
        }

        void MoveLabels(Label[] labels) {
            // get the width and height of the form and labels
            int formWidth = ClientRectangle.Width;
            int formHeight = ClientRectangle.Height;

            foreach (Label label in labels) {
                int labelWidth = label.Width;
                int labelHeight = label.Height;

                // Adjust the label size based on the current font size
                labelWidth = label.Width;
                labelHeight = label.Height;

                // calculate the new location of the label
                int x = label.Location.X;
                int y = label.Location.Y;
                if (x + labelWidth < formWidth) {
                    // move the label to the right
                    x += 2;
                }
                else {
                    // move the label to the left
                    x = 2;
                }
                if (y + labelHeight < formHeight) {
                    // move the label down
                    y += 2;
                }
                else {
                    // move the label up
                    y = 2;
                }

                // set the new location of the label
                label.Location = new Point(x, y);
            }
        }

        bool increasingWidth = true;

        void btnRunTimerX_Tick(object sender, EventArgs e) {
            if (btnRun.Visible) {
                if (increasingWidth) {
                    currentFontSize += 0.4f;
                    btnRun.Font = new Font("Segoe UI", currentFontSize);
                    if (btnRun.Width < 170) {
                        btnRun.Width += 2;
                        btnRun.Height += 1; // Scale the height as well
                    }
                    else {
                        increasingWidth = false;
                        btnRunTimerX.Stop();
                        btnRunTimerY.Start();
                    }
                }
                else {
                    currentFontSize -= 0.4f;
                    btnRun.Font = new Font("Segoe UI", currentFontSize);
                    if (btnRun.Width > 150) {
                        btnRun.Width -= 2;
                        btnRun.Height -= 1; // Scale the height as well
                    }
                    else {
                        increasingWidth = true;
                        btnRunTimerY.Stop();
                        btnRunTimerX.Start();
                    }
                }

                // center the button horizontally
                btnRun.Left = (customPanel2.Width - btnRun.Width) / 2;
            }
        }

        float currentFontSize = 14f;
        void btnRunTimerY_Tick(object sender, EventArgs e) {
            if (btnRun.Visible) {
                if (increasingWidth) {
                    currentFontSize += 0.4f;
                    btnRun.Font = new Font("Segoe UI", currentFontSize);
                    if (btnRun.Height < 40) { 
                        btnRun.Height += 1;
                        btnRun.Width += 2; 
                    }
                    else {
                        increasingWidth = false;
                        btnRunTimerY.Stop();
                    }
                }
                else {
                    currentFontSize -= 0.4f;
                    btnRun.Font = new Font("Segoe UI", currentFontSize);
                    if (btnRun.Height > 40) { 
                        btnRun.Height -= 1;
                        btnRun.Width -= 2;
                    }
                    else {
                        increasingWidth = true;
                        btnRunTimerY.Stop();
                        btnRunTimerX.Start();
                    }
                }

                // center the button horizontally
                btnRun.Left = (customPanel2.Width - btnRun.Width) / 2;
            }
        }
        void btnRun_Click(object sender, EventArgs e) {
            Hide();
            new Dashboard().Show();
        }
    }
}