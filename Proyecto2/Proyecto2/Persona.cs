using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto2
{
    class Persona
    {
        public string id;
        public string nombre;
        public string apellidoPaterno;
        public string apellidoMaterno;
        public string genero;
        public string direccion;

        public Persona()
        {
            id = "123";
            nombre = "Eduardo";
            apellidoPaterno = "Viñas";
            apellidoMaterno = "Valdez";
            genero = "Masculino";
            direccion = "Villas del Real Segunda Seccion, Tecamac";
        }
    }
}
