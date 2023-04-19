using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class DireccionesConsultar : Form
    {
        public static String ID;
        BindingSource _DATOS = new BindingSource();
        public DireccionesConsultar()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.DIRECCIONES();
                dtgvDatos.AutoGenerateColumns = false;
                dtgvDatos.DataSource = _DATOS;
                lblRegistro.Text = dtgvDatos.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        private void DireccionesConsultar_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dtgvDatos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = dtgvDatos.CurrentRow.Cells[0].Value.ToString();
            Close();
        }
    }
}
