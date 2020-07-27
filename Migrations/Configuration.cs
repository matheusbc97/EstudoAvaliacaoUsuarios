namespace AvaliacaoUsuarios.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AvaliacaoUsuarios.Models.AvaliacaoUsuariosContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AvaliacaoUsuarios.Models.AvaliacaoUsuariosContext";
        }

        protected override void Seed(AvaliacaoUsuarios.Models.AvaliacaoUsuariosContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
