namespace Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReturnBackToursOfCustomersToIdentityModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TourOfCustomers",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        CustomerId = c.String(nullable: false, maxLength: 128),
                        TourId = c.Guid(nullable: false),
                        SoldDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Tours", t => t.TourId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.TourId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TourOfCustomers", "TourId", "dbo.Tours");
            DropForeignKey("dbo.TourOfCustomers", "CustomerId", "dbo.AspNetUsers");
            DropIndex("dbo.TourOfCustomers", new[] { "TourId" });
            DropIndex("dbo.TourOfCustomers", new[] { "CustomerId" });
            DropTable("dbo.TourOfCustomers");
        }
    }
}
