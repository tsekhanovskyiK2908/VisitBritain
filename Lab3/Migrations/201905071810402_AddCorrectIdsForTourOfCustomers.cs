namespace Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCorrectIdsForTourOfCustomers : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.TourOfCustomers");
            AlterColumn("dbo.TourOfCustomers", "Id", c => c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"));
            AddPrimaryKey("dbo.TourOfCustomers", "Id");
        }

        public override void Down()
        {
        }
    }
}
