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
    public partial class Login : Form
    {

        SessionManager.Session oSesion = SessionManager.Session.Instancia;
        Boolean _Autorizado = false;

        public bool Autorizado { get => _Autorizado;  }
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (oSesion.IniciarSesion(txtUsuario.Text, txtClave.Text))
            {
                _Autorizado = true;
                Close();
            }
            else
            {
                _Autorizado = false;
                lblMensaje.Text = "Usuario o clave incorrectos";
                lblMensaje.ForeColor = Color.Red;
                txtClave.Focus();
                txtClave.SelectAll();
            }
             
        }

        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (oSesion.IniciarSesion(txtUsuario.Text, txtClave.Text))
                {
                    _Autorizado = true;
                    Close();
                }
                else
                {
                    _Autorizado = false;
                    lblMensaje.Text = "Usuario o clave incorrectos";
                    lblMensaje.ForeColor = Color.Red;
                    txtClave.Focus();
                    txtClave.SelectAll();
                }
            }
        }
    }
}
