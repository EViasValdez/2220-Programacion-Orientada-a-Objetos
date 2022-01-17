using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Hijo Javi = new Hijo();
            Javi.Id = 12;
            Javi.nombre = "Javier ";
            Javi.aPaterno = "Escobedo ";
            Javi.aMaterno = "Fernandez";
            Console.WriteLine("El nombre del empleado es " + Javi.nombre + Javi.aPaterno + Javi.aMaterno);
            Console.ReadKey();
        }
    }
}
