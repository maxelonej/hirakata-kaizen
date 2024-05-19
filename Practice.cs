using System;
using System.Linq;
using System.Windows.Forms;

namespace HiraKata_Kaizen {
    public partial class Practice : Form {
        public Practice() {
            InitializeComponent();
        }

        void openChoice(string openNext) {
            Dashboard dashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            if (dashboard.content.Controls.Count > 0) dashboard.content.Controls.RemoveAt(0);
            Choice choice = new Choice();
            choice.TopLevel = false;
            choice.Dock = DockStyle.Fill;
            dashboard.content.Controls.Add(choice);
            dashboard.content.Tag = choice;
            choice.openNext = openNext; // Чтобы определить какая кнопка была нажата
            choice.Show();
        }

        void btnQuiz_Click(object sender, EventArgs e) {
            openChoice("quiz");
        }

        void btnCards_Click(object sender, EventArgs e) {
            openChoice("cards");
        }
    }
}
