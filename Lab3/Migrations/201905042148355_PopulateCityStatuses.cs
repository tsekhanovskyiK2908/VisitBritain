namespace Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCityStatuses : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO CityStatus (Name) VALUES ('Capital')");
            Sql(@"INSERT INTO CityStatus (Name) VALUES ('Culture Capital')");
            Sql(@"INSERT INTO CityStatus (Name) VALUES ('Millionare City')");
            Sql(@"INSERT INTO CityStatus (Name) VALUES ('Regional Center')");
            Sql(@"INSERT INTO CityStatus (Name) VALUES ('Industrial Center')");      
        }
        
        public override void Down()
        {
        }
    }
}
