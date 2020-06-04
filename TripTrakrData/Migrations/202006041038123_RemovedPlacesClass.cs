namespace TripTrakrData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedPlacesClass : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Place", "CountryId", "dbo.Country");
            DropForeignKey("dbo.Place", "Trip_TripId", "dbo.Trip");
            DropIndex("dbo.Place", new[] { "CountryId" });
            DropIndex("dbo.Place", new[] { "Trip_TripId" });
            AddColumn("dbo.Trip", "Places", c => c.String());
            DropColumn("dbo.Trip", "SitesDescription");
            DropTable("dbo.Place");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Place",
                c => new
                    {
                        PlaceId = c.Int(nullable: false, identity: true),
                        PlaceName = c.String(nullable: false),
                        CountryId = c.Int(nullable: false),
                        UserId = c.Guid(nullable: false),
                        Trip_TripId = c.Int(),
                    })
                .PrimaryKey(t => t.PlaceId);
            
            AddColumn("dbo.Trip", "SitesDescription", c => c.String());
            DropColumn("dbo.Trip", "Places");
            CreateIndex("dbo.Place", "Trip_TripId");
            CreateIndex("dbo.Place", "CountryId");
            AddForeignKey("dbo.Place", "Trip_TripId", "dbo.Trip", "TripId");
            AddForeignKey("dbo.Place", "CountryId", "dbo.Country", "CountryId", cascadeDelete: true);
        }
    }
}
