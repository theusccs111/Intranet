namespace Intranet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ManytoManyUsuarioGrupo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UsuarioAcessoes",
                c => new
                    {
                        IdGrupoAcesso = c.Int(nullable: false),
                        IdUsuario = c.Int(nullable: false),
                        grupo_id = c.Int(),
                        usuario_id = c.Int(),
                    })
                .PrimaryKey(t => new { t.IdGrupoAcesso, t.IdUsuario })
                .ForeignKey("dbo.GrupoAcessoes", t => t.grupo_id)
                .ForeignKey("dbo.Usuarios", t => t.usuario_id)
                .Index(t => t.grupo_id)
                .Index(t => t.usuario_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsuarioAcessoes", "usuario_id", "dbo.Usuarios");
            DropForeignKey("dbo.UsuarioAcessoes", "grupo_id", "dbo.GrupoAcessoes");
            DropIndex("dbo.UsuarioAcessoes", new[] { "usuario_id" });
            DropIndex("dbo.UsuarioAcessoes", new[] { "grupo_id" });
            DropTable("dbo.UsuarioAcessoes");
        }
    }
}
