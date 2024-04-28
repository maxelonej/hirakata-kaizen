using System;
using System.Windows.Forms;

namespace HiraKata_Kaizen {
    public partial class Dashboard : Form {
        bool sidebarExpand;
        public Dashboard() {
            InitializeComponent();
        }

        void GetSettings() {
            sidebarExpand = Properties.Settings.Default.sidebarExpand;
            if (sidebarExpand) {
                sidebar.Width = 272;
            }
            else if (!sidebarExpand) {
                sidebar.Width = 52;
            }
        }

        void Dashboard_Load(object sender, EventArgs e) {
            GetSettings();
        }

        void sidebarTransitionTimer_Tick(object sender, EventArgs e) {
            if (sidebarExpand) {
                sidebar.Width -= 4;
                if (sidebar.Width <= 52) {
                    sidebarExpand = false;
                    sidebarTransitionTimer.Stop();
                    Properties.Settings.Default.sidebarExpand = false;
                    Properties.Settings.Default.Save();
                }
            }
            else {
                sidebar.Width += 4;
                if (sidebar.Width >= 272) {
                    sidebarExpand = true;
                    sidebarTransitionTimer.Stop();
                    Properties.Settings.Default.sidebarExpand = true;
                    Properties.Settings.Default.Save();
                }
            }
        }

        void btnHamburgerMenu_Click(object sender, EventArgs e) {
            sidebarTransitionTimer.Start();
        }

        private void btnClose_Click(object sender, EventArgs e) {

        }

        private void btnMaximize_Click(object sender, EventArgs e) {

        }

        private void btnMinimize_Click(object sender, EventArgs e) {

        }

    }
}
