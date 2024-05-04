using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiraKata_Kaizen {
    public partial class Quiz : Form {
        byte _questionNumber = 1;
        byte _score;
        byte _totalQuestions;

        public Quiz() {
            InitializeComponent();

            // Initialize totalQuestions variable
            _totalQuestions = 3;

            // Display the first question
            AskQuestion(_questionNumber);
        }

        void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        void btnMinimize_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        void btnHome_Click(object sender, EventArgs e) {
            Hide();
            new Dashboard().Show();
        }

        // Shuffle button texts to randomize the location of the correct answer
        void ShuffleButtons(string[] options) {
            Random rnd = new Random();

            for (byte i = (byte)(options.Length - 1); i > 0; i--) {
                byte j = (byte)rnd.Next(i + 1);
                string temp = options[i];
                options[i] = options[j];
                options[j] = temp;
            }

            btn1.Text = options[0];
            btn2.Text = options[1];
            btn3.Text = options[2];
            btn4.Text = options[3];
        }

        // Display a question and its options
        void AskQuestion(byte questionNumber) {
            Database db = new Database();
            db.openConnection();

            using (SqlConnection connection = db.getConnection()) {

                string query = "SELECT question, first_answer, second_answer, third_answer, fourth_answer, correct_answer FROM questions WHERE question_id = @questionNumber";
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@questionNumber", questionNumber);

                    using (SqlDataReader reader = command.ExecuteReader()) {
                        if (reader.Read()) {
                            lblQuestion.Text = reader["question"].ToString();
                            string[] options = new string[] { reader["first_answer"].ToString(), reader["second_answer"].ToString(), reader["third_answer"].ToString(), reader["fourth_answer"].ToString() };
                            byte correctAnswer = Convert.ToByte(reader["correct_answer"]);
                            // Display the current question number and the total number of questions
                            lblQuestions.Text = $"{questionNumber}/{_totalQuestions}";

                            // Shuffle the options
                            ShuffleButtons(options);

                            // Set the correct answer tag
                            switch (correctAnswer) {
                                case 1:
                                    btn1.Tag = correctAnswer;
                                    break;
                                case 2:
                                    btn2.Tag = correctAnswer;
                                    break;
                                case 3:
                                    btn3.Tag = correctAnswer;
                                    break;
                                case 4:
                                    btn4.Tag = correctAnswer;
                                    break;
                            }
                        }
                    }
                }
            }

            db.closeConnection();
        }

        // btnClick
        void CheckAnswer(object sender, EventArgs e) {
            var senderObject = (Button)sender;
            byte buttonTag = Convert.ToByte(senderObject.Tag);
            bool isCorrect = buttonTag == 1; // assuming correct answer is 1

            // Change the button's backcolor based on the answer's correctness
            senderObject.BackColor = isCorrect ? Color.Green : Color.Red;

            // Reset the button's backcolor after a second
            Task.Delay(1000).ContinueWith(t => {
                if (InvokeRequired)
                    Invoke((MethodInvoker)delegate { senderObject.BackColor = SystemColors.Control; });
                else
                    senderObject.BackColor = SystemColors.Control;
            });

            // Continue with the existing code
            if (isCorrect) {
                _score++;
            }
            _questionNumber++;

            // If all questions have been answered, display the results
            if (_questionNumber > _totalQuestions) {
                double percentage = (double)_score * 100 / _totalQuestions;
                MessageBox.Show($"Your score is: {_score}/{_totalQuestions} ({percentage}%)");
                Hide();
                new Dashboard().Show();
                return;
            }

            // Display the next question
            AskQuestion(_questionNumber);
        }
    }
}