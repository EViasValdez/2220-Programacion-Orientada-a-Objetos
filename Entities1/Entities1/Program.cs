﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities1
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Datos> ListDatos = new List<Datos>();

            ListDatos.Add(new Datos {ID = 1, Nombre = "Felix", APaterno = "Amador", AMaterno = "Bosqueda", Direccion = "Estado De Mexico, Mexico", Telefono = "" });
            ListDatos.Add(new Datos {ID = 2, Nombre = "Armando", APaterno = "Vazquez Montes", AMaterno = "Villalba", Direccion = "Guadalajara, Mexico", Telefono = "" });
            ListDatos.Add(new Datos {ID = 3, Nombre = "Maria", APaterno = "Salgado", AMaterno = "Martinez", Direccion = "Puebla, Mexico", Telefono = "" });
            ListDatos.Add(new Datos {ID = 4, Nombre = "Joselyn", APaterno = "Perez Escobedo", AMaterno = "Rodriguez", Direccion = "Queretaro, Mexico", Telefono = "" });
            ListDatos.Add(new Datos {ID = 5, Nombre = "Mauricio", APaterno = "Hernandez", AMaterno = "Acevedo", Direccion = "Hidalgo, Mexico", Telefono = "" });
        }
    }
}