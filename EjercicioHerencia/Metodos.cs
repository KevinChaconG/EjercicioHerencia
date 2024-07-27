using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class Metodos : Operaciones
    {

        public void ImprimirCubo()
        {
            int largo = 20;
            int altura = 20;
            int ancho = 20;

            Console.WriteLine($"Perimetro: " + operacionPerimetro(largo, ancho));
            Console.WriteLine($"Area: " + operacionArea(largo, ancho));
            Console.WriteLine($"Volumen: " + operacionVolumen(largo, ancho, altura));
        }

        public void ImprimirCaja()
        {
            int largo = 30;
            int altura = 20;
            int ancho = 40;

            Console.WriteLine($"Perimetro: " + operacionPerimetro(largo, ancho));
            Console.WriteLine($"Area: " + operacionArea(largo, ancho));
            Console.WriteLine($"Volumen: " + operacionVolumen(largo, ancho, altura));
        }

    }
}
