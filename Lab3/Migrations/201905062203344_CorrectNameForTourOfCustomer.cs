namespace Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectNameForTourOfCustomer : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ToursOfCustomers", newName: "TourOfCustomers");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.TourOfCustomers", newName: "ToursOfCustomers");
        }
    }
}
