namespace ComputerShopSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTables : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT[dbo].[Properties] ON");
            Sql("INSERT INTO[dbo].[Properties]([Id], [PropertyDescription]) VALUES(1, N'HD')");
            Sql("INSERT INTO[dbo].[Properties] ([Id], [PropertyDescription]) VALUES(2, N'Processor')");
            Sql("INSERT INTO[dbo].[Properties] ([Id], [PropertyDescription]) VALUES(3, N'Dimensions')");
            Sql("INSERT INTO[dbo].[Properties] ([Id], [PropertyDescription]) VALUES(4, N'MAC Address')");
            Sql("INSERT INTO[dbo].[Properties] ([Id], [PropertyDescription]) VALUES(5, N'Allow USB')");
            Sql("INSERT INTO[dbo].[Properties] ([Id], [PropertyDescription]) VALUES(6, N'Current User')");
            Sql("INSERT INTO[dbo].[Properties] ([Id], [PropertyDescription]) VALUES(7, N'Network Speed')");
            Sql("INSERT INTO[dbo].[Properties] ([Id], [PropertyDescription]) VALUES(8, N'Operationg System')");
            Sql("INSERT INTO[dbo].[Properties] ([Id], [PropertyDescription]) VALUES(9, N'Ports')");
            Sql("INSERT INTO[dbo].[Properties] ([Id], [PropertyDescription]) VALUES(10, N'IP Adress')");
            Sql("INSERT INTO[dbo].[Properties] ([Id], [PropertyDescription]) VALUES(11, N'Is Color')");
            Sql("INSERT INTO[dbo].[Properties] ([Id], [PropertyDescription]) VALUES(12, N'Brand')");
            Sql("INSERT INTO[dbo].[Properties] ([Id], [PropertyDescription]) VALUES(13, N'Ram')");
            Sql("INSERT INTO[dbo].[Properties] ([Id], [PropertyDescription]) VALUES(14, N'Display')");
            Sql("INSERT INTO[dbo].[Properties] ([Id], [PropertyDescription]) VALUES(15, N'Current User')");
            Sql("SET IDENTITY_INSERT[dbo].[Properties] OFF");

            Sql("SET IDENTITY_INSERT[dbo].[Categories] ON");
            Sql("INSERT INTO [dbo].[Categories] ([Id], [Name]) VALUES (1, N'Printer')");
            Sql("INSERT INTO [dbo].[Categories] ([Id], [Name]) VALUES (2, N'Laptop')");
            Sql("INSERT INTO [dbo].[Categories] ([Id], [Name]) VALUES (3, N'Switch')");
            Sql("SET IDENTITY_INSERT[dbo].[Categories] OFF");

            Sql("SET IDENTITY_INSERT[dbo].[CategoryProperties] ON");
            Sql("INSERT INTO [dbo].[CategoryProperties] ([Id], [PropertyID], [CategoryID]) VALUES (1, 10, 1)");
            Sql("INSERT INTO [dbo].[CategoryProperties] ([Id], [PropertyID], [CategoryID]) VALUES (2, 11, 1)");
            Sql("INSERT INTO [dbo].[CategoryProperties] ([Id], [PropertyID], [CategoryID]) VALUES (3, 12, 1)");
            Sql("INSERT INTO [dbo].[CategoryProperties] ([Id], [PropertyID], [CategoryID]) VALUES (4, 2, 2)");
            Sql("INSERT INTO [dbo].[CategoryProperties] ([Id], [PropertyID], [CategoryID]) VALUES (5, 1, 2)");
            Sql("INSERT INTO [dbo].[CategoryProperties] ([Id], [PropertyID], [CategoryID]) VALUES (6, 13, 2)");
            Sql("INSERT INTO [dbo].[CategoryProperties] ([Id], [PropertyID], [CategoryID]) VALUES (7, 14, 2)");
            Sql("INSERT INTO [dbo].[CategoryProperties] ([Id], [PropertyID], [CategoryID]) VALUES (9, 10, 2)");
            Sql("INSERT INTO [dbo].[CategoryProperties] ([Id], [PropertyID], [CategoryID]) VALUES (10, 12, 2)");
            Sql("INSERT INTO [dbo].[CategoryProperties] ([Id], [PropertyID], [CategoryID]) VALUES (11, 9, 3)");
            Sql("INSERT INTO [dbo].[CategoryProperties] ([Id], [PropertyID], [CategoryID]) VALUES (12, 7, 3)");
            Sql("INSERT INTO [dbo].[CategoryProperties] ([Id], [PropertyID], [CategoryID]) VALUES (14, 10, 3)");
            Sql("INSERT INTO [dbo].[CategoryProperties] ([Id], [PropertyID], [CategoryID]) VALUES (15, 12, 3)");
            Sql("INSERT INTO [dbo].[CategoryProperties] ([Id], [PropertyID], [CategoryID]) VALUES (16, 15, 2)");
            Sql("SET IDENTITY_INSERT[dbo].[CategoryProperties] OFF");
        }
        
        public override void Down()
        {
        }
    }
}
