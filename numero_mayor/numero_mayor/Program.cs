using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_mayor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int num1;
                int num2;
                int num3;

                Console.WriteLine("Ingrese el primer número: ");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo número: ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el tercer número: ");
                num3 = int.Parse(Console.ReadLine());


                if (num1 < num2)
                {
                    if (num2 < num3)
                    {
                        Console.WriteLine("El número mayor es: " + num3);
                    }
                    else
                        Console.WriteLine("El número mayor es: " + num2);
                }
                else if (num1 > num2)
                {
                    if (num1 < num3)
                    {
                        Console.WriteLine("El número mayor es: " + num3);
                    }
                    else
                        Console.WriteLine("El número mayor es: " + num1);
                }
                Console.ReadLine();

                Console.WriteLine("Presione Enter para continuar evaluando números");
                Console.ReadKey();
            } while (true);
        }
    }
}
