namespace Blinds.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedBrandData2 : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                SET IDENTITY_INSERT [dbo].[Brands] ON 

                INSERT INTO [dbo].[Brands] ([Id], [Name]) VALUES(4, 'Levolor')

                SET IDENTITY_INSERT [dbo].[Brands] OFF 
            ");
        }
        
        public override void Down()
        {
            Sql(@"
                DELETE FROM INSERT INTO [dbo].[Brands] WHERE [Id] = 4
            ");
        }
    }
}
