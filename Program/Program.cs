using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Clase enemigo = new Clase();
            enemigo.PosicionX = 5;
            enemigo.PosicionY = 6;
            enemigo.PuntosGanados = 2;
            enemigo.Movimiento = 3;

            Console.WriteLine("Posicion en X: " + enemigo.PosicionX);
            Console.WriteLine("Posicion en Y: " + enemigo.PosicionY);
            Console.WriteLine("Total puntos: " + enemigo.PuntosGanados);
            Console.WriteLine("Movimientos: " + enemigo.Movimiento);
        }
    }
}
