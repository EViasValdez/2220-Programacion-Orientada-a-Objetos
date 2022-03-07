using System;

namespace Calculadora2
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion, resultado;
            float numero1, numero2;
            double rest = 0;
            string z;

            do
            {
                Console.WriteLine("---- Calculadora ----");
                Console.WriteLine("Elige la opcion a determinar");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");

                opcion = (Console.ReadLine());

                Console.WriteLine("Ingrese los valores");
                Console.WriteLine("Numero 1");
                resultado = Console.ReadLine();
                numero1 = float.Parse(resultado);
                Console.WriteLine("Numero 2");
                resultado = Console.ReadLine();
                numero2 = float.Parse(resultado);

                if (opcion == "1")
                {
                    Suma sum = new Suma (numero1, numero2);
                    rest = sum.resultado;
                }
                else if (opcion == "2")
                {
                    Resta res = new Resta (numero1, numero2);
                    rest = res.resultado;
                }
                else if (opcion == "3")
                {
                    Multiplicacion mult = new Multiplicacion (numero1, numero2);
                    rest = mult.resultado;
                }
                else if (opcion == "4")
                {
                    Division divi = new Division (numero1, numero2);
                    rest = divi.resultado;
                }
                Console.WriteLine("El resultado es " + rest);
                Console.WriteLine("¿Desea hacer otra opcion?");
                z = Console.ReadLine();
            }
            while (z == "s");
        }
    }
}