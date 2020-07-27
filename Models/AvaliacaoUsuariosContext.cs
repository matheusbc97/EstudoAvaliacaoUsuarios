using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AvaliacaoUsuarios.Models
{
    public class AvaliacaoUsuariosContext : DbContext
    {
        public AvaliacaoUsuariosContext(): base("AvaliacaoUsuariosLocal") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Avaliation> Avaliations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DbContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}