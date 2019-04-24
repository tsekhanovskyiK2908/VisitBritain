namespace Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1cc37121-640c-44e4-8051-540cd6248868', N'admin@visitBritain.net', 0, N'AJhcCGz6bPg6x9OI9Z3NS2cGTB8w9xi1cy81/mHzn2WDfmBXnyQpQGrO+c8z0icjcw==', N'bf3d2ddb-8553-4378-ae30-ff1374f206a8', NULL, 0, 0, NULL, 1, 0, N'admin@visitBritain.net')");
            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6c94edd7-e347-422e-8b55-19cc9c2348c5', N'CanManageToursAndUsers')");
            Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1cc37121-640c-44e4-8051-540cd6248868', N'6c94edd7-e347-422e-8b55-19cc9c2348c5')");
        }
        
        public override void Down()
        {
        }
    }
}
