using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGC.GUI
{
    public partial class Main : Form
    {
        SessionManager.Session oSesion = SessionManager.Session.Instancia;

        public Main()
        {
            InitializeComponent();
        }
       
        private void Main_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = oSesion.Usuario;
            lblRol.Text = oSesion.Rol;
        }

        private void gestionDeRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.RolesGestion f = new General.GUI.RolesGestion();
                f.MdiParent = this;
                f.Show();
            }
            catch (Exception)
            {

            }
        }

        private void gestionDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.EmpleadosGestion f = new General.GUI.EmpleadosGestion();
                f.MdiParent = this;
                f.Show();
            }
            catch (Exception)
            {

            }
        }

        private void gestionDeDireccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General.GUI.DireccionesGestion f = new General.GUI.DireccionesGestion();
            f.MdiParent = this;
            f.Show();
        }
    }
}
