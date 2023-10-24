using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            int Elem;

            List <int> MiList = new List<int>();

            Console.WriteLine("Ingrese el numero de elementos");
            Elem = int.Parse(Console.ReadLine());

            Console.WriteLine("=================");
            for (int i = 0; i < Elem; i++)
            {
                Console.WriteLine("Ingrese un entero");
                int Mundos = int.Parse(Console.ReadLine());
                MiList.Add(Mundos);
            }
            foreach (int i in MiList)
            {
                Console.WriteLine("=================");
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}