namespace Blinds.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedBrandData : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                SET IDENTITY_INSERT [dbo].[Brands] ON 

                INSERT INTO [dbo].[Brands] ([Id], [Name]) VALUES(1, 'Bali')
                INSERT INTO [dbo].[Brands] ([Id], [Name]) VALUES(2, 'Blinds.com')
                INSERT INTO [dbo].[Brands] ([Id], [Name]) VALUES(3, 'Norman')

                SET IDENTITY_INSERT [dbo].[Brands] OFF 
            ");
        }
        
        public override void Down()
        {
            Sql(@"
                DELETE FROM INSERT INTO [dbo].[Brands] WHERE [Id] IN (1,2,3)
            ");
        }
    }
}
