using System;
using System.Windows.Forms;

namespace HiraKata_Kaizen {
    public partial class Home : Form {
        public Home() {
            InitializeComponent();
        }

        void Home_Load(object sender, EventArgs e) {
            ControlBox = false;
        }
    }
}
