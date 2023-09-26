using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Servicios
{
    /// <summary>
    /// interfaz que contiene todas las acciones que se pueden hacer desde el munu 
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Muestra el mensaje de bienvenida
        /// 250923 - sav
        /// </summary>
        public void mensajeBienvenida();

        /// <summary>
        /// METOTDO QUE MUESTRA EL MUENU Y TAL
        /// </summary>
        /// 260923 - sav
        /// <returns>UN ENTERO CON LA OPCION SELECIONADA</returns>
        public int mostrarMenuYSeleccion();
    }
}
