using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoGetSet
{
    class Practica
    {
        private int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private float _Iva;
        public float Iva
        {
            get
            {
                float i = 0.16f;
                _Iva = _Iva * i;

                return _Iva;
            }
            set { _Iva = value; }
        }

        private float _total;
        public float Total
        {
            get { return _total; }
            set { _total = value; }
        }

        private float _TotalIva;
        public float TotalIva
        {
            get
            {

                _TotalIva = Total + 1.16f;

                return _TotalIva;
            }
            set { _TotalIva = value; }
        }

        private float _Descuento;
        public float Descuento
        {
            get
            {
                if (Total > 1000)
                {
                    _Descuento = TotalIva * 0.20f;
                    _Descuento = TotalIva - _Descuento;
                }

                return _Descuento;
            }
            set { _Descuento = value; }
        }
    }
}