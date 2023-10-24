using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno Alum = new Alumno();

            Console.WriteLine("El alumno " + Alum.Nombre);
            // Alum.ApellidoPaterno;
            // Alum.ApellidoMaterno;
        }
    }
}