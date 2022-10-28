using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_if
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string jugadornuevo; 
            int puntajenuevo;

            Console.WriteLine("Nombre del jugador: ");
            jugadornuevo = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo puntaje: ");
            puntajenuevo = int.Parse(Console.ReadLine());

            Diferencia(jugadornuevo, puntajenuevo);
            Console.ReadLine();
        }

        static void Diferencia(string jugadornuevo, int puntajenuevo)
        {
            string jugador = "Mary";
            int puntaje = 98;

            if (puntajenuevo > puntaje)
            {
                Console.WriteLine("La nueva puntuación más alta es " + puntajenuevo);
                Console.WriteLine("La puntuación más alta fue lograda por " + jugadornuevo);
            }
            else
                Console.WriteLine("La puntuación más alta de " + puntaje + " no se ha podido superar " +
                    "y aún está en manos de " + jugador);



            


            
        }
    }
}
