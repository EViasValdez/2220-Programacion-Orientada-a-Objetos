using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaAct
{
    public class Cliente:Datos
    {
        public string Sueldo { get; set; }
        public string Turno { get; set; }
        public string Cargo { get; set; }
        public string Antiguedad { get; set; }
    }
}