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



            context.GrupoAcesso.AddOrUpdate(x => x.id,
       new GrupoAcesso() { id = 1, descricao = "administrador", isAtivo = true }
       );

            context.GrupoAcesso.AddOrUpdate(x => x.id,
       new GrupoAcesso() { id = 2, descricao = "cta", isAtivo = false }
       );
            context.Usuario.AddOrUpdate(x => x.id,
       new Usuario() { id = 1, login = "admin", senha = "451278", grupos = { context.GrupoAcesso.Find(1) } }
       );

            context.Usuario.AddOrUpdate(x => x.id,
       new Usuario() { id = 2, login = "teste", senha = "451278", grupos = { context.GrupoAcesso.Find(2) } }
       );

            context.Produto.AddOrUpdate(x => x.Id,
                     new Produto() { Id = 1, DescProduto = "Chave", isAtivo = true,DataCompra = new DateTime(2018,1,1),DataVencimento = new DateTime(2018,1,1),Peso = 1,Quantidade = 1,Valor = 1}
           );

            context.Produto.AddOrUpdate(x => x.Id,
                new Produto() { Id = 2, DescProduto = "Mesa", isAtivo = true, DataCompra = new DateTime(2018, 1, 1), DataVencimento = new DateTime(2018, 1, 1), Peso = 1, Quantidade = 1, Valor = 1 }
            );

            context.Produto.AddOrUpdate(x => x.Id,
                new Produto() { Id = 3, DescProduto = "Cadeira", isAtivo = true, DataCompra = new DateTime(2018, 1, 1), DataVencimento = new DateTime(2018, 1, 1), Peso = 1, Quantidade = 1, Valor = 1 }
            );


        }
    }
}
