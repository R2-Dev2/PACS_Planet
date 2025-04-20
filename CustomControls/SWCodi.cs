using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace CustomControls
{
    public partial class SWCodi : UserControl
    {
        private AccesADades accesADades;

        private string _tableName;

        public string tableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }

        private string _codeName;

        public string codeName
        {
            get { return _codeName; }
            set { _codeName = value; }
        }

        private string _descName;

        public string descName
        {
            get { return _descName; }
            set { _descName = value; }
        }

        private string _nameId;

        public string nameId
        {
            get { return _nameId; }
            set { _nameId = value; }
        }

        private string _controlId;

        public string controlId
        {
            get { return _controlId; }
            set { _controlId = value; }
        }

        private string _formCS;

        public string formCS
        {
            get { return _formCS; }
            set { _formCS = value; }
        }

        private string _classeCS;

        public string classeCS
        {
            get { return _classeCS; }
            set { _classeCS = value; }
        }

        public string getValue()
        {
            return txtDesc.Text;
        }

        public SWCodi()
        {
            InitializeComponent();
        }

        private void ValidateCode()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add(this.codeName, txtCodi.Text);
            DataSet dts = accesADades.ExecutaCerca(this.tableName, dict);

            string id = "";
            if (dts.Tables[0].Rows.Count == 1)
            {
                txtDesc.Text = dts.Tables[0].Rows[0][this.descName].ToString();
                id = dts.Tables[0].Rows[0][this.nameId].ToString();
            }
            else
            {
                txtDesc.Text = "Unknown data";
            }
            UpdateIdTextBox(id);
        }


        public void UpdateFromId(string id)
        {
            if (id == "")
            {
                txtCodi.Text = "";
                txtDesc.Text = "";
                return;
            }
            string query = $"SELECT * FROM {this.tableName} WHERE {this.nameId} = '{id}'";
            DataSet dts = accesADades.PortarPerConsulta(query);

            if (dts.Tables[0].Rows.Count == 1)
            {
                txtCodi.Text = dts.Tables[0].Rows[0][this.codeName].ToString();
                txtDesc.Text = dts.Tables[0].Rows[0][this.descName].ToString();
            }
            else
            {
                if (txtCodi.Text == "")
                {
                    txtDesc.Text = "";
                }
                else
                {
                    txtDesc.Text = "Unknown data";
                }
            }
        }

        public void UpdateIdTextBox(string newId)
        {
            if (controlId != null)
            {
                Form frm = this.FindForm();
                foreach (Control ctrl in frm.Controls)
                {
                    if (ctrl.Name == controlId && ctrl is SWTextBox swTextBox)
                    {
                        swTextBox.Text = newId;
                        return;
                    }
                }
            }
        }

        private void OpenCS()
        {
            try
            {
                Assembly assembly = Assembly.LoadFrom($@"{this.classeCS}.dll");
                Object dllBD;
                Type type;

                type = assembly.GetType($"{this.classeCS}.{this.formCS}");
                Object[] args = { this.Name, this.FindForm() };
                dllBD = Activator.CreateInstance(type, args);
                Form frm = (Form)dllBD;

                frm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show($"Couldn't open form: {this.formCS}");
            }
        }

        private void SWCodi_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            this.accesADades = new AccesADades("SecureCore");
        }

        private void txtCodi_Leave(object sender, EventArgs e)
        {
            ValidateCode();
        }

        private void txtCodi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                OpenCS();
            }
        }

        private void txtCodi_DoubleClick(object sender, EventArgs e)
        {
            OpenCS();
        }
    }
}
