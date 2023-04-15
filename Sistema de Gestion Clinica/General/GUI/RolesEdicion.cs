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
    public partial class RolesEdicion : Form
    {
        public RolesEdicion()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(RolesGestion.x == 2)
            {
                try
                {
                    General.CLS.Roles roles = new General.CLS.Roles { IdRol=txtIdRol.Text.ToString(),Rol = txtRol.Text.ToString() };
                    Boolean f = roles.Actualizar();
                    if (f == false)
                    {
                        MessageBox.Show("Fallo Al Actualizar");
                    }
                    else
                    {
                        MessageBox.Show("Exito Al Actualizar");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("HA ocurrido un error inesperado");
                }
                Close();
            }
            if(RolesGestion.x == 3)
            {
                try
                {
                    General.CLS.Roles roles = new General.CLS.Roles { Rol = txtRol.Text.ToString() };
                    Boolean f = roles.Insertar();
                    if (f == false)
                    {
                        MessageBox.Show("Fallo Al Insertar");
                    }
                    else
                    {
                        MessageBox.Show("Exito Al Insertar");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("HA ocurrido un error inesperado");
                }
                Close();
            }
            
        }

        private void RolesEdicion_Load(object sender, EventArgs e)
        {
            if(RolesGestion.x == 2)
            {
                txtIdRol.Text = RolesGestion.idrol;
                txtRol.Text = RolesGestion.rol;
                txtIdRol.ReadOnly = true;
            }
        }
    }
}
