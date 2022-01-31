using System;
using System.Collections.Generic;

namespace Asesorias
{
    class Program
    {
        static void Main(string[] args)
        {
			// Clase main con menu
            Console.WriteLine("==····==");
            Console.WriteLine("Sea bienvenido");
            bool electo = false;
            string sino;
            // Crear una repeticion en el programa
            do
			{
                Console.WriteLine("¿Que accion desea realizar?");
                string accion;
                accion = (Console.ReadLine());

                if (accion == "mostrar")
                {
                    Console.WriteLine("Usted eligio Mostrar");
                    Console.WriteLine("Eliga una clase");

                    string clase;
                    Console.WriteLine("1. Auto");
                    Console.WriteLine("2. Computadora");
                    Console.WriteLine("3. Banco");
                    Console.WriteLine("4. Pizarron");
                    Console.WriteLine("5. Teclado");
                    Console.WriteLine("6. Mouse");
                    clase = (Console.ReadLine());

                //Pantalla de seleccion usando if
                if (clase == "1")
                {
                    Auto vehiculo = new Auto(); // Llamada de la clase
                    vehiculo.mostrarauto(); // Llamada del metodo
                }
                else
                if (clase == "2")
                {
                    Computadora computador = new Computadora();
                    computador.mostrarcomputadora();
                }
                else
                if (clase == "3")
                {
                    Banco banca = new Banco();
                    banca.mostrarbanco();
                }
                else
                if (clase == "4")
                {
                    Pizarron pizar = new Pizarron();
                    pizar.mostrarpizarron();
                }
                else
                if (clase == "5")
                {
                    Teclado tecl = new Teclado();
                    tecl.mostrarteclado();
                }
                else
                if (clase == "6")
                {
                    Mouse rato = new Mouse();
                    rato.mostrarmouse();
                }
                }
                else
                if (accion == "borrar") //Abrir el metodo borrar
                {
                    Console.WriteLine("Usted eligio borrar");
                    Console.WriteLine("Eliga una clase");

                string clase2;
                Console.WriteLine("1. Auto"); // Unicamente funciona la primera opcion
                Console.WriteLine("2. Computadora");
                Console.WriteLine("3. Banco");
                Console.WriteLine("4. Pizarron");
                Console.WriteLine("5. Teclado");
                Console.WriteLine("6. Mouse");
                clase2 = (Console.ReadLine());

                if (clase2 == "1")
                {
			        Auto auto2 = new Auto();
			        auto2.borrarauto();
                }
                }
                electo = true;
                Console.WriteLine("¿Desea agregar otros datos?");
			    sino = Console.ReadLine();
                if (sino.ToLower().Equals("no")) electo = false;
                }while(electo);
        }
    }
    public class Auto // Clase del auto
    {
        public string tipoauto { get; set; } // Generacion de elementos
        public string marca { get; set; }
        public string modelo { get; set; }
        public string codigoplaca { get; set; }
        public int numserie { get; set; }
        public int numasientos { get; set; }
        public void mostrarauto() // Metodo para convocar por medio de la clase
        {
            Console.WriteLine("Usted eligio la opcion Automobil, ingrese cualquier tecla para continuar");
            Console.ReadKey();
            Auto automobil = new Auto();
            List<Auto> ListaAuto = new List<Auto>(); // Generacion de una lista
            Console.WriteLine("Ingrese la informacion"); 
            Console.WriteLine("Ponga el tipo de auto"); // Ingreso de datos
            automobil.tipoauto = Console.ReadLine();
            Console.WriteLine("Ponga la marca");
            automobil.marca = Console.ReadLine();
            Console.WriteLine("Ponga el modelo");
            automobil.modelo = Console.ReadLine();
            Console.WriteLine("Ponga el numero de asientos");
            automobil.numasientos = int.Parse(Console.ReadLine());

            ListaAuto.Add(automobil); // Registro de datos en la lista

            Console.WriteLine("====================");
            Console.ReadKey();

            foreach (Auto au in ListaAuto)
            {
                Console.WriteLine("Aqui estan los datos ingresados"); // Retorno de datos
                Console.WriteLine("Tipo de auto: " + automobil.tipoauto);
                Console.WriteLine("Marca: " + automobil.marca);
                Console.WriteLine("Modelo: " + automobil.modelo);
                Console.WriteLine("Numero de asientos: " + automobil.numasientos);
            }
        }
        public void borrarauto() // Metodo bara borrar datos por medio de la clase
        {
          Console.WriteLine("Este metodo esta inconcluso");
        }
    }

