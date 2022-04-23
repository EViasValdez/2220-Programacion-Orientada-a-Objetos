using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion, resultado;
            float numero1, numero2;

            Console.WriteLine("---- Calculadora ----");
            Console.WriteLine("Elige la opcion a determinar");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");

            opcion = (Console.ReadLine());

            Console.WriteLine("Ingresa los numeros");
            Console.WriteLine("Numero 1");
            resultado = Console.ReadLine();
            numero1 = float.Parse(resultado);
            Console.WriteLine("Numero 2");
            resultado = Console.ReadLine();
            numero2 = float.Parse(resultado);

            Program calc = new Program();

            if (opcion == "1")
            {
                calc.suma (numero1, numero2);

            }
            else if (opcion == "2")
            {
                calc.resta (numero1, numero2);
            }
        }
        public void suma(float numero1, float numero2)
        {
            double resultado;
            resultado = numero1 + numero2;
            Console.WriteLine("El resultado es: " + resultado);
        }
        public void resta(float numero1, float numero2)
        {
            double resultado;
            resultado = numero1 - numero2;
            Console.WriteLine("El resultado es: " + resultado);
        }
        public void multiplicacion(float numero1, float numero2)
        {
            double resultado;
            resultado = numero1 * numero2;
            Console.WriteLine("El resultado es: " + resultado);
        }
        public void division(float numero1, float numero2)
        {
            double resultado;
            resultado = numero1 / numero2;
            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}