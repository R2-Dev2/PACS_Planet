using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CustomControls
{
    public class SWTextBox : TextBox
    {
        public SWTextBox()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SWTextBox
            // 
            this.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextChanged += new System.EventHandler(this.SWTextBox_TextChanged);
            this.Enter += new System.EventHandler(this.SWTextbox_Enter);
            this.Leave += new System.EventHandler(this.SWTextbox_Leave);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.SWTextbox_Validating);
            this.ResumeLayout(false);

        }
        public enum TipusDada
        {
            Nombre,
            Text,
            Codi
        }
        private TipusDada _dadaPermesa;
        public TipusDada dadaPermesa
        {
            get { return _dadaPermesa; }
            set
            {
                _dadaPermesa = value;
            }
        }

        private string _columnName;
        public string columnName
        {
            get { return _columnName; }
            set { _columnName = value; }
        }

        private bool _isForeignKey;
        public bool isForeignKey
        {
            get { return _isForeignKey; }
            set
            {
                _isForeignKey = value;
                if (isForeignKey)
                {
                    this.TabStop = false;
                }
            }
        }

        private bool _required;
        public bool required
        {
            get { return _required; }
            set { _required = value; }
        }

        private string _codiSW;

        public string codiSW
        {
            get { return _codiSW; }
            set { _codiSW = value; }
        }


        public void SWTextbox_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void SWTextbox_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightYellow;
        }

        private void SWTextbox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool validacio = false;

            if (this.dadaPermesa == TipusDada.Nombre)
            {
                Regex nombre = new Regex(@"^\d+$");
                if (nombre.IsMatch(this.Text))
                {
                    validacio = true;
                }
            }
            else if (this.dadaPermesa == TipusDada.Codi)
            {
                Regex text = new Regex(@"^[A-Z^AEIOU]{4}-\d{3}/[13579]{1}[AEIOU]{1}$");
                if (text.IsMatch(this.Text))
                {
                    validacio = true;
                }
            }
            else
            {
                validacio = true;
            }

            if (!validacio)
            {
                this.Clear();
            }
        }

        private void SWTextBox_TextChanged(object sender, EventArgs e)
        {
            if (isForeignKey)
            {
                if (codiSW != null)
                {
                    Form frm = this.FindForm();
                    foreach (Control ctrl in frm.Controls)
                    {
                        if (ctrl.Name == codiSW && ctrl is SWCodi swcodi)
                        {
                            swcodi.UpdateFromId(this.Text);
                            return;
                        }
                    }
                }
            }
        }
    }
}
