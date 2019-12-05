using System;
using System.Collections.Generic;

namespace PuntoDeVentasApi.Models
{
    public partial class Perfil
    {
        public Perfil()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdPerfil { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