        public class Computadora // Clase de la computadora
        {
		public string marca { get; set; }
        public string modelo { get; set; }
        public string sistemaoperativo { get; set; }
        public string procesador { get; set; }
		public void mostrarcomputadora()
		{
            Console.WriteLine("Usted eligio la opcion Computadora, ingrese cualquier tecla para continuar");
            Console.ReadKey();
            Computadora ordenador = new Computadora();
            List<Computadora> ListaComp = new List<Computadora>();
            Console.WriteLine("Ingrese la informacion");
            Console.WriteLine("Ponga la marca de la computadora");
            ordenador.marca = Console.ReadLine();
            Console.WriteLine("Ponga el modelo");
            ordenador.modelo = Console.ReadLine();
            Console.WriteLine("Ponga el sistema operativo");
            ordenador.sistemaoperativo = Console.ReadLine();
            Console.WriteLine("Ponga el nombre del procesador");
            ordenador.procesador = Console.ReadLine();

            ListaComp.Add(ordenador);

            Console.WriteLine("====================");
            Console.ReadKey(); // Retorno de datos

            foreach (Computadora orden in ListaComp)
            {
                Console.WriteLine("Aqui estan los datos ingresados");
                Console.WriteLine("Marca: " + ordenador.marca);
                Console.WriteLine("Modelo: " + ordenador.modelo);
                Console.WriteLine("Sistema operativo: " + ordenador.sistemaoperativo);
                Console.WriteLine("Procesador: " + ordenador.procesador);
            }
        }
    }
    public class Banco // Clase del Banco
    {
        public string nombrebanco { get; set; }
        public string sucursal { get; set; }
        public string tipodesucursal { get; set; }
        public string horario{ get; set; }
		public void mostrarbanco ()
		{
            Console.WriteLine("Usted eligio la opcion Banco, ingrese cualquier tecla para continuar");
			Console.ReadKey();
			Banco banca = new Banco();
            List<Banco> ListaBanco = new List<Banco>();
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
            Console.ReadKey(); // Retorno de datos

            foreach (Banco banc in ListaBanco)
            {
                Console.WriteLine("Aqui estan los datos ingresados");
                Console.WriteLine("Nombre del banco: " + banca.nombrebanco);
                Console.WriteLine("Sucursal: " + banca.sucursal);
                Console.WriteLine("Tipo de sucursal: " + banca.tipodesucursal);
                Console.WriteLine("Horario:" + banca.horario);
            }
        }
    }

    public class Pizarron // Clase del pizarron
    {
        public string marca { get; set; }
        public string color { get; set; }
        public string tipo { get; set; }
        public string tamaño { get; set; }
		public void mostrarpizarron()
		{
            Console.WriteLine("Usted eligio la opcion Pizarron, ingrese cualquier tecla para continuar");
			Console.ReadKey();
			Pizarron pizarra = new Pizarron();
            List<Pizarron> ListaPizarron = new List<Pizarron>();
			Console.WriteLine("Ponga la marca del pizarron");
			pizarra.marca = Console.ReadLine();
			Console.WriteLine("Ponga el color del pizarron");
			pizarra.color = Console.ReadLine();
			Console.WriteLine("Ponga el tipo de pizarron");
			pizarra.tipo = Console.ReadLine();
            Console.WriteLine("Ponga el tamaño del pizarron");
			pizarra.tamaño = Console.ReadLine();

            ListaPizarron.Add(pizarra);

			Console.WriteLine("====================");
            Console.ReadKey(); // Retorno de datos

            foreach (Pizarron pizar in ListaPizarron)
            {
                Console.WriteLine("Aqui estan los datos ingresados");
                Console.WriteLine("Marca: " + pizarra.marca);
                Console.WriteLine("Color: " + pizarra.color);
                Console.WriteLine("Tipo: " + pizarra.tipo);
                Console.WriteLine("Tamaño: " + pizarra.tamaño);
            }
        }
    }

    public class Teclado // Clase del teclado
    {
        public string marca { get; set; }
        public string color { get; set; }
        public string tipo { get; set; }
        public string padnumerico { get; set; }
        public void mostrarteclado()
        {
            Console.WriteLine("Usted eligio la opcion Teclado, ingrese cualquier tecla para continuar");
            Console.ReadKey();
            Teclado key = new Teclado();
            List<Teclado> ListaTeclado = new List<Teclado>();
            Console.WriteLine("Ponga la marca del teclado");
            key.marca = Console.ReadLine();
            Console.WriteLine("Ponga el color del teclado");
            key.color = Console.ReadLine();
            Console.WriteLine("Ponga el tipo de teclado");
            key.tipo = Console.ReadLine();
            Console.WriteLine("Ponga si el teclado tiene pad numerico");
            key.padnumerico = Console.ReadLine();

            ListaTeclado.Add(key);

            Console.WriteLine("====================");
            Console.ReadKey(); // Retorno de datos

            foreach (Teclado tecl in ListaTeclado)
            {
                Console.WriteLine("Aqui estan los datos ingresados");
                Console.WriteLine("Marca: " + key.marca);
                Console.WriteLine("Color: " + key.color);
                Console.WriteLine("Tipo: " + key.tipo);
                Console.WriteLine("Pad Numerico: " + key.padnumerico);
            }
        }
    }
    public class Mouse // Clase del mouse
    {
        public string marca { get; set; }
        public string color { get; set; }
		public string tipo { get; set; }
		public string alambrico { get; set; }
        public void mostrarmouse()
        {
            Console.WriteLine("Usted eligio la opcion Mouse, ingrese cualquier tecla para continuar");
            Console.ReadKey();
            Mouse mous = new Mouse();
            List<Mouse> ListaMouse = new List<Mouse>();
            Console.WriteLine("Ponga la marca del raton");
            mous.marca = Console.ReadLine();
            Console.WriteLine("Ponga el color del raton");
            mous.color = Console.ReadLine();
            Console.WriteLine("Ponga el tipo de raton");
            mous.tipo = Console.ReadLine();
            Console.WriteLine("Ponga si el raton es alambrico");
            mous.alambrico = Console.ReadLine();

            ListaMouse.Add(mous);

            Console.WriteLine("====================");
            Console.ReadKey();

            foreach (Mouse mou in ListaMouse)
            {
                Console.WriteLine("Aqui estan los datos ingresados");
                Console.WriteLine("Marca: " + mous.marca);
                Console.WriteLine("Color: " + mous.color);
                Console.WriteLine("Tipo: " + mous.tipo);
                Console.WriteLine("Alambrico: " + mous.alambrico);
            }
        }
    }
}