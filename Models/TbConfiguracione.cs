using System;
using System.Collections.Generic;

#nullable disable

namespace HolaMundoORM.Models
{
    public partial class TbConfiguracione
    {
        public int IdConfiguracion { get; set; }
        public string Clave { get; set; }
        public string Valor { get; set; }
        public string ValorVisible { get; set; }
        public string Tipo { get; set; }
        public int UsuarioGrabacion { get; set; }
        public DateTime FechaGrabacion { get; set; }
        public int UsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
