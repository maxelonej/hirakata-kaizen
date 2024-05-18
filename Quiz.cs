using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HiraKata_Kaizen {
    public partial class Quiz : Form {
        byte _timeToAnswer;
        byte _totalQuestions;
        byte _rightAnswers;
        byte _wrongAnswers;
        byte _currentQuestionNumber = 1;
        byte totalScore;
        ushort elapsedSeconds;
        byte unanswered;

        string _questionType;
        string _answerType;
        string _cmbTime;
        string _enQuestionType;
        string _enAnswerType;

        string[] questionAndAnswers;

        public Quiz(string cmbTime, string cmbNumber, string cmbQuestions, string cmbAnswers) {
            InitializeComponent();

            _timeToAnswer = Byte.Parse(cmbTime);
            _totalQuestions = (byte)(Byte.Parse(cmbNumber) + 1);
            _questionType = cmbQuestions;
            _answerType = cmbAnswers;
            _cmbTime = cmbTime;

            int x = (pnQuestions.Size.Width - pnQuestions.Size.Width) / 2;
            lblQuestion.Location = new Point(x, lblQuestion.Location.Y);
            lblQuestion.Location = new Point((pnQuestions.Width - lblQuestion.Width) / 2, (pnQuestions.Height - lblQuestion.Height) / 2);
        }

        void Quiz_Load(object sender, EventArgs e) {
            timer.Start();
            LoadNextQuestion();
        }

        void LoadNextQuestion() {
            totalTimer.Start();
            questionAndAnswers = GetQuestionAndAnswers();

            lblQuestion.Text = questionAndAnswers[0];

            // Shuffle the answers
            string[] answers = questionAndAnswers.Skip(1).ToArray();
            answers.Shuffle();

            btn1.Text = answers[0];
            btn2.Text = answers[1];
            btn3.Text = answers[2];
            btn4.Text = answers[3];

            lblQuestions.Text = $"{_currentQuestionNumber}/{_totalQuestions - 1}";

            if (_currentQuestionNumber < _totalQuestions) {
                // Reset timer
                _timeToAnswer = Byte.Parse(_cmbTime); // reset the timer value
                timer.Start(); // restart the timer
            }
            else {
                totalTimer.Stop();
                timer.Stop();
                // hide panels
                pnQuestions.Visible = false; pnQuestions.Enabled = false;
                pnAnswers.Visible = false; pnAnswers.Enabled = false;
                pnStatus.Visible = false; pnStatus.Enabled = false;
                // move panel
                btnPractice.Location = new Point(6, 416);
                // show panel - results
                pnResults.Visible = true; pnResults.Enabled = true;
                lblResultCorrectAnswers.Text = lblCorrectAnswers.Text;
                lblResultWrongAnswers.Text = lblWrongAnswers.Text;
                lblResultUnanswered.Text = lblUnanswered.Text;
                lblTotalAnswered.Text = "" + (Byte.Parse(lblCorrectAnswers.Text) + Byte.Parse(lblWrongAnswers.Text));
                lblTotalQuestions.Text = "" + (_totalQuestions - 1);
                if (elapsedSeconds == 3 || elapsedSeconds == 4 || elapsedSeconds == 2) {
                    lblTotalTime.Text = "" + elapsedSeconds + " секунды";
                }
                else if (elapsedSeconds == 1) {
                    lblTotalTime.Text = "" + elapsedSeconds + " секунда";
                }
                else {
                    lblTotalTime.Text = "" + elapsedSeconds + " секунд";
                }

                totalScore = ((byte)(Byte.Parse(lblCorrectAnswers.Text) / (Double.Parse(lblTotalAnswered.Text) + Byte.Parse(lblResultUnanswered.Text)) * 100));
                lblTotalScore.Text = totalScore + "%";
            }
            _currentQuestionNumber++;
        }

        string[] GetQuestionAndAnswers() {
            using (SqlConnection connection = new SqlConnection(GetConnectionString())) {
                connection.Open();

                if (_questionType == "Хирагана") _enQuestionType = "hiragana";
                else if (_questionType == "Катакана") _enQuestionType = "katakana";
                else if (_questionType == "Ромадзи") _enQuestionType = "romaji";

                if (_answerType == "Хирагана") _enAnswerType = "hiragana";
                else if (_answerType == "Катакана") _enAnswerType = "katakana";
                else if (_answerType == "Ромадзи") _enAnswerType = "romaji";

                string query = $"SELECT TOP 1 {_enQuestionType}, {_enAnswerType} FROM japanese_characters ORDER BY NEWID()";

                using (SqlCommand command = new SqlCommand(query, connection)) {
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        if (reader.Read()) {
                            string[] questionAndAnswers = new string[5];
                            questionAndAnswers[0] = reader[_enQuestionType].ToString(); // q
                            questionAndAnswers[1] = reader[_enAnswerType].ToString(); // a

                            reader.Close();
                            // 3 random a
                            query = $"SELECT TOP 3 {_enAnswerType} FROM japanese_characters WHERE {_enQuestionType} != @{_enQuestionType} ORDER BY NEWID()";
                            using (SqlCommand command2 = new SqlCommand(query, connection)) {
                                command2.Parameters.AddWithValue($"@{_enQuestionType}", questionAndAnswers[0]);
                                using (SqlDataReader reader2 = command2.ExecuteReader()) {
                                    byte i = 2;
                                    while (reader2.Read()) {
                                        questionAndAnswers[i] = reader2[_enAnswerType].ToString(); // 3 a
                                        i++;
                                    }
                                }
                            }

                            return questionAndAnswers;
                        }
                    }
                }
            }

            return null;
        }

        string GetConnectionString() {
            return "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\HiraKata_Kaizen.mdf;Integrated Security=True;Connect Timeout=30";
        }

        // Btns click
        void btnAnswer_Click(object sender, EventArgs e) {
            Button button = (Button)sender;

            if (button.Text == questionAndAnswers[1]) {
                _rightAnswers++;
                lblCorrectAnswers.Text = _rightAnswers.ToString();
            }
            else {
                _wrongAnswers++;
                lblWrongAnswers.Text = _wrongAnswers.ToString();
            }

            LoadNextQuestion(); 
        }

        // Time to answer
        void timer_Tick(object sender, EventArgs e) {
            lblTimer.Text = "" + _timeToAnswer;
            if (_timeToAnswer > 0) {
                _timeToAnswer--;
            }
            else {
                timer.Stop();
                unanswered++;
                lblUnanswered.Text = unanswered.ToString();
                LoadNextQuestion();
            }
        }

        void totalTimer_Tick(object sender, EventArgs e) {
            elapsedSeconds++;
        }

        // Exit
        void btnPractice_Click(object sender, EventArgs e) {
            Dashboard dashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            if (dashboard.content.Controls.Count > 0) dashboard.content.Controls.RemoveAt(0);
            Practice Practice = new Practice();
            Practice.TopLevel = false;
            Practice.Dock = DockStyle.Fill;
            dashboard.content.Controls.Add(Practice);
            dashboard.content.Tag = Practice;
            Practice.Show();
        }
    }
}