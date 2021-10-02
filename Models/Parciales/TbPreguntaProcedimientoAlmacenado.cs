using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Models
{
    public partial class TbPreguntaProcedimientoAlmacenado
    {

        [Key]
        public int Id_Pregunta { get; set; }
        public int Id_Rubro { get; set; }
        public short Numero { get; set; }
        public string Pregunta { get; set; }
        public short Puntaje { get; set; }
        public bool? Estado { get; set; }
        public int Usuario_Grabacion { get; set; }
        public DateTime Fecha_Grabacion { get; set; }
        public int Usuario_Modificacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }


    }
}
