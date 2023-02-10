using System;
using System.Collections.Generic;

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
                        Auto vehiculo = new Auto(); // Llamada de la clase.
                        vehiculo.mostrarauto(); // Llamada del método.
                    }
                    else
                    if (Clase == "2")
                    {
                        Computadora computador = new Computadora();
                        computador.mostrarcomputadora();
                    }
                    else
                    if (Clase == "3")
                    {
                        Banco banca = new Banco();
                        banca.mostrarbanco();
                    }
                    else
                    if (Clase == "4")
                    {
                        Pizarron pizar = new Pizarron();
                        pizar.mostrarpizarron();
                    }
                    else
                    if (Clase == "5")
                    {
                        Teclado tecl = new Teclado();
                        tecl.mostrarteclado();
                    }
                    else
                    if (Clase == "6")
                    {
                        Mouse rato = new Mouse();
                        rato.mostrarmouse();
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
			                Auto auto2 = new Auto();
			                auto2.borrarauto();
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
        public string nombrebanco { get; set; }
        public string sucursal { get; set; }
        public string tipodesucursal { get; set; }
        public string horario{ get; set; }

		public void mostrarbanco()
		{
            Console.WriteLine("Usted eligió la opción banco, ingrese cualquier tecla para continuar");
			Console.ReadKey();

			Banco banca = new Banco();
            List <Banco> ListaBanco = new List<Banco>();

			Console.WriteLine("Ponga el nombre del banco");
			banca.nombrebanco = Console.ReadLine();
			Console.WriteLine("Ponga el nombre de la sucursal");
			banca.sucursal = Console.ReadLine();
			Console.WriteLine("Ponga el tipo de sucursal");
			banca.tipodesucursal = Console.ReadLine();
            Console.WriteLine("Ponga el horario");
            banca.horario = Console.ReadLine();

            ListaBanco.Add(banca);

			Console.WriteLine("====================");
            Console.ReadKey(); // Retorno de datos.

            foreach (Banco banc in ListaBanco)
            {
                Console.WriteLine("Aquí están los datos ingresados");
                Console.WriteLine("Nombre del banco: " + banca.nombrebanco);
                Console.WriteLine("Sucursal: " + banca.sucursal);
                Console.WriteLine("Tipo de sucursal: " + banca.tipodesucursal);
                Console.WriteLine("Horario:" + banca.horario);
            }
        }
    }
    public class Pizarron // Clase del pizarron.
    {
        public string Marca { get; set; }
        public string color { get; set; }
        public string tipo { get; set; }
        public string tamaño { get; set; }

		public void mostrarpizarron()
		{
            Console.WriteLine("Usted eligió la opción pizarron, ingrese cualquier tecla para continuar");
			Console.ReadKey();

			Pizarron pizarra = new Pizarron();
            List <Pizarron> ListaPizarron = new List <Pizarron>();

			Console.WriteLine("Ponga la Marca del pizarron");
			pizarra.Marca = Console.ReadLine();
			Console.WriteLine("Ponga el color del pizarron");
			pizarra.color = Console.ReadLine();
			Console.WriteLine("Ponga el tipo de pizarron");
			pizarra.tipo = Console.ReadLine();
            Console.WriteLine("Ponga el tamaño del pizarron");
			pizarra.tamaño = Console.ReadLine();

            ListaPizarron.Add(pizarra);

			Console.WriteLine("====================");
            Console.ReadKey(); // Retorno de datos.

            foreach (Pizarron pizar in ListaPizarron)
            {
                Console.WriteLine("Aquí están los datos ingresados");
                Console.WriteLine("Marca: " + pizarra.Marca);
                Console.WriteLine("Color: " + pizarra.color);
                Console.WriteLine("Tipo: " + pizarra.tipo);
                Console.WriteLine("Tamaño: " + pizarra.tamaño);
            }
        }
    }
    public class Teclado // Clase del teclado.
    {
        public string Marca { get; set; }
        public string color { get; set; }
        public string tipo { get; set; }
        public string padnumerico { get; set; }

        public void mostrarteclado()
        {
            Console.WriteLine("Usted eligió la opción teclado, ingrese cualquier tecla para continuar");
            Console.ReadKey();

            Teclado key = new Teclado();
            List <Teclado> ListaTeclado = new List<Teclado>();

            Console.WriteLine("Ponga la Marca del teclado");
            key.Marca = Console.ReadLine();
            Console.WriteLine("Ponga el color del teclado");
            key.color = Console.ReadLine();
            Console.WriteLine("Ponga el tipo de teclado");
            key.tipo = Console.ReadLine();
            Console.WriteLine("Ponga si el teclado tiene pad numérico");
            key.padnumerico = Console.ReadLine();

            ListaTeclado.Add(key);

            Console.WriteLine("====================");
            Console.ReadKey(); // Retorno de datos.

            foreach (Teclado tecl in ListaTeclado)
            {
                Console.WriteLine("Aquí están los datos ingresados");
                Console.WriteLine("Marca: " + key.Marca);
                Console.WriteLine("Color: " + key.color);
                Console.WriteLine("Tipo: " + key.tipo);
                Console.WriteLine("Pad Numerico: " + key.padnumerico);
            }
        }
    }
    public class Mouse // Clase del mouse.
    {
        public string Marca { get; set; }
        public string color { get; set; }
		public string tipo { get; set; }
		public string alambrico { get; set; }
        
        public void mostrarmouse()
        {
            Console.WriteLine("Usted eligió la opción mouse, ingrese cualquier tecla para continuar");
            Console.ReadKey();

            Mouse mous = new Mouse();
            List <Mouse> ListaMouse = new List<Mouse>();

            Console.WriteLine("Ponga la Marca del ratón");
            mous.Marca = Console.ReadLine();
            Console.WriteLine("Ponga el color del ratón");
            mous.color = Console.ReadLine();
            Console.WriteLine("Ponga el tipo de ratón");
            mous.tipo = Console.ReadLine();
            Console.WriteLine("Ponga si el ratón es alambrico");
            mous.alambrico = Console.ReadLine();

            ListaMouse.Add(mous);

            Console.WriteLine("====================");
            Console.ReadKey();

            foreach (Mouse mou in ListaMouse)
            {
                Console.WriteLine("Aquí están los datos ingresados");
                Console.WriteLine("Marca: " + mous.Marca);
                Console.WriteLine("Color: " + mous.color);
                Console.WriteLine("Tipo: " + mous.tipo);
                Console.WriteLine("Alambrico: " + mous.alambrico);
            }
        }
    }
}