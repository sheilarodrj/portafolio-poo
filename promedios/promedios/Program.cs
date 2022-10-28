using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promedios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorcal = 0;
            double calificacion = 0;
            double sumatotal = 0;
            double resultadopromedio = 0;
            string texto = "";

            do
            {

                Console.WriteLine("Por favor, ingrese una calificación para calcular el promedio: ");
                texto = Console.ReadLine();
                bool ingreso = double.TryParse(texto, out calificacion);


                if (ingreso == true)

                {
                    sumatotal = sumatotal + calificacion;
                    contadorcal++;
                }

                if (ingreso == false)
                {
                    Console.WriteLine("Ese no es un valor válido, por favor intente de nuevo: ");
                }
            } while (texto != "fin");
              resultadopromedio = sumatotal/ contadorcal;
            Console.WriteLine("El promedio es " + resultadopromedio);
            Console.ReadKey();
    }
    } }
