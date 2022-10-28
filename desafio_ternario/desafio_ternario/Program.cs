using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_ternario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valortemp = 0;
            string temperatura = " ";
            string aviso = " ";


            Console.WriteLine("Ingresa la temperatura del lugar");
            temperatura = Console.ReadLine();
            bool ingresado = int.TryParse(temperatura, out valortemp);

            if (ingresado == true)
            {
                aviso = valortemp <= 15 ? "Hace mucho frío" : " ";
                Console.WriteLine(aviso);

                aviso = valortemp >= 16 && valortemp <= 28 ? "Hace un clima agradable" : " ";
                Console.WriteLine(aviso);

                aviso = valortemp > 28 ? "Hace mucho calor" : " ";
                Console.WriteLine(aviso);

            }
           
                
            



        }

    }
}

