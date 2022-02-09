using System;
using System.Collections.Generic;
using System.Text;

namespace Empleados
{
    class Program
    {
        static void Main(string[] args)
        {
            Personal per = new Personal();
            Nomina nom = new Nomina();
            
            string otra = "";
            int i = 0;

            do
            {
                Console.WriteLine("Ingrese el id del empleado");
                string id = Console.ReadLine();

                Console.WriteLine("Ingrese dias trabajados");
                int dias = int.Parse(Console.ReadLine());

                if (id != per.identificador)
                {
                    Console.WriteLine("Error usuario no valido");
                    otra = "s";
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Ingrese los datos trabajados");
                    float salario = nom.calculo(dias, per.sueldo);
                    Console.WriteLine("El empleado " + per.nombre + per.identificador + per.fechadenacimiento + "Tiene un saldo de:" + salario);
                }
            }
            while(i < 2);
        }
    }
}