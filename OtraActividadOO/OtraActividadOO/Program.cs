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

            Console.WriteLine("Eliga una opcion");
            Console.WriteLine("1. Colores primarios");
            Console.WriteLine("2. Colores secundarios");
            Console.WriteLine("                                       ");

            opcion = (Console.ReadLine());

            color1 c1 = new color1();
            color2 c2 = new color2();

            if (opcion == "1")
            {
                Console.WriteLine("▌ Los colores primarios que se tienen son ▐");
                Console.WriteLine("Rojo: " + c1.rojo);
                Console.WriteLine("Amarillo: " + c1.amarillo);
                Console.WriteLine("Azul: " + c1.azul);
                Console.WriteLine("Verde: " + c1.verde);
            }
            else
            if (opcion == "2")
            {
                Console.WriteLine("▌ Los colores secundarios que se tienen son ▐");
                Console.WriteLine("Rojo garante: " + c2.rojogarante);
                Console.WriteLine("Amarillo oro: " + c2.amarillooro);
                Console.WriteLine("Azul rey: " + c2.azulrey);
                Console.WriteLine("Verde obscuro: " + c2.verdeoscuro);
            }
            Console.ReadKey();
        }
    }
}