
namespace EjercicioHerencia
{
    class Program
    {

        static void Main(string[] args)
        {

            Metodos Cubo = new Metodos();
            Console.WriteLine("Cubo");
            Cubo.ImprimirCubo();

            Console.WriteLine();

            Metodos Caja = new Metodos();
            Console.WriteLine("Caja");
            Caja.ImprimirCaja();

            Console.ReadLine();


        }
    }
}