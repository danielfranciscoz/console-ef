using System;
using System.Collections.Generic;

#nullable disable

namespace HolaMundoORM.Models
{
    public partial class TbPregunta
    {
        public TbPregunta()
        {
            TbRespuestasTestVocacionals = new HashSet<TbRespuestasTestVocacional>();
        }

        public int IdPregunta { get; set; }
        public int IdRubro { get; set; }
        public short Numero { get; set; }
        public string Pregunta { get; set; }
        public short Puntaje { get; set; }
        public bool? Estado { get; set; }
        public int UsuarioGrabacion { get; set; }
        public DateTime FechaGrabacion { get; set; }
        public int UsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public virtual ICollection<TbRespuestasTestVocacional> TbRespuestasTestVocacionals { get; set; }
    }
}
