namespace TripTrakrData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedTripProperties : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Trip", "CountryName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trip", "CountryName", c => c.String());
        }
    }
}
