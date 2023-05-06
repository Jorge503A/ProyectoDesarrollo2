namespace General.GUI
{
    partial class RolesEdicion
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
            this.lblIdRol = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtIdRol = new System.Windows.Forms.TextBox();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.pictureBoxCancelar = new System.Windows.Forms.PictureBox();
            this.pictureBoxGuardar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdRol
            // 
            this.lblIdRol.AutoSize = true;
            this.lblIdRol.Location = new System.Drawing.Point(58, 27);
            this.lblIdRol.Name = "lblIdRol";
            this.lblIdRol.Size = new System.Drawing.Size(37, 13);
            this.lblIdRol.TabIndex = 0;
            this.lblIdRol.Text = "ID Rol";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(58, 91);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(23, 13);
            this.lblRol.TabIndex = 1;
            this.lblRol.Text = "Rol";
            // 
            // txtIdRol
            // 
            this.txtIdRol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdRol.Location = new System.Drawing.Point(61, 43);
            this.txtIdRol.Name = "txtIdRol";
            this.txtIdRol.Size = new System.Drawing.Size(100, 20);
            this.txtIdRol.TabIndex = 4;
            // 
            // txtRol
            // 
            this.txtRol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRol.Location = new System.Drawing.Point(61, 107);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(315, 20);
            this.txtRol.TabIndex = 5;
            // 
            // pictureBoxCancelar
            // 
            this.pictureBoxCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCancelar.Image = global::General.Properties.Resources.cancelar;
            this.pictureBoxCancelar.Location = new System.Drawing.Point(384, 153);
            this.pictureBoxCancelar.Name = "pictureBoxCancelar";
            this.pictureBoxCancelar.Size = new System.Drawing.Size(50, 39);
            this.pictureBoxCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCancelar.TabIndex = 7;
            this.pictureBoxCancelar.TabStop = false;
            this.pictureBoxCancelar.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBoxGuardar
            // 
            this.pictureBoxGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxGuardar.Image = global::General.Properties.Resources.GuardarIcon;
            this.pictureBoxGuardar.Location = new System.Drawing.Point(311, 153);
            this.pictureBoxGuardar.Name = "pictureBoxGuardar";
            this.pictureBoxGuardar.Size = new System.Drawing.Size(50, 39);
            this.pictureBoxGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGuardar.TabIndex = 6;
            this.pictureBoxGuardar.TabStop = false;
            this.pictureBoxGuardar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RolesEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 204);
            this.Controls.Add(this.pictureBoxCancelar);
            this.Controls.Add(this.pictureBoxGuardar);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.txtIdRol);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblIdRol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RolesEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edicion de Roles";
            this.Load += new System.EventHandler(this.RolesEdicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdRol;
        private System.Windows.Forms.Label lblRol;
        public System.Windows.Forms.TextBox txtIdRol;
        public System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.PictureBox pictureBoxGuardar;
        private System.Windows.Forms.PictureBox pictureBoxCancelar;
    }
}