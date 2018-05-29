namespace Intranet.Migrations
{
    using Intranet.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Intranet.Models.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Intranet.Models.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Usuario.AddOrUpdate(x => x.id,
       new Usuario() { id = 1, login = "admin", senha = "451278" }
       );

            context.GrupoAcesso.AddOrUpdate(x => x.id,
       new GrupoAcesso() { id = 1, descricao = "administrador", isAtivo = true }
       );
        }
    }
}
