using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TallerMecanico.Models
{
    public class TallerContext : DbContext
    {
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Automovil> Automoviles { get; set; }

        public DbSet<Repuesto> Repuestos { get; set; }
        //public object Marca { get; internal set; }
    }
}

