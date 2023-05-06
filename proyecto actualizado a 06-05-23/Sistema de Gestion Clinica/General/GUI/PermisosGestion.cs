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
    public partial class PermisosGestion : Form
    {
        private void CargarRoles()
        {
            DataTable roles = new DataTable();
            try
            {
                roles = DataManager.DBConsultas.ROLES();
                cbbRoles.DataSource = roles;
                cbbRoles.DisplayMember = "Rol";
                cbbRoles.ValueMember = "IdRol";
            }
            catch (Exception)
            {

            }
        }

        private void CargarPermisos()
        {
            DataTable permisos = new DataTable();
            string PIDRol = cbbRoles.SelectedValue.ToString();
            try
            {
                permisos = DataManager.DBConsultas.PERMISOS(PIDRol);
                dtgvPermisos.AutoGenerateColumns = false;
                dtgvPermisos.DataSource = permisos;

            }
            catch (Exception)
            {

            }
        }
        public PermisosGestion()
        {
            InitializeComponent();
        }

        private void PermisosGestion_Load(object sender, EventArgs e)
        {
            CargarRoles();
        }

        private void cbbRoles_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarPermisos();
        }

        private void dtgvPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex == 0)
                {
                    String ValorActual;
                    ValorActual = dtgvPermisos.CurrentRow.Cells["Asignado"].Value.ToString();
                    if(ValorActual == "0")
                    {
                        CLS.Permisos oPermisos = new CLS.Permisos();
                        oPermisos.IdOpcion = dtgvPermisos.CurrentRow.Cells["IdOpcion"].Value.ToString();
                        oPermisos.IdRol= cbbRoles.SelectedValue.ToString();

                        if (oPermisos.Insertar())
                        {
                            CargarPermisos();
                        }
                    }
                    else
                    {
                        CLS.Permisos oPermisos = new CLS.Permisos();
                        oPermisos.IdPermiso = dtgvPermisos.CurrentRow.Cells["IdPermiso"].Value.ToString();

                        if (oPermisos.Eliminar())
                        {
                            CargarPermisos();
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
