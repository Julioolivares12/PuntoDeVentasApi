using System;
using System.Collections.Generic;

namespace PuntoDeVentasApi.Models
{
    public partial class Marcasvehiculos
    {
        public Marcasvehiculos()
        {
            Repuestos = new HashSet<Repuestos>();
        }

        public int IdMarcaveh { get; set; }
        public int IdModeloveh { get; set; }
        public int IdTipoveh { get; set; }
        public int IdClasesveh { get; set; }
        public string Descripcion { get; set; }

        public virtual Clasesvehiculos IdClasesvehNavigation { get; set; }
        public virtual ICollection<Repuestos> Repuestos { get; set; }
    }
}
