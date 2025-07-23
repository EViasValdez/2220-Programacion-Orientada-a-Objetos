using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Opcion, Resultado;
            float Numero1, Numero2;

            Console.WriteLine("---- Calculadora ----");
            Console.WriteLine("Elige la opción a determinar");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. Division");

            Opcion = (Console.ReadLine());

            Console.WriteLine("Ingresa los números");
            Console.WriteLine("Numero 1");
            Resultado = Console.ReadLine();
            Numero1 = float.Parse(Resultado);
            Console.WriteLine("Numero 2");
            Resultado = Console.ReadLine();
            Numero2 = float.Parse(Resultado);

            Program Calc = new Program();

            if (Opcion == "1")
            {
                Calc.Suma (Numero1, Numero2);
            }
            else if (Opcion == "2")
            {
                Calc.Resta (Numero1, Numero2);
            }
            else if (Opcion == "3")
            {
                Calc.Multiplicacion(Numero1, Numero2);
            }
            else if (Opcion == "4")
            {
                Calc.Division(Numero1, Numero2);
            }
        }
        public void Suma(float Numero1, float Numero2)
        {
            double Resultado;
            Resultado = Numero1 + Numero2;
            Console.WriteLine("El Resultado es: " + Resultado);
        }
        public void Resta(float Numero1, float Numero2)
        {
            double Resultado;
            Resultado = Numero1 - Numero2;
            Console.WriteLine("El Resultado es: " + Resultado);
        }
        public void Multiplicacion(float Numero1, float Numero2)
        {
            double Resultado;
            Resultado = Numero1 * Numero2;
            Console.WriteLine("El Resultado es: " + Resultado);
        }
        public void Division(float Numero1, float Numero2)
        {
            double Resultado;
            Resultado = Numero1 / Numero2;
            Console.WriteLine("El Resultado es: " + Resultado);
        }
    }
}