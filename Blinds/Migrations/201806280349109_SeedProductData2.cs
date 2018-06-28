namespace Blinds.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedProductData2 : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                SET IDENTITY_INSERT [dbo].[Products] ON 
                INSERT INTO [dbo].[Products] ([Id], [Name], [Price], [BrandId], [ImageUrl]) VALUES(12, 'Blackout Cellular Shade',50.99,2,'')
                INSERT INTO [dbo].[Products] ([Id], [Name], [Price], [BrandId], [ImageUrl]) VALUES(13, '2 Inch Economy Faux Wood Blind',16.79,2,'')
                INSERT INTO [dbo].[Products] ([Id], [Name], [Price], [BrandId], [ImageUrl]) VALUES(14, 'Signature Blackout Roller Shade',23.24 ,2,'')
                INSERT INTO [dbo].[Products] ([Id], [Name], [Price], [BrandId], [ImageUrl]) VALUES(15, 'Vinyl Vertical Blind',36.59,4,'')
                INSERT INTO [dbo].[Products] ([Id], [Name], [Price], [BrandId], [ImageUrl]) VALUES(16, '2 Inch Deluxe Wood Blind',41.59,2,'')

                SET IDENTITY_INSERT [dbo].[Products] OFF 
            ");
        }
        
        public override void Down()
        {
            Sql(@"
                DELETE FROM [dbo].[Products] WHERE [Id] BETWEEN 12 AND 16
            ");
        }
    }
}
