using System;
using System.Collections.Generic;

#nullable disable

namespace HolaMundoORM.Models
{
    public partial class TbRespuestasTestVocacional
    {
        public int IdRespuestaTestVocacional { get; set; }
        public int IdTestVocacional { get; set; }
        public int IdPregunta { get; set; }
        public short Respuesta { get; set; }
        public DateTime FechaGrabacion { get; set; }

        public virtual TbPregunta IdPreguntaNavigation { get; set; }
        public virtual TbTestVocacional IdTestVocacionalNavigation { get; set; }
    }
}
