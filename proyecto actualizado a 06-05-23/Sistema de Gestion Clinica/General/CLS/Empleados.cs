using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    internal class Empleados
    {
        String _IdEmpleado;
        String _NombreEmpleado;
        String _ApellidoEmpleado;
        String _TelefonoEmpleado;
        String _Genero;
        String _IdDireccion;
        public string IdEmpleado { get => _IdEmpleado; set => _IdEmpleado = value; }
        public string NombreEmpleado { get => _NombreEmpleado; set => _NombreEmpleado = value; }
        public string ApellidoEmpleado { get => _ApellidoEmpleado; set => _ApellidoEmpleado = value; }
        public string TelefonoEmpleado { get => _TelefonoEmpleado; set => _TelefonoEmpleado = value; }
        public string Genero { get => _Genero; set => _Genero = value; }
        public string IdDireccion { get => _IdDireccion; set => _IdDireccion = value; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;

            try
            {

                Sentencia = @"Insert into empleados(NombreEmpleado,ApellidoEmpleado,TelefonoEmpleado,Genero,IdDireccion) values('"+_NombreEmpleado+"','"+_ApellidoEmpleado+"','"+_TelefonoEmpleado+"','"+_Genero+"',"+_IdDireccion+");";
                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasInsertadas = Operacion.EjecutarSentencia(Sentencia);

                if (FilasInsertadas > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }


            return Resultado;
        }

        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;

            try
            {

                Sentencia = @"delete from empleados where IdEmpleado = '" + _IdEmpleado + "';";
                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasInsertadas = Operacion.EjecutarSentencia(Sentencia);

                if (FilasInsertadas > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }

        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;

            try
            {

                Sentencia = @"update empleados set NombreEmpleado = '" + _NombreEmpleado + "', ApellidoEmpleado = '"+_ApellidoEmpleado+"', TelefonoEmpleado = '"+_TelefonoEmpleado+"', Genero = '"+_Genero+"',IdDireccion = "+_IdDireccion+" where IdEmpleado = " + _IdEmpleado + ";";
                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasInsertadas = Operacion.EjecutarSentencia(Sentencia);

                if (FilasInsertadas > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }


            return Resultado;
        }
    }

}
