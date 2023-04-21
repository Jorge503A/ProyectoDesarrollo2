namespace General.GUI
{
    partial class EmpleadosEdicion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIdEmpleado = new System.Windows.Forms.Label();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.lblApellidoEmpleado = new System.Windows.Forms.Label();
            this.lblIdDireccion = new System.Windows.Forms.Label();
            this.lblTelefonoEmpleado = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.txtTelefonoEmpleado = new System.Windows.Forms.TextBox();
            this.txtIdDireccion = new System.Windows.Forms.TextBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.btnDireccion = new System.Windows.Forms.Button();
            this.pictureBoxCancelar = new System.Windows.Forms.PictureBox();
            this.pictureBoxGuardar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdEmpleado
            // 
            this.lblIdEmpleado.AutoSize = true;
            this.lblIdEmpleado.Location = new System.Drawing.Point(19, 38);
            this.lblIdEmpleado.Name = "lblIdEmpleado";
            this.lblIdEmpleado.Size = new System.Drawing.Size(65, 13);
            this.lblIdEmpleado.TabIndex = 0;
            this.lblIdEmpleado.Text = "IDEmpleado";
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(22, 78);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(94, 13);
            this.lblNombreEmpleado.TabIndex = 1;
            this.lblNombreEmpleado.Text = "Nombre Empleado";
            // 
            // lblApellidoEmpleado
            // 
            this.lblApellidoEmpleado.AutoSize = true;
            this.lblApellidoEmpleado.Location = new System.Drawing.Point(22, 113);
            this.lblApellidoEmpleado.Name = "lblApellidoEmpleado";
            this.lblApellidoEmpleado.Size = new System.Drawing.Size(94, 13);
            this.lblApellidoEmpleado.TabIndex = 2;
            this.lblApellidoEmpleado.Text = "Apellido Empleado";
            // 
            // lblIdDireccion
            // 
            this.lblIdDireccion.AutoSize = true;
            this.lblIdDireccion.Location = new System.Drawing.Point(23, 251);
            this.lblIdDireccion.Name = "lblIdDireccion";
            this.lblIdDireccion.Size = new System.Drawing.Size(61, 13);
            this.lblIdDireccion.TabIndex = 3;
            this.lblIdDireccion.Text = "IdDireccion";
            // 
            // lblTelefonoEmpleado
            // 
            this.lblTelefonoEmpleado.AutoSize = true;
            this.lblTelefonoEmpleado.Location = new System.Drawing.Point(22, 161);
            this.lblTelefonoEmpleado.Name = "lblTelefonoEmpleado";
            this.lblTelefonoEmpleado.Size = new System.Drawing.Size(99, 13);
            this.lblTelefonoEmpleado.TabIndex = 4;
            this.lblTelefonoEmpleado.Text = "Telefono Empleado";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(22, 200);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 5;
            this.lblGenero.Text = "Genero";
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(22, 55);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(42, 20);
            this.txtIdEmpleado.TabIndex = 6;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(22, 90);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(238, 20);
            this.txtNombreEmpleado.TabIndex = 7;
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(22, 129);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(238, 20);
            this.txtApellidoEmpleado.TabIndex = 8;
            // 
            // txtTelefonoEmpleado
            // 
            this.txtTelefonoEmpleado.Location = new System.Drawing.Point(25, 177);
            this.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            this.txtTelefonoEmpleado.Size = new System.Drawing.Size(235, 20);
            this.txtTelefonoEmpleado.TabIndex = 9;
            // 
            // txtIdDireccion
            // 
            this.txtIdDireccion.Location = new System.Drawing.Point(22, 267);
            this.txtIdDireccion.Name = "txtIdDireccion";
            this.txtIdDireccion.Size = new System.Drawing.Size(42, 20);
            this.txtIdDireccion.TabIndex = 10;
            // 
            // cmbGenero
            // 
            this.cmbGenero.AutoCompleteCustomSource.AddRange(new string[] {
            "M",
            "F"});
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbGenero.Location = new System.Drawing.Point(25, 216);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero.TabIndex = 11;
            this.cmbGenero.Text = "SELECCIONE";
            // 
            // btnDireccion
            // 
            this.btnDireccion.Location = new System.Drawing.Point(71, 267);
            this.btnDireccion.Name = "btnDireccion";
            this.btnDireccion.Size = new System.Drawing.Size(75, 23);
            this.btnDireccion.TabIndex = 14;
            this.btnDireccion.Text = "Dirección";
            this.btnDireccion.UseVisualStyleBackColor = true;
            this.btnDireccion.Click += new System.EventHandler(this.btnDireccion_Click);
            // 
            // pictureBoxCancelar
            // 
            this.pictureBoxCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCancelar.Image = global::General.Properties.Resources.cancelar;
            this.pictureBoxCancelar.Location = new System.Drawing.Point(313, 305);
            this.pictureBoxCancelar.Name = "pictureBoxCancelar";
            this.pictureBoxCancelar.Size = new System.Drawing.Size(50, 39);
            this.pictureBoxCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCancelar.TabIndex = 16;
            this.pictureBoxCancelar.TabStop = false;
            this.pictureBoxCancelar.Click += new System.EventHandler(this.pictureBoxCancelar_Click);
            // 
            // pictureBoxGuardar
            // 
            this.pictureBoxGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxGuardar.Image = global::General.Properties.Resources.GuardarIcon;
            this.pictureBoxGuardar.Location = new System.Drawing.Point(240, 305);
            this.pictureBoxGuardar.Name = "pictureBoxGuardar";
            this.pictureBoxGuardar.Size = new System.Drawing.Size(50, 39);
            this.pictureBoxGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGuardar.TabIndex = 15;
            this.pictureBoxGuardar.TabStop = false;
            this.pictureBoxGuardar.Click += new System.EventHandler(this.pictureBoxGuardar_Click);
            // 
            // EmpleadosEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 356);
            this.Controls.Add(this.pictureBoxCancelar);
            this.Controls.Add(this.pictureBoxGuardar);
            this.Controls.Add(this.btnDireccion);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.txtIdDireccion);
            this.Controls.Add(this.txtTelefonoEmpleado);
            this.Controls.Add(this.txtApellidoEmpleado);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblTelefonoEmpleado);
            this.Controls.Add(this.lblIdDireccion);
            this.Controls.Add(this.lblApellidoEmpleado);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Controls.Add(this.lblIdEmpleado);
            this.Name = "EmpleadosEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmpleadosEdicion";
            this.Load += new System.EventHandler(this.EmpleadosEdicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdEmpleado;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.Label lblApellidoEmpleado;
        private System.Windows.Forms.Label lblIdDireccion;
        private System.Windows.Forms.Label lblTelefonoEmpleado;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtApellidoEmpleado;
        private System.Windows.Forms.TextBox txtTelefonoEmpleado;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Button btnDireccion;
        public System.Windows.Forms.TextBox txtIdDireccion;
        private System.Windows.Forms.PictureBox pictureBoxCancelar;
        private System.Windows.Forms.PictureBox pictureBoxGuardar;
    }
}