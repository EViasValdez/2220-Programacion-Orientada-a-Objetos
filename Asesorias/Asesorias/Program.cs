using System;
using System.Collections.Generic;
using System.Text;

namespace Asesorias
{
    class Program
    {
        static void Main(string[] args)
        {
			// Clase main con menu.
            Console.WriteLine("==····==");
            Console.WriteLine("Sea bienvenido");

            bool Electo = false;
            string Sino;

            // Crear una repeticion en el programa.
            do
			{
                Console.WriteLine("¿Que acción desea realizar?");
                string Accion;
                Accion = (Console.ReadLine());

                if (Accion == "mostrar")
                {
                    Console.WriteLine("Usted eligió mostrar");
                    Console.WriteLine("Elige una clase");

                    string Clase;
                    
                    Console.WriteLine("1. Auto");
                    Console.WriteLine("2. Computadora");
                    Console.WriteLine("3. Banco");
                    Console.WriteLine("4. Pizarron");
                    Console.WriteLine("5. Teclado");
                    Console.WriteLine("6. Mouse");
                    Clase = (Console.ReadLine());

                    // Pantalla de selección usando if.
                    if (Clase == "1")
                    {
                        Auto Vehiculo = new Auto(); // Llamada de la clase.
                        Vehiculo.mostrarauto(); // Llamada del método.
                    }
                    else
                    if (Clase == "2")
                    {
                        Computadora Computador = new Computadora();
                        Computador.mostrarcomputadora();
                    }
                    else
                    if (Clase == "3")
                    {
                        Banco Banca = new Banco();
                        Banca.MostrarBanco();
                    }
                    else
                    if (Clase == "4")
                    {
                        Pizarron Pizar = new Pizarron();
                        Pizar.MostrarPizarron();
                    }
                    else
                    if (Clase == "5")
                    {
                        Teclado Tecl = new Teclado();
                        Tecl.MostrarTeclado();
                    }
                    else
                    if (Clase == "6")
                    {
                        Mouse Rato = new Mouse();
                        Rato.MostrarMouse();
                    }
                    }
                    else
                    if (Accion == "Borrar") // Abrir el método "borrar".
                    {
                        Console.WriteLine("Usted eligió Borrar");
                        Console.WriteLine("Elige una clase");

                        string Clase2;

                        Console.WriteLine("1. Auto"); // Unicamente funciona la primera opción.
                        Console.WriteLine("2. Computadora");
                        Console.WriteLine("3. Banco");
                        Console.WriteLine("4. Pizarron");
                        Console.WriteLine("5. Teclado");
                        Console.WriteLine("6. Mouse");
                        Clase2 = (Console.ReadLine());

                        if (Clase2 == "1")
                        {
			                Auto Auto2 = new Auto();
			                Auto2.borrarauto();
                        }
                        }
                        Electo = true;
                    
                    Console.WriteLine("¿Desea agregar otros datos?");
			        Sino = Console.ReadLine();

                    if (Sino.ToLower().Equals("no")) {
                        Electo = false;
                    }
                } while (Electo);
        }
    }
    public class Auto // Clase del auto.
    {
        public string TipoAuto { get; set; } // Generación de elementos.
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string CodigoPlaca { get; set; }
        public int NumSerie { get; set; }
        public int NumAsientos { get; set; }

