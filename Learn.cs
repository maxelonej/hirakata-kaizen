using System;
using System.Linq;
using System.Windows.Forms;

namespace HiraKata_Kaizen {
    public partial class Learn : Form {

        public Learn() {
            InitializeComponent();
        }

        void Learn_Load(object sender, EventArgs e) {
            ControlBox = false;
        }

        void btnQuiz_Click(object sender, EventArgs e) {
            var dashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            if (dashboard.content.Controls.Count > 0) dashboard.content.Controls.RemoveAt(0);
            Quiz quiz = new Quiz();
            quiz.TopLevel = false;
            quiz.Dock = DockStyle.Fill;
            dashboard.content.Controls.Add(quiz);
            dashboard.content.Tag = quiz;
            quiz.Show();
        }
    }
}
