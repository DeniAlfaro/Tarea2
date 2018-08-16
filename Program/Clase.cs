using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Clase
    {
        public int PosicionX { get; set; }
        public int PosicionY { get; set; }
        public int Movimiento { get; set; }
        private int Disparar { get; set; }
        private int Explotar { get; set; }

        private int _puntosGanados;
        public int PuntosGanados
        {
            get
            {
                return _puntosGanados;
            }
            set
            {
                if (value < 100)
                {
                    Console.WriteLine("Inserte un valor mayor a 100");
                }
                else if (value >= 100) {
                    Console.WriteLine("Puntos Ganados: " + PuntosGanados);
                }
            }
        }
    }
}
