namespace ComputerShopSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditInDeviceModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Devices", "AcquisitionDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Devices", "AcquisitionDate", c => c.DateTime());
        }
    }
}
