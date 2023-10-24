using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona Eduardo = new Persona();
            
            Console.WriteLine("El curp / id es: " + Eduardo.Id);
            Console.WriteLine("El nombre es: " + Eduardo.Nombre);
            Console.WriteLine("El apellido paterno es: " + Eduardo.ApellidoPaterno);
            Console.WriteLine("El apellido materno es: " + Eduardo.ApellidoMaterno);
            Console.WriteLine("El genero es: " + Eduardo.Genero);
            Console.WriteLine("Su dirección es: " + Eduardo.Direccion);

            Persona info = new Persona();
            info.Id = "458";
            info.Nombre = "";
            info.ApellidoPaterno = "";
            info.ApellidoMaterno = "";
            info.Genero = "";
            info.Direccion = "";
        }
    }
}