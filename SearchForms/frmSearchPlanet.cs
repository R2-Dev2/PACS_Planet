using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchForms
{
    public partial class frmSearchPlanet: frmSearch
    {
        public frmSearchPlanet(string controlId, Form originalForm)
        {
            InitializeComponent();
            this.tableName = "Planets";
            this.title = "Search Planets";
            this.controlId = controlId;
            this.originalForm = originalForm;
        }
        protected override void ConfigurarDataGrid()
        {
            base.ConfigurarDataGrid();
            dtgDades.Columns["idPlanet"].Visible = false;
            dtgDades.Columns["idSector"].Visible = false;
            dtgDades.Columns["idNatives"].Visible = false;
            dtgDades.Columns["idFiliation"].Visible = false;
            dtgDades.Columns["CodePlanet"].HeaderText = "Code";
            dtgDades.Columns["DescPlanet"].HeaderText = "Description";
            dtgDades.Columns["long"].HeaderText = "Long";
            dtgDades.Columns["lat"].HeaderText = "Lat";
            dtgDades.Columns["parsecs"].HeaderText = "Parsecs";
            dtgDades.Columns["PlanetPicture"].HeaderText = "Planet Picture";
            dtgDades.Columns["IPPlanet"].HeaderText = "IP Planet";
            dtgDades.Columns["PortPlanet"].HeaderText = "Port Planet";
            dtgDades.Columns["PortPlanet1"].HeaderText = "Port Planet1";
        }
    }
}
