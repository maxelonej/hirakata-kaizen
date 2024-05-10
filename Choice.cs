using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HiraKata_Kaizen {
    public partial class Choice : Form {
        public string openNext;
        Dashboard dashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();

        public Choice() {
            InitializeComponent();
        }

        void Choice_Load(object sender, EventArgs e) {
            ControlBox = false;

            // Packs
            string[] packs = { "Текущий", "Собственный" };
            cmbPack.Items.AddRange(packs);
            cmbPack.Texts = cmbPack.Items[0].ToString();

            // Time
            for (byte i = 45; i >= 5; i -= 5) {
                cmbTime.Items.Add(i.ToString());
            }
            cmbTime.Texts = cmbTime.Items[0].ToString();

            // Number
            for (byte i = 46; i >= 2; i -= 2) {
                cmbNumber.Items.Add(i.ToString());
            }
            cmbNumber.Texts = cmbNumber.Items[0].ToString();

            // Questions
            string[] questions = { "Хирагана", "Катакана", "Ромадзи" };
            cmbQuestions.Items.AddRange(questions);
            cmbQuestions.Texts = cmbQuestions.Items[0].ToString();

            // Answers
            cmbAnswers.Texts = "Ромадзи";

            if (openNext == "quiz") {
                lblTitle.Text = "Настройка \"Викторина\"";
                LoadSettings(Properties.Settings.Default.choicesQuiz);
            }
            else if (openNext == "cards") {
                lblTitle.Text = "Настройка \"Карты\"";
                LoadSettings(Properties.Settings.Default.choicesCards);
            }
            else if (openNext == "match") {
                lblTitle.Text = "Настройка \"Соответствие\"";
                LoadSettings(Properties.Settings.Default.choicesMatch);
            }
            else if (openNext == "drag") {
                lblTitle.Text = "Настройка \"Перетаскивание\"";
                LoadSettings(Properties.Settings.Default.choicesDrag);
            }

            lblTitle.Location = new Point((ClientSize.Width - lblTitle.Width) / 2, 18);
        }

        void LoadSettings(StringCollection choices) {
            if (choices == null) return;
            if (choices.Count > 0) {
                cmbTime.SelectedItem = cmbTime.Items.Cast<string>().FirstOrDefault(x => x == choices[0]);
            }
            if (choices.Count > 1) {
                cmbNumber.SelectedItem = cmbNumber.Items.Cast<string>().FirstOrDefault(x => x == choices[1]);
            }
            if (choices.Count > 2) {
                cmbQuestions.SelectedItem = choices.Count > 3 ? choices[2] : string.Empty;
            }
            if (choices.Count > 3) {
                cmbAnswers.SelectedItem = choices.Count > 4 ? choices[3] : string.Empty;
            }
        }

        void SaveSettings(StringCollection choices) {
            choices = new StringCollection {
                cmbTime.SelectedItem?.ToString(),
                cmbNumber.SelectedItem?.ToString(),
                cmbQuestions.SelectedItem?.ToString(),
                cmbAnswers.SelectedItem?.ToString()
            };
            if (openNext == "quiz") {
                Properties.Settings.Default.choicesQuiz = choices;
            }
            else if (openNext == "cards") {
                Properties.Settings.Default.choicesCards = choices;
            }
            else if (openNext == "match") {
                Properties.Settings.Default.choicesMatch = choices;
            }
            else if (openNext == "drag") {
                Properties.Settings.Default.choicesDrag = choices;
            }
            Properties.Settings.Default.Save();
        }

        // Next
        void btnStart_Click(object sender, EventArgs e) {
            if (openNext == "quiz") {
                SaveSettings(Properties.Settings.Default.choicesQuiz);

                if (dashboard.content.Controls.Count > 0) dashboard.content.Controls.RemoveAt(0);
                Quiz quiz = new Quiz(cmbTime.Texts, cmbNumber.Texts, cmbQuestions.Texts, cmbAnswers.Texts);
                quiz.TopLevel = false;
                quiz.Dock = DockStyle.Fill;
                dashboard.content.Controls.Add(quiz);
                dashboard.content.Tag = quiz;
                quiz.Show();
            }
            else if (openNext == "cards") {
                SaveSettings(Properties.Settings.Default.choicesCards);
            }
            else if (openNext == "match") {
                SaveSettings(Properties.Settings.Default.choicesMatch);
            }
            else if (openNext == "drag") {
                SaveSettings(Properties.Settings.Default.choicesDrag);
            }
        }

        // Back
        void btnPractice_Click(object sender, EventArgs e) {
            if (openNext == "quiz") {
                SaveSettings(Properties.Settings.Default.choicesQuiz);
            }
            else if (openNext == "cards") {
                SaveSettings(Properties.Settings.Default.choicesCards);
            }
            else if (openNext == "match") {
                SaveSettings(Properties.Settings.Default.choicesMatch);
            }
            else if (openNext == "drag") {
                SaveSettings(Properties.Settings.Default.choicesDrag);
            }

            var dashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            if (dashboard.content.Controls.Count > 0) dashboard.content.Controls.RemoveAt(0);
            Practice practice = new Practice();
            practice.TopLevel = false;
            practice.Dock = DockStyle.Fill;
            dashboard.content.Controls.Add(practice);
            dashboard.content.Tag = practice;
            practice.Show();
        }

        void cmbQuestions_OnSelectedIndexChanged(object sender, EventArgs e) {
            string selectedQuestion = cmbQuestions.SelectedItem.ToString();

            // Prevent selecting the same value for both questions and answers
            // q = Hiragana - a = Hiragana, etc
            string selectedAnswer = cmbQuestions.SelectedItem.ToString();

            cmbAnswers.Items.Clear();

            switch (selectedQuestion) {
                case "Хирагана":
                    cmbAnswers.Items.Add("Катакана");
                    cmbAnswers.Items.Add("Ромадзи");
                    if (selectedAnswer == selectedQuestion) {
                        cmbAnswers.SelectedIndex = 0;
                    }
                    break;
                case "Катакана":
                    cmbAnswers.Items.Add("Хирагана");
                    cmbAnswers.Items.Add("Ромадзи");
                    if (selectedAnswer == selectedQuestion) {
                        cmbAnswers.SelectedIndex = 0;
                    }
                    break;
                case "Ромадзи":
                    cmbAnswers.Items.Add("Хирагана");
                    cmbAnswers.Items.Add("Катакана");
                    if (selectedAnswer == selectedQuestion) {
                        cmbAnswers.SelectedIndex = 0;
                    }
                    break;
            }
        }

        void Choice_FormClosing(object sender, FormClosingEventArgs e) {
            if (openNext == "quiz") {
                SaveSettings(Properties.Settings.Default.choicesQuiz);
            }
            else if (openNext == "cards") {
                SaveSettings(Properties.Settings.Default.choicesCards);
            }
            else if (openNext == "match") {
                SaveSettings(Properties.Settings.Default.choicesMatch);
            }
            else if (openNext == "drag") {
                SaveSettings(Properties.Settings.Default.choicesDrag);
            }
        }
    }
}