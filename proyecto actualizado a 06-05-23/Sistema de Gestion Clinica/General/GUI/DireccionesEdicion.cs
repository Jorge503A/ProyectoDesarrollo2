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
    public partial class DireccionesEdicion : Form
    {
        public DireccionesEdicion()
        {
            InitializeComponent();
            var tt = new ToolTip();
            tt.SetToolTip(pictureBoxGuardar, "Guardar");
            var tt1 = new ToolTip();
            tt1.SetToolTip(pictureBoxCancelar, "Cancelar");
        }

        private void pictureBoxGuardar_Click(object sender, EventArgs e)
        {
            if (DireccionesGestion.x)
            {
                try
                {
                    General.CLS.Direcciones direccion = new General.CLS.Direcciones();
                    direccion.Iddireccion = txtIdDireccion.Text.ToString();
                    direccion.NumeroCasa = txtNumeroCasa.Text.ToString();
                    direccion.PasajePoligono = txtPasajePoligono.Text.ToString();
                    direccion.Calle = txtCalle.Text.ToString();
                    direccion.Colonia = txtColonia.Text.ToString();
                    direccion.Canton = txtCanton.Text.ToString();
                    direccion.Caserio = txtCaserio.Text.ToString();
                    direccion.CodigoPostal = txtCodigoPostal.Text.ToString();
                    direccion.Pais = txtPais.Text.ToString();
                    direccion.IdMunicipio = txtIdMunicipio.Text.ToString();
                    Boolean f = direccion.Actualizar();
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
            else
            {
                try
                {
                    General.CLS.Direcciones direccion = new General.CLS.Direcciones();
                    direccion.NumeroCasa = txtNumeroCasa.Text.ToString();
                    direccion.PasajePoligono = txtPasajePoligono.Text.ToString();
                    direccion.Calle = txtCalle.Text.ToString();
                    direccion.Colonia = txtColonia.Text.ToString();
                    direccion.Canton = txtCanton.Text.ToString();
                    direccion.Caserio = txtCaserio.Text.ToString();
                    direccion.CodigoPostal = txtCodigoPostal.Text.ToString();
                    direccion.Pais = txtPais.Text.ToString();
                    direccion.IdMunicipio = txtIdMunicipio.Text.ToString();
                    Boolean f = direccion.Insertar();
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

        private void DireccionesEdicion_Load(object sender, EventArgs e)
        {
            txtIdDireccion.ReadOnly = true;
        }

        private void pictureBoxCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMunicipios_Click(object sender, EventArgs e)
        {
            MunicipiosConsultar f = new MunicipiosConsultar();
            f.ShowDialog();
            txtIdMunicipio.Text = MunicipiosConsultar._IDROL;
        }
    }
}
