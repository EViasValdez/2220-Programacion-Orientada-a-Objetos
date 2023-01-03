using System;

namespace metodoGetSet
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
            Pract.total = float.Parse(Console.ReadLine());
            Pract.Iva = Pract.total;

            Console.WriteLine("----------------");
            Console.WriteLine("El id es: " + Pract.Id + " con nombre: " + Pract.Nombre);
            Console.WriteLine("Con un total de: " + Pract.total);
            Console.WriteLine("Un iva de: " + Pract.Iva);
            Console.WriteLine("El total iva es: " + Pract.totalIva);
            Console.WriteLine("El descuento es: " + Pract.descuento);
            Console.WriteLine(Pract.Iva);
        }
    }
}