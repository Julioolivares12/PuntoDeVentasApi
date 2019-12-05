using System;
using System.Collections.Generic;

namespace PuntoDeVentasApi.Models
{
    public partial class Inventario
    {
        public int IdInventario { get; set; }
        public string Descripcion { get; set; }
        public int IdRepuesto { get; set; }
        public string Bodega { get; set; }
        public int? Totalexistencias { get; set; }
        public int? Existenciasactuales { get; set; }

        public virtual Repuestos IdRepuestoNavigation { get; set; }
    }
}