        public void mostrarauto() // Metodo para convocar por medio de la Clase.
        {
            Console.WriteLine("Usted eligió la opción Automobil, ingrese cualquier tecla para continuar");
            Console.ReadKey();

            Auto Automobil = new Auto();
            List <Auto> ListaAuto = new List<Auto>(); // Generación de una lista.

            Console.WriteLine("Ingrese la información"); 
            Console.WriteLine("Ponga el tipo de auto"); // Ingreso de datos.
            Automobil.TipoAuto = Console.ReadLine();
            Console.WriteLine("Ponga la Marca");
            Automobil.Marca = Console.ReadLine();
            Console.WriteLine("Ponga el Modelo");
            Automobil.Modelo = Console.ReadLine();
            Console.WriteLine("Ponga el numero de asientos");
            Automobil.NumAsientos = int.Parse(Console.ReadLine());

            ListaAuto.Add(Automobil); // Registro de datos en la lista.

            Console.WriteLine("====================");
            Console.ReadKey();

            foreach (Auto au in ListaAuto)
            {
                Console.WriteLine("Aquí están los datos ingresados"); // Retorno de datos.
                Console.WriteLine("Tipo de auto: " + Automobil.TipoAuto);
                Console.WriteLine("Marca: " + Automobil.Marca);
                Console.WriteLine("Modelo: " + Automobil.Modelo);
                Console.WriteLine("Numero de asientos: " + Automobil.NumAsientos);
            }
        }
        public void borrarauto() // Método para borrar datos por medio de la Clase.
        {
            Console.WriteLine("Este método esta inconcluso");
        }
    }
    public class Computadora // Clase de la computadora.
    {
		public string Marca { get; set; }
        public string Modelo { get; set; }
        public string SistemaOperativo { get; set; }
        public string Procesador { get; set; }

		public void mostrarcomputadora()
		{
            Console.WriteLine("Usted eligió la opción Computadora, ingrese cualquier tecla para continuar");
            Console.ReadKey();

            Computadora Ordenador = new Computadora();
            List <Computadora> ListaComp = new List<Computadora>();

            Console.WriteLine("Ingrese la información");
            Console.WriteLine("Ponga la Marca de la computadora");
            Ordenador.Marca = Console.ReadLine();
            Console.WriteLine("Ponga el Modelo");
            Ordenador.Modelo = Console.ReadLine();
            Console.WriteLine("Ponga el sistema operativo");
            Ordenador.SistemaOperativo = Console.ReadLine();
            Console.WriteLine("Ponga el nombre del procesador");
            Ordenador.Procesador = Console.ReadLine();

            ListaComp.Add(Ordenador);

            Console.WriteLine("====================");
            Console.ReadKey(); // Retorno de datos.

            foreach (Computadora orden in ListaComp)
            {
                Console.WriteLine("Aquí están los datos ingresados");
                Console.WriteLine("Marca: " + Ordenador.Marca);
                Console.WriteLine("Modelo: " + Ordenador.Modelo);
                Console.WriteLine("Sistema operativo: " + Ordenador.SistemaOperativo);
                Console.WriteLine("Procesador: " + Ordenador.Procesador);
            }
        }
    }
    public class Banco // Clase del banco.
    {
        public string NombreBanco { get; set; }
        public string Sucursal { get; set; }
        public string TipodeSucursal { get; set; }
        public string Horario{ get; set; }

		public void MostrarBanco()
		{
            Console.WriteLine("Usted eligió la opción banco, ingrese cualquier tecla para continuar");
			Console.ReadKey();

			Banco Banca = new Banco();
            List <Banco> ListaBanco = new List<Banco>();

			Console.WriteLine("Ponga el nombre del banco");
			Banca.NombreBanco = Console.ReadLine();
			Console.WriteLine("Ponga el nombre de la sucursal");
			Banca.Sucursal = Console.ReadLine();
			Console.WriteLine("Ponga el tipo de sucursal");
			Banca.TipodeSucursal = Console.ReadLine();
            Console.WriteLine("Ponga el horario");
            Banca.Horario = Console.ReadLine();

            ListaBanco.Add(Banca);

			Console.WriteLine("====================");
            Console.ReadKey(); // Retorno de datos.

            foreach (Banco banc in ListaBanco)
            {
                Console.WriteLine("Aquí están los datos ingresados");
                Console.WriteLine("Nombre del banco: " + Banca.NombreBanco);
                Console.WriteLine("Sucursal: " + Banca.Sucursal);
                Console.WriteLine("Tipo de sucursal: " + Banca.TipodeSucursal);
                Console.WriteLine("Horario:" + Banca.Horario);
            }
        }
    }
    public class Pizarron // Clase del pizarron.
    {
        public string Marca { get; set; }
        public string Color { get; set; }
        public string Tipo { get; set; }
        public string Tamaño { get; set; }

