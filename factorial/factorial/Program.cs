using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int numero;
                int factorial = 1;


                Console.WriteLine("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    Console.WriteLine("El factorial de 0 es 1");
                }
                else
                    for (int i = 1; i <= numero; i++)
                    {
                        factorial = factorial * i;
                    }
                Console.WriteLine("El factorial de " + numero + " es: " + factorial);
                Console.ReadLine();

                Console.WriteLine("Presione Enter para continuar calculando factoriales");
                Console.ReadKey();
            } while (true);
        }
    }
}
