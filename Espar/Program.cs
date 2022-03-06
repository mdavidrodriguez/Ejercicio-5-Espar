using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saber si un numero es par o impar");
            Console.WriteLine("Digite un numero: ");
            int numero =int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Es Par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }
            Console.ReadLine();
        }
    }
}
