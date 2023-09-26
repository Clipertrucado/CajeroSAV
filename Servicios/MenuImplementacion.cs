using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Servicios
{
    /// <summary>
    /// implementacion del las acciones del menu 
    /// 250923 - sav
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mensajeBienvenida()
        {
            string mensaje = "Banco CSI1";

            Console.WriteLine(mensaje);

            
        }

        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;

            Console.WriteLine("#################################");
            Console.WriteLine("0. Cerrar aplicación");
            Console.WriteLine("1. Darse de alta");
            Console.WriteLine("2. Ingresar dinero");
            Console.WriteLine("3. Sacar dinero");
            Console.WriteLine("4. Trasferir dinero");
            Console.WriteLine("5. Historial de operaciones");
            Console.WriteLine("#################################");
            Console.WriteLine("Seleccione una opción: ");

            opcionIntroducida = Console.ReadKey(true).KeyChar-('0');

            return opcionIntroducida;
            



        }
    }
}
  