using System;

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
            Empl.aPaterno = Console.ReadLine();

            Console.WriteLine("Ingrese apellido paterno");
            Empl.aMaterno = Console.ReadLine();

            Console.WriteLine("================");

            Console.WriteLine("Datos del cliente");
            Console.WriteLine("Ingese sueldo");
            Clien.sueldo = Console.ReadLine();

            Console.WriteLine("Ingrese turno");
            Clien.turno = Console.ReadLine();

            Console.WriteLine("Ingrese Cargo");
            Clien.cargo = Console.ReadLine();

            Console.WriteLine("Ingrese Antiguedad");
            Clien.antiguedad = Console.ReadLine();

            Console.WriteLine("================");

            Console.WriteLine("He aqui los datos del empleado");
            Console.WriteLine("El id es " + Empl.Id);
            Console.WriteLine("El nombre es " + Empl.Nombre);
            Console.WriteLine("El apellido paterno es " + Empl.aPaterno);
            Console.WriteLine("El apellido materno es " + Empl.aMaterno);

            Console.WriteLine("He aqui los datos del cliente");
            Console.WriteLine("El sueldo es " + Clien.sueldo);
            Console.WriteLine("El turno es " + Clien.turno);
            Console.WriteLine("El cargo es " + Clien.cargo);
            Console.WriteLine("El cargo es " + Clien.antiguedad);
        }
    }
}