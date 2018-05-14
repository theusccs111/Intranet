namespace Intranet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editUsuario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "nome", c => c.String());
            AddColumn("dbo.Usuarios", "email", c => c.String());
            AddColumn("dbo.Usuarios", "telefone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "telefone");
            DropColumn("dbo.Usuarios", "email");
            DropColumn("dbo.Usuarios", "nome");
        }
    }
}
