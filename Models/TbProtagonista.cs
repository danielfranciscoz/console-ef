using System;
using System.Collections.Generic;

#nullable disable

namespace HolaMundoORM.Models
{
    public partial class TbProtagonista
    {
        public TbProtagonista()
        {
            TbTestVocacionals = new HashSet<TbTestVocacional>();
        }

        public int IdProtagonista { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Sexo { get; set; }
        public bool? Estado { get; set; }
        public int IdDepartamento { get; set; }
        public string Correo { get; set; }
        public DateTime FechaGrabacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public virtual ICollection<TbTestVocacional> TbTestVocacionals { get; set; }
    }
}
