using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HiraKata_Kaizen {
    public partial class Dashboard : Form {
        Point dragCursorPoint, dragFormPoint; // drag header
        bool mousedown; 
        Point initialLocation; Size initialSize; // back form from maximize
        Form currentForm; // Add a variable to store the current form

        public Dashboard() {
            InitializeComponent();

            initialLocation = Location;
            initialSize = Size;
        }

        public void loadForm(object Form) {
            // checks if the content panel already contains a form of the same type as the one being loaded
            // brings that form to the front instead of removing and re-adding it
            // This should prevent unnecessary form reload
            if (content.Controls.Count > 0 && content.Tag != null && content.Tag.GetType() == Form.GetType()) {
                currentForm = content.Tag as Form;
                currentForm.BringToFront();
                return;
            }

            if (content.Controls.Count > 0) content.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            content.Controls.Add(f);
            content.Tag = f;
            f.Show();

            currentForm = f;
        }

        bool sidebarExpand;
        void GetSettings() {
            sidebarExpand = Properties.Settings.Default.sidebarExpand;
            if (sidebarExpand) {
                sidebar.Width = 235;
            }
            else if (!sidebarExpand) {
                sidebar.Width = 64;
                foreach (Button btn in sidebar.Controls.OfType<Button>()) {
                    btn.Text = "";
                    btn.Size = new Size(42, 40);
                    btn.ImageAlign = ContentAlignment.MiddleCenter;
                    btn.Padding = Padding.Empty;
                }
            }
        }

        void Dashboard_Load(object sender, EventArgs e) {
            GetSettings(); // Load settings 
            loadForm(new Home());
            ChangeButtonColor(btnHome); 
        }
        
        void btnMinimize_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }
        void btnMaximize_Click(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Maximized) {
                WindowState = FormWindowState.Normal;
                StartPosition = FormStartPosition.CenterScreen;
            } else {
                WindowState = FormWindowState.Maximized;
            }
        }
        void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        // Сделать шапку draggable
        void header_MouseDown(object sender, MouseEventArgs e) {
            mousedown = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
            // WindowState = FormWindowState.Normal; 
        }
        void header_MouseUp(object sender, MouseEventArgs e) {
            mousedown = false;
        }
        void header_MouseMove(object sender, MouseEventArgs e) {
            if (mousedown) {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        // header doubleclick = maximize window or normal if maximized
        void header_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (WindowState == FormWindowState.Maximized) {
                WindowState = FormWindowState.Normal;
                Location = initialLocation;
                Size = initialSize;
            } else {
                WindowState = FormWindowState.Maximized;
            }
        }

        Button previousButton = null;
        void ChangeButtonColor(Button currentButton) {
            if (previousButton != null) {
                previousButton.BackColor = Color.FromArgb(24, 24, 27);
            }

            if (currentButton != null) {
                currentButton.BackColor = Color.FromArgb(14, 14, 16);
                previousButton = currentButton;
            }
        }

        void btnHome_Click(object sender, EventArgs e) {
            loadForm(new Home());
            ChangeButtonColor(sender as Button);
        }
        void btnExplore_Click(object sender, EventArgs e) {
            loadForm(new Explore());
            ChangeButtonColor(sender as Button);
        }
        void btnLearn_Click(object sender, EventArgs e) {
            loadForm(new Learn());
            ChangeButtonColor(sender as Button);
        }
        void btnStatistics_Click(object sender, EventArgs e) {
            loadForm(new Statistics());
            ChangeButtonColor(sender as Button);
        }
        void btnAchievements_Click(object sender, EventArgs e) {
            loadForm(new Achievements());
            ChangeButtonColor(sender as Button);
        }
        void btnSettings_Click(object sender, EventArgs e) {
            loadForm(new Settings());
            ChangeButtonColor(sender as Button);
        }
        void btnAbout_Click(object sender, EventArgs e) {
            loadForm(new About());
            ChangeButtonColor(sender as Button);
        }
    }
}
