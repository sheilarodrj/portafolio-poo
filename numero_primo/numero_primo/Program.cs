using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_primo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int numero;
                int contador = 0;

                Console.WriteLine("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());

                for (int i = 1; i < (numero + 1); i++)
                {
                    if (numero % i == 0)
                    {
                        contador++;
                    }
                }
                if (contador != 2)
                {
                    Console.WriteLine("El número " + numero + ", no es primo");
                }
                else
                {
                    Console.WriteLine("El número " + numero + ", es primo");
                }

                Console.ReadLine();

                Console.WriteLine("Presione Enter para continuar evaluando números");
                Console.ReadKey();
            } while (true);
        }
    }
}
