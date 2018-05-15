namespace Intranet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class criacaoGrupoAcesso : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GrupoAcessoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        descricao = c.String(),
                        isAtivo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GrupoAcessoes");
        }
    }
}
