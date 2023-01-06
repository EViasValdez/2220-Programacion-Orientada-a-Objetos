using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            int Elem;

            List <int> miList = new List<int>();

            Console.WriteLine("Ingrese el numero de elementos");
            Elem = int.Parse(Console.ReadLine());

            Console.WriteLine("=================");
            for (int i = 0; i < Elem; i++)
            {
                Console.WriteLine("Ingrese un entero");
                int mundos = int.Parse(Console.ReadLine());
                miList.Add (mundos);
            }
            foreach (int i in miList)
            {
                Console.WriteLine("=================");
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}