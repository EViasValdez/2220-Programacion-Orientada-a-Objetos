using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoGetSet
{
    class Metodo
    {
        string Nombre;

        public void SetValor(string Nom)
        {
            Nombre = Nom;
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