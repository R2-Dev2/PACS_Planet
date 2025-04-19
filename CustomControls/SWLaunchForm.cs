using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace CustomControls
{
    public partial class SWLaunchForm : UserControl
    {
        private string library;
        private string form;
        private string description;
        private Image imagebtn;
        private Panel panel;

        public SWLaunchForm(Panel panel)
        {
            InitializeComponent();
            this.panel = panel;
        }

        public string Library
        {
            get { return library; }
            set { library = value; }
        }

        public string Form
        {
            get { return form; }
            set { form = value; }
        }

        public Image ImageBtn
        {
            get { return imagebtn; }
            set
            {
                imagebtn = value;
                if (imagebtn != null)
                {
                    pbImage.Image = imagebtn;
                }
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                if (!string.IsNullOrEmpty(description))
                {
                    lblTextBtn.Text = description;
                }
            }
        }

        private void SWLaunchForm_Click(object sender, EventArgs e)
        {
            try
            {
                Assembly ensamblat = Assembly.LoadFrom($@"{this.Library}.dll");
                Object dllBD;
                Type tipus;
                tipus = ensamblat.GetType($"{this.Library}.{this.Form}");
                Form form = ActiveForm(panel, tipus);
                if (form == null)
                {
                    dllBD = Activator.CreateInstance(tipus);
                    form = ((Form)dllBD);
                    form.TopLevel = false;
                    form.Dock = DockStyle.Fill;
                    panel.Controls.Add(form);
                    form.Show();
                }
                form.BringToFront();
                SetActiveColor();
            }
            catch (Exception)
            {
                MessageBox.Show($"Couldn't open form: {this.Form}");
            }
        }

        private Form ActiveForm(Control father, Type tipus)
        {
            foreach (Form control in father.Controls)
            {
                if (control.GetType() == tipus)
                {
                    return control;
                }
            }
            return null;
        }

        private void SetActiveColor()
        {
            Form frm = this.FindForm();
            foreach (Control ctrl in frm.Controls)
            {
                if (ctrl is FlowLayoutPanel flowLayoutPanel)
                {
                    foreach (Control ctrlPanel in flowLayoutPanel.Controls)
                    {
                        if (ctrlPanel is SWLaunchForm swLauncher)
                        {
                            swLauncher.BackColor = Color.PowderBlue;
                        }
                    }
                }
            }
            this.BackColor = Color.CadetBlue;
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            SWLaunchForm_Click(sender, e);
        }

        private void lblTextBtn_Click(object sender, EventArgs e)
        {
            SWLaunchForm_Click(sender, e);
        }
    }
}
