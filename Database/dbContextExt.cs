using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using HolaMundoORM.Models;
using Models;
using System.Linq;
using System.Collections.Generic;

#nullable disable

namespace HolaMundoORM.Database
{
    public partial class dbContext
    {
       

        public virtual DbSet<TbPreguntaProcedimientoAlmacenado> tbPreguntaProcedimientoAlmacenado { get; set; }
      
        public List<TbPreguntaProcedimientoAlmacenado> ObtenerPreguntasProcedimiento(){
            return tbPreguntaProcedimientoAlmacenado.FromSqlRaw("EXECUTE sp_obtener_preguntas").ToList();
        }
    }
}
