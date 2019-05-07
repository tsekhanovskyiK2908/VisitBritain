namespace Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerAndTourFieldsToToursOfCustomers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TourOfCustomers", "Customer_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.TourOfCustomers", "TourId");
            CreateIndex("dbo.TourOfCustomers", "Customer_Id");
            AddForeignKey("dbo.TourOfCustomers", "Customer_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.TourOfCustomers", "TourId", "dbo.Tours", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TourOfCustomers", "TourId", "dbo.Tours");
            DropForeignKey("dbo.TourOfCustomers", "Customer_Id", "dbo.AspNetUsers");
            DropIndex("dbo.TourOfCustomers", new[] { "Customer_Id" });
            DropIndex("dbo.TourOfCustomers", new[] { "TourId" });
            DropColumn("dbo.TourOfCustomers", "Customer_Id");
        }
    }
}
