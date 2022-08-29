using System;
using System.Collections.Generic;

namespace Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Datos> listDatos = new List<Datos>();

            listDatos.Add (new Datos {Id = 1, nombre = "Felix", aPaterno = "Amador", aMaterno = "Bosqueda", direccion = "Estado De Mexico, Mexico", telefono = "" });
            listDatos.Add (new Datos {Id = 2, nombre = "Armando", aPaterno = "Vazquez Montes", aMaterno = "Villalba", direccion = "Guadalajara, Mexico", telefono = "" });
            listDatos.Add (new Datos {Id = 3, nombre = "Maria", aPaterno = "Salgado", aMaterno = "Martinez", direccion = "Puebla, Mexico", telefono = "" });
            listDatos.Add (new Datos {Id = 4, nombre = "Joselyn", aPaterno = "Perez Escobedo", aMaterno = "Rodriguez", direccion = "Queretaro, Mexico", telefono = "" });
            listDatos.Add (new Datos {Id = 5, nombre = "Mauricio", aPaterno = "Hernandez", aMaterno = "Acevedo", direccion = "Hidalgo, Mexico", telefono = "" });
        }
    }
}