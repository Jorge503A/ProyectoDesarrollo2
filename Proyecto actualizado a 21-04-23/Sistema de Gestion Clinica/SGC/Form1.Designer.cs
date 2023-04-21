namespace SGC
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txbIdpais = new System.Windows.Forms.TextBox();
            this.txbPais = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDatos
            // 
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Location = new System.Drawing.Point(26, 26);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.Size = new System.Drawing.Size(343, 147);
            this.dtgDatos.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(401, 87);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txbIdpais
            // 
            this.txbIdpais.Location = new System.Drawing.Point(75, 212);
            this.txbIdpais.Name = "txbIdpais";
            this.txbIdpais.Size = new System.Drawing.Size(188, 20);
            this.txbIdpais.TabIndex = 2;
            // 
            // txbPais
            // 
            this.txbPais.Location = new System.Drawing.Point(75, 254);
            this.txbPais.Name = "txbPais";
            this.txbPais.Size = new System.Drawing.Size(188, 20);
            this.txbPais.TabIndex = 3;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(317, 232);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "Agregar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 324);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txbPais);
            this.Controls.Add(this.txbIdpais);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dtgDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDatos;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txbIdpais;
        private System.Windows.Forms.TextBox txbPais;
        private System.Windows.Forms.Button btnInsertar;
    }
}

