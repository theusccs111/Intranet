namespace Intranet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MudancaManytoMany : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UsuarioGrupoAcessoes",
                c => new
                    {
                        Usuario_id = c.Int(nullable: false),
                        GrupoAcesso_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Usuario_id, t.GrupoAcesso_id })
                .ForeignKey("dbo.Usuarios", t => t.Usuario_id, cascadeDelete: true)
                .ForeignKey("dbo.GrupoAcessoes", t => t.GrupoAcesso_id, cascadeDelete: true)
                .Index(t => t.Usuario_id)
                .Index(t => t.GrupoAcesso_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsuarioGrupoAcessoes", "GrupoAcesso_id", "dbo.GrupoAcessoes");
            DropForeignKey("dbo.UsuarioGrupoAcessoes", "Usuario_id", "dbo.Usuarios");
            DropIndex("dbo.UsuarioGrupoAcessoes", new[] { "GrupoAcesso_id" });
            DropIndex("dbo.UsuarioGrupoAcessoes", new[] { "Usuario_id" });
            DropTable("dbo.UsuarioGrupoAcessoes");
        }
    }
}
