﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    public class Hijo:Padre
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string APaterno { get; set; }
        public string AMaterno { get; set; }
    }
}