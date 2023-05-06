namespace General.GUI
{
    partial class PermisosGestion
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
            this.cbbRoles = new System.Windows.Forms.ComboBox();
            this.lblSeleccioneRol = new System.Windows.Forms.Label();
            this.dtgvPermisos = new System.Windows.Forms.DataGridView();
            this.Asignado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IdOpcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdClasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbRoles
            // 
            this.cbbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoles.FormattingEnabled = true;
            this.cbbRoles.Location = new System.Drawing.Point(45, 93);
            this.cbbRoles.Name = "cbbRoles";
            this.cbbRoles.Size = new System.Drawing.Size(240, 21);
            this.cbbRoles.TabIndex = 0;
            this.cbbRoles.SelectedValueChanged += new System.EventHandler(this.cbbRoles_SelectedValueChanged);
            // 
            // lblSeleccioneRol
            // 
            this.lblSeleccioneRol.AutoSize = true;
            this.lblSeleccioneRol.Location = new System.Drawing.Point(42, 68);
            this.lblSeleccioneRol.Name = "lblSeleccioneRol";
            this.lblSeleccioneRol.Size = new System.Drawing.Size(91, 13);
            this.lblSeleccioneRol.TabIndex = 1;
            this.lblSeleccioneRol.Text = "Seleccione El Rol";
            // 
            // dtgvPermisos
            // 
            this.dtgvPermisos.AllowUserToAddRows = false;
            this.dtgvPermisos.AllowUserToDeleteRows = false;
            this.dtgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Asignado,
            this.IdOpcion,
            this.Opcion,
            this.IdClasificacion,
            this.Clasificacion,
            this.IdPermiso});
            this.dtgvPermisos.Location = new System.Drawing.Point(12, 135);
            this.dtgvPermisos.Name = "dtgvPermisos";
            this.dtgvPermisos.ReadOnly = true;
            this.dtgvPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPermisos.Size = new System.Drawing.Size(652, 239);
            this.dtgvPermisos.TabIndex = 2;
            this.dtgvPermisos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPermisos_CellContentClick);
            // 
            // Asignado
            // 
            this.Asignado.DataPropertyName = "Asignado";
            this.Asignado.HeaderText = "Asignado";
            this.Asignado.Name = "Asignado";
            // 
            // IdOpcion
            // 
            this.IdOpcion.DataPropertyName = "IdOpcion";
            this.IdOpcion.HeaderText = "ID";
            this.IdOpcion.Name = "IdOpcion";
            // 
            // Opcion
            // 
            this.Opcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Opcion.DataPropertyName = "Opcion";
            this.Opcion.HeaderText = "Opcion";
            this.Opcion.Name = "Opcion";
            // 
            // IdClasificacion
            // 
            this.IdClasificacion.DataPropertyName = "IdClasificacion";
            this.IdClasificacion.HeaderText = "IDclasificacion";
            this.IdClasificacion.Name = "IdClasificacion";
            this.IdClasificacion.Visible = false;
            // 
            // Clasificacion
            // 
            this.Clasificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Clasificacion.DataPropertyName = "Clasificacion";
            this.Clasificacion.HeaderText = "Clasificacion";
            this.Clasificacion.Name = "Clasificacion";
            // 
            // IdPermiso
            // 
            this.IdPermiso.DataPropertyName = "IdPermiso";
            this.IdPermiso.HeaderText = "IdPermiso";
            this.IdPermiso.Name = "IdPermiso";
            this.IdPermiso.Visible = false;
            // 
            // PermisosGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 386);
            this.Controls.Add(this.dtgvPermisos);
            this.Controls.Add(this.lblSeleccioneRol);
            this.Controls.Add(this.cbbRoles);
            this.Name = "PermisosGestion";
            this.Text = "PermisosGestion";
            this.Load += new System.EventHandler(this.PermisosGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbRoles;
        private System.Windows.Forms.Label lblSeleccioneRol;
        private System.Windows.Forms.DataGridView dtgvPermisos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Asignado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOpcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdClasificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clasificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPermiso;
    }
}