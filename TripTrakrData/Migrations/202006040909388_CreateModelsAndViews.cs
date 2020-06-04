namespace TripTrakrData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateModelsAndViews : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Place", "Trip_TripId", c => c.Int());
            CreateIndex("dbo.Place", "Trip_TripId");
            AddForeignKey("dbo.Place", "Trip_TripId", "dbo.Trip", "TripId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Place", "Trip_TripId", "dbo.Trip");
            DropIndex("dbo.Place", new[] { "Trip_TripId" });
            DropColumn("dbo.Place", "Trip_TripId");
        }
    }
}
