namespace ComputerShopSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditInModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PropertyValues", "Device_Id", "dbo.Devices");
            DropForeignKey("dbo.Devices", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Devices", new[] { "Category_Id" });
            DropIndex("dbo.PropertyValues", new[] { "Device_Id" });
            RenameColumn(table: "dbo.Devices", name: "Category_Id", newName: "CategoryId");
            AddColumn("dbo.PropertyValues", "CategoryID", c => c.Int(nullable: false));
            AlterColumn("dbo.Devices", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Devices", "CategoryId");
            CreateIndex("dbo.PropertyValues", "CategoryID");
            AddForeignKey("dbo.PropertyValues", "CategoryID", "dbo.Categories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Devices", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
            DropColumn("dbo.PropertyValues", "Device_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PropertyValues", "Device_Id", c => c.Int());
            DropForeignKey("dbo.Devices", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.PropertyValues", "CategoryID", "dbo.Categories");
            DropIndex("dbo.PropertyValues", new[] { "CategoryID" });
            DropIndex("dbo.Devices", new[] { "CategoryId" });
            AlterColumn("dbo.Devices", "CategoryId", c => c.Int());
            DropColumn("dbo.PropertyValues", "CategoryID");
            RenameColumn(table: "dbo.Devices", name: "CategoryId", newName: "Category_Id");
            CreateIndex("dbo.PropertyValues", "Device_Id");
            CreateIndex("dbo.Devices", "Category_Id");
            AddForeignKey("dbo.Devices", "Category_Id", "dbo.Categories", "Id");
            AddForeignKey("dbo.PropertyValues", "Device_Id", "dbo.Devices", "Id");
        }
    }
}
