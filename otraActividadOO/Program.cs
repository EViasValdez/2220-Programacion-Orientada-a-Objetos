using System;

namespace otraActividadOO
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;

            Console.WriteLine("                                       ");
            Console.WriteLine("■■ Hay dos tipos de colores ■■");
            Console.WriteLine("                                       ");

            color1 co1 = new color1();
            color1 co2 = new color2();

            if (opcion == "1"){
                Console.WriteLine("Usted eligio la opcion 1");
            }
        }
    }
}