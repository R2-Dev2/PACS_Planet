using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using CustomControls;

namespace SearchForms
{
    public partial class frmSearch : Form
    {
        private AccesADades accesADades;
        private DataSet dts;
        private Dictionary<string, string> dict = new Dictionary<string, string>();

        protected string connectionString;
        protected string tableName;
        protected string controlId;
        protected Form originalForm;
        protected string idName;

        private string _title;

        public string title
        {
            get { return _title; }
            set
            {
                _title = value;
                lblTitle.Text = _title;
                lblTitle.Refresh();
            }
        }

        public frmSearch()
        {
            InitializeComponent();
        }

        protected virtual void ConfigurarDataGrid()
        {
            dtgDades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDades.RowHeadersVisible = false;
        }

        private void PortarDades()
        {
            dts = accesADades.ExecutaCerca(tableName, dict);
            dtgDades.DataSource = dts.Tables[0];
            ConfigurarDataGrid();
        }

        private void PortarDadesInicials()
        {
            string query = $"SELECT * FROM {this.tableName} WHERE 1 = 2";
            dts = accesADades.PortarPerConsulta(query);
            dtgDades.DataSource = dts.Tables[0];
            ConfigurarDataGrid();
        }

        private void FillDictionary()
        {
            dict.Clear();
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is SWTextBox)
                {
                    SWTextBox swTxt = (SWTextBox)ctrl;
                    if (!string.IsNullOrEmpty(swTxt.Text))
                    {
                        dict.Add(swTxt.columnName, swTxt.Text);
                    }
                }
            }
        }

        private void selectAndClose()
        {
            if (dts != null)
            {
                if (dtgDades.SelectedRows.Count > 0)
                {
                    string selectedValueId = dts.Tables[0].Rows[dtgDades.CurrentRow.Index][0].ToString();
                    UpdateControlId(selectedValueId);
                }
            }
            this.Close();
        }

        private void UpdateControlId(string id)
        {
            if (controlId != null)
            {
                foreach (Control ctrl in this.originalForm.Controls)
                {
                    if (ctrl.Name == controlId && ctrl is SWCodi swCodi)
                    {
                        swCodi.UpdateIdTextBox(id);
                        return;
                    }
                }
            }
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            this.connectionString = "SecureCore";
            this.accesADades = new AccesADades(this.connectionString);
            PortarDadesInicials();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillDictionary();
            PortarDades();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            selectAndClose();
        }

        private void dtgDades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectAndClose();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            dts = null;
            this.Close();
        }

        private void dtgDades_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                selectAndClose();
            }
        }
    }
}
