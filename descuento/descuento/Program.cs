using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace descuento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escritorioscant;
            double precio;
            double compra;
            double descuento = 0;
            double total;


            Console.WriteLine("Número de escritorios: ");
            escritorioscant = int.Parse(Console.ReadLine());

            precio = 6500;
            compra = escritorioscant * precio;

            if (escritorioscant < 5)
            {
                descuento = compra * 0.1;
            }
            else
                if (escritorioscant < 10)
            {
                descuento = compra * 0.2;
            }
            else
                if (escritorioscant >= 10)
            {
                descuento = compra * 0.4;
            }
            total = compra - descuento;
            Console.WriteLine("El valor a pagar es: " + total);
        }
    }
}
