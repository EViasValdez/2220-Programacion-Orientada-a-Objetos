using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaAct
{
    public class Empleados:Datos
    {
        public string Rfc { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string NumeroTelefono { get; set; }
    }
}