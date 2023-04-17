using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Hijo Javi = new Hijo();

            Javi.Id = 12;
            Javi.Nombre = "Javier ";
            Javi.APaterno = "Escobedo ";
            Javi.AMaterno = "Fernandez";
            Console.WriteLine("El nombre del empleado es: " + Javi.Nombre + Javi.APaterno + Javi.AMaterno);
            Console.ReadKey();
        }
    }
}