using System;
using System.Collections.Generic;
using System.Text;

namespace metodoGetSet
{
    class Metodo
    {
        string nombre;
        public void setValor(string nom)
        {
            nombre = nom;
        }
        public string getValor()
        {
            if (nombre == "Eduardo")
            {
                nombre = "El nombre es Eduardo";
            }
            return nombre;
        }
    }
}