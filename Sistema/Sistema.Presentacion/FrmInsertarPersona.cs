using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Sistema.Negocio;

namespace Sistema.Presentacion
{
    public partial class FrmInsertarPersona : Form
    {
        public FrmInsertarPersona()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Función que se ejecuta al cargar el form.
        /// Lista a las personas en el gridview y pobla las opciones del combobox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmInsertarPersona_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.PoblarRoles();
        }

        /// <summary>
        /// Coloca la lista de personas en la fuente de datos del gridview y le da un formato personalizado.
        /// </summary>
        private void Listar()
        {
            try
            {
                DgvPersona.DataSource = NPersona.Listar();
                this.Formato();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        /// <summary>
        /// Coloca la lista de roles en la fuente de datos del combobox y configura sus miembros.
        /// </summary>
        private void PoblarRoles()
        {
            CmbRol.DataSource = null;
            CmbRol.ValueMember = "id";
            CmbRol.DisplayMember = "nombre";
            CmbRol.DataSource = NRol.Listar();
        }

        /// <summary>
        /// Configura el formato del gridview.
        /// </summary>
        private void Formato()
        {
            DgvPersona.Columns[0].Visible = false;
            DgvPersona.Columns[1].Width = 150;
            DgvPersona.Columns[2].Width = 150;
            DgvPersona.Columns[3].Width = 50;
            DgvPersona.Columns[4].Width = 150;
            DgvPersona.Columns[5].Width = 150;
        }

        /// <summary>
        /// Escucha el evento del botón INGRESAR.
        /// Inserta una nueva línea en la tabla persona de la base de datos usando los parámetros ingresados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtNombre.Text == string.Empty || TxtApellido.Text == string.Empty || TxtEdad.Text == string.Empty || TxtTelefono.Text == string.Empty)
                {
                    ErrorIcono.Clear();
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    List<TextBox> parametros = new List<TextBox> { TxtNombre, TxtApellido, TxtEdad, TxtTelefono };
                    foreach(TextBox parametro in parametros)
                    {
                        if (parametro.Text == string.Empty)
                            ErrorIcono.SetError(parametro, "Llenar parametro.");
                    }
                }
                else
                {
                    Rpta = NPersona.Insertar(TxtNombre.Text.Trim(), TxtApellido.Text.Trim(), Convert.ToInt32(TxtEdad.Text), TxtTelefono.Text.Trim(), (int)CmbRol.SelectedValue);
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se insertó de forma correcta el registro.");
                        this.Limpiar();
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        /// <summary>
        /// Borra el texto ingresado en los textview de la pantalla y esconde los íconos de error.
        /// </summary>
        private void Limpiar()
        {
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtTelefono.Clear();
            TxtEdad.Clear();
            ErrorIcono.Clear();
        }

        /// <summary>
        /// Muestran un mensaje luego del ingreso incorrecto o correcto del nuevo objeto persona.
        /// </summary>
        /// <param name="Mensaje"></param>
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Insertar personas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Insertar personas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
