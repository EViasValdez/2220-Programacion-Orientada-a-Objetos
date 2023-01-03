using System;
using System.Collections.Generic;

namespace Entities2
{
    class Program
    {
        static void Main(string[] args)
        {
            List <EntDatos> L = new List <EntDatos>();

            Boolean sino;

            EntDatos Data = new EntDatos();

            do
            {
                Console.WriteLine("Ingrese identificación");
                Data.Id = Console.ReadLine();
                Console.WriteLine("Ingrese nombre");
                Data.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese apellido paterno");
                Data.aPaterno = Console.ReadLine();
                Console.WriteLine("Ingrese apellido materno");
                Data.aMaterno = Console.ReadLine();
                Console.WriteLine("Ingrese numero");
                Data.Telefono = Console.ReadLine();
                Console.WriteLine("Ingrese Email");
                Data.Email = Console.ReadLine();
                Console.WriteLine("Ingrese dirección");
                Data.Direccion = Console.ReadLine();
                Console.WriteLine("Ingrese edad");
                Data.Edad = Console.ReadLine();
                Console.WriteLine("Ingrese CURP");
                Data.CURP = Console.ReadLine();

                L.Add (Data);

                foreach (EntDatos datos in L)
                {
                    Console.WriteLine("Nombre completo: " + Data.Nombre + " " + Data.aPaterno + " " + Data.aMaterno);
                    Console.WriteLine("Identificación: " + Data.Id);
                    Console.WriteLine("Numero de teléfono: " + Data.Telefono);
                    Console.WriteLine("Email: " + Data.Email);
                    Console.WriteLine("Dirección: " + Data.Direccion);
                    Console.WriteLine("Edad: " + Data.Edad);
                    Console.WriteLine("CURP: " + Data.CURP);
                }

                Console.ReadKey();
                Console.WriteLine("¿Quiere agregar otro?");
                sino = Boolean.Parse(Console.ReadLine());
            }
            while (sino == true);
        }
    }
}