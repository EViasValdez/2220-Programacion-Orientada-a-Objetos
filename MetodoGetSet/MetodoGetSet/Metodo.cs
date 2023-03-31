using System;
using System.Collections.Generic;
using System.Text;

namespace metodoGetSet
{
    class Metodo
    {
        string Nombre;

        public void setValor(string nom)
        {
            Nombre = nom;
        }
        public string getValor()
        {
            if (Nombre == "Eduardo")
            {
                Nombre = "El nombre es Eduardo";
            }
            return Nombre;
        }
    }
}