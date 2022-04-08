using System;

namespace Proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Auto vehiculo = new Auto();
            // Console.WriteLine("El modelo es " + vehiculo.modelo);
            // Console.WriteLine("La marca es " + vehiculo.marca);
            string mode;
            string marc;
            
            Console.WriteLine("Ingrese modelo");
            mode = Console.ReadLine();
            Console.WriteLine("Ingrese marca");
            marc = Console.ReadLine();
            
            Auto nave = new Auto (mode, marc);
            Console.WriteLine(nave.marca + " " + nave.modelo);
        }
    }
}