using System;
using System.Collections.Generic;
using System.Text;

namespace Empleados
{
    class Nomina
    {
        public float calculo(int dias, int sueldo)
        {
            int res = dias * sueldo;
            return res;
        }
    }
}
