using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto1
{
    class Auto
    {
        public string id;
        public string modelo;
        public string marca;
        public string color;
        public int annio;
        public string categoria;
        public string placa;
        public float precio;
        public string submarca;
        string x, y;

        public Auto(string model, string marca, string nada)
        {
            Console.WriteLine("Escriba la marca");
            x = Console.ReadLine();
            Console.ReadLine();
            y = Console.ReadLine();
        }
        public Auto(string modelo, string marca)
        {
            modelo = "Forte";
            marca = "Kia";
        
        }
        public Auto()
        {
            id = "62";
            annio = 2018;
            categoria = "A";
            color = "Blanco";
            marca = "Ford";
            modelo = "GT";
            placa = "RSG - 012 - 201";
            precio = 752400f;
            submarca = "Ford Mustang";
        }

    }
}
