using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HiraKata_Kaizen {
    [DefaultEvent("OnSelectedIndexChanged")]
    public class CustomComboBox : UserControl {
        //Fields
        Color backColor = Color.FromArgb(30, 30, 34);
        Color foreColor = Color.White;
        Color iconColor = Color.Maroon;
        Color listBackColor = Color.Black;
        Color listForeColor = Color.White;
        Color borderColor = Color.Maroon;
        byte borderSize = 1;

        //Items
        ComboBox comboBox;
        Label label;
        Button btnIcon;

        //Events
        public event EventHandler OnSelectedIndexChanged;//Default event

        //Constructor
        public CustomComboBox() {
            comboBox = new ComboBox();
            label = new Label();
            btnIcon = new Button();
            SuspendLayout();

            //ComboBox: Dropdown list
            comboBox.BackColor = listBackColor;
            comboBox.Font = new Font(Font.Name, 10F);
            comboBox.ForeColor = foreColor;
            comboBox.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);//Default event
            comboBox.TextChanged += new EventHandler(ComboBox_TextChanged);//Refresh text
            comboBox.Click += new EventHandler(ComboBox_Click); 

            //Button: Icon
            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = backColor;
            btnIcon.Size = new Size(30, 30);
            btnIcon.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, Color.Red);
            //btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(Icon_Click);//Open dropdown list
            btnIcon.Paint += new PaintEventHandler(Icon_Paint);//Draw icon

            //Label: Text
            label.Dock = DockStyle.Fill;
            label.AutoSize = false;
            label.BackColor = backColor;
            label.ForeColor = foreColor;
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.Padding = new Padding(8, 0, 0, 0);
            label.Font = new Font(Font.Name, 10F);
            //->Attach label events to user control event
            label.Click += new EventHandler(Surface_Click);//Select combo box
            label.MouseEnter += new EventHandler(Surface_MouseEnter);
            label.MouseLeave += new EventHandler(Surface_MouseLeave);

            //User Control
            Controls.Add(label);//2
            Controls.Add(btnIcon);//1
            Controls.Add(comboBox);//0
            MinimumSize = new Size(121, 29);
            Size = new Size(121, 29);
            Padding = new Padding(borderSize);//Border Size
            Font = new Font(this.Font.Name, 10F);
            base.BackColor = borderColor; //Border Color
            ResumeLayout();
            AdjustComboBoxDimensions();
        }

        // Private methods
        void ComboBox_Click(object sender, EventArgs e) {
            //Open dropdown list
            comboBox.Select();
            comboBox.DroppedDown = true;
        }
        void AdjustComboBoxDimensions() {
            comboBox.Width = Width - Padding.Left - Padding.Right;
            comboBox.Height = label.Height;
            comboBox.Location = new Point() {
                X = Padding.Left,
                Y = label.Bottom - comboBox.Height
            };
        }

        //Event methods

        //-> Default event
        void ComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);
            //Refresh text
            label.Text = comboBox.Text;
        }
        //-> Items actions
        void Icon_Click(object sender, EventArgs e) {
            //Open dropdown list
            comboBox.Select();
            comboBox.DroppedDown = true;
        }
        void Surface_Click(object sender, EventArgs e) {
            //Attach label click to user control click
            OnClick(e);
            //Select combo box
            comboBox.Select();
            if (comboBox.DropDownStyle == ComboBoxStyle.DropDownList)
                comboBox.DroppedDown = true;//Open dropdown list
        }
        void ComboBox_TextChanged(object sender, EventArgs e) {
            //Refresh text
            label.Text = comboBox.Text;
        }

        //-> Draw icon
        private void Icon_Paint(object sender, PaintEventArgs e) {
            //Fields
            byte iconWidht = 14;
            byte iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon.Width - iconWidht) / 2, (btnIcon.Height - iconHeight) / 2, iconWidht, iconHeight);
            Graphics graph = e.Graphics;

            //Draw arrow down icon
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2)) {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidht / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidht / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }

        //Properties
        //-> Appearance
        [Category("Appearance")]
        public new Color BackColor {
            get { return backColor; }
            set {
                backColor = value;
                label.BackColor = backColor;
                btnIcon.BackColor = backColor;
            }
        }

        [Category("Appearance")]
        public Color IconColor {
            get { return iconColor; }
            set {
                iconColor = value;
                btnIcon.Invalidate();//Redraw icon
            }
        }

        [Category("Appearance")]
        public Color ListBackColor {
            get { return listBackColor; }
            set {
                listBackColor = value;
                comboBox.BackColor = listBackColor;
            }
        }

        [Category("Appearance")]
        public Color ListTextColor {
            get { return listForeColor; }
            set {
                listForeColor = value;
                comboBox.ForeColor = listForeColor;
            }
        }

        [Category("Appearance")]
        public Color BorderColor {
            get { return borderColor; }
            set {
                borderColor = value;
                base.BackColor = borderColor; //Border Color
            }
        }

        [Category("Appearance")]
        public int BorderSize {
            get { return borderSize; }
            set {
                borderSize = (byte)value;
                Padding = new Padding(borderSize);//Border Size
                AdjustComboBoxDimensions();
            }
        }

        [Category("Appearance")]
        public override Color ForeColor {
            get { return base.ForeColor; }
            set {
                base.ForeColor = value;
                label.ForeColor = value;
            }
        }

        [Category("Appearance")]
        public override Font Font {
            get { return base.Font; }
            set {
                base.Font = value;
                label.Font = value;
                comboBox.Font = value;//Optional
            }
        }

        [Category("Appearance")]
        public string Texts {
            get { return label.Text; }
            set { label.Text = value; }
        }

        [Category("Appearance")]
        public ComboBoxStyle DropDownStyle {
            get { return comboBox.DropDownStyle; }
            set {
                if (comboBox.DropDownStyle != ComboBoxStyle.Simple)
                    comboBox.DropDownStyle = value;
            }
        }

        //Properties
        //-> Data
        [Category("Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items {
            get { return comboBox.Items; }
        }

        [Category("Data")]
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public object DataSource {
            get { return comboBox.DataSource; }
            set { comboBox.DataSource = value; }
        }

        [Category("Data")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource {
            get { return comboBox.AutoCompleteCustomSource; }
            set { comboBox.AutoCompleteCustomSource = value; }
        }

        [Category("Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource {
            get { return comboBox.AutoCompleteSource; }
            set { comboBox.AutoCompleteSource = value; }
        }

        [Category("Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode {
            get { return comboBox.AutoCompleteMode; }
            set { comboBox.AutoCompleteMode = value; }
        }

        [Category("Data")]
        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem {
            get { return comboBox.SelectedItem; }
            set { comboBox.SelectedItem = value; }
        }

        [Category("Data")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex {
            get { return comboBox.SelectedIndex; }
            set { comboBox.SelectedIndex = value; }
        }

        [Category("Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string DisplayMember {
            get { return comboBox.DisplayMember; }
            set { comboBox.DisplayMember = value; }
        }

        [Category("Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string ValueMember {
            get { return comboBox.ValueMember; }
            set { comboBox.ValueMember = value; }
        }

        //->Attach label events to user control event
        private void Surface_MouseLeave(object sender, EventArgs e) {
            OnMouseLeave(e);
        }

        private void Surface_MouseEnter(object sender, EventArgs e) {
            OnMouseEnter(e);
        }
        //::::+

        //Overridden methods
        protected override void OnResize(EventArgs e) {
            base.OnResize(e);
            AdjustComboBoxDimensions();
        }
    }
}
