namespace FlagChecker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration6changesharescountrytobytesinsteadofobject : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Countries", "Share_Uid", "dbo.Shares");
            DropIndex("dbo.Countries", new[] { "Share_Uid" });
            AddColumn("dbo.Shares", "Countries", c => c.Binary());
            DropColumn("dbo.Countries", "Share_Uid");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Countries", "Share_Uid", c => c.String(maxLength: 128));
            DropColumn("dbo.Shares", "Countries");
            CreateIndex("dbo.Countries", "Share_Uid");
            AddForeignKey("dbo.Countries", "Share_Uid", "dbo.Shares", "Uid");
        }
    }
}
