using System;
using System.Collections.Generic;
using System.Linq;
using HolaMundoORM.Database;
using HolaMundoORM.Models;

namespace HolaMundoORM
{
    class Program
    {
        static void Main(string[] args)
        {
           HolaMundoORM holaMundoORM = new HolaMundoORM();

           holaMundoORM.LeerProcedimiento();
        }
    }
}
