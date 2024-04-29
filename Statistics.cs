using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiraKata_Kaizen {
    public partial class Statistics : Form {
        public Statistics() {
            InitializeComponent();
        }

        void Statistics_Load(object sender, EventArgs e) {
            ControlBox = false;
        }
    }
}
