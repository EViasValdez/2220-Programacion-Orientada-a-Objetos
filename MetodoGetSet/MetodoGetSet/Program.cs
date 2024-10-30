using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace MetodoGetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Metodo m = new Metodo();
            // m.setValor("Eduardo");
            // Console.WriteLine(m.getValor());
            // Empleados e = new Empleados();
            // e.nombre = "Javier";
            // Console.ReadKey();

            Practica Pract = new Practica();

            Console.WriteLine("Ingrese el Id");
            Pract.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre");
            Pract.Nombre = (Console.ReadLine());

            Console.WriteLine("Ingrese el total");
            Pract.Total = float.Parse(Console.ReadLine());
            Pract.Iva = Pract.Total;

            Console.WriteLine("----------------");
            Console.WriteLine("El ID es: " + Pract.Id + " con nombre: " + Pract.Nombre);
            Console.WriteLine("Con un total de: " + Pract.Total);
            Console.WriteLine("Un IVA de: " + Pract.Iva);
            Console.WriteLine("El total iva es: " + Pract.TotalIva);
            Console.WriteLine("El descuento es: " + Pract.Descuento);
            Console.WriteLine(Pract.Iva);
        }
    }
}