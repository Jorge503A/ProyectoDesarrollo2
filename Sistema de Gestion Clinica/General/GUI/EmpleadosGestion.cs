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
    public partial class EmpleadosGestion : Form
    {
        public static String idempleado;
        public static String nombreempleado;
        public static String apellidoempleado;
        public static String telefonoempleado;
        public static String genero;
        public static String iddireccion;
        public static Boolean x = false;
        BindingSource _DATOS = new BindingSource();

        public void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.EMPLEADOS();
                dtgvDatos.AutoGenerateColumns = false;
                dtgvDatos.DataSource = _DATOS;
                lblRegistro.Text = dtgvDatos.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }
        public EmpleadosGestion()
        {
            InitializeComponent();
        }


        private void EmpleadosGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            x = false;
            EmpleadosEdicion f = new EmpleadosEdicion();
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ESTAS SEGURO DE LA ELIMINACION", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    General.CLS.Empleados empleados = new General.CLS.Empleados { IdEmpleado = dtgvDatos.CurrentRow.Cells[0].Value.ToString() };
                    Boolean f = empleados.Eliminar();
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
            x = true;
            idempleado = dtgvDatos.CurrentRow.Cells[0].Value.ToString();
            nombreempleado = dtgvDatos.CurrentRow.Cells[1].Value.ToString();
            apellidoempleado = dtgvDatos.CurrentRow.Cells[2].Value.ToString();
            telefonoempleado = dtgvDatos.CurrentRow.Cells[3].Value.ToString();
            genero = dtgvDatos.CurrentRow.Cells[4].Value.ToString();
            iddireccion = dtgvDatos.CurrentRow.Cells[5].Value.ToString();
            EmpleadosEdicion f = new EmpleadosEdicion();
            f.ShowDialog();
            CargarDatos();

        }
    }
}
