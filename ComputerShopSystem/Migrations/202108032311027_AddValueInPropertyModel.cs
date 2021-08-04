namespace ComputerShopSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValueInPropertyModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PropertyValues", "Values", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PropertyValues", "Values");
        }
    }
}
