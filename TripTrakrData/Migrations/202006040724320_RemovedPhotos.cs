namespace TripTrakrData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedPhotos : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Photo", "PlaceId", "dbo.Place");
            DropIndex("dbo.Photo", new[] { "PlaceId" });
            AlterColumn("dbo.Person", "LastName", c => c.String(nullable: false));
            DropTable("dbo.Photo");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Photo",
                c => new
                    {
                        PhotoId = c.Int(nullable: false, identity: true),
                        PhotoUrl = c.String(nullable: false),
                        PhotoCaption = c.String(),
                        PlaceId = c.Int(nullable: false),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.PhotoId);
            
            AlterColumn("dbo.Person", "LastName", c => c.String());
            CreateIndex("dbo.Photo", "PlaceId");
            AddForeignKey("dbo.Photo", "PlaceId", "dbo.Place", "PlaceId", cascadeDelete: true);
        }
    }
}
