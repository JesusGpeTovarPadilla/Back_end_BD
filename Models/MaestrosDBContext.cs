using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Back_end_BD.Models
{
    public class MaestrosDBContext: DbContext
    {
        private static string connection2 = "MaestroConnection";
        public MaestrosDBContext() : base(connection2)
        {

        }
        public DbSet<Maestros> Maestros { get; set; }
    }
}