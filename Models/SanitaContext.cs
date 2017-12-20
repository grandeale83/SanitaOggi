using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SanitaOggi.Models;

namespace SanitaOggi.Models
{
    public class SanitaContext : DbContext
    {
        public SanitaContext(DbContextOptions<SanitaContext> options) : base(options)
        { }

        public DbSet<Struttura> Struttura { get; set; }
        public DbSet<TipoAmbulatorio> TipoAmbulatorio { get; set; }
        public DbSet<Ambulatorio> Ambulatorio { get; set; }
    }
}
