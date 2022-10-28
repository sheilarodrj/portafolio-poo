using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int num1;
                int num2;

                Console.WriteLine("Ingrese el primer número: ");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo número: ");
                num2 = int.Parse(Console.ReadLine());

                if (num1 % num2 == 0)
                {
                    Console.WriteLine("El número " + num2 + " es multiplo de " + num1);
                }
                else
                    Console.WriteLine("El número " + num2 + ", no es multiplo de " + num1);

                Console.ReadLine();

                Console.WriteLine("Presione Enter para continuar evaluando números");
                Console.ReadKey();




            } while (true);

        }
    }
}
