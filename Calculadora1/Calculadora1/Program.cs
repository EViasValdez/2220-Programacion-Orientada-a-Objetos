using System;

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

            Program calc = new Program();

            if (Opcion == "1")
            {
                calc.suma (Numero1, Numero2);
            }
            else if (Opcion == "2")
            {
                calc.resta (Numero1, Numero2);
            }
        }
        public void suma(float Numero1, float Numero2)
        {
            double Resultado;
            Resultado = Numero1 + Numero2;
            Console.WriteLine("El Resultado es: " + Resultado);
        }
        public void resta(float Numero1, float Numero2)
        {
            double Resultado;
            Resultado = Numero1 - Numero2;
            Console.WriteLine("El Resultado es: " + Resultado);
        }
        public void multiplicacion(float Numero1, float Numero2)
        {
            double Resultado;
            Resultado = Numero1 * Numero2;
            Console.WriteLine("El Resultado es: " + Resultado);
        }
        public void division(float Numero1, float Numero2)
        {
            double Resultado;
            Resultado = Numero1 / Numero2;
            Console.WriteLine("El Resultado es: " + Resultado);
        }
    }
}