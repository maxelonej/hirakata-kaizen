using System;
using System.Windows.Forms;

namespace HiraKata_Kaizen {
    public partial class About : Form {
        public About() {
            InitializeComponent();
        }

        void About_Load(object sender, EventArgs e) {
            ControlBox = false;
        }
    }
}
