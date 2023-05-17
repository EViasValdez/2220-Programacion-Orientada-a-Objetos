using System;
using System.Collections.Generic;
using System.Text;

namespace Entities1
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Datos> ListDatos = new List<Datos>();

            ListDatos.Add(new Datos {Id = 1, Nombre = "Felix", APaterno = "Amador", AMaterno = "Bosqueda", Direccion = "Estado De Mexico, Mexico", Telefono = "" });
            ListDatos.Add(new Datos {Id = 2, Nombre = "Armando", APaterno = "Vazquez Montes", AMaterno = "Villalba", Direccion = "Guadalajara, Mexico", Telefono = "" });
            ListDatos.Add(new Datos {Id = 3, Nombre = "Maria", APaterno = "Salgado", AMaterno = "Martinez", Direccion = "Puebla, Mexico", Telefono = "" });
            ListDatos.Add(new Datos {Id = 4, Nombre = "Joselyn", APaterno = "Perez Escobedo", AMaterno = "Rodriguez", Direccion = "Queretaro, Mexico", Telefono = "" });
            ListDatos.Add(new Datos {Id = 5, Nombre = "Mauricio", APaterno = "Hernandez", AMaterno = "Acevedo", Direccion = "Hidalgo, Mexico", Telefono = "" });
        }
    }
}