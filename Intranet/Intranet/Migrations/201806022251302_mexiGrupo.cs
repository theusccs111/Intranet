namespace Intranet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mexiGrupo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GrupoAcessoes", "descricao", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GrupoAcessoes", "descricao", c => c.String());
        }
    }
}
