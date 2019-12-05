using System;
using System.Collections.Generic;

namespace PuntoDeVentasApi.Models
{
    public partial class Clasesvehiculos
    {
        public Clasesvehiculos()
        {
            Marcasvehiculos = new HashSet<Marcasvehiculos>();
        }

        public int IdClasesveh { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Marcasvehiculos> Marcasvehiculos { get; set; }
    }
}
