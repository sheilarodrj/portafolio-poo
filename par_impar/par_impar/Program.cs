using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace par_impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int num;

                {
                    Console.WriteLine("Ingrese un número: ");
                    num = int.Parse(Console.ReadLine());



                    if (num % 2 == 0)
                        Console.WriteLine("El número: " + num + ", es par");
                    else
                        Console.WriteLine("El número " + num + ", es impar");

                    Console.ReadLine();
                }
                Console.WriteLine("Presione Enter para continuar evaluando números");
                Console.ReadKey();
            } while (true);
        }
    }
    }

