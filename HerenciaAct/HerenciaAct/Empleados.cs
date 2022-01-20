using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaAct
{
    public class Empleados:Datos
    {
        public string rfc { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public string numerotelefono { get; set; }
    }
}