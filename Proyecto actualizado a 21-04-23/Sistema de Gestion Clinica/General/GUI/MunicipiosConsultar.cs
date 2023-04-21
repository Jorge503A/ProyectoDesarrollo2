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
    public partial class MunicipiosConsultar : Form
    {
        BindingSource _DATOS = new BindingSource();
        public static String _IDROL;


        public MunicipiosConsultar()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.MUNICIPIOS();
                dtgvDatos.AutoGenerateColumns = false;
                dtgvDatos.DataSource = _DATOS;
            }
            catch (Exception)
            {

            }
        }

        public void CargarDatosBusqueda()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.MUNICIPIOS1(txtBusqueda.Text.ToString());
                dtgvDatos.AutoGenerateColumns = false;
                dtgvDatos.DataSource = _DATOS;
            }
            catch (Exception)
            {

            }
        }

        private void MunicipiosConsultar_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(txtBusqueda.Text.Length > 0)
            {
                CargarDatosBusqueda();
            }
            else
            {
                CargarDatos();
            }
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (txtBusqueda.Text.Length > 0)
                {
                    CargarDatosBusqueda();
                }
                else
                {
                    CargarDatos();
                }
            }
        }

        private void dtgvDatos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _IDROL = dtgvDatos.CurrentRow.Cells[0].Value.ToString();
            Close();
        }
    }
}
