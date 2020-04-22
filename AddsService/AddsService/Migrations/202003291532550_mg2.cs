namespace AddsService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        Description = c.String(),
                        Image1 = c.Binary(),
                        Image2 = c.Binary(),
                        Image3 = c.Binary(),
                        SellarName = c.String(),
                        SellarContact = c.String(),
                        sellarAddress = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Brand = c.String(),
                        Price = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        Fuel = c.String(),
                        Description = c.String(),
                        Image1 = c.Binary(),
                        Image2 = c.Binary(),
                        Image3 = c.Binary(),
                        SellarName = c.String(),
                        SellarContact = c.String(),
                        SellarAddress = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategotyId = c.Int(nullable: false, identity: true),
                        Categoryname = c.String(),
                    })
                .PrimaryKey(t => t.CategotyId);
            
            CreateTable(
                "dbo.Electronics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        Model = c.String(),
                        Price = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        Color = c.String(),
                        Description = c.String(),
                        Image1 = c.Binary(),
                        Image2 = c.Binary(),
                        Image3 = c.Binary(),
                        SellarName = c.String(),
                        SellarContact = c.String(),
                        SellarAddress = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Image",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        image = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Image");
            DropTable("dbo.Electronics");
            DropTable("dbo.Categories");
            DropTable("dbo.Cars");
            DropTable("dbo.Books");
        }
    }
}
