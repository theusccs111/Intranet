namespace Intranet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Login : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "senha", c => c.String(nullable: false));
            AlterColumn("dbo.Usuarios", "login", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "login", c => c.String());
            DropColumn("dbo.Usuarios", "senha");
        }
    }
}
