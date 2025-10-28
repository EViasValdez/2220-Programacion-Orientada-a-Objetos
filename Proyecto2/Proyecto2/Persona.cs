using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto2
{
    class Persona
    {
        public string Identificacion;
        public string Nombre;
        public string ApellidoPaterno;
        public string ApellidoMaterno;
        public string Genero;
        public string Direccion;

        public Persona()
        {
            Identificacion = "123";
            Nombre = "Eduardo";
            ApellidoPaterno = "Viñas";
            ApellidoMaterno = "Valdez";
            Genero = "Masculino";
            Direccion = "Villa del real segunda sección, Tecámac";
        }
    }
}