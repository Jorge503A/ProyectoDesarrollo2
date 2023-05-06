using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    internal class Direcciones
    {
        String _IdDireccion;
        String _NumeroCasa;
        String _PasajePoligono;
        String _Calle;
        String _Colonia;
        String _Canton;
        String _Caserio;
        String _CodigoPostal;
        String _Pais;
        String _IdMunicipio;
        public string Iddireccion { get => _IdDireccion; set => _IdDireccion = value; }
        public string NumeroCasa { get => _NumeroCasa; set => _NumeroCasa = value; }
        public string PasajePoligono { get => _PasajePoligono; set => _PasajePoligono = value; }
        public string Calle { get => _Calle; set => _Calle = value; }
        public string Colonia { get => _Colonia; set => _Colonia = value; }
        public string Canton { get => _Canton; set => _Canton = value; }
        public string Caserio { get => _Caserio; set => _Caserio = value; }
        public string CodigoPostal { get => _CodigoPostal; set => _CodigoPostal = value; }
        public string Pais { get => _Pais; set => _Pais = value; }
        public string IdMunicipio { get => _IdMunicipio; set => _IdMunicipio = value; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;

            try
            {

                Sentencia = @"Insert into direcciones(NumeroCasa,PasajePoligono,Calle,Colonia,Canton,Caserio,CodigoPostal,Pais,IdMunicipio) values('" + _NumeroCasa + "','" + _PasajePoligono + "','" + _Calle + "','" + _Colonia + "','"+_Canton+"','"+_Caserio+"','"+_CodigoPostal+"','"+_Pais+"',"+_IdMunicipio+");";
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

                Sentencia = @"delete from direcciones where IdDireccion = '" + _IdDireccion + "';";
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

                Sentencia = @"update direcciones set NumeroCasa = '"+_NumeroCasa+"', PasajePoligono = '"+_PasajePoligono+"', Calle = '"+_Calle+"', Colonia = '"+_Colonia+"', Canton = '"+_Canton+"', Caserio = '"+_Caserio+"', CodigoPostal = '"+_CodigoPostal+"', Pais = '"+_Pais+"', IdMunicipio = "+_IdMunicipio+" where IdDireccion = "+_IdDireccion+";";
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
