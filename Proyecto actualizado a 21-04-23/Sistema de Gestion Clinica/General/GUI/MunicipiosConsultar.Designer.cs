namespace General.GUI
{
    partial class MunicipiosConsultar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtgvDatos = new System.Windows.Forms.DataGridView();
            this.IdMunicipios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(105, 12);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(186, 20);
            this.txtBusqueda.TabIndex = 0;
            this.txtBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::General.Properties.Resources.buscar1;
            this.pictureBox1.Location = new System.Drawing.Point(297, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dtgvDatos
            // 
            this.dtgvDatos.AllowUserToAddRows = false;
            this.dtgvDatos.AllowUserToDeleteRows = false;
            this.dtgvDatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDatos.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMunicipios,
            this.municipio,
            this.departamento});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvDatos.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvDatos.Location = new System.Drawing.Point(0, 38);
            this.dtgvDatos.MultiSelect = false;
            this.dtgvDatos.Name = "dtgvDatos";
            this.dtgvDatos.ReadOnly = true;
            this.dtgvDatos.RowHeadersVisible = false;
            this.dtgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDatos.Size = new System.Drawing.Size(454, 412);
            this.dtgvDatos.TabIndex = 8;
            this.dtgvDatos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvDatos_CellMouseDoubleClick);
            // 
            // IdMunicipios
            // 
            this.IdMunicipios.DataPropertyName = "IdMunicipios";
            this.IdMunicipios.HeaderText = "IDMunicipio";
            this.IdMunicipios.Name = "IdMunicipios";
            this.IdMunicipios.ReadOnly = true;
            this.IdMunicipios.Width = 134;
            // 
            // municipio
            // 
            this.municipio.DataPropertyName = "municipio";
            this.municipio.HeaderText = "Municipio";
            this.municipio.Name = "municipio";
            this.municipio.ReadOnly = true;
            this.municipio.Width = 133;
            // 
            // departamento
            // 
            this.departamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departamento.DataPropertyName = "departamento";
            this.departamento.HeaderText = "Departamento";
            this.departamento.Name = "departamento";
            this.departamento.ReadOnly = true;
            // 
            // MunicipiosConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 450);
            this.Controls.Add(this.dtgvDatos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBusqueda);
            this.Name = "MunicipiosConsultar";
            this.Text = "MunicipiosConsultar";
            this.Load += new System.EventHandler(this.MunicipiosConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMunicipios;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamento;
    }
}