namespace ComputerShopSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PropertyValues", "CategoryID", "dbo.Categories");
            DropIndex("dbo.PropertyValues", new[] { "CategoryID" });
            AddColumn("dbo.PropertyValues", "DeviceID", c => c.Int(nullable: false));
            CreateIndex("dbo.PropertyValues", "DeviceID");
            AddForeignKey("dbo.PropertyValues", "DeviceID", "dbo.Devices", "Id", cascadeDelete: true);
            DropColumn("dbo.PropertyValues", "CategoryID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PropertyValues", "CategoryID", c => c.Int(nullable: false));
            DropForeignKey("dbo.PropertyValues", "DeviceID", "dbo.Devices");
            DropIndex("dbo.PropertyValues", new[] { "DeviceID" });
            DropColumn("dbo.PropertyValues", "DeviceID");
            CreateIndex("dbo.PropertyValues", "CategoryID");
            AddForeignKey("dbo.PropertyValues", "CategoryID", "dbo.Categories", "Id", cascadeDelete: true);
        }
    }
}
