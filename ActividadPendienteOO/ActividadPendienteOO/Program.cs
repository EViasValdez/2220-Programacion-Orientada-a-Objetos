using System;

namespace ActividadPendienteOO
{
    class Program
    {
        static void Main(string[] args)
        {
            string Opcion;

            Console.WriteLine("|||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("■■ Tienda de electronica y computación ■■");
            Console.WriteLine("■■ Computadoras ■■");
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("                                       ");
            Console.ReadKey();

            Console.WriteLine("Las marcas que tenemos son las siguientes");
            Console.WriteLine("1. Toshiba");
            Console.WriteLine("2. Lenovo");
            Console.WriteLine("3. Hewlett-Packard");
            Console.WriteLine("4. Acer");
            Console.WriteLine("Elige la opción deseada con el numero marcado");
            Console.WriteLine("                                       ");
            Opcion = (Console.ReadLine());

            Toshiba Tsba = new Toshiba();
            Lenovo Lnvo = new Lenovo();
            HewlettPackard Hepa = new HewlettPackard();
            Acer Ar = new Acer();

            if (Opcion == "1")
            {
                Console.WriteLine("► Detalles del producto ◄");
                Console.WriteLine("Id del producto: " + Tsba.Id);
                Console.WriteLine("Marca: " + Tsba.Marca);
                Console.WriteLine("Modelo: " + Tsba.Modelo);
                Console.WriteLine("Tipo de computadora: " + Tsba.Tipo);
                Console.WriteLine("Sistema operativo: " + Tsba.SistemaOperativo);
                Console.WriteLine("Capacidad de memoria: " + Tsba.Capacidad);
                Console.WriteLine("Procesador: " + Tsba.Procesador);
                Console.WriteLine("Tarjeta gráfica: " + Tsba.TarjetaGrafica);
            }
            else
            if (Opcion == "2")
            {
                Console.WriteLine("► Detalles del producto ◄");
                Console.WriteLine("Id del producto: " + Lnvo.Id);
                Console.WriteLine("Marca: " + Lnvo.Marca);
                Console.WriteLine("Modelo: " + Lnvo.Modelo);
                Console.WriteLine("Tipo de computadora: " + Lnvo.Tipo);
                Console.WriteLine("Sistema operativo: " + Lnvo.SistemaOperativo);
                Console.WriteLine("Capacidad de memoria: " + Lnvo.Capacidad);
                Console.WriteLine("Procesador: " + Lnvo.Procesador);
                Console.WriteLine("Tarjeta gráfica: " + Lnvo.TarjetaGrafica);
            }
            else
            if (Opcion == "3")
            {
                Console.WriteLine("► Detalles del producto ◄");
                Console.WriteLine("Id del producto: " + Hepa.Id);
                Console.WriteLine("Marca: " + Hepa.Marca);
                Console.WriteLine("Modelo: " + Hepa.Modelo);
                Console.WriteLine("Tipo de computadora: " + Hepa.Tipo);
                Console.WriteLine("Sistema operativo: " + Hepa.SistemaOperativo);
                Console.WriteLine("Capacidad de memoria: " + Hepa.Capacidad);
                Console.WriteLine("Procesador: " + Hepa.Procesador);
                Console.WriteLine("Tarjeta gráfica: " + Hepa.TarjetaGrafica);
            }
            else
            if (Opcion == "4")
            {
                Console.WriteLine("► Detalles del producto ◄");
                Console.WriteLine("Id del producto: " + Ar.Id);
                Console.WriteLine("Marca: " + Ar.Marca);
                Console.WriteLine("Modelo: " + Ar.Modelo);
                Console.WriteLine("Tipo de computadora: " + Ar.Tipo);
                Console.WriteLine("Sistema operativo: " + Ar.SistemaOperativo);
                Console.WriteLine("Capacidad de memoria: " + Ar.Capacidad);
                Console.WriteLine("Procesador: " + Ar.Procesador);
                Console.WriteLine("Tarjeta gráfica: " + Ar.TarjetaGrafica);
            }
            Console.ReadKey();
        }
    }
}