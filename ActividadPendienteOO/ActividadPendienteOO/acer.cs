using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadPendienteOO
{
    class Acer
    {
        public string Id;
        public string Marca;
        public string Modelo;
        public string Tipo;
        public string SistemaOperativo;
        public string Capacidad;
        public string MemoriaRam;
        public string Procesador;
        public string TarjetaGrafica;

        public Acer()
        {
            Id = "N5CV2MYZ";
            Marca = "Acer";
            Modelo = "Aspire C24";
            Tipo = "All-in-One";
            SistemaOperativo = "Windows 10";
            Capacidad = "1TB en HDD";
            MemoriaRam = "8 GBs";
            Procesador = "Intel Core i3 i3-1005G1";
            TarjetaGrafica = "Gráficos integrados";
        }
    }
}