using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingresa un número entero: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El cuadrado de " + num1 + " es " + Math.Pow(num1, 2));
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}

