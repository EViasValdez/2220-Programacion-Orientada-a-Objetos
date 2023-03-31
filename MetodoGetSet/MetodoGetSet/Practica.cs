using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoGetSet
{
    class Practica
    {
        private int _Id;
        public int Id;
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
        public float Iva;
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
        public float total;
        {
            get { return _total; }
            set { _total = value; }
        }
        private float _totalIva;
        public float totalIva;
        {
            get
            {
                _totalIva = total + 1.16f;
                return _totalIva;
            }
            set { _totalIva = value; }
        }
        private float _descuento;
        public float descuento;
        {
            get
            {
                if (total > 1000)
                {
                    _descuento = totalIva * 0.20f;
                    _descuento = totalIva - _descuento;
                }
                return _descuento; }
            }
            set { _descuento = value; }
        }
    }
}