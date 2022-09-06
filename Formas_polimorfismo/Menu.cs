using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Formas_polimorfismo
{
    internal class Menu
    {
        public static int opt = 0;
        public static void menu()
        {
            
            do
            {
                Console.Clear();
                Console.WriteLine("Que figura desea hacer? \n 1) Cuadrado \n 2) Triangulo \n 3) Circulo \n 4) Salir");

                switch (Program.inPutManager())
                {
                    case 1:
                            Console.Clear();
                            Shapes.Hueco();
                        break;
                    case 2:
                            Console.Clear();
                            Traingulo.triangulo();
                        break;
                    case 3:
                            Console.Clear();
                            Circulo.circulo();
                        break;
                    case 4:
                            Console.Clear();
                            Console.WriteLine("Hasta luego");
                            opt = 4;
                        break;
                    default:
                            Console.Clear();
                            Console.WriteLine("Valor no valido");
                            Thread.Sleep(1500);
                        break;
                }

            } while(opt != 4);

        }


    }
}
