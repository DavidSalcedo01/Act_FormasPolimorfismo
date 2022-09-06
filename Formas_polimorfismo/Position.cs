using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;

namespace Formas_polimorfismo
{

     public class Position
    {
        
        public static void position()
        {
            Console.WriteLine("Ingrese la posicion de la figura en X");
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la posicion de la figura en Y");
            int Y = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(X, Y);

        }


    }
}
