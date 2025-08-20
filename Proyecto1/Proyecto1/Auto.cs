using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Proyecto1
{
    class Auto
    {
        public string Identificacion;
        public string Modelo;
        public string Marca;
        public string Color;
        public int Annio;
        public string Categoria;
        public string Placa;
        public float Precio;
        public string SubMarca;
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
            Identificacion = "62";
            Annio = 2018;
            Categoria = "A";
            Color = "Blanco";
            Marca = "Ford";
            Modelo = "GT";
            Placa = "RSG - 012 - 201";
            Precio = 752400f;
            SubMarca = "Ford Mustang";
        }
    }
}