using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HiraKata_Kaizen {
    public partial class Quiz : Form {
        string _questionType;
        string _answerType;
        byte _totalQuestions;
        int _currentQuestionId;
        byte _rightAnswers;
        byte _wrongAnswers;
        byte _currentQuestionNumber = 1;
        byte _timeToAnswer;
        string _cmbTime;
        string[] questionAndAnswers;

        public Quiz(string cmbTime, string cmbNumber, string cmbQuestions, string cmbAnswers) {
            InitializeComponent();

            _timeToAnswer = Byte.Parse(cmbTime);
            _totalQuestions = Byte.Parse(cmbNumber);
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
            questionAndAnswers = GetQuestionAndAnswers();

            lblQuestion.Text = questionAndAnswers[0];

            // Shuffle the answers
            string[] answers = questionAndAnswers.Skip(1).ToArray();
            answers.Shuffle();

            btn1.Text = answers[0];
            btn2.Text = answers[1];
            btn3.Text = answers[2];
            btn4.Text = answers[3];

            lblQuestions.Text = $"{_currentQuestionNumber}/{_totalQuestions}";

            if (_currentQuestionNumber < _totalQuestions) {
                // Reset timer
                _timeToAnswer = Byte.Parse(_cmbTime); // reset the timer value
                timer.Start(); // restart the timer
            }
            else {
                timer.Stop();
                // TODO - hide panels, show panel - results
            }
            _currentQuestionNumber++;
        }

        string[] GetQuestionAndAnswers() {
            using (SqlConnection connection = new SqlConnection(GetConnectionString())) {
                connection.Open();

                var query = "SELECT TOP 1 hiragana, romaji FROM japanese_characters ORDER BY NEWID()";
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    using (var reader = command.ExecuteReader()) {
                        if (reader.Read()) {
                            string[] questionAndAnswers = new string[5];
                            questionAndAnswers[0] = reader["hiragana"].ToString(); // q
                            questionAndAnswers[1] = reader["romaji"].ToString(); // a

                            reader.Close();
                            // 3 random a
                            query = "SELECT TOP 3 romaji FROM japanese_characters WHERE hiragana!= @hiragana ORDER BY NEWID()";
                            using (SqlCommand command2 = new SqlCommand(query, connection)) {
                                command2.Parameters.AddWithValue("@hiragana", questionAndAnswers[0]);
                                using (SqlDataReader reader2 = command2.ExecuteReader()) {
                                    byte i = 2;
                                    while (reader2.Read()) {
                                        questionAndAnswers[i] = reader2["romaji"].ToString(); // 3 a
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

        void btnLearn_Click(object sender, EventArgs e) {
            Dashboard dashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            if (dashboard.content.Controls.Count > 0) dashboard.content.Controls.RemoveAt(0);
            Learn learn = new Learn();
            learn.TopLevel = false;
            learn.Dock = DockStyle.Fill;
            dashboard.content.Controls.Add(learn);
            dashboard.content.Tag = learn;
            learn.Show();
        }

        void timer_Tick(object sender, EventArgs e) {
            lblTimer.Text = "" + _timeToAnswer;
            if (_timeToAnswer > 0) {
                _timeToAnswer--;
            }
            else {
                timer.Stop();
                LoadNextQuestion();
            }
        }
    }
}