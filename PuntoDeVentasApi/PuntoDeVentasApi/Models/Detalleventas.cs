using System;
using System.Collections.Generic;

namespace PuntoDeVentasApi.Models
{
    public partial class Detalleventas
    {
        public int IdDetalleventa { get; set; }
        public int IdVenta { get; set; }
        public int IdRepuesto { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Preciounitario { get; set; }
        public decimal? Subtotalrepuesto { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? Iva { get; set; }
        public decimal? Totalrepuesto { get; set; }
        public DateTime? FechaPago { get; set; }
        public string Mes { get; set; }

        public virtual Ventas IdVentaNavigation { get; set; }
    }
}
