using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            EVV_Datos Data = new EVV_Datos();
            EVV_Publicacion DatPubli = new EVV_Publicacion();
            EVV_CD DatCD = new EVV_CD();

            Console.WriteLine("Ingrese id");
            Data.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nombre");
            Data.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese apellido materno");
            Data.APaterno = Console.ReadLine();
            Console.WriteLine("Ingrese apellido paterno");
            Data.AMaterno = Console.ReadLine();

            Console.WriteLine("Libro");
            Console.WriteLine("Ingrese titulo");
            DatPubli.Titulo = Console.ReadLine();
            Console.WriteLine("Ingrese precio");
            DatPubli.Precio = int.Parse(Console.ReadLine());
        }
    }
}