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
    public partial class DireccionesGestion : Form
    {
        public static Boolean x = false;
        BindingSource _DATOS = new BindingSource();
        public DireccionesGestion()
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

        private void DireccionesGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DireccionesEdicion f = new DireccionesEdicion();
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ESTAS SEGURO DE LA ELIMINACION", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    General.CLS.Direcciones direccion = new General.CLS.Direcciones { Iddireccion = dtgvDatos.CurrentRow.Cells[0].Value.ToString() };
                    Boolean f = direccion.Eliminar();
                    if (f == false)
                    {
                        MessageBox.Show("Eliminacion Fallida");
                    }
                    else
                    {
                        MessageBox.Show("Eliminacion exitosa");
                    }
                    CargarDatos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error inesperado");
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ESTAS SEGURO DE ACTUALIZAR EL REGISTRO SELECCIONADO", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                x = true;
                DireccionesEdicion f = new DireccionesEdicion();
                f.txtIdDireccion.Text = dtgvDatos.CurrentRow.Cells[0].Value.ToString();
                f.txtNumeroCasa.Text = dtgvDatos.CurrentRow.Cells[1].Value.ToString();
                f.txtPasajePoligono.Text = dtgvDatos.CurrentRow.Cells[2].Value.ToString();
                f.txtCalle.Text = dtgvDatos.CurrentRow.Cells[3].Value.ToString();
                f.txtColonia.Text = dtgvDatos.CurrentRow.Cells[4].Value.ToString();
                f.txtCanton.Text = dtgvDatos.CurrentRow.Cells[5].Value.ToString();
                f.txtCaserio.Text = dtgvDatos.CurrentRow.Cells[6].Value.ToString();
                f.txtCodigoPostal.Text = dtgvDatos.CurrentRow.Cells[7].Value.ToString();
                f.txtPais.Text = dtgvDatos.CurrentRow.Cells[8].Value.ToString();
                f.txtIdMunicipio.Text = dtgvDatos.CurrentRow.Cells[9].Value.ToString();
                f.ShowDialog();
                CargarDatos();
            }
        }
    }
}
