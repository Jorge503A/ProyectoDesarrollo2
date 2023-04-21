using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SGC.CLS
{
    class AppManager:ApplicationContext
    {
        private Boolean Splash()
        {
            Boolean Resultado = true;
            GUI.Splash f = new GUI.Splash();
            f.ShowDialog();
            return Resultado;
        }
        private Boolean Prueba()
        {
            Boolean Resultado = true;
            Form1 f = new Form1();
            f.ShowDialog();
            return Resultado;
        }

        private Boolean Login()
        {
            Boolean Resultado = true;
            GUI.Login f = new GUI.Login();
            f.ShowDialog();
            Resultado = f.Autorizado;
           
            return Resultado;
        }
        public AppManager()
        {
            if (Splash())
            {
                if (Login())
                {
                    GUI.Main f = new GUI.Main();
                    f.ShowDialog();
                }
            }

        }
    }
}
