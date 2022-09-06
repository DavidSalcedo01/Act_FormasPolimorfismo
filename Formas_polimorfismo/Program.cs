using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Formas_polimorfismo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Menu.menu();

        }

        public static int inPutManager()
        {
            int opt = 0;
            try
            {
                opt = int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.Clear();
                Console.WriteLine("Solo escriba numeros");
                Thread.Sleep(1500);
                Menu.menu();
            }
            catch(OverflowException)
            {
                Console.Clear();
                Console.WriteLine("Solo escriba valores del 1 al 4");
                Thread.Sleep(1500);
                Menu.menu();
            }
            return opt;
        }
    }
}
