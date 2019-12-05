using System;
using System.Collections.Generic;

namespace PuntoDeVentasApi.Models
{
    public partial class Repuestos
    {
        public Repuestos()
        {
            Inventario = new HashSet<Inventario>();
        }

        public int IdRepuesto { get; set; }
        public int IdParteveh { get; set; }
        public int IdMarcaveh { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal? Preciocompra { get; set; }
        public decimal? Precioventa { get; set; }
        public decimal? Descuento { get; set; }
        public string NumMotor { get; set; }
        public string NumChasis { get; set; }
        public string NumVin { get; set; }
        public string Upc { get; set; }
        public decimal? Cantidad { get; set; }

        public virtual Marcasvehiculos IdMarcavehNavigation { get; set; }
        public virtual Partesvehiculos IdPartevehNavigation { get; set; }
        public virtual ICollection<Inventario> Inventario { get; set; }
    }
}
