using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadPendienteOO
{
    class Lenovo
    {
        public string ID;
        public string Marca;
        public string Modelo;
        public string Tipo;
        public string SistemaOperativo;
        public string Capacidad;
        public string MemoriaRam;
        public string Procesador;
        public string TarjetaGrafica;

        public Lenovo()
        {
            ID = "ZNAS6Z2M";
            Marca = "Lenovo";
            Modelo = "IdeaPad 5i";
            Tipo = "Laptop";
            SistemaOperativo = "Windows 10";
            Capacidad = "1TB en HDD y 256GBs en SSD";
            MemoriaRam = "8 GBs";
            Procesador = "AMD Ryzen 5000";
            TarjetaGrafica = "AMD Radeon";
        }
    }
}