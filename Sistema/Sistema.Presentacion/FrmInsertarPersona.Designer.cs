
namespace Sistema.Presentacion
{
    partial class FrmInsertarPersona
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
            this.components = new System.ComponentModel.Container();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.LblEdad = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblRol = new System.Windows.Forms.Label();
            this.CmbRol = new System.Windows.Forms.ComboBox();
            this.DgvPersona = new System.Windows.Forms.DataGridView();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(75, 49);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(44, 13);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(75, 89);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(44, 13);
            this.LblApellido.TabIndex = 1;
            this.LblApellido.Text = "Apellido";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(130, 46);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(213, 20);
            this.TxtNombre.TabIndex = 2;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(130, 86);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(213, 20);
            this.TxtApellido.TabIndex = 3;
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(495, 86);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(213, 20);
            this.TxtEdad.TabIndex = 7;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(495, 46);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(213, 20);
            this.TxtTelefono.TabIndex = 6;
            // 
            // LblEdad
            // 
            this.LblEdad.AutoSize = true;
            this.LblEdad.Location = new System.Drawing.Point(440, 89);
            this.LblEdad.Name = "LblEdad";
            this.LblEdad.Size = new System.Drawing.Size(32, 13);
            this.LblEdad.TabIndex = 5;
            this.LblEdad.Text = "Edad";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Location = new System.Drawing.Point(440, 49);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(49, 13);
            this.LblTelefono.TabIndex = 4;
            this.LblTelefono.Text = "Teléfono";
            // 
            // LblRol
            // 
            this.LblRol.AutoSize = true;
            this.LblRol.Location = new System.Drawing.Point(75, 127);
            this.LblRol.Name = "LblRol";
            this.LblRol.Size = new System.Drawing.Size(23, 13);
            this.LblRol.TabIndex = 8;
            this.LblRol.Text = "Rol";
            // 
            // CmbRol
            // 
            this.CmbRol.FormattingEnabled = true;
            this.CmbRol.Location = new System.Drawing.Point(130, 127);
            this.CmbRol.Name = "CmbRol";
            this.CmbRol.Size = new System.Drawing.Size(213, 21);
            this.CmbRol.TabIndex = 9;
            // 
            // DgvPersona
            // 
            this.DgvPersona.AllowUserToAddRows = false;
            this.DgvPersona.AllowUserToDeleteRows = false;
            this.DgvPersona.AllowUserToOrderColumns = true;
            this.DgvPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPersona.Location = new System.Drawing.Point(12, 196);
            this.DgvPersona.Name = "DgvPersona";
            this.DgvPersona.ReadOnly = true;
            this.DgvPersona.Size = new System.Drawing.Size(776, 208);
            this.DgvPersona.TabIndex = 10;
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(584, 127);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(124, 47);
            this.BtnInsertar.TabIndex = 11;
            this.BtnInsertar.Text = "INSERTAR";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // FrmInsertarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.DgvPersona);
            this.Controls.Add(this.CmbRol);
            this.Controls.Add(this.LblRol);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.LblEdad);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblNombre);
            this.Name = "FrmInsertarPersona";
            this.Text = "Tarea 1 - Programación N-Capas";
            this.Load += new System.EventHandler(this.FrmInsertarPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label LblEdad;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblRol;
        private System.Windows.Forms.ComboBox CmbRol;
        private System.Windows.Forms.DataGridView DgvPersona;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
    }
}