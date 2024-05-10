using HiraKata_Kaizen.Properties;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HiraKata_Kaizen {
    public partial class Settings : Form {
        //Dashboard dashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
        public Settings() {
            InitializeComponent();
        }

        void Settings_Load(object sender, EventArgs e) {
            ControlBox = false;
        }

        void btnApply_Click(object sender, EventArgs e) {
        }

        void checkbox_CheckedChanged(object sender, EventArgs e) {
            //CheckBox cb = sender as CheckBox;
            //if (cb.Checked) {
            //    cb.Image = Properties.Resources.checkedCheckbox;
            //}
            //else {
            //    cb.Image = Properties.Resources.uncheckedCheckbox;
            //}
        }
    }
}
