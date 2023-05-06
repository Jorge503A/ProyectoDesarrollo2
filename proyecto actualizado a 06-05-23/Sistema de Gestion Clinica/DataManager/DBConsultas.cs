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


        public static DataTable PERMISOS(String pIdRol)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"select a.IdOpcion, a.Opcion,
             a.IdClasificacion, b.Clasificacion,
             IFNULL((select IdPermiso from permisos z
             where z.IdRol = "+pIdRol+ @" and z.IdOpcion = a.IdOpcion),0)IdPermiso,
            IF(IFNULL((Select IdPermiso from permisos z
             where z.IdRol = "+pIdRol+ @" and z.IdOpcion = a.IdOpcion),0)>0,1,0)Asignado
             from opciones a, clasificaciones b
            where a.IdClasificacion = b.IdClasificacion;";
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
            String Sentencia = @"select a.idDireccion, a.NumeroCasa,a.PasajePoligono, a.Calle, a.Colonia,a.Canton, a.Caserio, a.CodigoPostal, a.Pais, a.IdMunicipio from direcciones a;";
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

        public static DataTable MUNICIPIOS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"select a.IdMunicipios, a.Municipio, b.departamento from municipios a, departamentos b where a.IdDepartamento = b.IdDepartamento;";
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

        public static DataTable MUNICIPIOS1(String _NombreMunicipio)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"select a.IdMunicipios, a.Municipio, b.departamento from municipios a, departamentos b where a.IdDepartamento = b.IdDepartamento and a.Municipio ='"+_NombreMunicipio+"';";
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

        public static DataTable DIRECCIONESBUSQUEDA()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"select a.IdDireccion,a.NumeroCasa,a.PasajePoligono,a.Pais,b.municipio,c.Departamento from direcciones a, municipios b, departamentos c where a.IdMunicipio = b.IdMunicipios and b.IdDepartamento = c.IdDepartamento;";
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
