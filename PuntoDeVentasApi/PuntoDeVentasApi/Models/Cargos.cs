using System;
using System.Collections.Generic;

namespace PuntoDeVentasApi.Models
{
    public partial class Cargos
    {
        public Cargos()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdCargo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
