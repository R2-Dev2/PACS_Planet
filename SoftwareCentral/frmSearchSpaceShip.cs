using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareCentral
{
    public partial class frmSearchSpaceShip : frmSearch
    {

        public frmSearchSpaceShip(string controlId, Form originalForm)
        {
            InitializeComponent();
            this.tableName = "SpaceShips";
            this.title = "Search SpaceShips";
            this.controlId = controlId;
            this.originalForm = originalForm;
        }

        protected override void ConfigurarDataGrid()
        {
            base.ConfigurarDataGrid();
            dtgDades.Columns["idSpaceShip"].Visible = false;
            dtgDades.Columns["idSpaceShipType"].Visible = false;
            dtgDades.Columns["CodeSpaceShip"].HeaderText = "Code";
            dtgDades.Columns["IPSpaceShip"].HeaderText = "IP SpaceShip";
            dtgDades.Columns["PortSpaceShipL"].HeaderText = "Port Listen";
            dtgDades.Columns["PortSpaceShipS"].HeaderText = "Port Send";
        }
    }
}