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
            Console.WriteLine("Nombre del jugador: ");
            string jugador = Console.ReadLine();
            int puntajenuevo = 100;
            int puntajerecord = 80;
            string jugadorecord = "maría";


            if (puntajenuevo > puntajerecord)
            {
                Console.Write("La nueva puntuación más alta es " + puntajenuevo + ", " + "la nueva puntuación más alta fue lograda por " + jugador + " ");
            }
            if (puntajenuevo < puntajerecord)
            {
                Console.Write("La puntuación más alta es " + puntajerecord + " " + "no se ha podido superar, y aún está en manos de " + jugadorecord + " ");
            }
            Console.Read();
        }
    }
}
