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
        public static Boolean x = false;
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
            x = false; ;
            RolesEdicion f = new RolesEdicion();
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ESTAS SEGURO QUE DESEA ELIMINAR EL REGRISTRO SELECCIONADO", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
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
            if (MessageBox.Show("ESTAS SEGURO DE ACTUALIZAR EL REGISTRO SELECCIONADO", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
            {
                x = true;
                RolesEdicion f = new RolesEdicion();
                f.txtRol.Text = dtgvDatos.CurrentRow.Cells[1].Value.ToString();
                f.txtIdRol.Text = dtgvDatos.CurrentRow.Cells[0].Value.ToString();
                f.ShowDialog();
                CargarDatos();
            }
        }
    }
}
