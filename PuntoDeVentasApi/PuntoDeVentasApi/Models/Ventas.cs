using System;
using System.Collections.Generic;

namespace PuntoDeVentasApi.Models
{
    public partial class Ventas
    {
        public Ventas()
        {
            Detalleventas = new HashSet<Detalleventas>();
        }

        public int IdVenta { get; set; }
        public int IdUsuario { get; set; }
        public int IdCliente { get; set; }
        public string Nrodoc { get; set; }
        public string IdTipodoc { get; set; }
        public string NroCf { get; set; }
        public DateTime? Fechaventa { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? Iva { get; set; }
        public decimal? Montototal { get; set; }

        public virtual Clientes IdClienteNavigation { get; set; }
        public virtual Usuarios IdUsuarioNavigation { get; set; }
        public virtual ICollection<Detalleventas> Detalleventas { get; set; }
    }
}
