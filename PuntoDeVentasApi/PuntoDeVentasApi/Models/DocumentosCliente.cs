using System;
using System.Collections.Generic;

namespace PuntoDeVentasApi.Models
{
    public partial class DocumentosCliente
    {
        public int IdDocumento { get; set; }
        public int IdCliente { get; set; }
        public string Dui { get; set; }
        public string Nit { get; set; }
        public string Pasaporte { get; set; }
        public string Licencia { get; set; }
    }
}
