namespace ComputerShopSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameDevicePropertyAttrbuite : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DeviceProperties", "Value", c => c.String(nullable: false));
            DropColumn("dbo.DeviceProperties", "Values");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DeviceProperties", "Values", c => c.String());
            DropColumn("dbo.DeviceProperties", "Value");
        }
    }
}
