namespace Blinds.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedProductData : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                SET IDENTITY_INSERT [dbo].[Products] ON 
                INSERT INTO [dbo].[Products] ([Id], [Name], [Price], [BrandId], [ImageUrl]) VALUES(1, 'DiamondCell Blackout Cellular Shade',60.74,1,'')
                INSERT INTO [dbo].[Products] ([Id], [Name], [Price], [BrandId], [ImageUrl]) VALUES(2, '1 Inch Mini Blind ',18.39,2,'')
                INSERT INTO [dbo].[Products] ([Id], [Name], [Price], [BrandId], [ImageUrl]) VALUES(3, '2 Inch Faux Wood Blind',22.49 ,2,'')
                INSERT INTO [dbo].[Products] ([Id], [Name], [Price], [BrandId], [ImageUrl]) VALUES(4, 'Woven Wood Shade',29.24,2,'')
                INSERT INTO [dbo].[Products] ([Id], [Name], [Price], [BrandId], [ImageUrl]) VALUES(5, 'Economy Blackout Roller Shade',31.19,2,'')
                INSERT INTO [dbo].[Products] ([Id], [Name], [Price], [BrandId], [ImageUrl]) VALUES(6, 'Signature Solar Roller Shade',33.74,2,'')
                INSERT INTO [dbo].[Products] ([Id], [Name], [Price], [BrandId], [ImageUrl]) VALUES(7, 'Light Filtering Cellular Shade',38.99,2,'')
                INSERT INTO [dbo].[Products] ([Id], [Name], [Price], [BrandId], [ImageUrl]) VALUES(8, '2 Inch Deluxe Wood Blind', 41.59,2,'')
                INSERT INTO [dbo].[Products] ([Id], [Name], [Price], [BrandId], [ImageUrl]) VALUES(9, 'Premier Roman Shade',58.09,2,'')
                INSERT INTO [dbo].[Products] ([Id], [Name], [Price], [BrandId], [ImageUrl]) VALUES(10, 'Premier Grommet Drapery',66.39,2,'')
                INSERT INTO [dbo].[Products] ([Id], [Name], [Price], [BrandId], [ImageUrl]) VALUES(11, 'Easy Classic Pleat Drapery',81.59,3,'')

                SET IDENTITY_INSERT [dbo].[Products] OFF 
            ");
        }
        
        public override void Down()
        {
            Sql(@"
                DELETE FROM [dbo].[Products] WHERE [Id] BETWEEN 1 AND 11
            ");
        }
    }
}
