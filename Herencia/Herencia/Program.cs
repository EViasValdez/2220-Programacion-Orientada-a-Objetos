using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Hijo Javi = new Hijo();

            Javi.ID = 12;
            Javi.Nombre = "Javier ";
            Javi.APaterno = "Escobedo ";
            Javi.AMaterno = "Fernandez";
            Console.WriteLine("El nombre del empleado es: " + Javi.Nombre + Javi.APaterno + Javi.AMaterno);
            Console.ReadKey();
        }
    }
}