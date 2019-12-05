using System;
using System.Collections.Generic;

namespace PuntoDeVentasApi.Models
{
    public partial class Pagos
    {
        public int IdPago { get; set; }
        public int IdVenta { get; set; }
        public string Tipo { get; set; }
        public string Metodo { get; set; }
        public decimal? Valor { get; set; }
        public DateTime? FechePago { get; set; }
    }
}
