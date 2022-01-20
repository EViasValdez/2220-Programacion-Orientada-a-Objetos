using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaAct
{
    public class Cliente:Datos
    {
        public string sueldo { get; set; }
        public string turno { get; set; }
        public string cargo { get; set; }
        public string antiguedad { get; set; }
    }
}