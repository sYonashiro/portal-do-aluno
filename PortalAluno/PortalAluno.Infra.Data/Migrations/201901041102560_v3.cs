namespace PortalAluno.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Classes", newName: "Class");
            DropColumn("dbo.Class", "CascadeMode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Class", "CascadeMode", c => c.Int(nullable: false));
            RenameTable(name: "dbo.Class", newName: "Classes");
        }
    }
}
