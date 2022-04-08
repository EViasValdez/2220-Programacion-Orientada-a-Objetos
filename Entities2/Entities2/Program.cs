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

            EntDatos data = new EntDatos();

            do
            {
                Console.WriteLine("Ingrese identificacion");
                data.Id = Console.ReadLine();
                Console.WriteLine("Ingrese nombre");
                data.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese apellido paterno");
                data.aPaterno = Console.ReadLine();
                Console.WriteLine("Ingrese apellido materno");
                data.aMaterno = Console.ReadLine();
                Console.WriteLine("Ingrese numero");
                data.Telefono = Console.ReadLine();
                Console.WriteLine("Ingese Email");
                data.Email = Console.ReadLine();
                Console.WriteLine("Ingrese direccion");
                data.Direccion = Console.ReadLine();
                Console.WriteLine("Ingrese edad");
                data.Edad = Console.ReadLine();
                Console.WriteLine("Ingrese CURP");
                data.CURP = Console.ReadLine();

                L.Add (data);

                foreach (EntDatos datos in L)
                {
                    Console.WriteLine("Nombre completo: " + data.Nombre + " " + data.aPaterno + " " + data.aMaterno);
                    Console.WriteLine("Identificacion: " + data.Id);
                    Console.WriteLine("Numero de telefono: " + data.Telefono);
                    Console.WriteLine("Email: " + data.Email);
                    Console.WriteLine("Direccion: " + data.Direccion);
                    Console.WriteLine("Edad: " + data.Edad);
                    Console.WriteLine("CURP: " + data.CURP);
                }
                
                Console.ReadKey();
                Console.WriteLine("¿Quiere agregar otro?");
                sino = Boolean.Parse(Console.ReadLine());
            }
            while (sino == true);
        }
    }
}