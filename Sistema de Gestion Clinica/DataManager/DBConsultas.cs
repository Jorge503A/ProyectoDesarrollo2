using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public static class DBConsultas
    {
        public static DataTable VALIDAR_USUARIO(String pUsuario, String pClave)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("select a.IdUsuario, a.usuario, a.IdRol, c.rol, c.IdRol ");
            Sentencia.Append("from usuarios a, rol c, empleados b ");
            Sentencia.Append("where a.IdRol = c.IdRol ");
            Sentencia.Append("and b.IdEmpleado = a.IdEmpleado ");
            Sentencia.Append("and usuario = '" + pUsuario + @"' ");
            Sentencia.Append("and clave = sha1(md5(" + pClave + @"));");
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia.ToString());
            }
            catch (Exception)
            {

            }

            return Resultado;
        }


        public static DataTable ROLES()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"select IdRol, Rol FROM rol;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }

            return Resultado;

        }

        public static DataTable EMPLEADOS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"select IdEmpleado,IdEmpleado, NombreEmpleado, ApellidoEmpleado, TelefonoEmpleado, Genero, IdDireccion FROM empleados;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }

            return Resultado;

        }

        public static DataTable DIRECCIONES()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"select a.idDireccion, a.NumeroCasa,a.PasajePoligono, a.Pais, b.municipio,c.departamento from direcciones a, municipios b, departamentos c where a.IdMunicipio = b.IdMunicipios and b.IdDepartamento=c.IdDepartamento;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }

            return Resultado;

        }

    }
}
