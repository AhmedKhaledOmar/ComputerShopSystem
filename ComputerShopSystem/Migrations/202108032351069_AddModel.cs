namespace ComputerShopSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoryProperties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PropertyID = c.Int(nullable: false),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.Properties", t => t.PropertyID, cascadeDelete: true)
                .Index(t => t.PropertyID)
                .Index(t => t.CategoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CategoryProperties", "PropertyID", "dbo.Properties");
            DropForeignKey("dbo.CategoryProperties", "CategoryID", "dbo.Categories");
            DropIndex("dbo.CategoryProperties", new[] { "CategoryID" });
            DropIndex("dbo.CategoryProperties", new[] { "PropertyID" });
            DropTable("dbo.CategoryProperties");
        }
    }
}
