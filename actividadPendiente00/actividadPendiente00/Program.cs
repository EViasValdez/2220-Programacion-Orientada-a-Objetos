using System;

namespace actividadPendiente00
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;

            Console.WriteLine("—|||||||||||||||||||||||||||||||||||||—");
            Console.WriteLine("■■ Tienda de electronica y computacion ■■");
            Console.WriteLine("■■ Computadoras ■■");
            Console.WriteLine("—|||||||||||||||||||||||||||||||||||||—");
            Console.WriteLine("                                       ");
            Console.ReadKey();

            Console.WriteLine("Las marcas que tenemos son las siguientes");
            Console.WriteLine("1. Toshiba");
            Console.WriteLine("2. Lenovo");
            Console.WriteLine("3. Hewlett-Packard");
            Console.WriteLine("4. Acer");
            Console.WriteLine("Eliga la opcion deseada con el numero marcado");
            Console.WriteLine("                                       ");

            opcion = (Console.ReadLine());

            toshiba tsba = new toshiba();
            lenovo lnvo = new lenovo();
            hewlett_packard hepa = new hewlett_packard();
            acer acer = new acer();

            if (opcion == "1")
            {
                Console.WriteLine("► Detalles del producto ◄");
                Console.WriteLine("Id del producto: " + tsba.id);
                Console.WriteLine("Marca:" + tsba.marca);
                Console.WriteLine("Modelo:" + tsba.modelo);
                Console.WriteLine("Tipo de computadora: " + tsba.tipo);
                Console.WriteLine("Sistema operativo: " + tsba.sistemaoperativo);
                Console.WriteLine("Capacidad de memoria: " + tsba.capacidad);
                Console.WriteLine("Procesador: " + tsba.procesador);
                Console.WriteLine("Tarjeta grafica: " + tsba.tarjetagrafica);
            }
            else
            if (opcion == "2")
            {
                Console.WriteLine("► Detalles del producto ◄");
                Console.WriteLine("Id del producto: " + lnvo.id);
                Console.WriteLine("Marca:" + lnvo.marca);
                Console.WriteLine("Modelo:" + lnvo.modelo);
                Console.WriteLine("Tipo de computadora: " + lnvo.tipo);
                Console.WriteLine("Sistema operativo: " + lnvo.sistemaoperativo);
                Console.WriteLine("Capacidad de memoria: " + lnvo.capacidad);
                Console.WriteLine("Procesador: " + lnvo.procesador);
                Console.WriteLine("Tarjeta grafica: " + lnvo.tarjetagrafica);
            }
            else
            if (opcion == "3")
            {
                Console.WriteLine("► Detalles del producto ◄");
                Console.WriteLine("Id del producto: " + hepa.id);
                Console.WriteLine("Marca:" + hepa.marca);
                Console.WriteLine("Modelo:" + hepa.modelo);
                Console.WriteLine("Tipo de computadora: " + hepa.tipo);
                Console.WriteLine("Sistema operativo: " + hepa.sistemaoperativo);
                Console.WriteLine("Capacidad de memoria: " + hepa.capacidad);
                Console.WriteLine("Procesador: " + hepa.procesador);
                Console.WriteLine("Tarjeta grafica: " + hepa.tarjetagrafica);
            }
            else
            if (opcion == "4")
            {
                Console.WriteLine("► Detalles del producto ◄");
                Console.WriteLine("Id del producto: " + acer.id);
                Console.WriteLine("Marca: " + acer.marca);
                Console.WriteLine("Modelo: " + acer.modelo);
                Console.WriteLine("Tipo de computadora: " + acer.tipo);
                Console.WriteLine("Sistema operativo: " + acer.sistemaoperativo);
                Console.WriteLine("Capacidad de memoria: " + acer.capacidad);
                Console.WriteLine("Procesador: " + acer.procesador);
                Console.WriteLine("Tarjeta grafica: " + acer.tarjetagrafica);
            }
            Console.ReadKey();
        }
    }
}