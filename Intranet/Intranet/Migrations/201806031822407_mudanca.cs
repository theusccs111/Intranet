namespace Intranet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mudanca : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DescProduto = c.String(nullable: false),
                        Peso = c.Single(nullable: false),
                        Valor = c.Single(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        DataCompra = c.DateTime(nullable: false),
                        DataVencimento = c.DateTime(nullable: false),
                        isAtivo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.GrupoAcessoes", "descricao", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GrupoAcessoes", "descricao", c => c.String());
            DropTable("dbo.Produtoes");
        }
    }
}
