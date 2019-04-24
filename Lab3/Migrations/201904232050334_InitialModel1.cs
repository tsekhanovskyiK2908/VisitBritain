namespace Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Tours");
            DropPrimaryKey("dbo.ToursOfCustomers");
            AlterColumn("dbo.Tours", "Id", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.ToursOfCustomers", "Id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.Tours", "Id");
            AddPrimaryKey("dbo.ToursOfCustomers", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.ToursOfCustomers");
            DropPrimaryKey("dbo.Tours");
            AlterColumn("dbo.ToursOfCustomers", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.Tours", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.ToursOfCustomers", "Id");
            AddPrimaryKey("dbo.Tours", "Id");
        }
    }
}
