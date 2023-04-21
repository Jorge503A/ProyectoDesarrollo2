namespace General.GUI
{
    partial class DireccionesGestion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvDatos = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblRegistro = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Canton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caserio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatos)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvDatos
            // 
            this.dtgvDatos.AllowUserToAddRows = false;
            this.dtgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvDatos.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Column1,
            this.Calle,
            this.Colonia,
            this.Canton,
            this.Caserio,
            this.CodigoPostal,
            this.Pais,
            this.IdMunicipio});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDatos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDatos.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvDatos.Location = new System.Drawing.Point(0, 31);
            this.dtgvDatos.MultiSelect = false;
            this.dtgvDatos.Name = "dtgvDatos";
            this.dtgvDatos.ReadOnly = true;
            this.dtgvDatos.RowHeadersVisible = false;
            this.dtgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDatos.Size = new System.Drawing.Size(1004, 397);
            this.dtgvDatos.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblRegistro});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1004, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblRegistro
            // 
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(130, 17);
            this.lblRegistro.Text = "0 registros Encontrados";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEliminar,
            this.btnEditar,
            this.btnAgregar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1004, 31);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::General.Properties.Resources.borrar;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(78, 28);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::General.Properties.Resources.editar;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(65, 28);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::General.Properties.Resources.AgregarIcon;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(77, 28);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "IdDireccion";
            this.ID.HeaderText = "IDDireccion";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NumeroCasa";
            this.Nombre.HeaderText = "NumeroCasa";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PasajePoligono";
            this.Column1.HeaderText = "PasajePoligono";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Calle
            // 
            this.Calle.DataPropertyName = "Calle";
            this.Calle.HeaderText = "Calle";
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            // 
            // Colonia
            // 
            this.Colonia.DataPropertyName = "Colonia";
            this.Colonia.HeaderText = "Colonia";
            this.Colonia.Name = "Colonia";
            this.Colonia.ReadOnly = true;
            // 
            // Canton
            // 
            this.Canton.DataPropertyName = "Canton";
            this.Canton.HeaderText = "Canton";
            this.Canton.Name = "Canton";
            this.Canton.ReadOnly = true;
            // 
            // Caserio
            // 
            this.Caserio.DataPropertyName = "Caserio";
            this.Caserio.HeaderText = "Caserio";
            this.Caserio.Name = "Caserio";
            this.Caserio.ReadOnly = true;
            // 
            // CodigoPostal
            // 
            this.CodigoPostal.DataPropertyName = "CodigoPostal";
            this.CodigoPostal.HeaderText = "Codigo Postal";
            this.CodigoPostal.Name = "CodigoPostal";
            this.CodigoPostal.ReadOnly = true;
            // 
            // Pais
            // 
            this.Pais.DataPropertyName = "Pais";
            this.Pais.HeaderText = "Pais";
            this.Pais.Name = "Pais";
            this.Pais.ReadOnly = true;
            // 
            // IdMunicipio
            // 
            this.IdMunicipio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdMunicipio.DataPropertyName = "IdMunicipio";
            this.IdMunicipio.HeaderText = "IDMunicipio";
            this.IdMunicipio.Name = "IdMunicipio";
            this.IdMunicipio.ReadOnly = true;
            // 
            // DireccionesGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 450);
            this.Controls.Add(this.dtgvDatos);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DireccionesGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DireccionesGestion";
            this.Load += new System.EventHandler(this.DireccionesGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatos)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDatos;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblRegistro;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Canton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caserio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMunicipio;
    }
}