		public void MostrarPizarron()
		{
            Console.WriteLine("Usted eligió la opción pizarron, ingrese cualquier tecla para continuar");
			Console.ReadKey();

			Pizarron pizarra = new Pizarron();
            List <Pizarron> ListaPizarron = new List <Pizarron>();

			Console.WriteLine("Ponga la Marca del pizarron");
			pizarra.Marca = Console.ReadLine();
			Console.WriteLine("Ponga el color del pizarron");
			pizarra.Color = Console.ReadLine();
			Console.WriteLine("Ponga el tipo de pizarron");
			pizarra.Tipo = Console.ReadLine();
            Console.WriteLine("Ponga el tamaño del pizarron");
			pizarra.Tamaño = Console.ReadLine();

            ListaPizarron.Add(pizarra);

			Console.WriteLine("====================");
            Console.ReadKey(); // Retorno de datos.

            foreach (Pizarron Pizar in ListaPizarron)
            {
                Console.WriteLine("Aquí están los datos ingresados");
                Console.WriteLine("Marca: " + pizarra.Marca);
                Console.WriteLine("Color: " + pizarra.Color);
                Console.WriteLine("Tipo: " + pizarra.Tipo);
                Console.WriteLine("Tamaño: " + pizarra.Tamaño);
            }
        }
    }
    public class Teclado // Clase del teclado.
    {
        public string Marca { get; set; }
        public string Color { get; set; }
        public string Tipo { get; set; }
        public string PadNumerico { get; set; }

        public void MostrarTeclado()
        {
            Console.WriteLine("Usted eligió la opción teclado, ingrese cualquier tecla para continuar");
            Console.ReadKey();

            Teclado Key = new Teclado();
            List <Teclado> ListaTeclado = new List<Teclado>();

            Console.WriteLine("Ponga la Marca del teclado");
            Key.Marca = Console.ReadLine();
            Console.WriteLine("Ponga el color del teclado");
            Key.Color = Console.ReadLine();
            Console.WriteLine("Ponga el tipo de teclado");
            Key.Tipo = Console.ReadLine();
            Console.WriteLine("Ponga si el teclado tiene pad numérico");
            Key.PadNumerico = Console.ReadLine();

            ListaTeclado.Add(Key);

            Console.WriteLine("====================");
            Console.ReadKey(); // Retorno de datos.

            foreach (Teclado Tecl in ListaTeclado)
            {
                Console.WriteLine("Aquí están los datos ingresados");
                Console.WriteLine("Marca: " + Key.Marca);
                Console.WriteLine("Color: " + Key.Color);
                Console.WriteLine("Tipo: " + Key.Tipo);
                Console.WriteLine("Pad Numerico: " + Key.PadNumerico);
            }
        }
    }
    public class Mouse // Clase del mouse.
    {
        public string Marca { get; set; }
        public string Color { get; set; }
		public string Tipo { get; set; }
		public string Alambrico { get; set; }
        
        public void MostrarMouse()
        {
            Console.WriteLine("Usted eligió la opción mouse, ingrese cualquier tecla para continuar");
            Console.ReadKey();

            Mouse Mous = new Mouse();
            List <Mouse> ListaMouse = new List<Mouse>();

            Console.WriteLine("Ponga la Marca del ratón");
            Mous.Marca = Console.ReadLine();
            Console.WriteLine("Ponga el color del ratón");
            Mous.Color = Console.ReadLine();
            Console.WriteLine("Ponga el tipo de ratón");
            Mous.Tipo = Console.ReadLine();
            Console.WriteLine("Ponga si el ratón es alambrico");
            Mous.Alambrico = Console.ReadLine();

            ListaMouse.Add(Mous);

            Console.WriteLine("====================");
            Console.ReadKey();

            foreach (Mouse mou in ListaMouse)
            {
                Console.WriteLine("Aquí están los datos ingresados");
                Console.WriteLine("Marca: " + Mous.Marca);
                Console.WriteLine("Color: " + Mous.Color);
                Console.WriteLine("Tipo: " + Mous.Tipo);
                Console.WriteLine("Alambrico: " + Mous.Alambrico);
            }
        }
    }
}