using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hola mundo");
            Auto Vehiculo = new Auto();
            // Console.WriteLine("El modelo es: " + Vehiculo.Modelo);
            // Console.WriteLine("La marca es: " + Vehiculo.Marca);
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