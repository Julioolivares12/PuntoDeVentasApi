using System;
using System.Collections.Generic;

namespace PuntoDeVentasApi.Models
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Ventas = new HashSet<Ventas>();
        }

        public int IdUsuario { get; set; }
        public int IdCargo { get; set; }
        public int IdPerfil { get; set; }
        public string Primernombre { get; set; }
        public string Segundonombre { get; set; }
        public string Primerapellido { get; set; }
        public string Segundoapellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime? Fechanac { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }

        public virtual Cargos IdCargoNavigation { get; set; }
        public virtual Perfil IdPerfilNavigation { get; set; }
        public virtual ICollection<Ventas> Ventas { get; set; }
    }
}
