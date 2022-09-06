using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Formas_polimorfismo
{
    internal class Shapes
    {
        public static void Hueco()
        {
            string hueco = "";
            Console.WriteLine("Tendra un hueco en medio  (Si o No)");

            try
            {
               hueco = Console.ReadLine();
            }
            catch (OverflowException)
            {
               Console.WriteLine("Solo escriba Si o No");
            }
            int comp = string.Compare(hueco, "si", true);
            Console.Clear();
            if (comp == 0)
            {
                Square.squareM();
            }
            else
            {
                Square.squareC();
            }

        }
    }

    public class Square : Position
    {
        public static void squareC()
        {
            Console.WriteLine("Ingrese el tamaño de la figura");
            int siz = Program.inPutManager();
            position();
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < siz; i++)
            {
                for (int l = 0; l < siz; l++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n");
            Console.ResetColor();
            Console.Write("Enter para continuar...");
            Console.ReadKey();
        }

        public static void squareM()
        {
            Console.WriteLine("Ingrese el tamaño de la figura");
            int siz = Program.inPutManager();
            position();
            string[,] areglo = new string[siz, siz];

            for (int i = 0; i < siz; i++)
            {
                for (int l = 0; l < siz; l++)
                {
                    areglo[i, l] = " *";
                }
            }

            if (siz % 2 == 0)
            {
                int medio = siz / 2;
                areglo[medio, medio] = "  ";
                areglo[medio - 1, medio - 1] = "  ";
                areglo[medio, medio - 1] = "  ";
                areglo[medio - 1, medio] = "  ";
            }
            else
            {
                int medio = siz / 2;
                areglo[medio, medio] = "  ";
            }

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < siz; i++)
            {
                for (int l = 0; l < siz; l++)
                {
                    Console.Write(areglo[i, l]);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n");
            Console.ResetColor();
            Console.Write("Enter para continuar...");
            Console.ReadKey();

        }
    }

    public class Traingulo : Position
    {
        public static void triangulo()
        {
            Console.WriteLine("Ingrese el tamaño de la figura");
            int siz = Program.inPutManager();
            position();
            int i = 1;
            int spa = siz;
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Green;
            do
            {
                for (int m = spa; m > 0; m--)
                {
                    Console.Write(" ");
                }
                for (int l = 0; l < i; l++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine("");
                i++;
                spa--;

            } while (i < (siz + 1));
            Console.ResetColor();
            Console.Write("Enter para continuar...");
            Console.ReadKey();
        }
    }

    public class Circulo : Position
    {
        public static void circulo()
        {
            Console.WriteLine("Ingrese el tamaño de la figura");
            int siz = Program.inPutManager();
            position();
            int i = 1;
            int spa = siz;
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Green;
            do
            {
                for (int m = spa; m > 0; m--)
                {
                    Console.Write(" ");
                }
                for (int l = 0; l < i; l++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine("");
                i += 2;
                spa -= 2;

            } while (i < siz);

            i = 1;
            spa = siz;
            do
            {
                for (int m = 0; m < i; m++)
                {
                    Console.Write(" ");
                }
                for (int l = spa; l > 0; l--)
                {
                    Console.Write("* ");
                }

                Console.WriteLine("");
                i += 2;
                spa -= 2;

            } while (spa > 0);
            Console.ResetColor();
            Console.Write("Enter para continuar...");
            Console.ReadKey();
        }
    }

}
