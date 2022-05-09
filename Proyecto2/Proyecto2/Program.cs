using System;

namespace Proyecto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona Eduardo = new Persona();
            
            Console.WriteLine("El curp/id es: " + Eduardo.id);
            Console.WriteLine("El nombre es: " + Eduardo.nombre);
            Console.WriteLine("El apellido paterno es: " + Eduardo.apellidoPaterno);
            Console.WriteLine("El apellido materno es: " + Eduardo.apellidoMaterno);
            Console.WriteLine("El genero es: " + Eduardo.genero);
            Console.WriteLine("Su direccion es: " + Eduardo.direccion);
            
            Persona info = new Persona();
            info.id = "458";
            info.nombre = "";
            info.apellidoPaterno = "";
            info.apellidoMaterno = "";
            info.genero = "";
            info.direccion = "";
        }
    }
}