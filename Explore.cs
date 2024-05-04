using System;
using System.Drawing;
using System.Windows.Forms;

namespace HiraKata_Kaizen {
    public partial class Explore : Form {
        public Explore() {
            InitializeComponent();
        }

        void Explore_Load(object sender, EventArgs e) {
            ControlBox = false;

            btnHiragana.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, Color.Black);
            btnKatakana.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, Color.Black);

            // Какой фильтр был последний раз открыт - такой и открывать при открытии формы
            if (Properties.Settings.Default.lastOpenedFilter == "Hiragana") {
                btnHiragana_Click(btnHiragana, EventArgs.Empty);
            }
            else if (Properties.Settings.Default.lastOpenedFilter == "Katakana") {
                btnKatakana_Click(btnKatakana, EventArgs.Empty);
            }
        }

        void btnHiragana_Click(object sender, EventArgs e) {
            btnKatakana.BackColor = Color.FromArgb(30, 30, 34);
            btnHiragana.BackColor = Color.Maroon;
            btnHiragana.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 0, 10);
            btnHiragana.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnKatakana.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, Color.Black);
            katakanaContent.Visible = false; katakanaContent.Enabled = false;
            hiraganaContent.Visible = true; hiraganaContent.Enabled = true;
            Properties.Settings.Default.lastOpenedFilter = "Hiragana";
            Properties.Settings.Default.Save();
        }

        void btnKatakana_Click(object sender, EventArgs e) {
            btnHiragana.BackColor = Color.FromArgb(30, 30, 34);
            btnKatakana.BackColor = Color.Maroon;
            btnKatakana.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 0, 10);
            btnKatakana.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnHiragana.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, Color.Black);
            hiraganaContent.Visible = false; hiraganaContent.Enabled = false;
            katakanaContent.Visible = true; katakanaContent.Enabled = true;
            Properties.Settings.Default.lastOpenedFilter = "Katakana";
            Properties.Settings.Default.Save();
        }
    }
}
