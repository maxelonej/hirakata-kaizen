using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HiraKata_Kaizen {
    public partial class Choice : Form {
        public string openNext;
        public string selectedAnswer;
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
            cmbAnswers.Items.Clear();
            string[] answers = { "Ромадзи", "Катакана" };
            cmbAnswers.Items.AddRange(answers);
            cmbAnswers.Text = cmbAnswers.Items[0].ToString(); // Set the text of the combobox
                                                              // or
            cmbAnswers.SelectedIndex = 0; // Set the first item as selected
            selectedAnswer = cmbAnswers.SelectedItem.ToString();

            if (openNext == "quiz") {
                lblTitle.Text = "Настройка для викторины";
                LoadSettings(Properties.Settings.Default.choicesQuiz);
            }
            else if (openNext == "cards") {
                lblTitle.Text = "Настройка для карт";
                LoadSettings(Properties.Settings.Default.choicesCards);
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
                // Check if the second-to-last item in the choices collection is the answer
                string answer = choices[choices.Count - 2];
                cmbAnswers.Texts = choices.Count > 4 ? choices[choices.Count - 1] : answer;
                // a == q then a = [0]
                // if a.texts doesnt exist in items then items[0]
                if (!cmbAnswers.Items.Contains(cmbAnswers.Text)) {
                    cmbAnswers.SelectedIndex = 0;
                }
                selectedAnswer = cmbAnswers.Texts;
            }
            if (cmbQuestions.Texts == cmbAnswers.Texts) {
                cmbAnswers.SelectedIndex = 0;
                selectedAnswer = cmbAnswers.Texts;
            }
        }

    void SaveSettings(StringCollection choices) {
            choices.Clear();
            choices.Add(cmbTime.SelectedItem?.ToString());
            choices.Add(cmbNumber.SelectedItem?.ToString());
            choices.Add(cmbQuestions.SelectedItem?.ToString());
            choices.Add(cmbAnswers.SelectedItem?.ToString()); 
            if (cmbAnswers.SelectedItem != null) {
                choices.Add(cmbAnswers.SelectedItem.ToString());
            }
            if (openNext == "quiz") {
                Properties.Settings.Default.choicesQuiz = choices;
            }
            else if (openNext == "cards") {
                Properties.Settings.Default.choicesCards = choices;
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

                if (dashboard.content.Controls.Count > 0) dashboard.content.Controls.RemoveAt(0);
                Cards cards = new Cards(cmbTime.Texts, cmbNumber.Texts, cmbQuestions.Texts, cmbAnswers.Texts);
                cards.TopLevel = false;
                cards.Dock = DockStyle.Fill;
                dashboard.content.Controls.Add(cards);
                dashboard.content.Tag = cards;
                cards.Show();
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

            cmbAnswers.Items.Clear();

            switch (selectedQuestion) {
                case "Хирагана":
                    cmbAnswers.Items.Add("Ромадзи");
                    cmbAnswers.Items.Add("Катакана");
                    if (selectedQuestion == cmbAnswers.Texts) {
                        cmbAnswers.SelectedIndex = 0;
                    }
                    break;
                case "Катакана":
                    cmbAnswers.Items.Add("Ромадзи");
                    cmbAnswers.Items.Add("Хирагана");
                    if (selectedQuestion == cmbAnswers.Texts) {
                        cmbAnswers.SelectedIndex = 0;
                    }
                    break;
                case "Ромадзи":
                    cmbAnswers.Items.Add("Хирагана");
                    cmbAnswers.Items.Add("Катакана");
                    if (selectedQuestion == cmbAnswers.Texts) {
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
        }

        void Choice_Shown(object sender, EventArgs e) {
        }
    }
}