namespace Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropTableToursOfCustomers : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.TourOfCustomers");
        }
        
        public override void Down()
        {
        }
    }
}
