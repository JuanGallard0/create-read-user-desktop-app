using System;
using System.Data.SqlClient;

namespace Sistema.Datos
{
    class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion Con = null;

        private Conexion()
        {
            this.Base = "tarea1";
            this.Servidor = "192.168.0.18";
            this.Usuario = "sa";
            this.Clave = "uca99";
            this.Seguridad = false;
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Base + "; ";
                if (this.Seguridad)
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else 
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "User Id=" + this.Usuario + "; Password=" + this.Clave;
                }
            }
            catch(Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
