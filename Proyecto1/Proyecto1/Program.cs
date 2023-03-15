using System;

namespace Proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Auto vehiculo = new Auto();
            // Console.WriteLine("El modelo es: " + vehiculo.modelo);
            // Console.WriteLine("La marca es: " + vehiculo.marca);
            string Mode;
            string Marc;

            Console.WriteLine("Ingrese modelo");
            Mode = Console.ReadLine();
            Console.WriteLine("Ingrese marca");
            Marc = Console.ReadLine();

            Auto Nave = new Auto(Mode, Marc);
            Console.WriteLine(Nave.Marca + " " + Nave.Modelo);
        }
    }
}