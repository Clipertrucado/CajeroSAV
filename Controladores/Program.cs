using ConsoleApp1.Servicios;
using ConsoleApp1.Servicios;

namespace ConsoleApp1
{
	/// <summary>
	/// clase que controla el flujo de procedimientos de la aplicación
	/// </summary>
	class Program
	{
		/// <summary>
		/// metodo de entrada al a aplicación
		/// contiene el procedimiento de nuestra aplicacion
		/// 250923 - sav
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args) 
		{
			//llamamos al metodo que imprime el mensaje por consola
			MenuInterfaz menuInterface = new MenuImplementacion();

			menuInterface.mensajeBienvenida();

			//variable que controla la entrada y salida del bucle
			bool cerrarMenu = false;
			int opcionSeleccionada;
			//desde la primera interaccion se debe cumplir la condicion 
			while (!cerrarMenu) 
			{
				opcionSeleccionada = menuInterface.mostrarMenuYSeleccion();

				Console.WriteLine(opcionSeleccionada);

				switch (opcionSeleccionada) 
				{ 
					case 0:
                        Console.WriteLine("[INFO] - se ejecuta caso uno 0");
						cerrarMenu = true;
                        break;
					
					case 1:
                        Console.WriteLine("[INFO] - se ejecuta caso 1");
                        break;

                    case 2:
                        Console.WriteLine("[INFO] - se ejecuta caso 2");
                        break;

                    case 3:
                        Console.WriteLine("[INFO] - se ejecuta caso 3");
                        break;

                    case 4:
                        Console.WriteLine("[INFO] - se ejecuta caso 4");
                        break;

                    case 5:
                        Console.WriteLine("[INFO] - se ejecuta caso 5");
                        break;

					default:
						Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna");
						break;
                }
			
			}
         }
	}
}
