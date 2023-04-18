﻿using System;
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
    public partial class EmpleadosEdicion : Form
    {
        public EmpleadosEdicion()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(EmpleadosGestion.x == false)
            {
                try
                {
                    General.CLS.Empleados Empleado = new General.CLS.Empleados { NombreEmpleado = txtNombreEmpleado.Text.ToString(), ApellidoEmpleado = txtApellidoEmpleado.Text.ToString(), TelefonoEmpleado = txtTelefonoEmpleado.Text.ToString(), Genero = cmbGenero.Text.ToString(), IdDireccion = txtIdDireccion.Text.ToString() };
                    Boolean f = Empleado.Insertar();
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
            if(EmpleadosGestion.x == true)
            {
                try
                {
                    General.CLS.Empleados Empleado = new General.CLS.Empleados { IdEmpleado = txtIdEmpleado.Text.ToString(),NombreEmpleado = txtNombreEmpleado.Text.ToString(), ApellidoEmpleado = txtApellidoEmpleado.Text.ToString(), TelefonoEmpleado = txtTelefonoEmpleado.Text.ToString(), Genero = cmbGenero.Text.ToString(), IdDireccion = txtIdDireccion.Text.ToString() };
                    Boolean f = Empleado.Actualizar();
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
        }

        private void EmpleadosEdicion_Load(object sender, EventArgs e)
        {
            if (EmpleadosGestion.x == true)
            {
                txtIdEmpleado.Text = EmpleadosGestion.idempleado;
                txtIdEmpleado.ReadOnly = true;
                txtNombreEmpleado.Text = EmpleadosGestion.nombreempleado;
                txtApellidoEmpleado.Text = EmpleadosGestion.apellidoempleado;
                txtTelefonoEmpleado.Text = EmpleadosGestion.telefonoempleado;
                cmbGenero.Text = EmpleadosGestion.genero;
                txtIdDireccion.Text = EmpleadosGestion.iddireccion;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
