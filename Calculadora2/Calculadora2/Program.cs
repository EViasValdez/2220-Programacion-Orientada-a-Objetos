using System;

namespace Calculadora2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Opcion, Resultado;
            float Numero1, Numero2;
            double Rest = 0;
            string z;

            do
            {
                Console.WriteLine("---- Calculadora ----");
                Console.WriteLine("Elige la opción a determinar");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. Division");

                Opcion = (Console.ReadLine());

                Console.WriteLine("Ingrese los valores");
                Console.WriteLine("Numero 1");
                Resultado = Console.ReadLine();
                Numero1 = float.Parse(Resultado);
                Console.WriteLine("Numero 2");
                Resultado = Console.ReadLine();
                Numero2 = float.Parse(Resultado);

                if (Opcion == "1")
                {
                    Suma sum = new Suma (Numero1, Numero2);
                    Rest = sum.Resultado;
                }
                else if (Opcion == "2")
                {
                    Resta res = new Resta (Numero1, Numero2);
                    Rest = res.Resultado;
                }
                else if (Opcion == "3")
                {
                    Multiplicacion mult = new Multiplicacion (Numero1, Numero2);
                    Rest = mult.Resultado;
                }
                else if (Opcion == "4")
                {
                    Division Divi = new Division (Numero1, Numero2);
                    Rest = Divi.Resultado;
                }
                Console.WriteLine("El resultado es: " + Rest);
                Console.WriteLine("¿Desea hacer otra Opcion?");
                z = Console.ReadLine();
            }
            while (z == "s");
        }
    }
}