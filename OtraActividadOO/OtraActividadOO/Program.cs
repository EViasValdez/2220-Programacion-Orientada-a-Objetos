using System;

namespace OtraActividadOO
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;

            Console.WriteLine("—— En cada archivo creado hay dos tipos de colores definidos ——");
            Console.WriteLine("—— Los colores que se consideran normales y los que surgen de combinaciones de otros colores ——");
            Console.WriteLine("                                       ");
            Console.ReadKey();

            Console.WriteLine("Elige una opción");
            Console.WriteLine("1. Colores primarios");
            Console.WriteLine("2. Colores secundarios");
            Console.WriteLine("                                       ");

            opcion = (Console.ReadLine());

            Color1 C1 = new Color1();
            Color2 C2 = new Color2();

            if (opcion == "1")
            {
                Console.WriteLine("▌ Los colores primarios que se tienen son ▐");
                Console.WriteLine("Rojo: " + C1.Rojo);
                Console.WriteLine("Amarillo: " + C1.Amarillo);
                Console.WriteLine("Azul: " + C1.Azul);
                Console.WriteLine("Verde: " + C1.Verde);
            }
            else
            if (opcion == "2")
            {
                Console.WriteLine("▌ Los colores secundarios que se tienen son ▐");
                Console.WriteLine("Rojo garante: " + C2.RojoGarante);
                Console.WriteLine("Amarillo oro: " + C2.AmarilloOro);
                Console.WriteLine("Azul rey: " + C2.AzulRey);
                Console.WriteLine("Verde obscuro: " + C2.VerdeOscuro);
            }
            Console.ReadKey();
        }
    }
}