namespace TripTrakrData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCountryNameToTrip : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trip", "CountryName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Trip", "CountryName");
        }
    }
}
