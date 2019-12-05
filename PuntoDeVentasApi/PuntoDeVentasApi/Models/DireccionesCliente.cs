using System;
using System.Collections.Generic;

namespace PuntoDeVentasApi.Models
{
    public partial class DireccionesCliente
    {
        public int IdDireccion { get; set; }
        public int IdCliente { get; set; }
        public string Direcciontrabajo { get; set; }
        public string Direccioncasa { get; set; }
        public string Direccioncorrespondencia { get; set; }
    }
}
