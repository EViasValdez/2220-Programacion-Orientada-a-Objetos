using System;
using System.Collections.Generic;
using System.Text;

namespace Empleados
{
    class Nomina
    {
        public float calculo(int Dias, int Sueldo)
        {
            int Res = Dias * Sueldo;
            return Res;
        }
    }
}