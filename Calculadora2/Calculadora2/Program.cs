using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Suma Sum = new Suma (Numero1, Numero2);
                    Rest = Sum.Resultado;
                }
                else if (Opcion == "2")
                {
                    Resta Res = new Resta (Numero1, Numero2);
                    Rest = Res.Resultado;
                }
                else if (Opcion == "3")
                {
                    Multiplicacion Mult = new Multiplicacion (Numero1, Numero2);
                    Rest = Mult.Resultado;
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