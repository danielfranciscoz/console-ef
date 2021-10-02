using System;
using System.Collections.Generic;

#nullable disable

namespace HolaMundoORM.Models
{
    public partial class TbErrorTest
    {
        public int IdError { get; set; }
        public int ErrorNumber { get; set; }
        public int ErrorSeverity { get; set; }
        public int ErrorState { get; set; }
        public string ErrorProcedure { get; set; }
        public int ErrorLine { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime FechaError { get; set; }
    }
}
