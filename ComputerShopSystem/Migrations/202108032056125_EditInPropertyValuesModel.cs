namespace ComputerShopSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditInPropertyValuesModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PropertyValues", "Property_Id", "dbo.Properties");
            DropIndex("dbo.PropertyValues", new[] { "Property_Id" });
            RenameColumn(table: "dbo.PropertyValues", name: "Property_Id", newName: "PropertyID");
            AlterColumn("dbo.PropertyValues", "PropertyID", c => c.Int(nullable: false));
            CreateIndex("dbo.PropertyValues", "PropertyID");
            AddForeignKey("dbo.PropertyValues", "PropertyID", "dbo.Properties", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PropertyValues", "PropertyID", "dbo.Properties");
            DropIndex("dbo.PropertyValues", new[] { "PropertyID" });
            AlterColumn("dbo.PropertyValues", "PropertyID", c => c.Int());
            RenameColumn(table: "dbo.PropertyValues", name: "PropertyID", newName: "Property_Id");
            CreateIndex("dbo.PropertyValues", "Property_Id");
            AddForeignKey("dbo.PropertyValues", "Property_Id", "dbo.Properties", "Id");
        }
    }
}
