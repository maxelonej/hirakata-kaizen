using HiraKata_Kaizen.Properties;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HiraKata_Kaizen {
    public partial class Settings : Form {
        public bool sidebarExpand; 
        Dashboard dashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
        public Settings() {
            InitializeComponent();
        }

        void Settings_Load(object sender, EventArgs e) {
            ControlBox = false;

            sidebarExpand = Properties.Settings.Default.sidebarExpand;
            if (sidebarExpand) {
                checkboxExpandSidebar.Checked = true;
            }
            else if (!sidebarExpand) {
                checkboxExpandSidebar.Checked = false;
            }

        }

        void btnApply_Click(object sender, EventArgs e) {
            if (checkboxExpandSidebar.Checked) { // expand true
                if (dashboard != null) {
                    dashboard.sidebar.Width = 235;
                    foreach (Button btn in dashboard.sidebar.Controls.OfType<Button>()) {
                        btn.Size = new Size(206, 40);
                        btn.ImageAlign = ContentAlignment.MiddleLeft;
                    }
                    dashboard.btnHome.Padding = new Padding(10, 0, 43, 0);
                    dashboard.btnExplore.Padding = new Padding(10, 0, 0, 0);
                    dashboard.btnLearn.Padding = new Padding(10, 0, 42, 0);
                    dashboard.btnStatistics.Padding = new Padding(10, 0, 13, 0);
                    dashboard.btnAchievements.Padding = new Padding(10, 0, 7, 0);
                    dashboard.btnSettings.Padding = new Padding(10, 0, 15, 0);
                    dashboard.btnAbout.Padding = new Padding(10, 0, 20, 0);
                }
                sidebarExpand = true;
                Properties.Settings.Default.sidebarExpand = true;
                Properties.Settings.Default.Save();
            }
            else { // expand false
                if (dashboard != null) {
                    dashboard.sidebar.Width = 64;
                    foreach (Button btn in dashboard.sidebar.Controls.OfType<Button>()) {
                        btn.Size = new Size(42, 40);
                        btn.ImageAlign = ContentAlignment.MiddleCenter;
                        btn.Padding = Padding.Empty;
                    }
                }
                sidebarExpand = false;
                Properties.Settings.Default.sidebarExpand = false;
                Properties.Settings.Default.Save();
            }
        }

        void checkbox_CheckedChanged(object sender, EventArgs e) {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked) {
                cb.Image = Properties.Resources.checkedCheckbox;
            }
            else {
                cb.Image = Properties.Resources.uncheckedCheckbox;
            }
        }
    }
}
