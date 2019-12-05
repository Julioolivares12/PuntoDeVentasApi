using System;
using System.Collections.Generic;

namespace PuntoDeVentasApi.Models
{
    public partial class Clientes
    {
        public Clientes()
        {
            Ventas = new HashSet<Ventas>();
        }

        public int IdCliente { get; set; }
        public string Primernombre { get; set; }
        public string Primerapellido { get; set; }
        public DateTime? Fechanac { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string Lugartrabajo { get; set; }
        public string Dui { get; set; }
        public string Nit { get; set; }
        public string TelefCasa { get; set; }
        public string Celular { get; set; }
        public string DirecCasa { get; set; }
        public string TeleTrabajo { get; set; }

        public virtual ICollection<Ventas> Ventas { get; set; }
    }
}
