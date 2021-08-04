namespace ComputerShopSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDeviceModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Devices", "SerialNo", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Devices", "SerialNo");
        }
    }
}
