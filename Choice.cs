using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HiraKata_Kaizen {
    public partial class Choice : Form {
        public string openNext;
        Dashboard dashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();

        public Choice() {
            InitializeComponent();
            // Packs
            string[] packs = { "Текущий", "Собственный" };
            cmbPack.Items.AddRange(packs);
            cmbPack.Texts = cmbPack.Items[0].ToString();

            // Time
            for (byte i = 45; i >= 5; i -= 5) {
                cmbTime.Items.Add(i.ToString());
            }
            cmbTime.SelectedIndex = 0;

            // Number
            for (byte i = 46; i >= 2; i -= 2) {
                cmbNumber.Items.Add(i.ToString());
            }
            cmbNumber.SelectedIndex = 0;

            // Questions
            string[] questions = { "Хирагана", "Катакана", "Ромадзи" };
            cmbQuestions.Items.AddRange(questions);
            cmbQuestions.SelectedIndex = 0;

            // Answers
            string[] answers = { "Ромадзи", "Катакана" };
            cmbAnswers.Items.AddRange(answers);
            cmbAnswers.SelectedIndex = 0; 
        }

        void SaveSettings() {
            if (openNext == "quiz") {
                Properties.Settings.Default.QuizTime = byte.Parse(cmbTime.SelectedItem.ToString());
                Properties.Settings.Default.QuizNumber = byte.Parse(cmbNumber.SelectedItem.ToString());
                Properties.Settings.Default.QuizQuestion = cmbQuestions.SelectedItem.ToString();
                Properties.Settings.Default.QuizAnswer = cmbAnswers.SelectedItem.ToString();
            }
            else if (openNext == "cards") {
                Properties.Settings.Default.CardsTime = byte.Parse(cmbTime.SelectedItem.ToString());
                Properties.Settings.Default.CardsNumber = byte.Parse(cmbNumber.SelectedItem.ToString());
                Properties.Settings.Default.CardsQuestion = cmbQuestions.SelectedItem.ToString();
                Properties.Settings.Default.CardsAnswer = cmbAnswers.SelectedItem.ToString();
            }
            Properties.Settings.Default.Save();
        }

        void LoadSettings() {
            if (openNext == "quiz") {
                cmbTime.SelectedItem = Properties.Settings.Default.QuizTime.ToString();
                cmbNumber.SelectedItem = Properties.Settings.Default.QuizNumber.ToString();
                cmbQuestions.SelectedItem = Properties.Settings.Default.QuizQuestion;
                cmbAnswers.SelectedItem = Properties.Settings.Default.QuizAnswer;
            }
            else if (openNext == "cards") {
                cmbTime.SelectedItem = Properties.Settings.Default.CardsTime.ToString();
                cmbNumber.SelectedItem = Properties.Settings.Default.CardsNumber.ToString();
                cmbQuestions.SelectedItem = Properties.Settings.Default.CardsQuestion;
                cmbAnswers.SelectedItem = Properties.Settings.Default.CardsAnswer;
            }
        }

        void Choice_Load(object sender, EventArgs e) {
            ControlBox = false;
            LoadSettings();

            if (openNext == "quiz") {
                lblTitle.Text = "Настройка для викторины";
            }
            else if (openNext == "cards") {
                lblTitle.Text = "Настройка для карт";
            }
           
            lblTitle.Location = new Point((ClientSize.Width - lblTitle.Width) / 2, 18);
        }
        
        // Next
        void btnStart_Click(object sender, EventArgs e) {
            SaveSettings();
            if (openNext == "quiz") {
                if (dashboard.content.Controls.Count > 0) dashboard.content.Controls.RemoveAt(0);
                Quiz quiz = new Quiz(cmbTime.Texts, cmbNumber.Texts, cmbQuestions.Texts, cmbAnswers.Texts);
                quiz.TopLevel = false;
                quiz.Dock = DockStyle.Fill;
                dashboard.content.Controls.Add(quiz);
                dashboard.content.Tag = quiz;
                quiz.Show();
            }
            else if (openNext == "cards") {
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
            SaveSettings();
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

            switch (selectedQuestion) {
                case "Хирагана":
                    cmbAnswers.Items.Clear(); // очистить все итемы
                    // добавить новые
                    cmbAnswers.Items.Add("Ромадзи");
                    cmbAnswers.Items.Add("Катакана");
                    if (selectedQuestion == cmbAnswers.Texts) {
                        cmbAnswers.SelectedIndex = 0;
                    }
                    break;
                case "Катакана":
                    cmbAnswers.Items.Clear();
                    cmbAnswers.Items.Add("Ромадзи");
                    cmbAnswers.Items.Add("Хирагана");
                    if (selectedQuestion == cmbAnswers.Texts) {
                        cmbAnswers.SelectedIndex = 0;
                    }
                    break;
                case "Ромадзи":
                    cmbAnswers.Items.Clear();
                    cmbAnswers.Items.Add("Хирагана");
                    cmbAnswers.Items.Add("Катакана");
                    if (selectedQuestion == cmbAnswers.Texts) {
                        cmbAnswers.SelectedIndex = 0;
                    }
                    break;
            }
        }
    }
}