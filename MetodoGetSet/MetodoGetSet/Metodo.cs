using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoGetSet
{
    class Metodo
    {
        string Nombre;

        public void SetValor(string nom)
        {
            Nombre = nom;
        }
        public string GetValor()
        {
            if (Nombre == "Eduardo")
            {
                Nombre = "El nombre es Eduardo";
            }
            return Nombre;
        }
    }
}