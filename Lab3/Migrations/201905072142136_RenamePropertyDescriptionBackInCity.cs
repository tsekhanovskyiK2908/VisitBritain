namespace Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamePropertyDescriptionBackInCity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cities", "Description", c => c.String(nullable: false));
            DropColumn("dbo.Cities", "PathToDescription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cities", "PathToDescription", c => c.String(nullable: false));
            DropColumn("dbo.Cities", "Description");
        }
    }
}
