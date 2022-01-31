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

            Practica pract = new Practica();
            Console.WriteLine("Ingrese el Id: ");
            pract.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre: ");
            pract.Nombre = (Console.ReadLine());

            Console.WriteLine("Ingrese el total: ");
            pract.total = float.Parse(Console.ReadLine());
            pract.Iva = pract.total;

            Console.WriteLine("----------------");
            Console.WriteLine("El id es.... " + pract.Id + " con nombre.... " + pract.Nombre);
            Console.WriteLine("Con un total de.... " + pract.total);
            Console.WriteLine("Un iva de.... " + pract.Iva);
            Console.WriteLine("El total iva es.... " + pract.totalIva);
            Console.WriteLine("El descuento es.... " + pract.descuento);
            Console.WriteLine(pract.Iva);
        }
    }
}