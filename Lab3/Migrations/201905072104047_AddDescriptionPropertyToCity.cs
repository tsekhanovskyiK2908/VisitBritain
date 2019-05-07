namespace Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDescriptionPropertyToCity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cities", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cities", "Description");
        }
    }
}
