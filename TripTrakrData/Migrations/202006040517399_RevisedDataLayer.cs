namespace TripTrakrData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RevisedDataLayer : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Person", "YearMet");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Person", "YearMet", c => c.DateTime(nullable: false));
        }
    }
}
