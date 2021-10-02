using System;
using System.Collections.Generic;

#nullable disable

namespace HolaMundoORM.Models
{
    public partial class TbCentrosInicio
    {
        public int IdCentrosInicio { get; set; }
        public int IdCentro { get; set; }
        public short CantidadCarreras { get; set; }
        public int CantidadProtagonistas { get; set; }
        public short CantidadLaboratorios { get; set; }
        public short Orden { get; set; }
        public string Estado { get; set; }
        public int UsuarioGrabacion { get; set; }
        public DateTime FechaGrabacion { get; set; }
        public int UsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
