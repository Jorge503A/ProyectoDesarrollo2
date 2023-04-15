using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionManager
{
    public class Session
    {
        protected static Session _Instancia = null;
        static readonly Object _codelock = new Object();
        
        String _Usuario;
        String _Rol;
        String _IdRol;
        String _IdUsuario;

        private Session()
        {
        }

        public static Session Instancia
        {
            get
            {
                if(_Instancia == null)
                {
                    lock(_codelock)
                    {
                        if(_Instancia == null)
                        {
                            _Instancia = new Session();
                        }
                    }
                }
                return _Instancia;
            }
        }


        public string Usuario { get => _Usuario; }
        public string Rol { get => _Rol; }
        public string IdRol { get => _IdRol; }
        public string IdUsuario { get => _IdUsuario; }

        public Boolean IniciarSesion(String pUsuario, String pClave)
        {
            Boolean result = false;
            DataTable Resultado = new DataTable();
            try
            {
                Resultado = DataManager.DBConsultas.VALIDAR_USUARIO(pUsuario, pClave);
                //MessageBox.Show(Resultado.Rows.Count.ToString());
                if (Resultado.Rows.Count == 1)
                {
                    _IdUsuario = Resultado.Rows[0]["IdUsuario"].ToString();
                    _Usuario = Resultado.Rows[0]["usuario"].ToString();
                    _IdRol = Resultado.Rows[0]["IdRol"].ToString();
                    _Rol = Resultado.Rows[0]["rol"].ToString();
                    result = true;
                }
                else
                {
                    result = false;

                }
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }
    }
}
