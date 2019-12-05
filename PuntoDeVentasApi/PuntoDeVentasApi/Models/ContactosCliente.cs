using System;
using System.Collections.Generic;

namespace PuntoDeVentasApi.Models
{
    public partial class ContactosCliente
    {
        public int IdContacto { get; set; }
        public int IdCliente { get; set; }
        public string TelCasa { get; set; }
        public string TelTrabajo { get; set; }
        public string Celular { get; set; }
        public string TelReferencia1 { get; set; }
        public string TelReferencia2 { get; set; }
    }
}
