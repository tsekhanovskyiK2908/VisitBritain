namespace Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTours2 : DbMigration
    {
        public override void Up()
        {
            Sql($@"INSERT INTO Tours (Id, Name, DepartureCity, DepartureDate, ArrivalCity, ArrivalDate, Price, PlaceNumber) 
            VALUES('{new Guid()}','Amazing London', 'Warshaw', 29/04/2019, 'London', 01/05/2019, 555, 4)");          
        }
        
        public override void Down()
        {
        }
    }
}
