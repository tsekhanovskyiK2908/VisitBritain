namespace Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveToursOfCustomersFromIdentityModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TourOfCustomers", "Customer_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.TourOfCustomers", "TourId", "dbo.Tours");
            DropIndex("dbo.TourOfCustomers", new[] { "TourId" });
            DropIndex("dbo.TourOfCustomers", new[] { "Customer_Id" });
            DropTable("dbo.TourOfCustomers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TourOfCustomers",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        CustomerId = c.Guid(nullable: false),
                        TourId = c.Guid(nullable: false),
                        SoldDate = c.DateTime(nullable: false),
                        Customer_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.TourOfCustomers", "Customer_Id");
            CreateIndex("dbo.TourOfCustomers", "TourId");
            AddForeignKey("dbo.TourOfCustomers", "TourId", "dbo.Tours", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TourOfCustomers", "Customer_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
