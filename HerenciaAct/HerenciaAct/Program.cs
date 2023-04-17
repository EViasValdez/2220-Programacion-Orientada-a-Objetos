using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaAct
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleados Empl = new Empleados();
            Cliente Clien = new Cliente();

            Console.WriteLine("================");

            Console.WriteLine("Datos del empleado");
            Console.WriteLine("Ingrese ID");
            Empl.Id = Console.ReadLine();

            Console.WriteLine("Ingrese nombre");
            Empl.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese apellido materno");
            Empl.APaterno = Console.ReadLine();

            Console.WriteLine("Ingrese apellido paterno");
            Empl.AMaterno = Console.ReadLine();

            Console.WriteLine("================");

            Console.WriteLine("Datos del cliente");
            Console.WriteLine("Ingrese sueldo");
            Clien.Sueldo = Console.ReadLine();

            Console.WriteLine("Ingrese turno");
            Clien.Turno = Console.ReadLine();

            Console.WriteLine("Ingrese cargo");
            Clien.Cargo = Console.ReadLine();

            Console.WriteLine("Ingrese antigüedad");
            Clien.Antiguedad = Console.ReadLine();

            Console.WriteLine("================");

            Console.WriteLine("He aquí los datos del empleado");
            Console.WriteLine("El id es: " + Empl.Id);
            Console.WriteLine("El nombre es: " + Empl.Nombre);
            Console.WriteLine("El apellido paterno es: " + Empl.APaterno);
            Console.WriteLine("El apellido materno es: " + Empl.AMaterno);

            Console.WriteLine("He aquí los datos del cliente");
            Console.WriteLine("El sueldo es: " + Clien.Sueldo);
            Console.WriteLine("El turno es: " + Clien.Turno);
            Console.WriteLine("El cargo es: " + Clien.Cargo);
            Console.WriteLine("El cargo es: " + Clien.Antiguedad);
        }
    }
}