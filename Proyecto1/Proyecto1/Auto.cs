using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Proyecto1
{
    class Auto
    {
        public string Id;
        public string Modelo;
        public string Marca;
        public string Color;
        public int Annio;
        public string Categoria;
        public string Placa;
        public float Precio;
        public string Submarca;
        string x, y;

        public Auto(string Model, string Marca, string Nada)
        {
            Console.WriteLine("Escriba la marca");
            x = Console.ReadLine();
            Console.ReadLine();
            y = Console.ReadLine();
        }
        public Auto(string Modelo, string Marca)
        {
            Modelo = "Forte";
            Marca = "Kia";
        }
        public Auto()
        {
            Id = "62";
            Annio = 2018;
            Categoria = "A";
            Color = "Blanco";
            Marca = "Ford";
            Modelo = "GT";
            Placa = "RSG - 012 - 201";
            Precio = 752400f;
            Submarca = "Ford Mustang";
        }
    }
}