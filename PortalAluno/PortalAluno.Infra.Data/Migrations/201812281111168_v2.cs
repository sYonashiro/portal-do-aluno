namespace PortalAluno.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Student", name: "Address_Country", newName: "Country");
            RenameColumn(table: "dbo.Student", name: "Address_State", newName: "State");
            RenameColumn(table: "dbo.Student", name: "Address_City", newName: "City");
            RenameColumn(table: "dbo.Student", name: "Address_Neighborhood", newName: "Neighborhood");
            RenameColumn(table: "dbo.Student", name: "Address_Street", newName: "Street");
            RenameColumn(table: "dbo.Student", name: "Address_StreetNumber", newName: "StreetNumber");
            RenameColumn(table: "dbo.Student", name: "Address_Building", newName: "Building");
            DropColumn("dbo.Student", "Name_CascadeMode");
            DropColumn("dbo.Student", "Address_CascadeMode");
            DropColumn("dbo.Student", "Email_CascadeMode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Student", "Email_CascadeMode", c => c.Int(nullable: false));
            AddColumn("dbo.Student", "Address_CascadeMode", c => c.Int(nullable: false));
            AddColumn("dbo.Student", "Name_CascadeMode", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Student", name: "Building", newName: "Address_Building");
            RenameColumn(table: "dbo.Student", name: "StreetNumber", newName: "Address_StreetNumber");
            RenameColumn(table: "dbo.Student", name: "Street", newName: "Address_Street");
            RenameColumn(table: "dbo.Student", name: "Neighborhood", newName: "Address_Neighborhood");
            RenameColumn(table: "dbo.Student", name: "City", newName: "Address_City");
            RenameColumn(table: "dbo.Student", name: "State", newName: "Address_State");
            RenameColumn(table: "dbo.Student", name: "Country", newName: "Address_Country");
        }
    }
}
