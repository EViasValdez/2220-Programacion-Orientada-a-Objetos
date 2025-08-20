using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadPendienteOO
{
    class HewlettPackard
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

        public HewlettPackard()
        {
            ID = "KN7V6CTV";
            Marca = "HP";
            Modelo = "Pavilion 15-eh0003la";
            Tipo = "Laptop";
            SistemaOperativo = "Windows 10";
            Capacidad = "256 GBs en SSD";
            MemoriaRam = "8 GBs";
            Procesador = "Intel Core i7-1165G7";
            TarjetaGrafica = "Gráficos integrados";
        }
    }
}