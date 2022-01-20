using System;

namespace EduardoViñasValdez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("____ Editorial R.S ____ ");
            Console.WriteLine("Productos disponibles");
            Console.WriteLine("1. Libros");
            Console.WriteLine("2. CDs");

            EVV_Datos data = new EVV_Datos();
            EVV_Publicacion datPubli = new EVV_Publicacion();
            EVV_CD datCD = new EVV_CD();
            
            Console.WriteLine("Ingrese id");
            data.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nombre");
            data.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese apellido materno");
            data.aPaterno = Console.ReadLine();
            Console.WriteLine("Ingrese apellido paterno");
            data.aMaterno = Console.ReadLine();

            Console.WriteLine("Libro");
            Console.WriteLine("Ingrese titulo");
            datPubli.Titulo = Console.ReadLine();
            Console.WriteLine("Ingrese precio");
            datPubli.Precio = int.Parse(Console.ReadLine());
        }
    }
}
