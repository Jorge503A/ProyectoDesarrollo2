using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
            DataTable Resultado = new DataTable();
            Resultado = Operacion.Consultar("Select * from Pais;");
            dtgDatos.DataSource = Resultado;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
            Int32 nFilas = 0;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO pais(Pais) values('");
            Sentencia.Append(txbPais.Text);
            Sentencia.Append("');");

            nFilas = Operacion.EjecutarSentencia(Sentencia.ToString());
            if (nFilas > 0)
            {
                MessageBox.Show("Registro insertado");
            }
            else
            {
                MessageBox.Show("No se pudo insertar el registro");
            }
        }
    }
}
