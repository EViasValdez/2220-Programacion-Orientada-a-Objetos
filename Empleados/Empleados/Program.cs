using System;
using System.Collections.Generic;
using System.Text;

namespace Empleados
{
    class Program
    {
        static void Main(string[] args)
        {
            Personal Per = new Personal();
            Nomina Nom = new Nomina();

            string Otra = "";
            int i = 0;

            do
            {
                Console.WriteLine("Ingrese el id del empleado");
                string Id = Console.ReadLine();

                Console.WriteLine("Ingrese días trabajados");
                int Dias = int.Parse(Console.ReadLine());

                if (Id != Per.Identificador)
                {
                    Console.WriteLine("Error usuario no valido");
                    Otra = "s";
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Ingrese los datos trabajados");
                    float Salario = Nom.calculo(Dias, Per.Sueldo);

                    Console.WriteLine("El empleado " + Per.Nombre + Per.Identificador + Per.FechadeNacimiento + "Tiene un saldo de: " + Salario);
                }
            }
            while (i < 2);
        }
    }
}