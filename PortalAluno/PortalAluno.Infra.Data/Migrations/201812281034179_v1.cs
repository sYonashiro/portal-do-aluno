namespace PortalAluno.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Grade = c.Double(nullable: false),
                        CascadeMode = c.Int(nullable: false),
                        Student_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Student", t => t.Student_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Name_CascadeMode = c.Int(nullable: false),
                        Address_Country = c.String(),
                        Address_State = c.String(),
                        Address_City = c.String(),
                        Address_Neighborhood = c.String(),
                        Address_Street = c.String(),
                        Address_StreetNumber = c.Int(nullable: false),
                        Address_Building = c.String(),
                        Address_CascadeMode = c.Int(nullable: false),
                        Phone = c.String(),
                        Email = c.String(),
                        Email_CascadeMode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Classes", "Student_Id", "dbo.Student");
            DropIndex("dbo.Classes", new[] { "Student_Id" });
            DropTable("dbo.Student");
            DropTable("dbo.Classes");
        }
    }
}
