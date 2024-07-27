using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class Operaciones
    {


        public int operacionPerimetro(int largo, int ancho)
        {
            return largo + ancho;
        }

        public int operacionArea(int largo, int ancho)
        {
            return largo * ancho;
        }

        public int operacionVolumen(int largo, int ancho, int altura)
        {
            return largo * ancho * altura;
        }


    }
}
