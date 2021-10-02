using System;
using System.Collections.Generic;

#nullable disable

namespace HolaMundoORM.Models
{
    public partial class TbTestVocacional
    {
        public TbTestVocacional()
        {
            TbRespuestasTestVocacionals = new HashSet<TbRespuestasTestVocacional>();
        }

        public int IdTestVocacional { get; set; }
        public int IdProtagonista { get; set; }
        public string Codigo { get; set; }
        public string Estado { get; set; }
        public DateTime FechaGrabacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public virtual TbProtagonista IdProtagonistaNavigation { get; set; }
        public virtual ICollection<TbRespuestasTestVocacional> TbRespuestasTestVocacionals { get; set; }
    }
}
