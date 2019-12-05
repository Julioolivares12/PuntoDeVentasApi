using System;
using System.Collections.Generic;

namespace PuntoDeVentasApi.Models
{
    public partial class Partesvehiculos
    {
        public Partesvehiculos()
        {
            Repuestos = new HashSet<Repuestos>();
        }

        public int IdParteveh { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Repuestos> Repuestos { get; set; }
    }
}
