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
            Auto vehiculo = new Auto();
            // Console.WriteLine("El modelo es: " + vehiculo.Modelo);
            // Console.WriteLine("La marca es: " + vehiculo.Marca);
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