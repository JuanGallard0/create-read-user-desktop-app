using System.Data;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class NPersona
    {
        public static DataTable Listar()
        {
            DPersona Datos = new DPersona();
            return Datos.Listar();
        }

        public static string Insertar(string Nombre, string Apellido, int Edad, string Telefono, int IdRol)
        {
            DPersona Datos = new DPersona();
            Persona Obj = new Persona();
            Obj.Nombre = Nombre;
            Obj.Apellido = Apellido;
            Obj.Edad = Edad;
            Obj.Telefono = Telefono;
            Obj.IdRol = IdRol;
            return Datos.Insertar(Obj);
        }
    }
}
