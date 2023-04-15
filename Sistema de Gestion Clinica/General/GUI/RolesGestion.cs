using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using General.CLS;

namespace General.GUI
{
    public partial class RolesGestion : Form
    {
        public static String rol;
        public static int x = 0;
        public static String idrol;
        BindingSource _DATOS = new BindingSource();

        public void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.ROLES();
                dtgvDatos.AutoGenerateColumns = false;
                dtgvDatos.DataSource = _DATOS;
                lblRegistro.Text = dtgvDatos.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch(Exception)
            {

            }
        }

        public RolesGestion()
        {
            InitializeComponent();
        }

        private void RolesGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            x = 3;
            RolesEdicion f = new RolesEdicion();
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons x;
            x = (MessageBoxButtons)MessageBox.Show("ESTAS SEGURO DE LA ELIMINACION", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (x.ToString() == "OKCancel")
            {
                try
                {
                    General.CLS.Roles roles = new CLS.Roles { IdRol = dtgvDatos.CurrentRow.Cells[0].Value.ToString() };
                    Boolean f = roles.Eliminar();
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
            x = 2;
            rol = dtgvDatos.CurrentRow.Cells[1].Value.ToString();
            idrol = dtgvDatos.CurrentRow.Cells[0].Value.ToString();
            RolesEdicion f = new RolesEdicion();
            f.ShowDialog();
            CargarDatos();
        }
    }
}
