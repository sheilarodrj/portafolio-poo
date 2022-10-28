using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace año_bisiesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int año;
                Console.WriteLine("Ingrese el año: ");
                año = int.Parse(Console.ReadLine());


                if (año % 4 == 0 && (año % 100 != 0 | año % 400 == 0))
                {
                    Console.WriteLine("El año: " + año + ", si es bisiesto ");
                }
                else
                {
                    Console.WriteLine("El año " + año + ", no es bisiesto ");
                }
                Console.ReadLine();

                Console.WriteLine("Presione Enter para continuar evaluando años");
                Console.ReadKey();
            } while (true);
        }
    }
}
